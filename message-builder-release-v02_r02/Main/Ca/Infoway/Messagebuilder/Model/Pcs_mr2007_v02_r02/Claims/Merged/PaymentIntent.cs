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
namespace Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r02.Claims.Merged {
    using Ca.Infoway.Messagebuilder.Annotation;
    using Ca.Infoway.Messagebuilder.Datatype;
    using Ca.Infoway.Messagebuilder.Datatype.Impl;
    using Ca.Infoway.Messagebuilder.Datatype.Lang;
    using Ca.Infoway.Messagebuilder.Model;
    using Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r02.Claims.Coct_mt110101ca;
    using Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r02.Claims.Coct_mt110200ca;
    using Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r02.Claims.Ficr_mt610201ca;
    using System;
    using System.Collections.Generic;


    /**
     * <summary>PaymentIntent</summary>
     * 
     * <remarks>FICR_MT610201CA.PaymentIntent: Payment Intent 
     * <p>Amt must be positive or 0 for</p><p>completed 
     * Adjudication Results</p><p>messages</p><p>Amt must be 
     * negative or 0 for Invoice Cancel Results messages</p> <p>Amt 
     * must be positive or 0 for</p><p>completed Adjudication 
     * Results</p><p>messages</p><p>Amt must be negative or 0 for 
     * Invoice Cancel Results messages</p> <p>Amt must be positive 
     * or 0 for</p><p>completed Adjudication 
     * Results</p><p>messages</p><p>Amt must be negative or 0 for 
     * Invoice Cancel Results messages</p> <p>Amt must be positive 
     * or 0 for</p><p>completed Adjudication 
     * Results</p><p>messages</p><p>Amt must be negative or 0 for 
     * Invoice Cancel Results messages</p> <p>If an Adjudicator 
     * adjudicates for multiple insurance policies (EOBs) for 
     * multiple Payors and/or Payees, there would be more than 1 
     * Payment Intent payload in the Results message</p> 
     * FICR_MT630000CA.PaymentIntent: Payment Intent <p>Net_amt 
     * must be positive or 0 for</p><p>Adjudication Results 
     * messages</p><p>Net_amt must be negative or 0 for Invoice 
     * Cancel messages</p> <p>Net_amt must be positive or 0 
     * for</p><p>Adjudication Results messages</p><p>Net_amt must 
     * be negative or 0 for Invoice Cancel messages</p> <p>Net_amt 
     * must be positive or 0 for</p><p>Adjudication Results 
     * messages</p><p>Net_amt must be negative or 0 for Invoice 
     * Cancel messages</p> <p>If an Adjudicator adjudicates for 
     * multiple insurance policies (EOBs) for multiple Payors 
     * and/or Payees, there would be more than 1 Payment Intent 
     * payload in the Results message</p></remarks>
     */
    [Hl7PartTypeMappingAttribute(new string[] {"FICR_MT610201CA.PaymentIntent","FICR_MT630000CA.PaymentIntent"})]
    public class PaymentIntent : MessagePartBean {

        private TS effectiveTime;
        private MO amt;
        private Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r02.Claims.Coct_mt110200ca.PayeeAccount creditAccount;
        private Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r02.Claims.Coct_mt110101ca.Account debitAccount;
        private IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r02.Claims.Ficr_mt610201ca.AdjudicatorBillingTaxAccount> pertinentInformationAdjudicatorBillingTaxAccount;
        private IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r02.Claims.Ficr_mt610201ca.PaymentReason> reasonOf;

