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

namespace Ca.Infoway.Messagebuilder.Resolver {
	
	using Ca.Infoway.Messagebuilder;
	using Ca.Infoway.Messagebuilder.Domainvalue;
    using Ca.Infoway.Messagebuilder.Terminology;
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
			return this.Lookup<T>(interfaceType, code, null, true);
		}
	
		/// <summary>
		/// {@inheritDoc}
		/// </summary>
		///
		public override T Lookup<T>(Type type, String code, bool ignoreCase) /* where T : Code */ {
			return this.Lookup<T>(type, code, null, ignoreCase);
		}
	
		/// <summary>
		/// Lookup.
		/// </summary>
		///
		/// <param name="T"> the generic type</param>
		/// <param name="type">the type</param>
		/// <param name="code">the c</param>
		/// <param name="codeSystemOid">the c system oid</param>
		/// <returns>the t</returns>
		/* @SuppressWarnings("unchecked")*/
		public override T Lookup<T>(Type type, String code,
				String codeSystemOid)  /*where T : Code*/ {
			return Lookup<T>(type, code, codeSystemOid, true);
		}

        public override T Lookup<T>(Type type, String code,
                String codeSystemOid, bool ignoreCase) /*where T : Code*/ {
            return (T) FindMatchingOption(code, codeSystemOid, ignoreCase);
        }

        private Object FindMatchingOption(String code, String codeSystem,
				bool ignoreCase) {
			Object[] values = Ca.Infoway.Messagebuilder.Lang.EnumPattern.GetEnumConstants(this.e);
			Object result = null;
			for (int i = 0, length = (values == null) ? 0 : values.Length; CodeType
					&& result == null && i < length; i++) {
				if (Ca.Infoway.Messagebuilder.StringUtils.IsNotBlank(code)
						&& Ca.Infoway.Messagebuilder.StringUtils.IsNotBlank(codeSystem)) {
					result = Match((Code) values[i], code, codeSystem, ignoreCase);
				} else if (Ca.Infoway.Messagebuilder.StringUtils.IsNotBlank(code)) {
					result = Match((Code) values[i], code, ignoreCase);
				}
			}
			return result;
		}
	
		
		private bool CodeType {
		  get {
				return typeof(Code).IsAssignableFrom(this.e);
			}
		}
		
	
		private Object Match(Code code, String codeValue, bool ignoreCase) {
		    bool match = (ignoreCase ? StringUtils.EqualsIgnoreCase(code.CodeValue, codeValue) : StringUtils.Equals(code.CodeValue, codeValue));
		    return match ? code : null;
		}
	
		private Object Match(Code code, String codeValue, String codeSystem, bool ignoreCase) {
		    bool matchCode = (ignoreCase ? StringUtils.EqualsIgnoreCase(code.CodeValue, codeValue) : StringUtils.Equals(code.CodeValue, codeValue));
		    bool matchCodeSystem = StringUtils.Equals(code.CodeSystem, codeSystem); // ignoreCase not checked here
		    return matchCode && matchCodeSystem ? code : null;
		}
	}
}