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
 * Last modified: $LastChangedDate: 2011-05-04 16:47:15 -0300 (Wed, 04 May 2011) $
 * Revision:      $LastChangedRevision: 2623 $
 */
/* This class was auto-generated by the message builder generator tools. */
namespace Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Pharmacy.Merged {
    using Ca.Infoway.Messagebuilder.Annotation;
    using Ca.Infoway.Messagebuilder.Datatype;
    using Ca.Infoway.Messagebuilder.Datatype.Impl;
    using Ca.Infoway.Messagebuilder.Domainvalue;
    using Ca.Infoway.Messagebuilder.Model;
    using System;


    /**
     * <summary>AppearanceCharacteristics</summary>
     * 
     * <remarks>POME_MT010100CA.Characteristic: Appearance 
     * Characteristics <p>The characteristics of a manufactured 
     * product that visually distinguish it from other 
     * products.</p> <p>Used for searching drugs. May be employed 
     * as means of communication between providers and 
     * patients.</p> POME_MT010040CA.Characteristic: Appearance 
     * Characteristics <p>The characteristics of a manufactured 
     * product that visually distinguish it from other 
     * products.</p> <p>Used for searching drugs. May be employed 
     * as means of communication between providers and 
     * patients.</p></remarks>
     */
    [Hl7PartTypeMappingAttribute(new string[] {"POME_MT010040CA.Characteristic","POME_MT010100CA.Characteristic"})]
    public class AppearanceCharacteristics : MessagePartBean {

        private CV code;
        private ST value;

        public AppearanceCharacteristics() {
            this.code = new CVImpl();
            this.value = new STImpl();
        }
        /**
         * <summary>CharacteristicType</summary>
         * 
         * <remarks>Characteristic Type <p>A coded value denoting the 
         * type of physical characteristic being documented. Kinds of 
         * characteristics include: Color, Shape, Markings, Size.</p> 
         * <p>Identifies what kind of characteristic is being 
         * identified. This is mandatory as providing the 
         * characteristic alone without specifying the type can result 
         * in ambiguity</p> A:Characteristic Type <p>A coded value 
         * denoting the type of physical characteristic being 
         * documented. Kinds of characteristics include: Color, Shape, 
         * Markings, Size, etc.</p> <p>Identifies what kind of 
         * characteristic is being identified. This is mandatory as 
         * providing the characteristic alone without specifying the 
         * type can result in ambiguity.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"code"})]
        public MedicationObservationType Code {
            get { return (MedicationObservationType) this.code.Value; }
            set { this.code.Value = value; }
        }

        /**
         * <summary>Characteristic</summary>
         * 
         * <remarks>E:Characteristic <p>Information pertaining to a 
         * specific instance of drug characteristic (color, shape, 
         * markings etc).</p> <p>Provides the 'value' part of the 
         * name-value pair describing the drug product appearance 
         * characteristic.</p><p>The attribute is marked as 
         * &quot;mandatory&quot; as there must be a value for a 
         * mandatory code.</p> <p>Provides the 'value' part of the 
         * name-value pair describing the drug product appearance 
         * characteristic.</p><p>The attribute is marked as 
         * &quot;mandatory&quot; as there must be a value for a 
         * mandatory code.</p> Characteristic <p>Information pertaining 
         * to a specific instance of drug characteristic (color, shape, 
         * markings etc)</p> <p>Provides the 'value' part of the 
         * name-value pair describing the drug product appearance 
         * characteristic.</p><p>The attribute is marked as 'mandatory' 
         * as there must be a value for a mandatory code.</p> 
         * <p>Provides the 'value' part of the name-value pair 
         * describing the drug product appearance 
         * characteristic.</p><p>The attribute is marked as 'mandatory' 
         * as there must be a value for a mandatory code.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"value"})]
        public String Value {
            get { return this.value.Value; }
            set { this.value.Value = value; }
        }

    }

}