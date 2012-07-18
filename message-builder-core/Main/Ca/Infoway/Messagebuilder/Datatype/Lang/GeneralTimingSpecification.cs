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
 
namespace Ca.Infoway.Messagebuilder.Datatype.Lang {
	
	using Ca.Infoway.Messagebuilder;
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.ComponentModel;
	using System.Runtime.CompilerServices;
	
	/// <summary>
	/// The  v datatype that backs the Hl7 Datatype for GTS (GTS.BOUNDEDPIVL).
	/// This data type is used to convey two pieces of information: The overall time-period 
	/// when something occurred (or is to occur), as well as how often it should/did occur 
	/// within that time-period
	/// </summary>
	///
	public class GeneralTimingSpecification {
	
		private readonly Interval<Ca.Infoway.Messagebuilder.PlatformDate> duration;
		private readonly PeriodicIntervalTime frequency;
	
		/// <summary>
		/// Constructs a GeneralTimingSpecification with the given supplied values.
		/// </summary>
		///
		/// <param name="duration_0">the duration as a date interval</param>
		/// <param name="frequency_1">the frequency as a PeriodicIntervalTime</param>
		public GeneralTimingSpecification(Interval<Ca.Infoway.Messagebuilder.PlatformDate> duration_0,
				PeriodicIntervalTime frequency_1) : base() {
			this.duration = duration_0;
			this.frequency = frequency_1;
		}
	
		/// <summary>
		/// Returns the duration.
		/// </summary>
		///
		/// <returns>the date interval duration</returns>
		public Interval<Ca.Infoway.Messagebuilder.PlatformDate> Duration {
		/// <summary>
		/// Returns the duration.
		/// </summary>
		///
		/// <returns>the date interval duration</returns>
		  get {
				return this.duration;
			}
		}
		
	
		/// <summary>
		/// Returns the frequency.
		/// </summary>
		///
		/// <returns>the frequency</returns>
		public PeriodicIntervalTime Frequency {
		/// <summary>
		/// Returns the frequency.
		/// </summary>
		///
		/// <returns>the frequency</returns>
		  get {
				return this.frequency;
			}
		}
		
	}
}
