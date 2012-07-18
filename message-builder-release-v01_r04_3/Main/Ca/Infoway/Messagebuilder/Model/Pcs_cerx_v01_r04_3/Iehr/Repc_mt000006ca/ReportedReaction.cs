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
 * Last modified: $LastChangedDate: 2012-02-16 10:57:47 -0500 (Thu, 16 Feb 2012) $
 * Revision:      $LastChangedRevision: 5364 $
 */
/* This class was auto-generated by the message builder generator tools. */
namespace Ca.Infoway.Messagebuilder.Model.Pcs_cerx_v01_r04_3.Iehr.Repc_mt000006ca {
    using Ca.Infoway.Messagebuilder.Annotation;
    using Ca.Infoway.Messagebuilder.Datatype;
    using Ca.Infoway.Messagebuilder.Datatype.Impl;
    using Ca.Infoway.Messagebuilder.Datatype.Lang;
    using Ca.Infoway.Messagebuilder.Domainvalue;
    using Ca.Infoway.Messagebuilder.Model;
    using Ca.Infoway.Messagebuilder.Model.Pcs_cerx_v01_r04_3.Common.Coct_mt090107ca;
    using Ca.Infoway.Messagebuilder.Model.Pcs_cerx_v01_r04_3.Common.Merged;
    using Ca.Infoway.Messagebuilder.Model.Pcs_cerx_v01_r04_3.Iehr.Merged;
    using Ca.Infoway.Messagebuilder.Model.Pcs_cerx_v01_r04_3.Merged;
    using System;
    using System.Collections.Generic;


    /**
     * <summary>Reported Reaction</summary>
     * 
     * <remarks><p>Value is mandatory if not using 
     * SNOMED</p><p>Code is fixed to DX if not using SNOMED</p> 
     * <p>Value is mandatory if not using SNOMED</p><p>Code is 
     * fixed to DX if not using SNOMED</p> <p>This is a record of 
     * an adverse reaction considered relevant to the patient's 
     * clinical record.</p> <p>Useful in tracking reactions when it 
     * is not known precisely what product they are associated with 
     * and whether the reaction is due to an allergy or 
     * intolerance, a drug interaction or some other cause. 
     * Effectively gives a 'heads up' to clinicians using the drug 
     * or combination of drugs.</p></remarks>
     */
    [Hl7PartTypeMappingAttribute(new string[] {"REPC_MT000006CA.ReactionObservationEvent"})]
    public class ReportedReaction : MessagePartBean {

        private II id;
        private CD code;
        private ST text;
        private IVL<TS, Interval<PlatformDate>> effectiveTime;
        private CV confidentialityCode;
        private CV value;
        private Ca.Infoway.Messagebuilder.Model.Pcs_cerx_v01_r04_3.Common.Merged.Patient subjectPatient;
        private Ca.Infoway.Messagebuilder.Model.Pcs_cerx_v01_r04_3.Common.Coct_mt090107ca.Provider responsiblePartyAssignedPerson;
        private Ca.Infoway.Messagebuilder.Model.Pcs_cerx_v01_r04_3.Merged.RefusedBy author;
        private Ca.Infoway.Messagebuilder.Model.Pcs_cerx_v01_r04_3.Iehr.Merged.ReportedBy informant;
        private Ca.Infoway.Messagebuilder.Model.Pcs_cerx_v01_r04_3.Merged.RecordedAt location;
        private IList<Ca.Infoway.Messagebuilder.Model.Pcs_cerx_v01_r04_3.Merged.Comment> subjectOf1Annotation;
        private BL subjectOf2AnnotationIndicator;
        private IList<Ca.Infoway.Messagebuilder.Model.Pcs_cerx_v01_r04_3.Iehr.Merged.ReportedReactions> subjectOf3CausalityAssessment;
        private Ca.Infoway.Messagebuilder.Model.Pcs_cerx_v01_r04_3.Merged.AllergyIntoleranceSeverityLevel subjectOf4SeverityObservation;

