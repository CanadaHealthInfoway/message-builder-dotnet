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
 * Author:        $LastChangedBy: tmcgrady $
 * Last modified: $LastChangedDate: 2011-09-21 11:11:24 -0400 (Wed, 21 Sep 2011) $
 * Revision:      $LastChangedRevision: 3001 $
 */

/// ---------------------------------------------------------------------------------------------------
///  This file was automatically generated by J2CS Translator (http://j2cstranslator.sourceforge.net/). 
///  Version 1.0.0                                                                                      
/// ---------------------------------------------------------------------------------------------------

namespace Ca.Infoway.Messagebuilder.Domainvalue.Basic
{
	
	using Ca.Infoway.Messagebuilder;
	using Ca.Infoway.Messagebuilder.Domainvalue;
	using Ca.Infoway.Messagebuilder.Lang;
    using Ca.Infoway.Messagebuilder.Datatype.Lang.Util;
    using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.ComponentModel;
	using System.Runtime.CompilerServices;
	
	/// <summary>
	/// An enum to handle basic time units.
	/// </summary>
	///
	[Serializable]
	public class DefaultTimeUnit : EnumPattern, DateConverter, x_TimeUnitsOfMeasure {
	
		private const long serialVersionUID = 3134130558551921271L;
	
		public static readonly DefaultTimeUnit YEAR = new DefaultTimeUnit("YEAR", "a",
				Ca.Infoway.Messagebuilder.DateUtils.MILLIS_PER_DAY * 365);
		public static readonly DefaultTimeUnit MONTH = new DefaultTimeUnit("MONTH",
				"mo", Ca.Infoway.Messagebuilder.DateUtils.MILLIS_PER_DAY * 30);
		public static readonly DefaultTimeUnit WEEK = new DefaultTimeUnit("WEEK",
				"wk", Ca.Infoway.Messagebuilder.DateUtils.MILLIS_PER_DAY * 7);
        public static readonly DefaultTimeUnit DAY = new DefaultTimeUnit("DAY", "d",
                Ca.Infoway.Messagebuilder.DateUtils.MILLIS_PER_DAY);
        public static readonly DefaultTimeUnit HOUR = new DefaultTimeUnit("HOUR", "h",
                Ca.Infoway.Messagebuilder.DateUtils.MILLIS_PER_HOUR);
        public static readonly DefaultTimeUnit MINUTE = new DefaultTimeUnit("MINUTE",
                "min", Ca.Infoway.Messagebuilder.DateUtils.MILLIS_PER_MINUTE);
        public static readonly DefaultTimeUnit SECOND = new DefaultTimeUnit("SECOND",
				"s", Ca.Infoway.Messagebuilder.DateUtils.MILLIS_PER_SECOND);
	
		private readonly String codeValue;
		private readonly long conversion;
	
		private DefaultTimeUnit(String name, String codeValue_0, long conversion_1) : base(name) {
			this.codeValue = codeValue_0;
			this.conversion = conversion_1;
		}

        static DefaultTimeUnit() { }
	
		/// <summary>
		/// Returns the c system for uniform unit of measure.
		/// </summary>
		///
		/// <returns>the c system for uniform unit of measure.</returns>
		public virtual String CodeSystem {
		/// <summary>
		/// Returns the c system for uniform unit of measure.
		/// </summary>
		///
		/// <returns>the c system for uniform unit of measure.</returns>
		  get {
				return Ca.Infoway.Messagebuilder.Codesystem.CodeSystem.VOCABULARY_UNIFORM_UNIT_OF_MEASURE.Root;
			}
		}
		
	
		/// <summary>
		/// Returns the c value.
		/// </summary>
		///
		/// <returns>the c value</returns>
		public virtual String CodeValue {
		/// <summary>
		/// Returns the c value.
		/// </summary>
		///
		/// <returns>the c value</returns>
		  get {
				return this.codeValue;
			}
		}
		
	
		/// <summary>
		/// Converts the given value into milliseconds.
		/// </summary>
		///
		/// <param name="value">the value to convert</param>
		/// <returns>the given value in milliseconds.</returns>
		public virtual long ToMilliseconds(int value_ren) {
			return this.conversion * value_ren;
		}
	
		/// <summary>
		/// Converts the given BigDecimal into milliseconds.
		/// </summary>
		///
		/// <param name="quantity">the BigDecimal to convert.</param>
		/// <returns>the given value in milliseconds.</returns>
		public long ToMilliseconds(BigDecimal quantity) {
			return quantity.Multiply(new BigDecimal(this.conversion)).LongValue;
		}
	
		/// <summary>
		/// Returns the DefaultTimeUnit that is applicable for the given unit c value.
		/// </summary>
		///
		/// <param name="unitCodeValue">the unit c value</param>
		/// <returns>the DefaultTimeUnit that is applicable for the given unit c value</returns>
		public static DefaultTimeUnit Lookup(String unitCodeValue) {
			DefaultTimeUnit result = null;
			/* foreach */
			foreach (DefaultTimeUnit unit  in  Ca.Infoway.Messagebuilder.Lang.EnumPattern.Values<DefaultTimeUnit>(typeof(DefaultTimeUnit))) {
				if (String.Equals(unitCodeValue, unit.CodeValue)) {
					result = unit;
					break;
				}
			}
			return result;
		}

        public static bool IsDayBased(Ca.Infoway.Messagebuilder.Domainvalue.UnitsOfMeasureCaseSensitive units)
        {
            if (units == null || units.CodeValue == null)
            {
                return false;
            }
            return YEAR.CodeValue.Equals(units.CodeValue) ||
                    MONTH.CodeValue.Equals(units.CodeValue) ||
                    WEEK.CodeValue.Equals(units.CodeValue) ||
                    DAY.CodeValue.Equals(units.CodeValue);
        }
	

	}
}