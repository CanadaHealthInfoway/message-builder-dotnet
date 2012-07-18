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
namespace Ca.Infoway.Messagebuilder.Model.Sk_cerx_v01_r04_3.Pharmacy.Merged {
    using Ca.Infoway.Messagebuilder.Annotation;
    using Ca.Infoway.Messagebuilder.Datatype;
    using Ca.Infoway.Messagebuilder.Datatype.Impl;
    using Ca.Infoway.Messagebuilder.Datatype.Lang;
    using Ca.Infoway.Messagebuilder.Model;


    /**
     * <summary>Protocols</summary>
     * 
     * <remarks>PORX_MT060340CA.SubstanceAdministrationDefinition: 
     * Protocols <p>Documentation of why a prescriber has chosen to 
     * prescribe the drug in the manner they have.</p> <p>Allows 
     * linking to specific guidelines or protocols. Also used to 
     * provide additional detail needed when requesting a special 
     * access drug from Health Canada.</p> 
     * PORX_MT060160CA.SubstanceAdministrationDefinition: Protocols 
     * <p>Documentation of why a prescriber has chosen to prescribe 
     * the drug in the manner they have.</p> <p>Allows linking to 
     * specific guidelines or protocols. Also used to provide 
     * additional detail needed when requesting a 'special access' 
     * drug from Health Canada.</p></remarks>
     */
    [Hl7PartTypeMappingAttribute(new string[] {"PORX_MT010120CA.SubstanceAdministrationDefinition","PORX_MT060160CA.SubstanceAdministrationDefinition","PORX_MT060340CA.SubstanceAdministrationDefinition"})]
    public class Protocols : MessagePartBean {

        private II id;

        public Protocols() {
            this.id = new IIImpl();
        }
        /**
         * <summary>ProtocolIdentifiers</summary>
         * 
         * <remarks>H:Protocol Identifiers <p>A unique identifier for a 
         * specific protocol or guideline which the prescription has 
         * been written in accordance with.</p> <p>Enables the 
         * communication of a reference to a protocol, study or 
         * guideline id, specific to the jurisdiction;</p><p>Allows 
         * providers to reference a protocol/guideline for prescribing 
         * to specific situations. This could also be used for 
         * justification for prescribing a medication from a particular 
         * formulary. E.g., 'Limited Use' medications in Ontario 
         * require physicians to use a code indicating that a patient 
         * is eligible for this particular medication</p> <p>Enables 
         * the communication of a reference to a protocol, study or 
         * guideline id, specific to the jurisdiction;</p><p>Allows 
         * providers to reference a protocol/guideline for prescribing 
         * to specific situations. This could also be used for 
         * justification for prescribing a medication from a particular 
         * formulary. E.g., 'Limited Use' medications in Ontario 
         * require physicians to use a code indicating that a patient 
         * is eligible for this particular medication</p> Protocol 
         * Identifiers <p>A unique identifier for a specific protocol 
         * or guideline which the prescription has been written in 
         * accordance with.</p> <p>Enables the communication of a 
         * reference to a protocol, study or guideline id, specific to 
         * the jurisdiction;</p><p>Allows providers to reference a 
         * protocol/guideline for prescribing to specific situations. 
         * This could also be used for justification for prescribing a 
         * medication from a particular formulary. E.g., 'Limited Use' 
         * medications in Ontario require physicians to use a code 
         * indicating that a patient is eligible for this particular 
         * medication.</p> <p>Enables the communication of a reference 
         * to a protocol, study or guideline id, specific to the 
         * jurisdiction;</p><p>Allows providers to reference a 
         * protocol/guideline for prescribing to specific situations. 
         * This could also be used for justification for prescribing a 
         * medication from a particular formulary. E.g., 'Limited Use' 
         * medications in Ontario require physicians to use a code 
         * indicating that a patient is eligible for this particular 
         * medication.</p> Protocol Identifiers <p>A unique identifier 
         * for a specific protocol or guideline which the prescription 
         * has been written in accordance with.</p> <p>Enables the 
         * communication of a reference to a protocol, study or 
         * guideline id, specific to the jurisdiction;</p><p>Allows 
         * providers to reference a protocol/guideline for prescribing 
         * to specific situations. This could also be used for 
         * justification for prescribing a medication from a particular 
         * formulary. E.g., 'Limited' Use medications in Ontario 
         * require physicians to use a code indicating that a patient 
         * is eligible for this particular medication.</p> <p>Enables 
         * the communication of a reference to a protocol, study or 
         * guideline id, specific to the jurisdiction;</p><p>Allows 
         * providers to reference a protocol/guideline for prescribing 
         * to specific situations. This could also be used for 
         * justification for prescribing a medication from a particular 
         * formulary. E.g., 'Limited' Use medications in Ontario 
         * require physicians to use a code indicating that a patient 
         * is eligible for this particular medication.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"id"})]
        public Identifier Id {
            get { return this.id.Value; }
            set { this.id.Value = value; }
        }

    }

}