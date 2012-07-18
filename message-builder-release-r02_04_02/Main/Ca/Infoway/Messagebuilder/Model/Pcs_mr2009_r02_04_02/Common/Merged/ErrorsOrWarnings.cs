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
    using Ca.Infoway.Messagebuilder.Domainvalue;
    using Ca.Infoway.Messagebuilder.Model;
    using System;
    using System.Collections.Generic;


    /**
     * <summary>ErrorsOrWarnings</summary>
     * 
     * <remarks>MCCI_MT002200CA.AcknowledgementDetail: Errors or 
     * Warnings <p>An error, warning or information message 
     * associated with the message being acknowledged.</p> 
     * <p>Allows identification issues related to the parsing and 
     * low-level processing of the message.</p> 
     * MCCI_MT002300CA.AcknowledgementDetail: Errors or Warnings 
     * <p>An error, warning or information message associated with 
     * the message being acknowledged.</p> <p>Allows identification 
     * issues related to the parsing and low-level processing of 
     * the message.</p></remarks>
     */
    [Hl7PartTypeMappingAttribute(new string[] {"MCCI_MT002200CA.AcknowledgementDetail","MCCI_MT002300CA.AcknowledgementDetail"})]
    public class ErrorsOrWarnings : MessagePartBean {

        private CS messageType;
        private CV responseCode;
        private ST messageDescription;
        private SET<ST, String> referencedMessageLocations;

        public ErrorsOrWarnings() {
            this.messageType = new CSImpl();
            this.responseCode = new CVImpl();
            this.messageDescription = new STImpl();
            this.referencedMessageLocations = new SETImpl<ST, String>(typeof(STImpl));
        }
        /**
         * <summary>MessageType</summary>
         * 
         * <remarks>Message type <p>Distinguishes between errors, 
         * warnings and information messages.</p> <p>Different types of 
         * messages have substantially different ramifications.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"typeCode"})]
        public AcknowledgementDetailType MessageType {
            get { return (AcknowledgementDetailType) this.messageType.Value; }
            set { this.messageType.Value = value; }
        }

        /**
         * <summary>ResponseCode</summary>
         * 
         * <remarks>A:Response Code <p>Indicates the specific issue 
         * represented by this message.</p> <p>By providing coded 
         * identification of issues and errors, allows applications to 
         * have logic that manages particular errors and warnings 
         * automatically. However in some circumstances, a code may not 
         * be available. Therefore the attribute is marked as 
         * 'populated'.</p><p>The coding strength is CWE (coded with 
         * extensions). The use of local codes is only permitted when 
         * those codes are submitted to the SC for consideration and if 
         * the SC makes a recommendation other then adoption of the 
         * local code, jurisdictions are bound to adopt the 
         * recommendation.</p> <p>By providing coded identification of 
         * issues and errors, allows applications to have logic that 
         * manages particular errors and warnings automatically. 
         * However in some circumstances, a code may not be available. 
         * Therefore the attribute is marked as 'populated'.</p><p>The 
         * coding strength is CWE (coded with extensions). The use of 
         * local codes is only permitted when those codes are submitted 
         * to the SC for consideration and if the SC makes a 
         * recommendation other then adoption of the local code, 
         * jurisdictions are bound to adopt the recommendation.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"code"})]
        public AcknowledgementDetailCode ResponseCode {
            get { return (AcknowledgementDetailCode) this.responseCode.Value; }
            set { this.responseCode.Value = value; }
        }

        /**
         * <summary>MessageDescription</summary>
         * 
         * <remarks>C:Message Description <p>The human-readable 
         * description of the error, warning or information message. 
         * May convey additional details not present in the 'code', but 
         * is not intended to be human-processable.</p> <p>Allows 
         * supplementing the 'computer' information for 
         * human-readability.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"text"})]
        public String MessageDescription {
            get { return this.messageDescription.Value; }
            set { this.messageDescription.Value = value; }
        }

        /**
         * <summary>ReferencedMessageLocations</summary>
         * 
         * <remarks>B:Referenced Message Locations <p>Indicates the 
         * location of the elements within the message instance that 
         * triggered this error, warning or information message.</p> 
         * <p>Allows syntax and other messages to be linked to 
         * particular fields within the message.</p> <p>I.e. only the 
         * default 'child' axis is permitted, occurrence numbers are 
         * always specified, and no other predicates are permitted.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"location"})]
        public ICollection<String> ReferencedMessageLocations {
            get { return this.referencedMessageLocations.RawSet(); }
        }

    }

}