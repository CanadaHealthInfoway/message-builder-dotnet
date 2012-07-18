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
 * Last modified: $LastChangedDate: 2012-02-16 11:07:45 -0500 (Thu, 16 Feb 2012) $
 * Revision:      $LastChangedRevision: 5485 $
 */
/* This class was auto-generated by the message builder generator tools. */
namespace Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r01.Pharmacy.Porx_mt060100ca {
    using Ca.Infoway.Messagebuilder;
    using Ca.Infoway.Messagebuilder.Annotation;
    using Ca.Infoway.Messagebuilder.Datatype;
    using Ca.Infoway.Messagebuilder.Datatype.Impl;
    using Ca.Infoway.Messagebuilder.Datatype.Lang;
    using Ca.Infoway.Messagebuilder.Domainvalue;
    using Ca.Infoway.Messagebuilder.Model;
    using Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r01.Merged;
    using Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r01.Pharmacy.Merged;
    using System;
    using System.Collections.Generic;


    /**
     * <summary>Dispense</summary>
     * 
     * <remarks><p>Describes the issuing of a drug in response to 
     * an authorizing prescription.</p> <p>This is a 'core' class 
     * of the medication model and is important for understanding 
     * what drugs the patient is actually receiving.</p></remarks>
     */
    [Hl7PartTypeMappingAttribute(new string[] {"PORX_MT060100CA.MedicationDispense"})]
    public class Dispense : MessagePartBean {

        private II id;
        private CS statusCode;
        private SET<CV, Code> confidentialityCode;
        private Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r01.Merged.HealthcareWorker responsiblePartyAssignedEntity;
        private Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r01.Merged.HealthcareWorker performerAssignedEntity;
        private Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r01.Merged.CreatedAt location;
        private Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r01.Pharmacy.Merged.SupplyEvent component1SupplyEvent;
        private ST component2AdministrationInstructionsText;
        private Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r01.Pharmacy.Merged.SubstanceAdministrationRequest fulfillmentSubstanceAdministrationRequest;
        private BL subjectOf1DetectedIssueIndicator;
        private BL subjectOf2AnnotationIndicator;

