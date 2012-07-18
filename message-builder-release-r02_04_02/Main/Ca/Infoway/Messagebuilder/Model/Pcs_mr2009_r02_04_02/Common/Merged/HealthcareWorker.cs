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
 * Last modified: $LastChangedDate: 2012-01-18 21:05:07 -0500 (Wed, 18 Jan 2012) $
 * Revision:      $LastChangedRevision: 3929 $
 */

/* This class was auto-generated by the message builder generator tools. */
namespace Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Common.Merged {
    using Ca.Infoway.Messagebuilder.Annotation;
    using Ca.Infoway.Messagebuilder.Datatype;
    using Ca.Infoway.Messagebuilder.Datatype.Impl;
    using Ca.Infoway.Messagebuilder.Datatype.Lang;
    using Ca.Infoway.Messagebuilder.Domainvalue;
    using Ca.Infoway.Messagebuilder.Model;
    using Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Merged;
    using System;
    using System.Collections.Generic;


    /**
     * <summary>HealthcareWorker</summary>
     * 
     * <remarks>COCT_MT090108CA.AssignedEntity: Healthcare Worker 
     * <p>The person organization assigned to carry out the 
     * associated (linked by a participation) action and/or the 
     * organization under whose authority they are acting.</p> 
     * <p>Critical to tracking responsibility and performing 
     * follow-up. The CMET supports both licensed providers as well 
     * as non-licensed providers such as technicians, 
     * receptionists, etc.</p> <p>All attributes other than the 
     * various identifiers are expected to be retrieved from the 
     * provider registry.</p> COCT_MT090102CA.AssignedEntity: 
     * Healthcare Worker <p>The person assigned to carry out the 
     * associated action (linked by a participation) and/or the 
     * organization/group under whose authority they are 
     * acting.</p> <p>Critical to tracking responsibility and 
     * performing follow-up. The CMET supports both licensed 
     * providers as well as non-licensed providers such as 
     * technicians, receptionists, etc.</p></remarks>
     */
    [Hl7PartTypeMappingAttribute(new string[] {"COCT_MT090102CA.AssignedEntity","COCT_MT090108CA.AssignedEntity","COCT_MT260010CA.AssignedEntity","COCT_MT260020CA.AssignedEntity","COCT_MT260030CA.AssignedEntity"})]
    public class HealthcareWorker : MessagePartBean, Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Iehr.Merged.IParty, Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Common.Coct_mt080100ca.IPerformerChoice, Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Lab.Merged.IRecipientChoice, Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Merged.IChoice, Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Common.Merged.IActingPerson, Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Common.Merged.IAuthorPerson, Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Merged.IRoleChoice, Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Common.Merged.IEntererChoice, Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Merged.IRecipient, Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Common.Coct_mt011001ca.IAssignees, Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Common.Coct_mt911108ca.IActingPerson, Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Pharmacy.Merged.IChangedBy {

        private ST assignedOrganizationName;
        private SET<II, Identifier> healthcareWorkerIdentifier;
        private CV healthcareWorkerType;
        private SET<TEL, TelecommunicationAddress> healthcareWorkerPhoneAndEmails;
        private Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Merged.ActingPerson assignedPerson;
        private II organizationIdentifier;
        private CV organizationType;
        private SET<TEL, TelecommunicationAddress> organizationPhoneAndEmails;

