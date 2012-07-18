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
namespace Ca.Infoway.Messagebuilder.Model.Ab_mr2007_v02_r02.Sessionmgmt.Porx_mt060160ca {
    using Ca.Infoway.Messagebuilder;
    using Ca.Infoway.Messagebuilder.Annotation;
    using Ca.Infoway.Messagebuilder.Datatype;
    using Ca.Infoway.Messagebuilder.Datatype.Impl;
    using Ca.Infoway.Messagebuilder.Datatype.Lang;
    using Ca.Infoway.Messagebuilder.Domainvalue;
    using Ca.Infoway.Messagebuilder.Model;
    using Ca.Infoway.Messagebuilder.Model.Ab_mr2007_v02_r02.Merged;
    using Ca.Infoway.Messagebuilder.Model.Ab_mr2007_v02_r02.Sessionmgmt.Coct_mt090107ca;
    using Ca.Infoway.Messagebuilder.Model.Ab_mr2007_v02_r02.Sessionmgmt.Coct_mt120600ca;
    using Ca.Infoway.Messagebuilder.Model.Ab_mr2007_v02_r02.Sessionmgmt.Coct_mt220110ca;
    using Ca.Infoway.Messagebuilder.Model.Ab_mr2007_v02_r02.Sessionmgmt.Merged;
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
    public class Prescription : MessagePartBean, Ca.Infoway.Messagebuilder.Model.Ab_mr2007_v02_r02.Merged.IMedicationRecord {

        private II id;
        private CD code;
        private CS statusCode;
        private CV confidentialityCode;
        private Ca.Infoway.Messagebuilder.Model.Ab_mr2007_v02_r02.Merged.Patient subjectPatient;
        private Ca.Infoway.Messagebuilder.Model.Ab_mr2007_v02_r02.Sessionmgmt.Coct_mt220110ca.DrugProduct directTargetMedication;
        private Ca.Infoway.Messagebuilder.Model.Ab_mr2007_v02_r02.Sessionmgmt.Coct_mt090107ca.Provider responsiblePartyAssignedPerson;
        private Ca.Infoway.Messagebuilder.Model.Ab_mr2007_v02_r02.Merged.Author4 author;
        private CV informantAssignedEntityAssignedDeviceCode;
        private Ca.Infoway.Messagebuilder.Model.Ab_mr2007_v02_r02.Merged.CreatedAt location;
        private IList<Ca.Infoway.Messagebuilder.Model.Ab_mr2007_v02_r02.Merged.Protocols> definitionSubstanceAdministrationDefinition;
        private Ca.Infoway.Messagebuilder.Model.Ab_mr2007_v02_r02.Merged.ParentPrescription predecessorPriorCombinedMedicationRequest;
        private IList<Ca.Infoway.Messagebuilder.Model.Ab_mr2007_v02_r02.Merged.PrescribedBecauseOf> reason;
        private BL preconditionVerificationEventCriterion;
        private BL derivedFromSourceDispense;
        private IList<Ca.Infoway.Messagebuilder.Model.Ab_mr2007_v02_r02.Sessionmgmt.Merged.CoverageExtensions> coverageCoverage;
        private IList<Ca.Infoway.Messagebuilder.Model.Ab_mr2007_v02_r02.Merged.PrescriptionPatientMeasurements> pertinentInformationQuantityObservationEvent;
        private IList<Ca.Infoway.Messagebuilder.Model.Ab_mr2007_v02_r02.Merged.AdministrationInstructions> component1DosageInstruction;
        private Ca.Infoway.Messagebuilder.Model.Ab_mr2007_v02_r02.Sessionmgmt.Merged.NotEligibleForTrial component2;
        private Ca.Infoway.Messagebuilder.Model.Ab_mr2007_v02_r02.Sessionmgmt.Porx_mt060160ca.Includes component3;
        private IList<Ca.Infoway.Messagebuilder.Model.Ab_mr2007_v02_r02.Sessionmgmt.Merged.PrescriptionDispenses> fulfillment1MedicationDispense;
        private Ca.Infoway.Messagebuilder.Model.Ab_mr2007_v02_r02.Merged.LastDispenseInformation fulfillment2SupplyEventLastSummary;
        private Ca.Infoway.Messagebuilder.Model.Ab_mr2007_v02_r02.Merged.FirstDispenseInformation fulfillment3SupplyEventFirstSummary;
        private Ca.Infoway.Messagebuilder.Model.Ab_mr2007_v02_r02.Merged.RemainingDispenseInformation fulfillment4SupplyEventFutureSummary;
        private Ca.Infoway.Messagebuilder.Model.Ab_mr2007_v02_r02.Merged.PreviousDispenseInformation fulfillment5SupplyEventPastSummary;
        private IList<Ca.Infoway.Messagebuilder.Model.Ab_mr2007_v02_r02.Merged.Issues> subjectOf1DetectedIssueEvent;
        private BL subjectOf2DetectedIssueIndicator;
        private IList<Ca.Infoway.Messagebuilder.Model.Ab_mr2007_v02_r02.Sessionmgmt.Coct_mt120600ca.Notes> subjectOf3Annotation;
        private BL subjectOf4AnnotationIndicator;
        private Ca.Infoway.Messagebuilder.Model.Ab_mr2007_v02_r02.Merged.AllowedSubstitution subjectOf5SubstitutionPermission;
        private IList<Ca.Infoway.Messagebuilder.Model.Ab_mr2007_v02_r02.Sessionmgmt.Merged.StatusChanges> subjectOf6ControlActEvent;
        private IList<Ca.Infoway.Messagebuilder.Model.Ab_mr2007_v02_r02.Sessionmgmt.Merged.RefusalToFills> subjectOf7RefusalToFill;
        private Ca.Infoway.Messagebuilder.Model.Ab_mr2007_v02_r02.Merged.Classifies componentOf;

