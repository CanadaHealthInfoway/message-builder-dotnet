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
 * Last modified: $LastChangedDate: 2012-02-16 11:05:28 -0500 (Thu, 16 Feb 2012) $
 * Revision:      $LastChangedRevision: 5451 $
 */
/* This class was auto-generated by the message builder generator tools. */
namespace Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r01.Common.Merged {
    using Ca.Infoway.Messagebuilder.Annotation;
    using Ca.Infoway.Messagebuilder.Datatype;
    using Ca.Infoway.Messagebuilder.Datatype.Impl;
    using Ca.Infoway.Messagebuilder.Datatype.Lang;
    using Ca.Infoway.Messagebuilder.Domainvalue;
    using Ca.Infoway.Messagebuilder.Model;
    using System;
    using System.Collections.Generic;


    [Hl7PartTypeMappingAttribute(new string[] {"MCCI_MT002200CA.Acknowledgement","MCCI_MT002300CA.Acknowledgement"})]
    public class Acknowledgement : MessagePartBean {

        private CS typeCode;
        private INT messageWaitingNumber;
        private CV messageWaitingPriorityCode;
        private II targetMessageId;
        private IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r01.Common.Merged.ErrorsOrWarnings> acknowledgementDetail;

        public Acknowledgement() {
            this.typeCode = new CSImpl();
            this.messageWaitingNumber = new INTImpl();
            this.messageWaitingPriorityCode = new CVImpl();
            this.targetMessageId = new IIImpl();
            this.acknowledgementDetail = new List<Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r01.Common.Merged.ErrorsOrWarnings>();
        }
        /**
         * <summary>AcknowledgementCode</summary>
         * 
         * <remarks>GA:Acknowledgement Code <p>Indicates whether the 
         * previous interaction was successfully processed.</p> <p>Key 
         * to understanding whether the interaction has been successful 
         * and is therefore mandatory.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"typeCode"})]
        public AcknowledgementType TypeCode {
            get { return (AcknowledgementType) this.typeCode.Value; }
            set { this.typeCode.Value = value; }
        }

        /**
         * <summary>NumberOfWaitingMessages</summary>
         * 
         * <remarks>GC:Number of Waiting Messages <p>For applications 
         * which support polling, indicates the total number of 
         * messages waiting to be retrieved.</p> <p>Indicates to a 
         * system how many polled messages are available without the 
         * need so send a separate query. The element is optional 
         * because not all systems will support polling.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"messageWaitingNumber"})]
        public int? MessageWaitingNumber {
            get { return this.messageWaitingNumber.Value; }
            set { this.messageWaitingNumber.Value = value; }
        }

        /**
         * <summary>MessageWaitingPriority</summary>
         * 
         * <remarks>GD:Message Waiting Priority <p>Indicates the 
         * priority of the highest-priority message that is waiting on 
         * the poll queue for the system being responded to.</p> <p>The 
         * priority of the waiting message may influence how quickly 
         * the polling system may choose to download queued messages. 
         * The element is optional because not all systems will support 
         * polling.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"messageWaitingPriorityCode"})]
        public MessageWaitingPriority MessageWaitingPriorityCode {
            get { return (MessageWaitingPriority) this.messageWaitingPriorityCode.Value; }
            set { this.messageWaitingPriorityCode.Value = value; }
        }

        /**
         * <summary>AcknowledgedMessageId</summary>
         * 
         * <remarks>BA:Acknowledged Message Id <p>References the 
         * identifier of the message this current message is 
         * acknowledging.</p> <p>soap:Header\wsa:RelatesTo</p> 
         * <p>Provides the necessary link to complete a conversation 
         * for systems using communication technologies which are not 
         * conversational. This attribute is therefore mandatory.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"targetMessage/id"})]
        public Identifier TargetMessageId {
            get { return this.targetMessageId.Value; }
            set { this.targetMessageId.Value = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"acknowledgementDetail"})]
        public IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r01.Common.Merged.ErrorsOrWarnings> AcknowledgementDetail {
            get { return this.acknowledgementDetail; }
        }

    }

}