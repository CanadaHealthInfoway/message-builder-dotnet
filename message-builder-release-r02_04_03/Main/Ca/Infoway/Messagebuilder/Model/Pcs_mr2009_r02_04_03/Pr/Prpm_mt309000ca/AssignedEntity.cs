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
namespace Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Pr.Prpm_mt309000ca {
    using Ca.Infoway.Messagebuilder.Annotation;
    using Ca.Infoway.Messagebuilder.Datatype;
    using Ca.Infoway.Messagebuilder.Datatype.Impl;
    using Ca.Infoway.Messagebuilder.Datatype.Lang;
    using Ca.Infoway.Messagebuilder.Domainvalue;
    using Ca.Infoway.Messagebuilder.Model;
    using Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Pr.Merged;
    using System.Collections.Generic;


    /**
     * <summary>Assigned Entity</summary>
     * 
     * <remarks><p>The role class, assigned entity, captures the 
     * critical information of the provider playing the role of 
     * interest. This includes an identifier for the role, mailing 
     * address, phone number, and the time within which the role is 
     * played (may be open ended). The scooping organization, which 
     * may be omitted if not needed, provides the organizational 
     * context for the entity that actually plays the role. For 
     * example, the role scoper will normally be the party that 
     * assigns the identifier for the role.</p> <p>Roleclass 
     * required to provide additional information for the person 
     * responsible for providing healthcare services within a 
     * specific healthcare setting</p></remarks>
     */
    [Hl7PartTypeMappingAttribute(new string[] {"PRPM_MT309000CA.AssignedEntity"})]
    public class AssignedEntity : MessagePartBean, Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Pr.Prpm_mt309000ca.IRoleChoice {

        private IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Pr.Merged.Privilege> responsibleForPrivilege;
        private SET<II, Identifier> id;
        private IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Pr.Prpm_mt309000ca.IRoleChoice> relatedToRoleChoice;
        private CV code;
        private LIST<PN, PersonName> name;
        private Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Pr.Prpm_mt309000ca.PrinicpalPerson assignedPrincipalPerson;
        private Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Pr.Prpm_mt309000ca.Organization representedOrganization;
        private IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Pr.Merged.ActDefinitionOrEventName_2> performanceActDefinitionOrEvent;

        public AssignedEntity() {
            this.responsibleForPrivilege = new List<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Pr.Merged.Privilege>();
            this.id = new SETImpl<II, Identifier>(typeof(IIImpl));
            this.relatedToRoleChoice = new List<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Pr.Prpm_mt309000ca.IRoleChoice>();
            this.code = new CVImpl();
            this.name = new LISTImpl<PN, PersonName>(typeof(PNImpl));
            this.performanceActDefinitionOrEvent = new List<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Pr.Merged.ActDefinitionOrEventName_2>();
        }
        [Hl7XmlMappingAttribute(new string[] {"responsibleFor/privilege"})]
        public IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Pr.Merged.Privilege> ResponsibleForPrivilege {
            get { return this.responsibleForPrivilege; }
        }

        /**
         * <summary>Functional Role Identifier</summary>
         * 
         * <remarks><p>Identifies specific functional role that a 
         * provider may play within an organization.</p> <p>Required 
         * attribute supports the identification of the healthcare 
         * provider</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"id"})]
        public ICollection<Identifier> Id {
            get { return this.id.RawSet(); }
        }

        [Hl7XmlMappingAttribute(new string[] {"relatedTo/roleChoice"})]
        public IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Pr.Prpm_mt309000ca.IRoleChoice> RelatedToRoleChoice {
            get { return this.relatedToRoleChoice; }
        }

        /**
         * <summary>Functional Role Type</summary>
         * 
         * <remarks><p>The code identifying the specific functional 
         * role.</p> <p>Mandatory attribute supports the identification 
         * of the healthcare provider</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"code"})]
        public AssignedRoleType Code {
            get { return (AssignedRoleType) this.code.Value; }
            set { this.code.Value = value; }
        }

        /**
         * <summary>Functional Role Name</summary>
         * 
         * <remarks><p>The providers name pertaining to the specific 
         * functional role.</p> <p>Required attribute supports the 
         * identification of the healthcare provider</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"name"})]
        public IList<PersonName> Name {
            get { return this.name.RawList(); }
        }

        [Hl7XmlMappingAttribute(new string[] {"assignedPrincipalPerson"})]
        public Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Pr.Prpm_mt309000ca.PrinicpalPerson AssignedPrincipalPerson {
            get { return this.assignedPrincipalPerson; }
            set { this.assignedPrincipalPerson = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"representedOrganization"})]
        public Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Pr.Prpm_mt309000ca.Organization RepresentedOrganization {
            get { return this.representedOrganization; }
            set { this.representedOrganization = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"performance/actDefinitionOrEvent"})]
        public IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Pr.Merged.ActDefinitionOrEventName_2> PerformanceActDefinitionOrEvent {
            get { return this.performanceActDefinitionOrEvent; }
        }

    }

}