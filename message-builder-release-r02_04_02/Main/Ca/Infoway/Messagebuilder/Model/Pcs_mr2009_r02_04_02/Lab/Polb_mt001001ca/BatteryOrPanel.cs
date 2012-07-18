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
     * <summary>Battery or Panel</summary>
     * 
     * <remarks><p>Used as a functional grouper of tests. Usually a 
     * &quot;panel&quot; or &quot;battery&quot; of tests are 
     * diagnostically related and frequently conducted and reported 
     * together.</p></remarks>
     */
    [Hl7PartTypeMappingAttribute(new string[] {"POLB_MT001001CA.BatteryRequest"})]
    public class BatteryOrPanel : MessagePartBean, Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Lab.Polb_mt001001ca.IRequestChoice {

        private IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Lab.Merged.IRecipientChoice> informationRecipientRecipientChoice;
        private IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Common.Merged.HealthcareWorker> verifierAssignedEntity;
        private II batteryIdentifier;
        private Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Lab.Merged.ParentTest occurrenceOfActParentPointer;
        private CD batteryType;
        private IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Lab.Merged.SupportingClinicalInformation> pertinentInformationSupportingClinicalObservationEvent;
        private Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Lab.Merged.LabInitiatedOrderIndicator component1LabInitiatedOrderIndicator;
        private CS batteryStatus;
        private Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Lab.Merged.ReferralRedirectIndicator component2ReferralRedirectIndicator;
        private LIST<GTS, GeneralTimingSpecification> batteryRequestTimeSpecification;
        private Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Lab.Merged.OrderSortKey component3RequestSortKey;
        private CV batteryPriorityCode;
        private IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Lab.Polb_mt001001ca.IRequestChoice> component4RequestChoice;
        private SET<CV, Code> batteryMaskingIndicator;
        private IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Merged.Includes> subjectOf1;
        private Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Common.Coct_mt130001ca.VersionInformation subjectOf2ControlActEvent;
        private Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Lab.Merged.PriorTestRequest componentOf1PriorActRequest;
        private IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Merged.CareCompositions> componentOf2PatientCareProvisionEvent;

        public BatteryOrPanel() {
            this.informationRecipientRecipientChoice = new List<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Lab.Merged.IRecipientChoice>();
            this.verifierAssignedEntity = new List<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Common.Merged.HealthcareWorker>();
            this.batteryIdentifier = new IIImpl();
            this.batteryType = new CDImpl();
            this.pertinentInformationSupportingClinicalObservationEvent = new List<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Lab.Merged.SupportingClinicalInformation>();
            this.batteryStatus = new CSImpl();
            this.batteryRequestTimeSpecification = new LISTImpl<GTS, GeneralTimingSpecification>(typeof(GTSImpl));
            this.batteryPriorityCode = new CVImpl();
            this.component4RequestChoice = new List<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Lab.Polb_mt001001ca.IRequestChoice>();
            this.batteryMaskingIndicator = new SETImpl<CV, Code>(typeof(CVImpl));
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
         * <summary>Q:Battery Identifier</summary>
         * 
         * <remarks><p>Uniquely identifies this panel or battery.</p> 
         * <p>Mandatory for create, revise, cancel, and nullify 
         * actions.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"id"})]
        public Identifier BatteryIdentifier {
            get { return this.batteryIdentifier.Value; }
            set { this.batteryIdentifier.Value = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"occurrenceOf/actParentPointer"})]
        public Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Lab.Merged.ParentTest OccurrenceOfActParentPointer {
            get { return this.occurrenceOfActParentPointer; }
            set { this.occurrenceOfActParentPointer = value; }
        }

        /**
         * <summary>R:Battery Type</summary>
         * 
         * <remarks><p>The type of battery or the &quot;code&quot; for 
         * this battery or panel. The value set bound to this attribute 
         * is a list of LOINC codes pulled from the pan-Canadian 
         * Laboratory Observation Code Database (pCLOCD). Only those 
         * records flagged as orderable or &quot;both&quot; in the 
         * pCLOCD can be used.</p> <p>Used to categorize and specify 
         * the type of battery to be performed.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"code"})]
        public ObservationOrderableLabType BatteryType {
            get { return (ObservationOrderableLabType) this.batteryType.Value; }
            set { this.batteryType.Value = value; }
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

        /**
         * <summary>T:Battery Status</summary>
         * 
         * <remarks><p>The statusCode represents the &quot;state&quot; 
         * of the battery e.g. active=in progress or not yet started, 
         * complete=resulted and/or result reported. It is up to the 
         * order placer to determine, upon receipt of one or more 
         * results which fulfill this battery request, when the order 
         * is complete.</p> <p>The statusCode represents the 
         * &quot;state&quot; of the test e.g. active=in progress or not 
         * yet started, complete=resulted and/or reported. For a 
         * battery, a &quot;complete&quot; status represents a 
         * &quot;complete&quot; status for all child orders.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"statusCode"})]
        public ActStatus BatteryStatus {
            get { return (ActStatus) this.batteryStatus.Value; }
            set { this.batteryStatus.Value = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"component2/referralRedirectIndicator"})]
        public Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Lab.Merged.ReferralRedirectIndicator Component2ReferralRedirectIndicator {
            get { return this.component2ReferralRedirectIndicator; }
            set { this.component2ReferralRedirectIndicator = value; }
        }

        /**
         * <summary>S:Battery Request Time Specification</summary>
         * 
         * <remarks><p>The time specification for when the battery is 
         * requested to be performed or occur or when the changes to 
         * the request took effect or are supposed to take effect. This 
         * time specification includes support for complex, repeating 
         * orders.</p> <p>Would be used to communicate that an Order is 
         * for a future date.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"effectiveTime"})]
        public IList<GeneralTimingSpecification> BatteryRequestTimeSpecification {
            get { return this.batteryRequestTimeSpecification.RawList(); }
        }

        [Hl7XmlMappingAttribute(new string[] {"component3/requestSortKey"})]
        public Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Lab.Merged.OrderSortKey Component3RequestSortKey {
            get { return this.component3RequestSortKey; }
            set { this.component3RequestSortKey = value; }
        }

        /**
         * <summary>U:Battery Priority Code</summary>
         * 
         * <remarks><p>Priority code associated with a specific 
         * test.</p> <p>Communicates requested test priority (e.g. 
         * routine, stat, etc.)</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"priorityCode"})]
        public ActPriority BatteryPriorityCode {
            get { return (ActPriority) this.batteryPriorityCode.Value; }
            set { this.batteryPriorityCode.Value = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"component4/requestChoice"})]
        public IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Lab.Polb_mt001001ca.IRequestChoice> Component4RequestChoice {
            get { return this.component4RequestChoice; }
        }

        /**
         * <summary>V:Battery Masking Indicator</summary>
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
        public ICollection<x_BasicConfidentialityKind> BatteryMaskingIndicator {
            get { return this.batteryMaskingIndicator.RawSet<x_BasicConfidentialityKind>(); }
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