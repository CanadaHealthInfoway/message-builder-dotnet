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
namespace Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Pharmacy.Merged {
    using Ca.Infoway.Messagebuilder.Annotation;
    using Ca.Infoway.Messagebuilder.Datatype;
    using Ca.Infoway.Messagebuilder.Datatype.Impl;
    using Ca.Infoway.Messagebuilder.Model;
    using System;


    [Hl7PartTypeMappingAttribute(new string[] {"POME_MT010040CA.AssignedEntity1","POME_MT010040CA.AssignedEntity2","POME_MT010040CA.AssignedEntity3","PORR_MT050016CA.AssignedEntity"})]
    public class AssignedEntity3 : MessagePartBean {

        private ST assignedOrganizationName;

        public AssignedEntity3() {
            this.assignedOrganizationName = new STImpl();
        }
        /**
         * <summary>Formulary Owner Name</summary>
         * 
         * <remarks><p>The name of the organization or facility 
         * responsible for the formulary.</p> <p>Helps identify the 
         * circumstances in which the formulary applies.</p> 
         * D:Medication Document Author Name <p>The name of the 
         * organization responsible for creating the medication 
         * document.</p> <p>Helps the receiver evaluate the supplied 
         * information.</p> Monitoring Organization Name <p>The name of 
         * the organization responsible for the monitoring program</p> 
         * <p>Helps identify the program and understand its context. 
         * May also indicate who to send reports to.</p> Monograph 
         * Author Name <p>The name of the organization responsible for 
         * creating the monograph</p> <p>Helps the receiver evaluate 
         * the supplied information.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"assignedOrganization/name","representedOrganization/name"})]
        [Hl7MapByPartType(Name="assignedOrganization", Type="POME_MT010040CA.Organization1")]
        [Hl7MapByPartType(Name="assignedOrganization", Type="POME_MT010040CA.Organization2")]
        [Hl7MapByPartType(Name="assignedOrganization", Type="POME_MT010040CA.Organization3")]
        [Hl7MapByPartType(Name="representedOrganization", Type="PORR_MT050016CA.Organization4")]
        public String AssignedOrganizationName {
            get { return this.assignedOrganizationName.Value; }
            set { this.assignedOrganizationName.Value = value; }
        }

    }

}