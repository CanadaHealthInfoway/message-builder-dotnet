/**
 * Copyright 2013 Canada Health Infoway, Inc.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *        http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 *
 * Author:        $LastChangedBy: tmcgrady $
 * Last modified: $LastChangedDate: 2013-03-01 18:48:17 -0400 (Fri, 01 Mar 2013) $
 * Revision:      $LastChangedRevision: 6663 $
 */

/// ---------------------------------------------------------------------------------------------------
///  This file was automatically generated by J2CS Translator (http://j2cstranslator.sourceforge.net/). 
///  Version 1.0.0                                                                                      
/// ---------------------------------------------------------------------------------------------------
 
namespace Ca.Infoway.Messagebuilder.Terminology.Codeset {
	
	using Ca.Infoway.Messagebuilder;
	using Ca.Infoway.Messagebuilder.Terminology.Codeset.Dao;
	using Ca.Infoway.Messagebuilder.Terminology.Codeset.Domain;
	using Ca.Infoway.Messagebuilder.Terminology.Proxy;
	using ILOG.J2CsMapping.Util;
	//!using Org.Apache.Commons.Lang.Time;
	using NHibernate;
	using NHibernate.Cfg;
	using Spring.Data.NHibernate; //! Spring.Orm.Hibernate3;
	using System;
	using System.Collections;
	using System.Collections.Generic;
	//using System.ComponentModel;
	using System.IO;
	using System.Runtime.CompilerServices;
	
	/// <summary>
	/// A class to run some performance measures on database-based c resolution.
	/// </summary>
	///
	public class PerformanceTester {
	
		private ISessionFactory factory;
		private CodeSetDao dao;
		private DatabaseCodeResolver resolver;
	    private static readonly String VERSION = "VERSION";
	
		public PerformanceTester(bool useSecondLevelCache) {
			CreateDao(useSecondLevelCache);
			this.resolver = new DatabaseCodeResolver(this.dao,
					new TypedCodeFactory(), VERSION);
		}
	
		public static void Main(String[] args) {
			IList<String> codes = ReadSampleCodes();
	
			bool cache = false;
			for (int i = 0; i < 10; i++) {
				PerformanceTester tester = new PerformanceTester(cache);
				tester.Run(codes);
				cache = !cache;
			}
		}
	
		/* @SuppressWarnings("unchecked")*/
		private static IList<String> ReadSampleCodes() {
			Stream input = typeof(PerformanceTester).Assembly.GetFile("sampleCodes.txt");
			try {
				return IOUtils.ReadLines(input);
			} finally {
				IOUtils.CloseQuietly(input);
			}
		}
	
		private void Run(IList<String> codes) {
			OpenSession();
	
			StopWatch stopWatch = new StopWatch();
			stopWatch.Start();
	
			for (int i = 0, length = 1000; i < length; i++) {
				if (i % 50 == 0) {
					ResetSession();
				}
				LookupCodes(codes);
			}
	
			stopWatch.Stop();
			CloseSession();
	
			System.Console.Out.WriteLine(stopWatch.GetTime());
		}
	
		/* @SuppressWarnings("unchecked")*/
		private void LookupCodes(IList<String> codes) {
			for (int i = 0, length = codes.Count; i < length; i++) {
				String line = codes[i];
				String[] words = Ca.Infoway.Messagebuilder.StringUtils.Split(line);
				if (Ca.Infoway.Messagebuilder.StringUtils.IsNotBlank(line)
						&& Ca.Infoway.Messagebuilder.ArrayUtils.GetLength(words) == 3) {
					try {
						Type c = (Type) ILOG.J2CsMapping.Reflect.Helper.GetNativeType("ca.infoway.messagebuilder.domainvalue."
															+ words[0]);
						this.resolver.Lookup<Code>(c, words[1], words[2]);
					} catch (TypeLoadException e) {
						System.Console.Out.WriteLine(words[0]
								+ " cannot be resolved to a Code type");
					}
				}
			}
		}
	
		private void ResetSession() {
			CloseSession();
			OpenSession();
		}
	
		private void OpenSession() {
			ISession session = this.factory.OpenSession();
			Spring.Transaction.Support.TransactionSynchronizationManager.BindResource(this.factory,
					new SessionHolder(session));
		}
	
		private void CloseSession() {
			SessionHolder holder = (SessionHolder) Spring.Transaction.Support.TransactionSynchronizationManager
					.GetResource(this.factory);
			ISession session = holder.Session;
			Spring.Transaction.Support.TransactionSynchronizationManager.UnbindResource(this.factory);
			session.Close();
		}
	
		public Properties CreateProperties(bool cache) {
			Properties properties = new Properties();
			properties.SetProperty("hibernate.connection.url",
					"jdbc:postgresql://127.0.0.1:5432/chi");
			properties.SetProperty("hibernate.connection.username", "postgres");
			properties.SetProperty("hibernate.connection.password", "password");
			properties.SetProperty("hibernate.connection.driver_class",
					"org.postgresql.Driver");
			properties.SetProperty("hibernate.dialect",
					"org.hibernate.dialect.PostgreSQLDialect");
	
			properties.SetProperty("hibernate.cache.provider_class",
					"org.hibernate.cache.HashtableCacheProvider");
			properties.SetProperty("hibernate.cache.use_second_level_cache",
					(cache) ? "true" : "false");
			properties.SetProperty("hibernate.cache.use_query_cache",
					(cache) ? "true" : "false");
			return properties;
		}
	
		public void CreateDao(bool secondLevelCache) {

			Configuration configuration = new Configuration();
            
			configuration.SetNamingStrategy(ImprovedNamingStrategy.Instance);
			configuration.Properties = (IDictionary<string, string>) CreateProperties(secondLevelCache);
			configuration.AddClass(typeof(VocabularyDomain));
			configuration.AddClass(typeof(CodeSystem));
			configuration.AddClass(typeof(CodedValue));
			configuration.AddClass(typeof(ValueSet));
			configuration.AddClass(typeof(ValueSetEntry));
	
			this.factory = configuration.BuildSessionFactory();
			this.dao = new HibernateCodeSetDao(this.factory);
		}
	
	}
}