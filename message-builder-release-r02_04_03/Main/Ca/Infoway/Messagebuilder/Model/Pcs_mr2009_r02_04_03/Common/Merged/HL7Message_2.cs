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
namespace Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Common.Merged {
    using Ca.Infoway.Messagebuilder.Annotation;
    using Ca.Infoway.Messagebuilder.Datatype;
    using Ca.Infoway.Messagebuilder.Datatype.Impl;
    using Ca.Infoway.Messagebuilder.Datatype.Lang;
    using Ca.Infoway.Messagebuilder.Domainvalue;
    using Ca.Infoway.Messagebuilder.Model;
    using System;
    using System.Collections.Generic;


    /**
     * <summary>HL7Message</summary>
     * 
     * <remarks>MCCI_MT102001CA.Message: HL7 Message <p>The root 
     * class of all messages.</p> <p>Conveys information about the 
     * interaction and how it is to be processed</p> 
     * MCCI_MT002200CA.Message: HL7 Message <p>The root class of 
     * all messages.</p> <p>Conveys information about the 
     * interaction and how it is to be processed</p></remarks>
     */
    [Hl7PartTypeMappingAttribute(new string[] {"MCCI_MT002200CA.Message","MCCI_MT102001CA.Message"})]
    public class HL7Message_2 : MessagePartBean {

        private II id;
        private TS creationTime;
        private ST securityText;
        private CS responseModeCode;
        private II interactionId;
        private LIST<II, Identifier> profileId;
        private CS processingCode;
        private CS acceptAckCode;
        private Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Common.Merged.Receiver receiver;
        private Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Common.Merged.ToBeRespondedToBy respondTo;
        private Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Common.Merged.Sender sender;
        private IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Common.Merged.RoutingInstructionLines> attentionLine;
        private CS processingModeCode;
        private Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Common.Merged.Acknowledgement acknowledgement;

