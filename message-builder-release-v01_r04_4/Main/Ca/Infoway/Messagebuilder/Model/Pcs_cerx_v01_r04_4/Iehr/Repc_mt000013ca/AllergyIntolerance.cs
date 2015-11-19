/**
 * Copyright 2015 Canada Health Infoway, Inc.
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
 * Last modified: $LastChangedDate: 2011-05-04 15:47:15 -0400 (Wed, 04 May 2011) $
 * Revision:      $LastChangedRevision: 2623 $
 */
/* This class was auto-generated by the message builder generator tools. */
namespace Ca.Infoway.Messagebuilder.Model.Pcs_cerx_v01_r04_4.Iehr.Repc_mt000013ca {
    using Ca.Infoway.Messagebuilder.Annotation;
    using Ca.Infoway.Messagebuilder.Datatype;
    using Ca.Infoway.Messagebuilder.Datatype.Impl;
    using Ca.Infoway.Messagebuilder.Datatype.Lang;
    using Ca.Infoway.Messagebuilder.Domainvalue;
    using Ca.Infoway.Messagebuilder.Model;
    using Ca.Infoway.Messagebuilder.Model.Pcs_cerx_v01_r04_4.Common.Coct_mt050203ca;
    using Ca.Infoway.Messagebuilder.Model.Pcs_cerx_v01_r04_4.Iehr.Merged;
    using Ca.Infoway.Messagebuilder.Model.Pcs_cerx_v01_r04_4.Merged;
    using System;
    using System.Collections.Generic;


    /**
     * <summary>Business Name: Allergy/Intolerance</summary>
     * 
     * <p>Necessary component of a person's overall medication and 
     * clinical profile. Helps with drug contraindication 
     * checking.</p> <p>A record of a patient's allergy or 
     * intolerance.</p>
     */
    [Hl7PartTypeMappingAttribute(new string[] {"REPC_MT000013CA.IntoleranceCondition"})]
    public class AllergyIntolerance : MessagePartBean {

        private II id;
        private CD code;
        private BL negationInd;
        private CS statusCode;
        private TS effectiveTime;
        private CV confidentialityCode;
        private CV uncertaintyCode;
        private Ca.Infoway.Messagebuilder.Model.Pcs_cerx_v01_r04_4.Common.Coct_mt050203ca.Patient subjectPatient;
        private Ca.Infoway.Messagebuilder.Model.Pcs_cerx_v01_r04_4.Iehr.Merged.ReportedBy informant;
        private IList<Ca.Infoway.Messagebuilder.Model.Pcs_cerx_v01_r04_4.Iehr.Merged.IRecords> supportRecords;
        private Ca.Infoway.Messagebuilder.Model.Pcs_cerx_v01_r04_4.Merged.AllergyIntoleranceSeverityLevel subjectOfSeverityObservation;

