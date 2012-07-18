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
namespace Ca.Infoway.Messagebuilder.Model.Sk_cerx_v01_r04_3.Common.Merged {
    using Ca.Infoway.Messagebuilder.Annotation;
    using Ca.Infoway.Messagebuilder.Datatype;
    using Ca.Infoway.Messagebuilder.Datatype.Impl;
    using Ca.Infoway.Messagebuilder.Datatype.Lang;
    using Ca.Infoway.Messagebuilder.Domainvalue;
    using Ca.Infoway.Messagebuilder.Model;
    using Ca.Infoway.Messagebuilder.Model.Sk_cerx_v01_r04_3.Common.Coct_mt090107ca;
    using Ca.Infoway.Messagebuilder.Model.Sk_cerx_v01_r04_3.Common.Coct_mt240003ca;
    using Ca.Infoway.Messagebuilder.Model.Sk_cerx_v01_r04_3.Merged;
    using Ca.Infoway.Messagebuilder.Model.Sk_cerx_v01_r04_3.Pharmacy.Merged;
    using System;
    using System.Collections.Generic;


    /**
     * <summary>TriggerEvent</summary>
     * 
     * <remarks>MCAI_MT700221CA.ControlActEvent: Trigger Event 
     * <p>Identifies the action that resulted in this message being 
     * sent.</p> <p>Key to understanding what action a message 
     * represents.</p> <p>There may be constraints on the usage of 
     * the effectiveTime and reasonCode attributes in the 
     * definition of the interaction or the trigger events which 
     * are conveyed with this wrapper.</p> 
     * MCAI_MT700220CA.ControlActEvent: Trigger Event <p>Identifies 
     * the action that resulted in this message being sent.</p> 
     * <p>Key to understanding what action a message 
     * represents.</p> <p>There may be constraints on the usage of 
     * the effectiveTime and reasonCode attributes in the 
     * definition of the interaction or the trigger events which 
     * are conveyed with this wrapper.</p></remarks>
     */
    [Hl7PartTypeMappingAttribute(new string[] {"MCAI_MT700220CA.ControlActEvent","MCAI_MT700221CA.ControlActEvent"})]
    public class TriggerEvent_2<ACT> : MessagePartBean {

        private II id;
        private CV code;
        private TS effectiveTime;
        private CV reasonCode;
        private Ca.Infoway.Messagebuilder.Model.Sk_cerx_v01_r04_3.Common.Coct_mt090107ca.Provider responsiblePartyAssignedPerson;
        private Ca.Infoway.Messagebuilder.Model.Sk_cerx_v01_r04_3.Merged.RefusedBy author;
        private Ca.Infoway.Messagebuilder.Model.Sk_cerx_v01_r04_3.Common.Coct_mt090107ca.Provider dataEntererAssignedPerson;
        private Ca.Infoway.Messagebuilder.Model.Sk_cerx_v01_r04_3.Merged.RecordedAt location;
        private Ca.Infoway.Messagebuilder.Model.Sk_cerx_v01_r04_3.Common.Coct_mt240003ca.ServiceLocation dataEntryLocationServiceDeliveryLocation;
        private Ca.Infoway.Messagebuilder.Model.Sk_cerx_v01_r04_3.Common.Merged.RefersTo<ACT> subject;
        private IList<Ca.Infoway.Messagebuilder.Model.Sk_cerx_v01_r04_3.Pharmacy.Merged.Issues> subjectOfDetectedIssueEvent;

