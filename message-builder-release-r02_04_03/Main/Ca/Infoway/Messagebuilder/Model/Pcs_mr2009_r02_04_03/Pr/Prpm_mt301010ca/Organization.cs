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
namespace Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Pr.Prpm_mt301010ca {
    using Ca.Infoway.Messagebuilder.Annotation;
    using Ca.Infoway.Messagebuilder.Datatype;
    using Ca.Infoway.Messagebuilder.Datatype.Impl;
    using Ca.Infoway.Messagebuilder.Datatype.Lang;
    using Ca.Infoway.Messagebuilder.Model;
    using System;


    /**
     * <summary>Organization</summary>
     * 
     * <remarks><p>The scoping organization for the specified role 
     * class</p> <p>Supports the requirement to supply additional 
     * information regarding the assigning Organization of the 
     * specified RoleClass</p></remarks>
     */
    [Hl7PartTypeMappingAttribute(new string[] {"PRPM_MT301010CA.Organization"})]
    public class Organization : MessagePartBean {

        private II id;
        private ST name;
        private AD addr;
        private Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Pr.Prpm_mt301010ca.TerritorialAuthority territorialAuthority;

        public Organization() {
            this.id = new IIImpl();
            this.name = new STImpl();
            this.addr = new ADImpl();
        }
        /**
         * <summary>Organization Id</summary>
         * 
         * <remarks><p>Unique identifier for the organization that 
         * assigned the specified roleClass identifier.</p> <p>Required 
         * attribute supports the validation and identification of the 
         * specified roleClass.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"id"})]
        public Identifier Id {
            get { return this.id.Value; }
            set { this.id.Value = value; }
        }

        /**
         * <summary>Issuing Representing Qualification Granting 
         * Organization Name</summary>
         * 
         * <remarks><p>The name of the organization in support of three 
         * role classes as follows:</p><p>1. Organization that is 
         * responsible for registering the provider for a specific 
         * healthcare provider role.</p><p>2. Organization associated 
         * with a providers functional role.</p><p>3. Organization that 
         * grants the qualifications or expertise.</p> <p>The name of 
         * the organization in support of three role classes as 
         * follows:</p><p>1. Organization that is responsible for 
         * registering the provider for a specific healthcare provider 
         * role.</p><p>2. Organization associated with a providers 
         * functional role.</p><p>3. Organization that grants the 
         * qualifications or expertise.</p> <p>The name of the 
         * organization in support of three role classes as 
         * follows:</p><p>1. Organization that is responsible for 
         * registering the provider for a specific healthcare provider 
         * role.</p><p>2. Organization associated with a providers 
         * functional role.</p><p>3. Organization that grants the 
         * qualifications or expertise.</p> <p>The name of the 
         * organization in support of three role classes as 
         * follows:</p><p>1. Organization that is responsible for 
         * registering the provider for a specific healthcare provider 
         * role.</p><p>2. Organization associated with a providers 
         * functional role.</p><p>3. Organization that grants the 
         * qualifications or expertise.</p> <p>Required attribute 
         * supports the validation and identification of the healthcare 
         * provider.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"name"})]
        public String Name {
            get { return this.name.Value; }
            set { this.name.Value = value; }
        }

        /**
         * <summary>(Issuing Representing Qualification Granting 
         * Organization Address</summary>
         * 
         * <remarks><p>Address for any of the supported roles</p><p>1. 
         * Issuing Oganization</p><p>2. Representing 
         * Organization</p><p>3. Qualification Granting 
         * Organization</p> <p>Address for any of the supported 
         * roles</p><p>1. Issuing Oganization</p><p>2. Representing 
         * Organization</p><p>3. Qualification Granting 
         * Organization</p> <p>Address for any of the supported 
         * roles</p><p>1. Issuing Oganization</p><p>2. Representing 
         * Organization</p><p>3. Qualification Granting 
         * Organization</p> <p>Address for any of the supported 
         * roles</p><p>1. Issuing Oganization</p><p>2. Representing 
         * Organization</p><p>3. Qualification Granting 
         * Organization</p> <p>Required attribute supports the 
         * validation and identification of the healthcare provider</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"addr"})]
        public PostalAddress Addr {
            get { return this.addr.Value; }
            set { this.addr.Value = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"territorialAuthority"})]
        public Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Pr.Prpm_mt301010ca.TerritorialAuthority TerritorialAuthority {
            get { return this.territorialAuthority; }
            set { this.territorialAuthority = value; }
        }

    }

}