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
 * Last modified: $LastChangedDate: 2011-05-17 11:48:36 -0400 (Tue, 17 May 2011) $
 * Revision:      $LastChangedRevision: 2666 $
 */

/// ---------------------------------------------------------------------------------------------------
///  This file was automatically generated by J2CS Translator (http://j2cstranslator.sourceforge.net/). 
///  Version 1.0.0                                                                                      
/// ---------------------------------------------------------------------------------------------------
 
namespace Ca.Infoway.Messagebuilder.Terminology {

    using System;
    using Ca.Infoway.Messagebuilder;
	using NUnit;
	using NUnit.Framework;
	
	[TestFixture]
	public class TrivialCodeResolverTest {
	
		private static readonly String CODESYSTEM = "CODESYSTEM";
		private static readonly String CODE = "CODE";
	
		[Test]
		public void TestResolveCodeWithCodeAndCodeSystem() {

			MockCharacters result = new TrivialCodeResolver().Lookup<MockCharacters>(typeof(MockCharacters), CODE, CODESYSTEM);

			Assert.AreEqual(CODE,((Code) result).CodeValue,"result");
			Assert.AreEqual(CODESYSTEM,((Code) result).CodeSystem,"result");

		}
		
		[NUnit.Framework.Test]
		public void TestNullCode() {
			TrivialCodeResolver trivialCodeResolver = new TrivialCodeResolver();
			trivialCodeResolver.AddDomainValue(null, typeof(MockCharacters));
			
			Assert.IsNull(trivialCodeResolver.Lookup<MockCharacters>(typeof(MockCharacters), "foo", null), "null");
			trivialCodeResolver.AddDomainValue(new MockCharactersCode("foo"), typeof(MockCharacters));
			Assert.IsNotNull(trivialCodeResolver.Lookup<MockCharacters>(typeof(MockCharacters), "foo", null), "not null");
		}
	
		class MockCharactersCode : MockCharacters {
			string code;
			internal MockCharactersCode(string code) {
				this.code = code;
			}
			public string CodeValue {
				get {
					return code;
				}
			}
			public string CodeSystem {
				get {
					return null;
				}
			}
		}		
	
	}
}
