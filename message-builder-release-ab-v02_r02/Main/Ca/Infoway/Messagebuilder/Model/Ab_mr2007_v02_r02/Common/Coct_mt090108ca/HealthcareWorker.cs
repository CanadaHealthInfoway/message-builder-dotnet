/**
 * Copyright 2013 Canada Health Infoway, Inc.
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
 * Last modified: $LastChangedDate: 2011-05-04 15:47:15 -0400 (Wed, 04 May 2011) $
 * Revision:      $LastChangedRevision: 2623 $
 */
/* This class was auto-generated by the message builder generator tools. */
namespace Ca.Infoway.Messagebuilder.Model.Ab_mr2007_v02_r02.Common.Coct_mt090108ca {
    using Ca.Infoway.Messagebuilder.Annotation;
    using Ca.Infoway.Messagebuilder.Datatype;
    using Ca.Infoway.Messagebuilder.Datatype.Impl;
    using Ca.Infoway.Messagebuilder.Datatype.Lang;
    using Ca.Infoway.Messagebuilder.Domainvalue;
    using Ca.Infoway.Messagebuilder.Model;
    using System;
    using System.Collections.Generic;


    /**
     * <summary>Business Name: Healthcare Worker</summary>
     * 
     * <p>The person organization assigned to carry out the 
     * associated (linked by a participation) action and/or the 
     * organization under whose authority they are acting.</p> 
     * <p>Critical to tracking responsibility and performing 
     * follow-up. The CMET supports both licensed providers as well 
     * as non-licensed providers such as technicians, 
     * receptionists, etc.</p> <p>All attributes other than the 
     * various identifiers are expected to be retrieved from the 
     * provider registry.</p>
     */
    [Hl7PartTypeMappingAttribute(new string[] {"COCT_MT090108CA.AssignedEntity"})]
    public class HealthcareWorker : MessagePartBean, Ca.Infoway.Messagebuilder.Model.Ab_mr2007_v02_r02.Pharmacy.Merged.IChangedBy, Ca.Infoway.Messagebuilder.Model.Ab_mr2007_v02_r02.Iehr.Repc_mt000012ca.IChoice, Ca.Infoway.Messagebuilder.Model.Ab_mr2007_v02_r02.Common.Coct_mt911107ca.IActingPerson, Ca.Infoway.Messagebuilder.Model.Ab_mr2007_v02_r02.Si.Rcmr_mt010001ca.IRecipient, Ca.Infoway.Messagebuilder.Model.Ab_mr2007_v02_r02.Iehr.Merged.IParty, Ca.Infoway.Messagebuilder.Model.Ab_mr2007_v02_r02.Common.Coct_mt911108ca.IActingPerson {

        private II id;
        private CV code;
        private SET<TEL, TelecommunicationAddress> telecom;
        private PN assignedPersonName;
        private II assignedPersonAsHealthCareProviderId;
        private II representedOrganizationId;
        private ST representedOrganizationName;
        private CV representedOrganizationAssignedOrganizationCode;
        private SET<TEL, TelecommunicationAddress> representedOrganizationAssignedOrganizationTelecom;

