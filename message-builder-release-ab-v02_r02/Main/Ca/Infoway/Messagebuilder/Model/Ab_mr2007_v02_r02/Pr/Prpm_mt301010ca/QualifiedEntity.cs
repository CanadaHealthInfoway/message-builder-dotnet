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
namespace Ca.Infoway.Messagebuilder.Model.Ab_mr2007_v02_r02.Pr.Prpm_mt301010ca {
    using Ca.Infoway.Messagebuilder.Annotation;
    using Ca.Infoway.Messagebuilder.Datatype;
    using Ca.Infoway.Messagebuilder.Datatype.Impl;
    using Ca.Infoway.Messagebuilder.Datatype.Lang;
    using Ca.Infoway.Messagebuilder.Domainvalue;
    using Ca.Infoway.Messagebuilder.Model;
    using Ca.Infoway.Messagebuilder.Model.Ab_mr2007_v02_r02.Pr.Merged;
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
    [Hl7PartTypeMappingAttribute(new string[] {"PRPM_MT301010CA.QualifiedEntity"})]
    public class QualifiedEntity : MessagePartBean, Ca.Infoway.Messagebuilder.Model.Ab_mr2007_v02_r02.Pr.Prpm_mt301010ca.IRoleChoice {

        private IList<Ca.Infoway.Messagebuilder.Model.Ab_mr2007_v02_r02.Pr.Merged.Privilege> responsibleForPrivilege;
        private II id;
        private IList<Ca.Infoway.Messagebuilder.Model.Ab_mr2007_v02_r02.Pr.Prpm_mt301010ca.RelatedTo> relatedTo;
        private CV code;
        private IVL<TS, Interval<PlatformDate>> effectiveTime;
        private Ca.Infoway.Messagebuilder.Model.Ab_mr2007_v02_r02.Pr.Merged.PrinicpalPerson_1 qualifiedPrincipalPerson;
        private Ca.Infoway.Messagebuilder.Model.Ab_mr2007_v02_r02.Pr.Prpm_mt301010ca.Organization qualificationGrantingOrganization;

        public QualifiedEntity() {
            this.responsibleForPrivilege = new List<Ca.Infoway.Messagebuilder.Model.Ab_mr2007_v02_r02.Pr.Merged.Privilege>();
            this.id = new IIImpl();
            this.relatedTo = new List<Ca.Infoway.Messagebuilder.Model.Ab_mr2007_v02_r02.Pr.Prpm_mt301010ca.RelatedTo>();
            this.code = new CVImpl();
            this.effectiveTime = new IVLImpl<TS, Interval<PlatformDate>>();
        }
        [Hl7XmlMappingAttribute(new string[] {"responsibleFor/privilege"})]
        public IList<Ca.Infoway.Messagebuilder.Model.Ab_mr2007_v02_r02.Pr.Merged.Privilege> ResponsibleForPrivilege {
            get { return this.responsibleForPrivilege; }
        }

        /**
         * <summary>Expertise or Credentials Role Identifier</summary>
         * 
         * <remarks><p>Unique identifier for the Expertise or 
         * Credential.</p> <p>Mandatory attribute supports the 
         * identification of the healthcare provider credentials</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"id"})]
        public Identifier Id {
            get { return this.id.Value; }
            set { this.id.Value = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"relatedTo"})]
        public IList<Ca.Infoway.Messagebuilder.Model.Ab_mr2007_v02_r02.Pr.Prpm_mt301010ca.RelatedTo> RelatedTo {
            get { return this.relatedTo; }
        }

        /**
         * <summary>Expertise or Credentials Role Type</summary>
         * 
         * <remarks><p>A code for the degree or educational rank that 
         * the credential specifies. May also apply to an Expertise 
         * type.</p> <p>Mandatory attribute supports the identification 
         * of the healthcare provider credentials</p> <p>If Expertise 
         * or Credentials are included in the message, then Role Type 
         * Must Exist.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"code"})]
        public QualifiedRoleType Code {
            get { return (QualifiedRoleType) this.code.Value; }
            set { this.code.Value = value; }
        }

        /**
         * <summary>Expertise or Credentials Role Effective Date</summary>
         * 
         * <remarks><p>The effective date of the provider expertise or 
         * credentials in the healthcare provider role.</p> 
         * <p>Mandatory attribute supports the identification of the 
         * healthcare provider credentials</p> <p>If Expertise or 
         * Credentials are included in the message, then Role Effective 
         * Date Must Exist</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"effectiveTime"})]
        public Interval<PlatformDate> EffectiveTime {
            get { return this.effectiveTime.Value; }
            set { this.effectiveTime.Value = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"qualifiedPrincipalPerson"})]
        public Ca.Infoway.Messagebuilder.Model.Ab_mr2007_v02_r02.Pr.Merged.PrinicpalPerson_1 QualifiedPrincipalPerson {
            get { return this.qualifiedPrincipalPerson; }
            set { this.qualifiedPrincipalPerson = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"qualificationGrantingOrganization"})]
        public Ca.Infoway.Messagebuilder.Model.Ab_mr2007_v02_r02.Pr.Prpm_mt301010ca.Organization QualificationGrantingOrganization {
            get { return this.qualificationGrantingOrganization; }
            set { this.qualificationGrantingOrganization = value; }
        }

    }

}