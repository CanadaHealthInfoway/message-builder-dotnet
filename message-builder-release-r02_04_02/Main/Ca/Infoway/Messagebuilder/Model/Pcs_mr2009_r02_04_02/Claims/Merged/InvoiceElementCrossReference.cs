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
 * Last modified: $LastChangedDate: 2012-01-19 07:11:45 -0500 (Thu, 19 Jan 2012) $
 * Revision:      $LastChangedRevision: 4387 $
 */

/* This class was auto-generated by the message builder generator tools. */
namespace Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Claims.Merged {
    using Ca.Infoway.Messagebuilder.Annotation;
    using Ca.Infoway.Messagebuilder.Datatype;
    using Ca.Infoway.Messagebuilder.Datatype.Impl;
    using Ca.Infoway.Messagebuilder.Datatype.Lang;
    using Ca.Infoway.Messagebuilder.Model;


    [Hl7PartTypeMappingAttribute(new string[] {"FICR_MT500201CA.InvoiceElementCrossReference","FICR_MT600201CA.InvoiceElementCrossReference"})]
    public class InvoiceElementCrossReference : MessagePartBean {

        private II crossReferenceIdentifier;

        public InvoiceElementCrossReference() {
            this.crossReferenceIdentifier = new IIImpl();
        }
        /**
         * <summary>CrossReferenceIdentifier</summary>
         * 
         * <remarks>Cross Reference Identifier</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"id"})]
        public Identifier CrossReferenceIdentifier {
            get { return this.crossReferenceIdentifier.Value; }
            set { this.crossReferenceIdentifier.Value = value; }
        }

    }

}