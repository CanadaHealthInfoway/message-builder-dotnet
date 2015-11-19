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
namespace Ca.Infoway.Messagebuilder.Model.Pcs_cerx_v01_r04_4.Pharmacy.Merged {
    using Ca.Infoway.Messagebuilder.Annotation;
    using Ca.Infoway.Messagebuilder.Datatype;
    using Ca.Infoway.Messagebuilder.Datatype.Impl;
    using Ca.Infoway.Messagebuilder.Datatype.Lang;
    using Ca.Infoway.Messagebuilder.Domainvalue;
    using Ca.Infoway.Messagebuilder.Model;
    using Ca.Infoway.Messagebuilder.Model.Pcs_cerx_v01_r04_4.Common.Coct_mt220100ca;
    using System;


    /**
     * <summary>Business Name: ActiveMedication</summary>
     * 
     * <remarks>PORX_MT980020CA.SubstanceAdministration: Active 
     * Medication <p>Allows providers to identify the implicated 
     * drugs when determining their management approach.</p> 
     * <p>Indicates an active medication (prescription or 
     * non-prescription medication) that is recorded in the 
     * patient's record and which contributed to triggering the 
     * issue.</p> PORX_MT980010CA.SubstanceAdministration: Active 
     * Medication <p>Allows providers to identify the offending 
     * drugs when determining their management approach.</p> 
     * <p>Indicates an active medication (prescription or 
     * non-prescription medication) that is recorded in the 
     * patient's record and which contributed to triggering the 
     * issue.</p></remarks>
     */
    [Hl7PartTypeMappingAttribute(new string[] {"PORX_MT980010CA.SubstanceAdministration","PORX_MT980020CA.SubstanceAdministration"})]
    public class ActiveMedication : MessagePartBean, Ca.Infoway.Messagebuilder.Model.Pcs_cerx_v01_r04_4.Pharmacy.Porx_mt980010ca.ICausalActs, Ca.Infoway.Messagebuilder.Model.Pcs_cerx_v01_r04_4.Pharmacy.Porx_mt980020ca.ICausalActs {

        private CS moodCode;
        private II id;
        private CD code;
        private CS statusCode;
        private IVL<TS, Interval<PlatformDate>> effectiveTime;
        private CV confidentialityCode;
        private PQ doseQuantity;
        private Ca.Infoway.Messagebuilder.Model.Pcs_cerx_v01_r04_4.Common.Coct_mt220100ca.DrugProduct consumableMedication;

