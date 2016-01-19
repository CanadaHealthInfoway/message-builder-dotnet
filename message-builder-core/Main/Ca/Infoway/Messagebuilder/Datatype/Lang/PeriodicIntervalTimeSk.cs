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

    using Ca.Infoway.Messagebuilder.Datatype.Lang.Util;
    using Ca.Infoway.Messagebuilder;
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.ComponentModel;
	using System.Runtime.CompilerServices;
	using Ca.Infoway.Messagebuilder.Datatype.Lang.Util;
	
	/// <summary>
	/// 
	/// This is a special implementation for Saskatechewan since this jurisdiction redefined the GTS.BOUNDEDPIVL datatype. 
	/// 
	/// Periodic Interval of Time (PIVL) specializes SXCM. Backed by a   Date.
	/// http://www.hl7.org/v3ballot/html/infrastructure/itsxml/datatypes-its-xml.htm#dtimpl-PIVL
	/// Definition: An interval of time that recurs periodically. Periodic intervals
	/// have two properties, phase and period. The phase specifies the "interval
	/// prototype" that is repeated every period.
	/// </summary>
	///
	public class PeriodicIntervalTimeSk : PeriodicIntervalTime {
	
		private readonly Interval<PhysicalQuantity> quantitySk;
	
		private PeriodicIntervalTimeSk(DateDiff period_0, Interval<Ca.Infoway.Messagebuilder.PlatformDate> phase_1,
				Int32? repetitions_2, Interval<PhysicalQuantity> quantity_3,
				Representation representation_4) : base(period_0, phase_1, repetitions_2, null, representation_4) {
			this.quantitySk = quantity_3;
		}
	
		/// <summary>
		/// Constructs a PeriodicIntervalTimeSk using the supplied parameters.
		/// </summary>
		///
		/// <param name="repetitions_0">number of repetitions</param>
		/// <param name="quantity_1">a physical quantity</param>
		/// <returns>the constructed PeriodicIntervalTime</returns>
		public static PeriodicIntervalTimeSk CreateFrequencySk(Int32? repetitions_0, PhysicalQuantity quantity_1, PhysicalQuantity quantity_2) {
			Interval<PhysicalQuantity> ivlPq = IntervalUtil.CreateInterval(quantity_1, quantity_2);
			return new PeriodicIntervalTimeSk(null, null, repetitions_0, ivlPq,
					Representation.FREQUENCY);
		}

		[Obsolete("getQuantity() call not allowed for SK version. Use getQuantitySk() instead.")]
		new public PhysicalQuantity Quantity {
		  get {
				throw new System.NotSupportedException("getQuantity() call not allowed for SK version. Use getQuantitySk() instead.");
			}
		}
		
		/// <summary>
		/// Returns the physical quantity interval. 
		/// </summary>
		///
		/// <returns>the quantity interval</returns>
		public Interval<PhysicalQuantity> QuantitySk {
		/// <summary>
		/// Returns the physical quantity. interval 
		/// </summary>
		///
		/// <returns>the quantity interval</returns>
            get
            {
                return quantitySk;
            }
		}
		
        public override int GetHashCode()
        {
            return new HashCodeBuilder()
                    .AppendSuper(base.GetHashCode())
                    .Append(this.quantitySk)
                    .ToHashCode();
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            else if (obj.GetType() != GetType())
            {
                return false;
            } else {
                return Equals((PeriodicIntervalTimeSk) obj);
            }
        }

        private bool Equals(PeriodicIntervalTimeSk that)
        {
            return new EqualsBuilder().AppendSuper(base.Equals(that))
                    .Append(this.quantitySk, that.quantitySk)
                    .IsEquals();
        }
	
	}
}
