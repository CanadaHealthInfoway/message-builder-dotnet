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
 
namespace Ca.Infoway.Messagebuilder.Datatype.Lang {
	
	using Ca.Infoway.Messagebuilder;
    using Ca.Infoway.Messagebuilder.Datatype.Lang.Util;
    using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.ComponentModel;
	using System.Runtime.CompilerServices;
	using System.Runtime.Serialization;
	using System.Text;
	
	/// <summary>
	/// Postal address parts are held by a postal address object and together make up the full address.
	/// </summary>
	///
	[Serializable]
	public class PostalAddressPart {
	
		private const long serialVersionUID = -8651771688623021546L;
		private PostalAddressPartType type;
		private String value_ren;
		private Code code;
	
		/// <summary>
		/// Constructs an empty part.
		/// </summary>
		///
		public PostalAddressPart() {
		}
	
		/// <summary>
		/// Constructs a part with the given type and value. 
		/// </summary>
		///
		/// <param name="type_0">the part type</param>
		/// <param name="value">the value of the part type</param>
		public PostalAddressPart(PostalAddressPartType type_0, String value_ren) {
			this.type = type_0;
			this.value_ren = value_ren;
		}
	
		/// <summary>
		/// Constructs a part with the given type and value. 
		/// </summary>
		///
		/// <param name="value">the value of the part type</param>
		/// <param name="type_0">the part type</param>
		public PostalAddressPart(String value_ren, PostalAddressPartType type_0) {
			this.type = type_0;
			this.value_ren = value_ren;
		}
	
		/// <summary>
		/// Constructs a part with the given value (and no type).
		/// </summary>
		///
		/// <param name="value">the value of the part type</param>
		public PostalAddressPart(String value_ren) {
			this.value_ren = value_ren;
		}
	
		/// <summary>
		/// Constructs a postal address part with the supplied parameters. 
		/// </summary>
		///
		/// <param name="type_0">the part type</param>
		/// <param name="code_1">the c for the part type</param>
		/// <param name="originalValue">the value of the part type</param>
		public PostalAddressPart(PostalAddressPartType type_0, Code code_1,
				String originalValue) {
			this.type = type_0;
			this.code = code_1;
			this.value_ren = originalValue;
		}
	
		/// <summary>
		/// Constructs a postal address part with the supplied parameters. 
		/// </summary>
		///
		/// <param name="type_0">the part type</param>
		/// <param name="code_1">the c for the part type</param>
		public PostalAddressPart(PostalAddressPartType type_0, Code code_1) {
			this.type = type_0;
			this.code = code_1;
		}
	
		/// <summary>
		/// Constructs a postal address part with the supplied parameters. 
		/// </summary>
		///
		/// <param name="type_0">the part type</param>
		/// <param name="codedString">a cd string containing the c and value for this postal address part type</param>
		public PostalAddressPart(PostalAddressPartType type_0,
				CodedString<Code> codedString) {
			this.type = type_0;
			this.code = (codedString == null) ? null : codedString.Code;
			this.value_ren = (codedString == null) ? null : codedString.Value;
		}
	
		/// <summary>
		/// Sets the postal address part type.
		/// </summary>
		///
		/// <param name="type_0">the type to set</param>
		public PostalAddressPartType Type {
		/// <summary>
		/// Gets the postal address part type.
		/// </summary>
		///
		/// <returns>the type</returns>
		  get {
				return this.type;
			}
		/// <summary>
		/// Sets the postal address part type.
		/// </summary>
		///
		/// <param name="type_0">the type to set</param>
		  set {
				this.type = value;
			}
		}
		
	
		/// <summary>
		/// Sets the part type value (as a string).
		/// </summary>
		///
		/// <param name="value">the part type value</param>
		public String Value {
		/// <summary>
		/// Obtains the part type value, from either the value itself or the c.
		/// </summary>
		///
		/// <returns>the part type value</returns>
		  get {
				if (this.code != null && this.code  is  Describable) {
					return ((Describable) this.code).Description;
				} else if (this.value_ren != null) {
					return this.value_ren;
				} else if (this.code != null) {
					return this.code.CodeValue;
				}
				return null;
			}
			
		/// <summary>
		/// Sets the part type value (as a string).
		/// </summary>
		///
		/// <param name="value">the part type value</param>
		  set {
				this.value_ren = value;
			}
		}
		
	
		/// <summary>
		/// The hashc, based on type, value, and c.
		/// </summary>
		///
		/// <returns>the hashc</returns>
		public override int GetHashCode() {
			return new HashCodeBuilder().Append(this.type).Append(this.value_ren)
					.Append(this.code).ToHashCode();
		}
	
		/// <summary>
		/// Compares the supplied object to this object for equality.
		/// </summary>
		///
		/// <param name="obj">the object to compare</param>
		/// <returns>whether the supplied object is equal to this object</returns>
		public override bool Equals(Object obj) {
			if (obj == null) {
				return false;
			} else if ((Object) GetType() != (Object) obj.GetType()) {
				return false;
			} else {
				PostalAddressPart that = (PostalAddressPart) obj;
				return new EqualsBuilder().Append(this.type, that.type).Append(
						this.value_ren, that.value_ren).Append(this.code, that.code)
						.IsEquals();
			}
		}
	
		/// <summary>
		/// Sets the c.
		/// </summary>
		///
		/// <param name="code_0">the c</param>
		public Code Code {
		/// <summary>
		/// Gets the c, if available.
		/// </summary>
		///
		/// <returns>the c</returns>
		  get {
				return this.code;
			}
		/// <summary>
		/// Sets the c.
		/// </summary>
		///
		/// <param name="code_0">the c</param>
		  set {
				this.code = value;
			}
		}
		
	
		/// <summary>
		/// Returns a string representation of this object.
		/// </summary>
		///
		/// <returns>the object formatted as a string</returns>
		public override  System.String ToString() {
			StringBuilder builder = new StringBuilder();
			if (this.type != null) {
				builder.Append(this.type.ToString());
				builder.Append(" ");
			}
			if (Ca.Infoway.Messagebuilder.StringUtils.IsNotBlank(Value)) {
				builder.Append(Value);
			}
			return builder.ToString();
		}
	
		/// <summary>
		/// Converts this postal address into a cd string. Makes use of value and c (and specifically, not the part type). 
		/// </summary>
		///
		/// <returns>this postal address part as a cd string (using value and c)</returns>
		public CodedString<Code> AsCodedString() {
			return new CodedString<Code>(this.value_ren, this.code);
		}
	}
}
