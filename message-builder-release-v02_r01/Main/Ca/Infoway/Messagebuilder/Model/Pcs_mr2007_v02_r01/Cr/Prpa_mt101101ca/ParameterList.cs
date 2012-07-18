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
 * Last modified: $LastChangedDate: 2012-02-16 11:05:56 -0500 (Thu, 16 Feb 2012) $
 * Revision:      $LastChangedRevision: 5460 $
 */
/* This class was auto-generated by the message builder generator tools. */
namespace Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r01.Cr.Prpa_mt101101ca {
    using Ca.Infoway.Messagebuilder.Annotation;
    using Ca.Infoway.Messagebuilder.Datatype;
    using Ca.Infoway.Messagebuilder.Datatype.Impl;
    using Ca.Infoway.Messagebuilder.Datatype.Lang;
    using Ca.Infoway.Messagebuilder.Model;


    /**
     * <summary><p>either a Public or Business Identifier must be 
     * supplied to support this Query</p></summary>
     */
    [Hl7PartTypeMappingAttribute(new string[] {"PRPA_MT101101CA.ParameterList"})]
    public class ParameterList : MessagePartBean {

        private II clientIDBusValue;
        private II clientIDPubValue;

        public ParameterList() {
            this.clientIDBusValue = new IIImpl();
            this.clientIDPubValue = new IIImpl();
        }
        /**
         * <summary>Client Healthcare Identification Number</summary>
         * 
         * <remarks><p>This identification attribute supports capture 
         * of a healthcare identifier specific to the client. This 
         * identifier may be assigned jurisdictionally or by care 
         * facility.</p> <p>Mandatory attribute supports unique 
         * identification of the client and is a public identifier. 
         * E.G. Internal Business ID</p> <p>At least 1 client 
         * identifier must be present in the message</p><p>Text 
         * constraint exists on the model to support non mandatory 
         * requirements either a Public or Business Identifier must be 
         * supplied to support this Query.</p> <p>At least 1 client 
         * identifier must be present in the message</p><p>Text 
         * constraint exists on the model to support non mandatory 
         * requirements either a Public or Business Identifier must be 
         * supplied to support this Query.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"clientIDBus/value"})]
        public Identifier ClientIDBusValue {
            get { return this.clientIDBusValue.Value; }
            set { this.clientIDBusValue.Value = value; }
        }

        /**
         * <summary>Client Healthcare Identification Number</summary>
         * 
         * <remarks><p>This identification attribute supports capture 
         * of a healthcare identifier specific to the client. This 
         * identifier may be assigned jurisdictionally or by care 
         * facility.</p> <p>Mandatory attribute supports unique 
         * identification of the client and is a public identifier. 
         * E.G. Provincial Health Care Number</p> <p>At least 1 client 
         * identifier must be present in the message</p><p>Text 
         * constraint exists on the model to support non mandatory 
         * requirements either a Public or Business Identifier must be 
         * supplied to support this Query.</p> <p>At least 1 client 
         * identifier must be present in the message</p><p>Text 
         * constraint exists on the model to support non mandatory 
         * requirements either a Public or Business Identifier must be 
         * supplied to support this Query.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"clientIDPub/value"})]
        public Identifier ClientIDPubValue {
            get { return this.clientIDPubValue.Value; }
            set { this.clientIDPubValue.Value = value; }
        }

    }

}