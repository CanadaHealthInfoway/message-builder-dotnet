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
namespace Ca.Infoway.Messagebuilder.Model.Sk_cerx_v01_r04_3.Pharmacy.Porx_mt010120ca {
    using Ca.Infoway.Messagebuilder.Annotation;
    using Ca.Infoway.Messagebuilder.Datatype;
    using Ca.Infoway.Messagebuilder.Datatype.Impl;
    using Ca.Infoway.Messagebuilder.Datatype.Lang;
    using Ca.Infoway.Messagebuilder.Domainvalue;
    using Ca.Infoway.Messagebuilder.Model;
    using Ca.Infoway.Messagebuilder.Model.Sk_cerx_v01_r04_3.Common.Coct_mt220100ca;
    using Ca.Infoway.Messagebuilder.Model.Sk_cerx_v01_r04_3.Common.Merged;
    using Ca.Infoway.Messagebuilder.Model.Sk_cerx_v01_r04_3.Merged;
    using Ca.Infoway.Messagebuilder.Model.Sk_cerx_v01_r04_3.Pharmacy.Merged;
    using Ca.Infoway.Messagebuilder.Model.Sk_cerx_v01_r04_3.Pharmacy.Porx_mt980040ca;
    using System;
    using System.Collections.Generic;


    /**
     * <summary>Prescription</summary>
     * 
     * <remarks><p>Id should not be specified if the order is being 
     * sent by prescriber; Id is mandatory if the order is being 
     * sent by the DIS</p> <p>Information pertaining to a 
     * prescriber's authorization for a drug to be dispensed to a 
     * patient, as well as the instruction on when and how the drug 
     * is to be consumed by the patient</p> <p>This is a 'core' 
     * class of the medication model and is important for 
     * understanding what drugs the patient is intended to be 
     * receiving.</p></remarks>
     */
    [Hl7PartTypeMappingAttribute(new string[] {"PORX_MT010120CA.CombinedMedicationRequest"})]
    public class Prescription : MessagePartBean {

        private II id;
        private CS statusCode;
        private CV confidentialityCode;
        private Ca.Infoway.Messagebuilder.Model.Sk_cerx_v01_r04_3.Common.Coct_mt220100ca.DrugProduct directTargetMedication;
        private Ca.Infoway.Messagebuilder.Model.Sk_cerx_v01_r04_3.Common.Merged.Patient subjectPatient;
        private IList<Ca.Infoway.Messagebuilder.Model.Sk_cerx_v01_r04_3.Pharmacy.Merged.Protocols> definitionSubstanceAdministrationDefinition;
        private Ca.Infoway.Messagebuilder.Model.Sk_cerx_v01_r04_3.Pharmacy.Merged.ParentPrescription predecessorPriorCombinedMedicationRequest;
        private IList<Ca.Infoway.Messagebuilder.Model.Sk_cerx_v01_r04_3.Pharmacy.Merged.PrescribedBecauseOf> reason;
        private BL preconditionVerificationEventCriterion;
        private IList<Ca.Infoway.Messagebuilder.Model.Sk_cerx_v01_r04_3.Pharmacy.Merged.PrescriptionPatientMeasurements> pertinentInformationQuantityObservationEvent;
        private IList<Ca.Infoway.Messagebuilder.Model.Sk_cerx_v01_r04_3.Pharmacy.Merged.CoverageExtensions_1> coverageCoverage;
        private IList<Ca.Infoway.Messagebuilder.Model.Sk_cerx_v01_r04_3.Pharmacy.Porx_mt980040ca.AdministrationInstructions> component1DosageInstruction;
        private Ca.Infoway.Messagebuilder.Model.Sk_cerx_v01_r04_3.Pharmacy.Porx_mt010120ca.Component2 component2;
        private Ca.Infoway.Messagebuilder.Model.Sk_cerx_v01_r04_3.Pharmacy.Porx_mt010120ca.Includes component3;
        private Ca.Infoway.Messagebuilder.Model.Sk_cerx_v01_r04_3.Pharmacy.Merged.AllowedSubstitution subjectOf1SubstitutionPermission;
        private Ca.Infoway.Messagebuilder.Model.Sk_cerx_v01_r04_3.Merged.Comment subjectOf2Annotation;
        private Ca.Infoway.Messagebuilder.Model.Sk_cerx_v01_r04_3.Pharmacy.Merged.Classifies componentOf;

