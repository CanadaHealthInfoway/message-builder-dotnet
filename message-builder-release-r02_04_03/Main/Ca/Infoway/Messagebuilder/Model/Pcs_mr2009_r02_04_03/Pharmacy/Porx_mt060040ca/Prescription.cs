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
namespace Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Pharmacy.Porx_mt060040ca {
    using Ca.Infoway.Messagebuilder;
    using Ca.Infoway.Messagebuilder.Annotation;
    using Ca.Infoway.Messagebuilder.Datatype;
    using Ca.Infoway.Messagebuilder.Datatype.Impl;
    using Ca.Infoway.Messagebuilder.Datatype.Lang;
    using Ca.Infoway.Messagebuilder.Domainvalue;
    using Ca.Infoway.Messagebuilder.Model;
    using Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Common.Coct_mt141007ca;
    using Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Common.Merged;
    using Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Merged;
    using Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Pharmacy.Merged;
    using System;
    using System.Collections.Generic;


    /**
     * <summary>Prescription</summary>
     * 
     * <remarks><p>Reported Issue is only permitted if Issue 
     * Indicator is not present and vice versa.</p><p>Annotation is 
     * only permitted if Annotation Indicator is not present and 
     * vice versa</p> <p>Reported Issue is only permitted if Issue 
     * Indicator is not present and vice versa.</p><p>Annotation is 
     * only permitted if Annotation Indicator is not present and 
     * vice versa</p> <p>Information pertaining to a Prescriber's 
     * authorization for a device to be dispensed to a patient, as 
     * well as the instruction on when and how the device is to be 
     * used by the patient.</p> <p>This is a 'core' class of the 
     * medication model and is important for understanding what 
     * devices the patient is intended to be receiving.</p></remarks>
     */
    [Hl7PartTypeMappingAttribute(new string[] {"PORX_MT060040CA.DeviceRequest"})]
    public class Prescription : MessagePartBean, Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Pharmacy.Merged.IPrescription {

        private SET<II, Identifier> id;
        private CS statusCode;
        private SET<CV, Code> confidentialityCode;
        private Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Common.Coct_mt141007ca.DeviceProduct directTargetManufacturedProduct;
        private Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Common.Merged.HealthcareWorker responsiblePartyAssignedEntity;
        private Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Merged.PrescribedBy author;
        private Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Merged.OccurredAt location;
        private Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Pharmacy.Merged.ParentPrescription predecessorPriorSupplyRequest;
        private IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Merged.BecauseOf> reason;
        private BL preconditionVerificationEventCriterion;
        private BL derivedFromSourceDispense;
        private IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Pharmacy.Merged.CoverageExtensions_1> coverageCoverage;
        private Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Pharmacy.Merged.ProcedureRequest component1ProcedureRequest;
        private Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Pharmacy.Merged.Component6 component2;
        private Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Pharmacy.Merged.LastDispenseInformation_2 fulfillment1SupplyEventLastSummary;
        private Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Pharmacy.Merged.FirstDispenseInformation_2 fulfillment2SupplyEventFirstSummary;
        private Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Pharmacy.Merged.RemainingDispenseInformation_2 fulfillment3SupplyEventFutureSummary;
        private Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Pharmacy.Merged.PreviousDispenseInformation_2 fulfillment4SupplyEventPastSummary;
        private IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Pharmacy.Merged.DeviceDispense> fulfillment5DeviceDispense;
        private IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Common.Merged.Issues> subjectOf1DetectedIssueEvent;
        private IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Pharmacy.Merged.StatusChanges> subjectOf2ControlActEvent;
        private IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Merged.Includes> subjectOf3;
        private IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Pharmacy.Merged.RefusalToFills> subjectOf4RefusalToFill;
        private BL subjectOf5DetectedIssueIndicator;
        private BL subjectOf6AnnotationIndicator;
        private IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Merged.CareCompositions> componentOfPatientCareProvisionEvent;

