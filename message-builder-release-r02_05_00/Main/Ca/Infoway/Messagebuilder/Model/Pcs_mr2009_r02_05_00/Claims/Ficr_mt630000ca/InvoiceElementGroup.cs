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
namespace Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_05_00.Claims.Ficr_mt630000ca {
    using Ca.Infoway.Messagebuilder.Annotation;
    using Ca.Infoway.Messagebuilder.Datatype;
    using Ca.Infoway.Messagebuilder.Datatype.Impl;
    using Ca.Infoway.Messagebuilder.Datatype.Lang;
    using Ca.Infoway.Messagebuilder.Model;
    using Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_05_00.Claims.Merged;
    using Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_05_00.Domainvalue;
    using System.Collections.Generic;


    [Hl7PartTypeMappingAttribute(new string[] {"FICR_MT630000CA.InvoiceElementGroup"})]
    public class InvoiceElementGroup : MessagePartBean {

        private II id;
        private CV code;
        private MO netAmt;
        private IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_05_00.Claims.Merged.AdjudicationResultIdentifier> referenceAdjudicatedInvoiceElementGroup;

        public InvoiceElementGroup() {
            this.id = new IIImpl();
            this.code = new CVImpl();
            this.netAmt = new MOImpl();
            this.referenceAdjudicatedInvoiceElementGroup = new List<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_05_00.Claims.Merged.AdjudicationResultIdentifier>();
        }
        /**
         * <summary>Business Name: Invoice Group ID</summary>
         * 
         * <remarks>Relationship: 
         * FICR_MT630000CA.InvoiceElementGroup.id 
         * Conformance/Cardinality: MANDATORY (1) <p>Invoice Grouping 
         * Identifier: There are some situations where more than 1 
         * identifier for this object can be included in a message.</p> 
         * <p>May include data centre and sequence numbers</p><p>1. 
         * unique invoice group identifier, independent of adjudicator 
         * recipient.</p><p>2. sequential invoice grouping identifier 
         * by adjudicator.</p><p>Obligation on adjudicator is to return 
         * and communicate about this item with all identifiers (i.e. 
         * identifier 1. and 2.).</p> <p>Set of identifiers that 
         * uniquely identify the Invoice Grouping.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"id"})]
        public Identifier Id {
            get { return this.id.Value; }
            set { this.id.Value = value; }
        }

        /**
         * <summary>Business Name: Invoice Type</summary>
         * 
         * <remarks>Relationship: 
         * FICR_MT630000CA.InvoiceElementGroup.code 
         * Conformance/Cardinality: MANDATORY (1) <p>Invoice Type is 
         * the indication to the payor as to the content rules to apply 
         * when processing and adjudicating the invoice. Basically, the 
         * structure of the invoice grouping. Ie. Clinical Product, 
         * Clinical Service, Preferred Accom, Rx Dispense, Rx 
         * Compound</p><p>This is used to indicate the type of Invoice 
         * Grouping.</p><p>Each Invoice Type is used to specify 1. 
         * vocabulary, 2. structure of the Invoice Element Choice and 
         * 3. which Billable Act(s) can be included for the specified 
         * Invoice Type.</p><p>Information on constraints for the 
         * Invoice Type will be found in the NeCST Message 
         * Specifications. Each Benefit Group will indicate which 
         * Invoice Types will be supported by that Benefit 
         * Group.</p><p>Invoice Types will not generate unique and 
         * distinct XML schemas that can tested independent of each 
         * other. They must be tested together within an Message 
         * Type.</p> <p>Invoice Type - Health Care Services/Goods, Rx 
         * Dispense, Rx compound, Preferred Accom.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"code"})]
        public ActInvoiceGroupType Code {
            get { return (ActInvoiceGroupType) this.code.Value; }
            set { this.code.Value = value; }
        }

        /**
         * <summary>Business Name: Invoice Sub-total</summary>
         * 
         * <remarks>Relationship: 
         * FICR_MT630000CA.InvoiceElementGroup.netAmt 
         * Conformance/Cardinality: MANDATORY (1) <p>This is the sum of 
         * the Submitted Invoice Line amounts.</p> <p>For Cancel 
         * Request: This would serve as a cross-check for the 
         * Adjudicator for the Invoice Grouping that is being 
         * cancelled.</p><p>Attribute cannot be mandatory as it may not 
         * be present for a Coverage Extension Request.</p> <p>Invoice 
         * Sub-total - Identifies the total monetary amount billed for 
         * the invoice element.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"netAmt"})]
        public Money NetAmt {
            get { return this.netAmt.Value; }
            set { this.netAmt.Value = value; }
        }

        /**
         * <summary>Relationship: 
         * FICR_MT630000CA.PreviousAdjudicationResultReference.adjudicatedInvoiceElementGroup</summary>
         * 
         * <remarks>Conformance/Cardinality: REQUIRED (1)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"reference/adjudicatedInvoiceElementGroup"})]
        public IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_05_00.Claims.Merged.AdjudicationResultIdentifier> ReferenceAdjudicatedInvoiceElementGroup {
            get { return this.referenceAdjudicatedInvoiceElementGroup; }
        }

    }

}