        public Prescription() {
            this.id = new IIImpl();
            this.statusCode = new CSImpl();
            this.confidentialityCode = new CVImpl();
            this.definitionSubstanceAdministrationDefinition = new List<Ca.Infoway.Messagebuilder.Model.Sk_cerx_v01_r04_3.Pharmacy.Merged.Protocols>();
            this.reason = new List<Ca.Infoway.Messagebuilder.Model.Sk_cerx_v01_r04_3.Pharmacy.Merged.PrescribedBecauseOf>();
            this.preconditionVerificationEventCriterion = new BLImpl(false);
            this.pertinentInformationQuantityObservationEvent = new List<Ca.Infoway.Messagebuilder.Model.Sk_cerx_v01_r04_3.Pharmacy.Merged.PrescriptionPatientMeasurements>();
            this.coverageCoverage = new List<Ca.Infoway.Messagebuilder.Model.Sk_cerx_v01_r04_3.Pharmacy.Merged.CoverageExtensions_1>();
            this.component1DosageInstruction = new List<Ca.Infoway.Messagebuilder.Model.Sk_cerx_v01_r04_3.Pharmacy.Porx_mt980040ca.AdministrationInstructions>();
        }
        /**
         * <summary>A:Prescription Number</summary>
         * 
         * <remarks><p>The Prescription Order Number is a globally 
         * unique number assigned to a prescription by the EHR/DIS 
         * irrespective of the source of the order</p><p>It is created 
         * by the EHR/DIS once the prescription has passed all edits 
         * and validation.</p> <p>The Prescription Order Number is a 
         * globally unique number assigned to a prescription by the 
         * EHR/DIS irrespective of the source of the order</p><p>It is 
         * created by the EHR/DIS once the prescription has passed all 
         * edits and validation.</p> <p>Allows for the situations where 
         * the order is originating from the DIS.</p><p>Allows 
         * prescriptions to be uniquely referenced.</p><p>Because this 
         * attribute is not used for prescriptions originating from a 
         * prescriber system, the element is optional.</p> <p>Allows 
         * for the situations where the order is originating from the 
         * DIS.</p><p>Allows prescriptions to be uniquely 
         * referenced.</p><p>Because this attribute is not used for 
         * prescriptions originating from a prescriber system, the 
         * element is optional.</p> <p>Allows for the situations where 
         * the order is originating from the DIS.</p><p>Allows 
         * prescriptions to be uniquely referenced.</p><p>Because this 
         * attribute is not used for prescriptions originating from a 
         * prescriber system, the element is optional.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"id"})]
        public Identifier Id {
            get { return this.id.Value; }
            set { this.id.Value = value; }
        }

        /**
         * <summary>C:Prescription Status</summary>
         * 
         * <remarks><p>This denotes the state of the prescription in 
         * the lifecycle of the prescription. Valid statuses are: new, 
         * active, suspended, aborted, completed, obsolete and 
         * nullified. Use 'new' when submitting a clinical 
         * pre-determination. Use 'active' when registering a new 
         * prescription or converting a predetermination into a valid 
         * prescription.</p> <p>Indicates what actions are allowed to 
         * be performed against a prescription. This is a mandatory 
         * field because every prescription needs to be in some 
         * state.</p> <p><strong>Any other code will cause a CODE_INVAL 
         * error issue to be returned.</strong></p></remarks>
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
         * restrict access to their prescriptions. Provides support for 
         * additional confidentiality constraint, giving patients a 
         * level of control over their information. Valid values are: 
         * 'NORMAL' (denotes 'Not Masked'); and 'RESTRICTED' (denotes 
         * 'Masked'). The default is 'NORMAL' signifying 'Not 
         * Masked'.</p> <p>Prescription.masked</p> <p>Allows the 
         * patient to have discrete control over access to their 
         * medication data.</p><p>The attribute is optional because not 
         * all systems will support masking.</p> <p>Allows the patient 
         * to have discrete control over access to their medication 
         * data.</p><p>The attribute is optional because not all 
         * systems will support masking.</p> <p><strong>As SK does not 
         * implement record-level masking, this must be "Normal" or a 
         * CODE_INVAL error issue will be returned.</strong></p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"confidentialityCode"})]
        public x_VeryBasicConfidentialityKind ConfidentialityCode {
            get { return (x_VeryBasicConfidentialityKind) this.confidentialityCode.Value; }
            set { this.confidentialityCode.Value = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"directTarget/medication"})]
        public Ca.Infoway.Messagebuilder.Model.Sk_cerx_v01_r04_3.Common.Coct_mt220100ca.DrugProduct DirectTargetMedication {
            get { return this.directTargetMedication; }
            set { this.directTargetMedication = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"subject/patient"})]
        public Ca.Infoway.Messagebuilder.Model.Sk_cerx_v01_r04_3.Common.Merged.Patient SubjectPatient {
            get { return this.subjectPatient; }
            set { this.subjectPatient = value; }
        }

        /**
         * <summary><div>Documentation of why a prescriber has chosen 
         * to&nbsp;prescribe the drug in the manner they 
         * have.&nbsp;</div></summary>
         */
        [Hl7XmlMappingAttribute(new string[] {"definition/substanceAdministrationDefinition"})]
        public IList<Ca.Infoway.Messagebuilder.Model.Sk_cerx_v01_r04_3.Pharmacy.Merged.Protocols> DefinitionSubstanceAdministrationDefinition {
            get { return this.definitionSubstanceAdministrationDefinition; }
        }

