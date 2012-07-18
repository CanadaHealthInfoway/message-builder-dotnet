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
 * Last modified: $LastChangedDate: 2012-02-16 11:02:17 -0500 (Thu, 16 Feb 2012) $
 * Revision:      $LastChangedRevision: 5407 $
 */
/* This class was auto-generated by the message builder generator tools. */
namespace Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r01.Merged {
    using Ca.Infoway.Messagebuilder.Annotation;
    using Ca.Infoway.Messagebuilder.Datatype;
    using Ca.Infoway.Messagebuilder.Datatype.Impl;
    using Ca.Infoway.Messagebuilder.Model;
    using System;


    /**
     * <summary>PORX_MT060210CA.Author: *b:recorded by</summary>
     * 
     * <remarks><p>Indicates the identity of the provider who 
     * recorded the other medication information.</p> <p>Allows 
     * other providers to enquire about the authenticity of the 
     * content of the other medication record and is therefore 
     * mandatory.</p> PORR_MT050016CA.Author: Monograph Source 
     * <p>Expresses who is responsible for the content of the 
     * monograph</p> <p>Provides a means of evaluating accuracy of 
     * the content of the monograph.</p> PORX_MT060160CA.Author5: 
     * *refused by <p>Indicates who refused to fulfill the 
     * prescription</p> <p>Allows follow-up and traceability of the 
     * refusal.</p><p>Association is mandatory as the provider 
     * refusing the fill must be known.</p> <p>Allows follow-up and 
     * traceability of the refusal.</p><p>Association is mandatory 
     * as the provider refusing the fill must be known.</p> 
     * PORX_MT020070CA.Author: bc:prescribed by <p>The person who 
     * prescribed the medication.</p> <p>Used to create an 
     * 'inferred' prescription if an electronic prescription does 
     * not already exist in the EHR.</p> PORX_MT060190CA.Author: 
     * *recorded by <p>Indicates the provider who recorded the 
     * &quot;other active medication&quot;.</p> <p>Useful for 
     * follow-up and audit purposes, and therefore mandatory.</p> 
     * PORX_MT060190CA.Author3: *refused by <p>Indicates who 
     * refused to fulfill the prescription</p> <p>Allows follow-up 
     * and traceability of the refusal and is therefore 
     * mandatory</p> POME_MT010040CA.Author: Monograph Source 
     * <p>Expresses who is responsible for the content of the 
     * monograph</p> <p>ZPC1.1(organization.ID)</p><p>ZPD2.1</p> 
     * <p>ZPC1.1(organization.ID)</p><p>ZPD2.1</p> <p>Provides a 
     * means of evaluating accuracy of the content of the 
     * monograph.</p> PORX_MT030040CA.Author: *refused by 
     * <p>Indicates who refused to fulfill the prescription</p> 
     * <p>Allows follow-up and traceability of the refusal and is 
     * therefore mandatory.</p> PORX_MT060090CA.Author5: 
     * *prescribed by <p>Indicates the prescriber of the 
     * prescription.</p> <p>The prescriber is a key piece of legal 
     * information which must be conveyed and is therefore 
     * mandatory.</p> PORX_MT060160CA.Author: *created by 
     * <p>Identifies the provider responsible for capturing the 
     * Other Medication record</p> <p>Provides traceability as well 
     * as contact information for follow-up and is therefore 
     * mandatory.</p> REPC_MT000009CA.Author: *f:authored by 
     * <p>Identifies the provider who reported the allergy or 
     * intolerance.</p> <p>Identifies responsibility for accuracy 
     * and relevance of the information. This association reflects 
     * primary responsibility, and is therefore mandatory.</p> 
     * PORX_MT060340CA.Author: *refused by <p>Indicates who refused 
     * to fulfill the prescription</p> <p>Allows follow-up and 
     * traceability of the refusal.</p><p>Association is mandatory 
     * as the provider refusing the fill must be known.</p> 
     * <p>Allows follow-up and traceability of the 
     * refusal.</p><p>Association is mandatory as the provider 
     * refusing the fill must be known.</p> PORX_MT060060CA.Author: 
     * *refused by <p>Indicates who refused to fulfill the 
     * prescription</p> <p>Allows follow-up and traceability of the 
     * refusal and is therefore mandatory</p> 
     * PORX_MT060040CA.Author: *refused by <p>Indicates who refused 
     * to fulfill the prescription</p> <p>Allows follow-up and 
     * traceability of the refusal.</p><p>Association is mandatory 
     * as the provider refusing the fill must be known.</p> 
     * <p>Allows follow-up and traceability of the 
     * refusal.</p><p>Association is mandatory as the provider 
     * refusing the fill must be known.</p> REPC_MT000005CA.Author: 
     * *f:authored by <p>Identifies the provider who reported the 
     * allergy or intolerance.</p> <p>Identifies responsibility for 
     * accuracy and relevance of the information. This association 
     * reflects primary responsibility, and is therefore 
     * mandatory.</p> PORX_MT060010CA.Author5: *prescribed by 
     * <p>Indicates the prescriber of the prescription.</p> <p>The 
     * prescriber is a key piece of legal information which must be 
     * conveyed and is therefore mandatory.</p> 
     * REPC_MT000006CA.Author: *f:authored by <p>Identifies the 
     * provider who reported the reaction.</p> <p>Identifies 
     * responsibility for accuracy and relevance of the 
     * information. This association reflects primary 
     * responsibility, and is therefore mandatory.</p> 
     * PORX_MT020060CA.Author: bc:prescribed by <p>The person who 
     * prescribed the device.</p> <p>Used to create an 'inferred' 
     * prescription if an electronic prescription does not already 
     * exist in the EHR.</p></remarks>
     */
    [Hl7PartTypeMappingAttribute(new string[] {"POME_MT010040CA.Author","PORR_MT050016CA.Author","PORX_MT020060CA.Author","PORX_MT020070CA.Author","PORX_MT030040CA.Author","PORX_MT060010CA.Author5","PORX_MT060040CA.Author","PORX_MT060060CA.Author","PORX_MT060090CA.Author5","PORX_MT060160CA.Author","PORX_MT060160CA.Author5","PORX_MT060190CA.Author","PORX_MT060190CA.Author3","PORX_MT060210CA.Author","PORX_MT060340CA.Author","REPC_MT000005CA.Author","REPC_MT000006CA.Author","REPC_MT000009CA.Author"})]
    public class RefusedBy : MessagePartBean {