        public PaymentIntent() {
            this.effectiveTime = new TSImpl();
            this.amt = new MOImpl();
            this.pertinentInformationAdjudicatorBillingTaxAccount = new List<Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r02.Claims.Ficr_mt610201ca.AdjudicatorBillingTaxAccount>();
            this.reasonOf = new List<Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r02.Claims.Ficr_mt610201ca.PaymentReason>();
        }
        /**
         * <summary>PaymentIntentDateTime</summary>
         * 
         * <remarks>Payment Intent Date/Time <p>Parment Intent 
         * Date/Time - Time payor intends to make payment (e.g. date of 
         * cheque/EFT run).</p> <p>For nullify, this would also be the 
         * date the payor intends to make the payment.</p><p>For 
         * Invoice Nullify Results: Effective time of the cancel is 
         * noted in the control act wrapper.</p> <p>For nullify, this 
         * would also be the date the payor intends to make the 
         * payment.</p><p>For Invoice Nullify Results: Effective time 
         * of the cancel is noted in the control act wrapper.</p> 
         * Payment Intent Date/Time <p>Time payor intends to make 
         * payment (e.g. date of cheque/EFT run). For nullify, this 
         * would also be the date the payor intends to make the 
         * payment.</p><p>For Invoice Nullify Results: Effective time 
         * of the cancel is noted in the control act wrapper.</p> 
         * <p>Time payor intends to make payment (e.g. date of 
         * cheque/EFT run). For nullify, this would also be the date 
         * the payor intends to make the payment.</p><p>For Invoice 
         * Nullify Results: Effective time of the cancel is noted in 
         * the control act wrapper.</p> <p>For Invoice Nullify Results: 
         * Effective time of the cancel is noted in the control act 
         * wrapper.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"effectiveTime"})]
        public PlatformDate EffectiveTime {
            get { return this.effectiveTime.Value; }
            set { this.effectiveTime.Value = value; }
        }

        /**
         * <summary>Total intent payment amount</summary>
         * 
         * <remarks><p>Adjudication Results: The payment intent amount 
         * cannot be mandatory for active adjudication 
         * results.</p><p>For Invoice Nullify Results: the payment 
         * intent is completed only, and therefore the amount must be 
         * specified.</p><p>For completed Payment Intents, this field 
         * is mandatory.</p> <p>Adjudication Results: The payment 
         * intent amount cannot be mandatory for active adjudication 
         * results.</p><p>For Invoice Nullify Results: the payment 
         * intent is completed only, and therefore the amount must be 
         * specified.</p><p>For completed Payment Intents, this field 
         * is mandatory.</p> <p>Adjudication Results: The payment 
         * intent amount cannot be mandatory for active adjudication 
         * results.</p><p>For Invoice Nullify Results: the payment 
         * intent is completed only, and therefore the amount must be 
         * specified.</p><p>For completed Payment Intents, this field 
         * is mandatory.</p> <p>Adjudication Results: The payment 
         * intent amount cannot be mandatory for active adjudication 
         * results.</p><p>For Invoice Nullify Results: the payment 
         * intent is completed only, and therefore the amount must be 
         * specified.</p><p>For completed Payment Intents, this field 
         * is mandatory.</p><p>Amt must be positive or 0 
         * for</p><p>completed Adjudication 
         * Results</p><p>messages</p><p>Amt must be negative or 0 for 
         * Invoice Cancel Results messages</p> <p>Adjudication Results: 
         * The payment intent amount cannot be mandatory for active 
         * adjudication results.</p><p>For Invoice Nullify Results: the 
         * payment intent is completed only, and therefore the amount 
         * must be specified.</p><p>For completed Payment Intents, this 
         * field is mandatory.</p><p>Amt must be positive or 0 
         * for</p><p>completed Adjudication 
         * Results</p><p>messages</p><p>Amt must be negative or 0 for 
         * Invoice Cancel Results messages</p> <p>Adjudication Results: 
         * The payment intent amount cannot be mandatory for active 
         * adjudication results.</p><p>For Invoice Nullify Results: the 
         * payment intent is completed only, and therefore the amount 
         * must be specified.</p><p>For completed Payment Intents, this 
         * field is mandatory.</p><p>Amt must be positive or 0 
         * for</p><p>completed Adjudication 
         * Results</p><p>messages</p><p>Amt must be negative or 0 for 
         * Invoice Cancel Results messages</p> <p>Adjudication Results: 
         * The payment intent amount cannot be mandatory for active 
         * adjudication results.</p><p>For Invoice Nullify Results: the 
         * payment intent is completed only, and therefore the amount 
         * must be specified.</p><p>For completed Payment Intents, this 
         * field is mandatory.</p><p>Amt must be positive or 0 
         * for</p><p>completed Adjudication 
         * Results</p><p>messages</p><p>Amt must be negative or 0 for 
         * Invoice Cancel Results messages</p> <p>Adjudication Results: 
         * The payment intent amount cannot be mandatory for active 
         * adjudication results.</p><p>For Invoice Nullify Results: the 
         * payment intent is completed only, and therefore the amount 
         * must be specified.</p><p>For completed Payment Intents, this 
         * field is mandatory.</p><p>Amt must be positive or 0 
         * for</p><p>completed Adjudication 
         * Results</p><p>messages</p><p>Amt must be negative or 0 for 
         * Invoice Cancel Results messages</p> <p>Adjudication Results: 
         * The payment intent amount cannot be mandatory for active 
         * adjudication results.</p><p>For Invoice Nullify Results: the 
         * payment intent is completed only, and therefore the amount 
         * must be specified.</p><p>For completed Payment Intents, this 
         * field is mandatory.</p><p>Amt must be positive or 0 
         * for</p><p>completed Adjudication 
         * Results</p><p>messages</p><p>Amt must be negative or 0 for 
         * Invoice Cancel Results messages</p> <p>Adjudication Results: 
         * The payment intent amount cannot be mandatory for active 
         * adjudication results.</p><p>For Invoice Nullify Results: the 
         * payment intent is completed only, and therefore the amount 
         * must be specified.</p><p>For completed Payment Intents, this 
         * field is mandatory.</p><p>Amt must be positive or 0 
         * for</p><p>completed Adjudication 
         * Results</p><p>messages</p><p>Amt must be negative or 0 for 
         * Invoice Cancel Results messages</p> payment amount 
         * <p>payment amount</p> <p>Adjudication Results: The payment 
         * intent amount cannot be mandatory for active adjudication 
         * results.</p><p>For Invoice Nullify Results: the payment 
         * intent is completed only, and therefore the amount must be 
         * specified.</p><p>For completed Payment Intents, this field 
         * is mandatory.</p> <p>Adjudication Results: The payment 
         * intent amount cannot be mandatory for active adjudication 
         * results.</p><p>For Invoice Nullify Results: the payment 
         * intent is completed only, and therefore the amount must be 
         * specified.</p><p>For completed Payment Intents, this field 
         * is mandatory.</p> <p>Adjudication Results: The payment 
         * intent amount cannot be mandatory for active adjudication 
         * results.</p><p>For Invoice Nullify Results: the payment 
         * intent is completed only, and therefore the amount must be 
         * specified.</p><p>For completed Payment Intents, this field 
         * is mandatory.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"amt"})]
        public Money Amt {
            get { return this.amt.Value; }
            set { this.amt.Value = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"credit/account"})]
        public Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r02.Claims.Coct_mt110200ca.PayeeAccount CreditAccount {
            get { return this.creditAccount; }
            set { this.creditAccount = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"debit/account"})]
        public Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r02.Claims.Coct_mt110101ca.Account DebitAccount {
            get { return this.debitAccount; }
            set { this.debitAccount = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"pertinentInformation/adjudicatorBillingTaxAccount"})]
        public IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r02.Claims.Ficr_mt610201ca.AdjudicatorBillingTaxAccount> PertinentInformationAdjudicatorBillingTaxAccount {
            get { return this.pertinentInformationAdjudicatorBillingTaxAccount; }
        }

        [Hl7XmlMappingAttribute(new string[] {"reasonOf"})]
        public IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r02.Claims.Ficr_mt610201ca.PaymentReason> ReasonOf {
            get { return this.reasonOf; }
        }

    }

}