        public AllergyIntolerance() {
            this.id = new IIImpl();
            this.code = new CDImpl();
            this.negationInd = new BLImpl();
            this.statusCode = new CSImpl();
            this.effectiveTime = new TSImpl();
            this.confidentialityCode = new CVImpl();
            this.uncertaintyCode = new CVImpl();
            this.supportRecords = new List<Ca.Infoway.Messagebuilder.Model.Pcs_cerx_v01_r04_4.Iehr.Merged.IRecords>();
        }
        /**
         * <summary>Business Name: D:Allergy/Intolerance Record Id</summary>
         * 
         * <remarks>Relationship: 
         * REPC_MT000013CA.IntoleranceCondition.id 
         * Conformance/Cardinality: MANDATORY (1) <p>Indicates the 
         * allergy or intolerance record to be updated and is therefore 
         * mandatory.</p> <p>Unique identifier for an 
         * allergy/intolerance record.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"id"})]
        public Identifier Id {
            get { return this.id.Value; }
            set { this.id.Value = value; }
        }

        /**
         * <summary>Business Name: A:Allergy/Intolerance Type</summary>
         * 
         * <remarks>Relationship: 
         * REPC_MT000013CA.IntoleranceCondition.code 
         * Conformance/Cardinality: MANDATORY (1) <p>Allows for the 
         * separation of allergy and intolerance records. The type of 
         * condition is critical to understanding the record and is 
         * therefore mandatory. It is expressed as a CD to allow for 
         * SNOMED post-coordination.</p> <p>A coded value denoting 
         * whether the record pertains to an intolerance or a true 
         * allergy. (Allergies result from immunologic reactions. 
         * Intolerances do not.)</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"code"})]
        public ObservationIntoleranceType Code {
            get { return (ObservationIntoleranceType) this.code.Value; }
            set { this.code.Value = value; }
        }

        /**
         * <summary>Business Name: G:Allergy/Intolerance Refuted</summary>
         * 
         * <remarks>Relationship: 
         * REPC_MT000013CA.IntoleranceCondition.negationInd 
         * Conformance/Cardinality: MANDATORY (1) <p>Allows providers 
         * to refute a previously confirmed or suspected allergy. 
         * Because it is essential to know whether the allergy or 
         * intolerance is being refuted or affirmed, this attribute is 
         * mandatory.</p> <p>An indication that the allergy/intolerance 
         * has been refuted. I.e. A clinician has positively determined 
         * that the patient does not suffer from a particular allergy 
         * or intolerance.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"negationInd"})]
        public bool? NegationInd {
            get { return this.negationInd.Value; }
            set { this.negationInd.Value = value; }
        }

        /**
         * <summary>Business Name: E:Allergy/Intolerance Status</summary>
         * 
         * <remarks>Relationship: 
         * REPC_MT000013CA.IntoleranceCondition.statusCode 
         * Conformance/Cardinality: MANDATORY (1) <p>Allows providers 
         * to evaluate the relevance of a recorded allergy/intolerance. 
         * The status has a default value of 'ACTIVE' and is therefore 
         * mandatory.</p> <p>System must default the status to 
         * 'ACTIVE'.</p> <p>A coded value that indicates whether an 
         * allergy/intolerance is 'ACTIVE' or 'COMPLETE' (indicating no 
         * longer active).</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"statusCode"})]
        public ActStatus StatusCode {
            get { return (ActStatus) this.statusCode.Value; }
            set { this.statusCode.Value = value; }
        }

        /**
         * <summary>Business Name: I:Allergy/Intolerance Date</summary>
         * 
         * <remarks>Relationship: 
         * REPC_MT000013CA.IntoleranceCondition.effectiveTime 
         * Conformance/Cardinality: REQUIRED (0-1) <p>Allows providers 
         * to evaluate the period of relevance for the 
         * allergy/intolerance record.</p> <p>The date on which the 
         * recorded allergy is considered active.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"effectiveTime"})]
        public PlatformDate EffectiveTime {
            get { return this.effectiveTime.Value; }
            set { this.effectiveTime.Value = value; }
        }

        /**
         * <summary>Business Name: H:Allergy/Intolerance Masking 
         * Indicator</summary>
         * 
         * <remarks>Relationship: 
         * REPC_MT000013CA.IntoleranceCondition.confidentialityCode 
         * Conformance/Cardinality: OPTIONAL (0-1) <p>Provides support 
         * for additional confidentiality constraint to reflect the 
         * wishes of the patient.</p><p>The attribute is optional 
         * because not all systems will support masking.</p> <p>Denotes 
         * access restriction placed on the allergy or intolerance 
         * record. Methods for accessing masked allergy records will be 
         * governed by each jurisdiction (e.g. court orders, shared 
         * secret/consent, etc.). The default confidentiality level is 
         * 'NORMAL'.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"confidentialityCode"})]
        public x_VeryBasicConfidentialityKind ConfidentialityCode {
            get { return (x_VeryBasicConfidentialityKind) this.confidentialityCode.Value; }
            set { this.confidentialityCode.Value = value; }
        }

        /**
         * <summary>Business Name: F:Confirmed Indicator</summary>
         * 
         * <remarks>Relationship: 
         * REPC_MT000013CA.IntoleranceCondition.uncertaintyCode 
         * Conformance/Cardinality: MANDATORY (1) <p>Helps other 
         * providers to make appropriate decisions in their management 
         * of allergy or intolerance contraindications.</p><p>Attribute 
         * is mandatory because an allergy or intolerance record must 
         * be tagged as either 'confirmed' or 'suspected'.</p> <p>An 
         * indication of the level of confidence/surety placed in the 
         * recorded information.</p><p>The two valid codes are:</p><p>- 
         * U (stated with uncertainty) -Specifies that the author of 
         * the act affirms the uncertainty of the act statement. In 
         * other words, they know that parts of the act statement are 
         * not certain or are inferred. An example of this is an 
         * inferred prescription where some order data is inferred from 
         * a supply event (i.e. dispense).</p><p>- N (stated with no 
         * assertion of uncertainty) - Specifies that the act statement 
         * is made without any explicit expression of 
         * certainty/uncertainty. This is the normal statement, meaning 
         * that it may not be free of errors and uncertainty may still 
         * exist. In healthcare, N is believed to express certainty to 
         * the strength possible.</p><p>An allergy or intolerance 
         * record is always used in drug contraindication checking 
         * whether the record is U or N.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"uncertaintyCode"})]
        public ActUncertainty UncertaintyCode {
            get { return (ActUncertainty) this.uncertaintyCode.Value; }
            set { this.uncertaintyCode.Value = value; }
        }

        /**
         * <summary>Relationship: REPC_MT000013CA.Subject2.patient</summary>
         * 
         * <remarks>Conformance/Cardinality: MANDATORY (1)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"subject/patient"})]
        public Ca.Infoway.Messagebuilder.Model.Pcs_cerx_v01_r04_4.Common.Coct_mt050203ca.Patient SubjectPatient {
            get { return this.subjectPatient; }
            set { this.subjectPatient = value; }
        }

        /**
         * <summary>Relationship: 
         * REPC_MT000013CA.IntoleranceCondition.informant</summary>
         * 
         * <remarks>Conformance/Cardinality: REQUIRED (0-1)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"informant"})]
        public Ca.Infoway.Messagebuilder.Model.Pcs_cerx_v01_r04_4.Iehr.Merged.ReportedBy Informant {
            get { return this.informant; }
            set { this.informant = value; }
        }

        /**
         * <summary>Relationship: REPC_MT000013CA.Support.records</summary>
         * 
         * <remarks>Conformance/Cardinality: REQUIRED (1)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"support/records"})]
        public IList<Ca.Infoway.Messagebuilder.Model.Pcs_cerx_v01_r04_4.Iehr.Merged.IRecords> SupportRecords {
            get { return this.supportRecords; }
        }

        /**
         * <summary>Relationship: 
         * REPC_MT000013CA.Subject1.severityObservation</summary>
         * 
         * <remarks>Conformance/Cardinality: POPULATED (1)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"subjectOf/severityObservation"})]
        public Ca.Infoway.Messagebuilder.Model.Pcs_cerx_v01_r04_4.Merged.AllergyIntoleranceSeverityLevel SubjectOfSeverityObservation {
            get { return this.subjectOfSeverityObservation; }
            set { this.subjectOfSeverityObservation = value; }
        }

    }

}