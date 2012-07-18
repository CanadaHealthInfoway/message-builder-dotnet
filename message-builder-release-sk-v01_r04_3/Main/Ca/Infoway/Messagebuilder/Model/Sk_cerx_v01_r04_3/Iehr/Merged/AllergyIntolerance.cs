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
namespace Ca.Infoway.Messagebuilder.Model.Sk_cerx_v01_r04_3.Iehr.Merged {
    using Ca.Infoway.Messagebuilder.Annotation;
    using Ca.Infoway.Messagebuilder.Datatype;
    using Ca.Infoway.Messagebuilder.Datatype.Impl;
    using Ca.Infoway.Messagebuilder.Datatype.Lang;
    using Ca.Infoway.Messagebuilder.Domainvalue;
    using Ca.Infoway.Messagebuilder.Model;
    using Ca.Infoway.Messagebuilder.Model.Sk_cerx_v01_r04_3.Common.Merged;
    using Ca.Infoway.Messagebuilder.Model.Sk_cerx_v01_r04_3.Merged;
    using System;
    using System.Collections.Generic;


    /**
     * <summary>AllergyIntolerance</summary>
     * 
     * <remarks>REPC_MT000001CA.IntoleranceCondition: 
     * Allergy/Intolerance <p>Value is mandatory if not using 
     * SNOMED</p> <p>A record of a patient's allergy or 
     * intolerance.</p> <p>Necessary component of a person's 
     * overall medication and clinical profile. Helps with drug 
     * contraindication checking.</p> 
     * REPC_MT000013CA.IntoleranceCondition: Allergy/Intolerance 
     * <p>A record of a patient's allergy or intolerance.</p> 
     * <p>Necessary component of a person's overall medication and 
     * clinical profile. Helps with drug contraindication 
     * checking.</p></remarks>
     */
    [Hl7PartTypeMappingAttribute(new string[] {"REPC_MT000001CA.IntoleranceCondition","REPC_MT000013CA.IntoleranceCondition"})]
    public class AllergyIntolerance : MessagePartBean {

        private CD code;
        private BL negationInd;
        private CS statusCode;
        private TS effectiveTime;
        private CV confidentialityCode;
        private CV uncertaintyCode;
        private CV value;
        private Ca.Infoway.Messagebuilder.Model.Sk_cerx_v01_r04_3.Common.Merged.Patient subjectPatient;
        private Ca.Infoway.Messagebuilder.Model.Sk_cerx_v01_r04_3.Iehr.Merged.ReportedBy informant;
        private IList<Ca.Infoway.Messagebuilder.Model.Sk_cerx_v01_r04_3.Iehr.Merged.IRecords> supportRecords;
        private Ca.Infoway.Messagebuilder.Model.Sk_cerx_v01_r04_3.Merged.Comment subjectOf1Annotation;
        private Ca.Infoway.Messagebuilder.Model.Sk_cerx_v01_r04_3.Merged.AllergyIntoleranceSeverityLevel subjectOfSeverityObservation;
        private II id;

