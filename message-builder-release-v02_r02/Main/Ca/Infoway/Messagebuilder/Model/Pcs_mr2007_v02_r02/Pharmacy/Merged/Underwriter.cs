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
 * Last modified: $LastChangedDate: 2012-02-16 11:13:28 -0500 (Thu, 16 Feb 2012) $
 * Revision:      $LastChangedRevision: 5551 $
 */
/* This class was auto-generated by the message builder generator tools. */
namespace Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r02.Pharmacy.Merged {
    using Ca.Infoway.Messagebuilder.Annotation;
    using Ca.Infoway.Messagebuilder.Datatype;
    using Ca.Infoway.Messagebuilder.Datatype.Impl;
    using Ca.Infoway.Messagebuilder.Datatype.Lang;
    using Ca.Infoway.Messagebuilder.Model;
    using System;


    [Hl7PartTypeMappingAttribute(new string[] {"PORX_MT010110CA.Underwriter","PORX_MT010120CA.Underwriter","PORX_MT060040CA.Underwriter"})]
    public class Underwriter : MessagePartBean {

        private II id;
        private ST underwritingOrganizationName;

        public Underwriter() {
            this.id = new IIImpl();
            this.underwritingOrganizationName = new STImpl();
        }
        /**
         * <summary>PayorIdentifier</summary>
         * 
         * <remarks>Payor Identifier <p>A unique identifier for the 
         * payor organization responsible for the coverage 
         * extension.</p> <p>Gives context to the coverage extension 
         * identifier and therefore mandatory. Allows the dispensing 
         * service delivery location to know where to send a claim.</p> 
         * B:Payor Identifier <p>A unique identifier for the payor 
         * organization responsible for the coverage extension.</p> 
         * <p>Gives context to the coverage extension identifier and 
         * therefore mandatory. Allows the dispensing service delivery 
         * location to know where to send a claim.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"id"})]
        public Identifier Id {
            get { return this.id.Value; }
            set { this.id.Value = value; }
        }

        /**
         * <summary>PayorName</summary>
         * 
         * <remarks>C:Payor Name <p>The name of the organization 
         * responsible for issuing the coverage extension</p> 
         * <p>Mandatory for display purposes.</p> Payor Name <p>The 
         * name of the organization responsible for issuing the 
         * coverage extension.</p> <p>Mandatory for display 
         * purposes.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"underwritingOrganization/name"})]
        public String UnderwritingOrganizationName {
            get { return this.underwritingOrganizationName.Value; }
            set { this.underwritingOrganizationName.Value = value; }
        }

    }

}