        private Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r01.Merged.HealthcareWorker assignedEntity;
        private TS time;

        public RefusedBy() {
            this.time = new TSImpl();
        }
        [Hl7XmlMappingAttribute(new string[] {"assignedEntity"})]
        public Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r01.Merged.HealthcareWorker AssignedEntity {
            get { return this.assignedEntity; }
            set { this.assignedEntity = value; }
        }

        /**
         * <summary>Prescription Order Date</summary>
         * 
         * <remarks><p>The date at which the drug was prescribed. This 
         * may differ from the date on which the prescription becomes 
         * effective. E.g. A prescription created today may not be 
         * valid to be dispensed or administered for two weeks.</p> 
         * <p>Indicates when the action was performed, and may 
         * influence expiry dates for the order.</p><p>The attribute is 
         * populated because the creation date of the prescription 
         * shall always be known or absent for a reason.</p> 
         * <p>Indicates when the action was performed, and may 
         * influence expiry dates for the order.</p><p>The attribute is 
         * populated because the creation date of the prescription 
         * shall always be known or absent for a reason.</p> 
         * Prescription Order Date <p>The date at which the device was 
         * prescribed. This may differ from the date on which the 
         * prescription becomes effective. E.g. A prescription created 
         * today may not be valid to be dispensed or used for two 
         * weeks.</p> <p>Indicates when the action was performed, and 
         * may influence expiry dates for the order.</p><p>The 
         * attribute is populated because the creation date of the 
         * prescription shall always be known or absent for a 
         * reason.</p> <p>Indicates when the action was performed, and 
         * may influence expiry dates for the order.</p><p>The 
         * attribute is populated because the creation date of the 
         * prescription shall always be known or absent for a 
         * reason.</p> Create Timestamp <p>The date and time on which 
         * the allergy/intolerance record was created.</p> 
         * <p>Identifies timing of allergy/intolerance for sorting and 
         * for audit purposes. Attribute is populated because the 
         * source of the data may not be through the 'record common 
         * observation' interaction.</p> Create Timestamp <p>The date 
         * and time on which the allergy/intolerance record was 
         * created.</p> <p>Identifies timing of allergy/intolerance for 
         * sorting and for audit purposes. Attribute is populated 
         * because the source of the data may not be through the 
         * 'record allergy/intolerance' interaction.</p> Create 
         * Timestamp <p>The date and time on which the adverse reaction 
         * record was created.</p> <p>Identifies timing of adverse 
         * reaction for sorting and for audit purposes. Attribute is 
         * populated because the source of the data may not be through 
         * the 'record common observation' interaction.</p> 
         * Prescription Order Date <p>The calendar date on which the 
         * device was prescribed. This may differ from the date on 
         * which the prescription becomes effective. E.g. A 
         * prescription created today may not be valid to be dispensed 
         * or used for two weeks.</p> <p>Indicates when the action was 
         * performed, and may influence expiry dates for the 
         * order.</p><p>The attribute is populated because the creation 
         * date of the prescription shall always be known or absent for 
         * a reason.</p> <p>Indicates when the action was performed, 
         * and may influence expiry dates for the order.</p><p>The 
         * attribute is populated because the creation date of the 
         * prescription shall always be known or absent for a 
         * reason.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"time"})]
        public PlatformDate Time {
            get { return this.time.Value; }
            set { this.time.Value = value; }
        }

    }

}