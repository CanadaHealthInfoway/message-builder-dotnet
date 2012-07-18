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
namespace Ca.Infoway.Messagebuilder.Model.Ab_mr2007_v02_r02.Common.Mfmi_mt700751ca {
    using Ca.Infoway.Messagebuilder.Annotation;
    using Ca.Infoway.Messagebuilder.Datatype;
    using Ca.Infoway.Messagebuilder.Datatype.Impl;
    using Ca.Infoway.Messagebuilder.Datatype.Lang;
    using Ca.Infoway.Messagebuilder.Domainvalue;
    using Ca.Infoway.Messagebuilder.Model;
    using Ca.Infoway.Messagebuilder.Model.Ab_mr2007_v02_r02.Common.Merged;
    using Ca.Infoway.Messagebuilder.Model.Ab_mr2007_v02_r02.Merged;
    using System;
    using System.Collections.Generic;


    /**
     * <summary>Trigger Event</summary>
     * 
     * <remarks><p>Identifies the action that resulted in this 
     * message being sent.</p> <p>Key to understanding what action 
     * a message represents.</p> <p>There may be constraints on the 
     * usage of the effectiveTime and reasonCode attributes in the 
     * definition of the interaction or the trigger events which 
     * are conveyed with this wrapper.</p></remarks>
     */
    [Hl7PartTypeMappingAttribute(new string[] {"MFMI_MT700751CA.ControlActEvent"})]
    public class TriggerEvent<PL> : MessagePartBean {

        private CS classCode;
        private CS moodCode;
        private II id;
        private CV code;
        private IVL<TS, Interval<PlatformDate>> effectiveTime;
        private CV reasonCode;
        private Ca.Infoway.Messagebuilder.Model.Ab_mr2007_v02_r02.Merged.HealthcareWorker responsiblePartyAssignedEntity;
        private Ca.Infoway.Messagebuilder.Model.Ab_mr2007_v02_r02.Common.Merged.CreatedBy author;
        private Ca.Infoway.Messagebuilder.Model.Ab_mr2007_v02_r02.Common.Merged.IEntererChoice dataEntererEntererChoice;
        private Ca.Infoway.Messagebuilder.Model.Ab_mr2007_v02_r02.Merged.CreatedAt location;
        private Ca.Infoway.Messagebuilder.Model.Ab_mr2007_v02_r02.Merged.ServiceLocation dataEntryLocationServiceDeliveryLocation;
        private Ca.Infoway.Messagebuilder.Model.Ab_mr2007_v02_r02.Common.Merged.AuthenticationToken pertinentInformationAuthorizationToken;
        private Ca.Infoway.Messagebuilder.Model.Ab_mr2007_v02_r02.Common.Merged.AuthorizedBy subjectOf1;
        private IList<Ca.Infoway.Messagebuilder.Model.Ab_mr2007_v02_r02.Merged.Caused> subjectOf2;
        private Ca.Infoway.Messagebuilder.Model.Ab_mr2007_v02_r02.Common.Merged.QueryByParameter<PL> queryByParameter;

        public TriggerEvent() {
            this.classCode = new CSImpl();
            this.moodCode = new CSImpl();
            this.id = new IIImpl();
            this.code = new CVImpl();
            this.effectiveTime = new IVLImpl<TS, Interval<PlatformDate>>();
            this.reasonCode = new CVImpl();
            this.subjectOf2 = new List<Ca.Infoway.Messagebuilder.Model.Ab_mr2007_v02_r02.Merged.Caused>();
        }
        [Hl7XmlMappingAttribute(new string[] {"classCode"})]
        public ActClass ClassCode {
            get { return (ActClass) this.classCode.Value; }
            set { this.classCode.Value = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"moodCode"})]
        public ActMood MoodCode {
            get { return (ActMood) this.moodCode.Value; }
            set { this.moodCode.Value = value; }
        }

