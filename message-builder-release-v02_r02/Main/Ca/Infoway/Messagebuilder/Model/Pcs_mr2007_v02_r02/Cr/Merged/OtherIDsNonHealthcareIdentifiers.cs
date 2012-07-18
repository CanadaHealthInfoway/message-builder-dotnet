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
 * Last modified: $LastChangedDate: 2012-02-16 11:12:20 -0500 (Thu, 16 Feb 2012) $
 * Revision:      $LastChangedRevision: 5538 $
 */
/* This class was auto-generated by the message builder generator tools. */
namespace Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r02.Cr.Merged {
    using Ca.Infoway.Messagebuilder.Annotation;
    using Ca.Infoway.Messagebuilder.Datatype;
    using Ca.Infoway.Messagebuilder.Datatype.Impl;
    using Ca.Infoway.Messagebuilder.Datatype.Lang;
    using Ca.Infoway.Messagebuilder.Domainvalue;
    using Ca.Infoway.Messagebuilder.Model;
    using System;


    /**
     * <summary>OtherIDsNonHealthcareIdentifiers</summary>
     * 
     * <remarks>PRPA_MT101104CA.OtherIDs: Other IDs Non Healthcare 
     * Identifiers <p>Identifiers used for the focal person by 
     * other organizations are sent in the OtherIDs class. The 
     * other organization can be sent in the E_Organization Entity 
     * Class</p> <p>Provides the ability to capture additional 
     * client identifiers that are not healthcare specific</p> 
     * PRPA_MT101002CA.OtherIDs: Other IDs Non Healthcare 
     * Identifiers <p>Identifiers used for the focal person by 
     * other organizations are sent in the OtherIDs class. The 
     * other organization can be sent in the E_Organization Entity 
     * Class</p> <p>Provides the ability to capture additional 
     * client identifiers that are not healthcare specific</p> 
     * PRPA_MT101106CA.OtherIDs: Other IDs Non Healthcare 
     * Identifiers <p>Identifiers used for the focal person by 
     * other organizations are sent in the OtherIDs class. The 
     * other organization can be sent in the E_Organization Entity 
     * Class</p> <p>Provides the ability to capture additional 
     * client identifiers that are not healthcare specific</p> 
     * PRPA_MT101001CA.OtherIDs: Other IDs Non Healthcare 
     * Identifiers <p>Identifiers used for the focal person by 
     * other organizations are sent in the OtherIDs class. The 
     * other organization can be sent in the E_Organization Entity 
     * Class</p> <p>Provides the ability to capture additional 
     * client identifiers that are not healthcare specific</p></remarks>
     */
    [Hl7PartTypeMappingAttribute(new string[] {"PRPA_MT101001CA.OtherIDs","PRPA_MT101002CA.OtherIDs","PRPA_MT101104CA.OtherIDs","PRPA_MT101106CA.OtherIDs"})]
    public class OtherIDsNonHealthcareIdentifiers : MessagePartBean {

        private II id;
        private CV code;
        private II assigningIdOrganizationId;
        private ST assigningIdOrganizationName;

        public OtherIDsNonHealthcareIdentifiers() {
            this.id = new IIImpl();
            this.code = new CVImpl();
            this.assigningIdOrganizationId = new IIImpl();
            this.assigningIdOrganizationName = new STImpl();
        }
        /**
         * <summary>NonHealthcareIdentification</summary>
         * 
         * <remarks>NonHealthcare Identification <p>Other 
         * non-healthcare identifiers for the Client (e.g. Drivers 
         * License, RCMP, DND, Social Insurance Number)</p> 
         * <p>Mandatory attribute supports the identification of the 
         * client</p> NonHealthcare Identification <p>Other 
         * non-healthcare identifiers for the Client (e.g. Passport, 
         * SIN, DND, DIAND, Drivers License)</p> <p>Mandatory attribute 
         * supports the identification of the client</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"id"})]
        public Identifier Id {
            get { return this.id.Value; }
            set { this.id.Value = value; }
        }

        /**
         * <summary>NonHealthcareIdentificationCode</summary>
         * 
         * <remarks>NonHealthcare Identification Code <p>A pan Canadian 
         * code further specifying the kind of Role such as Drivers 
         * License, RCMP, DND, Social Insurance Number</p> <p>Populated 
         * attribute supports the identification of the client</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"code"})]
        public OtherIDsRoleCode Code {
            get { return (OtherIDsRoleCode) this.code.Value; }
            set { this.code.Value = value; }
        }

        /**
         * <summary>NonHealthcareOrganizationIdentifier</summary>
         * 
         * <remarks>NonHealthcare Organization Identifier <p>Unique 
         * identifier for the organization that assigned the 
         * non-healthcare identifier for the client.</p> <p>Mandatory 
         * attribute supports the identification of the organization 
         * assigning the identifier to the client</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"assigningIdOrganization/id"})]
        public Identifier AssigningIdOrganizationId {
            get { return this.assigningIdOrganizationId.Value; }
            set { this.assigningIdOrganizationId.Value = value; }
        }

        /**
         * <summary>NonHealthcareOrganizationName</summary>
         * 
         * <remarks>NonHealthcare Organization Name <p>A name for the 
         * non-healthcare organization</p> <p>Populated attribute 
         * supports the identification of the organization assigning 
         * the identifier to the client</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"assigningIdOrganization/name"})]
        public String AssigningIdOrganizationName {
            get { return this.assigningIdOrganizationName.Value; }
            set { this.assigningIdOrganizationName.Value = value; }
        }

    }

}