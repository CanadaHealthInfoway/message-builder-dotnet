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
	/// Hl7 datatype TN backed by the  v datatype TrivialName.
	/// A string used for simple names for things (e.g. drug names) and places (e.g. "Canada Health Infoway")
	/// </summary>
	///
	public class TNImpl : ENImpl<TrivialName>, TN {
	
		private const long serialVersionUID = -3857569397613505550L;
	
		/// <summary>
		/// Constructs an empty TN.
		/// </summary>
		///
		public TNImpl() : this((TrivialName)null) {
		}
	
		/// <summary>
		/// Constructs a TN using the given value.
		/// </summary>
		///
		/// <param name="defaultValue">the initial value.</param>
		public TNImpl(TrivialName defaultValue) : base(typeof(TrivialName), defaultValue, null, Ca.Infoway.Messagebuilder.Datatype.StandardDataType.TN) {
		}
	
		/// <summary>
		/// Constructs a TN having the supplied null flavor. 
		/// </summary>
		///
		/// <param name="nullFlavor">a null flavor</param>
		public TNImpl(NullFlavor nullFlavor) : base(typeof(TrivialName), null, nullFlavor, Ca.Infoway.Messagebuilder.Datatype.StandardDataType.TN) {
		}
	}
}
