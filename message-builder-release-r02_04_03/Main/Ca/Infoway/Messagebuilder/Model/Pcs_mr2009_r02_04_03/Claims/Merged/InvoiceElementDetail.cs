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
namespace Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Claims.Merged {
    using Ca.Infoway.Messagebuilder;
    using Ca.Infoway.Messagebuilder.Annotation;
    using Ca.Infoway.Messagebuilder.Datatype;
    using Ca.Infoway.Messagebuilder.Datatype.Impl;
    using Ca.Infoway.Messagebuilder.Datatype.Lang;
    using Ca.Infoway.Messagebuilder.Model;
    using Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Common.Coct_mt280001ca;
    using System;
    using System.Collections.Generic;


    /**
     * <summary>FICR_MT500201CA.InvoiceElementDetail: (no business 
     * name)</summary>
     * 
     * <remarks><p>RTO used to specify 15 pills (each) out of a 
     * bottle of 100 pills (each) to reflect billing for a portion 
     * of a package (e.g. 0.15 of a bottle)</p> 
     * FICR_MT600201CA.InvoiceElementDetail: (no business name) 
     * <p>RTO used to specify 15 pills (each) out of a bottle of 
     * 100 pills (each) to reflect billing for a portion of a 
     * package (e.g. 0.15 of a bottle)</p></remarks>
     */
    [Hl7PartTypeMappingAttribute(new string[] {"FICR_MT500201CA.InvoiceElementDetail","FICR_MT510201CA.InvoiceElementDetail","FICR_MT600201CA.InvoiceElementDetail","FICR_MT610201CA.InvoiceElementDetail"})]
    public class InvoiceElementDetail : MessagePartBean, Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Merged.IInvoiceElementChoice, Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Claims.Ficr_mt600201ca.IInvoiceElementChoice, Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Claims.Ficr_mt500201ca.IInvoiceElementChoice {

        private II id;
        private CV code;
        private MO netAmt;
        private IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Common.Coct_mt280001ca.IA_BillableActChoice> reasonOfBillableActChoice;
        private PQ unitQuantity;
        private RTO<Money, PhysicalQuantity> unitPriceAmt;
        private REAL factorNumber;

        public InvoiceElementDetail() {
            this.id = new IIImpl();
            this.code = new CVImpl();
            this.netAmt = new MOImpl();
            this.reasonOfBillableActChoice = new List<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Common.Coct_mt280001ca.IA_BillableActChoice>();
            this.unitQuantity = new PQImpl();
            this.unitPriceAmt = new RTOImpl<Money, PhysicalQuantity>();
            this.factorNumber = new REALImpl();
        }
        /**
         * <summary>SubmittedInvoiceLineIdentifier</summary>
         * 
         * <remarks>Submitted Invoice Line Identifier</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"id"})]
        public Identifier Id {
            get { return this.id.Value; }
            set { this.id.Value = value; }
        }

        /**
         * <summary>SubmittedProductServiceCode</summary>
         * 
         * <remarks>Submitted Product/Service Code Submitted 
         * product/Service code</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"code"})]
        public Code Code {
            get { return (Code) this.code.Value; }
            set { this.code.Value = value; }
        }

        /**
         * <summary>SubmittedInvoiceLineAmount</summary>
         * 
         * <remarks>Submitted Invoice Line Amount</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"netAmt"})]
        public Money NetAmt {
            get { return this.netAmt.Value; }
            set { this.netAmt.Value = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"reasonOf/billableActChoice"})]
        public IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Common.Coct_mt280001ca.IA_BillableActChoice> ReasonOfBillableActChoice {
            get { return this.reasonOfBillableActChoice; }
        }

        /**
         * <summary>SubmittedUnitQuantity</summary>
         * 
         * <remarks>Submitted Unit Quantity</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"unitQuantity"})]
        public PhysicalQuantity UnitQuantity {
            get { return this.unitQuantity.Value; }
            set { this.unitQuantity.Value = value; }
        }

        /**
         * <summary>SubmittedUnitAmountPrice</summary>
         * 
         * <remarks>Submitted Unit Amount Price</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"unitPriceAmt"})]
        public Ratio<Money, PhysicalQuantity> UnitPriceAmt {
            get { return this.unitPriceAmt.Value; }
            set { this.unitPriceAmt.Value = value; }
        }

        /**
         * <summary>Multiplier, e.g. 0.07</summary>
         * 
         * <remarks>Tax % applied to unitPriceAmt.</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"factorNumber"})]
        public BigDecimal FactorNumber {
            get { return this.factorNumber.Value; }
            set { this.factorNumber.Value = value; }
        }

    }

}