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
namespace Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Lab.Polb_mt001999ca {
    using Ca.Infoway.Messagebuilder;
    using Ca.Infoway.Messagebuilder.Annotation;
    using Ca.Infoway.Messagebuilder.Datatype;
    using Ca.Infoway.Messagebuilder.Datatype.Impl;
    using Ca.Infoway.Messagebuilder.Datatype.Lang;
    using Ca.Infoway.Messagebuilder.Domainvalue;
    using Ca.Infoway.Messagebuilder.Model;
    using Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Common.Coct_mt090102ca;
    using Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Common.Coct_mt090508ca;
    using Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Common.Coct_mt130001ca;
    using Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Common.Merged;
    using Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Lab.Merged;
    using Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Merged;
    using System.Collections.Generic;


    /**
     * <summary>Placer Group</summary>
     * 
     * <remarks><p>Group(er) of tests requested to be 
     * performed.</p></remarks>
     */
    [Hl7PartTypeMappingAttribute(new string[] {"POLB_MT001999CA.PlacerGroup"})]
    public class PlacerGroup : MessagePartBean, Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Lab.Polb_mt001999ca.IRequestChoice {

        private IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Merged.SpecimenRole> specimenSpecimen;
        private Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Common.Merged.Patient_1 recordTargetPatient;
        private SET<II, Identifier> id;
        private Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Common.Coct_mt090508ca.HealthcareOrganization performerAssignedEntity;
        private IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Common.Merged.HealthcareWorker> callBackContactAssignedEntity;
        private SET<CV, Code> confidentialityCode;
        private IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Lab.Merged.IRecipientChoice> informationRecipientRecipientChoice;
        private IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Common.Coct_mt090102ca.HealthcareWorker> verifierAssignedEntity;
        private Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Lab.Merged.ParentTest occurrenceOfActParentPointer;
        private Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Lab.Merged.Outbreak pertinentInformation1OutbreakEvent;
        private IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Lab.Merged.SupportingClinicalInformation> pertinentInformation2SupportingClinicalObservationEvent;
        private Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Lab.Merged.ReferralRedirectIndicator component1ReferralRedirectIndicator;
        private Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Lab.Merged.OrderSortKey component2RequestSortKey;
        private Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Lab.Merged.LabInitiatedOrderIndicator component3LabInitiatedOrderIndicator;
        private IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Lab.Polb_mt001999ca.IRequestChoice> component4RequestChoice;
        private IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Lab.Polb_mt001999ca.IResultChoice> fulfillmentResultChoice1;
        private IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Merged.Includes> subjectOf1;
        private Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Common.Coct_mt130001ca.VersionInformation subjectOf2ControlActEvent;
        private Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Lab.Merged.PriorTestRequest componentOfPriorActRequest;

        public PlacerGroup() {
            this.specimenSpecimen = new List<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Merged.SpecimenRole>();
            this.id = new SETImpl<II, Identifier>(typeof(IIImpl));
            this.callBackContactAssignedEntity = new List<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Common.Merged.HealthcareWorker>();
            this.confidentialityCode = new SETImpl<CV, Code>(typeof(CVImpl));
            this.informationRecipientRecipientChoice = new List<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Lab.Merged.IRecipientChoice>();
            this.verifierAssignedEntity = new List<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Common.Coct_mt090102ca.HealthcareWorker>();
            this.pertinentInformation2SupportingClinicalObservationEvent = new List<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Lab.Merged.SupportingClinicalInformation>();
            this.component4RequestChoice = new List<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Lab.Polb_mt001999ca.IRequestChoice>();
            this.fulfillmentResultChoice1 = new List<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Lab.Polb_mt001999ca.IResultChoice>();
            this.subjectOf1 = new List<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Merged.Includes>();
        }
        [Hl7XmlMappingAttribute(new string[] {"specimen/specimen"})]
        public IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Merged.SpecimenRole> SpecimenSpecimen {
            get { return this.specimenSpecimen; }
        }

        [Hl7XmlMappingAttribute(new string[] {"recordTarget/patient"})]
        public Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Common.Merged.Patient_1 RecordTargetPatient {
            get { return this.recordTargetPatient; }
            set { this.recordTargetPatient = value; }
        }