        public TriggerEvent_2() {
            this.id = new IIImpl();
            this.code = new CVImpl();
            this.effectiveTime = new TSImpl();
            this.reasonCode = new CVImpl();
            this.subjectOfDetectedIssueEvent = new List<Ca.Infoway.Messagebuilder.Model.Sk_cerx_v01_r04_3.Pharmacy.Merged.Issues>();
        }
        /**
         * <summary>EventIdentifier</summary>
         * 
         * <remarks>B:Event Identifier <p>A unique identifier for this 
         * particular event assigned by the system in which the event 
         * occurred.</p> <p>Allows the event to be referenced (for 
         * retractions) and also indicates whether multiple 
         * interactions were caused by the same triggering event. The 
         * attribute is therefore mandatory.</p> <p>These identifiers 
         * should be stored for use in 'retractions'. They should be 
         * stored in such a way that they are associated with the item 
         * that was modified by this event. For example, a system 
         * should be able to show the list of trigger event identifiers 
         * for the actions that have been recorded against a particular 
         * prescription.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"id"})]
        public Identifier Id {
            get { return this.id.Value; }
            set { this.id.Value = value; }
        }

        /**
         * <summary>EventType</summary>
         * 
         * <remarks>A:Event Type <p>Identifies the trigger event that 
         * occurred.</p> <p>This is mandatory because it is essential 
         * to understanding the meaning of the event.</p> A:Event Type 
         * <p>Identifies the trigger event that occurred.</p> <p>This 
         * is mandatory because it is essential to understanding the 
         * meaning of the event.</p> <p>with the response.&nbsp;</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"code"})]
        public HL7TriggerEventCode Code {
            get { return (HL7TriggerEventCode) this.code.Value; }
            set { this.code.Value = value; }
        }

        /**
         * <summary>EventEffectivePeriod</summary>
         * 
         * <remarks>C:Event Effective Period <p>Indicates the time the 
         * change occurred. If not populated, the assumption is the 
         * same time the message was constructed.</p> <p>The time a 
         * change becomes effective may differ from the time the event 
         * is recorded. (I.e. it may be in the future or the past). For 
         * changes such as 'suspend', an intended end date may also be 
         * indicated.</p> <p>This will not be populated by 
         * PIN.&nbsp;</p> C:Event Effective Period <p>Indicates the 
         * time the occurred. If not specified, assumption is that the 
         * event occurred at the same time the message was 
         * constructed.</p> <p>The time a change becomes effective may 
         * differ from the time the event is recorded. (I.e. it may be 
         * in the future or the past). For changes such as 'suspend', 
         * an intended end date may also be indicated.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"effectiveTime"})]
        public PlatformDate EffectiveTime {
            get { return this.effectiveTime.Value; }
            set { this.effectiveTime.Value = value; }
        }

        /**
         * <summary>EventReason</summary>
         * 
         * <remarks>E:Event Reason <p>Identifies why this specific 
         * query, modification request, or modification occurred.</p> 
         * <p>Allows identifying a reason for a specific action, such 
         * as 'reason for hold'. Also allows identifying reason for 
         * accessing information for a query.</p> <p>The domain 
         * associated with this attribute will vary for each 
         * interaction and will be noted as part of the interaction 
         * description.</p> E:Event Reason <p>Identifies why this 
         * specific query, modification request, or modification 
         * occurred.</p> <p>Allows identifying a reason for a specific 
         * action, such as 'reason for hold'. Also allows identifying 
         * reason for accessing information for a query.</p> <p>The 
         * domain associated with this attribute will vary for each 
         * interaction and will be noted as part of the interaction 
         * description.</p> <p>by Infoway for reject responses does not 
         * exist.&nbsp;</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"reasonCode"})]
        public ControlActReason ReasonCode {
            get { return (ControlActReason) this.reasonCode.Value; }
            set { this.reasonCode.Value = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"responsibleParty/assignedPerson"})]
        public Ca.Infoway.Messagebuilder.Model.Sk_cerx_v01_r04_3.Common.Coct_mt090107ca.Provider ResponsiblePartyAssignedPerson {
            get { return this.responsiblePartyAssignedPerson; }
            set { this.responsiblePartyAssignedPerson = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"author"})]
        public Ca.Infoway.Messagebuilder.Model.Sk_cerx_v01_r04_3.Merged.RefusedBy Author {
            get { return this.author; }
            set { this.author = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"dataEnterer/assignedPerson"})]
        public Ca.Infoway.Messagebuilder.Model.Sk_cerx_v01_r04_3.Common.Coct_mt090107ca.Provider DataEntererAssignedPerson {
            get { return this.dataEntererAssignedPerson; }
            set { this.dataEntererAssignedPerson = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"location"})]
        public Ca.Infoway.Messagebuilder.Model.Sk_cerx_v01_r04_3.Merged.RecordedAt Location {
            get { return this.location; }
            set { this.location = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"dataEntryLocation/serviceDeliveryLocation"})]
        public Ca.Infoway.Messagebuilder.Model.Sk_cerx_v01_r04_3.Common.Coct_mt240003ca.ServiceLocation DataEntryLocationServiceDeliveryLocation {
            get { return this.dataEntryLocationServiceDeliveryLocation; }
            set { this.dataEntryLocationServiceDeliveryLocation = value; }
        }

        /**
         * <summary>Payload</summary>
         * 
         * <remarks>Payload </p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"subject"})]
        public Ca.Infoway.Messagebuilder.Model.Sk_cerx_v01_r04_3.Common.Merged.RefersTo<ACT> Subject {
            get { return this.subject; }
            set { this.subject = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"subjectOf/detectedIssueEvent"})]
        public IList<Ca.Infoway.Messagebuilder.Model.Sk_cerx_v01_r04_3.Pharmacy.Merged.Issues> SubjectOfDetectedIssueEvent {
            get { return this.subjectOfDetectedIssueEvent; }
        }

    }

}