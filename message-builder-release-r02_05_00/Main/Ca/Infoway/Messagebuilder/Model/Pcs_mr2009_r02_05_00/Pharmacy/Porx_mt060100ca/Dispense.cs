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
namespace Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_05_00.Pharmacy.Porx_mt060100ca {
    using Ca.Infoway.Messagebuilder;
    using Ca.Infoway.Messagebuilder.Annotation;
    using Ca.Infoway.Messagebuilder.Datatype;
    using Ca.Infoway.Messagebuilder.Datatype.Impl;
    using Ca.Infoway.Messagebuilder.Datatype.Lang;
    using Ca.Infoway.Messagebuilder.Domainvalue;
    using Ca.Infoway.Messagebuilder.Model;
    using Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_05_00.Merged;
    using Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_05_00.Pharmacy.Merged;
    using Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_05_00.Pr.Coct_mt090108ca;
    using System;
    using System.Collections.Generic;


    /**
     * <summary>Business Name: Dispense</summary>
     * 
     * <p>This is a 'core' class of the medication model and is 
     * important for understanding what drugs the patient is 
     * actually receiving.</p> <p>Describes the issuing of a drug 
     * in response to an authorizing prescription.</p>
     */
    [Hl7PartTypeMappingAttribute(new string[] {"PORX_MT060100CA.MedicationDispense"})]
    public class Dispense : MessagePartBean {

        private II id;
        private CS statusCode;
        private SET<CV, Code> confidentialityCode;
        private Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_05_00.Merged.SupervisedBy responsibleParty;
        private Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_05_00.Pr.Coct_mt090108ca.HealthcareWorker performerAssignedEntity;
        private Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_05_00.Merged.TargetedToPharmacy location;
        private Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_05_00.Pharmacy.Merged.SupplyEvent component1SupplyEvent;
        private Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_05_00.Pharmacy.Merged.PrescribedAdminidtrationInstruction component2AdministrationInstructions;
        private Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_05_00.Pharmacy.Porx_mt060100ca.Prescription fulfillmentSubstanceAdministrationRequest;
        private BL subjectOf1DetectedIssueIndicator;
        private BL subjectOf2AnnotationIndicator;

