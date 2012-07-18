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
 * Last modified: $LastChangedDate: 2012-02-16 10:58:52 -0500 (Thu, 16 Feb 2012) $
 * Revision:      $LastChangedRevision: 5374 $
 */
/* This class was auto-generated by the message builder generator tools. */
namespace Ca.Infoway.Messagebuilder.Model.Pcs_cerx_v01_r04_3.Pharmacy.Merged {
    using Ca.Infoway.Messagebuilder.Annotation;
    using Ca.Infoway.Messagebuilder.Datatype;
    using Ca.Infoway.Messagebuilder.Datatype.Impl;
    using Ca.Infoway.Messagebuilder.Datatype.Lang;
    using Ca.Infoway.Messagebuilder.Domainvalue;
    using Ca.Infoway.Messagebuilder.Model;


    /**
     * <summary>PatientMeasurableObservations</summary>
     * 
     * <remarks>PORX_MT980010CA.ObservationMeasurableEvent: Patient 
     * Measurable Observations <p>This is the recorded observation 
     * (e.g. height, weight, lab result, etc.) of the patient that 
     * contributed to the issue being raised.</p> <p>Useful for 
     * determining appropriate management and for drilling down for 
     * more information.</p> 
     * PORX_MT980020CA.ObservationMeasurableEvent: Patient 
     * Measurable Observations <p>This is the recorded observation 
     * (e.g. allergy, medical condition, lab result, weight, 
     * pregnancy status, etc.) of the patient that contributed to 
     * the issue being raised.</p> <p>Useful for determining 
     * appropriate management and for drilling down for more 
     * information.</p> PORX_MT980030CA.ObservationMeasurableEvent: 
     * Patient Measurable Observations <p>This is the recorded 
     * observation (e.g. height, weight, lab result, etc.) of the 
     * patient that contributed to the issue being raised.</p> 
     * <p>Useful for determining appropriate management and for 
     * drilling down for more information.</p></remarks>
     */
    [Hl7PartTypeMappingAttribute(new string[] {"PORX_MT980010CA.ObservationMeasurableEvent","PORX_MT980020CA.ObservationMeasurableEvent","PORX_MT980030CA.ObservationMeasurableEvent"})]
    public class PatientMeasurableObservations : MessagePartBean, Ca.Infoway.Messagebuilder.Model.Pcs_cerx_v01_r04_3.Pharmacy.Merged.ICausalActs {

        private II id;
        private CV code;
        private CV confidentialityCode;
        private PQ value;

