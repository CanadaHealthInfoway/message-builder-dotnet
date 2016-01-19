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
	
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.ComponentModel;
	using System.Runtime.CompilerServices;
	
	/// <summary>
	///   datatype for ratios.
	/// For RTO&lt;PQ.DRUG, PQ.TIME&gt;: Used to express a quantity of drug over a particular time-period.
	/// For RTO&lt;MO.CAD, PQ.BASIC&gt;: Used to express a monetary value over quantity.
	/// </summary>
	///
	/// <param name="T"> The underlying   datatype for the numerator.</param>
	/// <param name="U"> The underlying   datatype for the denominator.</param>
	public class Ratio<T, U> : BareRatio {
	
		private T numerator;
		private U denominator;
	
		/// <summary>
		/// Constructs an empty Ratio object.
		/// </summary>
		///
		public Ratio() {
		}
	
		/// <summary>
		/// Constructs a Ratio object with the given numerator and denominator.
		/// </summary>
		///
		/// <param name="numerator_0">the numerator for the ratio</param>
		/// <param name="denominator_1">the denominator for the ratoi</param>
		public Ratio(T numerator_0, U denominator_1) {
			this.numerator = numerator_0;
			this.denominator = denominator_1;
		}
	
		/// <summary>
		/// Sets the denominator.
		/// </summary>
		///
		/// <param name="denominator_0">the denominator</param>
		public U Denominator {
		/// <summary>
		/// Returns the denominator.
		/// </summary>
		///
		/// <returns>the denominator</returns>
		  get {
				return this.denominator;
			}
		/// <summary>
		/// Sets the denominator.
		/// </summary>
		///
		/// <param name="denominator_0">the denominator</param>
		  set {
				this.denominator = value;
			}
		}
		
	
		/// <summary>
		/// Sets the numerator.
		/// </summary>
		///
		/// <param name="numerator_0">the numerator</param>
		public T Numerator {
		/// <summary>
		/// Returns the numerator.
		/// </summary>
		///
		/// <returns>the numerator</returns>
		  get {
				return this.numerator;
			}
		/// <summary>
		/// Sets the numerator.
		/// </summary>
		///
		/// <param name="numerator_0">the numerator</param>
		  set {
				this.numerator = value;
			}
		}

		
		
		public object BareDenominator {
			get {
				return Denominator;
			}
		}
		
		public object BareNumerator {
			get {
				return Numerator;
			}
		}
		
        public override int GetHashCode()
        {
            return new HashCodeBuilder()
		            .Append(this.numerator)
		            .Append(this.denominator)
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
                return Equals((Ratio<T,U>) obj);
            }
        }
    
        private bool Equals(Ratio<T,U> that)
        {
            return new EqualsBuilder()
                    .Append(this.numerator, that.numerator)
                    .Append(this.denominator, that.denominator)
                    .IsEquals();
        }
    
	}
}
