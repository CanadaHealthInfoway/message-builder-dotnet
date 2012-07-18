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
 * Last modified: $LastChangedDate: 2012-01-18 21:08:07 -0500 (Wed, 18 Jan 2012) $
 * Revision:      $LastChangedRevision: 3969 $
 */

/* This class was auto-generated by the message builder generator tools. */
namespace Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Immunization.Poiz_mt030060ca {
    using Ca.Infoway.Messagebuilder.Annotation;
    using Ca.Infoway.Messagebuilder.Datatype;
    using Ca.Infoway.Messagebuilder.Datatype.Impl;
    using Ca.Infoway.Messagebuilder.Domainvalue;
    using Ca.Infoway.Messagebuilder.Model;


    /**
     * <summary><p>Identifies the source of the immunization 
     * information as someone who has a personal relationship with 
     * the patient.</p></summary>
     * 
     * <remarks><p>Supplies contextual information about the source 
     * of the immunization report.</p></remarks>
     */
    [Hl7PartTypeMappingAttribute(new string[] {"POIZ_MT030060CA.PersonalRelationshipRole"})]
    public class PersonalRelationshipRole : MessagePartBean, Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Immunization.Merged.IInformationSourceChoice {

        private CV personalRelationshipType;

        public PersonalRelationshipRole() {
            this.personalRelationshipType = new CVImpl();
        }
        /**
         * <summary>Personal Relationship Type</summary>
         * 
         * <remarks><p>Describes the personal relationship between the 
         * information source and the patient.</p> <p>Useful for 
         * categorizing sources of immunization information. As a 
         * result, this attribute is populated.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"code"})]
        public PersonalRelationshipRoleType PersonalRelationshipType {
            get { return (PersonalRelationshipRoleType) this.personalRelationshipType.Value; }
            set { this.personalRelationshipType.Value = value; }
        }

    }

}