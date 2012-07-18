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
 * Last modified: $LastChangedDate: 2012-02-16 10:57:57 -0500 (Thu, 16 Feb 2012) $
 * Revision:      $LastChangedRevision: 5367 $
 */
/* This class was auto-generated by the message builder generator tools. */
namespace Ca.Infoway.Messagebuilder.Model.Pcs_cerx_v01_r04_3.Iehr.Repc_mt000010ca {
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
     * <summary>Medical Condition</summary>
     * 
     * <remarks><p>Value is mandatory if not using 
     * SNOMED</p><p>Code is fixed to DX if not using SNOMED</p> 
     * <p>Value is mandatory if not using SNOMED</p><p>Code is 
     * fixed to DX if not using SNOMED</p> <p>A record of a 
     * patient's medical condition. Includes diseases, 
     * disabilities, pregnancy, lactation and other clinical 
     * conditions of interest.</p> <p>Necessary component of a 
     * person's overall medication and clinical profile. Helps with 
     * contraindication checking.</p></remarks>
     */
    [Hl7PartTypeMappingAttribute(new string[] {"REPC_MT000010CA.MedicalCondition"})]
    public class MedicalCondition : MessagePartBean {

        private II id;
        private CD code;
        private CS statusCode;
        private IVL<TS, Interval<PlatformDate>> effectiveTime;
        private CV confidentialityCode;
        private CV value;
        private Ca.Infoway.Messagebuilder.Model.Pcs_cerx_v01_r04_3.Common.Merged.Patient subjectPatient;
        private Ca.Infoway.Messagebuilder.Model.Pcs_cerx_v01_r04_3.Common.Coct_mt090107ca.Provider responsiblePartyAssignedPerson;
        private Ca.Infoway.Messagebuilder.Model.Pcs_cerx_v01_r04_3.Merged.RefusedBy author;
        private Ca.Infoway.Messagebuilder.Model.Pcs_cerx_v01_r04_3.Iehr.Merged.ReportedBy informant;
        private Ca.Infoway.Messagebuilder.Model.Pcs_cerx_v01_r04_3.Merged.RecordedAt location;
        private Ca.Infoway.Messagebuilder.Model.Pcs_cerx_v01_r04_3.Iehr.Repc_mt000010ca.MedicalCondition replacementOfMedicalCondition;
        private IList<Ca.Infoway.Messagebuilder.Model.Pcs_cerx_v01_r04_3.Merged.VersionInformation> subjectOf1ControlActEvent;
        private IList<Ca.Infoway.Messagebuilder.Model.Pcs_cerx_v01_r04_3.Merged.Comment> subjectOf2Annotation;
        private BL subjectOf3ChronicIndicator;

