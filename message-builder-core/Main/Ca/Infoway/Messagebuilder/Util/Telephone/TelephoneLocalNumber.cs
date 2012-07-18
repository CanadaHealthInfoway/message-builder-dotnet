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
 
namespace Ca.Infoway.Messagebuilder.Util.Telephone {
	
	using Ca.Infoway.Messagebuilder;
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.ComponentModel;
	using System.Runtime.CompilerServices;
	
	
	/// <summary>
	/// The seven-digit part of the telephone number, without area c.
	/// This number is stored as 1234567 but we want to display it as 123-4567
	/// </summary>
	///
	public class TelephoneLocalNumber {
	
		private String telephoneNumber;
	
		public static TelephoneLocalNumber Create(String telephoneLocalNumberString) {
			TelephoneLocalNumber result = null;
	
			if (!Ca.Infoway.Messagebuilder.StringUtils.IsBlank(telephoneLocalNumberString)) {
				String noHyphenNumber = Ca.Infoway.Messagebuilder.StringUtils.Remove(
						telephoneLocalNumberString, '-');
				result = new TelephoneLocalNumber();
				result.TelephoneNumber = noHyphenNumber;
			}
	
			return result;
		}
	
		
		public String TelephoneNumber {
		  get {
				return this.telephoneNumber;
			}
		  set {
				this.telephoneNumber = value;
			}
		}
		
	
		
		public String FormattedTelephoneNumber {
		  get {
				String result = TelephoneNumber;
				if (result != null && result.Length == 7) {
					result = result.Substring(0,(3)-(0)).ToUpper() + "-"
							+ result.Substring(3).ToUpper();
				}
				return result;
			}
		}
		
	
		public virtual  System.Object Clone() {
			TelephoneLocalNumber clone = new TelephoneLocalNumber();
			clone.TelephoneNumber = TelephoneNumber;
			return clone;
		}
	}
}