        public Prescription() {
            this.id = new IIImpl();
            this.code = new CDImpl();
            this.statusCode = new CSImpl();
            this.confidentialityCode = new CVImpl();
            this.informantAssignedEntityAssignedDeviceCode = new CVImpl();
            this.definitionSubstanceAdministrationDefinition = new List<Ca.Infoway.Messagebuilder.Model.Ab_mr2007_v02_r02.Merged.Protocols>();
            this.reason = new List<Ca.Infoway.Messagebuilder.Model.Ab_mr2007_v02_r02.Merged.PrescribedBecauseOf>();
            this.preconditionVerificationEventCriterion = new BLImpl(false);
            this.derivedFromSourceDispense = new BLImpl(false);
            this.coverageCoverage = new List<Ca.Infoway.Messagebuilder.Model.Ab_mr2007_v02_r02.Sessionmgmt.Merged.CoverageExtensions>();
            this.pertinentInformationQuantityObservationEvent = new List<Ca.Infoway.Messagebuilder.Model.Ab_mr2007_v02_r02.Merged.PrescriptionPatientMeasurements>();
            this.component1DosageInstruction = new List<Ca.Infoway.Messagebuilder.Model.Ab_mr2007_v02_r02.Merged.AdministrationInstructions>();
            this.fulfillment1MedicationDispense = new List<Ca.Infoway.Messagebuilder.Model.Ab_mr2007_v02_r02.Sessionmgmt.Merged.PrescriptionDispenses>();
            this.subjectOf1DetectedIssueEvent = new List<Ca.Infoway.Messagebuilder.Model.Ab_mr2007_v02_r02.Merged.Issues>();
            this.subjectOf2DetectedIssueIndicator = new BLImpl(false);
            this.subjectOf3Annotation = new List<Ca.Infoway.Messagebuilder.Model.Ab_mr2007_v02_r02.Sessionmgmt.Coct_mt120600ca.Notes>();
            this.subjectOf4AnnotationIndicator = new BLImpl(false);
            this.subjectOf6ControlActEvent = new List<Ca.Infoway.Messagebuilder.Model.Ab_mr2007_v02_r02.Sessionmgmt.Merged.StatusChanges>();
            this.subjectOf7RefusalToFill = new List<Ca.Infoway.Messagebuilder.Model.Ab_mr2007_v02_r02.Sessionmgmt.Merged.RefusalToFills>();
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
         * edits and validation.</p> 
         * <p>Prescription.prescriptionNumber</p><p>Prescription.prescriptionExternalKey</p><p>D53(ID 
         * for the prescription assigned by pharmacy)</p><p>D55(ID for 
         * the dispense event)</p><p>D99.01</p><p>X0101(id for 
         * prescription)</p><p>ZDP.5</p><p>ZDP.6</p><p>ZDP.22</p><p>ZRV.5</p><p>DRU.080-01(extension)</p><p>DRU.080-02(route)</p><p>Claim.455-EM 
         * (route)</p><p>Claim.402-D2 
         * (extension)</p><p>Claim.456-EN</p><p>Claim.454-EK</p><p>A_BillablePharmacyDispense</p> 
         * <p>Prescription.prescriptionNumber</p><p>Prescription.prescriptionExternalKey</p><p>D53(ID 
         * for the prescription assigned by pharmacy)</p><p>D55(ID for 
         * the dispense event)</p><p>D99.01</p><p>X0101(id for 
         * prescription)</p><p>ZDP.5</p><p>ZDP.6</p><p>ZDP.22</p><p>ZRV.5</p><p>DRU.080-01(extension)</p><p>DRU.080-02(route)</p><p>Claim.455-EM 
         * (route)</p><p>Claim.402-D2 
         * (extension)</p><p>Claim.456-EN</p><p>Claim.454-EK</p><p>A_BillablePharmacyDispense</p> 
         * <p>Prescription.prescriptionNumber</p><p>Prescription.prescriptionExternalKey</p><p>D53(ID 
         * for the prescription assigned by pharmacy)</p><p>D55(ID for 
         * the dispense event)</p><p>D99.01</p><p>X0101(id for 
         * prescription)</p><p>ZDP.5</p><p>ZDP.6</p><p>ZDP.22</p><p>ZRV.5</p><p>DRU.080-01(extension)</p><p>DRU.080-02(route)</p><p>Claim.455-EM 
         * (route)</p><p>Claim.402-D2 
         * (extension)</p><p>Claim.456-EN</p><p>Claim.454-EK</p><p>A_BillablePharmacyDispense</p> 
         * <p>Prescription.prescriptionNumber</p><p>Prescription.prescriptionExternalKey</p><p>D53(ID 
         * for the prescription assigned by pharmacy)</p><p>D55(ID for 
         * the dispense event)</p><p>D99.01</p><p>X0101(id for 
         * prescription)</p><p>ZDP.5</p><p>ZDP.6</p><p>ZDP.22</p><p>ZRV.5</p><p>DRU.080-01(extension)</p><p>DRU.080-02(route)</p><p>Claim.455-EM 
         * (route)</p><p>Claim.402-D2 
         * (extension)</p><p>Claim.456-EN</p><p>Claim.454-EK</p><p>A_BillablePharmacyDispense</p> 
         * <p>Prescription.prescriptionNumber</p><p>Prescription.prescriptionExternalKey</p><p>D53(ID 
         * for the prescription assigned by pharmacy)</p><p>D55(ID for 
         * the dispense event)</p><p>D99.01</p><p>X0101(id for 
         * prescription)</p><p>ZDP.5</p><p>ZDP.6</p><p>ZDP.22</p><p>ZRV.5</p><p>DRU.080-01(extension)</p><p>DRU.080-02(route)</p><p>Claim.455-EM 
         * (route)</p><p>Claim.402-D2 
         * (extension)</p><p>Claim.456-EN</p><p>Claim.454-EK</p><p>A_BillablePharmacyDispense</p> 
         * <p>Prescription.prescriptionNumber</p><p>Prescription.prescriptionExternalKey</p><p>D53(ID 
         * for the prescription assigned by pharmacy)</p><p>D55(ID for 
         * the dispense event)</p><p>D99.01</p><p>X0101(id for 
         * prescription)</p><p>ZDP.5</p><p>ZDP.6</p><p>ZDP.22</p><p>ZRV.5</p><p>DRU.080-01(extension)</p><p>DRU.080-02(route)</p><p>Claim.455-EM 
         * (route)</p><p>Claim.402-D2 
         * (extension)</p><p>Claim.456-EN</p><p>Claim.454-EK</p><p>A_BillablePharmacyDispense</p> 
         * <p>Prescription.prescriptionNumber</p><p>Prescription.prescriptionExternalKey</p><p>D53(ID 
         * for the prescription assigned by pharmacy)</p><p>D55(ID for 
         * the dispense event)</p><p>D99.01</p><p>X0101(id for 
         * prescription)</p><p>ZDP.5</p><p>ZDP.6</p><p>ZDP.22</p><p>ZRV.5</p><p>DRU.080-01(extension)</p><p>DRU.080-02(route)</p><p>Claim.455-EM 
         * (route)</p><p>Claim.402-D2 
         * (extension)</p><p>Claim.456-EN</p><p>Claim.454-EK</p><p>A_BillablePharmacyDispense</p> 
         * <p>Prescription.prescriptionNumber</p><p>Prescription.prescriptionExternalKey</p><p>D53(ID 
         * for the prescription assigned by pharmacy)</p><p>D55(ID for 
         * the dispense event)</p><p>D99.01</p><p>X0101(id for 
         * prescription)</p><p>ZDP.5</p><p>ZDP.6</p><p>ZDP.22</p><p>ZRV.5</p><p>DRU.080-01(extension)</p><p>DRU.080-02(route)</p><p>Claim.455-EM 
         * (route)</p><p>Claim.402-D2 
         * (extension)</p><p>Claim.456-EN</p><p>Claim.454-EK</p><p>A_BillablePharmacyDispense</p> 
         * <p>Prescription.prescriptionNumber</p><p>Prescription.prescriptionExternalKey</p><p>D53(ID 
         * for the prescription assigned by pharmacy)</p><p>D55(ID for 
         * the dispense event)</p><p>D99.01</p><p>X0101(id for 
         * prescription)</p><p>ZDP.5</p><p>ZDP.6</p><p>ZDP.22</p><p>ZRV.5</p><p>DRU.080-01(extension)</p><p>DRU.080-02(route)</p><p>Claim.455-EM 
         * (route)</p><p>Claim.402-D2 
         * (extension)</p><p>Claim.456-EN</p><p>Claim.454-EK</p><p>A_BillablePharmacyDispense</p> 
         * <p>Prescription.prescriptionNumber</p><p>Prescription.prescriptionExternalKey</p><p>D53(ID 
         * for the prescription assigned by pharmacy)</p><p>D55(ID for 
         * the dispense event)</p><p>D99.01</p><p>X0101(id for 
         * prescription)</p><p>ZDP.5</p><p>ZDP.6</p><p>ZDP.22</p><p>ZRV.5</p><p>DRU.080-01(extension)</p><p>DRU.080-02(route)</p><p>Claim.455-EM 
         * (route)</p><p>Claim.402-D2 
         * (extension)</p><p>Claim.456-EN</p><p>Claim.454-EK</p><p>A_BillablePharmacyDispense</p> 
         * <p>Prescription.prescriptionNumber</p><p>Prescription.prescriptionExternalKey</p><p>D53(ID 
         * for the prescription assigned by pharmacy)</p><p>D55(ID for 
         * the dispense event)</p><p>D99.01</p><p>X0101(id for 
         * prescription)</p><p>ZDP.5</p><p>ZDP.6</p><p>ZDP.22</p><p>ZRV.5</p><p>DRU.080-01(extension)</p><p>DRU.080-02(route)</p><p>Claim.455-EM 
         * (route)</p><p>Claim.402-D2 
         * (extension)</p><p>Claim.456-EN</p><p>Claim.454-EK</p><p>A_BillablePharmacyDispense</p> 
         * <p>Prescription.prescriptionNumber</p><p>Prescription.prescriptionExternalKey</p><p>D53(ID 
         * for the prescription assigned by pharmacy)</p><p>D55(ID for 
         * the dispense event)</p><p>D99.01</p><p>X0101(id for 
         * prescription)</p><p>ZDP.5</p><p>ZDP.6</p><p>ZDP.22</p><p>ZRV.5</p><p>DRU.080-01(extension)</p><p>DRU.080-02(route)</p><p>Claim.455-EM 
         * (route)</p><p>Claim.402-D2 
         * (extension)</p><p>Claim.456-EN</p><p>Claim.454-EK</p><p>A_BillablePharmacyDispense</p> 
         * <p>Prescription.prescriptionNumber</p><p>Prescription.prescriptionExternalKey</p><p>D53(ID 
         * for the prescription assigned by pharmacy)</p><p>D55(ID for 
         * the dispense event)</p><p>D99.01</p><p>X0101(id for 
         * prescription)</p><p>ZDP.5</p><p>ZDP.6</p><p>ZDP.22</p><p>ZRV.5</p><p>DRU.080-01(extension)</p><p>DRU.080-02(route)</p><p>Claim.455-EM 
         * (route)</p><p>Claim.402-D2 
         * (extension)</p><p>Claim.456-EN</p><p>Claim.454-EK</p><p>A_BillablePharmacyDispense</p> 
         * <p>Prescription.prescriptionNumber</p><p>Prescription.prescriptionExternalKey</p><p>D53(ID 
         * for the prescription assigned by pharmacy)</p><p>D55(ID for 
         * the dispense event)</p><p>D99.01</p><p>X0101(id for 
         * prescription)</p><p>ZDP.5</p><p>ZDP.6</p><p>ZDP.22</p><p>ZRV.5</p><p>DRU.080-01(extension)</p><p>DRU.080-02(route)</p><p>Claim.455-EM 
         * (route)</p><p>Claim.402-D2 
         * (extension)</p><p>Claim.456-EN</p><p>Claim.454-EK</p><p>A_BillablePharmacyDispense</p> 
         * <p>Prescription.prescriptionNumber</p><p>Prescription.prescriptionExternalKey</p><p>D53(ID 
         * for the prescription assigned by pharmacy)</p><p>D55(ID for 
         * the dispense event)</p><p>D99.01</p><p>X0101(id for 
         * prescription)</p><p>ZDP.5</p><p>ZDP.6</p><p>ZDP.22</p><p>ZRV.5</p><p>DRU.080-01(extension)</p><p>DRU.080-02(route)</p><p>Claim.455-EM 
         * (route)</p><p>Claim.402-D2 
         * (extension)</p><p>Claim.456-EN</p><p>Claim.454-EK</p><p>A_BillablePharmacyDispense</p> 
         * <p>Prescription.prescriptionNumber</p><p>Prescription.prescriptionExternalKey</p><p>D53(ID 
         * for the prescription assigned by pharmacy)</p><p>D55(ID for 
         * the dispense event)</p><p>D99.01</p><p>X0101(id for 
         * prescription)</p><p>ZDP.5</p><p>ZDP.6</p><p>ZDP.22</p><p>ZRV.5</p><p>DRU.080-01(extension)</p><p>DRU.080-02(route)</p><p>Claim.455-EM 
         * (route)</p><p>Claim.402-D2 
         * (extension)</p><p>Claim.456-EN</p><p>Claim.454-EK</p><p>A_BillablePharmacyDispense</p> 
         * <p>Prescription.prescriptionNumber</p><p>Prescription.prescriptionExternalKey</p><p>D53(ID 
         * for the prescription assigned by pharmacy)</p><p>D55(ID for 
         * the dispense event)</p><p>D99.01</p><p>X0101(id for 
         * prescription)</p><p>ZDP.5</p><p>ZDP.6</p><p>ZDP.22</p><p>ZRV.5</p><p>DRU.080-01(extension)</p><p>DRU.080-02(route)</p><p>Claim.455-EM 
         * (route)</p><p>Claim.402-D2 
         * (extension)</p><p>Claim.456-EN</p><p>Claim.454-EK</p><p>A_BillablePharmacyDispense</p> 
         * <p>Allows prescriptions to be uniquely referenced.</p><p>The 
         * number is mandatory to allow every prescription record to be 
         * uniquely identified.</p> <p>Allows prescriptions to be 
         * uniquely referenced.</p><p>The number is mandatory to allow 
         * every prescrip
         * ... [rest of documentation truncated due to excessive length]
         */
        [Hl7XmlMappingAttribute(new string[] {"id"})]
        public Identifier Id {
            get { return this.id.Value; }
            set { this.id.Value = value; }
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
        public ActCode Code {
            get { return (ActCode) this.code.Value; }
            set { this.code.Value = value; }
        }

        /**
         * <summary>C:Prescription Status</summary>
         * 
         * <remarks><p>This denotes the state of the prescription in 
         * the lifecycle of the prescription. Valid statuses are: NEW, 
         * ACTIVE, SUSPENDED, ABORTED, COMPLETED, OBSOLETE and 
         * NULLIFIED.</p> <p>Prescription.state (cannot distinguish 
         * between 'Filled' and 'Unfilled', must look at amounts 
         * dispensed to distniguish between those; and also cannot 
         * distinguish modified, need to look at event 
         * history).</p><p>Prescription Status</p> 
         * <p>Prescription.state (cannot distinguish between 'Filled' 
         * and 'Unfilled', must look at amounts dispensed to 
         * distniguish between those; and also cannot distinguish 
         * modified, need to look at event history).</p><p>Prescription 
         * Status</p> <p>Indicates what actions are allowed to be 
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
         * <summary>F:Prescription Masking Indicator</summary>
         * 
         * <remarks><p>Communicates the intent of the patient to 
         * restrict access to their prescriptions.</p><p>Provides 
         * support for additional confidentiality constraint, giving 
         * patients a level of control over their 
         * information.</p><p>Valid values are: 'NORMAL' (denotes 'Not 
         * Masked'); and 'RESTRICTED' (denotes 'Masked').</p><p>The 
         * default is 'NORMAL' signifying 'Not Masked'.</p> 
         * <p>Communicates the intent of the patient to restrict access 
         * to their prescriptions.</p><p>Provides support for 
         * additional confidentiality constraint, giving patients a 
         * level of control over their information.</p><p>Valid values 
         * are: 'NORMAL' (denotes 'Not Masked'); and 'RESTRICTED' 
         * (denotes 'Masked').</p><p>The default is 'NORMAL' signifying 
         * 'Not Masked'.</p> <p>Communicates the intent of the patient 
         * to restrict access to their prescriptions.</p><p>Provides 
         * support for additional confidentiality constraint, giving 
         * patients a level of control over their 
         * information.</p><p>Valid values are: 'NORMAL' (denotes 'Not 
         * Masked'); and 'RESTRICTED' (denotes 'Masked').</p><p>The 
         * default is 'NORMAL' signifying 'Not Masked'.</p> 
         * <p>Communicates the intent of the patient to restrict access 
         * to their prescriptions.</p><p>Provides support for 
         * additional confidentiality constraint, giving patients a 
         * level of control over their information.</p><p>Valid values 
         * are: 'NORMAL' (denotes 'Not Masked'); and 'RESTRICTED' 
         * (denotes 'Masked').</p><p>The default is 'NORMAL' signifying 
         * 'Not Masked'.</p> <p>Prescription.masked</p> <p>Allows the 
         * patient to have discrete control over access to their 
         * medication data.</p><p>The attribute is optional because not 
         * all systems will support masking.</p> <p>Allows the patient 
         * to have discrete control over access to their medication 
         * data.</p><p>The attribute is optional because not all 
         * systems will support masking.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"confidentialityCode"})]
        public x_VeryBasicConfidentialityKind ConfidentialityCode {
            get { return (x_VeryBasicConfidentialityKind) this.confidentialityCode.Value; }
            set { this.confidentialityCode.Value = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"subject/patient"})]
        public Ca.Infoway.Messagebuilder.Model.Ab_mr2007_v02_r02.Merged.Patient SubjectPatient {
            get { return this.subjectPatient; }
            set { this.subjectPatient = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"directTarget/medication"})]
        public Ca.Infoway.Messagebuilder.Model.Ab_mr2007_v02_r02.Sessionmgmt.Coct_mt220110ca.DrugProduct DirectTargetMedication {
            get { return this.directTargetMedication; }
            set { this.directTargetMedication = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"responsibleParty/assignedPerson"})]
        public Ca.Infoway.Messagebuilder.Model.Ab_mr2007_v02_r02.Sessionmgmt.Coct_mt090107ca.Provider ResponsiblePartyAssignedPerson {
            get { return this.responsiblePartyAssignedPerson; }
            set { this.responsiblePartyAssignedPerson = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"author"})]
        public Ca.Infoway.Messagebuilder.Model.Ab_mr2007_v02_r02.Merged.Author4 Author {
            get { return this.author; }
            set { this.author = value; }
        }

        /**
         * <summary>Prescription Source</summary>
         * 
         * <remarks><p>Indicates the data source for the information 
         * about the prescription.</p> <p>Some sources, such as Alberta 
         * Blue Cross have less complete data (e.g. no total quantity 
         * prescribed) and therefore cannot be directly dispensed 
         * against without updating with additional information from 
         * the paper script.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"informant/assignedEntity/assignedDevice/code"})]
        public Code InformantAssignedEntityAssignedDeviceCode {
            get { return (Code) this.informantAssignedEntityAssignedDeviceCode.Value; }
            set { this.informantAssignedEntityAssignedDeviceCode.Value = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"location"})]
        public Ca.Infoway.Messagebuilder.Model.Ab_mr2007_v02_r02.Merged.CreatedAt Location {
            get { return this.location; }
            set { this.location = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"definition/substanceAdministrationDefinition"})]
        public IList<Ca.Infoway.Messagebuilder.Model.Ab_mr2007_v02_r02.Merged.Protocols> DefinitionSubstanceAdministrationDefinition {
            get { return this.definitionSubstanceAdministrationDefinition; }
        }

        [Hl7XmlMappingAttribute(new string[] {"predecessor/priorCombinedMedicationRequest"})]
        public Ca.Infoway.Messagebuilder.Model.Ab_mr2007_v02_r02.Merged.ParentPrescription PredecessorPriorCombinedMedicationRequest {
            get { return this.predecessorPriorCombinedMedicationRequest; }
            set { this.predecessorPriorCombinedMedicationRequest = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"reason"})]
        public IList<Ca.Infoway.Messagebuilder.Model.Ab_mr2007_v02_r02.Merged.PrescribedBecauseOf> Reason {
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
        public IList<Ca.Infoway.Messagebuilder.Model.Ab_mr2007_v02_r02.Sessionmgmt.Merged.CoverageExtensions> CoverageCoverage {
            get { return this.coverageCoverage; }
        }

        [Hl7XmlMappingAttribute(new string[] {"pertinentInformation/quantityObservationEvent"})]
        public IList<Ca.Infoway.Messagebuilder.Model.Ab_mr2007_v02_r02.Merged.PrescriptionPatientMeasurements> PertinentInformationQuantityObservationEvent {
            get { return this.pertinentInformationQuantityObservationEvent; }
        }

        [Hl7XmlMappingAttribute(new string[] {"component1/dosageInstruction"})]
        public IList<Ca.Infoway.Messagebuilder.Model.Ab_mr2007_v02_r02.Merged.AdministrationInstructions> Component1DosageInstruction {
            get { return this.component1DosageInstruction; }
        }

        [Hl7XmlMappingAttribute(new string[] {"component2"})]
        public Ca.Infoway.Messagebuilder.Model.Ab_mr2007_v02_r02.Sessionmgmt.Merged.NotEligibleForTrial Component2 {
            get { return this.component2; }
            set { this.component2 = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"component3"})]
        public Ca.Infoway.Messagebuilder.Model.Ab_mr2007_v02_r02.Sessionmgmt.Porx_mt060160ca.Includes Component3 {
            get { return this.component3; }
            set { this.component3 = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"fulfillment1/medicationDispense"})]
        public IList<Ca.Infoway.Messagebuilder.Model.Ab_mr2007_v02_r02.Sessionmgmt.Merged.PrescriptionDispenses> Fulfillment1MedicationDispense {
            get { return this.fulfillment1MedicationDispense; }
        }

        [Hl7XmlMappingAttribute(new string[] {"fulfillment2/supplyEventLastSummary"})]
        public Ca.Infoway.Messagebuilder.Model.Ab_mr2007_v02_r02.Merged.LastDispenseInformation Fulfillment2SupplyEventLastSummary {
            get { return this.fulfillment2SupplyEventLastSummary; }
            set { this.fulfillment2SupplyEventLastSummary = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"fulfillment3/supplyEventFirstSummary"})]
        public Ca.Infoway.Messagebuilder.Model.Ab_mr2007_v02_r02.Merged.FirstDispenseInformation Fulfillment3SupplyEventFirstSummary {
            get { return this.fulfillment3SupplyEventFirstSummary; }
            set { this.fulfillment3SupplyEventFirstSummary = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"fulfillment4/supplyEventFutureSummary"})]
        public Ca.Infoway.Messagebuilder.Model.Ab_mr2007_v02_r02.Merged.RemainingDispenseInformation Fulfillment4SupplyEventFutureSummary {
            get { return this.fulfillment4SupplyEventFutureSummary; }
            set { this.fulfillment4SupplyEventFutureSummary = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"fulfillment5/supplyEventPastSummary"})]
        public Ca.Infoway.Messagebuilder.Model.Ab_mr2007_v02_r02.Merged.PreviousDispenseInformation Fulfillment5SupplyEventPastSummary {
            get { return this.fulfillment5SupplyEventPastSummary; }
            set { this.fulfillment5SupplyEventPastSummary = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"subjectOf1/detectedIssueEvent"})]
        public IList<Ca.Infoway.Messagebuilder.Model.Ab_mr2007_v02_r02.Merged.Issues> SubjectOf1DetectedIssueEvent {
            get { return this.subjectOf1DetectedIssueEvent; }
        }

        [Hl7XmlMappingAttribute(new string[] {"subjectOf2/detectedIssueIndicator"})]
        public bool? SubjectOf2DetectedIssueIndicator {
            get { return this.subjectOf2DetectedIssueIndicator.Value; }
            set { this.subjectOf2DetectedIssueIndicator.Value = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"subjectOf3/annotation"})]
        public IList<Ca.Infoway.Messagebuilder.Model.Ab_mr2007_v02_r02.Sessionmgmt.Coct_mt120600ca.Notes> SubjectOf3Annotation {
            get { return this.subjectOf3Annotation; }
        }

        [Hl7XmlMappingAttribute(new string[] {"subjectOf4/annotationIndicator"})]
        public bool? SubjectOf4AnnotationIndicator {
            get { return this.subjectOf4AnnotationIndicator.Value; }
            set { this.subjectOf4AnnotationIndicator.Value = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"subjectOf5/substitutionPermission"})]
        public Ca.Infoway.Messagebuilder.Model.Ab_mr2007_v02_r02.Merged.AllowedSubstitution SubjectOf5SubstitutionPermission {
            get { return this.subjectOf5SubstitutionPermission; }
            set { this.subjectOf5SubstitutionPermission = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"subjectOf6/controlActEvent"})]
        public IList<Ca.Infoway.Messagebuilder.Model.Ab_mr2007_v02_r02.Sessionmgmt.Merged.StatusChanges> SubjectOf6ControlActEvent {
            get { return this.subjectOf6ControlActEvent; }
        }

        [Hl7XmlMappingAttribute(new string[] {"subjectOf7/refusalToFill"})]
        public IList<Ca.Infoway.Messagebuilder.Model.Ab_mr2007_v02_r02.Sessionmgmt.Merged.RefusalToFills> SubjectOf7RefusalToFill {
            get { return this.subjectOf7RefusalToFill; }
        }

        [Hl7XmlMappingAttribute(new string[] {"componentOf"})]
        public Ca.Infoway.Messagebuilder.Model.Ab_mr2007_v02_r02.Merged.Classifies ComponentOf {
            get { return this.componentOf; }
            set { this.componentOf = value; }
        }

    }

}