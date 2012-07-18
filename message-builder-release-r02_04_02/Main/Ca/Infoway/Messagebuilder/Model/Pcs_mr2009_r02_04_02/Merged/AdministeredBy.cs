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
 * Last modified: $LastChangedDate: 2012-01-18 21:00:08 -0500 (Wed, 18 Jan 2012) $
 * Revision:      $LastChangedRevision: 3886 $
 */

/* This class was auto-generated by the message builder generator tools. */
namespace Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Merged {
    using Ca.Infoway.Messagebuilder.Annotation;
    using Ca.Infoway.Messagebuilder.Datatype;
    using Ca.Infoway.Messagebuilder.Datatype.Impl;
    using Ca.Infoway.Messagebuilder.Domainvalue;
    using Ca.Infoway.Messagebuilder.Model;
    using System;


    /**
     * <summary>POIZ_MT030060CA.Performer: administered by</summary>
     * 
     * <remarks><p>The provider who administered the vaccine.</p> 
     * <p>Needed to identify who actually administered the vaccine 
     * to the patient. If the performing provider is not specified, 
     * the author is assumed to be the performing provider. This 
     * information may not always be known. As a result, this 
     * participation is required.</p> POIZ_MT030050CA.Performer: 
     * administered by <p>The provider who administered the 
     * vaccine.</p> <p>Needed to identify who actually administered 
     * the vaccine to the patient. If the performing provider is 
     * not specified, the author is assumed to be the performing 
     * provider. This information may not always be known. As a 
     * result, this participation is required.</p> 
     * POIZ_MT060150CA.Performer: administered by <p>The provider 
     * who administered the vaccine.</p> <p>Needed to identify who 
     * actually administered the vaccine to the patient. If the 
     * performing provider is not specified, the author is assumed 
     * to be the performing provider. This information may not 
     * always be known. As a result, this participation is 
     * required.</p> REPC_MT210002CA.Performer: *u: referred to 
     * <p>Identifies the specific provider for which the referral 
     * is to be sent.</p> <p>If the referral was targeted to a 
     * specific provider then the identity of the provider must be 
     * known.</p> REPC_MT210003CA.Performer: *u: referred to 
     * <p>Identifies the specific provider for which the referral 
     * is to be sent.</p> <p>If the referral was targeted to a 
     * specific provider then the identity of the provider must be 
     * known.</p></remarks>
     */
    [Hl7PartTypeMappingAttribute(new string[] {"POIZ_MT030050CA.Performer","POIZ_MT030060CA.Performer","POIZ_MT060150CA.Performer","REPC_MT210001CA.Performer","REPC_MT210002CA.Performer","REPC_MT210003CA.Performer"})]
    public class AdministeredBy : MessagePartBean {

        private CV signingMethod;
        private CV signatureCode;
        private ED<String> digitalSignature;
        private Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Merged.HealthcareWorker assignedEntity;

        public AdministeredBy() {
            this.signingMethod = new CVImpl();
            this.signatureCode = new CVImpl();
            this.digitalSignature = new EDImpl<String>();
        }
        /**
         * <summary>SigningMethod</summary>
         * 
         * <remarks>Signing method <p>A code specifying the modality by 
         * which the original information was presented.</p> <p>Used to 
         * specify whether the information was initially provided 
         * verbally, (hand-)written, or electronically. As not all 
         * implementations will need to communication this information, 
         * this attribute is optional.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"modeCode"})]
        public ParticipationMode SigningMethod {
            get { return (ParticipationMode) this.signingMethod.Value; }
            set { this.signingMethod.Value = value; }
        }

        /**
         * <summary>SignatureCode</summary>
         * 
         * <remarks>Signature Code <p>A code specifying whether and how 
         * the participant has attested his participation through a 
         * signature and or whether such a signature is needed.</p> 
         * <p>Allows for communicating whether a the provider has 
         * digitally signed their signature. Strong, trusted 
         * authentication of the submitting author is sufficient to 
         * remove the need for digital signatures. As a result, this 
         * attribute is optional.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"signatureCode"})]
        public ParticipationSignature SignatureCode {
            get { return (ParticipationSignature) this.signatureCode.Value; }
            set { this.signatureCode.Value = value; }
        }

        /**
         * <summary>DigitalSignature</summary>
         * 
         * <remarks>Digital Signature <p>A textual or multimedia 
         * depiction of the signature by which the participant endorses 
         * his or her participation in the Act as specified in the 
         * Participation.typeCode and that he or she agrees to assume 
         * the associated accountability.</p> <p>Allows for recording 
         * the signature of the performing provider. Strong, trusted 
         * authentication of the submitting author is sufficient to 
         * remove the need for digital signatures. As a result, this 
         * attribute is optional.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"signatureText"})]
        public String DigitalSignature {
            get { return this.digitalSignature.Value; }
            set { this.digitalSignature.Value = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"assignedEntity"})]
        public Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Merged.HealthcareWorker AssignedEntity {
            get { return this.assignedEntity; }
            set { this.assignedEntity = value; }
        }

    }

}