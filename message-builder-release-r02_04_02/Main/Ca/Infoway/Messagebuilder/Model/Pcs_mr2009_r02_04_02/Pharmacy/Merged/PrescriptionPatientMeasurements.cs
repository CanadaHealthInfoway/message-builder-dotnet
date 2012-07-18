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
 * Last modified: $LastChangedDate: 2012-01-18 21:10:42 -0500 (Wed, 18 Jan 2012) $
 * Revision:      $LastChangedRevision: 3991 $
 */

/* This class was auto-generated by the message builder generator tools. */
namespace Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Pharmacy.Merged {
    using Ca.Infoway.Messagebuilder.Annotation;
    using Ca.Infoway.Messagebuilder.Datatype;
    using Ca.Infoway.Messagebuilder.Datatype.Impl;
    using Ca.Infoway.Messagebuilder.Datatype.Lang;
    using Ca.Infoway.Messagebuilder.Domainvalue;
    using Ca.Infoway.Messagebuilder.Model;
    using System;


    /**
     * <summary>PrescriptionPatientMeasurements</summary>
     * 
     * <remarks>PORX_MT060340CA.QuantityObservationEvent: 
     * Prescription Patient Measurements <p>This comprises the 
     * height and/or weight of a patient as measured/observed/known 
     * by the prescriber at the time of prescribing.</p> <p>Allows 
     * patient height and weight to be conveyed to the pharmacy for 
     * dosage calculation or verification</p> 
     * PORX_MT010120CA.QuantityObservationEvent: Prescription 
     * Patient Measurements <p>This comprises the height and/or 
     * weight of a patient as measured/observed/known by the 
     * prescriber at the time of prescribing.</p> <p>Allows patient 
     * height and weight to be conveyed to the pharmacy for dosage 
     * calculation or verification;</p> 
     * PORX_MT060160CA.QuantityObservationEvent: Prescription 
     * Patient Measurements <p>This comprises the height and/or 
     * weight of a patient as measured/observed/known by the 
     * prescriber at the time of prescribing.</p> <p>Allows patient 
     * height and weight to be conveyed to the pharmacy for dosage 
     * calculation or verification</p></remarks>
     */
    [Hl7PartTypeMappingAttribute(new string[] {"PORX_MT010120CA.QuantityObservationEvent","PORX_MT060160CA.QuantityObservationEvent","PORX_MT060340CA.QuantityObservationEvent"})]
    public class PrescriptionPatientMeasurements : MessagePartBean {

        private CV prescriptionPatientMeasurementType;
        private TS effectiveTime;
        private PQ prescriptionPatientMeasuredValue;

        public PrescriptionPatientMeasurements() {
            this.prescriptionPatientMeasurementType = new CVImpl();
            this.effectiveTime = new TSImpl();
            this.prescriptionPatientMeasuredValue = new PQImpl();
        }
        /**
         * <summary>PrescriptionPatientMeasurementType</summary>
         * 
         * <remarks>Prescription Patient Measurement Type 
         * <p>Identification of the type of measurement/observation 
         * that was made about the patient. The only two allowable 
         * types are height and weight.</p> <p>Distinguishes what kind 
         * of information is being specified. Code is mandatory to 
         * ensure that measurements/observations are 
         * distinguishable.</p> Prescription Patient Measurement Type 
         * <p>Identification of the type of observation that was made 
         * about the patient. The only two allowable types are height 
         * and weight.</p> <p>Distinguishes height from 
         * weight.</p><p>Code is mandatory to ensure that 
         * measurements/observations are distinguishable.</p> 
         * <p>Distinguishes height from weight.</p><p>Code is mandatory 
         * to ensure that measurements/observations are 
         * distinguishable.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"code"})]
        public x_ActObservationHeightOrWeight PrescriptionPatientMeasurementType {
            get { return (x_ActObservationHeightOrWeight) this.prescriptionPatientMeasurementType.Value; }
            set { this.prescriptionPatientMeasurementType.Value = value; }
        }

        /**
         * <summary>Prescription Patient Measurement Time</summary>
         * 
         * <remarks><p>The date on which the measurement was made.</p> 
         * <p>Allows provider to evaluate currency of the 
         * information.</p><p>The attribute is populated because the 
         * measurement time must be known or a null flavor must be 
         * specified.</p> <p>Allows provider to evaluate currency of 
         * the information.</p><p>The attribute is populated because 
         * the measurement time must be known or a null flavor must be 
         * specified.</p> Prescription Patient Measurement Timestamp 
         * <p>The date on which the measurement was made</p> <p>Allows 
         * providers to evaluate currency of the 
         * information.</p><p>Because the date of measurement 
         * determines the relevance of the information, this attribute 
         * is defined as 'populated'.</p> <p>Allows providers to 
         * evaluate currency of the information.</p><p>Because the date 
         * of measurement determines the relevance of the information, 
         * this attribute is defined as 'populated'.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"effectiveTime"})]
        public PlatformDate EffectiveTime {
            get { return this.effectiveTime.Value; }
            set { this.effectiveTime.Value = value; }
        }

        /**
         * <summary>PrescriptionPatientMeasuredValue</summary>
         * 
         * <remarks>Prescription Patient Measured Value <p>The amount 
         * (quantity and unit) that has been recorded for the specific 
         * type of observation. E.g. height in meters, weight in 
         * kilograms.</p> <p>Provides comparable representation of the 
         * measurement. May be used in calculations.</p><p>Attribute is 
         * defined as 'mandatory' to ensure that a value is supplied, 
         * if there is a measurement.</p> <p>Provides comparable 
         * representation of the measurement. May be used in 
         * calculations.</p><p>Attribute is defined as 'mandatory' to 
         * ensure that a value is supplied, if there is a 
         * measurement.</p> Prescription Patient Measured Value <p>The 
         * amount (quantity and unit) that has been recorded for the 
         * patient's height and/or weight. E.g. height in meters, 
         * weight in kilograms, etc.</p> <p>OBS.010-02 
         * (quantity)</p><p>OBS.010-03 (unit)</p><p>Clinical.595-H4 
         * (value)</p><p>Clinical.495-H3 (unit)</p> <p>OBS.010-02 
         * (quantity)</p><p>OBS.010-03 (unit)</p><p>Clinical.595-H4 
         * (value)</p><p>Clinical.495-H3 (unit)</p> <p>OBS.010-02 
         * (quantity)</p><p>OBS.010-03 (unit)</p><p>Clinical.595-H4 
         * (value)</p><p>Clinical.495-H3 (unit)</p> <p>OBS.010-02 
         * (quantity)</p><p>OBS.010-03 (unit)</p><p>Clinical.595-H4 
         * (value)</p><p>Clinical.495-H3 (unit)</p> <p>Provides 
         * comparable representation of the measurement. May be used in 
         * calculations.</p><p>The attribute is mandatory because the 
         * measurement value must be known.</p> <p>Provides comparable 
         * representation of the measurement. May be used in 
         * calculations.</p><p>The attribute is mandatory because the 
         * measurement value must be known.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"value"})]
        public PhysicalQuantity PrescriptionPatientMeasuredValue {
            get { return this.prescriptionPatientMeasuredValue.Value; }
            set { this.prescriptionPatientMeasuredValue.Value = value; }
        }

    }

}