        public ReportedReaction() {
            this.id = new IIImpl();
            this.code = new CDImpl();
            this.text = new STImpl();
            this.effectiveTime = new IVLImpl<TS, Interval<PlatformDate>>();
            this.confidentialityCode = new CVImpl();
            this.value = new CVImpl();
            this.subjectOf1Annotation = new List<Ca.Infoway.Messagebuilder.Model.Pcs_cerx_v01_r04_3.Merged.Comment>();
            this.subjectOf2AnnotationIndicator = new BLImpl(false);
            this.subjectOf3CausalityAssessment = new List<Ca.Infoway.Messagebuilder.Model.Pcs_cerx_v01_r04_3.Iehr.Merged.ReportedReactions>();
        }
        /**
         * <summary>C:Reaction Record Id</summary>
         * 
         * <remarks><p>An identifier assigned to the record of the 
         * adverse reaction.</p> <p>Uniquely identifies the specific 
         * reaction record and is therefore mandatory.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"id"})]
        public Identifier Id {
            get { return this.id.Value; }
            set { this.id.Value = value; }
        }

        /**
         * <summary>Diagnosis Type</summary>
         * 
         * <remarks><p>Indicates the type of diagnosis being 
         * captured.</p> <p>Indicates that the observation is actually 
         * a diagnosis and is therefore mandatory. The datatype is CD 
         * to support SNOMED post-coordination.</p> <p>If using SNOMED, 
         * this will contain the diagnosis. Otherwise it will be a 
         * fixed value of 'DX'.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"code"})]
        public ActCode Code {
            get { return (ActCode) this.code.Value; }
            set { this.code.Value = value; }
        }

        /**
         * <summary>G:Description</summary>
         * 
         * <remarks><p>A free form description of the reaction.</p> 
         * <p>B.4</p> <p>Allows for flexibility in the recording and 
         * reporting of the reaction.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"text"})]
        public String Text {
            get { return this.text.Value; }
            set { this.text.Value = value; }
        }

        /**
         * <summary>F:Reaction Onset Date</summary>
         * 
         * <remarks><p>The date on which the reaction occurrence 
         * began.</p> <p>Indicates when evidence of the condition first 
         * appeared. May also provide information on the duration of 
         * the reaction.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"effectiveTime"})]
        public Interval<PlatformDate> EffectiveTime {
            get { return this.effectiveTime.Value; }
            set { this.effectiveTime.Value = value; }
        }

        /**
         * <summary>G:Adverse Reaction Masking Indicator</summary>
         * 
         * <remarks><p>Communicates the intent of the patient to 
         * restrict access to their adverse reactions. Provides support 
         * for additional confidentiality constraint, giving patients a 
         * level of control over their information. Valid values are: 
         * 'NORMAL' (denotes 'Not Masked'); and 'RESTRICTED' (denotes 
         * 'Masked'). The default is 'NORMAL' signifying 'Not 
         * Masked'.</p> <p>Allows the patient to have discrete control 
         * over access to their adverse reaction data.</p><p>The 
         * attribute is optional because not all systems will support 
         * masking.</p> <p>Allows the patient to have discrete control 
         * over access to their adverse reaction data.</p><p>The 
         * attribute is optional because not all systems will support 
         * masking.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"confidentialityCode"})]
        public x_VeryBasicConfidentialityKind ConfidentialityCode {
            get { return (x_VeryBasicConfidentialityKind) this.confidentialityCode.Value; }
            set { this.confidentialityCode.Value = value; }
        }

        /**
         * <summary>B:Reaction</summary>
         * 
         * <remarks><p>Specifies the kind of reaction, as experienced 
         * by the patient.</p> <p>B.1</p> <p>Ensures consistency in 
         * tracking and categorizing the reaction type. Helps ensure 
         * that only proper allergies are categorized as allergy. The 
         * attribute is optional because it will not be used for 
         * SNOMED. The attribute is CWE because not all possible types 
         * of reactions are expressible by coded values.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"value"})]
        public SubjectReaction Value {
            get { return (SubjectReaction) this.value.Value; }
            set { this.value.Value = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"subject/patient"})]
        public Ca.Infoway.Messagebuilder.Model.Pcs_cerx_v01_r04_3.Common.Merged.Patient SubjectPatient {
            get { return this.subjectPatient; }
            set { this.subjectPatient = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"responsibleParty/assignedPerson"})]
        public Ca.Infoway.Messagebuilder.Model.Pcs_cerx_v01_r04_3.Common.Coct_mt090107ca.Provider ResponsiblePartyAssignedPerson {
            get { return this.responsiblePartyAssignedPerson; }
            set { this.responsiblePartyAssignedPerson = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"author"})]
        public Ca.Infoway.Messagebuilder.Model.Pcs_cerx_v01_r04_3.Merged.RefusedBy Author {
            get { return this.author; }
            set { this.author = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"informant"})]
        public Ca.Infoway.Messagebuilder.Model.Pcs_cerx_v01_r04_3.Iehr.Merged.ReportedBy Informant {
            get { return this.informant; }
            set { this.informant = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"location"})]
        public Ca.Infoway.Messagebuilder.Model.Pcs_cerx_v01_r04_3.Merged.RecordedAt Location {
            get { return this.location; }
            set { this.location = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"subjectOf1/annotation"})]
        public IList<Ca.Infoway.Messagebuilder.Model.Pcs_cerx_v01_r04_3.Merged.Comment> SubjectOf1Annotation {
            get { return this.subjectOf1Annotation; }
        }

        [Hl7XmlMappingAttribute(new string[] {"subjectOf2/annotationIndicator"})]
        public bool? SubjectOf2AnnotationIndicator {
            get { return this.subjectOf2AnnotationIndicator.Value; }
            set { this.subjectOf2AnnotationIndicator.Value = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"subjectOf3/causalityAssessment"})]
        public IList<Ca.Infoway.Messagebuilder.Model.Pcs_cerx_v01_r04_3.Iehr.Merged.ReportedReactions> SubjectOf3CausalityAssessment {
            get { return this.subjectOf3CausalityAssessment; }
        }

        [Hl7XmlMappingAttribute(new string[] {"subjectOf4/severityObservation"})]
        public Ca.Infoway.Messagebuilder.Model.Pcs_cerx_v01_r04_3.Merged.AllergyIntoleranceSeverityLevel SubjectOf4SeverityObservation {
            get { return this.subjectOf4SeverityObservation; }
            set { this.subjectOf4SeverityObservation = value; }
        }

    }

}