        public ActiveMedication() {
            this.moodCode = new CSImpl();
            this.id = new IIImpl();
            this.code = new CDImpl();
            this.statusCode = new CSImpl();
            this.effectiveTime = new IVLImpl<TS, Interval<PlatformDate>>();
            this.confidentialityCode = new CVImpl();
            this.doseQuantity = new PQImpl();
        }
        /**
         * <summary>Business Name: OtherMedicationIndicator</summary>
         * 
         * <remarks>Un-merged Business Name: OtherMedicationIndicator 
         * Relationship: 
         * PORX_MT980020CA.SubstanceAdministration.moodCode 
         * Conformance/Cardinality: MANDATORY (1) <p>Knowing whether a 
         * drug is prescribed or not can influence actions taken to 
         * mitigate an issue. The element is therefore mandatory.</p> 
         * <p>If the attribute is 'RQO', represents a prescription or 
         * dispense record. Otherwise if 'EVN', it represents an 'Other 
         * Medication' record.</p> Un-merged Business Name: 
         * OtherMedicationIndicator Relationship: 
         * PORX_MT980010CA.SubstanceAdministration.moodCode 
         * Conformance/Cardinality: MANDATORY (1) <p>Knowing whether a 
         * drug is prescribed or not can influence actions taken to 
         * mitigate an issue. This attribute is therefore 
         * mandatory.</p> <p>If the attribute is 'RQO', represents a 
         * prescription or dispense record. Otherwise if 'EVN', it 
         * represents an 'Other Medication' record.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"moodCode"})]
        public x_ActMoodOrderEvent MoodCode {
            get { return (x_ActMoodOrderEvent) this.moodCode.Value; }
            set { this.moodCode.Value = value; }
        }

        /**
         * <summary>Business Name: ActiveMedicationRecordNumber</summary>
         * 
         * <remarks>Un-merged Business Name: 
         * ActiveMedicationRecordNumber Relationship: 
         * PORX_MT980020CA.SubstanceAdministration.id 
         * Conformance/Cardinality: REQUIRED (1) 
         * <p>DDI/DuplicateTherapy.InteractingPrescriptionNumber</p> 
         * <p>InteractingPrescription.PrescriptionExternalKey</p> 
         * <p>InteractingPrescription.PrescriptionNumber</p> 
         * <p>DDI/Dosage/Duplicate Therapy.SourceNumber (All senders 
         * must uniquely identify prescriptions on request)</p> 
         * <p>Allows provider to drill-down and retrieve additional 
         * information about the implicated drug therapy to either 
         * modify the therapy or to learn more information in 
         * determining their management approach for the 
         * issue</p><p>The attribute is only marked as 'populated' 
         * because it may be masked.</p> <p>Unique identifier of the 
         * prescription or other medication drug record that triggered 
         * the issue.</p> Un-merged Business Name: 
         * ActiveMedicationRecordNumber Relationship: 
         * PORX_MT980010CA.SubstanceAdministration.id 
         * Conformance/Cardinality: REQUIRED (1) 
         * <p>DDI/DuplicateTherapy.InteractingPrescriptionNumber</p> 
         * <p>InteractingPrescription.PrescriptionExternalKey</p> 
         * <p>InteractingPrescription.PrescriptionNumber</p> 
         * <p>DDI/Dosage/Duplicate Therapy.SourceNumber (All senders 
         * must uniquely identify prescriptions on request)</p> 
         * <p>Allows provider to drill-down and retrieve additional 
         * information about the implicated drug therapy to either 
         * modify the therapy or to learn more information in 
         * determining their management approach for the 
         * issue.</p><p>The attribute is marked as populated because it 
         * may be masked.</p> <p>Unique identifier of the prescription 
         * or other medication drug record that triggered the 
         * issue.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"id"})]
        public Identifier Id {
            get { return this.id.Value; }
            set { this.id.Value = value; }
        }

        /**
         * <summary>Business Name: AdministrationType</summary>
         * 
         * <remarks>Un-merged Business Name: AdministrationType 
         * Relationship: PORX_MT980020CA.SubstanceAdministration.code 
         * Conformance/Cardinality: REQUIRED (1) <p>Needed to determine 
         * what to do about the issue. Because the medication can be 
         * masked, this element is only marked as 
         * 'populated'.</p><p>The element allows a full 'CD' type to 
         * support SNOMED implementations.</p> <p>Identifies whether 
         * the interaction is with a drug or a vaccine. For SNOMED, may 
         * also indicate the specific drug or vaccine at issue.</p> 
         * Un-merged Business Name: AdministrationType Relationship: 
         * PORX_MT980010CA.SubstanceAdministration.code 
         * Conformance/Cardinality: REQUIRED (1) <p>Needed to determine 
         * what to do about the issue. Because the medication can be 
         * masked, this element is only marked as 
         * 'populated'.</p><p>The element allows a full 'CD' type to 
         * support SNOMED implementations.</p> <p>Identifies whether 
         * the interaction is with a drug or a vaccine. For SNOMED, may 
         * also indicate the specific drug or vaccine at issue.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"code"})]
        public ActSubstanceAdministrationCode Code {
            get { return (ActSubstanceAdministrationCode) this.code.Value; }
            set { this.code.Value = value; }
        }

        /**
         * <summary>Business Name: ActiveMedicationStatus</summary>
         * 
         * <remarks>Un-merged Business Name: ActiveMedicationStatus 
         * Relationship: 
         * PORX_MT980020CA.SubstanceAdministration.statusCode 
         * Conformance/Cardinality: REQUIRED (0-1) <p>ZPB3.8 (aborted = 
         * discontinued; nullified = reversed/system reversed; 
         * active=filled/not-filled)</p> <p>Used to determine the 
         * relevance of the issue and the need to manage it. For 
         * example, if the medication is on hold, it may be less of an 
         * issue than if it is being actively taken.</p> <p>Indicates 
         * the status of the medication record at the time of the 
         * issue.</p> Un-merged Business Name: ActiveMedicationStatus 
         * Relationship: 
         * PORX_MT980010CA.SubstanceAdministration.statusCode 
         * Conformance/Cardinality: REQUIRED (0-1) <p>ZPB3.8 (aborted = 
         * discontinued; nullified = reversed/system reversed; 
         * active=filled/not-filled)</p> <p>Used to determine the 
         * relevance of the issue and the need to manage it. For 
         * example, if the medication is on hold, it may be less of an 
         * issue than if it is being actively taken.</p> <p>Indicates 
         * the status of the medication record at the time of the 
         * issue.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"statusCode"})]
        public ActStatus StatusCode {
            get { return (ActStatus) this.statusCode.Value; }
            set { this.statusCode.Value = value; }
        }

        /**
         * <summary>Business Name: ActiveMedicationTimeRange</summary>
         * 
         * <remarks>Un-merged Business Name: ActiveMedicationTimeRange 
         * Relationship: 
         * PORX_MT980020CA.SubstanceAdministration.effectiveTime 
         * Conformance/Cardinality: REQUIRED (0-1) <p>Requested 
         * Duration</p> <p>Allows the provider to evaluate 'duplicate 
         * therapy' and similar timing-based issues.</p> <p>The date 
         * and time during which the patient is expected to be taking 
         * the drug which triggered the issue.</p> Un-merged Business 
         * Name: ActiveMedicationTimeRange Relationship: 
         * PORX_MT980010CA.SubstanceAdministration.effectiveTime 
         * Conformance/Cardinality: REQUIRED (0-1) <p>Requested 
         * Duration</p> <p>Allows the provider to evaluate 'duplicate 
         * therapy' and similar timing-based issues.</p> <p>The date 
         * and time during which the patient is expected to be taking 
         * the drug which triggered the issue.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"effectiveTime"})]
        public Interval<PlatformDate> EffectiveTime {
            get { return this.effectiveTime.Value; }
            set { this.effectiveTime.Value = value; }
        }

        /**
         * <summary>Business Name: ActiveMedicationMaskingIndicator</summary>
         * 
         * <remarks>Un-merged Business Name: 
         * ActiveMedicationMaskingIndicator Relationship: 
         * PORX_MT980020CA.SubstanceAdministration.confidentialityCode 
         * Conformance/Cardinality: OPTIONAL (0-1) <p>Conveys the 
         * patient's wishes relating to the sensitivity of the 
         * drug.</p><p>The attribute is optional because not all 
         * systems will support masking.</p> <p>An indication of 
         * sensitivity surrounding the implicated drug, and thus 
         * defines the required sensitivity for the detected issue.</p> 
         * Un-merged Business Name: ActiveMedicationMaskingIndicator 
         * Relationship: 
         * PORX_MT980010CA.SubstanceAdministration.confidentialityCode 
         * Conformance/Cardinality: OPTIONAL (0-1) <p>Conveys the 
         * patient's wishes relating to the sensitivity of the drug 
         * information.</p><p>The attribute is optional because not all 
         * systems will support masking.</p> <p>An indication of 
         * sensitivity surrounding the related drug, and thus defines 
         * the required sensitivity for the detected issue.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"confidentialityCode"})]
        public x_VeryBasicConfidentialityKind ConfidentialityCode {
            get { return (x_VeryBasicConfidentialityKind) this.confidentialityCode.Value; }
            set { this.confidentialityCode.Value = value; }
        }

        /**
         * <summary>Business Name: ActiveMedicationDoseQuantity</summary>
         * 
         * <remarks>Un-merged Business Name: 
         * ActiveMedicationDoseQuantity Relationship: 
         * PORX_MT980020CA.SubstanceAdministration.doseQuantity 
         * Conformance/Cardinality: REQUIRED (0-1) <p>Requested Dosage 
         * Level</p> <p>ZPS.12</p> <p>ZDU.4.4</p> 
         * <p>Contraindication.dosageAmount</p> <p>Used in Low 
         * Dose/High Dose issues.</p> <p>The amount of medication 
         * administered to the patient</p> Un-merged Business Name: 
         * ActiveMedicationDoseQuantity Relationship: 
         * PORX_MT980010CA.SubstanceAdministration.doseQuantity 
         * Conformance/Cardinality: REQUIRED (0-1) <p>Requested Dosage 
         * Level</p> <p>ZPS.12</p> <p>ZDU.4.4</p> 
         * <p>Contraindication.dosageAmount</p> <p>Used in Low 
         * Dose/High Dose issues.</p> <p>The amount of medication 
         * administered to the patient</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"doseQuantity"})]
        public PhysicalQuantity DoseQuantity {
            get { return this.doseQuantity.Value; }
            set { this.doseQuantity.Value = value; }
        }

        /**
         * <summary>Un-merged Business Name: (no business name 
         * specified)</summary>
         * 
         * <remarks>Relationship: PORX_MT980020CA.Consumable.medication 
         * Conformance/Cardinality: REQUIRED (1) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * PORX_MT980010CA.Consumable.medication 
         * Conformance/Cardinality: REQUIRED (1)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"consumable/medication"})]
        public Ca.Infoway.Messagebuilder.Model.Pcs_cerx_v01_r04_4.Common.Coct_mt220100ca.DrugProduct ConsumableMedication {
            get { return this.consumableMedication; }
            set { this.consumableMedication = value; }
        }

    }

}