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
    using Ca.Infoway.Messagebuilder.Domainvalue.Basic;
    using System;
	using System.Collections.Generic;
	using System.ComponentModel;
	using System.Runtime.CompilerServices;
	
	/// <summary>
	/// Abstract super class for names.
	/// </summary>
	///
	public class EntityName {

        private ISet<EntityNameUse> uses;
        private IList<EntityNamePart> parts;
		
		public EntityName() {
			this.uses = new SortedSet<EntityNameUse>();
            this.parts = new List<EntityNamePart>();
		}
	
		/// <summary>
		/// Obtains the list of name parts.
		/// </summary>
		///
		/// <returns>the list of name parts</returns>
		public IList<EntityNamePart> Parts {
		/// <summary>
		/// Obtains the list of name parts.
		/// </summary>
		///
		/// <returns>the list of name parts</returns>
		  get {
              return this.parts;
          }
		}

        public virtual void AddNamePart(EntityNamePart part) {
            this.parts.Add(part);
        }
		
	
		/// <summary>
		/// Replaces the set of name uses for this name.
		/// </summary>
		///
		/// <param name="uses_0">the set of name uses</param>
		public ICollection<EntityNameUse> Uses {
		/// <summary>
		/// Obtains the set of name uses for this name.
		/// </summary>
		///
		/// <returns>the set of name uses</returns>
		  get {
				return this.uses;
			}
		}
		
	
		/// <summary>
		/// Adds a name use to this name.
		/// </summary>
		///
		/// <param name="use">the name use to add</param>
		public void AddUse(EntityNameUse use) {
			ILOG.J2CsMapping.Collections.Generics.Collections.Add(this.uses,use);
		}

        /// <summary>
        /// The time interval for which this name is valid
        /// </summary>
        public Interval<PlatformDate> ValidTime {
            get;
            set;
        }

        public override int GetHashCode()
        {
            return new HashCodeBuilder()
                    .Append(this.parts)
                    .Append(this.uses)
                    .Append(ValidTime)
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
                return Equals((EntityName) obj);
            }
        }

        private bool Equals(EntityName that)
        {
            return new EqualsBuilder()
                .Append(this.parts, that.parts)
                .Append(this.uses, that.uses)
                .Append(ValidTime, that.ValidTime)
                .IsEquals();
        }
    
	}
}