        public MedicalCondition() {
            this.id = new IIImpl();
            this.code = new CDImpl();
            this.statusCode = new CSImpl();
            this.effectiveTime = new IVLImpl<TS, Interval<PlatformDate>>();
            this.confidentialityCode = new CVImpl();
            this.value = new CVImpl();
            this.subjectOf1ControlActEvent = new List<Ca.Infoway.Messagebuilder.Model.Pcs_cerx_v01_r04_3.Merged.VersionInformation>();
            this.subjectOf2Annotation = new List<Ca.Infoway.Messagebuilder.Model.Pcs_cerx_v01_r04_3.Merged.Comment>();
            this.subjectOf3ChronicIndicator = new BLImpl(false);
        }
        /**
         * <summary>A:Medical Condition Record Id</summary>
         * 
         * <remarks><p>Unique identifier for medical condition 
         * record.</p> <p>Allows for direct referencing of a medical 
         * condition record when querying or updating and is therefore 
         * mandatory.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"id"})]
        public Identifier Id {
            get { return this.id.Value; }
            set { this.id.Value = value; }
        }

        /**
         * <summary>Condition Type</summary>
         * 
         * <remarks><p>Indicates what kind of condition is being 
         * reported.</p> <p>Identifies this observation as reporting a 
         * medical condition and is therefore mandatory. When using 
         * SNOMED, the actual condition may be post-coordinated into 
         * this attribute, thus CD is used.</p> <p>If SNOMED is used, 
         * the diagnosis will appear here. Otherwise, a fixed value of 
         * &quot;DX&quot; should be sent.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"code"})]
        public ActCode Code {
            get { return (ActCode) this.code.Value; }
            set { this.code.Value = value; }
        }

        /**
         * <summary>D:Condition Status</summary>
         * 
         * <remarks><p>A coded value that indicates whether the 
         * condition is still impacting the patient. 'ACTIVE' means the 
         * condition is still affecting the patient. 'COMPLETE' means 
         * the condition no longer holds</p> <p>Essential to evaluating 
         * the relevance of the condition record. In some cases, it may 
         * not be known whether the condition still exists or not. 
         * Therefore the status is treated as 'populated'.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"statusCode"})]
        public ActStatus StatusCode {
            get { return (ActStatus) this.statusCode.Value; }
            set { this.statusCode.Value = value; }
        }

        /**
         * <summary>E:Condition Time Period</summary>
         * 
         * <remarks><p>The date on which the condition first began and 
         * when it ended.</p><p>For ongoing conditions such as chronic 
         * diseases, the upper boundary may be unknown.</p><p>For 
         * transient conditions such as pregnancy, lactation, etc; the 
         * upper boundary of the period would usually be specified to 
         * signify the end of the condition.</p> <p>The date on which 
         * the condition first began and when it ended.</p><p>For 
         * ongoing conditions such as chronic diseases, the upper 
         * boundary may be unknown.</p><p>For transient conditions such 
         * as pregnancy, lactation, etc; the upper boundary of the 
         * period would usually be specified to signify the end of the 
         * condition.</p> <p>The date on which the condition first 
         * began and when it ended.</p><p>For ongoing conditions such 
         * as chronic diseases, the upper boundary may be 
         * unknown.</p><p>For transient conditions such as pregnancy, 
         * lactation, etc; the upper boundary of the period would 
         * usually be specified to signify the end of the 
         * condition.</p> <p>Allows providers to evaluate the period of 
         * relevance for the medical condition.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"effectiveTime"})]
        public Interval<PlatformDate> EffectiveTime {
            get { return this.effectiveTime.Value; }
            set { this.effectiveTime.Value = value; }
        }

        /**
         * <summary>F:Condition Masking Indicator</summary>
         * 
         * <remarks><p>Denotes access restriction placed on the medical 
         * condition record. Methods for accessing masked medical 
         * condition records will be governed by each jurisdiction 
         * (e.g. court orders, shared secret/consent, etc.).</p><p>The 
         * default confidentiality level is 'NORMAL'.</p> <p>Denotes 
         * access restriction placed on the medical condition record. 
         * Methods for accessing masked medical condition records will 
         * be governed by each jurisdiction (e.g. court orders, shared 
         * secret/consent, etc.).</p><p>The default confidentiality 
         * level is 'NORMAL'.</p> <p>Provides support for additional 
         * confidentiality constraint to reflect the wishes of the 
         * patient.</p><p>The attribute is optional because not all 
         * systems will support masking.</p> <p>Provides support for 
         * additional confidentiality constraint to reflect the wishes 
         * of the patient.</p><p>The attribute is optional because not 
         * all systems will support masking.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"confidentialityCode"})]
        public x_VeryBasicConfidentialityKind ConfidentialityCode {
            get { return (x_VeryBasicConfidentialityKind) this.confidentialityCode.Value; }
            set { this.confidentialityCode.Value = value; }
        }

        /**
         * <summary>C:Condition</summary>
         * 
         * <remarks><p>A code indicating the specific condition. E.g. 
         * Hypertension, Pregnancy.</p> <p>This is the central piece of 
         * information in recording a condition. However because when 
         * using SNOMED the actual diagnosis will be sent in the 'code' 
         * attribute, this element is optional.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"value"})]
        public DiagnosisValue Value {
            get { return (DiagnosisValue) this.value.Value; }
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

        [Hl7XmlMappingAttribute(new string[] {"replacementOf/medicalCondition"})]
        public Ca.Infoway.Messagebuilder.Model.Pcs_cerx_v01_r04_3.Iehr.Repc_mt000010ca.MedicalCondition ReplacementOfMedicalCondition {
            get { return this.replacementOfMedicalCondition; }
            set { this.replacementOfMedicalCondition = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"subjectOf1/controlActEvent"})]
        public IList<Ca.Infoway.Messagebuilder.Model.Pcs_cerx_v01_r04_3.Merged.VersionInformation> SubjectOf1ControlActEvent {
            get { return this.subjectOf1ControlActEvent; }
        }

        [Hl7XmlMappingAttribute(new string[] {"subjectOf2/annotation"})]
        public IList<Ca.Infoway.Messagebuilder.Model.Pcs_cerx_v01_r04_3.Merged.Comment> SubjectOf2Annotation {
            get { return this.subjectOf2Annotation; }
        }

        [Hl7XmlMappingAttribute(new string[] {"subjectOf3/chronicIndicator"})]
        public bool? SubjectOf3ChronicIndicator {
            get { return this.subjectOf3ChronicIndicator.Value; }
            set { this.subjectOf3ChronicIndicator.Value = value; }
        }

    }

}