        public PatientMeasurableObservations() {
            this.id = new IIImpl();
            this.code = new CVImpl();
            this.confidentialityCode = new CVImpl();
            this.value = new PQImpl();
        }
        /**
         * <summary>ObservationIdentifier</summary>
         * 
         * <remarks>A:Observation Identifier <p>Unique identifier for 
         * the record of the observation (e.g. height, weight or lab 
         * test/result) that contributed to the issue.</p> <p>Allows 
         * lookup of the specific observation (e.g. height, weight, or 
         * lab record) for additional details when evaluating 
         * appropriateness of issue management.</p><p>The attribute is 
         * only marked as 'populated' because it may be masked.</p> 
         * <p>Allows lookup of the specific observation (e.g. height, 
         * weight, or lab record) for additional details when 
         * evaluating appropriateness of issue management.</p><p>The 
         * attribute is only marked as 'populated' because it may be 
         * masked.</p> A:Observation Identifier <p>Unique identifier 
         * for the record of the observation (e.g. height, weight or 
         * lab test/result) that contributed to the issue.</p> 
         * <p>Allows lookup of the specific observation (e.g. height, 
         * weight, or lab record) for additional details when 
         * evaluating appropriateness of issue management.</p><p>The 
         * attribute is marked as populated because it may be 
         * masked.</p> <p>Allows lookup of the specific observation 
         * (e.g. height, weight, or lab record) for additional details 
         * when evaluating appropriateness of issue 
         * management.</p><p>The attribute is marked as populated 
         * because it may be masked.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"id"})]
        public Identifier Id {
            get { return this.id.Value; }
            set { this.id.Value = value; }
        }

        /**
         * <summary>ObservationType</summary>
         * 
         * <remarks>B:Observation Type <p>Distinguishes between the 
         * kinds of measurable observation that could be the trigger 
         * for clinical issue detection. Measurable observation types 
         * include: Lab Result, Height, Weight, and other measurable 
         * information about a person that may be deemed as a possible 
         * trigger for clinical issue detection.</p> <p>Indicates the 
         * type of observation record being referenced. The attribute 
         * is mandatory because it is essential to interpreting the 
         * rest of the information on the class.</p> B:Observation Type 
         * <p>Distinguishes between the kinds of measurable 
         * observations that can trigger clinical issues. Measurable 
         * observation types include: Lab Result, Height, Weight, and 
         * other measurable information about a person that may be 
         * deemed as a possible trigger for clinical issue 
         * detection.</p> <p>Indicates the type of observation record 
         * being referenced. The attribute is mandatory because it is 
         * essential to interpreting the rest of the information on the 
         * class.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"code"})]
        public ObservationIssueTriggerMeasuredObservationType Code {
            get { return (ObservationIssueTriggerMeasuredObservationType) this.code.Value; }
            set { this.code.Value = value; }
        }

        /**
         * <summary>D:Observation Masking Indicator</summary>
         * 
         * <remarks><p>An indication of sensitivity surrounding the 
         * related measurable observation, and thus defines the 
         * required sensitivity for the detected issue.</p> 
         * <p>Contraindication.intractingSourceMasked (Normal=false; 
         * Restricted or Very Restricted = True); (Information is 
         * withheld because the prescription is masked will be given a 
         * NULL flavour of 'Masked')</p> <p>Conveys the patients wishes 
         * relating to the sensitivity of the observation 
         * information.</p><p>The attribute is optional because not all 
         * systems will support masking.</p> <p>Conveys the patients 
         * wishes relating to the sensitivity of the observation 
         * information.</p><p>The attribute is optional because not all 
         * systems will support masking.</p> D:Observation Masking 
         * Indicator <p>An indication of sensitivity surrounding the 
         * related measurable observation, and thus defines the 
         * required sensitivity for the detected issue.</p> 
         * <p>Contraindication.intractingSourceMasked (Normal=false; 
         * Restricted or Very Restricted = True); (Information is 
         * withheld because the prescription is masked will be given a 
         * NULL flavour of 'Masked')</p> <p>Conveys the patient's 
         * wishes relating to the sensitivity of the observation 
         * information.</p><p>The attribute is optional because not all 
         * systems will support masking.</p> <p>Conveys the patient's 
         * wishes relating to the sensitivity of the observation 
         * information.</p><p>The attribute is optional because not all 
         * systems will support masking.</p> D:Observation Masked 
         * Indicator <p>An indication of sensitivity surrounding the 
         * offending measurable observation, and thus defines the 
         * required sensitivity for the detected issue.</p> 
         * <p>Contraindication.intractingSourceMasked (Normal=false; 
         * Restricted or Very Restricted = True); (Information is 
         * withheld because the prescription is masked will be given a 
         * NULL flavour of 'Masked')</p> <p>Conveys the patient's 
         * wishes relating to the sensitivity of the 
         * observation.</p><p>The attribute is optional because not all 
         * systems will support masking.</p> <p>Conveys the patient's 
         * wishes relating to the sensitivity of the 
         * observation.</p><p>The attribute is optional because not all 
         * systems will support masking.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"confidentialityCode"})]
        public x_VeryBasicConfidentialityKind ConfidentialityCode {
            get { return (x_VeryBasicConfidentialityKind) this.confidentialityCode.Value; }
            set { this.confidentialityCode.Value = value; }
        }

        /**
         * <summary>ObservationValue</summary>
         * 
         * <remarks>C:Observation Value <p>Denotes a specific 
         * measurable observation made about a person that might have 
         * trigger the clinical issue detection.</p> <p>Provides 
         * unambiguous reference to the related measurable 
         * observation.</p> C:Observation Value <p>Denotes a specific 
         * measurable observation made about a person that triggered 
         * the clinical issue detection.</p> <p>Provides unambiguous 
         * reference to the implicated measurable observation.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"value"})]
        public PhysicalQuantity Value {
            get { return this.value.Value; }
            set { this.value.Value = value; }
        }

    }

}