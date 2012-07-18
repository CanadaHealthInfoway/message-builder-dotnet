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
namespace Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Pharmacy.Porx_mt060160ca {
    using Ca.Infoway.Messagebuilder;
    using Ca.Infoway.Messagebuilder.Annotation;
    using Ca.Infoway.Messagebuilder.Datatype;
    using Ca.Infoway.Messagebuilder.Datatype.Impl;
    using Ca.Infoway.Messagebuilder.Datatype.Lang;
    using Ca.Infoway.Messagebuilder.Domainvalue;
    using Ca.Infoway.Messagebuilder.Model;
    using Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Common.Coct_mt220110ca;
    using Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Common.Coct_mt270010ca;
    using Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Common.Merged;
    using Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Merged;
    using Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Pharmacy.Merged;
    using System;
    using System.Collections.Generic;


    /**
     * <summary>Prescription</summary>
     * 
     * <remarks><p>Reported Issue is only permitted if Issue 
     * Indicator is not present and vice versa</p><p>Annotation is 
     * only permitted if Detected Issue Indicator is not present 
     * and vice versa</p> <p>Reported Issue is only permitted if 
     * Issue Indicator is not present and vice 
     * versa</p><p>Annotation is only permitted if Detected Issue 
     * Indicator is not present and vice versa</p> <p>Information 
     * pertaining to a Prescriber's authorization for a drug to be 
     * dispensed to a patient, as well as the instruction on when 
     * and how the drug is to be administered to the patient.</p> 
     * <p>This is a 'core' class of the medication model and is 
     * important for understanding what drugs the patient is 
     * intended to be receiving.</p></remarks>
     */
    [Hl7PartTypeMappingAttribute(new string[] {"PORX_MT060160CA.CombinedMedicationRequest"})]
    public class Prescription : MessagePartBean, Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Pharmacy.Merged.IMedicationRecord {

        private SET<II, Identifier> id;
        private CD code;
        private CS statusCode;
        private SET<CV, Code> confidentialityCode;
        private Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Common.Coct_mt220110ca.DrugProduct directTargetMedication;
        private Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Common.Merged.HealthcareWorker responsiblePartyAssignedEntity;
        private Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Merged.PrescribedBy author;
        private Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Merged.OccurredAt location;
        private IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Pharmacy.Merged.Protocols> definitionSubstanceAdministrationDefinition;
        private Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Pharmacy.Merged.ParentPrescription predecessorPriorCombinedMedicationRequest;
        private IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Merged.BecauseOf> reason;
        private BL preconditionVerificationEventCriterion;
        private BL derivedFromSourceDispense;
        private IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Pharmacy.Merged.CoverageExtensions_2> coverageCoverage;
        private IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Pharmacy.Merged.PrescriptionPatientMeasurements> pertinentInformationQuantityObservationEvent;
        private IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Common.Coct_mt270010ca.AdministrationInstructions> component1DosageInstruction;
        private Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Pharmacy.Merged.NotEligibleForTrial component2;
        private Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Pharmacy.Porx_mt060160ca.Includes component3;
        private IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Pharmacy.Merged.MedicationDispense> fulfillment1MedicationDispense;
        private Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Pharmacy.Merged.LastDispenseInformation_1 fulfillment2SupplyEventLastSummary;
        private Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Pharmacy.Merged.FirstDispenseInformation_1 fulfillment3SupplyEventFirstSummary;
        private Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Pharmacy.Merged.RemainingDispenseInformation_1 fulfillment4SupplyEventFutureSummary;
        private Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Pharmacy.Merged.PreviousDispenseInformation_1 fulfillment5SupplyEventPastSummary;
        private IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Common.Merged.Issues> subjectOf1DetectedIssueEvent;
        private BL subjectOf2DetectedIssueIndicator;
        private IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Merged.Includes> subjectOf3;
        private BL subjectOf4AnnotationIndicator;
        private Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Pharmacy.Merged.AllowedSubstitution subjectOf5SubstitutionPermission;
        private IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Pharmacy.Merged.StatusChanges> subjectOf6ControlActEvent;
        private IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Pharmacy.Merged.RefusalToFills> subjectOf7RefusalToFill;
        private IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Merged.CareCompositions> componentOf1PatientCareProvisionEvent;
        private Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Pharmacy.Merged.Classifies componentOf2;

