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
namespace Ca.Infoway.Messagebuilder.Model.Sk_cerx_v01_r04_3.Pharmacy.Pome_mt010040ca {
    using Ca.Infoway.Messagebuilder.Annotation;
    using Ca.Infoway.Messagebuilder.Datatype;
    using Ca.Infoway.Messagebuilder.Datatype.Impl;
    using Ca.Infoway.Messagebuilder.Datatype.Lang;
    using Ca.Infoway.Messagebuilder.Domainvalue;
    using Ca.Infoway.Messagebuilder.Model;
    using System;


    /**
     * <summary>Patient Characteristics</summary>
     * 
     * <remarks><p>Value should be mandatory if not using 
     * SNOMED</p> <p>Indicates a characteristic that should be 
     * possessed by the patient for the dose to be appropriate.</p> 
     * <p>Allows filtering of dosages to be appropriate to the 
     * patient.</p></remarks>
     */
    [Hl7PartTypeMappingAttribute(new string[] {"POME_MT010040CA.ObservationEventCriterion"})]
    public class PatientCharacteristics : MessagePartBean {

        private CV code;
        private BL negationInd;
        private IVL<PQ, Interval<PhysicalQuantity>> value;

        public PatientCharacteristics() {
            this.code = new CVImpl();
            this.negationInd = new BLImpl();
            this.value = new IVLImpl<PQ, Interval<PhysicalQuantity>>();
        }
        /**
         * <summary>Patient Characteristic Type</summary>
         * 
         * <remarks><p>Indicates the type of patient characteristic 
         * being expressed. E.g. Height, weight, age, lab values, etc. 
         * If negation indicator is true, then this indicates a 
         * characteristic the patient should *not* have.</p> <p>Needed 
         * to identify what type of characteristic is being expressed, 
         * and therefore mandatory.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"code"})]
        public ObservationDosageDefinitionPreconditionType Code {
            get { return (ObservationDosageDefinitionPreconditionType) this.code.Value; }
            set { this.code.Value = value; }
        }

        /**
         * <summary>Exclude characteristic?</summary>
         * 
         * <remarks><p>If true, indicates that the characteristic is 
         * one which should *not* be held by the patient for the dosage 
         * to apply.</p> <p>Many dosages are inappropriate for patients 
         * with certain characteristics (e.g. INR values, 
         * etc.)</p><p>Because it must be known whether the 
         * characteristic is included or excluded, this element is 
         * mandatory.</p> <p>Many dosages are inappropriate for 
         * patients with certain characteristics (e.g. INR values, 
         * etc.)</p><p>Because it must be known whether the 
         * characteristic is included or excluded, this element is 
         * mandatory.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"negationInd"})]
        public bool? NegationInd {
            get { return this.negationInd.Value; }
            set { this.negationInd.Value = value; }
        }

        /**
         * <summary>Patient Characteristic Value</summary>
         * 
         * <remarks><p>Indicates the specific value or range of values 
         * of the characteristic a patient should have for the dosage 
         * to be appropriate.</p> <p>Allows comparison to actual 
         * patient characteristics to see if the dosage is applicable. 
         * In some circumstances, the specific range may not be known, 
         * thus the field is &quot;populated&quot;</p><p>Example: This 
         * dosage specification applies to people over 60 
         * pounds&quot;.</p> <p>Allows comparison to actual patient 
         * characteristics to see if the dosage is applicable. In some 
         * circumstances, the specific range may not be known, thus the 
         * field is &quot;populated&quot;</p><p>Example: This dosage 
         * specification applies to people over 60 pounds&quot;.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"value"})]
        public Interval<PhysicalQuantity> Value {
            get { return this.value.Value; }
            set { this.value.Value = value; }
        }

    }

}