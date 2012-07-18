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
 * Last modified: $LastChangedDate: 2012-01-18 21:44:20 -0500 (Wed, 18 Jan 2012) $
 * Revision:      $LastChangedRevision: 4350 $
 */

/// ---------------------------------------------------------------------------------------------------
///  This file was automatically generated by J2CS Translator (http://j2cstranslator.sourceforge.net/). 
///  Version 1.0.0                                                                                      
/// ---------------------------------------------------------------------------------------------------
 
namespace Ca.Infoway.Messagebuilder.Util.Iterator {
	
	using NUnit;
    using System;
    using System.Collections.Generic;
	
	[NUnit.Framework.TestFixture]
	public class ArrayIterableTest {
	
		[NUnit.Framework.Test]
		public void ShouldReverseArray() {
			IList<String> expected = new List<System.String>(ILOG.J2CsMapping.Collections.Generics.Arrays.AsList("wilma","barney","fred"));
			/* foreach */
            foreach (String s in Ca.Infoway.Messagebuilder.Util.Iterator.ArrayIterable<String>.Reverse<String>(new String[] { "fred", "barney",
					"wilma" })) {
				NUnit.Framework.Assert.AreEqual(ILOG.J2CsMapping.Collections.Generics.Collections.RemoveAt(expected,0),s,s);
			}
		}
	}
}
