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
 * Last modified: $LastChangedDate: 2012-01-18 21:08:49 -0500 (Wed, 18 Jan 2012) $
 * Revision:      $LastChangedRevision: 3978 $
 */

/* This class was auto-generated by the message builder generator tools. */
namespace Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Lab.Polb_mt001001ca {
    using Ca.Infoway.Messagebuilder;
    using Ca.Infoway.Messagebuilder.Annotation;
    using Ca.Infoway.Messagebuilder.Datatype;
    using Ca.Infoway.Messagebuilder.Datatype.Impl;
    using Ca.Infoway.Messagebuilder.Datatype.Lang;
    using Ca.Infoway.Messagebuilder.Domainvalue;
    using Ca.Infoway.Messagebuilder.Model;
    using Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Common.Coct_mt130001ca;
    using Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Common.Merged;
    using Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Lab.Merged;
    using Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Merged;
    using System.Collections.Generic;


    /**
     * <summary>Placer Group</summary>
     * 
     * <remarks><p>Group(er) of tests requested to be 
     * performed.</p></remarks>
     */
    [Hl7PartTypeMappingAttribute(new string[] {"POLB_MT001001CA.PlacerGroup"})]
    public class PlacerGroup : MessagePartBean, Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Lab.Polb_mt001001ca.IRequestChoice {

        private IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Lab.Merged.IRecipientChoice> informationRecipientRecipientChoice;
        private IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Common.Merged.HealthcareWorker> verifierAssignedEntity;
        private II placerGroupIdentifier;
        private Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Lab.Merged.ParentTest occurrenceOfActParentPointer;
        private SET<CV, Code> placerGroupMaskingIndicator;
        private IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Lab.Merged.SupportingClinicalInformation> pertinentInformationSupportingClinicalObservationEvent;
        private Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Lab.Merged.LabInitiatedOrderIndicator component1LabInitiatedOrderIndicator;
        private Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Lab.Merged.ReferralRedirectIndicator component2ReferralRedirectIndicator;
        private Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Lab.Merged.OrderSortKey component3RequestSortKey;
        private IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Lab.Polb_mt001001ca.IRequestChoice> component4RequestChoice;
        private IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Merged.Includes> subjectOf1;
        private Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Common.Coct_mt130001ca.VersionInformation subjectOf2ControlActEvent;
        private Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Lab.Merged.PriorTestRequest componentOf1PriorActRequest;
        private IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Merged.CareCompositions> componentOf2PatientCareProvisionEvent;

        public PlacerGroup() {
            this.informationRecipientRecipientChoice = new List<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Lab.Merged.IRecipientChoice>();
            this.verifierAssignedEntity = new List<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Common.Merged.HealthcareWorker>();
            this.placerGroupIdentifier = new IIImpl();
            this.placerGroupMaskingIndicator = new SETImpl<CV, Code>(typeof(CVImpl));
            this.pertinentInformationSupportingClinicalObservationEvent = new List<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Lab.Merged.SupportingClinicalInformation>();
            this.component4RequestChoice = new List<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Lab.Polb_mt001001ca.IRequestChoice>();
            this.subjectOf1 = new List<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Merged.Includes>();
            this.componentOf2PatientCareProvisionEvent = new List<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Merged.CareCompositions>();
        }
        [Hl7XmlMappingAttribute(new string[] {"informationRecipient/recipientChoice"})]
        public IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Lab.Merged.IRecipientChoice> InformationRecipientRecipientChoice {
            get { return this.informationRecipientRecipientChoice; }
        }

        [Hl7XmlMappingAttribute(new string[] {"verifier/assignedEntity"})]
        public IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Common.Merged.HealthcareWorker> VerifierAssignedEntity {
            get { return this.verifierAssignedEntity; }
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
        public Identifier PlacerGroupIdentifier {
            get { return this.placerGroupIdentifier.Value; }
            set { this.placerGroupIdentifier.Value = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"occurrenceOf/actParentPointer"})]
        public Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Lab.Merged.ParentTest OccurrenceOfActParentPointer {
            get { return this.occurrenceOfActParentPointer; }
            set { this.occurrenceOfActParentPointer = value; }
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
        public ICollection<x_BasicConfidentialityKind> PlacerGroupMaskingIndicator {
            get { return this.placerGroupMaskingIndicator.RawSet<x_BasicConfidentialityKind>(); }
        }

        [Hl7XmlMappingAttribute(new string[] {"pertinentInformation/supportingClinicalObservationEvent"})]
        public IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Lab.Merged.SupportingClinicalInformation> PertinentInformationSupportingClinicalObservationEvent {
            get { return this.pertinentInformationSupportingClinicalObservationEvent; }
        }

        [Hl7XmlMappingAttribute(new string[] {"component1/labInitiatedOrderIndicator"})]
        public Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Lab.Merged.LabInitiatedOrderIndicator Component1LabInitiatedOrderIndicator {
            get { return this.component1LabInitiatedOrderIndicator; }
            set { this.component1LabInitiatedOrderIndicator = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"component2/referralRedirectIndicator"})]
        public Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Lab.Merged.ReferralRedirectIndicator Component2ReferralRedirectIndicator {
            get { return this.component2ReferralRedirectIndicator; }
            set { this.component2ReferralRedirectIndicator = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"component3/requestSortKey"})]
        public Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Lab.Merged.OrderSortKey Component3RequestSortKey {
            get { return this.component3RequestSortKey; }
            set { this.component3RequestSortKey = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"component4/requestChoice"})]
        public IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Lab.Polb_mt001001ca.IRequestChoice> Component4RequestChoice {
            get { return this.component4RequestChoice; }
        }

        [Hl7XmlMappingAttribute(new string[] {"subjectOf1"})]
        public IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Merged.Includes> SubjectOf1 {
            get { return this.subjectOf1; }
        }

        [Hl7XmlMappingAttribute(new string[] {"subjectOf2/controlActEvent"})]
        public Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Common.Coct_mt130001ca.VersionInformation SubjectOf2ControlActEvent {
            get { return this.subjectOf2ControlActEvent; }
            set { this.subjectOf2ControlActEvent = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"componentOf1/priorActRequest"})]
        public Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Lab.Merged.PriorTestRequest ComponentOf1PriorActRequest {
            get { return this.componentOf1PriorActRequest; }
            set { this.componentOf1PriorActRequest = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"componentOf2/patientCareProvisionEvent"})]
        public IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Merged.CareCompositions> ComponentOf2PatientCareProvisionEvent {
            get { return this.componentOf2PatientCareProvisionEvent; }
        }

    }

}