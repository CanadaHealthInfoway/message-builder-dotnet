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
 
namespace Ca.Infoway.Messagebuilder.Terminology {
	
	using Ca.Infoway.Messagebuilder;
	using Ca.Infoway.Messagebuilder.Domainvalue;
	using System;
    using System.Linq;
	using System.Collections;
	using System.Collections.Generic;
	using System.ComponentModel;
	using System.Runtime.CompilerServices;
	
	/// <summary>
	/// The Class EnumBasedCodeResolver.
	/// </summary>
	///
	public class EnumBasedCodeResolver : CodeResolverImpl {
	
		private readonly Type e;
	
		/// <summary>
		/// Instantiates a new enum based c resolver.
		/// </summary>
		///
		/// <param name="e_0">the e</param>
		public EnumBasedCodeResolver(Type e_0) {
			this.e = e_0;
		}
	
		/// <summary>
		/// {@inheritDoc}
		/// </summary>
		///
		public override ICollection<T> Lookup<T>(Type type) /* where T : Code */
		{
		    /*return new List<T>((IEnumerable<T>)
                ILOG.J2CsMapping.Collections.Generics.Arrays.AsList(Ca.Infoway.Messagebuilder.Lang.EnumPattern.GetEnumConstants(this.e)));*/

		    var enumConstants = Lang.EnumPattern.GetEnumConstants(e);

		    var hack = new ArrayList(enumConstants);
            var lookup = new List<T>((IEnumerable<T>)hack.ToArray(typeof(T)));
           
		    return lookup;
		}

	    /// <summary>
		/// {@inheritDoc}
		/// </summary>
		///
		public override T Lookup<T>(Type interfaceType, String code) /* where T : Code */ {
			return this.Lookup<T>(interfaceType, code, null, null);
		}
	
		/// <summary>
		/// Lookup.
		/// </summary>
		///
		/// <param name="T"> the generic type</param>
		/// <param name="interfaceType">the interface type</param>
		/// <param name="nullFlavor">the null flavor</param>
		/// <returns>the t</returns>
		public T Lookup<T>(Type interfaceType,
				NullFlavor nullFlavor)  where T : Code {
			return this.Lookup<T>(interfaceType, null, null, nullFlavor);
		}
	
		/// <summary>
		/// {@inheritDoc}
		/// </summary>
		///
		public override T Lookup<T>(Type type, String code, String codeSystemOid) /* where T : Code */ {
			return this.Lookup<T>(type, code, codeSystemOid, null);
		}
	
		/// <summary>
		/// Lookup.
		/// </summary>
		///
		/// <param name="T"> the generic type</param>
		/// <param name="type">the type</param>
		/// <param name="code">the c</param>
		/// <param name="codeSystemOid">the c system oid</param>
		/// <param name="nullFlavor">the null flavor</param>
		/// <returns>the t</returns>
		/* @SuppressWarnings("unchecked")*/
		public T Lookup<T>(Type type, String code,
				String codeSystemOid, NullFlavor nullFlavor)  where T : Code {
			return (T) FindMatchingOption(code, codeSystemOid, nullFlavor);
		}
	
		private Object FindMatchingOption(String code, String codeSystem,
				NullFlavor nullFlavor) {
			Object[] values = Ca.Infoway.Messagebuilder.Lang.EnumPattern.GetEnumConstants(this.e);
			Object result = null;
			for (int i = 0, length = (values == null) ? 0 : values.Length; CodeType
					&& result == null && i < length; i++) {
				if (Ca.Infoway.Messagebuilder.StringUtils.IsNotBlank(code)
						&& Ca.Infoway.Messagebuilder.StringUtils.IsNotBlank(codeSystem)) {
					result = Match((Code) values[i], code, codeSystem);
				} else if (Ca.Infoway.Messagebuilder.StringUtils.IsNotBlank(code)) {
					result = Match((Code) values[i], code);
				}
			}
			return result;
		}
	
		
		private bool CodeType {
		  get {
				return typeof(Code).IsAssignableFrom(this.e);
			}
		}
		
	
		private Object Match(Code code, String codeValue) {
			return (String.Equals(code.CodeValue, codeValue)) ? code : null;
		}
	
		private Object Match(Code code, String codeValue, String codeSystem) {
			return (String.Equals(code.CodeValue, codeValue)
					&& String.Equals(code.CodeSystem, codeSystem)) ? code
					: null;
		}
	}
}
