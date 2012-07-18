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
	/// Uniform resource Locator. Bound to an underlying TelecommunicationAddress.
	/// </summary>
	///
	public class URLImpl : ANYImpl<TelecommunicationAddress>, URL {
	
		/// <summary>
		/// Constructs an empty URL.
		/// </summary>
		///
		public URLImpl() : this((TelecommunicationAddress)null) {
		}
	
		/// <summary>
		/// Constructs a URL with the goven value.
		/// </summary>
		///
		/// <param name="defaultValue">the initial URL value</param>
		public URLImpl(TelecommunicationAddress defaultValue) : this(defaultValue, null, Ca.Infoway.Messagebuilder.Datatype.StandardDataType.URL) {
		}
	
		/// <summary>
		/// Constructs a URL with a null flavor.
		/// </summary>
		///
		/// <param name="nullFlavor">the null flavor for the url</param>
		public URLImpl(NullFlavor nullFlavor) : this(null, nullFlavor, Ca.Infoway.Messagebuilder.Datatype.StandardDataType.URL) {
		}
	
		/// <summary>
		/// Constructs a URL with both a telecom address value and a null flavor.
		/// </summary>
		///
		/// <param name="defaultValue">initial value for the telecom address</param>
		/// <param name="nullFlavor">initial null flavor for the URL</param>
		/// <param name="dataType">the datatype enum representing this telecom address</param>
		public URLImpl(TelecommunicationAddress defaultValue,
				NullFlavor nullFlavor, StandardDataType dataType) : base(typeof(TelecommunicationAddress), defaultValue, nullFlavor, dataType) {
		}
	
	}
}