        public HealthcareWorker() {
            this.id = new IIImpl();
            this.code = new CVImpl();
            this.telecom = new SETImpl<TEL, TelecommunicationAddress>(typeof(TELImpl));
            this.assignedPersonName = new PNImpl();
            this.assignedPersonAsHealthCareProviderId = new IIImpl();
            this.representedOrganizationId = new IIImpl();
            this.representedOrganizationName = new STImpl();
            this.representedOrganizationAssignedOrganizationCode = new CVImpl();
            this.representedOrganizationAssignedOrganizationTelecom = new SETImpl<TEL, TelecommunicationAddress>(typeof(TELImpl));
        }
        /**
         * <summary>Business Name: A:Healthcare Worker Identifier</summary>
         * 
         * <remarks>Relationship: COCT_MT090108CA.AssignedEntity.id 
         * Conformance/Cardinality: MANDATORY (1) <p>Unique identifier 
         * the person involved in the action.</p> <p>Allows unique 
         * identification of the person which can be critical for 
         * authentication, permissions, drill-down and traceability and 
         * is therefore mandatory.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"id"})]
        public Identifier Id {
            get { return this.id.Value; }
            set { this.id.Value = value; }
        }

        /**
         * <summary>Business Name: B: Healthcare Worker Type</summary>
         * 
         * <remarks>Relationship: COCT_MT090108CA.AssignedEntity.code 
         * Conformance/Cardinality: MANDATORY (1) <p>Indicates the 
         * &quot;kind&quot; of healthcare participant, such as 
         * &quot;physician&quot;, &quot;dentist&quot;, &quot;lab 
         * technician&quot;, &quot;receptionist&quot;, etc.</p> 
         * <p>Provides context around the actions of the participant 
         * and is therefore mandatory.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"code"})]
        public HealthcareProviderRoleType Code {
            get { return (HealthcareProviderRoleType) this.code.Value; }
            set { this.code.Value = value; }
        }

        /**
         * <summary>Business Name: E: Healthcare Worker Phone and 
         * Emails</summary>
         * 
         * <remarks>Relationship: 
         * COCT_MT090108CA.AssignedEntity.telecom 
         * Conformance/Cardinality: REQUIRED (0-5) <p>Indicates phone 
         * and/or e-mail addresses at which the healthcare worker can 
         * be reached.</p> <p>This is the most commonly used piece of 
         * contact information and is returned here to avoid 
         * unnecessary queries of the provider registry.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"telecom"})]
        public ICollection<TelecommunicationAddress> Telecom {
            get { return this.telecom.RawSet(); }
        }

        /**
         * <summary>Business Name: C: Healthcare Worker Name</summary>
         * 
         * <remarks>Relationship: COCT_MT090108CA.Person.name 
         * Conformance/Cardinality: MANDATORY (1) <p>The name of the 
         * participating person.</p> <p>This is a human-readable name 
         * and is thus essential for both display and validation of the 
         * person. As a result, the attribute is mandatory.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"assignedPerson/name"})]
        public PersonName AssignedPersonName {
            get { return this.assignedPersonName.Value; }
            set { this.assignedPersonName.Value = value; }
        }

        /**
         * <summary>Business Name: D: License Number</summary>
         * 
         * <remarks>Relationship: COCT_MT090108CA.HealthCareProvider.id 
         * Conformance/Cardinality: MANDATORY (1) <p>The license number 
         * issued to the provider and relevant to the current 
         * action.</p> <p>Allows lookup on college website, 
         * confirmation of identity, etc. Regulations occasionally 
         * require license numbers to be specified as part of clinical 
         * records.</p> <p>If the identifier used in the root of the 
         * CMET is the same as the license number, the license number 
         * should be sent in both places.</p><p>Detailed information 
         * about the status and effective period of licenses must be 
         * retrieved from the provider registry.</p> <p>If the 
         * identifier used in the root of the CMET is the same as the 
         * license number, the license number should be sent in both 
         * places.</p><p>Detailed information about the status and 
         * effective period of licenses must be retrieved from the 
         * provider registry.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"assignedPerson/asHealthCareProvider/id"})]
        public Identifier AssignedPersonAsHealthCareProviderId {
            get { return this.assignedPersonAsHealthCareProviderId.Value; }
            set { this.assignedPersonAsHealthCareProviderId.Value = value; }
        }

        /**
         * <summary>Business Name: F: Organization identifier</summary>
         * 
         * <remarks>Relationship: COCT_MT090108CA.Organization.id 
         * Conformance/Cardinality: MANDATORY (1) <p>A unique 
         * identifier for the organization</p> <p>Allows the 
         * organization to be referenced when determining privileges 
         * and for drill-downs to retrieve additional information. 
         * Because of its importance, the attribute is mandatory.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"representedOrganization/id"})]
        public Identifier RepresentedOrganizationId {
            get { return this.representedOrganizationId.Value; }
            set { this.representedOrganizationId.Value = value; }
        }

        /**
         * <summary>Business Name: H: Organization Name</summary>
         * 
         * <remarks>Relationship: COCT_MT090108CA.Organization.name 
         * Conformance/Cardinality: MANDATORY (1) <p>Identifies the 
         * name of the organization</p> <p>Allows for human recognition 
         * of the organization as well as confirmation of the 
         * identifier. As a result, the attribute is mandatory.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"representedOrganization/name"})]
        public String RepresentedOrganizationName {
            get { return this.representedOrganizationName.Value; }
            set { this.representedOrganizationName.Value = value; }
        }

        /**
         * <summary>Business Name: G: Organization Type</summary>
         * 
         * <remarks>Relationship: 
         * COCT_MT090108CA.AssignedOrganization.code 
         * Conformance/Cardinality: MANDATORY (1) <p>Identifies the 
         * type of organization on whose behalf the action was taken. 
         * E.g. Pharmacy, Clinic, Hospital, etc.</p> <p>Provides 
         * context to the action and is therefore mandatory.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"representedOrganization/assignedOrganization/code"})]
        public HealthcareOrganizationRoleType RepresentedOrganizationAssignedOrganizationCode {
            get { return (HealthcareOrganizationRoleType) this.representedOrganizationAssignedOrganizationCode.Value; }
            set { this.representedOrganizationAssignedOrganizationCode.Value = value; }
        }

        /**
         * <summary>Business Name: I: Organization Phone and Emails</summary>
         * 
         * <remarks>Relationship: 
         * COCT_MT090108CA.AssignedOrganization.telecom 
         * Conformance/Cardinality: REQUIRED (0-5) <p>Identifies 
         * contact information for the responsible organization.</p> 
         * <p>This is the most commonly used contact information and is 
         * returned to avoid unnecessary queries against the client 
         * registry.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"representedOrganization/assignedOrganization/telecom"})]
        public ICollection<TelecommunicationAddress> RepresentedOrganizationAssignedOrganizationTelecom {
            get { return this.representedOrganizationAssignedOrganizationTelecom.RawSet(); }
        }

    }

}