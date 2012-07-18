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
 * Last modified: $LastChangedDate: 2012-02-16 11:03:21 -0500 (Thu, 16 Feb 2012) $
 * Revision:      $LastChangedRevision: 5418 $
 */
/* This class was auto-generated by the message builder generator tools. */
namespace Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r01.Claims.Merged {
    using Ca.Infoway.Messagebuilder;
    using Ca.Infoway.Messagebuilder.Annotation;
    using Ca.Infoway.Messagebuilder.Datatype;
    using Ca.Infoway.Messagebuilder.Datatype.Impl;
    using Ca.Infoway.Messagebuilder.Datatype.Lang;
    using Ca.Infoway.Messagebuilder.Domainvalue;
    using Ca.Infoway.Messagebuilder.Model;
    using Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r01.Claims.Ficr_mt610201ca;
    using Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r01.Claims.Qucr_mt830201ca;
    using System.Collections.Generic;


    /**
     * <summary>FICR_MT610201CA.AdjudicatedInvoiceElementGroup: 
     * Adjudicated Invoice</summary>
     * 
     * <remarks><p>For the root AdjududicatedInvoiceElementGroup, 
     * the Coverage, Author and OutcomeOf relationships are 
     * Mandatory.</p><p>All Relationships to the 
     * AdjudicatedInvoiceElementGroup can only be associated with 
     * the root level instance</p> <p>For the root 
     * AdjududicatedInvoiceElementGroup, the Coverage, Author and 
     * OutcomeOf relationships are Mandatory.</p><p>All 
     * Relationships to the AdjudicatedInvoiceElementGroup can only 
     * be associated with the root level instance</p> <p>A.K.A. the 
     * result.</p> QUCR_MT830201CA.AdjudicatedInvoiceElementGroup: 
     * Adjudication Result Identifier <p>Adjudication Result 
     * Identifier</p> <p>May include data centre and sequence 
     * numbers</p></remarks>
     */
    [Hl7PartTypeMappingAttribute(new string[] {"FICR_MT610201CA.AdjudicatedInvoiceElementGroup","QUCR_MT830201CA.AdjudicatedInvoiceElementGroup"})]
    public class AdjudicationResultIdentifier : MessagePartBean, Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r01.Claims.Ficr_mt610201ca.IAdjudicatedInvoiceElementChoice {

        private Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r01.Claims.Ficr_mt610201ca.Allowable reference1Allowable;
        private II id;
        private CV code;
        private CS statusCode;
        private MO netAmt;
        private Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r01.Claims.Merged.Adjudicator author;
        private Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r01.Claims.Merged.AdjudicationResultIdentifier predecessorAdjudicatedInvoiceElementGroup;
        private IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r01.Claims.Merged.AdjudicatedInvoiceElementGroup> referenceAdjudicatedInvoiceElementGroup;
        private IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r01.Claims.Ficr_mt610201ca.AdjudicatedInvoiceCoverage> coverage;
        private IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r01.Claims.Ficr_mt610201ca.ComponentInvoiceElement> component;
        private Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r01.Claims.Merged.AdjudicatedResultsGroup referencedByAdjudResultsGroup;
        private Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r01.Claims.Qucr_mt830201ca.AdjudicatedResultOutcome outcomeOf;

        public AdjudicationResultIdentifier() {
            this.id = new IIImpl();
            this.code = new CVImpl();
            this.statusCode = new CSImpl();
            this.netAmt = new MOImpl();
            this.referenceAdjudicatedInvoiceElementGroup = new List<Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r01.Claims.Merged.AdjudicatedInvoiceElementGroup>();
            this.coverage = new List<Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r01.Claims.Ficr_mt610201ca.AdjudicatedInvoiceCoverage>();
            this.component = new List<Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r01.Claims.Ficr_mt610201ca.ComponentInvoiceElement>();
        }
        [Hl7XmlMappingAttribute(new string[] {"reference1/allowable"})]
        public Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r01.Claims.Ficr_mt610201ca.Allowable Reference1Allowable {
            get { return this.reference1Allowable; }
            set { this.reference1Allowable = value; }
        }

