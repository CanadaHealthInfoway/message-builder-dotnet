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
 * Author:        $LastChangedBy: gng $
 * Last modified: $LastChangedDate: 2015-11-19 18:20:12 -0500 (Fri, 30 Jan 2015) $
 * Revision:      $LastChangedRevision: 9755 $
 */


/// ---------------------------------------------------------------------------------------------------
///  This file was automatically generated by J2CS Translator (http://j2cstranslator.sourceforge.net/). 
///  Version 1.0.0                                                                                      
/// ---------------------------------------------------------------------------------------------------

namespace Ca.Infoway.Messagebuilder.Datatype.Lang.Util {
	
	using Ca.Infoway.Messagebuilder.Lang;
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.ComponentModel;
	using System.Runtime.CompilerServices;
	
	/// <summary>
	/// An enum for organization name part types.
	/// </summary>
	///
	[Serializable]
	public class OrganizationNamePartType : EnumPattern, 
			NamePartType {
	
		private const long serialVersionUID = -8005396643000939327L;
	
		public static readonly OrganizationNamePartType DELIMITER = new OrganizationNamePartType(
				"DELIMITER", "delimiter");
		public static readonly OrganizationNamePartType PREFIX = new OrganizationNamePartType(
				"PREFIX", "prefix");
		public static readonly OrganizationNamePartType SUFFIX = new OrganizationNamePartType(
				"SUFFIX", "suffix");
	
		private readonly String value_ren;
	
		private OrganizationNamePartType(String name, String value_ren) : base(name) {
			this.value_ren = value_ren;
		}

        static OrganizationNamePartType() { }
	
		/// <summary>
		/// Returns the value of this enum.
		/// </summary>
		///
		/// <returns>the value</returns>
		public virtual String Value {
		/// <summary>
		/// Returns the value of this enum.
		/// </summary>
		///
		/// <returns>the value</returns>
		  get {
				return this.value_ren;
			}
		}
		
	}
}
