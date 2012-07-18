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
 * Last modified: $LastChangedDate: 2011-09-21 11:11:24 -0400 (Wed, 21 Sep 2011) $
 * Revision:      $LastChangedRevision: 3001 $
 */

/// ---------------------------------------------------------------------------------------------------
///  This file was automatically generated by J2CS Translator (http://j2cstranslator.sourceforge.net/). 
///  Version 1.0.0                                                                                      
/// ---------------------------------------------------------------------------------------------------
 
namespace Ca.Infoway.Messagebuilder.Datatype.Impl {
	
	using Ca.Infoway.Messagebuilder.Datatype;
	using Ca.Infoway.Messagebuilder.Datatype.Lang;
	using Ca.Infoway.Messagebuilder.Domainvalue;
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.ComponentModel;
	using System.Runtime.CompilerServices;
	
	/// <summary>
	/// HL7 datatype for instance identifier. Backed by the   datatype Identifier.
	/// An identifier that uniquely identifies a thing or object. Examples are object 
	/// identifier for HL7 RIM objects, medical record number, order id, service catalog 
	/// item id, Vehicle Identification Number (VIN), etc. Instance identifiers are 
	/// defined based on ISO object identifiers. 
	/// </summary>
	///
	public class IIImpl : ANYImpl<Identifier>, II {
	
		private const long serialVersionUID = -2292476001838737646L;
	
		/// <summary>
		/// Constructs an empty Identifier.
		/// </summary>
		///
		public IIImpl() : this((Identifier)null) {
		}
	
		/// <summary>
		/// Constructs an Identifier using the supplied value.
		/// </summary>
		///
		/// <param name="defaultValue">the initial value</param>
		public IIImpl(Identifier defaultValue) : base(typeof(Identifier), defaultValue, null, Ca.Infoway.Messagebuilder.Datatype.StandardDataType.II) {
		}
	
		/// <summary>
		/// Constructs an Identifier with the given null flavor.
		/// </summary>
		///
		/// <param name="nullFlavor">a null flavor</param>
		public IIImpl(NullFlavor nullFlavor) : base(typeof(Identifier), null, nullFlavor, Ca.Infoway.Messagebuilder.Datatype.StandardDataType.II) {
		}
	
	}
}
