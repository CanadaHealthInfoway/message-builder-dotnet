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
namespace Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Merged {
    using Ca.Infoway.Messagebuilder;
    using Ca.Infoway.Messagebuilder.Annotation;
    using Ca.Infoway.Messagebuilder.Datatype;
    using Ca.Infoway.Messagebuilder.Datatype.Impl;
    using Ca.Infoway.Messagebuilder.Datatype.Lang;
    using Ca.Infoway.Messagebuilder.Domainvalue;
    using Ca.Infoway.Messagebuilder.Model;
    using Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Common.Merged;
    using Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Iehr.Comt_mt300003ca;
    using System;
    using System.Collections.Generic;


    /**
     * <summary>Comment</summary>
     * 
     * <remarks>COMT_MT300001CA.Annotation: Comment <p>Identifies 
     * the comments to be recorded against a Patient's record.</p> 
     * <p>Allows comments to be attached to a Patient record. A 
     * Patient record can pertain to demographic or clinical (Drug, 
     * Condition, Lab, DI, Immunization, etc) information.</p> 
     * COMT_MT300003CA.Annotation: Comment <p>Identifies the 
     * comments to be recorded against a Patient's record.</p> 
     * <p>Allows comments to be attached to a Patient record. A 
     * Patient record can pertain to demographic or clinical (Drug, 
     * Condition, Lab, DI, etc) information.</p> 
     * COMT_MT301001CA.Annotation: Comment <p>Identifies the 
     * comments to be recorded against a Patient's record.</p> 
     * <p>Allows comments to be attached to a Patient record. A 
     * Patient record can pertain to demographic or clinical (Drug, 
     * Condition, Lab, DI, etc) information.</p></remarks>
     */
    [Hl7PartTypeMappingAttribute(new string[] {"COMT_MT300001CA.Annotation","COMT_MT300003CA.Annotation","COMT_MT301001CA.Annotation"})]
    public class Comment : MessagePartBean {

        private CV code;
        private ST text;
        private SET<CV, Code> confidentialityCode;
        private II id;
        private Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Common.Merged.HealthcareWorker responsiblePartyAssignedEntity;
        private Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Iehr.Comt_mt300003ca.AnnotatedBy author;
        private Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Merged.OccurredAt location;
        private CV languageCode;
        private II subjectAnnotatedActId;