        /**
         * <summary>AdjudicatedResultsIdentifier</summary>
         * 
         * <remarks>(no business name) <p>May include data centre and 
         * sequence numbers</p> <p>Technique to identify that the EOB 
         * was not electronic (manual) is through the participation 
         * mode code for the adjudicator.</p> Adjudicated Results 
         * Identifier <p>Technique to identify that the EOB was not 
         * electronic (manual) is through the participation mode code 
         * for the adjudicator.</p> <p>Technique to identify that the 
         * EOB was not electronic (manual) is through the participation 
         * mode code for the adjudicator.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"id"})]
        public Identifier Id {
            get { return this.id.Value; }
            set { this.id.Value = value; }
        }

        /**
         * <summary>InvoiceType</summary>
         * 
         * <remarks>(Invoice Type <p>Invoice Type e.g. Healthcare 
         * Services, Rx Dispense, Rx Compound, Healthcare Goods, 
         * Preferred Accomodation</p> <p>For Invoice (COB) : Invoice 
         * type (for root) cannot be different from submitted invoice. 
         * This would be a cause for rejecting the invoice.</p><p>For 
         * Adjudication Results: code must match to the corresponding 
         * invoice element that was submitted.</p><p>For Invoice 
         * Nullify Results: this is the identifier of the EOB that was 
         * previously messaged to the Provider.</p><p>Modifiers for the 
         * codes are taken from the same domain (i.e 
         * ActInvoiceGroupCode).</p> <p>For Invoice (COB) : Invoice 
         * type (for root) cannot be different from submitted invoice. 
         * This would be a cause for rejecting the invoice.</p><p>For 
         * Adjudication Results: code must match to the corresponding 
         * invoice element that was submitted.</p><p>For Invoice 
         * Nullify Results: this is the identifier of the EOB that was 
         * previously messaged to the Provider.</p><p>Modifiers for the 
         * codes are taken from the same domain (i.e 
         * ActInvoiceGroupCode).</p> <p>For Invoice (COB) : Invoice 
         * type (for root) cannot be different from submitted invoice. 
         * This would be a cause for rejecting the invoice.</p><p>For 
         * Adjudication Results: code must match to the corresponding 
         * invoice element that was submitted.</p><p>For Invoice 
         * Nullify Results: this is the identifier of the EOB that was 
         * previously messaged to the Provider.</p><p>Modifiers for the 
         * codes are taken from the same domain (i.e 
         * ActInvoiceGroupCode).</p> <p>For Invoice (COB) : Invoice 
         * type (for root) cannot be different from submitted invoice. 
         * This would be a cause for rejecting the invoice.</p><p>For 
         * Adjudication Results: code must match to the corresponding 
         * invoice element that was submitted.</p><p>For Invoice 
         * Nullify Results: this is the identifier of the EOB that was 
         * previously messaged to the Provider.</p><p>Modifiers for the 
         * codes are taken from the same domain (i.e 
         * ActInvoiceGroupCode).</p> Invoice Type <p>Invoice Type e.g. 
         * Healthcare Services, Rx Dispense, Rx Compound, Healthcare 
         * Goods, Preferred Accomodation</p> <p>RXDINV, RXCINV, CSINV, 
         * CPINV only.</p> <p>For Invoice (COB) : Invoice type (for 
         * root) cannot be different from submitted invoice. This would 
         * be a cause for rejecting the invoice.</p><p>For Adjudication 
         * Results: code must match to the corresponding invoice 
         * element that was submitted.</p><p>For Invoice Nullify 
         * Results: this is the identifier of the EOB that was 
         * previously messaged to the Provider.</p><p>Modifiers for the 
         * codes are taken from the same domain (i.e 
         * ActInvoiceGroupCode).</p> <p>For Invoice (COB) : Invoice 
         * type (for root) cannot be different from submitted invoice. 
         * This would be a cause for rejecting the invoice.</p><p>For 
         * Adjudication Results: code must match to the corresponding 
         * invoice element that was submitted.</p><p>For Invoice 
         * Nullify Results: this is the identifier of the EOB that was 
         * previously messaged to the Provider.</p><p>Modifiers for the 
         * codes are taken from the same domain (i.e 
         * ActInvoiceGroupCode).</p> <p>For Invoice (COB) : Invoice 
         * type (for root) cannot be different from submitted invoice. 
         * This would be a cause for rejecting the invoice.</p><p>For 
         * Adjudication Results: code must match to the corresponding 
         * invoice element that was submitted.</p><p>For Invoice 
         * Nullify Results: this is the identifier of the EOB that was 
         * previously messaged to the Provider.</p><p>Modifiers for the 
         * codes are taken from the same domain (i.e 
         * ActInvoiceGroupCode).</p> <p>For Invoice (COB) : Invoice 
         * type (for root) cannot be different from submitted invoice. 
         * This would be a cause for rejecting the invoice.</p><p>For 
         * Adjudication Results: code must match to the corresponding 
         * invoice element that was submitted.</p><p>For Invoice 
         * Nullify Results: this is the identifier of the EOB that was 
         * previously messaged to the Provider.</p><p>Modifiers for the 
         * codes are taken from the same domain (i.e 
         * ActInvoiceGroupCode).</p> <p>For Invoice (COB) : Invoice 
         * type (for root) cannot be different from submitted invoice. 
         * This would be a cause for rejecting the invoice.</p><p>For 
         * Adjudication Results: code must match to the corresponding 
         * invoice element that was submitted.</p><p>For Invoice 
         * Nullify Results: this is the identifier of the EOB that was 
         * previously messaged to the Provider.</p><p>Modifiers for the 
         * codes are taken from the same domain (i.e 
         * ActInvoiceGroupCode).</p> <p>For Invoice (COB) : Invoice 
         * type (for root) cannot be different from submitted invoice. 
         * This would be a cause for rejecting the invoice.</p><p>For 
         * Adjudication Results: code must match to the corresponding 
         * invoice element that was submitted.</p><p>For Invoice 
         * Nullify Results: this is the identifier of the EOB that was 
         * previously messaged to the Provider.</p><p>Modifiers for the 
         * codes are taken from the same domain (i.e 
         * ActInvoiceGroupCode).</p> <p>For Invoice (COB) : Invoice 
         * type (for root) cannot be different from submitted invoice. 
         * This would be a cause for rejecting the invoice.</p><p>For 
         * Adjudication Results: code must match to the corresponding 
         * invoice element that was submitted.</p><p>For Invoice 
         * Nullify Results: this is the identifier of the EOB that was 
         * previously messaged to the Provider.</p><p>Modifiers for the 
         * codes are taken from the same domain (i.e 
         * ActInvoiceGroupCode).</p> <p>For Invoice (COB) : Invoice 
         * type (for root) cannot be different from submitted invoice. 
         * This would be a cause for rejecting the invoice.</p><p>For 
         * Adjudication Results: code must match to the corresponding 
         * invoice element that was submitted.</p><p>For Invoice 
         * Nullify Results: this is the identifier of the EOB that was 
         * previously messaged to the Provider.</p><p>Modifiers for the 
         * codes are taken from the same domain (i.e 
         * ActInvoiceGroupCode).</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"code"})]
        public Code Code {
            get { return (Code) this.code.Value; }
            set { this.code.Value = value; }
        }

        /**
         * <summary>StatusOfTheAdjudicatedInvoice</summary>
         * 
         * <remarks>Status of the Adjudicated Invoice <p>Status of the 
         * Adjudicated Invoice</p> <p>Active EOBs are used to convey 
         * interim or preliminary adjudication results. They can also 
         * be used, with information codes, to indicate that the 
         * invoice grouping is held for manual review by the 
         * adjudicator, waiting for other third party information (e.g. 
         * from another provider, employer, etc.).</p><p>Suspended EOBs 
         * are used to convey adjudication results that are awaiting 
         * additional information from the submitting 
         * Provider.</p><p>Complete EOBs are used to convey final 
         * adjudication results, with an associated intent to pay.</p> 
         * <p>Active EOBs are used to convey interim or preliminary 
         * adjudication results. They can also be used, with 
         * information codes, to indicate that the invoice grouping is 
         * held for manual review by the adjudicator, waiting for other 
         * third party information (e.g. from another provider, 
         * employer, etc.).</p><p>Suspended EOBs are used to convey 
         * adjudication results that are awaiting additional 
         * information from the submitting Provider.</p><p>Complete 
         * EOBs are used to convey final adjudication results, with an 
         * associated intent to pay.</p> <p>Active EOBs are used to 
         * convey interim or preliminary adjudication results. They can 
         * also be used, with information codes, to indicate that the 
         * invoice grouping is held for manual review by the 
         * adjudicator, waiting for other third party information (e.g. 
         * from another provider, employer, etc.).</p><p>Suspended EOBs 
         * are used to convey adjudication results that are awaiting 
         * additional information from the submitting 
         * Provider.</p><p>Complete EOBs are used to convey final 
         * adjudication results, with an associated intent to pay.</p> 
         * <p>For Pharmacy dispense Invoices &amp; Pre-Determinations 
         * (RXDINV, RXCINV), only completed EOBs are permitted to 
         * facilitate real-time processing.</p><p>For Pharmacy clinical 
         * product (CPINV) and clinical service (CSINV) Invoices &amp; 
         * Pre-Determinations, status may be active, suspended or 
         * complete.</p><p>For all Coverage Extension Requests, status 
         * may be active, suspended or complete. For Invoice (COB): 
         * Status code must be complete in order for EOB to be sent to 
         * downstream Adjudicators. If a Provider receives a 
         * non-complete EOB, this cannot be forwarded to a downstream 
         * Adjudicator.</p><p>Field cannot be made mandatory, as it is 
         * not included in Payment Advice Detail messages (only 
         * completed EOBs can be included in a Payment Advice).</p> 
         * <p>For Pharmacy dispense Invoices &amp; Pre-Determinations 
         * (RXDINV, RXCINV), only completed EOBs are permitted to 
         * facilitate real-time processing.</p><p>For Pharmacy clinical 
         * product (CPINV) and clinical service (CSINV) Invoices &amp; 
         * Pre-Determinations, status may be active, suspended or 
         * complete.</p><p>For all Coverage Extension Requests, status 
         * may be active, suspended or complete. For Invoice (COB): 
         * Status code must be complete in order for EOB to be sent to 
         * downstream Adjudicators. If a Provider receives a 
         * non-complete EOB, this cannot be forwarded to a downstream 
         * Adjudicator.</p><p>Field cannot be made mandatory, as it is 
         * not included in Payment Advice Detail messages (only 
         * completed EOBs can be included in a Payment Advice).</p> 
         * <p>For Pharmacy dispense Invoices &amp; Pre-Determinations 
         * (RXDINV, RXCINV), only completed EOBs are permitted to 
         * facilitate real-time processing.</p><p>For Pharmacy clinical 
         * product (CPINV) and clinical service (CSINV) Invoices &amp; 
         * Pre-Determinations, status may be active, suspended or 
         * complete.</p><p>For all Coverage Extension Requests, status 
         * may be active, suspended or complete. For Invoice (COB): 
         * Status code must be complete in order for EOB to be sent to 
         * downstream Adjudicators. If a Provider receives a 
         * non-complete EOB, this cannot be forwarded to a downstream 
         * Adjudicator.</p><p>Field cannot be made mandatory, as it is 
         * not included in Payment Advice Detail messages (only 
         * completed EOBs can be included in a Payment Advice).</p> 
         * <p>For Pharmacy dispense Invoices &amp; Pre-Determinations 
         * (RXDINV, RXCINV), only completed EOBs are permitted to 
         * facilitate real-time processing.</p><p>For Pharmacy clinical 
         * product (CPINV) and clinical service (CSINV) Invoices &amp; 
         * Pre-Determinations, status may be active, suspended or 
         * complete.</p><p>For all Coverage Extension Requests, status 
         * may be active, suspended or complete. For Invoice (COB): 
         * Status code must be complete in order for EOB to be sent to 
         * downstream Adjudicators. If a Provider receives a 
         * non-complete EOB, this cannot be forwarded to a downstream 
         * Adjudicator.</p><p>Field cannot be made mandatory, as it is 
         * not included in Payment Advice Detail messages (only 
         * completed EOBs can be included in a Payment Advice).</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"statusCode"})]
        public ActStatus StatusCode {
            get { return (ActStatus) this.statusCode.Value; }
            set { this.statusCode.Value = value; }
        }

        /**
         * <summary>PaidAmount</summary>
         * 
         * <remarks>Paid Amount <p>Paid Amount</p> <p>For Coverage 
         * Extension Results, this is typically not specified, as 
         * dollar limits are noted as information codes.</p> Paid 
         * Amount <p>Grand total of all SOFA observations contained in 
         * this summary</p> <p>For Coverage Extension Results, this is 
         * typically not specified, as dollar limits are noted as 
         * information codes.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"netAmt"})]
        public Money NetAmt {
            get { return this.netAmt.Value; }
            set { this.netAmt.Value = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"author"})]
        public Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r01.Claims.Merged.Adjudicator Author {
            get { return this.author; }
            set { this.author = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"predecessor/adjudicatedInvoiceElementGroup"})]
        public Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r01.Claims.Merged.AdjudicationResultIdentifier PredecessorAdjudicatedInvoiceElementGroup {
            get { return this.predecessorAdjudicatedInvoiceElementGroup; }
            set { this.predecessorAdjudicatedInvoiceElementGroup = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"reference/adjudicatedInvoiceElementGroup"})]
        public IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r01.Claims.Merged.AdjudicatedInvoiceElementGroup> ReferenceAdjudicatedInvoiceElementGroup {
            get { return this.referenceAdjudicatedInvoiceElementGroup; }
        }

        [Hl7XmlMappingAttribute(new string[] {"coverage"})]
        public IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r01.Claims.Ficr_mt610201ca.AdjudicatedInvoiceCoverage> Coverage {
            get { return this.coverage; }
        }

        [Hl7XmlMappingAttribute(new string[] {"component"})]
        public IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r01.Claims.Ficr_mt610201ca.ComponentInvoiceElement> Component {
            get { return this.component; }
        }

        [Hl7XmlMappingAttribute(new string[] {"referencedBy/adjudResultsGroup"})]
        public Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r01.Claims.Merged.AdjudicatedResultsGroup ReferencedByAdjudResultsGroup {
            get { return this.referencedByAdjudResultsGroup; }
            set { this.referencedByAdjudResultsGroup = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"outcomeOf"})]
        public Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r01.Claims.Qucr_mt830201ca.AdjudicatedResultOutcome OutcomeOf {
            get { return this.outcomeOf; }
            set { this.outcomeOf = value; }
        }

    }

}