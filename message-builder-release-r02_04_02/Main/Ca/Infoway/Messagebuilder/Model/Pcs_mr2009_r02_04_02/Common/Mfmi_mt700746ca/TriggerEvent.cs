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
 * Last modified: $LastChangedDate: 2012-01-18 21:05:12 -0500 (Wed, 18 Jan 2012) $
 * Revision:      $LastChangedRevision: 3930 $
 */

/* This class was auto-generated by the message builder generator tools. */
namespace Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Common.Mfmi_mt700746ca {
    using Ca.Infoway.Messagebuilder.Annotation;
    using Ca.Infoway.Messagebuilder.Datatype;
    using Ca.Infoway.Messagebuilder.Datatype.Impl;
    using Ca.Infoway.Messagebuilder.Datatype.Lang;
    using Ca.Infoway.Messagebuilder.Domainvalue;
    using Ca.Infoway.Messagebuilder.Model;
    using Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Common.Merged;
    using Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Merged;
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
    [Hl7PartTypeMappingAttribute(new string[] {"MFMI_MT700746CA.ControlActEvent"})]
    public class TriggerEvent<PL,RR> : MessagePartBean {

        private II eventIdentifier;
        private CV eventType;
        private IVL<TS, Interval<PlatformDate>> eventEffectivePeriod;
        private CV eventReason;
        private CE messageLanguage;
        private IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Common.Merged.RegistrationEvent<RR>> subjectRegistrationEvent;
        private IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Merged.Issues> subjectOfDetectedIssueEvent;
        private Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Common.Merged.QueryAck queryAck;
        private Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Common.Merged.QueryByParameter<PL> queryByParameter;

        public TriggerEvent() {
            this.eventIdentifier = new IIImpl();
            this.eventType = new CVImpl();
            this.eventEffectivePeriod = new IVLImpl<TS, Interval<PlatformDate>>();
            this.eventReason = new CVImpl();
            this.messageLanguage = new CEImpl();
            this.subjectRegistrationEvent = new List<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Common.Merged.RegistrationEvent<RR>>();
            this.subjectOfDetectedIssueEvent = new List<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Merged.Issues>();
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
         * retracted or undone). The identifier must be unique and 
         * different from the event identifier that is present on the 
         * request - it must be generated by the responding 
         * application.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"id"})]
        public Identifier EventIdentifier {
            get { return this.eventIdentifier.Value; }
            set { this.eventIdentifier.Value = value; }
        }

        /**
         * <summary>A:Event Type</summary>
         * 
         * <remarks><p>Identifies the trigger event that occurred.</p> 
         * <p>This is mandatory because it is essential to 
         * understanding the meaning of the event.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"code"})]
        public HL7TriggerEventCode EventType {
            get { return (HL7TriggerEventCode) this.eventType.Value; }
            set { this.eventType.Value = value; }
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
        public Interval<PlatformDate> EventEffectivePeriod {
            get { return this.eventEffectivePeriod.Value; }
            set { this.eventEffectivePeriod.Value = value; }
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
        public ControlActReason EventReason {
            get { return (ControlActReason) this.eventReason.Value; }
            set { this.eventReason.Value = value; }
        }

        /**
         * <summary>Message Language</summary>
         */
        [Hl7XmlMappingAttribute(new string[] {"languageCode"})]
        public HumanLanguage MessageLanguage {
            get { return (HumanLanguage) this.messageLanguage.Value; }
            set { this.messageLanguage.Value = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"subject/registrationEvent"})]
        public IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Common.Merged.RegistrationEvent<RR>> SubjectRegistrationEvent {
            get { return this.subjectRegistrationEvent; }
        }

        [Hl7XmlMappingAttribute(new string[] {"subjectOf/detectedIssueEvent"})]
        public IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Merged.Issues> SubjectOfDetectedIssueEvent {
            get { return this.subjectOfDetectedIssueEvent; }
        }

        [Hl7XmlMappingAttribute(new string[] {"queryAck"})]
        public Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Common.Merged.QueryAck QueryAck {
            get { return this.queryAck; }
            set { this.queryAck = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"queryByParameter"})]
        public Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Common.Merged.QueryByParameter<PL> QueryByParameter {
            get { return this.queryByParameter; }
            set { this.queryByParameter = value; }
        }

    }

}