        public Dispense() {
            this.id = new IIImpl();
            this.statusCode = new CSImpl();
            this.confidentialityCode = new SETImpl<CV, Code>(typeof(CVImpl));
            this.subjectOf1DetectedIssueIndicator = new BLImpl(false);
            this.subjectOf2AnnotationIndicator = new BLImpl(false);
        }
        /**
         * <summary>Business Name: A:Prescription Dispense Number</summary>
         * 
         * <remarks>Relationship: PORX_MT060100CA.MedicationDispense.id 
         * Conformance/Cardinality: MANDATORY (1) <p>Allows dispense 
         * events to be uniquely referenced and is therefore 
         * mandatory.</p> <p>The Prescription Dispense Number is a 
         * globally unique number assigned to a prescription dispense 
         * by the EHR/DIS irrespective of the source of the supply 
         * event</p><p>It is created by the EHR/DIS once the dispense 
         * has passed all edits and validation.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"id"})]
        public Identifier Id {
            get { return this.id.Value; }
            set { this.id.Value = value; }
        }

        /**
         * <summary>Business Name: C:Dispense Status</summary>
         * 
         * <remarks>Relationship: 
         * PORX_MT060100CA.MedicationDispense.statusCode 
         * Conformance/Cardinality: MANDATORY (1) <p>Indicates how far 
         * along the process the dispense event is. It should always be 
         * known and is therefore mandatory.</p> <p>Indicates whether 
         * the dispense has been picked up ('complete') or has just 
         * been processed ('active').</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"statusCode"})]
        public ActStatus StatusCode {
            get { return (ActStatus) this.statusCode.Value; }
            set { this.statusCode.Value = value; }
        }

        /**
         * <summary>Business Name: E:Prescription Masking Indicators</summary>
         * 
         * <remarks>Relationship: 
         * PORX_MT060100CA.MedicationDispense.confidentialityCode 
         * Conformance/Cardinality: REQUIRED (0-2) <p>Allows the 
         * patient to have discrete control over access to their 
         * medication data.</p><p>Taboo allows the provider to request 
         * restricted access to patient or their care 
         * giver.</p><p>Constraint: Can't have both normal and one of 
         * the other codes simultaneously.</p><p>The attribute is 
         * required because even if a jurisdiction doesn't support 
         * masking on the way in, it will need to need to communicate 
         * masked data returned from other jurisdictions.</p> 
         * <p>Communicates the intent of the patient to restrict access 
         * to their prescriptions.</p><p>Provides support for 
         * additional confidentiality constraint, giving patients a 
         * level of control over their information.</p><p>Allows a 
         * provider to request restricted access by the 
         * patient</p><p>Valid values are: 'N' (normal - denotes 'Not 
         * Masked'); 'R' (restricted - denotes 'Masked'); 'V' (very 
         * restricted - denotes very restricted access as declared by 
         * the Privacy Officer of the record holder) and 'T' (taboo - 
         * denotes 'Patient Access Restricted').</p><p>The default is 
         * 'normal' signifying 'Not Masked'.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"confidentialityCode"})]
        public ICollection<x_BasicConfidentialityKind> ConfidentialityCode {
            get { return this.confidentialityCode.RawSet<x_BasicConfidentialityKind>(); }
        }

        /**
         * <summary>Relationship: 
         * PORX_MT060100CA.MedicationDispense.responsibleParty</summary>
         * 
         * <remarks>Conformance/Cardinality: REQUIRED (0-1)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"responsibleParty"})]
        public Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_05_00.Merged.SupervisedBy ResponsibleParty {
            get { return this.responsibleParty; }
            set { this.responsibleParty = value; }
        }

        /**
         * <summary>Relationship: 
         * PORX_MT060100CA.Performer.assignedEntity</summary>
         * 
         * <remarks>Conformance/Cardinality: MANDATORY (1)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"performer/assignedEntity"})]
        public Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_05_00.Pr.Coct_mt090108ca.HealthcareWorker PerformerAssignedEntity {
            get { return this.performerAssignedEntity; }
            set { this.performerAssignedEntity = value; }
        }

        /**
         * <summary>Relationship: 
         * PORX_MT060100CA.MedicationDispense.location</summary>
         * 
         * <remarks>Conformance/Cardinality: MANDATORY (1)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"location"})]
        public Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_05_00.Merged.TargetedToPharmacy Location {
            get { return this.location; }
            set { this.location = value; }
        }

        /**
         * <summary>Relationship: 
         * PORX_MT060100CA.Component2.supplyEvent</summary>
         * 
         * <remarks>Conformance/Cardinality: MANDATORY (1)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"component1/supplyEvent"})]
        public Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_05_00.Pharmacy.Merged.SupplyEvent Component1SupplyEvent {
            get { return this.component1SupplyEvent; }
            set { this.component1SupplyEvent = value; }
        }

        /**
         * <summary>Relationship: 
         * PORX_MT060100CA.Component11.administrationInstructions</summary>
         * 
         * <remarks>Conformance/Cardinality: MANDATORY (1)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"component2/administrationInstructions"})]
        public Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_05_00.Pharmacy.Merged.PrescribedAdminidtrationInstruction Component2AdministrationInstructions {
            get { return this.component2AdministrationInstructions; }
            set { this.component2AdministrationInstructions = value; }
        }

        /**
         * <summary>Relationship: 
         * PORX_MT060100CA.InFulfillmentOf.substanceAdministrationRequest</summary>
         * 
         * <remarks>Conformance/Cardinality: REQUIRED (1)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"fulfillment/substanceAdministrationRequest"})]
        public Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_05_00.Pharmacy.Porx_mt060100ca.Prescription FulfillmentSubstanceAdministrationRequest {
            get { return this.fulfillmentSubstanceAdministrationRequest; }
            set { this.fulfillmentSubstanceAdministrationRequest = value; }
        }

        /**
         * <summary>Relationship: 
         * PORX_MT060100CA.Subject4.detectedIssueIndicator</summary>
         * 
         * <remarks>Conformance/Cardinality: REQUIRED (1)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"subjectOf1/detectedIssueIndicator"})]
        public bool? SubjectOf1DetectedIssueIndicator {
            get { return this.subjectOf1DetectedIssueIndicator.Value; }
            set { this.subjectOf1DetectedIssueIndicator.Value = value; }
        }

        /**
         * <summary>Relationship: 
         * PORX_MT060100CA.Subject3.annotationIndicator</summary>
         * 
         * <remarks>Conformance/Cardinality: REQUIRED (1)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"subjectOf2/annotationIndicator"})]
        public bool? SubjectOf2AnnotationIndicator {
            get { return this.subjectOf2AnnotationIndicator.Value; }
            set { this.subjectOf2AnnotationIndicator.Value = value; }
        }

    }

}