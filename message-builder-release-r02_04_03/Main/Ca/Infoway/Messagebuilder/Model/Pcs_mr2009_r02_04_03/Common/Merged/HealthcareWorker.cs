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
namespace Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Common.Merged {
    using Ca.Infoway.Messagebuilder.Annotation;
    using Ca.Infoway.Messagebuilder.Datatype;
    using Ca.Infoway.Messagebuilder.Datatype.Impl;
    using Ca.Infoway.Messagebuilder.Datatype.Lang;
    using Ca.Infoway.Messagebuilder.Domainvalue;
    using Ca.Infoway.Messagebuilder.Model;
    using Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Merged;
    using System.Collections.Generic;


    /**
     * <summary>COCT_MT090108CA.AssignedEntity: Healthcare Worker</summary>
     * 
     * <remarks><p>The person organization assigned to carry out 
     * the associated (linked by a participation) action and/or the 
     * organization under whose authority they are acting.</p> 
     * <p>Critical to tracking responsibility and performing 
     * follow-up. The CMET supports both licensed providers as well 
     * as non-licensed providers such as technicians, 
     * receptionists, etc.</p> <p>All attributes other than the 
     * various identifiers are expected to be retrieved from the 
     * provider registry.</p> COCT_MT090502CA.AssignedEntity: 
     * Healthcare Organization <p>The organization under whose 
     * authority the associated action (linked by a participation) 
     * was performed.</p> <p>Critical to tracking responsibility 
     * and performing follow-up.</p></remarks>
     */
    [Hl7PartTypeMappingAttribute(new string[] {"COCT_MT090108CA.AssignedEntity","COCT_MT090502CA.AssignedEntity"})]
    public class HealthcareWorker : MessagePartBean, Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Iehr.Merged.IParty, Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Common.Coct_mt080100ca.IPerformerChoice, Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Lab.Merged.IRecipientChoice, Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Merged.IChoice, Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Common.Merged.IActingPerson, Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Common.Merged.IAuthorPerson, Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Merged.IRecipient, Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Merged.IRoleChoice, Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Common.Merged.IEntererChoice, Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Common.Coct_mt011001ca.IAssignees, Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Common.Coct_mt911108ca.IActingPerson, Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Pharmacy.Merged.IChangedBy {

        private IList<II> id;
        private CV code;
        private LIST<TEL, TelecommunicationAddress> telecom;
        private Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Merged.ActingPerson assignedPerson;
        private Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Merged.ResponsibleOrganization representedOrganization;

        public HealthcareWorker() {
            this.id = new List<II>();
            this.code = new CVImpl();
            this.telecom = new LISTImpl<TEL, TelecommunicationAddress>(typeof(TELImpl));
        }
        /**
         * <summary>HealthcareWorkerIdentifier</summary>
         * 
         * <remarks>A:Healthcare Worker Identifier <p>Unique identifier 
         * the person involved in the action.</p> <p>Allows unique 
         * identification of the person which can be critical for 
         * authentication, permissions, drill-down and traceability and 
         * is therefore mandatory.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"id"})]
        public IList<Identifier> Id {
            get { return new RawListWrapper<II, Identifier>(id, typeof(IIImpl)); }
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
        public AssignedRoleType Code {
            get { return (AssignedRoleType) this.code.Value; }
            set { this.code.Value = value; }
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
        public IList<TelecommunicationAddress> Telecom {
            get { return this.telecom.RawList(); }
        }

        [Hl7XmlMappingAttribute(new string[] {"assignedPerson"})]
        public Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Merged.ActingPerson AssignedPerson {
            get { return this.assignedPerson; }
            set { this.assignedPerson = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"representedOrganization"})]
        public Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Merged.ResponsibleOrganization RepresentedOrganization {
            get { return this.representedOrganization; }
            set { this.representedOrganization = value; }
        }

    }

}