        public AllergyIntolerance() {
            this.code = new CDImpl();
            this.negationInd = new BLImpl();
            this.statusCode = new CSImpl();
            this.effectiveTime = new TSImpl();
            this.confidentialityCode = new CVImpl();
            this.uncertaintyCode = new CVImpl();
            this.value = new CVImpl();
            this.supportRecords = new List<Ca.Infoway.Messagebuilder.Model.Sk_cerx_v01_r04_3.Iehr.Merged.IRecords>();
            this.id = new IIImpl();
        }
        /**
         * <summary>AllergyIntoleranceType</summary>
         * 
         * <remarks>A:Allergy/Intolerance Type <p>A coded value 
         * denoting whether the record pertains to an intolerance or a 
         * true allergy. (Allergies result from immunologic reactions. 
         * Intolerances do not.)</p> <p>Allows for the separation of 
         * allergy and intolerance records. The type of condition is 
         * critical to understanding the record and is therefore 
         * mandatory. It is expressed as a CD to allow for SNOMED 
         * post-coordination.</p> <p>This will indicate whether this is 
         * a drug allergy, a non- drug allergy, a drug intolerance, or 
         * a non-drug intolerance. <strong>CODE_INVAL error issue will 
         * be returned if non- leaf-level codes are sent, i.e. OINT is 
         * not allowed while EALG is.</strong></p> Allergy/Intolerance 
         * Type <p>A coded value denoting whether the record pertains 
         * to an intolerance or a true allergy. (Allergies result from 
         * immunologic reactions. Intolerances do not.)</p> <p>Allows 
         * for the separation of allergy and intolerance records. The 
         * type of condition is critical to understanding the record 
         * and is therefore mandatory. It is expressed as a CD to allow 
         * for SNOMED post-coordination.</p> <p>This will indicate 
         * whether this is a drug allergy, a non- drug allergy, a drug 
         * intolerance, or a non-drug intolerance. <strong>CODE_INVAL 
         * error issue will be returned if non- leaf-level codes are 
         * sent, i.e. OINT is not allowed while EALG is.</strong></p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"code"})]
        public ObservationIntoleranceType Code {
            get { return (ObservationIntoleranceType) this.code.Value; }
            set { this.code.Value = value; }
        }

        /**
         * <summary>AllergyIntoleranceRefuted</summary>
         * 
         * <remarks>G:Allergy/Intolerance Refuted <p>An indication that 
         * the allergy/intolerance has been refuted. I.e. A clinician 
         * has positively determined that the patient does not suffer 
         * from a particular allergy or intolerance.</p> <p>Allows 
         * providers to refute a previously confirmed or suspected 
         * allergy. The attribute is mandatory because it is essential 
         * to know whether a record is refuted or not.</p> 
         * G:Allergy/Intolerance Refuted <p>An indication that the 
         * allergy/intolerance has been refuted. I.e. A clinician has 
         * positively determined that the patient does not suffer from 
         * a particular allergy or intolerance.</p> <p>Allows providers 
         * to refute a previously confirmed or suspected allergy. 
         * Because it is essential to know whether the allergy or 
         * intolerance is being refuted or affirmed, this attribute is 
         * mandatory.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"negationInd"})]
        public bool? NegationInd {
            get { return this.negationInd.Value; }
            set { this.negationInd.Value = value; }
        }

        /**
         * <summary>AllergyIntoleranceStatus</summary>
         * 
         * <remarks>E:Allergy/Intolerance Status <p>A coded value that 
         * indicates whether an allergy/intolerance is 'ACTIVE' or 
         * 'COMPLETE' (indicating no longer active).</p> <p>Allows 
         * providers to evaluate the relevance of a recorded 
         * allergy/intolerance. The status has a default value of 
         * 'ACTIVE' and is therefore mandatory.</p> <p>System must 
         * default the status to 'ACTIVE'.</p> <p>This can be "active" 
         * or "completed". <strong>CODE_INVAL error issue will be 
         * returned if not.</strong></p> E:Allergy/Intolerance Status 
         * <p>A coded value that indicates whether an 
         * allergy/intolerance is 'active' or 'completed' (indicating 
         * no longer active).</p> <p>Allows providers to evaluate the 
         * relevance of a recorded allergy/intolerance. The status has 
         * a default value of 'active' and is therefore mandatory.</p> 
         * <p>System must default the status to 'active'. CODE_INVAL 
         * error issue will be returned if not set to either 'active' 
         * or 'completed'.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"statusCode"})]
        public ActStatus StatusCode {
            get { return (ActStatus) this.statusCode.Value; }
            set { this.statusCode.Value = value; }
        }

        /**
         * <summary>AllergyIntoleranceDate</summary>
         * 
         * <remarks>I:Allergy/Intolerance Date </p> <p>Allows providers 
         * to evaluate the period of relevance for the 
         * allergy/intolerance record.</p> I:Allergy/Intolerance Date 
         * <p>The date on which the recorded allergy is considered 
         * active.</p> <p>Allows providers to evaluate the period of 
         * relevance for the allergy/intolerance record.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"effectiveTime"})]
        public PlatformDate EffectiveTime {
            get { return this.effectiveTime.Value; }
            set { this.effectiveTime.Value = value; }
        }

        /**
         * <summary>AllergyIntoleranceMaskingIndicator</summary>
         * 
         * <remarks>H:Allergy/Intolerance Masking Indicator <p>Denotes 
         * access restriction placed on the allergy or intolerance 
         * record. Methods for accessing masked allergy records will be 
         * governed by each jurisdiction (e.g. court orders, shared 
         * secret/consent, etc.). The default confidentiality level is 
         * 'NORMAL'.</p> <p>Provides support for additional 
         * confidentiality constraint to reflect the wishes of the 
         * patient.</p><p>The attribute is optional because not all 
         * systems will support masking.</p> <p>Provides support for 
         * additional confidentiality constraint to reflect the wishes 
         * of the patient.</p><p>The attribute is optional because not 
         * all systems will support masking.</p> <p>This indicates 
         * whether the allergy should be masked or not. <strong>As SK 
         * does not implement record-level masking, this must be 
         * "Normal" or a CODE_INVAL error issue will be 
         * returned.</strong></p> H:Allergy/Intolerance Masking 
         * Indicator <p>Denotes access restriction placed on the 
         * allergy or intolerance record. Methods for accessing masked 
         * allergy records will be governed by each jurisdiction (e.g. 
         * court orders, shared secret/consent, etc.). The default 
         * confidentiality level is 'NORMAL'.</p> <p>Provides support 
         * for additional confidentiality constraint to reflect the 
         * wishes of the patient.</p><p>The attribute is optional 
         * because not all systems will support masking.</p> 
         * <p>Provides support for additional confidentiality 
         * constraint to reflect the wishes of the patient.</p><p>The 
         * attribute is optional because not all systems will support 
         * masking.</p> <p><strong>As SK does not implement 
         * record-level masking, this must be </strong><strong>NORMAL 
         * or a CODE_INVAL error issue will be returned.</strong></p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"confidentialityCode"})]
        public x_VeryBasicConfidentialityKind ConfidentialityCode {
            get { return (x_VeryBasicConfidentialityKind) this.confidentialityCode.Value; }
            set { this.confidentialityCode.Value = value; }
        }

        /**
         * <summary>ConfirmedIndicator</summary>
         * 
         * <remarks>F:Confirmed Indicator <p>An allergy or intolerance 
         * record is always used in drug contraindication checking 
         * whether the record is tagged as 'confirmed' or 
         * 'suspected'.</p> <p>An indication of the level of 
         * confidence/surety placed in the recorded 
         * information.</p><p>The two valid codes are:</p><p>- U 
         * (stated with uncertainty) -Specifies that the author of the 
         * act affirms the uncertainty of the act statement. In other 
         * words, they know that parts of the act statement are not 
         * certain or are inferred. An example of this is an inferred 
         * prescription where some order data is inferred from a supply 
         * event (i.e. dispense).</p><p>- N (stated with no assertion 
         * of uncertainty) - Specifies that the act statement is made 
         * without any explicit expression of certainty/uncertainty. 
         * This is the normal statement, meaning that it may not be 
         * free of errors and uncertainty may still exist. In 
         * healthcare, N is believed to express certainty to the 
         * strength possible.</p><p>An allergy or intolerance record is 
         * always used in drug contraindication checking whether the 
         * record is U or N.</p> <p>An indication of the level of 
         * confidence/surety placed in the recorded 
         * information.</p><p>The two valid codes are:</p><p>- U 
         * (stated with uncertainty) -Specifies that the author of the 
         * act affirms the uncertainty of the act statement. In other 
         * words, they know that parts of the act statement are not 
         * certain or are inferred. An example of this is an inferred 
         * prescription where some order data is inferred from a supply 
         * event (i.e. dispense).</p><p>- N (stated with no assertion 
         * of uncertainty) - Specifies that the act statement is made 
         * without any explicit expression of certainty/uncertainty. 
         * This is the normal statement, meaning that it may not be 
         * free of errors and uncertainty may still exist. In 
         * healthcare, N is believed to express certainty to the 
         * strength possible.</p><p>An allergy or intolerance record is 
         * always used in drug contraindication checking whether the 
         * record is U or N.</p> <p>An indication of the level of 
         * confidence/surety placed in the recorded 
         * information.</p><p>The two valid codes are:</p><p>- U 
         * (stated with uncertainty) -Specifies that the author of the 
         * act affirms the uncertainty of the act statement. In other 
         * words, they know that parts of the act statement are not 
         * certain or are inferred. An example of this is an inferred 
         * prescription where some order data is inferred from a supply 
         * event (i.e. dispense).</p><p>- N (stated with no assertion 
         * of uncertainty) - Specifies that the act statement is made 
         * without any explicit expression of certainty/uncertainty. 
         * This is the normal statement, meaning that it may not be 
         * free of errors and uncertainty may still exist. In 
         * healthcare, N is believed to express certainty to the 
         * strength possible.</p><p>An allergy or intolerance record is 
         * always used in drug contraindication checking whether the 
         * record is U or N.</p> <p>An indication of the level of 
         * confidence/surety placed in the recorded 
         * information.</p><p>The two valid codes are:</p><p>- U 
         * (stated with uncertainty) -Specifies that the author of the 
         * act affirms the uncertainty of the act statement. In other 
         * words, they know that parts of the act statement are not 
         * certain or are inferred. An example of this is an inferred 
         * prescription where some order data is inferred from a supply 
         * event (i.e. dispense).</p><p>- N (stated with no assertion 
         * of uncertainty) - Specifies that the act statement is made 
         * without any explicit expression of certainty/uncertainty. 
         * This is the normal statement, meaning that it may not be 
         * free of errors and uncertainty may still exist. In 
         * healthcare, N is believed to express certainty to the 
         * strength possible.</p><p>An allergy or intolerance record is 
         * always used in drug contraindication checking whether the 
         * record is U or N.</p> <p>Helps other providers to make 
         * appropriate decisions in their management of allergy or 
         * intolerance contraindications.</p><p>Attribute is mandatory 
         * because an allergy or intolerance record must be tagged as 
         * either 'confirmed' or 'suspected'.</p> <p>Helps other 
         * providers to make appropriate decisions in their management 
         * of allergy or intolerance contraindications.</p><p>Attribute 
         * is mandatory because an allergy or intolerance record must 
         * be tagged as either 'confirmed' or 'suspected'.</p> <p>This 
         * can be 'N' or 'U'. <strong>CODE_INVAL error issue will be 
         * returned if not.</strong></p> F:Confirmed Indicator <p>An 
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
         * whether the record is U or N.</p> <p>An indication of the 
         * level of confidence/surety placed in the recorded 
         * information.</p><p>The two valid codes are:</p><p>- U 
         * (stated with uncertainty) -Specifies that the author of the 
         * act affirms the uncertainty of the act statement. In other 
         * words, they know that parts of the act statement are not 
         * certain or are inferred. An example of this is an inferred 
         * prescription where some order data is inferred from a supply 
         * event (i.e. dispense).</p><p>- N (stated with no assertion 
         * of uncertainty) - Specifies that the act statement is made 
         * without any explicit expression of certainty/uncertainty. 
         * This is the normal statement, meaning that it may not be 
         * free of errors and uncertainty may still exist. In 
         * healthcare, N is believed to express certainty to the 
         * strength possible.</p><p>An allergy or intolerance record is 
         * always used in drug contraindication checking whether the 
         * record is U or N.</p> <p>An indication of the level of 
         * confidence/surety placed in the recorded 
         * information.</p><p>The two valid codes are:</p><p>- U 
         * (stated with uncertainty) -Specifies that the author of the 
         * act affirms the uncertainty of the act statement. In other 
         * words, they know that parts of the act statement are not 
         * certain or are inferred. An example of this is an inferred 
         * prescription where some order data is inferred from a supply 
         * event (i.e. dispense).</p><p>- N (stated with no assertion 
         * of uncertainty) - Specifies that the act statement is made 
         * without any explicit expression of certainty/uncertainty. 
         * This is the normal statement, meaning that it may not be 
         * free of errors and uncertainty may still exist. In 
         * healthcare, N is believed to express certainty to the 
         * strength possible.</p><p>An allergy or intolerance record is 
         * always used in drug contraindication checking whether the 
         * record is U or N.</p> <p>An indication of the level of 
         * confidence/surety placed in the recorded 
         * information.</p><p>The two valid codes are:</p><p>- U 
         * (stated with uncertainty) -Specifies that the author of the 
         * act affirms the uncertainty of the act statement. In other 
         * words, they know that parts of the act statement are not 
         * certain or are inferred. An example of this is an inferred 
         * prescription where some order data is inferred from a supply 
         * event (i.e. dispense).</p><p>- N (stated with no assertion 
         * of uncertainty) - Specifies that the act statement is made 
         * without any explicit expression of certainty/uncertainty. 
         * This is the normal statement, meaning that it may not be 
         * free of errors and uncertainty may still exist. In 
         * healthcare, N is believed to express certainty to the 
         * strength possible.</p><p>An allergy or intolerance record is 
         * always used in drug contraindication checking whether the 
         * record is U or N.</p> <p>An indication of the level of 
         * confidence/surety 
         * ... [rest of documentation truncated due to excessive length]
         */
        [Hl7XmlMappingAttribute(new string[] {"uncertaintyCode"})]
        public ActUncertainty UncertaintyCode {
            get { return (ActUncertainty) this.uncertaintyCode.Value; }
            set { this.uncertaintyCode.Value = value; }
        }

