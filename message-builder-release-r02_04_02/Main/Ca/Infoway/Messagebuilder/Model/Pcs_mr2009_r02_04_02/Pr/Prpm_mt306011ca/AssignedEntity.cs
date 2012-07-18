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
 * Last modified: $LastChangedDate: 2012-01-18 21:12:42 -0500 (Wed, 18 Jan 2012) $
 * Revision:      $LastChangedRevision: 4018 $
 */

/* This class was auto-generated by the message builder generator tools. */
namespace Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Pr.Prpm_mt306011ca {
    using Ca.Infoway.Messagebuilder.Annotation;
    using Ca.Infoway.Messagebuilder.Datatype;
    using Ca.Infoway.Messagebuilder.Datatype.Impl;
    using Ca.Infoway.Messagebuilder.Datatype.Lang;
    using Ca.Infoway.Messagebuilder.Domainvalue;
    using Ca.Infoway.Messagebuilder.Model;
    using Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Pr.Merged;
    using System;
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
    [Hl7PartTypeMappingAttribute(new string[] {"PRPM_MT306011CA.AssignedEntity"})]
    public class AssignedEntity : MessagePartBean, Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Pr.Prpm_mt306011ca.IRoleChoice {

        private IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Pr.Merged.Privilege> responsibleForPrivilege;
        private SET<II, Identifier> functionalRoleIdentifier;
        private IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Pr.Prpm_mt306011ca.RelatedTo> relatedTo;
        private CV functionalRoleType;
        private LIST<PN, PersonName> functionalRoleName;
        private LIST<AD, PostalAddress> functionalRoleAddress;
        private LIST<TEL, TelecommunicationAddress> functionalRoleTelecom;
        private CS functionalRoleStatusCode;
        private IVL<TS, Interval<PlatformDate>> functionalRoleEffectiveDate;
        private Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Pr.Merged.PrinicpalPerson_2 assignedPrincipalPerson;
        private Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Pr.Prpm_mt306011ca.Organization representedOrganization;
        private IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Pr.Merged.ActDefinitionOrEventName_2> performanceActDefinitionOrEvent;

        public AssignedEntity() {
            this.responsibleForPrivilege = new List<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Pr.Merged.Privilege>();
            this.functionalRoleIdentifier = new SETImpl<II, Identifier>(typeof(IIImpl));
            this.relatedTo = new List<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Pr.Prpm_mt306011ca.RelatedTo>();
            this.functionalRoleType = new CVImpl();
            this.functionalRoleName = new LISTImpl<PN, PersonName>(typeof(PNImpl));
            this.functionalRoleAddress = new LISTImpl<AD, PostalAddress>(typeof(ADImpl));
            this.functionalRoleTelecom = new LISTImpl<TEL, TelecommunicationAddress>(typeof(TELImpl));
            this.functionalRoleStatusCode = new CSImpl();
            this.functionalRoleEffectiveDate = new IVLImpl<TS, Interval<PlatformDate>>();
            this.performanceActDefinitionOrEvent = new List<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Pr.Merged.ActDefinitionOrEventName_2>();
        }
        [Hl7XmlMappingAttribute(new string[] {"responsibleFor/privilege"})]
        public IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Pr.Merged.Privilege> ResponsibleForPrivilege {
            get { return this.responsibleForPrivilege; }
        }

        /**
         * <summary>Functional Role Identifier</summary>
         * 
         * <remarks><p>Identifies specific functional role that a 
         * provider may play within an organization.</p> <p>Populated 
         * attribute supports the identification of the healthcare 
         * provider</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"id"})]
        public ICollection<Identifier> FunctionalRoleIdentifier {
            get { return this.functionalRoleIdentifier.RawSet(); }
        }

        [Hl7XmlMappingAttribute(new string[] {"relatedTo"})]
        public IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Pr.Prpm_mt306011ca.RelatedTo> RelatedTo {
            get { return this.relatedTo; }
        }

        /**
         * <summary>Functional Role Type</summary>
         * 
         * <remarks><p>The code identifying the specific functional 
         * role.</p> <p>Mandatory attribute supports the identification 
         * of the healthcare provider</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"code"})]
        public AssignedRoleType FunctionalRoleType {
            get { return (AssignedRoleType) this.functionalRoleType.Value; }
            set { this.functionalRoleType.Value = value; }
        }

        /**
         * <summary>Functional Role Name</summary>
         * 
         * <remarks><p>The providers name pertaining to the specific 
         * functional role.</p> <p>Required attribute supports the 
         * identification of the healthcare provider</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"name"})]
        public IList<PersonName> FunctionalRoleName {
            get { return this.functionalRoleName.RawList(); }
        }

        /**
         * <summary>Functional Role Address</summary>
         * 
         * <remarks><p>Address of the provider when playing the 
         * functional role.</p> <p>Required attribute supports the 
         * identification of the healthcare provider</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"addr"})]
        public IList<PostalAddress> FunctionalRoleAddress {
            get { return this.functionalRoleAddress.RawList(); }
        }

        /**
         * <summary>Functional Role Telecom</summary>
         * 
         * <remarks><p>Telecom of the provider when playing the 
         * functional role.</p> <p>Required attribute supports the 
         * identification of the healthcare provider</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"telecom"})]
        public IList<TelecommunicationAddress> FunctionalRoleTelecom {
            get { return this.functionalRoleTelecom.RawList(); }
        }

        /**
         * <summary>Functional Role Status Code</summary>
         * 
         * <remarks><p>The status of the provider in the functional 
         * role i.e. Active</p> <p>Required attribute supports the 
         * identification of the healthcare provider</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"statusCode"})]
        public RoleStatus FunctionalRoleStatusCode {
            get { return (RoleStatus) this.functionalRoleStatusCode.Value; }
            set { this.functionalRoleStatusCode.Value = value; }
        }

        /**
         * <summary>Functional Role Effective Date</summary>
         * 
         * <remarks><p>The effective date of the provider in the 
         * functional role.</p> <p>Required attribute supports the 
         * identification of the healthcare provider</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"effectiveTime"})]
        public Interval<PlatformDate> FunctionalRoleEffectiveDate {
            get { return this.functionalRoleEffectiveDate.Value; }
            set { this.functionalRoleEffectiveDate.Value = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"assignedPrincipalPerson"})]
        public Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Pr.Merged.PrinicpalPerson_2 AssignedPrincipalPerson {
            get { return this.assignedPrincipalPerson; }
            set { this.assignedPrincipalPerson = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"representedOrganization"})]
        public Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Pr.Prpm_mt306011ca.Organization RepresentedOrganization {
            get { return this.representedOrganization; }
            set { this.representedOrganization = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"performance/actDefinitionOrEvent"})]
        public IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Pr.Merged.ActDefinitionOrEventName_2> PerformanceActDefinitionOrEvent {
            get { return this.performanceActDefinitionOrEvent; }
        }

    }

}