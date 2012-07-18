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
    using Ca.Infoway.Messagebuilder.Model.Sk_cerx_v01_r04_3.Merged;
    using Ca.Infoway.Messagebuilder.Model.Sk_cerx_v01_r04_3.Pharmacy.Porx_mt980040ca;
    using System;
    using System.Collections.Generic;


    /**
     * <summary>PORX_MT060340CA.MedicationDispense: Prescription 
     * Dispenses</summary>
     * 
     * <remarks><p>Reported Issue is only permitted if Issue 
     * Indicator is not present</p><p>Annotation is only permitted 
     * if Annotation Indicator is not present</p> <p>Reported Issue 
     * is only permitted if Issue Indicator is not 
     * present</p><p>Annotation is only permitted if Annotation 
     * Indicator is not present</p> <p>This is the detailed 
     * information about a medication dispense that has been 
     * performed on behalf of a patient.</p> 
     * <p>A_BillablePharmacyDispense</p> <p>Dispensing is an 
     * integral part of the overall medication process.</p> 
     * PORX_MT060090CA.MedicationDispense: Dispense <p>Reported 
     * Issue is only permitted if Issue Indicator is not 
     * present</p><p>Annotation is only permitted if Annotation 
     * Indicator is not present</p> <p>Reported Issue is only 
     * permitted if Issue Indicator is not present</p><p>Annotation 
     * is only permitted if Annotation Indicator is not present</p> 
     * <p>Describes the issuing of a drug in response to an 
     * authorizing prescription.</p> <p>This is a 'core' class of 
     * the medication model and is important for understanding what 
     * drugs the patient is actually receiving.</p> 
     * PORX_MT060160CA.MedicationDispense: Prescription Dispenses 
     * <p>Reported Issue is only permitted if Issue Indicator is 
     * not present and vice versa</p><p>Annotation is only 
     * permitted if Annotation Indicator is not present and vice 
     * versa</p> <p>Reported Issue is only permitted if Issue 
     * Indicator is not present and vice versa</p><p>Annotation is 
     * only permitted if Annotation Indicator is not present and 
     * vice versa</p> <p>This is the detailed information about a 
     * medication dispense that has been performed on behalf of a 
     * patient.</p> <p>A_BillablePharmacyDispense</p> <p>Dispensing 
     * is an integral part of the overall medication process.</p></remarks>
     */
    [Hl7PartTypeMappingAttribute(new string[] {"PORX_MT060090CA.MedicationDispense","PORX_MT060160CA.MedicationDispense","PORX_MT060340CA.MedicationDispense"})]
    public class MedicationDispense : MessagePartBean {

        private II id;
        private CS statusCode;
        private Ca.Infoway.Messagebuilder.Model.Sk_cerx_v01_r04_3.Common.Coct_mt090107ca.Provider responsiblePartyAssignedPerson;
        private Ca.Infoway.Messagebuilder.Model.Sk_cerx_v01_r04_3.Common.Coct_mt090107ca.Provider performerAssignedPerson;
        private Ca.Infoway.Messagebuilder.Model.Sk_cerx_v01_r04_3.Merged.RecordedAt location;
        private IList<Ca.Infoway.Messagebuilder.Model.Sk_cerx_v01_r04_3.Pharmacy.Porx_mt980040ca.AdministrationInstructions> component2DosageInstruction;
        private Ca.Infoway.Messagebuilder.Model.Sk_cerx_v01_r04_3.Pharmacy.Merged.Substitution component3SubstitutionMade;
        private Ca.Infoway.Messagebuilder.Model.Sk_cerx_v01_r04_3.Pharmacy.Merged.SupplyEvent_1 component1SupplyEvent;
        private IList<Ca.Infoway.Messagebuilder.Model.Sk_cerx_v01_r04_3.Pharmacy.Merged.StatusChanges> subjectOf1ControlActEvent;
        private IList<Ca.Infoway.Messagebuilder.Model.Sk_cerx_v01_r04_3.Merged.Comment> subjectOf4Annotation;
        private BL subjectOf3DetectedIssueIndicator;
        private IList<Ca.Infoway.Messagebuilder.Model.Sk_cerx_v01_r04_3.Pharmacy.Merged.Issues> subjectOf5DetectedIssueEvent;
        private BL subjectOf2AnnotationIndicator;
        private CV confidentialityCode;
        private Ca.Infoway.Messagebuilder.Model.Sk_cerx_v01_r04_3.Pharmacy.Merged.PrescriptionReference inFulfillmentOfSubstanceAdministrationRequest;

        public MedicationDispense() {
            this.id = new IIImpl();
            this.statusCode = new CSImpl();
            this.component2DosageInstruction = new List<Ca.Infoway.Messagebuilder.Model.Sk_cerx_v01_r04_3.Pharmacy.Porx_mt980040ca.AdministrationInstructions>();
            this.subjectOf1ControlActEvent = new List<Ca.Infoway.Messagebuilder.Model.Sk_cerx_v01_r04_3.Pharmacy.Merged.StatusChanges>();
            this.subjectOf4Annotation = new List<Ca.Infoway.Messagebuilder.Model.Sk_cerx_v01_r04_3.Merged.Comment>();
            this.subjectOf3DetectedIssueIndicator = new BLImpl(false);
            this.subjectOf5DetectedIssueEvent = new List<Ca.Infoway.Messagebuilder.Model.Sk_cerx_v01_r04_3.Pharmacy.Merged.Issues>();
            this.subjectOf2AnnotationIndicator = new BLImpl(false);
            this.confidentialityCode = new CVImpl();
        }
        /**
         * <summary>PrescriptionDispenseNumber</summary>
         * 
         * <remarks>A:Prescription Dispense Number <p>The Prescription 
         * Dispense Number is a globally unique number assigned to a 
         * dispense (single fill) by the EHR/DIS irrespective of the 
         * source of the dispense.</p><p>It is created by the EHR/DIS 
         * once the dispense has passed all edits and validation.</p> 
         * <p>The Prescription Dispense Number is a globally unique 
         * number assigned to a dispense (single fill) by the EHR/DIS 
         * irrespective of the source of the dispense.</p><p>It is 
         * created by the EHR/DIS once the dispense has passed all 
         * edits and validation.</p> 
         * <p>DispensedItem.dispensedItemKey</p><p>DispensedItem.externalKey</p><p>D53(ID 
         * for the prescription assigned by pharmacy)</p><p>D55(ID for 
         * the dispense 
         * event)</p><p>D99.01</p><p>ZDP.5</p><p>ZDP.6</p><p>ZDP.22</p><p>ZRV.5</p><p>DRU.080-01(extension)</p><p>DRU.080-02(route)</p><p>Claim.455-EM 
         * (route)</p><p>Claim.402-D2 
         * (extension)</p><p>Claim.456-EN</p><p>Claim.454-EK</p><p>A_BillablePharmacyDispense</p> 
         * <p>DispensedItem.dispensedItemKey</p><p>DispensedItem.externalKey</p><p>D53(ID 
         * for the prescription assigned by pharmacy)</p><p>D55(ID for 
         * the dispense 
         * event)</p><p>D99.01</p><p>ZDP.5</p><p>ZDP.6</p><p>ZDP.22</p><p>ZRV.5</p><p>DRU.080-01(extension)</p><p>DRU.080-02(route)</p><p>Claim.455-EM 
         * (route)</p><p>Claim.402-D2 
         * (extension)</p><p>Claim.456-EN</p><p>Claim.454-EK</p><p>A_BillablePharmacyDispense</p> 
         * <p>DispensedItem.dispensedItemKey</p><p>DispensedItem.externalKey</p><p>D53(ID 
         * for the prescription assigned by pharmacy)</p><p>D55(ID for 
         * the dispense 
         * event)</p><p>D99.01</p><p>ZDP.5</p><p>ZDP.6</p><p>ZDP.22</p><p>ZRV.5</p><p>DRU.080-01(extension)</p><p>DRU.080-02(route)</p><p>Claim.455-EM 
         * (route)</p><p>Claim.402-D2 
         * (extension)</p><p>Claim.456-EN</p><p>Claim.454-EK</p><p>A_BillablePharmacyDispense</p> 
         * <p>DispensedItem.dispensedItemKey</p><p>DispensedItem.externalKey</p><p>D53(ID 
         * for the prescription assigned by pharmacy)</p><p>D55(ID for 
         * the dispense 
         * event)</p><p>D99.01</p><p>ZDP.5</p><p>ZDP.6</p><p>ZDP.22</p><p>ZRV.5</p><p>DRU.080-01(extension)</p><p>DRU.080-02(route)</p><p>Claim.455-EM 
         * (route)</p><p>Claim.402-D2 
         * (extension)</p><p>Claim.456-EN</p><p>Claim.454-EK</p><p>A_BillablePharmacyDispense</p> 
         * <p>DispensedItem.dispensedItemKey</p><p>DispensedItem.externalKey</p><p>D53(ID 
         * for the prescription assigned by pharmacy)</p><p>D55(ID for 
         * the dispense 
         * event)</p><p>D99.01</p><p>ZDP.5</p><p>ZDP.6</p><p>ZDP.22</p><p>ZRV.5</p><p>DRU.080-01(extension)</p><p>DRU.080-02(route)</p><p>Claim.455-EM 
         * (route)</p><p>Claim.402-D2 
         * (extension)</p><p>Claim.456-EN</p><p>Claim.454-EK</p><p>A_BillablePharmacyDispense</p> 
         * <p>DispensedItem.dispensedItemKey</p><p>DispensedItem.externalKey</p><p>D53(ID 
         * for the prescription assigned by pharmacy)</p><p>D55(ID for 
         * the dispense 
         * event)</p><p>D99.01</p><p>ZDP.5</p><p>ZDP.6</p><p>ZDP.22</p><p>ZRV.5</p><p>DRU.080-01(extension)</p><p>DRU.080-02(route)</p><p>Claim.455-EM 
         * (route)</p><p>Claim.402-D2 
         * (extension)</p><p>Claim.456-EN</p><p>Claim.454-EK</p><p>A_BillablePharmacyDispense</p> 
         * <p>DispensedItem.dispensedItemKey</p><p>DispensedItem.externalKey</p><p>D53(ID 
         * for the prescription assigned by pharmacy)</p><p>D55(ID for 
         * the dispense 
         * event)</p><p>D99.01</p><p>ZDP.5</p><p>ZDP.6</p><p>ZDP.22</p><p>ZRV.5</p><p>DRU.080-01(extension)</p><p>DRU.080-02(route)</p><p>Claim.455-EM 
         * (route)</p><p>Claim.402-D2 
         * (extension)</p><p>Claim.456-EN</p><p>Claim.454-EK</p><p>A_BillablePharmacyDispense</p> 
         * <p>DispensedItem.dispensedItemKey</p><p>DispensedItem.externalKey</p><p>D53(ID 
         * for the prescription assigned by pharmacy)</p><p>D55(ID for 
         * the dispense 
         * event)</p><p>D99.01</p><p>ZDP.5</p><p>ZDP.6</p><p>ZDP.22</p><p>ZRV.5</p><p>DRU.080-01(extension)</p><p>DRU.080-02(route)</p><p>Claim.455-EM 
         * (route)</p><p>Claim.402-D2 
         * (extension)</p><p>Claim.456-EN</p><p>Claim.454-EK</p><p>A_BillablePharmacyDispense</p> 
         * <p>DispensedItem.dispensedItemKey</p><p>DispensedItem.externalKey</p><p>D53(ID 
         * for the prescription assigned by pharmacy)</p><p>D55(ID for 
         * the dispense 
         * event)</p><p>D99.01</p><p>ZDP.5</p><p>ZDP.6</p><p>ZDP.22</p><p>ZRV.5</p><p>DRU.080-01(extension)</p><p>DRU.080-02(route)</p><p>Claim.455-EM 
         * (route)</p><p>Claim.402-D2 
         * (extension)</p><p>Claim.456-EN</p><p>Claim.454-EK</p><p>A_BillablePharmacyDispense</p> 
         * <p>DispensedItem.dispensedItemKey</p><p>DispensedItem.externalKey</p><p>D53(ID 
         * for the prescription assigned by pharmacy)</p><p>D55(ID for 
         * the dispense 
         * event)</p><p>D99.01</p><p>ZDP.5</p><p>ZDP.6</p><p>ZDP.22</p><p>ZRV.5</p><p>DRU.080-01(extension)</p><p>DRU.080-02(route)</p><p>Claim.455-EM 
         * (route)</p><p>Claim.402-D2 
         * (extension)</p><p>Claim.456-EN</p><p>Claim.454-EK</p><p>A_BillablePharmacyDispense</p> 
         * <p>DispensedItem.dispensedItemKey</p><p>DispensedItem.externalKey</p><p>D53(ID 
         * for the prescription assigned by pharmacy)</p><p>D55(ID for 
         * the dispense 
         * event)</p><p>D99.01</p><p>ZDP.5</p><p>ZDP.6</p><p>ZDP.22</p><p>ZRV.5</p><p>DRU.080-01(extension)</p><p>DRU.080-02(route)</p><p>Claim.455-EM 
         * (route)</p><p>Claim.402-D2 
         * (extension)</p><p>Claim.456-EN</p><p>Claim.454-EK</p><p>A_BillablePharmacyDispense</p> 
         * <p>DispensedItem.dispensedItemKey</p><p>DispensedItem.externalKey</p><p>D53(ID 
         * for the prescription assigned by pharmacy)</p><p>D55(ID for 
         * the dispense 
         * event)</p><p>D99.01</p><p>ZDP.5</p><p>ZDP.6</p><p>ZDP.22</p><p>ZRV.5</p><p>DRU.080-01(extension)</p><p>DRU.080-02(route)</p><p>Claim.455-EM 
         * (route)</p><p>Claim.402-D2 
         * (extension)</p><p>Claim.456-EN</p><p>Claim.454-EK</p><p>A_BillablePharmacyDispense</p> 
         * <p>DispensedItem.dispensedItemKey</p><p>DispensedItem.externalKey</p><p>D53(ID 
         * for the prescription assigned by pharmacy)</p><p>D55(ID for 
         * the dispense 
         * event)</p><p>D99.01</p><p>ZDP.5</p><p>ZDP.6</p><p>ZDP.22</p><p>ZRV.5</p><p>DRU.080-01(extension)</p><p>DRU.080-02(route)</p><p>Claim.455-EM 
         * (route)</p><p>Claim.402-D2 
         * (extension)</p><p>Claim.456-EN</p><p>Claim.454-EK</p><p>A_BillablePharmacyDispense</p> 
         * <p>DispensedItem.dispensedItemKey</p><p>DispensedItem.externalKey</p><p>D53(ID 
         * for the prescription assigned by pharmacy)</p><p>D55(ID for 
         * the dispense 
         * event)</p><p>D99.01</p><p>ZDP.5</p><p>ZDP.6</p><p>ZDP.22</p><p>ZRV.5</p><p>DRU.080-01(extension)</p><p>DRU.080-02(route)</p><p>Claim.455-EM 
         * (route)</p><p>Claim.402-D2 
         * (extension)</p><p>Claim.456-EN</p><p>Claim.454-EK</p><p>A_BillablePharmacyDispense</p> 
         * <p>DispensedItem.dispensedItemKey</p><p>DispensedItem.externalKey</p><p>D53(ID 
         * for the prescription assigned by pharmacy)</p><p>D55(ID for 
         * the dispense 
         * event)</p><p>D99.01</p><p>ZDP.5</p><p>ZDP.6</p><p>ZDP.22</p><p>ZRV.5</p><p>DRU.080-01(extension)</p><p>DRU.080-02(route)</p><p>Claim.455-EM 
         * (route)</p><p>Claim.402-D2 
         * (extension)</p><p>Claim.456-EN</p><p>Claim.454-EK</p><p>A_BillablePharmacyDispense</p> 
         * <p>DispensedItem.dispensedItemKey</p><p>DispensedItem.externalKey</p><p>D53(ID 
         * for the prescription assigned by pharmacy)</p><p>D55(ID for 
         * the dispense 
         * event)</p><p>D99.01</p><p>ZDP.5</p><p>ZDP.6</p><p>ZDP.22</p><p>ZRV.5</p><p>DRU.080-01(extension)</p><p>DRU.080-02(route)</p><p>Claim.455-EM 
         * (route)</p><p>Claim.402-D2 
         * (extension)</p><p>Claim.456-EN</p><p>Claim.454-EK</p><p>A_BillablePharmacyDispense</p> 
         * <p>Allows for the referencing of a specific dispense 
         * record.</p><p>Identifier for a dispensed record is needed so 
         * that dispenses may be uniquely referenced. Thus the 
         * mandatory requirement.</p> <p>Allows for the referencing of 
         * a specific dispense record.</p><p>Identifier for a dispensed 
         * record is needed so that dispenses may be uniquely 
         * referenced. Thus the mandatory requirement.</p> 
         * A:Prescription Dispense Number <p>The Prescription Dispense 
         * Number is a globally unique number assigned to a dispense 
         * (single fill) by the EHR/DIS irrespective of the source of 
         * the dispense.</p><p>It is created by the EHR/DIS once the 
         * dispense has passed all edits and validation.</p> <p>The 
         * Prescription Dispense Number is a globally unique number 
         * assigned to a dispense (single fill) by the EHR/DIS 
         * irrespective of the source of the dispense.</p><p>It is 
         * created by the EHR/DIS once the dispense has passed all 
         * edits and validation.</p> <p>Allows for the referencing of a 
         * specific dispense record.</p><p>Identifier for a dispensed 
         * record is needed so that dispenses may be uniquely 
         * referenced. Thus the mandatory requirement.</p> <p>Allows 
         * for the referencing of a specific dispense 
         * record.</p><p>Identifier for a dispense
         * ... [rest of documentation truncated due to excessive length]
         */
        [Hl7XmlMappingAttribute(new string[] {"id"})]
        public Identifier Id {
            get { return this.id.Value; }
            set { this.id.Value = value; }
        }

        /**
         * <summary>DispenseStatus</summary>
         * 
         * <remarks>C:Dispense Status <p>Indicates the status of the 
         * dispense record created on the EHR/DIS. If Active it means 
         * that the dispense has been processed but not yet given to 
         * the patient. If Complete, it indicates that the medication 
         * has been delivered to the patient.</p> <p>Important in 
         * understanding what medication the patient actually has on 
         * hand, thus the attribute is mandatory. May also influence 
         * the ability of a different pharmacy to dispense the 
         * medication.</p> Dispense Status <p>Indicates the status of 
         * the dispense record created on the EHR/DIS. If 'Active' it 
         * means that the dispense has been processed but not yet given 
         * to the patient. If 'Complete', it indicates that the 
         * medication has been delivered to the patient.</p> 
         * <p>Important in understanding what medication the patient 
         * actually has on hand, thus the attribute is mandatory. May 
         * also influence the ability of a different pharmacy to 
         * dispense the medication.</p> C:Dispense Status <p>Indicates 
         * the status of the dispense record created on the EHR/DIS. If 
         * 'Active' it means that the dispense has been processed but 
         * not yet given to the patient. If 'Complete', it indicates 
         * that the medication has been delivered to the patient.</p> 
         * <p>Important in understanding what medication the patient 
         * actually has on hand, thus the attribute is mandatory. May 
         * also influence the ability of a different pharmacy to 
         * dispense the medication.</p></remarks>
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

        [Hl7XmlMappingAttribute(new string[] {"component1/dosageInstruction","component2/dosageInstruction"})]
        [Hl7MapByPartType(Name="component1", Type="PORX_MT060090CA.Component11")]
        [Hl7MapByPartType(Name="component1", Type="PORX_MT060340CA.Component11")]
        [Hl7MapByPartType(Name="component1/dosageInstruction", Type="PORX_MT980040CA.DosageInstruction")]
        [Hl7MapByPartType(Name="component2", Type="PORX_MT060160CA.Component11")]
        [Hl7MapByPartType(Name="component2/dosageInstruction", Type="PORX_MT980040CA.DosageInstruction")]
        public IList<Ca.Infoway.Messagebuilder.Model.Sk_cerx_v01_r04_3.Pharmacy.Porx_mt980040ca.AdministrationInstructions> Component2DosageInstruction {
            get { return this.component2DosageInstruction; }
        }

        /**
         * <summary>(no business name)</summary>
         * 
         * <remarks><p>any.&nbsp;</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"component2/substitutionMade","component3/substitutionMade"})]
        [Hl7MapByPartType(Name="component2", Type="PORX_MT060090CA.Component13")]
        [Hl7MapByPartType(Name="component2", Type="PORX_MT060340CA.Component13")]
        [Hl7MapByPartType(Name="component2/substitutionMade", Type="PORX_MT060090CA.SubstitutionMade")]
        [Hl7MapByPartType(Name="component2/substitutionMade", Type="PORX_MT060340CA.SubstitutionMade")]
        [Hl7MapByPartType(Name="component3", Type="PORX_MT060160CA.Component13")]
        [Hl7MapByPartType(Name="component3/substitutionMade", Type="PORX_MT060160CA.SubstitutionMade")]
        public Ca.Infoway.Messagebuilder.Model.Sk_cerx_v01_r04_3.Pharmacy.Merged.Substitution Component3SubstitutionMade {
            get { return this.component3SubstitutionMade; }
            set { this.component3SubstitutionMade = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"component1/supplyEvent","component3/supplyEvent"})]
        [Hl7MapByPartType(Name="component1", Type="PORX_MT060160CA.Component")]
        [Hl7MapByPartType(Name="component1/supplyEvent", Type="PORX_MT060160CA.SupplyEvent")]
        [Hl7MapByPartType(Name="component3", Type="PORX_MT060090CA.Component")]
        [Hl7MapByPartType(Name="component3", Type="PORX_MT060340CA.Component")]
        [Hl7MapByPartType(Name="component3/supplyEvent", Type="PORX_MT060090CA.SupplyEvent")]
        [Hl7MapByPartType(Name="component3/supplyEvent", Type="PORX_MT060340CA.SupplyEvent")]
        public Ca.Infoway.Messagebuilder.Model.Sk_cerx_v01_r04_3.Pharmacy.Merged.SupplyEvent_1 Component1SupplyEvent {
            get { return this.component1SupplyEvent; }
            set { this.component1SupplyEvent = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"subjectOf1/controlActEvent"})]
        public IList<Ca.Infoway.Messagebuilder.Model.Sk_cerx_v01_r04_3.Pharmacy.Merged.StatusChanges> SubjectOf1ControlActEvent {
            get { return this.subjectOf1ControlActEvent; }
        }

        [Hl7XmlMappingAttribute(new string[] {"subjectOf2/annotation","subjectOf3/annotation","subjectOf4/annotation"})]
        [Hl7MapByPartType(Name="subjectOf2", Type="PORX_MT060340CA.Subject7")]
        [Hl7MapByPartType(Name="subjectOf2/annotation", Type="COCT_MT120600CA.Annotation")]
        [Hl7MapByPartType(Name="subjectOf3", Type="PORX_MT060090CA.Subject7")]
        [Hl7MapByPartType(Name="subjectOf3/annotation", Type="COCT_MT120600CA.Annotation")]
        [Hl7MapByPartType(Name="subjectOf4", Type="PORX_MT060160CA.Subject7")]
        [Hl7MapByPartType(Name="subjectOf4/annotation", Type="COCT_MT120600CA.Annotation")]
        public IList<Ca.Infoway.Messagebuilder.Model.Sk_cerx_v01_r04_3.Merged.Comment> SubjectOf4Annotation {
            get { return this.subjectOf4Annotation; }
        }

        /**
         * <summary>(no business name)</summary>
         * 
         * <remarks><p>issues.&nbsp;</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"subjectOf3/detectedIssueIndicator","subjectOf4/detectedIssueIndicator"})]
        [Hl7MapByPartType(Name="subjectOf3", Type="PORX_MT060160CA.Subject13")]
        [Hl7MapByPartType(Name="subjectOf3", Type="PORX_MT060340CA.Subject13")]
        [Hl7MapByPartType(Name="subjectOf3/detectedIssueIndicator", Type="PORX_MT060160CA.DetectedIssueIndicator")]
        [Hl7MapByPartType(Name="subjectOf3/detectedIssueIndicator", Type="PORX_MT060340CA.DetectedIssueIndicator")]
        [Hl7MapByPartType(Name="subjectOf4", Type="PORX_MT060090CA.Subject13")]
        [Hl7MapByPartType(Name="subjectOf4/detectedIssueIndicator", Type="PORX_MT060090CA.DetectedIssueIndicator")]
        public bool? SubjectOf3DetectedIssueIndicator {
            get { return this.subjectOf3DetectedIssueIndicator.Value; }
            set { this.subjectOf3DetectedIssueIndicator.Value = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"subjectOf2/detectedIssueEvent","subjectOf4/detectedIssueEvent","subjectOf5/detectedIssueEvent"})]
        [Hl7MapByPartType(Name="subjectOf2", Type="PORX_MT060090CA.Subject6")]
        [Hl7MapByPartType(Name="subjectOf2/detectedIssueEvent", Type="PORX_MT980030CA.DetectedIssueEvent")]
        [Hl7MapByPartType(Name="subjectOf4", Type="PORX_MT060340CA.Subject6")]
        [Hl7MapByPartType(Name="subjectOf4/detectedIssueEvent", Type="PORX_MT980030CA.DetectedIssueEvent")]
        [Hl7MapByPartType(Name="subjectOf5", Type="PORX_MT060160CA.Subject6")]
        [Hl7MapByPartType(Name="subjectOf5/detectedIssueEvent", Type="PORX_MT980030CA.DetectedIssueEvent")]
        public IList<Ca.Infoway.Messagebuilder.Model.Sk_cerx_v01_r04_3.Pharmacy.Merged.Issues> SubjectOf5DetectedIssueEvent {
            get { return this.subjectOf5DetectedIssueEvent; }
        }

        /**
         * <summary>(no business name)</summary>
         * 
         * <remarks><p>notes were not to be included and there are 
         * notes.&nbsp;</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"subjectOf2/annotationIndicator","subjectOf5/annotationIndicator"})]
        [Hl7MapByPartType(Name="subjectOf2", Type="PORX_MT060160CA.Subject12")]
        [Hl7MapByPartType(Name="subjectOf2/annotationIndicator", Type="PORX_MT060160CA.AnnotationIndicator")]
        [Hl7MapByPartType(Name="subjectOf5", Type="PORX_MT060090CA.Subject12")]
        [Hl7MapByPartType(Name="subjectOf5", Type="PORX_MT060340CA.Subject12")]
        [Hl7MapByPartType(Name="subjectOf5/annotationIndicator", Type="PORX_MT060090CA.AnnotationIndicator")]
        [Hl7MapByPartType(Name="subjectOf5/annotationIndicator", Type="PORX_MT060340CA.AnnotationIndicator")]
        public bool? SubjectOf2AnnotationIndicator {
            get { return this.subjectOf2AnnotationIndicator.Value; }
            set { this.subjectOf2AnnotationIndicator.Value = value; }
        }

        /**
         * <summary>PrescriptionMaskingIndicator</summary>
         * 
         * <remarks>E:Prescription Masking Indicator</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"confidentialityCode"})]
        public x_VeryBasicConfidentialityKind ConfidentialityCode {
            get { return (x_VeryBasicConfidentialityKind) this.confidentialityCode.Value; }
            set { this.confidentialityCode.Value = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"inFulfillmentOf/substanceAdministrationRequest"})]
        public Ca.Infoway.Messagebuilder.Model.Sk_cerx_v01_r04_3.Pharmacy.Merged.PrescriptionReference InFulfillmentOfSubstanceAdministrationRequest {
            get { return this.inFulfillmentOfSubstanceAdministrationRequest; }
            set { this.inFulfillmentOfSubstanceAdministrationRequest = value; }
        }

    }

}