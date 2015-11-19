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
namespace Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Pharmacy.Porx_mt060060ca {
    using Ca.Infoway.Messagebuilder;
    using Ca.Infoway.Messagebuilder.Annotation;
    using Ca.Infoway.Messagebuilder.Datatype;
    using Ca.Infoway.Messagebuilder.Datatype.Impl;
    using Ca.Infoway.Messagebuilder.Datatype.Lang;
    using Ca.Infoway.Messagebuilder.Domainvalue;
    using Ca.Infoway.Messagebuilder.Model;
    using Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Common.Coct_mt011001ca;
    using Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Common.Coct_mt090108ca;
    using Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Common.Coct_mt141007ca;
    using Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Merged;
    using Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Pharmacy.Merged;
    using System;
    using System.Collections.Generic;


    /**
     * <summary>Business Name: Prescription</summary>
     * 
     * <p>This is a 'core' class of the medication model and is 
     * important for understanding what devices the patient is 
     * intended to be receiving.</p> <p>Information pertaining to a 
     * Prescriber's authorization for a device to be dispensed to a 
     * patient, as well as the instruction on when and how the 
     * device is to be used by the patient.</p>
     */
    [Hl7PartTypeMappingAttribute(new string[] {"PORX_MT060060CA.DevicePrescription"})]
    public class Prescription : MessagePartBean, Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Pharmacy.Porx_mt060300ca.IPrescription, Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Iehr.Comt_mt111111ca.IPharmacy {

        private SET<II, Identifier> id;
        private CS statusCode;
        private SET<CV, Code> confidentialityCode;
        private Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Common.Coct_mt141007ca.DeviceProduct directTargetManufacturedProduct;
        private Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Common.Coct_mt090108ca.HealthcareWorker responsiblePartyAssignedEntity;
        private Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Merged.PrescribedBy author;
        private IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Merged.BecauseOf> reason;
        private BL preconditionVerificationEventCriterion;
        private BL derivedFromSourceDispense;
        private Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Pharmacy.Merged.ProcedureRequest component1ProcedureRequest;
        private Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Pharmacy.Merged.Component6 component2;
        private Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Pharmacy.Merged.RemainingDispenseInformation_2 fulfillment1SupplyEventFutureSummary;
        private Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Pharmacy.Merged.FirstDispenseInformation_2 fulfillment2SupplyEventFirstSummary;
        private Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Pharmacy.Merged.LastDispenseInformation_2 fulfillment3SupplyEventLastSummary;
        private Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Pharmacy.Merged.PreviousDispenseInformation_2 fulfillment4SupplyEventPastSummary;
        private BL subjectOf1AnnotationIndicator;
        private BL subjectOf2DetectedIssueIndicator;
        private IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Pharmacy.Merged.RefusalToFills> subjectOf3RefusalToFill;
        private IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Common.Coct_mt011001ca.CareCompositions> componentOfPatientCareProvisionEvent;