        [Hl7XmlMappingAttribute(new string[] {"predecessor/priorCombinedMedicationRequest"})]
        public Ca.Infoway.Messagebuilder.Model.Sk_cerx_v01_r04_3.Pharmacy.Merged.ParentPrescription PredecessorPriorCombinedMedicationRequest {
            get { return this.predecessorPriorCombinedMedicationRequest; }
            set { this.predecessorPriorCombinedMedicationRequest = value; }
        }

        /**
         * <summary><div>sent, &ldquo;Nulls&rdquo; are allowed if there 
         * are no indications&nbsp;recorded against a 
         * prescription.&nbsp;</div></summary>
         */
        [Hl7XmlMappingAttribute(new string[] {"reason"})]
        public IList<Ca.Infoway.Messagebuilder.Model.Sk_cerx_v01_r04_3.Pharmacy.Merged.PrescribedBecauseOf> Reason {
            get { return this.reason; }
        }

        /**
         * <summary>Non-authoritative Indicator</summary>
         * 
         * <remarks><div>before the prescription can be 
         * dispensed.</div></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"precondition/verificationEventCriterion"})]
        public bool? PreconditionVerificationEventCriterion {
            get { return this.preconditionVerificationEventCriterion.Value; }
            set { this.preconditionVerificationEventCriterion.Value = value; }
        }

        /**
         * <summary>Includes</summary>
         * 
         * <remarks><p>&nbsp;This comprises the height and/or weight of 
         * a&nbsp;patient as measured/observed/known by 
         * the&nbsp;prescriber at the time of prescribing.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"pertinentInformation/quantityObservationEvent"})]
        public IList<Ca.Infoway.Messagebuilder.Model.Sk_cerx_v01_r04_3.Pharmacy.Merged.PrescriptionPatientMeasurements> PertinentInformationQuantityObservationEvent {
            get { return this.pertinentInformationQuantityObservationEvent; }
        }

        [Hl7XmlMappingAttribute(new string[] {"coverage/coverage"})]
        public IList<Ca.Infoway.Messagebuilder.Model.Sk_cerx_v01_r04_3.Pharmacy.Merged.CoverageExtensions_1> CoverageCoverage {
            get { return this.coverageCoverage; }
        }

        [Hl7XmlMappingAttribute(new string[] {"component1/dosageInstruction"})]
        public IList<Ca.Infoway.Messagebuilder.Model.Sk_cerx_v01_r04_3.Pharmacy.Porx_mt980040ca.AdministrationInstructions> Component1DosageInstruction {
            get { return this.component1DosageInstruction; }
        }

        /**
         * <summary><div>Indicates that a prescription is part of a 
         * Trial&nbsp;Program.&nbsp;</div></summary>
         */
        [Hl7XmlMappingAttribute(new string[] {"component2"})]
        public Ca.Infoway.Messagebuilder.Model.Sk_cerx_v01_r04_3.Pharmacy.Porx_mt010120ca.Component2 Component2 {
            get { return this.component2; }
            set { this.component2 = value; }
        }

        /**
         * <summary><p>&nbsp;Identifies the instructions for how the 
         * prescribed&nbsp;medication should be dispensed to the 
         * patient.</p></summary>
         */
        [Hl7XmlMappingAttribute(new string[] {"component3"})]
        public Ca.Infoway.Messagebuilder.Model.Sk_cerx_v01_r04_3.Pharmacy.Porx_mt010120ca.Includes Component3 {
            get { return this.component3; }
            set { this.component3 = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"subjectOf1/substitutionPermission"})]
        public Ca.Infoway.Messagebuilder.Model.Sk_cerx_v01_r04_3.Pharmacy.Merged.AllowedSubstitution SubjectOf1SubstitutionPermission {
            get { return this.subjectOf1SubstitutionPermission; }
            set { this.subjectOf1SubstitutionPermission = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"subjectOf2/annotation"})]
        public Ca.Infoway.Messagebuilder.Model.Sk_cerx_v01_r04_3.Merged.Comment SubjectOf2Annotation {
            get { return this.subjectOf2Annotation; }
            set { this.subjectOf2Annotation = value; }
        }

        /**
         * <summary><div>prescription has been put.</div></summary>
         */
        [Hl7XmlMappingAttribute(new string[] {"componentOf"})]
        public Ca.Infoway.Messagebuilder.Model.Sk_cerx_v01_r04_3.Pharmacy.Merged.Classifies ComponentOf {
            get { return this.componentOf; }
            set { this.componentOf = value; }
        }

    }

}