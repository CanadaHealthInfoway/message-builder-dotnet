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
 * Last modified: $LastChangedDate: 2012-02-16 10:57:39 -0500 (Thu, 16 Feb 2012) $
 * Revision:      $LastChangedRevision: 5361 $
 */
/* This class was auto-generated by the message builder generator tools. */
namespace Ca.Infoway.Messagebuilder.Model.Pcs_cerx_v01_r04_3.Iehr.Merged {
    using Ca.Infoway.Messagebuilder.Annotation;
    using Ca.Infoway.Messagebuilder.Datatype;
    using Ca.Infoway.Messagebuilder.Datatype.Impl;
    using Ca.Infoway.Messagebuilder.Datatype.Lang;
    using Ca.Infoway.Messagebuilder.Domainvalue;
    using Ca.Infoway.Messagebuilder.Model;


    /**
     * <summary>ComponentMeasurements</summary>
     * 
     * <remarks>REPC_MT100002CA.SubObservationEvent: Component 
     * Measurements <p>The same Measurement Type may not be 
     * specified in both the SubObservationEvent and the 
     * CommonObservationEvent.</p> <p>Represents one of the two 
     * components (systolic and diastolic) of a blood pressure 
     * measurement.</p> <p>Allows both parts to be captured as part 
     * of a single measurement.</p> 
     * REPC_MT000018CA.SubObservationEvent: Component Measurements 
     * <p>The same Measurement Type may not be specified in both 
     * the SubObservationEvent and the CommonObservationEvent.</p> 
     * <p>Represents one of the two components (systolic and 
     * diastolic) of a blood pressure measurement.</p> <p>Allows 
     * both parts to be captured as part of a single 
     * measurement.</p></remarks>
     */
    [Hl7PartTypeMappingAttribute(new string[] {"REPC_MT000018CA.SubObservationEvent","REPC_MT100002CA.SubObservationEvent"})]
    public class ComponentMeasurements : MessagePartBean {

        private CD code;
        private PQ value;

        public ComponentMeasurements() {
            this.code = new CDImpl();
            this.value = new PQImpl();
        }
        /**
         * <summary>BloodPressureMeasurementType</summary>
         * 
         * <remarks>Blood Pressure Measurement Type <p>Distinguishes 
         * between the two types of blood measurement. This can either 
         * be code for SYSTOLIC or DYSTOLIC</p> <p>Distinguishes 
         * between the two types of blood pressure 
         * measurements.</p><p>Code is mandatory to ensure that blood 
         * pressure observations are distinguishable. The attribute is 
         * CD to support SNOMED</p> <p>Distinguishes between the two 
         * types of blood pressure measurements.</p><p>Code is 
         * mandatory to ensure that blood pressure observations are 
         * distinguishable. The attribute is CD to support SNOMED</p> 
         * A:Blood Pressure Measurement Type <p>Distinguishes bwtween 
         * the two types of blood measurement. This can either be code 
         * for SYSTOLIC or DYSTOLIC</p> <p>Distinguishes between the 
         * two twtype of blood pressure measurements.</p><p>Code is 
         * mandatory to ensure that blood pressure observations are 
         * distinguishable. The attribute is CD to support SNOMED</p> 
         * <p>Distinguishes between the two twtype of blood pressure 
         * measurements.</p><p>Code is mandatory to ensure that blood 
         * pressure observations are distinguishable. The attribute is 
         * CD to support SNOMED</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"code"})]
        public CommonClinicalObservationType Code {
            get { return (CommonClinicalObservationType) this.code.Value; }
            set { this.code.Value = value; }
        }

        /**
         * <summary>BloodPressureMeasurementValue</summary>
         * 
         * <remarks>B:Blood Pressure Measurement Value <p>The amount 
         * (quantity and unit) that has been recorded for the blood 
         * pressure.</p> <p>Provides standard representation of the 
         * blood pressure measurement. May be used in calculations. 
         * Attribute is defined as mandatory to ensure that a value is 
         * always supplied, if there is a blood pressure 
         * measurement.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"value"})]
        public PhysicalQuantity Value {
            get { return this.value.Value; }
            set { this.value.Value = value; }
        }

    }

}