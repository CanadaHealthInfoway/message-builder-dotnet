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
 * Last modified: $LastChangedDate: 2012-02-16 11:02:17 -0500 (Thu, 16 Feb 2012) $
 * Revision:      $LastChangedRevision: 5407 $
 */
/* This class was auto-generated by the message builder generator tools. */
namespace Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r01.Merged {
    using Ca.Infoway.Messagebuilder.Annotation;
    using Ca.Infoway.Messagebuilder.Datatype;
    using Ca.Infoway.Messagebuilder.Datatype.Impl;
    using Ca.Infoway.Messagebuilder.Datatype.Lang;
    using Ca.Infoway.Messagebuilder.Model;
    using System;


    [Hl7PartTypeMappingAttribute(new string[] {"FICR_MT600201CA.CarrierRole","FICR_MT610201CA.CarrierRole","PORX_MT060160CA.CarrierRole","PORX_MT060340CA.CarrierRole"})]
    public class CarrierRole : MessagePartBean {

        private II id;
        private ST underwritingCarrierOrganizationName;
        private ST underwritingOrganizationName;

        public CarrierRole() {
            this.id = new IIImpl();
            this.underwritingCarrierOrganizationName = new STImpl();
            this.underwritingOrganizationName = new STImpl();
        }
        /**
         * <summary>Payor Identifier</summary>
         * 
         * <remarks><p>A unique identifier for the payor organization 
         * responsible for the coverage extension.</p> <p>Gives context 
         * to the coverage extension identifier and therefore 
         * mandatory. Allows the dispensing service delivery location 
         * to know where to send a claim.</p> Carrier ID <p>Unique 
         * identifier of the Policy Carrier - OID, made up of OID root 
         * and extension that identifies the insurance carrier.</p> 
         * Carrier ID <p>The unique identifier of the policy 
         * carrier.</p> <p>RxS1: OID, made up of OID root and extension 
         * that identifies the insurance carrier.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"id"})]
        public Identifier Id {
            get { return this.id.Value; }
            set { this.id.Value = value; }
        }

        /**
         * <summary>PayorName</summary>
         * 
         * <remarks>Payor Name <p>The name of the organization 
         * responsible for issuing the coverage extension.</p> 
         * <p>Mandatory for display purposes.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"underwritingCarrierOrganization/name"})]
        public String UnderwritingCarrierOrganizationName {
            get { return this.underwritingCarrierOrganizationName.Value; }
            set { this.underwritingCarrierOrganizationName.Value = value; }
        }

        /**
         * <summary>PayorName</summary>
         * 
         * <remarks>Payor Name <p>The name of the organization 
         * responsible for issuing the coverage extension.</p> 
         * <p>Mandatory for display purposes.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"underwritingOrganization/name"})]
        public String UnderwritingOrganizationName {
            get { return this.underwritingOrganizationName.Value; }
            set { this.underwritingOrganizationName.Value = value; }
        }

    }

}