        public Prescription() {
            this.id = new SETImpl<II, Identifier>(typeof(IIImpl));
            this.statusCode = new CSImpl();
            this.confidentialityCode = new SETImpl<CV, Code>(typeof(CVImpl));
            this.reason = new List<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Merged.BecauseOf>();
            this.preconditionVerificationEventCriterion = new BLImpl(false);
            this.derivedFromSourceDispense = new BLImpl(false);
            this.coverageCoverage = new List<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Pharmacy.Merged.CoverageExtensions_1>();
            this.fulfillment5DeviceDispense = new List<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Pharmacy.Merged.DeviceDispense>();
            this.subjectOf1DetectedIssueEvent = new List<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Common.Merged.Issues>();
            this.subjectOf2ControlActEvent = new List<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Pharmacy.Merged.StatusChanges>();
            this.subjectOf3 = new List<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Merged.Includes>();
            this.subjectOf4RefusalToFill = new List<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Pharmacy.Merged.RefusalToFills>();
            this.subjectOf5DetectedIssueIndicator = new BLImpl(false);
            this.subjectOf6AnnotationIndicator = new BLImpl(false);
            this.componentOfPatientCareProvisionEvent = new List<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Merged.CareCompositions>();
        }
        /**
         * <summary>A:Prescription Order Number</summary>
         * 
         * <remarks><p>The Prescription Order Number is a globally 
         * unique number assigned to a prescription by the EHR/DIS 
         * irrespective of the source of the order</p><p>It is created 
         * by the EHR/DIS once the prescription has passed all edits 
         * and validation.</p> <p>The Prescription Order Number is a 
         * globally unique number assigned to a prescription by the 
         * EHR/DIS irrespective of the source of the order</p><p>It is 
         * created by the EHR/DIS once the prescription has passed all 
         * edits and validation.</p> <p>Allows prescriptions to be 
         * uniquely referenced.</p><p>The number is mandatory to allow 
         * every prescription record to be uniquely identified.</p> 
         * <p>Allows prescriptions to be uniquely referenced.</p><p>The 
         * number is mandatory to allow every prescription record to be 
         * uniquely identified.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"id"})]
        public ICollection<Identifier> Id {
            get { return this.id.RawSet(); }
        }

        /**
         * <summary>C:Prescription Status</summary>
         * 
         * <remarks><p>This denotes the state of the prescription in 
         * the lifecycle of the prescription. Valid statuses are: NEW, 
         * ACTIVE, SUSPENDED, ABORTED, COMPLETED, OBSOLETE and 
         * NULLIFIED.</p> <p>Indicates what actions are allowed to be 
         * performed against a prescription.</p><p>This is a mandatory 
         * field because every prescription needs to be in some 
         * state.</p> <p>Indicates what actions are allowed to be 
         * performed against a prescription.</p><p>This is a mandatory 
         * field because every prescription needs to be in some 
         * state.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"statusCode"})]
        public ActStatus StatusCode {
            get { return (ActStatus) this.statusCode.Value; }
            set { this.statusCode.Value = value; }
        }

        /**
         * <summary>F:Prescription Masking Indicators</summary>
         * 
         * <remarks><p>Communicates the intent of the patient to 
         * restrict access to their prescriptions.</p><p>Provides 
         * support for additional confidentiality constraint, giving 
         * patients a level of control over their 
         * information.</p><p>Allows a provider ro request restricted 
         * access by the patient.</p><p>Valid values are: 'N' (normal - 
         * denotes 'Not Masked'); 'R' (restricted - denotes 'Masked'); 
         * 'V' (very restricted - denotes very restricted access as 
         * declared by the Privacy Officer of the record holder) and 
         * 'T' (taboo - denotes 'Patient Access Restricted').</p><p>The 
         * default is 'normal' signifying 'Not Masked'.</p> 
         * <p>Communicates the intent of the patient to restrict access 
         * to their prescriptions.</p><p>Provides support for 
         * additional confidentiality constraint, giving patients a 
         * level of control over their information.</p><p>Allows a 
         * provider ro request restricted access by the 
         * patient.</p><p>Valid values are: 'N' (normal - denotes 'Not 
         * Masked'); 'R' (restricted - denotes 'Masked'); 'V' (very 
         * restricted - denotes very restricted access as declared by 
         * the Privacy Officer of the record holder) and 'T' (taboo - 
         * denotes 'Patient Access Restricted').</p><p>The default is 
         * 'normal' signifying 'Not Masked'.</p> <p>Communicates the 
         * intent of the patient to restrict access to their 
         * prescriptions.</p><p>Provides support for additional 
         * confidentiality constraint, giving patients a level of 
         * control over their information.</p><p>Allows a provider ro 
         * request restricted access by the patient.</p><p>Valid values 
         * are: 'N' (normal - denotes 'Not Masked'); 'R' (restricted - 
         * denotes 'Masked'); 'V' (very restricted - denotes very 
         * restricted access as declared by the Privacy Officer of the 
         * record holder) and 'T' (taboo - denotes 'Patient Access 
         * Restricted').</p><p>The default is 'normal' signifying 'Not 
         * Masked'.</p> <p>Communicates the intent of the patient to 
         * restrict access to their prescriptions.</p><p>Provides 
         * support for additional confidentiality constraint, giving 
         * patients a level of control over their 
         * information.</p><p>Allows a provider ro request restricted 
         * access by the patient.</p><p>Valid values are: 'N' (normal - 
         * denotes 'Not Masked'); 'R' (restricted - denotes 'Masked'); 
         * 'V' (very restricted - denotes very restricted access as 
         * declared by the Privacy Officer of the record holder) and 
         * 'T' (taboo - denotes 'Patient Access Restricted').</p><p>The 
         * default is 'normal' signifying 'Not Masked'.</p> 
         * <p>Communicates the intent of the patient to restrict access 
         * to their prescriptions.</p><p>Provides support for 
         * additional confidentiality constraint, giving patients a 
         * level of control over their information.</p><p>Allows a 
         * provider ro request restricted access by the 
         * patient.</p><p>Valid values are: 'N' (normal - denotes 'Not 
         * Masked'); 'R' (restricted - denotes 'Masked'); 'V' (very 
         * restricted - denotes very restricted access as declared by 
         * the Privacy Officer of the record holder) and 'T' (taboo - 
         * denotes 'Patient Access Restricted').</p><p>The default is 
         * 'normal' signifying 'Not Masked'.</p> <p>Allows the patient 
         * to have discrete control over access to their prescription 
         * data.</p><p>Taboo allows the provider to request restricted 
         * access to patient or their care giver.</p><p>Constraint: 
         * Cant have both normal and one of the other codes 
         * simultaneously.</p><p>The attribute is required because even 
         * if a jurisdiction doesn't support masking on the way in, it 
         * will need to need to communicate masked data returned from 
         * other jurisdictions.</p> <p>Allows the patient to have 
         * discrete control over access to their prescription 
         * data.</p><p>Taboo allows the provider to request restricted 
         * access to patient or their care giver.</p><p>Constraint: 
         * Cant have both normal and one of the other codes 
         * simultaneously.</p><p>The attribute is required because even 
         * if a jurisdiction doesn't support masking on the way in, it 
         * will need to need to communicate masked data returned from 
         * other jurisdictions.</p> <p>Allows the patient to have 
         * discrete control over access to their prescription 
         * data.</p><p>Taboo allows the provider to request restricted 
         * access to patient or their care giver.</p><p>Constraint: 
         * Cant have both normal and one of the other codes 
         * simultaneously.</p><p>The attribute is required because even 
         * if a jurisdiction doesn't support masking on the way in, it 
         * will need to need to communicate masked data returned from 
         * other jurisdictions.</p> <p>Allows the patient to have 
         * discrete control over access to their prescription 
         * data.</p><p>Taboo allows the provider to request restricted 
         * access to patient or their care giver.</p><p>Constraint: 
         * Cant have both normal and one of the other codes 
         * simultaneously.</p><p>The attribute is required because even 
         * if a jurisdiction doesn't support masking on the way in, it 
         * will need to need to communicate masked data returned from 
         * other jurisdictions.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"confidentialityCode"})]
        public ICollection<x_BasicConfidentialityKind> ConfidentialityCode {
            get { return this.confidentialityCode.RawSet<x_BasicConfidentialityKind>(); }
        }

        [Hl7XmlMappingAttribute(new string[] {"directTarget/manufacturedProduct"})]
        public Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Common.Coct_mt141007ca.DeviceProduct DirectTargetManufacturedProduct {
            get { return this.directTargetManufacturedProduct; }
            set { this.directTargetManufacturedProduct = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"responsibleParty/assignedEntity"})]
        public Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Common.Merged.HealthcareWorker ResponsiblePartyAssignedEntity {
            get { return this.responsiblePartyAssignedEntity; }
            set { this.responsiblePartyAssignedEntity = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"author"})]
        public Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Merged.PrescribedBy Author {
            get { return this.author; }
            set { this.author = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"location"})]
        public Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Merged.OccurredAt Location {
            get { return this.location; }
            set { this.location = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"predecessor/priorSupplyRequest"})]
        public Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Pharmacy.Merged.ParentPrescription PredecessorPriorSupplyRequest {
            get { return this.predecessorPriorSupplyRequest; }
            set { this.predecessorPriorSupplyRequest = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"reason"})]
        public IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Merged.BecauseOf> Reason {
            get { return this.reason; }
        }

        [Hl7XmlMappingAttribute(new string[] {"precondition/verificationEventCriterion"})]
        public bool? PreconditionVerificationEventCriterion {
            get { return this.preconditionVerificationEventCriterion.Value; }
            set { this.preconditionVerificationEventCriterion.Value = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"derivedFrom/sourceDispense"})]
        public bool? DerivedFromSourceDispense {
            get { return this.derivedFromSourceDispense.Value; }
            set { this.derivedFromSourceDispense.Value = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"coverage/coverage"})]
        public IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Pharmacy.Merged.CoverageExtensions_1> CoverageCoverage {
            get { return this.coverageCoverage; }
        }

        [Hl7XmlMappingAttribute(new string[] {"component1/procedureRequest"})]
        public Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Pharmacy.Merged.ProcedureRequest Component1ProcedureRequest {
            get { return this.component1ProcedureRequest; }
            set { this.component1ProcedureRequest = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"component2"})]
        public Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Pharmacy.Merged.Component6 Component2 {
            get { return this.component2; }
            set { this.component2 = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"fulfillment1/supplyEventLastSummary"})]
        public Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Pharmacy.Merged.LastDispenseInformation_2 Fulfillment1SupplyEventLastSummary {
            get { return this.fulfillment1SupplyEventLastSummary; }
            set { this.fulfillment1SupplyEventLastSummary = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"fulfillment2/supplyEventFirstSummary"})]
        public Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Pharmacy.Merged.FirstDispenseInformation_2 Fulfillment2SupplyEventFirstSummary {
            get { return this.fulfillment2SupplyEventFirstSummary; }
            set { this.fulfillment2SupplyEventFirstSummary = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"fulfillment3/supplyEventFutureSummary"})]
        public Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Pharmacy.Merged.RemainingDispenseInformation_2 Fulfillment3SupplyEventFutureSummary {
            get { return this.fulfillment3SupplyEventFutureSummary; }
            set { this.fulfillment3SupplyEventFutureSummary = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"fulfillment4/supplyEventPastSummary"})]
        public Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Pharmacy.Merged.PreviousDispenseInformation_2 Fulfillment4SupplyEventPastSummary {
            get { return this.fulfillment4SupplyEventPastSummary; }
            set { this.fulfillment4SupplyEventPastSummary = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"fulfillment5/deviceDispense"})]
        public IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Pharmacy.Merged.DeviceDispense> Fulfillment5DeviceDispense {
            get { return this.fulfillment5DeviceDispense; }
        }

        [Hl7XmlMappingAttribute(new string[] {"subjectOf1/detectedIssueEvent"})]
        public IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Common.Merged.Issues> SubjectOf1DetectedIssueEvent {
            get { return this.subjectOf1DetectedIssueEvent; }
        }

        [Hl7XmlMappingAttribute(new string[] {"subjectOf2/controlActEvent"})]
        public IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Pharmacy.Merged.StatusChanges> SubjectOf2ControlActEvent {
            get { return this.subjectOf2ControlActEvent; }
        }

        [Hl7XmlMappingAttribute(new string[] {"subjectOf3"})]
        public IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Merged.Includes> SubjectOf3 {
            get { return this.subjectOf3; }
        }

        [Hl7XmlMappingAttribute(new string[] {"subjectOf4/refusalToFill"})]
        public IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Pharmacy.Merged.RefusalToFills> SubjectOf4RefusalToFill {
            get { return this.subjectOf4RefusalToFill; }
        }

        [Hl7XmlMappingAttribute(new string[] {"subjectOf5/detectedIssueIndicator"})]
        public bool? SubjectOf5DetectedIssueIndicator {
            get { return this.subjectOf5DetectedIssueIndicator.Value; }
            set { this.subjectOf5DetectedIssueIndicator.Value = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"subjectOf6/annotationIndicator"})]
        public bool? SubjectOf6AnnotationIndicator {
            get { return this.subjectOf6AnnotationIndicator.Value; }
            set { this.subjectOf6AnnotationIndicator.Value = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"componentOf/patientCareProvisionEvent"})]
        public IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Merged.CareCompositions> ComponentOfPatientCareProvisionEvent {
            get { return this.componentOfPatientCareProvisionEvent; }
        }

    }

}