        /**
         * <summary>Agent</summary>
         * 
         * <remarks>B:Agent <p>Indicates the substance to which the 
         * patient is allergic</p> <p>Critical for identifying the 
         * allergy or intolerance. However, because the attribute is 
         * not used for SNOMED, it is optional.</p> <p><strong>PIN is 
         * extending the IntoleranceValue vocabulary to include FDB 
         * Allergen Group Codes and will not accept the ClinicalDrug 
         * child domain vocabulary. Because PIN is not using SNOMED, 
         * this attribute is mandatory.</strong></p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"value"})]
        public IntoleranceValue Value {
            get { return (IntoleranceValue) this.value.Value; }
            set { this.value.Value = value; }
        }

        /**
         * <summary>SufferedBy</summary>
         * 
         * <remarks>Suffered By <div>Identifies the person suffering 
         * from the&nbsp;allergy/intolerance.&nbsp;</div></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"subject/patient"})]
        public Ca.Infoway.Messagebuilder.Model.Sk_cerx_v01_r04_3.Common.Merged.Patient SubjectPatient {
            get { return this.subjectPatient; }
            set { this.subjectPatient = value; }
        }

        /**
         * <summary>ReportedBy</summary>
         * 
         * <remarks>Reported By <p>&nbsp;Indicates where the 
         * information that led to the&nbsp;recording of this 
         * information came from.</p> Reported By <p><strong>Indicates 
         * where the information that led to the recording of this 
         * information came from.</strong></p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"informant"})]
        public Ca.Infoway.Messagebuilder.Model.Sk_cerx_v01_r04_3.Iehr.Merged.ReportedBy Informant {
            get { return this.informant; }
            set { this.informant = value; }
        }

        /**
         * <summary>SupportedBy</summary>
         * 
         * <remarks>Supported By <div>provides evidence for the 
         * existence (or non-existence)&nbsp;of the 
         * allergy/intolerance.&nbsp;</div> Supported By 
         * </font></font></font></p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"support/records"})]
        public IList<Ca.Infoway.Messagebuilder.Model.Sk_cerx_v01_r04_3.Iehr.Merged.IRecords> SupportRecords {
            get { return this.supportRecords; }
        }

        /**
         * <summary>(no business name)</summary>
         * 
         * <remarks><p>&nbsp;</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"subjectOf1/annotation"})]
        public Ca.Infoway.Messagebuilder.Model.Sk_cerx_v01_r04_3.Merged.Comment SubjectOf1Annotation {
            get { return this.subjectOf1Annotation; }
            set { this.subjectOf1Annotation = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"subjectOf/severityObservation","subjectOf2/severityObservation"})]
        [Hl7MapByPartType(Name="subjectOf", Type="REPC_MT000013CA.Subject1")]
        [Hl7MapByPartType(Name="subjectOf/severityObservation", Type="REPC_MT000013CA.SeverityObservation")]
        [Hl7MapByPartType(Name="subjectOf2", Type="REPC_MT000001CA.Subject1")]
        [Hl7MapByPartType(Name="subjectOf2/severityObservation", Type="REPC_MT000001CA.SeverityObservation")]
        public Ca.Infoway.Messagebuilder.Model.Sk_cerx_v01_r04_3.Merged.AllergyIntoleranceSeverityLevel SubjectOfSeverityObservation {
            get { return this.subjectOfSeverityObservation; }
            set { this.subjectOfSeverityObservation = value; }
        }

        /**
         * <summary>AllergyIntoleranceRecordId</summary>
         * 
         * <remarks>D:Allergy/Intolerance Record Id <p>Unique 
         * identifier for an allergy/intolerance record.</p> 
         * <p>Indicates the allergy or intolerance record to be updated 
         * and is therefore mandatory.</p> <p>This is the identifier of 
         * the allergy/intolerance record to update. <strong>A KEY204 
         * error issue will be returned if this ID does not exist in 
         * PIN.</strong></p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"id"})]
        public Identifier Id {
            get { return this.id.Value; }
            set { this.id.Value = value; }
        }

    }

}