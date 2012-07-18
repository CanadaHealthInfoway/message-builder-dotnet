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
namespace Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r02.Claims.Coct_mt110200ca {
    using Ca.Infoway.Messagebuilder.Annotation;
    using Ca.Infoway.Messagebuilder.Datatype;
    using Ca.Infoway.Messagebuilder.Datatype.Impl;
    using Ca.Infoway.Messagebuilder.Datatype.Lang;
    using Ca.Infoway.Messagebuilder.Model;
    using System;


    /**
     * <summary>Payee Organisation</summary>
     * 
     * <remarks><p>Organisation receiving payment.</p></remarks>
     */
    [Hl7PartTypeMappingAttribute(new string[] {"COCT_MT110200CA.PayeeOrganization"})]
    public class PayeeOrganisation : MessagePartBean, Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r02.Claims.Coct_mt110200ca.IPayeeChoice {

        private Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r02.Claims.Coct_mt110200ca.PayeeRelationshipRole asPayeeRelationshipRole;
        private ST name;
        private AD addr;

        public PayeeOrganisation() {
            this.name = new STImpl();
            this.addr = new ADImpl();
        }
        [Hl7XmlMappingAttribute(new string[] {"asPayeeRelationshipRole"})]
        public Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r02.Claims.Coct_mt110200ca.PayeeRelationshipRole AsPayeeRelationshipRole {
            get { return this.asPayeeRelationshipRole; }
            set { this.asPayeeRelationshipRole = value; }
        }

        /**
         * <summary>Payee Organisation name</summary>
         * 
         * <remarks><p>name of organisation receiving payment.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"name"})]
        public String Name {
            get { return this.name.Value; }
            set { this.name.Value = value; }
        }

        /**
         * <summary>Payee Organisation address</summary>
         */
        [Hl7XmlMappingAttribute(new string[] {"addr"})]
        public PostalAddress Addr {
            get { return this.addr.Value; }
            set { this.addr.Value = value; }
        }

    }

}