        public Prescription() {
            this.id = new SETImpl<II, Identifier>(typeof(IIImpl));
            this.statusCode = new CSImpl();
            this.confidentialityCode = new SETImpl<CV, Code>(typeof(CVImpl));
            this.reason = new List<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Merged.BecauseOf>();
            this.preconditionVerificationEventCriterion = new BLImpl(false);
            this.derivedFromSourceDispense = new BLImpl(false);
            this.subjectOf1AnnotationIndicator = new BLImpl(false);
            this.subjectOf2DetectedIssueIndicator = new BLImpl(false);
            this.subjectOf3RefusalToFill = new List<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Pharmacy.Merged.RefusalToFills>();
            this.componentOfPatientCareProvisionEvent = new List<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Common.Coct_mt011001ca.CareCompositions>();
        }
        /**
         * <summary>Business Name: A:Prescription Order Number</summary>
         * 
         * <remarks>Relationship: PORX_MT060060CA.DevicePrescription.id 
         * Conformance/Cardinality: MANDATORY (1-2) <p>Allows 
         * prescriptions to be uniquely referenced.</p><p>The number is 
         * mandatory to allow every prescription record to be uniquely 
         * identified.</p> <p>The Prescription Order Number is a 
         * globally unique number assigned to a prescription by the 
         * EHR/DIS irrespective of the source of the order</p><p>It is 
         * created by the EHR/DIS once the prescription has passed all 
         * edits and validation.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"id"})]
        public ICollection<Identifier> Id {
            get { return this.id.RawSet(); }
        }

        /**
         * <summary>Business Name: C:Prescription Status</summary>
         * 
         * <remarks>Relationship: 
         * PORX_MT060060CA.DevicePrescription.statusCode 
         * Conformance/Cardinality: MANDATORY (1) <p>Indicates what 
         * actions are allowed to be performed against a 
         * prescription.</p><p>This is a mandatory field because every 
         * prescription needs to be in some state.</p> <p>This denotes 
         * the state of the prescription in the lifecycle of the 
         * prescription. Valid statuses are: NEW, ACTIVE, SUSPENDED, 
         * ABORTED, COMPLETED, OBSOLETE and NULLIFIED.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"statusCode"})]
        public ActStatus StatusCode {
            get { return (ActStatus) this.statusCode.Value; }
            set { this.statusCode.Value = value; }
        }

        /**
         * <summary>Business Name: F:Prescription Masking Indicators</summary>
         * 
         * <remarks>Relationship: 
         * PORX_MT060060CA.DevicePrescription.confidentialityCode 
         * Conformance/Cardinality: REQUIRED (0-2) <p>Allows the 
         * patient to have discrete control over access to their 
         * prescription data.</p><p>Taboo allows the provider to 
         * request restricted access to patient or their care 
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
         * patient.</p><p>Valid values are: 'N' (normal - denotes 'Not 
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
         * PORX_MT060060CA.DirectTarget.manufacturedProduct</summary>
         * 
         * <remarks>Conformance/Cardinality: MANDATORY (1)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"directTarget/manufacturedProduct"})]
        public Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Common.Coct_mt141007ca.DeviceProduct DirectTargetManufacturedProduct {
            get { return this.directTargetManufacturedProduct; }
            set { this.directTargetManufacturedProduct = value; }
        }

        /**
         * <summary>Relationship: 
         * PORX_MT060060CA.ResponsibleParty.assignedEntity</summary>
         * 
         * <remarks>Conformance/Cardinality: REQUIRED (1)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"responsibleParty/assignedEntity"})]
        public Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Common.Coct_mt090108ca.HealthcareWorker ResponsiblePartyAssignedEntity {
            get { return this.responsiblePartyAssignedEntity; }
            set { this.responsiblePartyAssignedEntity = value; }
        }

        /**
         * <summary>Relationship: 
         * PORX_MT060060CA.DevicePrescription.author</summary>
         * 
         * <remarks>Conformance/Cardinality: MANDATORY (1)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"author"})]
        public Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Merged.PrescribedBy Author {
            get { return this.author; }
            set { this.author = value; }
        }

        /**
         * <summary>Relationship: 
         * PORX_MT060060CA.DevicePrescription.reason</summary>
         * 
         * <remarks>Conformance/Cardinality: REQUIRED (1-5)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"reason"})]
        public IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Merged.BecauseOf> Reason {
            get { return this.reason; }
        }

        /**
         * <summary>Relationship: 
         * PORX_MT060060CA.Precondition.verificationEventCriterion</summary>
         * 
         * <remarks>Conformance/Cardinality: REQUIRED (1)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"precondition/verificationEventCriterion"})]
        public bool? PreconditionVerificationEventCriterion {
            get { return this.preconditionVerificationEventCriterion.Value; }
            set { this.preconditionVerificationEventCriterion.Value = value; }
        }

        /**
         * <summary>Relationship: 
         * PORX_MT060060CA.DerivedFrom.sourceDispense</summary>
         * 
         * <remarks>Conformance/Cardinality: REQUIRED (1)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"derivedFrom/sourceDispense"})]
        public bool? DerivedFromSourceDispense {
            get { return this.derivedFromSourceDispense.Value; }
            set { this.derivedFromSourceDispense.Value = value; }
        }

        /**
         * <summary>Relationship: 
         * PORX_MT060060CA.Component1.procedureRequest</summary>
         * 
         * <remarks>Conformance/Cardinality: REQUIRED (1)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"component1/procedureRequest"})]
        public Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Pharmacy.Merged.ProcedureRequest Component1ProcedureRequest {
            get { return this.component1ProcedureRequest; }
            set { this.component1ProcedureRequest = value; }
        }

        /**
         * <summary>Relationship: 
         * PORX_MT060060CA.DevicePrescription.component2</summary>
         * 
         * <remarks>Conformance/Cardinality: REQUIRED (1)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"component2"})]
        public Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Pharmacy.Merged.Component6 Component2 {
            get { return this.component2; }
            set { this.component2 = value; }
        }

        /**
         * <summary>Relationship: 
         * PORX_MT060060CA.InFulfillmentOf4.supplyEventFutureSummary</summary>
         * 
         * <remarks>Conformance/Cardinality: REQUIRED (1)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"fulfillment1/supplyEventFutureSummary"})]
        public Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Pharmacy.Merged.RemainingDispenseInformation_2 Fulfillment1SupplyEventFutureSummary {
            get { return this.fulfillment1SupplyEventFutureSummary; }
            set { this.fulfillment1SupplyEventFutureSummary = value; }
        }

        /**
         * <summary>Relationship: 
         * PORX_MT060060CA.InFulfillmentOf5.supplyEventFirstSummary</summary>
         * 
         * <remarks>Conformance/Cardinality: REQUIRED (1)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"fulfillment2/supplyEventFirstSummary"})]
        public Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Pharmacy.Merged.FirstDispenseInformation_2 Fulfillment2SupplyEventFirstSummary {
            get { return this.fulfillment2SupplyEventFirstSummary; }
            set { this.fulfillment2SupplyEventFirstSummary = value; }
        }

        /**
         * <summary>Relationship: 
         * PORX_MT060060CA.InFulfillmentOf6.supplyEventLastSummary</summary>
         * 
         * <remarks>Conformance/Cardinality: REQUIRED (1)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"fulfillment3/supplyEventLastSummary"})]
        public Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Pharmacy.Merged.LastDispenseInformation_2 Fulfillment3SupplyEventLastSummary {
            get { return this.fulfillment3SupplyEventLastSummary; }
            set { this.fulfillment3SupplyEventLastSummary = value; }
        }

        /**
         * <summary>Relationship: 
         * PORX_MT060060CA.InFulfillmentOf2.supplyEventPastSummary</summary>
         * 
         * <remarks>Conformance/Cardinality: REQUIRED (1)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"fulfillment4/supplyEventPastSummary"})]
        public Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Pharmacy.Merged.PreviousDispenseInformation_2 Fulfillment4SupplyEventPastSummary {
            get { return this.fulfillment4SupplyEventPastSummary; }
            set { this.fulfillment4SupplyEventPastSummary = value; }
        }

        /**
         * <summary>Relationship: 
         * PORX_MT060060CA.Subject.annotationIndicator</summary>
         * 
         * <remarks>Conformance/Cardinality: REQUIRED (1)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"subjectOf1/annotationIndicator"})]
        public bool? SubjectOf1AnnotationIndicator {
            get { return this.subjectOf1AnnotationIndicator.Value; }
            set { this.subjectOf1AnnotationIndicator.Value = value; }
        }

        /**
         * <summary>Relationship: 
         * PORX_MT060060CA.Subject2.detectedIssueIndicator</summary>
         * 
         * <remarks>Conformance/Cardinality: REQUIRED (1)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"subjectOf2/detectedIssueIndicator"})]
        public bool? SubjectOf2DetectedIssueIndicator {
            get { return this.subjectOf2DetectedIssueIndicator.Value; }
            set { this.subjectOf2DetectedIssueIndicator.Value = value; }
        }

        /**
         * <summary>Relationship: 
         * PORX_MT060060CA.Subject3.refusalToFill</summary>
         * 
         * <remarks>Conformance/Cardinality: REQUIRED (1)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"subjectOf3/refusalToFill"})]
        public IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Pharmacy.Merged.RefusalToFills> SubjectOf3RefusalToFill {
            get { return this.subjectOf3RefusalToFill; }
        }

        /**
         * <summary>Relationship: 
         * PORX_MT060060CA.Component.patientCareProvisionEvent</summary>
         * 
         * <remarks>Conformance/Cardinality: REQUIRED (1)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"componentOf/patientCareProvisionEvent"})]
        public IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Common.Coct_mt011001ca.CareCompositions> ComponentOfPatientCareProvisionEvent {
            get { return this.componentOfPatientCareProvisionEvent; }
        }

    }

}