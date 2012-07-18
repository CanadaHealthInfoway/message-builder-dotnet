/**
 * Copyright 2012 Canada Health Infoway, Inc.
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
 * Last modified: $LastChangedDate: 2012-01-18 21:44:48 -0500 (Wed, 18 Jan 2012) $
 * Revision:      $LastChangedRevision: 4355 $
 */

/// ---------------------------------------------------------------------------------------------------
///  This file was automatically generated by J2CS Translator (http://j2cstranslator.sourceforge.net/). 
///  Version 1.0.0                                                                                      
/// ---------------------------------------------------------------------------------------------------
 
namespace Ca.Infoway.Messagebuilder.Service {
	
	using Ca.Infoway.Messagebuilder;
	using ILOG.J2CsMapping.Collections.Generics;
	using log4net;
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.ComponentModel;
	using System.IO;
	using System.Reflection;
	using System.Runtime.CompilerServices;
    using System.Net;
	
	/// <summary>
	/// A common practice for allowing configurable implementations of a service
	/// interface is to look for a file in the META-INF directory of a jar.  An example of 
	/// this problem is XML parsing.  There's an abstract factory type called
	/// DocumentBuilderFactory, and the expectation is that
	/// some component will provide a concrete implementation of this type.  
	/// The usual way of handling that is to look for a special file in the META-INF directory.
	/// The file is a simple text file that contains the fully-qualified name of an
	/// implementing class, and then the code can decide to pick one (or many) of those implementations.
	/// This class implements behaviour like that -- it looks for a set of resources
	/// on the classpath, named after a specific type, and finds the corresponding classes.
	/// </summary>
	///
	/// <param name="T"> - the interface type of the service</param>
	public abstract class ServiceFactory<T> {
	
		private ILog log;
		private readonly Type c;
	
		/// <summary>
		/// Standard constructor.
		/// </summary>
		///
		/// <param name="c_0">- the type of service that the factory finds</param>
		public ServiceFactory(Type c_0) {
            this.log = LogManager.GetLogger(GetType());
			this.c = c_0;
		}
	
        
		/// <summary>
		/// Create an instance of the service.
		/// </summary>
		///
		/// <returns>- the instance of the service.</returns>
		public virtual T Create() {
			try {
				IList<Uri> resources = ServiceImplementations;
				IList<T> services = GetServices(resources);
				return ChooseImplementationOfService(services);
			} catch (IOException e) {
				return CreateTrivialService();
			}
		}
	/**/
		/// <summary>
		/// Choose an implementation of a service, based on several options.
		/// </summary>
		///
		/// <returns>- the instance of the service.</returns>
		protected abstract T ChooseImplementationOfService(IList<T> services);
	
		/// <summary>
		/// Create a trivial service if no other option exists.
		/// </summary>
		///
		/// <returns>- the trivial service.</returns>
		protected abstract T CreateTrivialService();
	
		/* @SuppressWarnings("unchecked")*/
		protected virtual IList<T> GetServices(IList<Uri> resources) {
			IList<T> result = new List<T>();
			/* foreach */
			foreach (Uri url in resources) {
				String className = Read(url);
				if (Ca.Infoway.Messagebuilder.StringUtils.IsNotBlank(className)) {
					Type messageServiceClass = GetClass(className);
					if (messageServiceClass != null
							&& c.IsAssignableFrom(messageServiceClass)) {
						try {
							T service = (T) Activator.CreateInstance(messageServiceClass);
							ILOG.J2CsMapping.Collections.Generics.Collections.Add(result,service);
						} catch (TargetException e) {
							this.log
									.Warn(
											"Service "
													+ className
													+ " cannot be instantiated.  It will be ignored.",
											e);
						} catch (MemberAccessException e_0) {
							this.log
									.Warn(
											"Service "
													+ className
													+ " cannot be instantiated.  It will be ignored.",
											e_0);
						} catch (Exception e_1) {
							this.log
									.Warn(
											"Service "
													+ className
													+ " cannot be instantiated.  It will be ignored.",
											e_1);
						}
					} else {
						this.log.Warn("Service " + className
								+ " is not a valid service implementation.");
					}
				}
			}
			return result;
		}
	
		private Type GetClass(String className) {
			try {
				return ILOG.J2CsMapping.Reflect.Helper.GetNativeType(Ca.Infoway.Messagebuilder.StringUtils.Trim(className));
			} catch (TypeLoadException) {
				return null;
			} catch (ReflectionTypeLoadException) {
				return null;
			}
		}
	
		private String Read(Uri url) {
			Stream input = WebRequest.Create(url).GetResponse().GetResponseStream();
			try {
				return IOUtils.ToString(input);
			} finally {
				IOUtils.CloseQuietly(input);
			}
		}
	
		
		private IList<Uri> ServiceImplementations {
			get
		  	{
				var list = new List<Uri>();
              	//assuming there is text file under /Services folder with the class name
				String serviceImplementationPath = Path.Combine(
					Path.Combine(AssemblyLocationUtil.GetRoot(), "Services"),
				    c.FullName                                            
				);
				
				if (File.Exists(serviceImplementationPath)) 
				{
					list.Add(new Uri(serviceImplementationPath));
				}
		      
             	return list;
		  	}
		}
		
	}
}