        /**
         * <summary>B:Event Identifier</summary>
         * 
         * <remarks><p>A unique identifier for this particular event 
         * assigned by the system in which the event occurred.</p> 
         * <p>Allows the event to be referenced (for undos) and also 
         * indicates whether multiple interactions were caused by the 
         * same triggering event. Also used for audit purposes.</p> 
         * <p>Identifier needs to be persisted by receiving 
         * applications, except for queries (queries cannot be 
         * retracted or undone).</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"id"})]
        public Identifier Id {
            get { return this.id.Value; }
            set { this.id.Value = value; }
        }

        /**
         * <summary>A:Event Type</summary>
         * 
         * <remarks><p>Identifies the trigger event that occurred.</p> 
         * <p>This is mandatory because it is essential to 
         * understanding the meaning of the event.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"code"})]
        public HL7TriggerEventCode Code {
            get { return (HL7TriggerEventCode) this.code.Value; }
            set { this.code.Value = value; }
        }

        /**
         * <summary>C:Event Effective Period</summary>
         * 
         * <remarks><p>Indicates the time the event (e.g. query, 
         * change, activation) should begin and occasionally when it 
         * should end.</p> <p>The time an event becomes effective may 
         * differ from the time the event is recorded (i.e. it may be 
         * in the future or the past). For events such as 'suspend', an 
         * intended end date may also be indicated.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"effectiveTime"})]
        public Interval<PlatformDate> EffectiveTime {
            get { return this.effectiveTime.Value; }
            set { this.effectiveTime.Value = value; }
        }

        /**
         * <summary>E:Event Reason</summary>
         * 
         * <remarks><p>Identifies why this specific message interaction 
         * (e.g. query, activation request, modification request) 
         * occurred.</p> <p>Allows identifying a reason for a specific 
         * action, such as 'reason for hold' or 'reason for accessing 
         * information'.</p> <p>The domain associated with this 
         * attribute will vary for each interaction and will be noted 
         * as part of the interaction description.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"reasonCode"})]
        public ControlActReason ReasonCode {
            get { return (ControlActReason) this.reasonCode.Value; }
            set { this.reasonCode.Value = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"responsibleParty/assignedEntity"})]
        public Ca.Infoway.Messagebuilder.Model.Ab_mr2007_v02_r02.Merged.HealthcareWorker ResponsiblePartyAssignedEntity {
            get { return this.responsiblePartyAssignedEntity; }
            set { this.responsiblePartyAssignedEntity = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"author"})]
        public Ca.Infoway.Messagebuilder.Model.Ab_mr2007_v02_r02.Common.Merged.CreatedBy Author {
            get { return this.author; }
            set { this.author = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"dataEnterer/entererChoice"})]
        public Ca.Infoway.Messagebuilder.Model.Ab_mr2007_v02_r02.Common.Merged.IEntererChoice DataEntererEntererChoice {
            get { return this.dataEntererEntererChoice; }
            set { this.dataEntererEntererChoice = value; }
        }

        public Ca.Infoway.Messagebuilder.Model.Ab_mr2007_v02_r02.Merged.HealthcareWorker DataEntererEntererChoiceAsAssignedEntity1 {
            get { return this.dataEntererEntererChoice is Ca.Infoway.Messagebuilder.Model.Ab_mr2007_v02_r02.Merged.HealthcareWorker ? (Ca.Infoway.Messagebuilder.Model.Ab_mr2007_v02_r02.Merged.HealthcareWorker) this.dataEntererEntererChoice : (Ca.Infoway.Messagebuilder.Model.Ab_mr2007_v02_r02.Merged.HealthcareWorker) null; }
        }
        public bool HasDataEntererEntererChoiceAsAssignedEntity1() {
            return (this.dataEntererEntererChoice is Ca.Infoway.Messagebuilder.Model.Ab_mr2007_v02_r02.Merged.HealthcareWorker);
        }

        public Ca.Infoway.Messagebuilder.Model.Ab_mr2007_v02_r02.Merged.HealthcareOrganization DataEntererEntererChoiceAsAssignedEntity2 {
            get { return this.dataEntererEntererChoice is Ca.Infoway.Messagebuilder.Model.Ab_mr2007_v02_r02.Merged.HealthcareOrganization ? (Ca.Infoway.Messagebuilder.Model.Ab_mr2007_v02_r02.Merged.HealthcareOrganization) this.dataEntererEntererChoice : (Ca.Infoway.Messagebuilder.Model.Ab_mr2007_v02_r02.Merged.HealthcareOrganization) null; }
        }
        public bool HasDataEntererEntererChoiceAsAssignedEntity2() {
            return (this.dataEntererEntererChoice is Ca.Infoway.Messagebuilder.Model.Ab_mr2007_v02_r02.Merged.HealthcareOrganization);
        }

        [Hl7XmlMappingAttribute(new string[] {"location"})]
        public Ca.Infoway.Messagebuilder.Model.Ab_mr2007_v02_r02.Merged.CreatedAt Location {
            get { return this.location; }
            set { this.location = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"dataEntryLocation/serviceDeliveryLocation"})]
        public Ca.Infoway.Messagebuilder.Model.Ab_mr2007_v02_r02.Merged.ServiceLocation DataEntryLocationServiceDeliveryLocation {
            get { return this.dataEntryLocationServiceDeliveryLocation; }
            set { this.dataEntryLocationServiceDeliveryLocation = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"pertinentInformation/authorizationToken"})]
        public Ca.Infoway.Messagebuilder.Model.Ab_mr2007_v02_r02.Common.Merged.AuthenticationToken PertinentInformationAuthorizationToken {
            get { return this.pertinentInformationAuthorizationToken; }
            set { this.pertinentInformationAuthorizationToken = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"subjectOf1"})]
        public Ca.Infoway.Messagebuilder.Model.Ab_mr2007_v02_r02.Common.Merged.AuthorizedBy SubjectOf1 {
            get { return this.subjectOf1; }
            set { this.subjectOf1 = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"subjectOf2"})]
        public IList<Ca.Infoway.Messagebuilder.Model.Ab_mr2007_v02_r02.Merged.Caused> SubjectOf2 {
            get { return this.subjectOf2; }
        }

        [Hl7XmlMappingAttribute(new string[] {"queryByParameter"})]
        public Ca.Infoway.Messagebuilder.Model.Ab_mr2007_v02_r02.Common.Merged.QueryByParameter<PL> QueryByParameter {
            get { return this.queryByParameter; }
            set { this.queryByParameter = value; }
        }

    }

}