        public HL7Message_2() {
            this.id = new IIImpl();
            this.creationTime = new TSImpl();
            this.securityText = new STImpl();
            this.responseModeCode = new CSImpl();
            this.interactionId = new IIImpl();
            this.profileId = new LISTImpl<II, Identifier>(typeof(IIImpl));
            this.processingCode = new CSImpl();
            this.acceptAckCode = new CSImpl();
            this.attentionLine = new List<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Common.Merged.RoutingInstructionLines>();
            this.processingModeCode = new CSImpl();
        }
        /**
         * <summary>MessageIdentifier</summary>
         * 
         * <remarks>A:Message Identifier <p>A unique identifier for the 
         * message.</p> <p>soap:Header\wsa:MessageID</p> <p>Allows 
         * detection of duplicate messages, and allows tying 
         * acknowledgments to the message they are acknowledging. The 
         * attribute is therefore mandatory.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"id"})]
        public Identifier Id {
            get { return this.id.Value; }
            set { this.id.Value = value; }
        }

        /**
         * <summary>MessageTimestamp</summary>
         * 
         * <remarks>G:Message Timestamp <p>Indicates the time this 
         * particular message instance was constructed.</p> <p>Allows 
         * identification of how current the information in a message 
         * is. Also provides a baseline for identifying the time-zone 
         * of other times within the message. As a result, the 
         * attribute is mandatory.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"creationTime"})]
        public PlatformDate CreationTime {
            get { return this.creationTime.Value; }
            set { this.creationTime.Value = value; }
        }

        /**
         * <summary>SecurityToken</summary>
         * 
         * <remarks>H:Security Token <p>A locally-defined field used to 
         * maintain a session, identify a user, and/or perform some 
         * other function related to authenticating the message 
         * source.</p> <p>Allows jurisdictions and applications to 
         * communicate authentication and session information. The 
         * attribute is optional because not all jurisdictions will 
         * require this capability.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"securityText"})]
        public String SecurityText {
            get { return this.securityText.Value; }
            set { this.securityText.Value = value; }
        }

        /**
         * <summary>ResponseType</summary>
         * 
         * <remarks>DA: Response Type <p>Identifies whether the 
         * response is desired immediately (as a direct 
         * acknowledgement), on a deferred basis (as a subsequent 
         * independent interaction) or via queue using polling.</p> 
         * <p>soap:Header\wsa:Action (after the second underscore, if 
         * any, D otherwise)</p> <p>Essential to determining receiver 
         * behavior and therefore mandatory.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"responseModeCode"})]
        public ResponseMode ResponseModeCode {
            get { return (ResponseMode) this.responseModeCode.Value; }
            set { this.responseModeCode.Value = value; }
        }

        /**
         * <summary>InteractionType</summary>
         * 
         * <remarks>B:Interaction Type <p>Indicates the interaction 
         * conveyed by this message.</p> <p>soap:Header\wsa:Action 
         * (after urn:hl7-org:v3: and before the second underscore, if 
         * any)</p> <p>Identifies what the receiving application should 
         * do, and how the message should be validated. The attribute 
         * is therefore mandatory.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"interactionId"})]
        public Identifier InteractionId {
            get { return this.interactionId.Value; }
            set { this.interactionId.Value = value; }
        }

        /**
         * <summary>ConformanceProfileIdentifiers</summary>
         * 
         * <remarks>F:Conformance Profile Identifiers <p>Identifies the 
         * conformance profile(s) this message complies with.</p> 
         * <p>Indicates any additional validation that may be 
         * appropriate. Also influences what extensions can be 
         * processed.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"profileId"})]
        public IList<Identifier> ProfileId {
            get { return this.profileId.RawList(); }
        }

        /**
         * <summary>ProcessingCode</summary>
         * 
         * <remarks>DB:Processing Code <p>Indicates whether this 
         * message is intended to be processed as production, test or 
         * debug message.</p> <p>soap:Header\wsa:To\(portion between 
         * second-last \ and third-last \)</p> <p>Indicates how the 
         * message should be handled and is therefore mandatory.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"processingCode"})]
        public ProcessingID ProcessingCode {
            get { return (ProcessingID) this.processingCode.Value; }
            set { this.processingCode.Value = value; }
        }

        /**
         * <summary>DesiredAcknowledgmentType</summary>
         * 
         * <remarks>E:Desired Acknowledgment Type <p>Indicates how the 
         * message is expected to be acknowledged.</p> <p>Provides 
         * support for immediate, deferred and polling mode and 
         * distinguishes which mode is desired. The attribute is 
         * therefore mandatory.</p> <p>When using SOAP, this attribute 
         * MUST be set to NE (Never). (Accept acknowledgements are 
         * handled via the transport protocol, not HL7.)</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"acceptAckCode"})]
        public AcknowledgementCondition AcceptAckCode {
            get { return (AcknowledgementCondition) this.acceptAckCode.Value; }
            set { this.acceptAckCode.Value = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"receiver"})]
        public Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Common.Merged.Receiver Receiver {
            get { return this.receiver; }
            set { this.receiver = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"respondTo"})]
        public Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Common.Merged.ToBeRespondedToBy RespondTo {
            get { return this.respondTo; }
            set { this.respondTo = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"sender"})]
        public Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Common.Merged.Sender Sender {
            get { return this.sender; }
            set { this.sender = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"attentionLine"})]
        public IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Common.Merged.RoutingInstructionLines> AttentionLine {
            get { return this.attentionLine; }
        }

        /**
         * <summary>ProcessingMode</summary>
         * 
         * <remarks>Processing Mode <p>This attribute defines whether 
         * the message is being sent in current processing, archive 
         * mode, initial load mode, restore from archive mode,</p> 
         * <p>Describes the mode of processing. For example current 
         * processing, archive mode, initial load mode, restore from 
         * archive mode.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"processingModeCode"})]
        public ProcessingMode ProcessingModeCode {
            get { return (ProcessingMode) this.processingModeCode.Value; }
            set { this.processingModeCode.Value = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"acknowledgement"})]
        public Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Common.Merged.Acknowledgement Acknowledgement {
            get { return this.acknowledgement; }
            set { this.acknowledgement = value; }
        }

    }

}