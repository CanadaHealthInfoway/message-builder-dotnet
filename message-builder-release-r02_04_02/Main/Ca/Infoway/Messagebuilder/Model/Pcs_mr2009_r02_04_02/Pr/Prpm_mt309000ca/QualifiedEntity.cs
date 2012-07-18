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
 * Last modified: $LastChangedDate: 2012-01-18 21:12:57 -0500 (Wed, 18 Jan 2012) $
 * Revision:      $LastChangedRevision: 4021 $
 */

/* This class was auto-generated by the message builder generator tools. */
namespace Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Pr.Prpm_mt309000ca {
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
     * <summary>Qualified Entity</summary>
     * 
     * <remarks><p>This role describes specific qualifications that 
     * may be held the provider as a result of training or 
     * experience, but having no legal force. Example: a medical 
     * degree or diploma. The current model does not include role 
     * attributes such as name, addr and telecom because there are 
     * no known use cases in this domain where this role is 
     * contactable.</p> <p>Roleclass required to provide additional 
     * information for the person responsible for providing 
     * healthcare services</p></remarks>
     */
    [Hl7PartTypeMappingAttribute(new string[] {"PRPM_MT309000CA.QualifiedEntity"})]
    public class QualifiedEntity : MessagePartBean, Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Pr.Prpm_mt309000ca.IRoleChoice {

        private IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Pr.Merged.Privilege> responsibleForPrivilege;
        private SET<II, Identifier> expertiseOrCredentialsRoleIdentifier;
        private IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Pr.Prpm_mt309000ca.IRoleChoice> relatedToRoleChoice;
        private CV expertiseOrCredentialsRoleType;
        private IVL<TS, Interval<PlatformDate>> expertiseOrCredentialsRoleEffectiveDate;
        private Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Pr.Prpm_mt309000ca.PrinicpalPerson qualifiedPrincipalPerson;
        private Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Pr.Prpm_mt309000ca.Organization qualificationGrantingOrganization;

        public QualifiedEntity() {
            this.responsibleForPrivilege = new List<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Pr.Merged.Privilege>();
            this.expertiseOrCredentialsRoleIdentifier = new SETImpl<II, Identifier>(typeof(IIImpl));
            this.relatedToRoleChoice = new List<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Pr.Prpm_mt309000ca.IRoleChoice>();
            this.expertiseOrCredentialsRoleType = new CVImpl();
            this.expertiseOrCredentialsRoleEffectiveDate = new IVLImpl<TS, Interval<PlatformDate>>();
        }
        [Hl7XmlMappingAttribute(new string[] {"responsibleFor/privilege"})]
        public IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Pr.Merged.Privilege> ResponsibleForPrivilege {
            get { return this.responsibleForPrivilege; }
        }

        /**
         * <summary>Expertise or Credentials Role Identifier</summary>
         * 
         * <remarks><p>Unique identifier for the Expertise or 
         * Credential.</p> <p>Required attribute supports the 
         * identification of the healthcare provider credentials</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"id"})]
        public ICollection<Identifier> ExpertiseOrCredentialsRoleIdentifier {
            get { return this.expertiseOrCredentialsRoleIdentifier.RawSet(); }
        }

        [Hl7XmlMappingAttribute(new string[] {"relatedTo/roleChoice"})]
        public IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Pr.Prpm_mt309000ca.IRoleChoice> RelatedToRoleChoice {
            get { return this.relatedToRoleChoice; }
        }

        /**
         * <summary>Expertise or Credentials Role Type</summary>
         * 
         * <remarks><p>A code for the degree or educational rank that 
         * the credential specifies. May also apply to an Expertise 
         * type.</p> <p>Required attribute supports the identification 
         * of the healthcare provider credentials</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"code"})]
        public QualifiedRoleType ExpertiseOrCredentialsRoleType {
            get { return (QualifiedRoleType) this.expertiseOrCredentialsRoleType.Value; }
            set { this.expertiseOrCredentialsRoleType.Value = value; }
        }

        /**
         * <summary>Expertise or Credentials Role Effective Date</summary>
         * 
         * <remarks><p>The effective date of the provider expertise or 
         * credentials in the healthcare provider role.</p> <p>Required 
         * attribute supports the identification of the healthcare 
         * provider credentials</p> <p>If Expertise or Credentials are 
         * included in the message, then Role Effective Date Must 
         * Exist</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"effectiveTime"})]
        public Interval<PlatformDate> ExpertiseOrCredentialsRoleEffectiveDate {
            get { return this.expertiseOrCredentialsRoleEffectiveDate.Value; }
            set { this.expertiseOrCredentialsRoleEffectiveDate.Value = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"qualifiedPrincipalPerson"})]
        public Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Pr.Prpm_mt309000ca.PrinicpalPerson QualifiedPrincipalPerson {
            get { return this.qualifiedPrincipalPerson; }
            set { this.qualifiedPrincipalPerson = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"qualificationGrantingOrganization"})]
        public Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Pr.Prpm_mt309000ca.Organization QualificationGrantingOrganization {
            get { return this.qualificationGrantingOrganization; }
            set { this.qualificationGrantingOrganization = value; }
        }

    }

}