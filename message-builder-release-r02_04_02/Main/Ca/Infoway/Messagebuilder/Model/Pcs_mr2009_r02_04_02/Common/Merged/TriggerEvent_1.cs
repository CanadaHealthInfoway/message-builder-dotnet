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
 * Last modified: $LastChangedDate: 2012-01-18 21:05:07 -0500 (Wed, 18 Jan 2012) $
 * Revision:      $LastChangedRevision: 3929 $
 */

/* This class was auto-generated by the message builder generator tools. */
namespace Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Common.Merged {
    using Ca.Infoway.Messagebuilder.Annotation;
    using Ca.Infoway.Messagebuilder.Datatype;
    using Ca.Infoway.Messagebuilder.Datatype.Impl;
    using Ca.Infoway.Messagebuilder.Datatype.Lang;
    using Ca.Infoway.Messagebuilder.Domainvalue;
    using Ca.Infoway.Messagebuilder.Model;
    using Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Common.Coct_mt240002ca;
    using Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Common.Coct_mt470002ca;
    using Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Merged;
    using System;
    using System.Collections.Generic;


    /**
     * <summary>TriggerEvent</summary>
     * 
     * <remarks>MCAI_MT700228CA.ControlActEvent: Trigger Event 
     * <p>Identifies the action that resulted in this message being 
     * sent.</p> <p>Key to understanding what action a message 
     * represents.</p> <p>There may be constraints on the usage of 
     * the effectiveTime and reasonCode attributes in the 
     * definition of the interaction or the trigger events which 
     * are conveyed with this wrapper.</p> 
     * MCAI_MT700227CA.ControlActEvent: Trigger Event <p>Identifies 
     * the action that resulted in this message being sent.</p> 
     * <p>Key to understanding what action a message 
     * represents.</p> <p>There may be constraints on the usage of 
     * the effectiveTime and reasonCode attributes in the 
     * definition of the interaction or the trigger events which 
     * are conveyed with this wrapper.</p> 
     * MCAI_MT700212CA.ControlActEvent: Trigger Event <p>Identifies 
     * the action that resulted in this message being sent.</p> 
     * <p>Key to understanding what action a message 
     * represents.</p> <p>There may be constraints on the usage of 
     * the effectiveTime and reasonCode attributes in the 
     * definition of the interaction or the trigger events which 
     * are conveyed with this wrapper.</p> 
     * MCAI_MT700222CA.ControlActEvent: Trigger Event <p>Identifies 
     * the action that resulted in this message being sent.</p> 
     * <p>Key to understanding what action a message 
     * represents.</p> <p>There may be constraints on the usage of 
     * the effectiveTime and reasonCode attributes in the 
     * definition of the interaction or the trigger events which 
     * are conveyed with this wrapper.</p> 
     * MCAI_MT700218CA.ControlActEvent: Trigger Event <p>Identifies 
     * the action that resulted in this message being sent.</p> 
     * <p>Key to understanding what action a message 
     * represents.</p> <p>There may be constraints on the usage of 
     * the effectiveTime and reasonCode attributes in the 
     * definition of the interaction or the trigger events which 
     * are conveyed with this wrapper.</p> 
     * MCAI_MT700217CA.ControlActEvent: Trigger Event <p>Identifies 
     * the action that resulted in this message being sent.</p> 
     * <p>Key to understanding what action a message 
     * represents.</p> <p>There may be constraints on the usage of 
     * the effectiveTime and reasonCode attributes in the 
     * definition of the interaction or the trigger events which 
     * are conveyed with this wrapper.</p> 
     * MCAI_MT700210CA.ControlActEvent: Trigger Event <p>Identifies 
     * the action that resulted in this message being sent.</p> 
     * <p>Key to understanding what action a message 
     * represents.</p> <p>There may be constraints on the usage of 
     * the effectiveTime and reasonCode attributes in the 
     * definition of the interaction or the trigger events which 
     * are conveyed with this wrapper.</p> 
     * MCAI_MT700226CA.ControlActEvent: Trigger Event <p>Identifies 
     * the action that resulted in this message being sent.</p> 
     * <p>Key to understanding what action a message 
     * represents.</p> <p>There may be constraints on the usage of 
     * the effectiveTime and reasonCode attributes in the 
     * definition of the interaction or the trigger events which 
     * are conveyed with this wrapper.</p> 
     * MCAI_MT700221CA.ControlActEvent: Trigger Event <p>Identifies 
     * the action that resulted in this message being sent.</p> 
     * <p>Key to understanding what action a message 
     * represents.</p> <p>There may be constraints on the usage of 
     * the effectiveTime and reasonCode attributes in the 
     * definition of the interaction or the trigger events which 
     * are conveyed with this wrapper.</p> 
     * MCAI_MT700216CA.ControlActEvent: Trigger Event <p>Identifies 
     * the action that resulted in this message being sent.</p> 
     * <p>Key to understanding what action a message 
     * represents.</p> <p>There may be constraints on the usage of 
     * the effectiveTime and reasonCode attributes in the 
     * definition of the interaction or the trigger events which 
     * are conveyed with this wrapper.</p> 
     * MCAI_MT700211CA.ControlActEvent: Trigger Event <p>Identifies 
     * the action that resulted in this message being sent.</p> 
     * <p>Key to understanding what action a message 
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
    [Hl7PartTypeMappingAttribute(new string[] {"MCAI_MT700210CA.ControlActEvent","MCAI_MT700211CA.ControlActEvent","MCAI_MT700212CA.ControlActEvent","MCAI_MT700216CA.ControlActEvent","MCAI_MT700217CA.ControlActEvent","MCAI_MT700218CA.ControlActEvent","MCAI_MT700220CA.ControlActEvent","MCAI_MT700221CA.ControlActEvent","MCAI_MT700222CA.ControlActEvent","MCAI_MT700226CA.ControlActEvent","MCAI_MT700227CA.ControlActEvent","MCAI_MT700228CA.ControlActEvent"})]
    public class TriggerEvent_1<ACT> : MessagePartBean {

        private II eventIdentifier;
        private CV eventType;
        private IVL<TS, Interval<PlatformDate>> eventEffectivePeriod;
        private CV eventReason;
        private CE messageLanguage;
        private Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Common.Merged.RefersTo_1<ACT> subject;
        private IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Merged.Issues> subjectOfDetectedIssueEvent;
        private Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Merged.IPatient recordTargetPatient1;
        private Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Common.Merged.HealthcareWorker responsiblePartyAssignedEntity;
        private Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Common.Merged.CreatedBy_1 author;
        private Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Common.Merged.IActingPerson dataEntererActingPerson;
        private Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Common.Coct_mt240002ca.ServiceLocation dataEntryLocationServiceDeliveryLocation;
        private Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Common.Coct_mt240002ca.ServiceLocation locationServiceDeliveryLocation;
        private Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Common.Merged.AuthenticationToken pertinentInformationAuthorizationToken;
        private Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Common.Coct_mt470002ca.Consent subjectOf1ConsentEvent;
        private IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Merged.CareCompositions> componentOfPatientCareProvisionEvent;

        public TriggerEvent_1() {
            this.eventIdentifier = new IIImpl();
            this.eventType = new CVImpl();
            this.eventEffectivePeriod = new IVLImpl<TS, Interval<PlatformDate>>();
            this.eventReason = new CVImpl();
            this.messageLanguage = new CEImpl();
            this.subjectOfDetectedIssueEvent = new List<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Merged.Issues>();
            this.componentOfPatientCareProvisionEvent = new List<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Merged.CareCompositions>();
        }
        /**
         * <summary>EventIdentifier</summary>
         * 
         * <remarks>B:Event Identifier <p>A unique identifier for this 
         * particular event assigned by the system in which the event 
         * occurred.</p> <p>Allows the event to be referenced (for 
         * undos) and also indicates whether multiple interactions were 
         * caused by the same triggering event. Also used for audit 
         * purposes.</p> <p>Identifier needs to be persisted by 
         * receiving applications, except for queries (queries cannot 
         * be retracted or undone).</p> B:Event Identifier <p>A unique 
         * identifier for this particular event assigned by the system 
         * in which the event occurred.</p> <p>Allows the event to be 
         * referenced (for undos) and also indicates whether multiple 
         * interactions were caused by the same triggering event. Also 
         * used for audit purposes.</p> <p>Identifier needs to be 
         * persisted by receiving applications, except for queries 
         * (queries cannot be retracted or undone). The identifier must 
         * be unique and different from the event identifier that is 
         * present on the request - it must be generated by the 
         * responding application.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"id"})]
        public Identifier EventIdentifier {
            get { return this.eventIdentifier.Value; }
            set { this.eventIdentifier.Value = value; }
        }

        /**
         * <summary>EventType</summary>
         * 
         * <remarks>A:Event Type <p>Identifies the trigger event that 
         * occurred.</p> <p>This is mandatory because it is essential 
         * to understanding the meaning of the event.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"code"})]
        public HL7TriggerEventCode EventType {
            get { return (HL7TriggerEventCode) this.eventType.Value; }
            set { this.eventType.Value = value; }
        }

        /**
         * <summary>EventEffectivePeriod</summary>
         * 
         * <remarks>C:Event Effective Period <p>Indicates the time the 
         * event (e.g. query, change, activation) should begin and 
         * occasionally when it should end.</p> <p>The time an event 
         * becomes effective may differ from the time the event is 
         * recorded (i.e. it may be in the future or the past). For 
         * events such as 'suspend', an intended end date may also be 
         * indicated.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"effectiveTime"})]
        public Interval<PlatformDate> EventEffectivePeriod {
            get { return this.eventEffectivePeriod.Value; }
            set { this.eventEffectivePeriod.Value = value; }
        }

        /**
         * <summary>EventReason</summary>
         * 
         * <remarks>E:Event Reason <p>Identifies why this specific 
         * message interaction (e.g. query, activation request, 
         * modification request) occurred.</p> <p>Allows identifying a 
         * reason for a specific action, such as 'reason for hold' or 
         * 'reason for accessing information'.</p> <p>The domain 
         * associated with this attribute will vary for each 
         * interaction and will be noted as part of the interaction 
         * description.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"reasonCode"})]
        public ControlActReason EventReason {
            get { return (ControlActReason) this.eventReason.Value; }
            set { this.eventReason.Value = value; }
        }

        /**
         * <summary>MessageLanguage</summary>
         * 
         * <remarks>Message Language</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"languageCode"})]
        public HumanLanguage MessageLanguage {
            get { return (HumanLanguage) this.messageLanguage.Value; }
            set { this.messageLanguage.Value = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"subject"})]
        public Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Common.Merged.RefersTo_1<ACT> Subject {
            get { return this.subject; }
            set { this.subject = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"subjectOf/detectedIssueEvent","subjectOf2/detectedIssueEvent"})]
        [Hl7MapByPartType(Name="subjectOf", Type="MCAI_MT700216CA.Subject")]
        [Hl7MapByPartType(Name="subjectOf", Type="MCAI_MT700217CA.Subject")]
        [Hl7MapByPartType(Name="subjectOf", Type="MCAI_MT700218CA.Subject")]
        [Hl7MapByPartType(Name="subjectOf", Type="MCAI_MT700220CA.Subject")]
        [Hl7MapByPartType(Name="subjectOf", Type="MCAI_MT700221CA.Subject")]
        [Hl7MapByPartType(Name="subjectOf", Type="MCAI_MT700222CA.Subject")]
        [Hl7MapByPartType(Name="subjectOf", Type="MCAI_MT700226CA.Subject")]
        [Hl7MapByPartType(Name="subjectOf", Type="MCAI_MT700227CA.Subject")]
        [Hl7MapByPartType(Name="subjectOf", Type="MCAI_MT700228CA.Subject")]
        [Hl7MapByPartType(Name="subjectOf/detectedIssueEvent", Type="COCT_MT260010CA.DetectedIssueEvent")]
        [Hl7MapByPartType(Name="subjectOf/detectedIssueEvent", Type="COCT_MT260012CA.DetectedIssueEvent")]
        [Hl7MapByPartType(Name="subjectOf/detectedIssueEvent", Type="COCT_MT260020CA.DetectedIssueEvent")]
        [Hl7MapByPartType(Name="subjectOf/detectedIssueEvent", Type="COCT_MT260022CA.DetectedIssueEvent")]
        [Hl7MapByPartType(Name="subjectOf2", Type="MCAI_MT700210CA.Subject")]
        [Hl7MapByPartType(Name="subjectOf2", Type="MCAI_MT700211CA.Subject")]
        [Hl7MapByPartType(Name="subjectOf2", Type="MCAI_MT700212CA.Subject")]
        [Hl7MapByPartType(Name="subjectOf2/detectedIssueEvent", Type="COCT_MT260010CA.DetectedIssueEvent")]
        [Hl7MapByPartType(Name="subjectOf2/detectedIssueEvent", Type="COCT_MT260012CA.DetectedIssueEvent")]
        public IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Merged.Issues> SubjectOfDetectedIssueEvent {
            get { return this.subjectOfDetectedIssueEvent; }
        }

        [Hl7XmlMappingAttribute(new string[] {"recordTarget/patient1"})]
        public Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Merged.IPatient RecordTargetPatient1 {
            get { return this.recordTargetPatient1; }
            set { this.recordTargetPatient1 = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"responsibleParty/assignedEntity"})]
        public Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Common.Merged.HealthcareWorker ResponsiblePartyAssignedEntity {
            get { return this.responsiblePartyAssignedEntity; }
            set { this.responsiblePartyAssignedEntity = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"author"})]
        public Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Common.Merged.CreatedBy_1 Author {
            get { return this.author; }
            set { this.author = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"dataEnterer/actingPerson"})]
        public Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Common.Merged.IActingPerson DataEntererActingPerson {
            get { return this.dataEntererActingPerson; }
            set { this.dataEntererActingPerson = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"dataEntryLocation/serviceDeliveryLocation"})]
        public Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Common.Coct_mt240002ca.ServiceLocation DataEntryLocationServiceDeliveryLocation {
            get { return this.dataEntryLocationServiceDeliveryLocation; }
            set { this.dataEntryLocationServiceDeliveryLocation = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"location/serviceDeliveryLocation"})]
        public Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Common.Coct_mt240002ca.ServiceLocation LocationServiceDeliveryLocation {
            get { return this.locationServiceDeliveryLocation; }
            set { this.locationServiceDeliveryLocation = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"pertinentInformation/authorizationToken"})]
        public Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Common.Merged.AuthenticationToken PertinentInformationAuthorizationToken {
            get { return this.pertinentInformationAuthorizationToken; }
            set { this.pertinentInformationAuthorizationToken = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"subjectOf1/consentEvent"})]
        public Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Common.Coct_mt470002ca.Consent SubjectOf1ConsentEvent {
            get { return this.subjectOf1ConsentEvent; }
            set { this.subjectOf1ConsentEvent = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"componentOf/patientCareProvisionEvent"})]
        public IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Merged.CareCompositions> ComponentOfPatientCareProvisionEvent {
            get { return this.componentOfPatientCareProvisionEvent; }
        }

    }

}