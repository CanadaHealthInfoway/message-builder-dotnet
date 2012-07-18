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
 * Last modified: $LastChangedDate: 2012-02-16 11:13:00 -0500 (Thu, 16 Feb 2012) $
 * Revision:      $LastChangedRevision: 5549 $
 */
/* This class was auto-generated by the message builder generator tools. */
namespace Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r02.Iehr.Repc_mt000012ca {
    using Ca.Infoway.Messagebuilder;
    using Ca.Infoway.Messagebuilder.Annotation;
    using Ca.Infoway.Messagebuilder.Datatype;
    using Ca.Infoway.Messagebuilder.Datatype.Impl;
    using Ca.Infoway.Messagebuilder.Datatype.Lang;
    using Ca.Infoway.Messagebuilder.Domainvalue;
    using Ca.Infoway.Messagebuilder.Model;
    using Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r02.Iehr.Merged;
    using Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r02.Merged;
    using System;
    using System.Collections.Generic;


    /**
     * <summary>Reported Reaction</summary>
     * 
     * <remarks><p>Value must be mandatory if not using 
     * SNOMED</p><p>Code must be fixed to DX if not using 
     * SNOMED</p> <p>Value must be mandatory if not using 
     * SNOMED</p><p>Code must be fixed to DX if not using 
     * SNOMED</p> <p>This is a record of an adverse reaction 
     * considered relevant to the patient's clinical record.</p> 
     * <p>Useful in tracking reactions when it is not known 
     * precisely what product they are associated with and whether 
     * the reaction is due to an allergy or intolerance, a drug 
     * interaction or some other cause. Effectively gives a 'heads 
     * up' to clinicians using the drug or combination of 
     * drugs.</p></remarks>
     */
    [Hl7PartTypeMappingAttribute(new string[] {"REPC_MT000012CA.ReactionObservationEvent"})]
    public class ReportedReaction : MessagePartBean {

        private II id;
        private CD code;
        private ST text;
        private IVL<TS, Interval<PlatformDate>> effectiveTime;
        private SET<CV, Code> confidentialityCode;
        private CV value;
        private Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r02.Iehr.Merged.ReportedBy informant;
        private Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r02.Merged.AllergyIntoleranceSeverityLevel subjectOf1SeverityObservation;
        private IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r02.Iehr.Merged.ReportedReactions> subjectOf2CausalityAssessment;