        /**
         * <summary>A:Placer Group Identifier</summary>
         * 
         * <remarks><p>Order (requisition) number of placer 
         * (requestor). If electronic order entry is not supported, 
         * then the sending organization must enter an Placer Order 
         * Identifier.</p><p>A unique number assigned to all tests in a 
         * requisition.</p> <p>Order (requisition) number of placer 
         * (requestor). If electronic order entry is not supported, 
         * then the sending organization must enter an Placer Order 
         * Identifier.</p><p>A unique number assigned to all tests in a 
         * requisition.</p> <p>This field allows an order placing 
         * application to group sets of requisitions together and 
         * subsequently identify them. Mandatory for create, revise, 
         * cancel, and nullify actions.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"id"})]
        public ICollection<Identifier> Id {
            get { return this.id.RawSet(); }
        }

        [Hl7XmlMappingAttribute(new string[] {"performer/assignedEntity"})]
        public Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Common.Coct_mt090508ca.HealthcareOrganization PerformerAssignedEntity {
            get { return this.performerAssignedEntity; }
            set { this.performerAssignedEntity = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"callBackContact/assignedEntity"})]
        public IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Common.Merged.HealthcareWorker> CallBackContactAssignedEntity {
            get { return this.callBackContactAssignedEntity; }
        }

        /**
         * <summary>B:Placer Group Masking Indicator</summary>
         * 
         * <remarks><p>Any piece of information is potentially subject 
         * to 'masking', restricting it's availability from providers 
         * who have not been specifically authorized. Additionally, 
         * some clinical data requires the ability to mark as &quot;not 
         * for direct disclosure to patient&quot;. The values in this 
         * attribute enable the above masking to be represented and 
         * messaged.</p> <p>This code allows for privacy control by 
         * patients as well as flagged for 'not for disclosure to 
         * patient' by care providers.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"confidentialityCode"})]
        public ICollection<x_BasicConfidentialityKind> ConfidentialityCode {
            get { return this.confidentialityCode.RawSet<x_BasicConfidentialityKind>(); }
        }

        [Hl7XmlMappingAttribute(new string[] {"informationRecipient/recipientChoice"})]
        public IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Lab.Merged.IRecipientChoice> InformationRecipientRecipientChoice {
            get { return this.informationRecipientRecipientChoice; }
        }

        [Hl7XmlMappingAttribute(new string[] {"verifier/assignedEntity"})]
        public IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Common.Coct_mt090102ca.HealthcareWorker> VerifierAssignedEntity {
            get { return this.verifierAssignedEntity; }
        }

        [Hl7XmlMappingAttribute(new string[] {"occurrenceOf/actParentPointer"})]
        public Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Lab.Merged.ParentTest OccurrenceOfActParentPointer {
            get { return this.occurrenceOfActParentPointer; }
            set { this.occurrenceOfActParentPointer = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"pertinentInformation1/outbreakEvent"})]
        public Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Lab.Merged.Outbreak PertinentInformation1OutbreakEvent {
            get { return this.pertinentInformation1OutbreakEvent; }
            set { this.pertinentInformation1OutbreakEvent = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"pertinentInformation2/supportingClinicalObservationEvent"})]
        public IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Lab.Merged.SupportingClinicalInformation> PertinentInformation2SupportingClinicalObservationEvent {
            get { return this.pertinentInformation2SupportingClinicalObservationEvent; }
        }

        [Hl7XmlMappingAttribute(new string[] {"component1/referralRedirectIndicator"})]
        public Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Lab.Merged.ReferralRedirectIndicator Component1ReferralRedirectIndicator {
            get { return this.component1ReferralRedirectIndicator; }
            set { this.component1ReferralRedirectIndicator = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"component2/requestSortKey"})]
        public Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Lab.Merged.OrderSortKey Component2RequestSortKey {
            get { return this.component2RequestSortKey; }
            set { this.component2RequestSortKey = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"component3/labInitiatedOrderIndicator"})]
        public Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Lab.Merged.LabInitiatedOrderIndicator Component3LabInitiatedOrderIndicator {
            get { return this.component3LabInitiatedOrderIndicator; }
            set { this.component3LabInitiatedOrderIndicator = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"component4/requestChoice"})]
        public IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Lab.Polb_mt001999ca.IRequestChoice> Component4RequestChoice {
            get { return this.component4RequestChoice; }
        }

        [Hl7XmlMappingAttribute(new string[] {"fulfillment/resultChoice1"})]
        public IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Lab.Polb_mt001999ca.IResultChoice> FulfillmentResultChoice1 {
            get { return this.fulfillmentResultChoice1; }
        }

        [Hl7XmlMappingAttribute(new string[] {"subjectOf1"})]
        public IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Merged.Includes> SubjectOf1 {
            get { return this.subjectOf1; }
        }

        [Hl7XmlMappingAttribute(new string[] {"subjectOf2/controlActEvent"})]
        public Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Common.Coct_mt130001ca.VersionInformation SubjectOf2ControlActEvent {
            get { return this.subjectOf2ControlActEvent; }
            set { this.subjectOf2ControlActEvent = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"componentOf/priorActRequest"})]
        public Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Lab.Merged.PriorTestRequest ComponentOfPriorActRequest {
            get { return this.componentOfPriorActRequest; }
            set { this.componentOfPriorActRequest = value; }
        }

    }

}