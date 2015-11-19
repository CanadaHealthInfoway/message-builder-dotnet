/**
 * Copyright 2015 Canada Health Infoway, Inc.
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
namespace Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r02.Claims.Ficr_mt610201ca {
    using Ca.Infoway.Messagebuilder.Annotation;
    using Ca.Infoway.Messagebuilder.Model;
    using Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r02.Claims.Merged;


    [Hl7PartTypeMappingAttribute(new string[] {"FICR_MT610201CA.AdjudicationResultReference"})]
    public class AdjudicationResultReference : MessagePartBean {

        private Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r02.Claims.Ficr_mt610201ca.IInvoiceElementChoice invoiceElementChoice;

        public AdjudicationResultReference() {
        }
        /**
         * <summary>Relationship: 
         * FICR_MT610201CA.AdjudicationResultReference.invoiceElementChoice</summary>
         * 
         * <remarks>Conformance/Cardinality: REQUIRED (1)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"invoiceElementChoice"})]
        public Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r02.Claims.Ficr_mt610201ca.IInvoiceElementChoice InvoiceElementChoice {
            get { return this.invoiceElementChoice; }
            set { this.invoiceElementChoice = value; }
        }

        public Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r02.Claims.Merged.SubmittedInvoiceGroup InvoiceElementChoiceAsInvoiceElementGroup {
            get { return this.invoiceElementChoice is Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r02.Claims.Merged.SubmittedInvoiceGroup ? (Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r02.Claims.Merged.SubmittedInvoiceGroup) this.invoiceElementChoice : (Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r02.Claims.Merged.SubmittedInvoiceGroup) null; }
        }
        public bool HasInvoiceElementChoiceAsInvoiceElementGroup() {
            return (this.invoiceElementChoice is Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r02.Claims.Merged.SubmittedInvoiceGroup);
        }

        public Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r02.Claims.Merged.SubmittedInvoiceElementDetails InvoiceElementChoiceAsInvoiceElementDetail {
            get { return this.invoiceElementChoice is Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r02.Claims.Merged.SubmittedInvoiceElementDetails ? (Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r02.Claims.Merged.SubmittedInvoiceElementDetails) this.invoiceElementChoice : (Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r02.Claims.Merged.SubmittedInvoiceElementDetails) null; }
        }
        public bool HasInvoiceElementChoiceAsInvoiceElementDetail() {
            return (this.invoiceElementChoice is Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r02.Claims.Merged.SubmittedInvoiceElementDetails);
        }

    }

}