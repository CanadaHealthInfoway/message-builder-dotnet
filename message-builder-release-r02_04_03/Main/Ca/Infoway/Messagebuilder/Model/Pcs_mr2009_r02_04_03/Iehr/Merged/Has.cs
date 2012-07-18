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
namespace Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Iehr.Merged {
    using Ca.Infoway.Messagebuilder;
    using Ca.Infoway.Messagebuilder.Annotation;
    using Ca.Infoway.Messagebuilder.Datatype;
    using Ca.Infoway.Messagebuilder.Datatype.Impl;
    using Ca.Infoway.Messagebuilder.Datatype.Lang;
    using Ca.Infoway.Messagebuilder.Domainvalue;
    using Ca.Infoway.Messagebuilder.Model;
    using System.Collections.Generic;


    /**
     * <summary>Has</summary>
     * 
     * <remarks>REPC_MT500004CA.Participant: *has <p>Identifies the 
     * participants associated with the particular location.</p> 
     * <p>Cardinality is constrained to 200 rather than 1000 
     * because it is exactly equal to the sum of the number of 
     * potential patients and providers</p> <p>Important for 
     * providing context for the encounter. The element is 
     * mandatory because there whole purpose of having a 
     * participant grouping is to have participants.</p> 
     * REPC_MT500002CA.Participant: *has <p>Identifies the 
     * participants associated with the particular location.</p> 
     * <p>Cardinality is constrained to 200 rather than 1000 
     * because it is exactly equal to the sum of the number of 
     * potential patients and providers</p> <p>Important for 
     * providing context for the encounter. The element is 
     * mandatory because there whole purpose of having a 
     * participant grouping is to have participants.</p> 
     * REPC_MT500001CA.Participant: *has <p>Identifies the 
     * participants associated with the particular location.</p> 
     * <p>Cardinality is constrained to 200 rather than 1000 
     * because it is exactly equal to the sum of the number of 
     * potential patients and providers</p> <p>Important for 
     * providing context for the encounter. The element is 
     * mandatory because there whole purpose of having a 
     * participant grouping is to have participants.</p></remarks>
     */
    [Hl7PartTypeMappingAttribute(new string[] {"REPC_MT500001CA.Participant","REPC_MT500002CA.Participant","REPC_MT500004CA.Participant"})]
    public class Has : MessagePartBean {

        private CV modeCode;
        private II roleId;
        private SET<CV, Code> roleConfidentialityCode;

        public Has() {
            this.modeCode = new CVImpl();
            this.roleId = new IIImpl();
            this.roleConfidentialityCode = new SETImpl<CV, Code>(typeof(CVImpl));
        }
        /**
         * <summary>ParticipationMechanism</summary>
         * 
         * <remarks>B:Participation Mechanism <p>Identifies how the 
         * patient and/or provider(s) participated in the encounter (in 
         * person, by phone, by videoconference, etc.)</p> 
         * <p>Understanding how each participant was involved in the 
         * encounter gives context to the encounter, particularly for 
         * telehealth.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"modeCode"})]
        public ParticipationMode ModeCode {
            get { return (ParticipationMode) this.modeCode.Value; }
            set { this.modeCode.Value = value; }
        }

        /**
         * <summary>ParticipantIdReference</summary>
         * 
         * <remarks>A: Participant Id Reference <p>The unique 
         * identifier of a patient or provider who was involved in the 
         * encounter at the identified location. This will reference 
         * one of the patient or provider ids already associated with 
         * the Care Composition.</p> <p>Links the participant to the 
         * location where they were involved in the encounter. The 
         * element is mandatory because there's no point listing 
         * participants unless they can be explicitly identified.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"role/id"})]
        public Identifier RoleId {
            get { return this.roleId.Value; }
            set { this.roleId.Value = value; }
        }

        /**
         * <summary>ParticipantConfidentialities</summary>
         * 
         * <remarks>C: Participant Confidentialities <p>Identifies the 
         * confidentiality level associated with the encounter for this 
         * specific participant.</p> <p>Provides individual 
         * participants in a group encounter with complete control over 
         * the confidentiality of their participation in that 
         * encounter.</p><p>The attribute is optional because not all 
         * systems will support masking.</p> <p>Provides individual 
         * participants in a group encounter with complete control over 
         * the confidentiality of their participation in that 
         * encounter.</p><p>The attribute is optional because not all 
         * systems will support masking.</p> <p>This element should 
         * only be specified if the id is referencing a patient, not a 
         * provider.</p><p>Stricter confidentiality asserted at the 
         * overall encounter level overrides looser confidentiality 
         * asserted at the participant level.</p> <p>This element 
         * should only be specified if the id is referencing a patient, 
         * not a provider.</p><p>Stricter confidentiality asserted at 
         * the overall encounter level overrides looser confidentiality 
         * asserted at the participant level.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"role/confidentialityCode"})]
        public ICollection<x_VeryBasicConfidentialityKind> RoleConfidentialityCode {
            get { return this.roleConfidentialityCode.RawSet<x_VeryBasicConfidentialityKind>(); }
        }

    }

}