        public HealthcareWorker() {
            this.assignedOrganizationName = new STImpl();
            this.healthcareWorkerIdentifier = new SETImpl<II, Identifier>(typeof(IIImpl));
            this.healthcareWorkerType = new CVImpl();
            this.healthcareWorkerPhoneAndEmails = new SETImpl<TEL, TelecommunicationAddress>(typeof(TELImpl));
            this.organizationIdentifier = new IIImpl();
            this.organizationType = new CVImpl();
            this.organizationPhoneAndEmails = new SETImpl<TEL, TelecommunicationAddress>(typeof(TELImpl));
        }
        /**
         * <summary>C:Knowledgebase Vendor Name</summary>
         * 
         * <remarks><p>The name of a clinical knowledgebase vendor 
         * organization.</p> <p>Allows a knowledgebase vendor to be 
         * referenced by name.</p><p>The attribute is mandatory because 
         * it is the only information collected about a knowledgebase 
         * vendor.</p> <p>Allows a knowledgebase vendor to be 
         * referenced by name.</p><p>The attribute is mandatory because 
         * it is the only information collected about a knowledgebase 
         * vendor.</p> H: Organization Name <p>Identifies the name of 
         * the organization</p> <p>Allows for human recognition of the 
         * organization as well as confirmation of the identifier. As a 
         * result, the attribute is mandatory.</p> C:Knowledgebase 
         * Vendor Name E: Organization Name <p>Identifies the name of 
         * the organization</p> <p>Allows for human recognition of the 
         * organization as well as confirmation of the identifier. As a 
         * result, the attribute is mandatory.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"assignedOrganization/name","representedOrganization/name"})]
        [Hl7MapByPartType(Name="assignedOrganization", Type="COCT_MT260010CA.Organization")]
        [Hl7MapByPartType(Name="assignedOrganization", Type="COCT_MT260020CA.Organization")]
        [Hl7MapByPartType(Name="assignedOrganization", Type="COCT_MT260030CA.Organization")]
        [Hl7MapByPartType(Name="representedOrganization", Type="COCT_MT090102CA.Organization")]
        [Hl7MapByPartType(Name="representedOrganization", Type="COCT_MT090108CA.Organization")]
        public String AssignedOrganizationName {
            get { return this.assignedOrganizationName.Value; }
            set { this.assignedOrganizationName.Value = value; }
        }

        /**
         * <summary>HealthcareWorkerIdentifier</summary>
         * 
         * <remarks>A:Healthcare Worker Identifier <p>Unique identifier 
         * the person involved in the action.</p> <p>Allows unique 
         * identification of the person which can be critical for 
         * authentication, permissions, drill-down and traceability and 
         * is therefore mandatory.</p> A: Healthcare Worker Identifier 
         * <p>Unique identifier the person involved in the action.</p> 
         * <p>Allows unique identification of the person which can be 
         * critical for authentication, permissions, drill-down and 
         * traceability and is therefore mandatory.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"id"})]
        public ICollection<Identifier> HealthcareWorkerIdentifier {
            get { return this.healthcareWorkerIdentifier.RawSet(); }
        }

        /**
         * <summary>HealthcareWorkerType</summary>
         * 
         * <remarks>B: Healthcare Worker Type <p>Indicates the 
         * &quot;kind&quot; of healthcare participant, such as 
         * &quot;physician&quot;, &quot;dentist&quot;, &quot;lab 
         * technician&quot;, &quot;receptionist&quot;, etc.</p> 
         * <p>Provides context around the actions of the participant 
         * and is therefore mandatory.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"code"})]
        public HealthcareProviderRoleType HealthcareWorkerType {
            get { return (HealthcareProviderRoleType) this.healthcareWorkerType.Value; }
            set { this.healthcareWorkerType.Value = value; }
        }

        /**
         * <summary>HealthcareWorkerPhoneAndEmails</summary>
         * 
         * <remarks>E: Healthcare Worker Phone and Emails <p>Indicates 
         * phone and/or e-mail addresses at which the healthcare worker 
         * can be reached.</p> <p>This is the most commonly used piece 
         * of contact information and is returned here to avoid 
         * unnecessary queries of the provider registry.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"telecom"})]
        public ICollection<TelecommunicationAddress> HealthcareWorkerPhoneAndEmails {
            get { return this.healthcareWorkerPhoneAndEmails.RawSet(); }
        }

        [Hl7XmlMappingAttribute(new string[] {"assignedPerson"})]
        public Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Merged.ActingPerson AssignedPerson {
            get { return this.assignedPerson; }
            set { this.assignedPerson = value; }
        }

        /**
         * <summary>OrganizationIdentifier</summary>
         * 
         * <remarks>D: Organization identifier <p>A unique identifier 
         * for the organization</p> <p>Allows the organization to be 
         * referenced when determining privileges and for drill-downs 
         * to retrieve additional information. Because of its 
         * importance, the attribute is mandatory.</p> F: Organization 
         * identifier <p>A unique identifier for the organization</p> 
         * <p>Allows the organization to be referenced when determining 
         * privileges and for drill-downs to retrieve additional 
         * information. Because of its importance, the attribute is 
         * mandatory.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"representedOrganization/id"})]
        public Identifier OrganizationIdentifier {
            get { return this.organizationIdentifier.Value; }
            set { this.organizationIdentifier.Value = value; }
        }

        /**
         * <summary>OrganizationType</summary>
         * 
         * <remarks>G: Organization Type <p>Identifies the type of 
         * organization on whose behalf the action was taken. E.g. 
         * Pharmacy, Clinic, Hospital, etc.</p> <p>Provides context to 
         * the action and is therefore mandatory.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"representedOrganization/assignedOrganization/code"})]
        public HealthcareOrganizationRoleType OrganizationType {
            get { return (HealthcareOrganizationRoleType) this.organizationType.Value; }
            set { this.organizationType.Value = value; }
        }

        /**
         * <summary>OrganizationPhoneAndEmails</summary>
         * 
         * <remarks>I: Organization Phone and Emails <p>Identifies 
         * contact information for the responsible organization.</p> 
         * <p>This is the most commonly used contact information and is 
         * returned to avoid unnecessary queries against the client 
         * registry.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"representedOrganization/assignedOrganization/telecom"})]
        public ICollection<TelecommunicationAddress> OrganizationPhoneAndEmails {
            get { return this.organizationPhoneAndEmails.RawSet(); }
        }

    }

}