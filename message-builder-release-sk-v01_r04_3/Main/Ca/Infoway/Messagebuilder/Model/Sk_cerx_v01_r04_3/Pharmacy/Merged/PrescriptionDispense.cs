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
namespace Ca.Infoway.Messagebuilder.Model.Sk_cerx_v01_r04_3.Pharmacy.Merged {
    using Ca.Infoway.Messagebuilder.Annotation;
    using Ca.Infoway.Messagebuilder.Datatype;
    using Ca.Infoway.Messagebuilder.Datatype.Impl;
    using Ca.Infoway.Messagebuilder.Datatype.Lang;
    using Ca.Infoway.Messagebuilder.Domainvalue;
    using Ca.Infoway.Messagebuilder.Model;
    using Ca.Infoway.Messagebuilder.Model.Sk_cerx_v01_r04_3.Common.Coct_mt090107ca;
    using Ca.Infoway.Messagebuilder.Model.Sk_cerx_v01_r04_3.Common.Merged;
    using Ca.Infoway.Messagebuilder.Model.Sk_cerx_v01_r04_3.Merged;
    using Ca.Infoway.Messagebuilder.Model.Sk_cerx_v01_r04_3.Pharmacy.Porx_mt060020ca;
    using System;


    /**
     * <summary>PORX_MT020060CA.DeviceDispense: Prescription 
     * Dispense</summary>
     * 
     * <remarks><p>This is the detailed information about a device 
     * dispense that has been performed on behalf a patient</p> 
     * <p>A_BillablePharmacyDispense</p> <p>Dispensing is an 
     * integral part of the overall prescription process.</p> 
     * PORX_MT060020CA.DeviceDispense: Dispense <p>Represents the 
     * dispensing of a device to a patient.</p> <p>Communicates an 
     * overview of a patient's dispenses.</p></remarks>
     */
    [Hl7PartTypeMappingAttribute(new string[] {"PORX_MT020060CA.DeviceDispense","PORX_MT060020CA.DeviceDispense"})]
    public class PrescriptionDispense : MessagePartBean {

        private II id;
        private CV confidentialityCode;
        private Ca.Infoway.Messagebuilder.Model.Sk_cerx_v01_r04_3.Pharmacy.Merged.IPatient subjectPatient1;
        private Ca.Infoway.Messagebuilder.Model.Sk_cerx_v01_r04_3.Common.Merged.Patient recordTargetPatient;
        private Ca.Infoway.Messagebuilder.Model.Sk_cerx_v01_r04_3.Pharmacy.Merged.PrescriptionReference inFulfillmentOfDeviceRequest;
        private Ca.Infoway.Messagebuilder.Model.Sk_cerx_v01_r04_3.Pharmacy.Merged.ProcedureRequest component1ProcedureRequest;
        private Ca.Infoway.Messagebuilder.Model.Sk_cerx_v01_r04_3.Pharmacy.Merged.DispenseDetails componentSupplyEvent;
        private Ca.Infoway.Messagebuilder.Model.Sk_cerx_v01_r04_3.Merged.Comment subjectOfAnnotation;
        private CS statusCode;
        private Ca.Infoway.Messagebuilder.Model.Sk_cerx_v01_r04_3.Common.Coct_mt090107ca.Provider responsiblePartyAssignedPerson;
        private Ca.Infoway.Messagebuilder.Model.Sk_cerx_v01_r04_3.Common.Coct_mt090107ca.Provider performerAssignedPerson;
        private Ca.Infoway.Messagebuilder.Model.Sk_cerx_v01_r04_3.Merged.RecordedAt location;
        private Ca.Infoway.Messagebuilder.Model.Sk_cerx_v01_r04_3.Pharmacy.Porx_mt060020ca.DispensedPrescriptionReference fulfillment;
        private BL subjectOf1DetectedIssueIndicator;
        private BL subjectOf2AnnotationIndicator;

