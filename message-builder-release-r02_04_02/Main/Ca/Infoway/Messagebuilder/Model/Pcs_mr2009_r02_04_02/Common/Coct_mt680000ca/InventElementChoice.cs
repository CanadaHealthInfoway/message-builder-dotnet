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
 * Last modified: $LastChangedDate: 2012-01-18 21:04:25 -0500 (Wed, 18 Jan 2012) $
 * Revision:      $LastChangedRevision: 3925 $
 */

/* This class was auto-generated by the message builder generator tools. */
namespace Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Common.Coct_mt680000ca {
    using Ca.Infoway.Messagebuilder;
    using Ca.Infoway.Messagebuilder.Annotation;
    using Ca.Infoway.Messagebuilder.Datatype;
    using Ca.Infoway.Messagebuilder.Datatype.Impl;
    using Ca.Infoway.Messagebuilder.Datatype.Lang;
    using Ca.Infoway.Messagebuilder.Model;
    using System.Collections.Generic;


    [Hl7PartTypeMappingAttribute(new string[] {"COCT_MT680000CA.InvoiceElementIntent"})]
    public class InventElementChoice : MessagePartBean, Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Merged.IInvoiceElementChoice {

        private CV invoiceElementIntentCode;
        private MO totalAmountBilledForInvoiceElement;
        private IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Common.Coct_mt680000ca.InvoiceElementComponent> component;

        public InventElementChoice() {
            this.invoiceElementIntentCode = new CVImpl();
            this.totalAmountBilledForInvoiceElement = new MOImpl();
            this.component = new List<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Common.Coct_mt680000ca.InvoiceElementComponent>();
        }
        /**
         * <summary>Invoice Element Intent Code</summary>
         * 
         * <remarks><p>(Invoice Type e.g. Healthcare Services, Rx 
         * Dispense, Rx Compound, Healthcare Goods, Preferred 
         * Accomodation</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"code"})]
        public Code InvoiceElementIntentCode {
            get { return (Code) this.invoiceElementIntentCode.Value; }
            set { this.invoiceElementIntentCode.Value = value; }
        }

        /**
         * <summary>Total amount billed for invoice element</summary>
         * 
         * <remarks><p>Identifies the total monetary amount billed for 
         * the invoice element.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"netAmt"})]
        public Money TotalAmountBilledForInvoiceElement {
            get { return this.totalAmountBilledForInvoiceElement.Value; }
            set { this.totalAmountBilledForInvoiceElement.Value = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"component"})]
        public IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Common.Coct_mt680000ca.InvoiceElementComponent> Component {
            get { return this.component; }
        }

    }

}