        public Prescription() {
            this.id = new SETImpl<II, Identifier>(typeof(IIImpl));
            this.code = new CDImpl();
            this.statusCode = new CSImpl();
            this.confidentialityCode = new SETImpl<CV, Code>(typeof(CVImpl));
            this.definitionSubstanceAdministrationDefinition = new List<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Pharmacy.Merged.Protocols>();
            this.reason = new List<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Merged.BecauseOf>();
            this.preconditionVerificationEventCriterion = new BLImpl(false);
            this.derivedFromSourceDispense = new BLImpl(false);
            this.coverageCoverage = new List<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Pharmacy.Merged.CoverageExtensions_2>();
            this.pertinentInformationQuantityObservationEvent = new List<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Pharmacy.Merged.PrescriptionPatientMeasurements>();
            this.component1DosageInstruction = new List<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Common.Coct_mt270010ca.AdministrationInstructions>();
            this.fulfillment1MedicationDispense = new List<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Pharmacy.Merged.MedicationDispense>();
            this.subjectOf1DetectedIssueEvent = new List<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Common.Merged.Issues>();
            this.subjectOf2DetectedIssueIndicator = new BLImpl(false);
            this.subjectOf3 = new List<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Merged.Includes>();
            this.subjectOf4AnnotationIndicator = new BLImpl(false);
            this.subjectOf6ControlActEvent = new List<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Pharmacy.Merged.StatusChanges>();
            this.subjectOf7RefusalToFill = new List<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Pharmacy.Merged.RefusalToFills>();
            this.componentOf1PatientCareProvisionEvent = new List<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Merged.CareCompositions>();
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
         * <summary>Prescription Type</summary>
         * 
         * <remarks><p>Indicates that this is a prescription for a drug 
         * as opposed to an immunization. For SNOMED, may also contain 
         * information regarding drug and route.</p> <p>Needed to 
         * convey the meaning of this class and is therefore 
         * mandatory.</p><p>The element allows 'CD' to provide support 
         * for SNOMED.</p> <p>Needed to convey the meaning of this 
         * class and is therefore mandatory.</p><p>The element allows 
         * 'CD' to provide support for SNOMED.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"code"})]
        public Code Code {
            get { return (Code) this.code.Value; }
            set { this.code.Value = value; }
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
         * information.</p><p>Allows a provider to request restricted 
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
         * provider to request restricted access by the 
         * patient.</p><p>Valid values are: 'N' (normal - denotes 'Not 
         * Masked'); 'R' (restricted - denotes 'Masked'); 'V' (very 
         * restricted - denotes very restricted access as declared by 
         * the Privacy Officer of the record holder) and 'T' (taboo - 
         * denotes 'Patient Access Restricted').</p><p>The default is 
         * 'normal' signifying 'Not Masked'.</p> <p>Communicates the 
         * intent of the patient to restrict access to their 
         * prescriptions.</p><p>Provides support for additional 
         * confidentiality constraint, giving patients a level of 
         * control over their information.</p><p>Allows a provider to 
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
         * information.</p><p>Allows a provider to request restricted 
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
         * provider to request restricted access by the 
         * patient.</p><p>Valid values are: 'N' (normal - denotes 'Not 
         * Masked'); 'R' (restricted - denotes 'Masked'); 'V' (very 
         * restricted - denotes very restricted access as declared by 
         * the Privacy Officer of the record holder) and 'T' (taboo - 
         * denotes 'Patient Access Restricted').</p><p>The default is 
         * 'normal' signifying 'Not Masked'.</p> <p>Allows the patient 
         * to have discrete control over access to their medication 
         * data.</p><p>Taboo allows the provider to request restricted 
         * access to patient or their care giver.</p><p>Constraint: 
         * Cant have both normal and one of the other codes 
         * simultaneously.</p><p>The attribute is required because even 
         * if a jurisdiction doesn't support masking on the way in, it 
         * will need to need to communicate masked data returned from 
         * other jurisdictions.</p> <p>Allows the patient to have 
         * discrete control over access to their medication 
         * data.</p><p>Taboo allows the provider to request restricted 
         * access to patient or their care giver.</p><p>Constraint: 
         * Cant have both normal and one of the other codes 
         * simultaneously.</p><p>The attribute is required because even 
         * if a jurisdiction doesn't support masking on the way in, it 
         * will need to need to communicate masked data returned from 
         * other jurisdictions.</p> <p>Allows the patient to have 
         * discrete control over access to their medication 
         * data.</p><p>Taboo allows the provider to request restricted 
         * access to patient or their care giver.</p><p>Constraint: 
         * Cant have both normal and one of the other codes 
         * simultaneously.</p><p>The attribute is required because even 
         * if a jurisdiction doesn't support masking on the way in, it 
         * will need to need to communicate masked data returned from 
         * other jurisdictions.</p> <p>Allows the patient to have 
         * discrete control over access to their medication 
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

        [Hl7XmlMappingAttribute(new string[] {"directTarget/medication"})]
        public Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Common.Coct_mt220110ca.DrugProduct DirectTargetMedication {
            get { return this.directTargetMedication; }
            set { this.directTargetMedication = value; }
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

        [Hl7XmlMappingAttribute(new string[] {"definition/substanceAdministrationDefinition"})]
        public IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Pharmacy.Merged.Protocols> DefinitionSubstanceAdministrationDefinition {
            get { return this.definitionSubstanceAdministrationDefinition; }
        }

        [Hl7XmlMappingAttribute(new string[] {"predecessor/priorCombinedMedicationRequest"})]
        public Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Pharmacy.Merged.ParentPrescription PredecessorPriorCombinedMedicationRequest {
            get { return this.predecessorPriorCombinedMedicationRequest; }
            set { this.predecessorPriorCombinedMedicationRequest = value; }
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
        public IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Pharmacy.Merged.CoverageExtensions_2> CoverageCoverage {
            get { return this.coverageCoverage; }
        }

        [Hl7XmlMappingAttribute(new string[] {"pertinentInformation/quantityObservationEvent"})]
        public IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Pharmacy.Merged.PrescriptionPatientMeasurements> PertinentInformationQuantityObservationEvent {
            get { return this.pertinentInformationQuantityObservationEvent; }
        }

        [Hl7XmlMappingAttribute(new string[] {"component1/dosageInstruction"})]
        public IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Common.Coct_mt270010ca.AdministrationInstructions> Component1DosageInstruction {
            get { return this.component1DosageInstruction; }
        }

        [Hl7XmlMappingAttribute(new string[] {"component2"})]
        public Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Pharmacy.Merged.NotEligibleForTrial Component2 {
            get { return this.component2; }
            set { this.component2 = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"component3"})]
        public Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Pharmacy.Porx_mt060160ca.Includes Component3 {
            get { return this.component3; }
            set { this.component3 = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"fulfillment1/medicationDispense"})]
        public IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Pharmacy.Merged.MedicationDispense> Fulfillment1MedicationDispense {
            get { return this.fulfillment1MedicationDispense; }
        }

        [Hl7XmlMappingAttribute(new string[] {"fulfillment2/supplyEventLastSummary"})]
        public Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Pharmacy.Merged.LastDispenseInformation_1 Fulfillment2SupplyEventLastSummary {
            get { return this.fulfillment2SupplyEventLastSummary; }
            set { this.fulfillment2SupplyEventLastSummary = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"fulfillment3/supplyEventFirstSummary"})]
        public Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Pharmacy.Merged.FirstDispenseInformation_1 Fulfillment3SupplyEventFirstSummary {
            get { return this.fulfillment3SupplyEventFirstSummary; }
            set { this.fulfillment3SupplyEventFirstSummary = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"fulfillment4/supplyEventFutureSummary"})]
        public Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Pharmacy.Merged.RemainingDispenseInformation_1 Fulfillment4SupplyEventFutureSummary {
            get { return this.fulfillment4SupplyEventFutureSummary; }
            set { this.fulfillment4SupplyEventFutureSummary = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"fulfillment5/supplyEventPastSummary"})]
        public Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Pharmacy.Merged.PreviousDispenseInformation_1 Fulfillment5SupplyEventPastSummary {
            get { return this.fulfillment5SupplyEventPastSummary; }
            set { this.fulfillment5SupplyEventPastSummary = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"subjectOf1/detectedIssueEvent"})]
        public IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Common.Merged.Issues> SubjectOf1DetectedIssueEvent {
            get { return this.subjectOf1DetectedIssueEvent; }
        }

        [Hl7XmlMappingAttribute(new string[] {"subjectOf2/detectedIssueIndicator"})]
        public bool? SubjectOf2DetectedIssueIndicator {
            get { return this.subjectOf2DetectedIssueIndicator.Value; }
            set { this.subjectOf2DetectedIssueIndicator.Value = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"subjectOf3"})]
        public IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Merged.Includes> SubjectOf3 {
            get { return this.subjectOf3; }
        }

        [Hl7XmlMappingAttribute(new string[] {"subjectOf4/annotationIndicator"})]
        public bool? SubjectOf4AnnotationIndicator {
            get { return this.subjectOf4AnnotationIndicator.Value; }
            set { this.subjectOf4AnnotationIndicator.Value = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"subjectOf5/substitutionPermission"})]
        public Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Pharmacy.Merged.AllowedSubstitution SubjectOf5SubstitutionPermission {
            get { return this.subjectOf5SubstitutionPermission; }
            set { this.subjectOf5SubstitutionPermission = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"subjectOf6/controlActEvent"})]
        public IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Pharmacy.Merged.StatusChanges> SubjectOf6ControlActEvent {
            get { return this.subjectOf6ControlActEvent; }
        }

        [Hl7XmlMappingAttribute(new string[] {"subjectOf7/refusalToFill"})]
        public IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Pharmacy.Merged.RefusalToFills> SubjectOf7RefusalToFill {
            get { return this.subjectOf7RefusalToFill; }
        }

        [Hl7XmlMappingAttribute(new string[] {"componentOf1/patientCareProvisionEvent"})]
        public IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Merged.CareCompositions> ComponentOf1PatientCareProvisionEvent {
            get { return this.componentOf1PatientCareProvisionEvent; }
        }

        [Hl7XmlMappingAttribute(new string[] {"componentOf2"})]
        public Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Pharmacy.Merged.Classifies ComponentOf2 {
            get { return this.componentOf2; }
            set { this.componentOf2 = value; }
        }

    }

}