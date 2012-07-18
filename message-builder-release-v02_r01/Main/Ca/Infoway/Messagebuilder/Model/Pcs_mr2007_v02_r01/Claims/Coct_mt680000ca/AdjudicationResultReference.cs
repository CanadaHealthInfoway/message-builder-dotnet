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
 * Last modified: $LastChangedDate: 2012-02-16 11:02:52 -0500 (Thu, 16 Feb 2012) $
 * Revision:      $LastChangedRevision: 5414 $
 */
/* This class was auto-generated by the message builder generator tools. */
namespace Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r01.Claims.Coct_mt680000ca {
    using Ca.Infoway.Messagebuilder.Annotation;
    using Ca.Infoway.Messagebuilder.Model;


    /**
     * <summary><p>Each submitted invoice element must have 1 
     * AdjudicationResults instance unless its parent is 
     * adjudicated as submitted</p></summary>
     * 
     * <remarks><p>Multiple references to submitted invoice 
     * elements provides support for code substitution where the 
     * number of submitted fee items is consolidated on the 
     * adjudication results (e.g. 3 items to 1)</p></remarks>
     */
    [Hl7PartTypeMappingAttribute(new string[] {"COCT_MT680000CA.AdjudicationResultReference"})]
    public class AdjudicationResultReference : MessagePartBean {

        private Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r01.Claims.Coct_mt680000ca.IInvoiceElementChoice invoiceElementChoice;

        public AdjudicationResultReference() {
        }
        [Hl7XmlMappingAttribute(new string[] {"invoiceElementChoice"})]
        public Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r01.Claims.Coct_mt680000ca.IInvoiceElementChoice InvoiceElementChoice {
            get { return this.invoiceElementChoice; }
            set { this.invoiceElementChoice = value; }
        }

        public Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r01.Claims.Coct_mt680000ca.InvoiceElementIntent InvoiceElementChoiceAsInvoiceElementIntent1 {
            get { return this.invoiceElementChoice is Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r01.Claims.Coct_mt680000ca.InvoiceElementIntent ? (Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r01.Claims.Coct_mt680000ca.InvoiceElementIntent) this.invoiceElementChoice : (Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r01.Claims.Coct_mt680000ca.InvoiceElementIntent) null; }
        }
        public bool HasInvoiceElementChoiceAsInvoiceElementIntent1() {
            return (this.invoiceElementChoice is Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r01.Claims.Coct_mt680000ca.InvoiceElementIntent);
        }

        public Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r01.Claims.Coct_mt680000ca.InvoiceElementIntent2 InvoiceElementChoiceAsInvoiceElementIntent2 {
            get { return this.invoiceElementChoice is Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r01.Claims.Coct_mt680000ca.InvoiceElementIntent2 ? (Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r01.Claims.Coct_mt680000ca.InvoiceElementIntent2) this.invoiceElementChoice : (Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r01.Claims.Coct_mt680000ca.InvoiceElementIntent2) null; }
        }
        public bool HasInvoiceElementChoiceAsInvoiceElementIntent2() {
            return (this.invoiceElementChoice is Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r01.Claims.Coct_mt680000ca.InvoiceElementIntent2);
        }

    }

}