        public ReportedReaction() {
            this.id = new IIImpl();
            this.code = new CDImpl();
            this.text = new STImpl();
            this.effectiveTime = new IVLImpl<TS, Interval<PlatformDate>>();
            this.confidentialityCode = new SETImpl<CV, Code>(typeof(CVImpl));
            this.value = new CVImpl();
            this.subjectOf2CausalityAssessment = new List<Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r02.Iehr.Merged.ReportedReactions>();
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
         * <p>Allows for flexibility in the recording and reporting of 
         * the reaction.</p></remarks>
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
         * <summary>G:Adverse Reaction Masking Indicators</summary>
         * 
         * <remarks><p>Communicates the intent of the patient to 
         * restrict access to their adverse reactions.</p><p>Provides 
         * support for additional confidentiality constraint, giving 
         * patients a level of control over their 
         * information.</p><p>Allows a provider to request restricted 
         * access by the patient.</p><p>Valid values are: 'N' (normal - 
         * denotes 'Not Masked'); 'R' (restricted - denotes 'Masked') 
         * and 'T' (taboo - denotes 'Patient Access 
         * Restricted').</p><p>The default is 'normal' signifying 'Not 
         * Masked'.</p> <p>Communicates the intent of the patient to 
         * restrict access to their adverse reactions.</p><p>Provides 
         * support for additional confidentiality constraint, giving 
         * patients a level of control over their 
         * information.</p><p>Allows a provider to request restricted 
         * access by the patient.</p><p>Valid values are: 'N' (normal - 
         * denotes 'Not Masked'); 'R' (restricted - denotes 'Masked') 
         * and 'T' (taboo - denotes 'Patient Access 
         * Restricted').</p><p>The default is 'normal' signifying 'Not 
         * Masked'.</p> <p>Communicates the intent of the patient to 
         * restrict access to their adverse reactions.</p><p>Provides 
         * support for additional confidentiality constraint, giving 
         * patients a level of control over their 
         * information.</p><p>Allows a provider to request restricted 
         * access by the patient.</p><p>Valid values are: 'N' (normal - 
         * denotes 'Not Masked'); 'R' (restricted - denotes 'Masked') 
         * and 'T' (taboo - denotes 'Patient Access 
         * Restricted').</p><p>The default is 'normal' signifying 'Not 
         * Masked'.</p> <p>Communicates the intent of the patient to 
         * restrict access to their adverse reactions.</p><p>Provides 
         * support for additional confidentiality constraint, giving 
         * patients a level of control over their 
         * information.</p><p>Allows a provider to request restricted 
         * access by the patient.</p><p>Valid values are: 'N' (normal - 
         * denotes 'Not Masked'); 'R' (restricted - denotes 'Masked') 
         * and 'T' (taboo - denotes 'Patient Access 
         * Restricted').</p><p>The default is 'normal' signifying 'Not 
         * Masked'.</p> <p>Communicates the intent of the patient to 
         * restrict access to their adverse reactions.</p><p>Provides 
         * support for additional confidentiality constraint, giving 
         * patients a level of control over their 
         * information.</p><p>Allows a provider to request restricted 
         * access by the patient.</p><p>Valid values are: 'N' (normal - 
         * denotes 'Not Masked'); 'R' (restricted - denotes 'Masked') 
         * and 'T' (taboo - denotes 'Patient Access 
         * Restricted').</p><p>The default is 'normal' signifying 'Not 
         * Masked'.</p> <p>Allows the patient to have discrete control 
         * over access to their adverse reaction data.</p><p>Taboo 
         * allows the provider to request restricted access to patient 
         * or their care giver.</p><p>Constraint: Cant have both normal 
         * and one of the other codes simultaneously.</p><p>The 
         * attribute is optional because not all systems will support 
         * masking.</p> <p>Allows the patient to have discrete control 
         * over access to their adverse reaction data.</p><p>Taboo 
         * allows the provider to request restricted access to patient 
         * or their care giver.</p><p>Constraint: Cant have both normal 
         * and one of the other codes simultaneously.</p><p>The 
         * attribute is optional because not all systems will support 
         * masking.</p> <p>Allows the patient to have discrete control 
         * over access to their adverse reaction data.</p><p>Taboo 
         * allows the provider to request restricted access to patient 
         * or their care giver.</p><p>Constraint: Cant have both normal 
         * and one of the other codes simultaneously.</p><p>The 
         * attribute is optional because not all systems will support 
         * masking.</p> <p>Allows the patient to have discrete control 
         * over access to their adverse reaction data.</p><p>Taboo 
         * allows the provider to request restricted access to patient 
         * or their care giver.</p><p>Constraint: Cant have both normal 
         * and one of the other codes simultaneously.</p><p>The 
         * attribute is optional because not all systems will support 
         * masking.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"confidentialityCode"})]
        public ICollection<x_NormalRestrictedTabooConfidentialityKind> ConfidentialityCode {
            get { return this.confidentialityCode.RawSet<x_NormalRestrictedTabooConfidentialityKind>(); }
        }

        /**
         * <summary>B:Reaction</summary>
         * 
         * <remarks><p>Specifies the kind of reaction, as experienced 
         * by the patient.</p> <p>Ensures consistency in tracking and 
         * categorizing the reaction type. Helps ensure that only 
         * proper allergies are categorized as allergy. The attribute 
         * is optional because it will not be used for SNOMED. The 
         * attribute is CWE because not all possible types of reactions 
         * are expressible by coded values.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"value"})]
        public SubjectReaction Value {
            get { return (SubjectReaction) this.value.Value; }
            set { this.value.Value = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"informant"})]
        public Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r02.Iehr.Merged.ReportedBy Informant {
            get { return this.informant; }
            set { this.informant = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"subjectOf1/severityObservation"})]
        public Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r02.Merged.AllergyIntoleranceSeverityLevel SubjectOf1SeverityObservation {
            get { return this.subjectOf1SeverityObservation; }
            set { this.subjectOf1SeverityObservation = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"subjectOf2/causalityAssessment"})]
        public IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r02.Iehr.Merged.ReportedReactions> SubjectOf2CausalityAssessment {
            get { return this.subjectOf2CausalityAssessment; }
        }

    }

}