        public Dispense() {
            this.id = new IIImpl();
            this.statusCode = new CSImpl();
            this.confidentialityCode = new SETImpl<CV, Code>(typeof(CVImpl));
            this.component2AdministrationInstructionsText = new STImpl();
            this.subjectOf1DetectedIssueIndicator = new BLImpl(false);
            this.subjectOf2AnnotationIndicator = new BLImpl(false);
        }
        /**
         * <summary>A:Prescription Dispense Number</summary>
         * 
         * <remarks><p>The Prescription Dispense Number is a globally 
         * unique number assigned to a prescription dispense by the 
         * EHR/DIS irrespective of the source of the supply 
         * event</p><p>It is created by the EHR/DIS once the dispense 
         * has passed all edits and validation.</p> <p>The Prescription 
         * Dispense Number is a globally unique number assigned to a 
         * prescription dispense by the EHR/DIS irrespective of the 
         * source of the supply event</p><p>It is created by the 
         * EHR/DIS once the dispense has passed all edits and 
         * validation.</p> <p>Allows dispense events to be uniquely 
         * referenced and is therefore mandatory.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"id"})]
        public Identifier Id {
            get { return this.id.Value; }
            set { this.id.Value = value; }
        }

        /**
         * <summary>C:Dispense Status</summary>
         * 
         * <remarks><p>Indicates whether the dispense has been picked 
         * up ('complete') or has just been processed ('active').</p> 
         * <p>Indicates how far along the process the dispense event 
         * is. It should always be known and is therefore 
         * mandatory.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"statusCode"})]
        public ActStatus StatusCode {
            get { return (ActStatus) this.statusCode.Value; }
            set { this.statusCode.Value = value; }
        }

        /**
         * <summary>E:Prescription Masking Indicators</summary>
         * 
         * <remarks><p>Communicates the intent of the patient to 
         * restrict access to their prescriptions.</p><p>Provides 
         * support for additional confidentiality constraint, giving 
         * patients a level of control over their 
         * information.</p><p>Allows a provider to request restricted 
         * access by the patient</p><p>Valid values are: 'N' (normal - 
         * denotes 'Not Masked'); 'R' (restricted - denotes 'Masked') 
         * and 'T' (taboo - denotes 'Patient Access 
         * Restricted').</p><p>The default is 'normal' signifying 'Not 
         * Masked'.</p> <p>Communicates the intent of the patient to 
         * restrict access to their prescriptions.</p><p>Provides 
         * support for additional confidentiality constraint, giving 
         * patients a level of control over their 
         * information.</p><p>Allows a provider to request restricted 
         * access by the patient</p><p>Valid values are: 'N' (normal - 
         * denotes 'Not Masked'); 'R' (restricted - denotes 'Masked') 
         * and 'T' (taboo - denotes 'Patient Access 
         * Restricted').</p><p>The default is 'normal' signifying 'Not 
         * Masked'.</p> <p>Communicates the intent of the patient to 
         * restrict access to their prescriptions.</p><p>Provides 
         * support for additional confidentiality constraint, giving 
         * patients a level of control over their 
         * information.</p><p>Allows a provider to request restricted 
         * access by the patient</p><p>Valid values are: 'N' (normal - 
         * denotes 'Not Masked'); 'R' (restricted - denotes 'Masked') 
         * and 'T' (taboo - denotes 'Patient Access 
         * Restricted').</p><p>The default is 'normal' signifying 'Not 
         * Masked'.</p> <p>Communicates the intent of the patient to 
         * restrict access to their prescriptions.</p><p>Provides 
         * support for additional confidentiality constraint, giving 
         * patients a level of control over their 
         * information.</p><p>Allows a provider to request restricted 
         * access by the patient</p><p>Valid values are: 'N' (normal - 
         * denotes 'Not Masked'); 'R' (restricted - denotes 'Masked') 
         * and 'T' (taboo - denotes 'Patient Access 
         * Restricted').</p><p>The default is 'normal' signifying 'Not 
         * Masked'.</p> <p>Communicates the intent of the patient to 
         * restrict access to their prescriptions.</p><p>Provides 
         * support for additional confidentiality constraint, giving 
         * patients a level of control over their 
         * information.</p><p>Allows a provider to request restricted 
         * access by the patient</p><p>Valid values are: 'N' (normal - 
         * denotes 'Not Masked'); 'R' (restricted - denotes 'Masked') 
         * and 'T' (taboo - denotes 'Patient Access 
         * Restricted').</p><p>The default is 'normal' signifying 'Not 
         * Masked'.</p> <p>Allows the patient to have discrete control 
         * over access to their medication data.</p><p>Taboo allows the 
         * provider to request restricted access to patient or their 
         * care giver.</p><p>Constraint: Cant have both normal and one 
         * of the other codes simultaneously.</p><p>The attribute is 
         * required because even if a jurisdiction doesn't support 
         * masking on the way in, it will need to need to communicate 
         * masked data returned from other jurisdictions.</p> <p>Allows 
         * the patient to have discrete control over access to their 
         * medication data.</p><p>Taboo allows the provider to request 
         * restricted access to patient or their care 
         * giver.</p><p>Constraint: Cant have both normal and one of 
         * the other codes simultaneously.</p><p>The attribute is 
         * required because even if a jurisdiction doesn't support 
         * masking on the way in, it will need to need to communicate 
         * masked data returned from other jurisdictions.</p> <p>Allows 
         * the patient to have discrete control over access to their 
         * medication data.</p><p>Taboo allows the provider to request 
         * restricted access to patient or their care 
         * giver.</p><p>Constraint: Cant have both normal and one of 
         * the other codes simultaneously.</p><p>The attribute is 
         * required because even if a jurisdiction doesn't support 
         * masking on the way in, it will need to need to communicate 
         * masked data returned from other jurisdictions.</p> <p>Allows 
         * the patient to have discrete control over access to their 
         * medication data.</p><p>Taboo allows the provider to request 
         * restricted access to patient or their care 
         * giver.</p><p>Constraint: Cant have both normal and one of 
         * the other codes simultaneously.</p><p>The attribute is 
         * required because even if a jurisdiction doesn't support 
         * masking on the way in, it will need to need to communicate 
         * masked data returned from other jurisdictions.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"confidentialityCode"})]
        public ICollection<x_NormalRestrictedTabooConfidentialityKind> ConfidentialityCode {
            get { return this.confidentialityCode.RawSet<x_NormalRestrictedTabooConfidentialityKind>(); }
        }

        [Hl7XmlMappingAttribute(new string[] {"responsibleParty/assignedEntity"})]
        public Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r01.Merged.HealthcareWorker ResponsiblePartyAssignedEntity {
            get { return this.responsiblePartyAssignedEntity; }
            set { this.responsiblePartyAssignedEntity = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"performer/assignedEntity"})]
        public Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r01.Merged.HealthcareWorker PerformerAssignedEntity {
            get { return this.performerAssignedEntity; }
            set { this.performerAssignedEntity = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"location"})]
        public Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r01.Merged.CreatedAt Location {
            get { return this.location; }
            set { this.location = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"component1/supplyEvent"})]
        public Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r01.Pharmacy.Merged.SupplyEvent Component1SupplyEvent {
            get { return this.component1SupplyEvent; }
            set { this.component1SupplyEvent = value; }
        }

        /**
         * <summary>Rendered Dosage Instruction</summary>
         * 
         * <remarks><p>A free form textual specification generated from 
         * the input specifications as created by the 
         * provider.</p><p>This is made up of either an 'Ad-hoc dosage 
         * instruction' or 'Textual rendition of the structured dosage 
         * lines', plus route, dosage unit, and other pertinent 
         * administration information specified by the provider.</p> 
         * <p>A free form textual specification generated from the 
         * input specifications as created by the provider.</p><p>This 
         * is made up of either an 'Ad-hoc dosage instruction' or 
         * 'Textual rendition of the structured dosage lines', plus 
         * route, dosage unit, and other pertinent administration 
         * information specified by the provider.</p> <p>Allows the 
         * provider to verify the codified structured dosage 
         * information entered and ensure that the exploded instruction 
         * is consistent with the intended instructions.</p><p>Also 
         * useful in bringing back administration instructions on query 
         * responses. Because all prescriptions and dispenses have 
         * dosage, this attribute is mandatory.</p> <p>Allows the 
         * provider to verify the codified structured dosage 
         * information entered and ensure that the exploded instruction 
         * is consistent with the intended instructions.</p><p>Also 
         * useful in bringing back administration instructions on query 
         * responses. Because all prescriptions and dispenses have 
         * dosage, this attribute is mandatory.</p> <p>For dosage 
         * instructions which cannot be summarized in the space 
         * allocated, a string such as &quot;Complex dose&quot; or 
         * &quot;Scaling dose&quot; or something similar should be 
         * sent. Dosage instructions should never be truncated.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"component2/administrationInstructions/text"})]
        public String Component2AdministrationInstructionsText {
            get { return this.component2AdministrationInstructionsText.Value; }
            set { this.component2AdministrationInstructionsText.Value = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"fulfillment/substanceAdministrationRequest"})]
        public Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r01.Pharmacy.Merged.SubstanceAdministrationRequest FulfillmentSubstanceAdministrationRequest {
            get { return this.fulfillmentSubstanceAdministrationRequest; }
            set { this.fulfillmentSubstanceAdministrationRequest = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"subjectOf1/detectedIssueIndicator"})]
        public bool? SubjectOf1DetectedIssueIndicator {
            get { return this.subjectOf1DetectedIssueIndicator.Value; }
            set { this.subjectOf1DetectedIssueIndicator.Value = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"subjectOf2/annotationIndicator"})]
        public bool? SubjectOf2AnnotationIndicator {
            get { return this.subjectOf2AnnotationIndicator.Value; }
            set { this.subjectOf2AnnotationIndicator.Value = value; }
        }

    }

}