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
 * Last modified: $LastChangedDate: 2012-01-18 21:12:32 -0500 (Wed, 18 Jan 2012) $
 * Revision:      $LastChangedRevision: 4016 $
 */

/* This class was auto-generated by the message builder generator tools. */
namespace Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Pr.Prpm_mt303010ca {
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
     * <summary>Healthcare Provider</summary>
     * 
     * <remarks><p>This roles the specific Healthcare provider role 
     * such as a Physician, Nurse or other type of caregivers.</p> 
     * <p>Roleclass required to support the identification of 
     * person responsible for providing healthcare services</p></remarks>
     */
    [Hl7PartTypeMappingAttribute(new string[] {"PRPM_MT303010CA.HealthCareProvider"})]
    public class HealthcareProvider : MessagePartBean, Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Merged.IChoice, Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Pr.Prpm_mt303010ca.IRoleChoice {

        private IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Pr.Merged.Privilege> responsibleForPrivilege;
        private II healthcareProviderRoleIdentification;
        private IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Pr.Prpm_mt303010ca.RelatedTo> relatedTo;
        private CV healthcareProviderRoleType;
        private LIST<PN, PersonName> healthcareProviderRoleName;
        private LIST<AD, PostalAddress> healthcareProviderRoleAddress;
        private LIST<TEL, TelecommunicationAddress> healthcareProviderRoleTelecom;
        private CS healthcareProviderRoleStatusCode;
        private IVL<TS, Interval<PlatformDate>> healthcareProviderRoleEffectiveDate;
        private Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Pr.Merged.PrinicpalPerson_1 healthCarePrincipalPerson;
        private Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Pr.Prpm_mt303010ca.Organization issuingOrganization;

        public HealthcareProvider() {
            this.responsibleForPrivilege = new List<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Pr.Merged.Privilege>();
            this.healthcareProviderRoleIdentification = new IIImpl();
            this.relatedTo = new List<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Pr.Prpm_mt303010ca.RelatedTo>();
            this.healthcareProviderRoleType = new CVImpl();
            this.healthcareProviderRoleName = new LISTImpl<PN, PersonName>(typeof(PNImpl));
            this.healthcareProviderRoleAddress = new LISTImpl<AD, PostalAddress>(typeof(ADImpl));
            this.healthcareProviderRoleTelecom = new LISTImpl<TEL, TelecommunicationAddress>(typeof(TELImpl));
            this.healthcareProviderRoleStatusCode = new CSImpl();
            this.healthcareProviderRoleEffectiveDate = new IVLImpl<TS, Interval<PlatformDate>>();
        }
        [Hl7XmlMappingAttribute(new string[] {"responsibleFor/privilege"})]
        public IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Pr.Merged.Privilege> ResponsibleForPrivilege {
            get { return this.responsibleForPrivilege; }
        }

        /**
         * <summary>Healthcare Provider Role Identification</summary>
         * 
         * <remarks><p>A unique identifier for a provider in a specific 
         * healthcare role.</p> <p>Mandatory attribute supports the 
         * identification of the healthcare provider</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"id"})]
        public Identifier HealthcareProviderRoleIdentification {
            get { return this.healthcareProviderRoleIdentification.Value; }
            set { this.healthcareProviderRoleIdentification.Value = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"relatedTo"})]
        public IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Pr.Prpm_mt303010ca.RelatedTo> RelatedTo {
            get { return this.relatedTo; }
        }

        /**
         * <summary>Healthcare Provider Role Type</summary>
         * 
         * <remarks><p>The code identifying the specific healthcare 
         * provider role.</p> <p>Mandatory attribute supports the 
         * identification of the healthcare provider</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"code"})]
        public HealthcareProviderRoleType HealthcareProviderRoleType {
            get { return (HealthcareProviderRoleType) this.healthcareProviderRoleType.Value; }
            set { this.healthcareProviderRoleType.Value = value; }
        }

        /**
         * <summary>Healthcare Provider Role Name</summary>
         * 
         * <remarks><p>The providers name pertaining to the specific 
         * healthcare provider role.</p> <p>Required attribute supports 
         * the identification of the healthcare provider</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"name"})]
        public IList<PersonName> HealthcareProviderRoleName {
            get { return this.healthcareProviderRoleName.RawList(); }
        }

        /**
         * <summary>Healthcare Provider Role Address</summary>
         * 
         * <remarks><p>The address for the provider when playing the 
         * role of healthcare provider.</p> <p>Required attribute 
         * supports the identification of the healthcare provider</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"addr"})]
        public IList<PostalAddress> HealthcareProviderRoleAddress {
            get { return this.healthcareProviderRoleAddress.RawList(); }
        }

        /**
         * <summary>Healthcare Provider Role Telecom</summary>
         * 
         * <remarks><p>The telecom for the provider when playing the 
         * role of healthcare provider.</p> <p>Required attribute 
         * supports the identification of the healthcare provider</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"telecom"})]
        public IList<TelecommunicationAddress> HealthcareProviderRoleTelecom {
            get { return this.healthcareProviderRoleTelecom.RawList(); }
        }

        /**
         * <summary>Healthcare Provider Role Status Code</summary>
         * 
         * <remarks><p>The status of the provider in the healthcare 
         * provider role i.e. Active</p> <p>Required attribute supports 
         * the identification of the healthcare provider</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"statusCode"})]
        public RoleStatus HealthcareProviderRoleStatusCode {
            get { return (RoleStatus) this.healthcareProviderRoleStatusCode.Value; }
            set { this.healthcareProviderRoleStatusCode.Value = value; }
        }

        /**
         * <summary>Healthcare Provider Role Effective Date</summary>
         * 
         * <remarks><p>The effective date of the provider in the 
         * healthcare provider role.</p> <p>Mandatory attribute 
         * supports the identification of the healthcare provider</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"effectiveTime"})]
        public Interval<PlatformDate> HealthcareProviderRoleEffectiveDate {
            get { return this.healthcareProviderRoleEffectiveDate.Value; }
            set { this.healthcareProviderRoleEffectiveDate.Value = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"healthCarePrincipalPerson"})]
        public Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Pr.Merged.PrinicpalPerson_1 HealthCarePrincipalPerson {
            get { return this.healthCarePrincipalPerson; }
            set { this.healthCarePrincipalPerson = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"issuingOrganization"})]
        public Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Pr.Prpm_mt303010ca.Organization IssuingOrganization {
            get { return this.issuingOrganization; }
            set { this.issuingOrganization = value; }
        }

    }

}