        public Comment() {
            this.code = new CVImpl();
            this.text = new STImpl();
            this.confidentialityCode = new SETImpl<CV, Code>(typeof(CVImpl));
            this.id = new IIImpl();
            this.languageCode = new CVImpl();
            this.subjectAnnotatedActId = new IIImpl();
        }
        /**
         * <summary>PatientNoteCategory</summary>
         * 
         * <remarks>A:Patient Note Category <p>A coded value denoting 
         * the category of note being attached to a Patient's record. 
         * Categories of note include: General, Medication, Lab, DI, 
         * etc.</p> <p>Allows patient notes of different purposes and 
         * use, to be attached to a patient. Attribute is mandatory to 
         * ensure that patient notes are categorized accordingly. This 
         * attribute may also be used by DISs to enforce different 
         * access control to different types of notes.</p> Patient Note 
         * Category <p>A coded value denoting the category of note 
         * being attached to a Patient's record. Categories of note 
         * include: General, Medication, Lab, DI, Immunization, etc</p> 
         * <p>Allows patient notes of different purposes and use, to be 
         * attached to a patient. Attribute is mandatory to ensure that 
         * patient notes are categorized accordingly. This attribute 
         * may also be used by DISs to enforce different access control 
         * to different types of notes.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"code"})]
        public ActPatientAnnotationCode Code {
            get { return (ActPatientAnnotationCode) this.code.Value; }
            set { this.code.Value = value; }
        }

        /**
         * <summary>C:Patient Note Text</summary>
         * 
         * <remarks><p>Free textual description of the patient 
         * note.</p> <p>Allows a provider to attach comments to a 
         * patient as a whole or to the patient's profile (such as 
         * medication, lab. DI, etc). This attribute is mandatory 
         * because there's no point in having a patient note unless 
         * there's actually content in the note.</p> C:Annotation Text 
         * <p>Free text comment to be attached to a record.</p> 
         * <p>Allows a provider to attach arbitrary comments to 
         * clinical records (prescription, dispenses, lab results, 
         * allergies, etc) for communication. This attribute is 
         * mandatory because there's no point in having an annotation 
         * unless there's actually content in the note.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"text"})]
        public String Text {
            get { return this.text.Value; }
            set { this.text.Value = value; }
        }

        /**
         * <summary>RestrictedPatientAccess</summary>
         * 
         * <remarks>D:Restricted Patient Access <p>Communicates the 
         * desire of the patient to restrict access to this Health 
         * Condition record. Provides support for additional 
         * confidentiality constraint, giving patients a level of 
         * control over their information. Methods for accessing masked 
         * event records will be governed by each jurisdiction (e.g. 
         * court orders, shared secret/consent, etc.). Can also be used 
         * to communicate that the information is deemed to be 
         * sensitive and should not be communicated or exposed to the 
         * patient (at least without the guidance of the authoring or 
         * other responsible healthcare provider). Valid values are: 
         * 'normal' (denotes 'Not Masked'); 'restricted' (denotes 
         * 'Masked'); very restricted (denotes Masked by Regulation); 
         * and 'taboo' (denotes 'patient restricted'). The default is 
         * 'normal' signifying 'Not Masked'. Either or both of the 
         * other codes can be asserted to indicate masking by the 
         * patient from providers or masking by a provider from the 
         * patient, respectively. 'normal' should never be asserted 
         * with one of the other codes.</p> <p>Taboo allows the 
         * provider to request restricted access to patient or their 
         * care giver.</p><p>Constraint: Cant have both normal and one 
         * of the other codes simultaneously.</p><p>The attribute is 
         * required because even if a jurisdiction doesn't support 
         * masking on the way in, it will need to need to communicate 
         * masked data returned from other jurisdictions.</p> <p>Taboo 
         * allows the provider to request restricted access to patient 
         * or their care giver.</p><p>Constraint: Cant have both normal 
         * and one of the other codes simultaneously.</p><p>The 
         * attribute is required because even if a jurisdiction doesn't 
         * support masking on the way in, it will need to need to 
         * communicate masked data returned from other 
         * jurisdictions.</p> <p>Taboo allows the provider to request 
         * restricted access to patient or their care 
         * giver.</p><p>Constraint: Cant have both normal and one of 
         * the other codes simultaneously.</p><p>The attribute is 
         * required because even if a jurisdiction doesn't support 
         * masking on the way in, it will need to need to communicate 
         * masked data returned from other jurisdictions.</p> 
         * D:Restricted Patient Access <p>Communicates the desire of 
         * the patient to restrict access to this Health Condition 
         * record. Provides support for additional confidentiality 
         * constraint, giving patients a level of control over their 
         * information. Methods for accessing masked event records will 
         * be governed by each jurisdiction (e.g. court orders, shared 
         * secret/consent, etc.). Can also be used to communicate that 
         * the information is deemed to be sensitive and should not be 
         * communicated or exposed to the patient (at least without the 
         * guidance of the authoring or other responsible healthcare 
         * provider). Valid values are: 'normal' (denotes 'Not 
         * Masked'); 'restricted' (denotes 'Masked'); very restricted 
         * (denotes Masked by Regulation); and 'taboo' (denotes 
         * 'patient restricted'). The default is 'normal' signifying 
         * 'Not Masked'. Either or both of the other codes can be 
         * asserted to indicate masking by the patient from providers 
         * or masking by a provider from the patient, respectively. 
         * 'normal' should never be asserted with one of the other 
         * codes.</p> <p>Taboo allows the provider to request 
         * restricted access to patient or their care 
         * giver.</p><p>Constraint: Cant have both normal and one of 
         * the other codes simultaneously.</p><p>The attribute is 
         * optional because not all systems will support masking.</p> 
         * <p>Taboo allows the provider to request restricted access to 
         * patient or their care giver.</p><p>Constraint: Cant have 
         * both normal and one of the other codes 
         * simultaneously.</p><p>The attribute is optional because not 
         * all systems will support masking.</p> <p>Taboo allows the 
         * provider to request restricted access to patient or their 
         * care giver.</p><p>Constraint: Cant have both normal and one 
         * of the other codes simultaneously.</p><p>The attribute is 
         * optional because not all systems will support masking.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"confidentialityCode"})]
        public ICollection<x_BasicConfidentialityKind> ConfidentialityCode {
            get { return this.confidentialityCode.RawSet<x_BasicConfidentialityKind>(); }
        }

        /**
         * <summary>PatientNoteId</summary>
         * 
         * <remarks>B:Patient Note Id <p>Identifier of the patient note 
         * record.</p> <p>Allows for the unique reference of a patient 
         * note and is therefore mandatory.</p><p>Allows for 
         * referencing of a particular patient note and thus allows for 
         * the removal of the note.</p> <p>Allows for the unique 
         * reference of a patient note and is therefore 
         * mandatory.</p><p>Allows for referencing of a particular 
         * patient note and thus allows for the removal of the 
         * note.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"id"})]
        public Identifier Id {
            get { return this.id.Value; }
            set { this.id.Value = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"responsibleParty/assignedEntity"})]
        public Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Common.Merged.HealthcareWorker ResponsiblePartyAssignedEntity {
            get { return this.responsiblePartyAssignedEntity; }
            set { this.responsiblePartyAssignedEntity = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"author"})]
        public Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Iehr.Comt_mt300003ca.AnnotatedBy Author {
            get { return this.author; }
            set { this.author = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"location"})]
        public Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Merged.OccurredAt Location {
            get { return this.location; }
            set { this.location = value; }
        }

        /**
         * <summary>WrittenIn</summary>
         * 
         * <remarks>D:Written in</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"languageCode"})]
        public HumanLanguage LanguageCode {
            get { return (HumanLanguage) this.languageCode.Value; }
            set { this.languageCode.Value = value; }
        }

        /**
         * <summary>RecordId</summary>
         * 
         * <remarks>A:Record Id <p>The identifier assigned by the 
         * central system (EHR) to the record item being annotated.</p> 
         * <p>Allows the record to be uniquely referenced and is 
         * therefore mandatory.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"subject/annotatedAct/id"})]
        public Identifier SubjectAnnotatedActId {
            get { return this.subjectAnnotatedActId.Value; }
            set { this.subjectAnnotatedActId.Value = value; }
        }

    }

}