        public PrescriptionDispense() {
            this.id = new IIImpl();
            this.confidentialityCode = new CVImpl();
            this.statusCode = new CSImpl();
            this.subjectOf1DetectedIssueIndicator = new BLImpl(false);
            this.subjectOf2AnnotationIndicator = new BLImpl(false);
        }
        /**
         * <summary>PrescriptionDispenseNumber</summary>
         * 
         * <remarks>A:Prescription Dispense Number <p>Identifier 
         * assigned by the dispensing facility.</p> <p>Allows formal 
         * tracking of centrally recorded dispenses to local records 
         * for audit and related purposes.</p> 
         * </font></font></font></b></p> A:Prescription Dispense Number 
         * <p>The Prescription Dispense Number is a globally unique 
         * number assigned to a dispense (single fill) by the EHR/DIS 
         * irrespective of the source of the dispense.</p><p>It is 
         * created by the EHR/DIS once the dispense has passed all 
         * edits and validation.</p> <p>The Prescription Dispense 
         * Number is a globally unique number assigned to a dispense 
         * (single fill) by the EHR/DIS irrespective of the source of 
         * the dispense.</p><p>It is created by the EHR/DIS once the 
         * dispense has passed all edits and validation.</p> <p>Allows 
         * for the referencing of a specific dispense 
         * record.</p><p>Identifier for a dispensed record is needed so 
         * that dispenses may be uniquely referenced. Thus the 
         * mandatory requirement.</p> <p>Allows for the referencing of 
         * a specific dispense record.</p><p>Identifier for a dispensed 
         * record is needed so that dispenses may be uniquely 
         * referenced. Thus the mandatory requirement.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"id"})]
        public Identifier Id {
            get { return this.id.Value; }
            set { this.id.Value = value; }
        }

        /**
         * <summary>PrescriptionMaskingIndicator</summary>
         * 
         * <remarks>E:Prescription Masking Indicator <p>Communicates 
         * the intent of the patient to restrict access to their 
         * prescriptions.</p><p>Provides support for additional 
         * confidentiality constraint, giving patients a level of 
         * control over their information.</p><p>Valid values are: 
         * 'NORMAL' (denotes 'Not Masked'); and 'RESTRICTED' (denotes 
         * 'Masked').</p><p>The default is 'NORMAL' signifying 'Not 
         * Masked'.</p> <p>Communicates the intent of the patient to 
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
         * default is 'NORMAL' signifying 'Not Masked'.</p> <p>Allows 
         * the patient to have discrete control over access to their 
         * medication data.</p><p>The attribute is optional because not 
         * all systems will support masking.</p> <p>Allows the patient 
         * to have discrete control over access to their medication 
         * data.</p><p>The attribute is optional because not all 
         * systems will support masking.</p> E:Prescription Masking 
         * Indicator <p>Communicates the intent that the dispense 
         * should be masked if it is created; If the dispense is 
         * masked, this makes the complete prescription and all 
         * dispenses masked.</p> <p>DispensedItem.masked</p> <p>Can be 
         * used to set a mask for a new dispense, if present in a new 
         * dispense request.</p><p>The attribute is optional because 
         * not all systems will support masking.</p> <p>Can be used to 
         * set a mask for a new dispense, if present in a new dispense 
         * request.</p><p>The attribute is optional because not all 
         * systems will support masking.</p> <p>If a dispense is 
         * masked, it implicitly masks the prescription being 
         * dispensed. (There's no point in masking a dispense if the 
         * prescription is unmasked.)</p> <p>CODE_INVAL error issue 
         * will be returned.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"confidentialityCode"})]
        public x_VeryBasicConfidentialityKind ConfidentialityCode {
            get { return (x_VeryBasicConfidentialityKind) this.confidentialityCode.Value; }
            set { this.confidentialityCode.Value = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"subject/patient1"})]
        public Ca.Infoway.Messagebuilder.Model.Sk_cerx_v01_r04_3.Pharmacy.Merged.IPatient SubjectPatient1 {
            get { return this.subjectPatient1; }
            set { this.subjectPatient1 = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"recordTarget/patient"})]
        public Ca.Infoway.Messagebuilder.Model.Sk_cerx_v01_r04_3.Common.Merged.Patient RecordTargetPatient {
            get { return this.recordTargetPatient; }
            set { this.recordTargetPatient = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"inFulfillmentOf/deviceRequest"})]
        public Ca.Infoway.Messagebuilder.Model.Sk_cerx_v01_r04_3.Pharmacy.Merged.PrescriptionReference InFulfillmentOfDeviceRequest {
            get { return this.inFulfillmentOfDeviceRequest; }
            set { this.inFulfillmentOfDeviceRequest = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"component1/procedureRequest"})]
        public Ca.Infoway.Messagebuilder.Model.Sk_cerx_v01_r04_3.Pharmacy.Merged.ProcedureRequest Component1ProcedureRequest {
            get { return this.component1ProcedureRequest; }
            set { this.component1ProcedureRequest = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"component/supplyEvent","component2/supplyEvent"})]
        [Hl7MapByPartType(Name="component", Type="PORX_MT060020CA.Component2")]
        [Hl7MapByPartType(Name="component/supplyEvent", Type="PORX_MT060020CA.SupplyEvent")]
        [Hl7MapByPartType(Name="component2", Type="PORX_MT020060CA.Component")]
        [Hl7MapByPartType(Name="component2/supplyEvent", Type="PORX_MT020060CA.SupplyEvent")]
        public Ca.Infoway.Messagebuilder.Model.Sk_cerx_v01_r04_3.Pharmacy.Merged.DispenseDetails ComponentSupplyEvent {
            get { return this.componentSupplyEvent; }
            set { this.componentSupplyEvent = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"subjectOf/annotation"})]
        public Ca.Infoway.Messagebuilder.Model.Sk_cerx_v01_r04_3.Merged.Comment SubjectOfAnnotation {
            get { return this.subjectOfAnnotation; }
            set { this.subjectOfAnnotation = value; }
        }

        /**
         * <summary>DispenseStatus</summary>
         * 
         * <remarks>C:Dispense Status <p>Indicates the status of the 
         * dispense record created on the EHR/DIS. If 'Active' it means 
         * that the dispense has been processed but not yet given to 
         * the patient. If 'Complete', it indicates that the medication 
         * has been delivered to the patient.</p> <p>Important in 
         * understanding what medication the patient actually has on 
         * hand, thus the attribute is mandatory. May also influence 
         * the ability of a different pharmacy to dispense the 
         * medication.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"statusCode"})]
        public ActStatus StatusCode {
            get { return (ActStatus) this.statusCode.Value; }
            set { this.statusCode.Value = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"responsibleParty/assignedPerson"})]
        public Ca.Infoway.Messagebuilder.Model.Sk_cerx_v01_r04_3.Common.Coct_mt090107ca.Provider ResponsiblePartyAssignedPerson {
            get { return this.responsiblePartyAssignedPerson; }
            set { this.responsiblePartyAssignedPerson = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"performer/assignedPerson"})]
        public Ca.Infoway.Messagebuilder.Model.Sk_cerx_v01_r04_3.Common.Coct_mt090107ca.Provider PerformerAssignedPerson {
            get { return this.performerAssignedPerson; }
            set { this.performerAssignedPerson = value; }
        }

        /**
         * <summary>(no business name)</summary>
         * 
         * <remarks><p>was performed.&nbsp;</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"location"})]
        public Ca.Infoway.Messagebuilder.Model.Sk_cerx_v01_r04_3.Merged.RecordedAt Location {
            get { return this.location; }
            set { this.location = value; }
        }

        /**
         * <summary>(no business name)</summary>
         * 
         * <remarks><p>Indicates the prescription that was 
         * dispensed.</p> <p><strong>NOTE: Although the CeRx 
         * specification defines this to be 0..1, a dispense in PIN is 
         * always associated with a prescription.</strong></p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"fulfillment"})]
        public Ca.Infoway.Messagebuilder.Model.Sk_cerx_v01_r04_3.Pharmacy.Porx_mt060020ca.DispensedPrescriptionReference Fulfillment {
            get { return this.fulfillment; }
            set { this.fulfillment = value; }
        }

        /**
         * <summary>IssueIndicator</summary>
         * 
         * <remarks>Issue Indicator <div>issues.</div></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"subjectOf1/detectedIssueIndicator"})]
        public bool? SubjectOf1DetectedIssueIndicator {
            get { return this.subjectOf1DetectedIssueIndicator.Value; }
            set { this.subjectOf1DetectedIssueIndicator.Value = value; }
        }

        /**
         * <summary>AnnotationIndicator</summary>
         * 
         * <remarks>Annotation Indicator <p>notes were not to be 
         * included and there are notes.&nbsp;</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"subjectOf2/annotationIndicator"})]
        public bool? SubjectOf2AnnotationIndicator {
            get { return this.subjectOf2AnnotationIndicator.Value; }
            set { this.subjectOf2AnnotationIndicator.Value = value; }
        }

    }

}