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
namespace Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_05_00.Claims.Merged {
    using Ca.Infoway.Messagebuilder.Annotation;
    using Ca.Infoway.Messagebuilder.Datatype;
    using Ca.Infoway.Messagebuilder.Datatype.Impl;
    using Ca.Infoway.Messagebuilder.Datatype.Lang;
    using Ca.Infoway.Messagebuilder.Model;
    using Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_05_00.Domainvalue;


    /**
     * <summary>QUCR_MT810201CA.AdjudResultsGroupSummaryData: 
     * Adjudicated Results Group Summary Data</summary>
     * 
     * <p>Used for SOFA queries only</p> <p>Summary Data for this 
     * Group of Adjudicated Results</p> 
     * FICR_MT610201CA.AdjudResultsGroupSummaryData: (no business 
     * name) <p>Used for SOFA queries only</p> 
     * FICR_MT630000CA.AdjudResultsGroupSummaryData: Summary 
     * Details <p>Summarised Details of the Adjudicated Results for 
     * a group of Invoice elements/line items.</p>
     */
    [Hl7PartTypeMappingAttribute(new string[] {"FICR_MT610201CA.AdjudResultsGroupSummaryData","FICR_MT630000CA.AdjudResultsGroupSummaryData","QUCR_MT810201CA.AdjudResultsGroupSummaryData"})]
    public class SummaryDetails : MessagePartBean {

        private CV code;
        private PQ value;

        public SummaryDetails() {
            this.code = new CVImpl();
            this.value = new PQImpl();
        }
        /**
         * <summary>Un-merged Business Name: SummaryInformation</summary>
         * 
         * <remarks>Relationship: 
         * QUCR_MT810201CA.AdjudResultsGroupSummaryData.code 
         * Conformance/Cardinality: REQUIRED (1) Un-merged Business 
         * Name: SummaryTypeCode Relationship: 
         * FICR_MT610201CA.AdjudResultsGroupSummaryData.code 
         * Conformance/Cardinality: REQUIRED (1) Un-merged Business 
         * Name: SummaryPeriodAmt Relationship: 
         * FICR_MT630000CA.AdjudResultsGroupSummaryData.code 
         * Conformance/Cardinality: REQUIRED (1) <p>(defines the 
         * 'categorization'. Only really relevant for summaries.</p> 
         * <p>Summary Period Amt</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"code"})]
        public ActInvoiceElementSummaryType Code {
            get { return (ActInvoiceElementSummaryType) this.code.Value; }
            set { this.code.Value = value; }
        }

        /**
         * <summary>Un-merged Business Name: ValueOfSummary</summary>
         * 
         * <remarks>Relationship: 
         * QUCR_MT810201CA.AdjudResultsGroupSummaryData.value 
         * Conformance/Cardinality: REQUIRED (1) <p>Constrain Value to 
         * PQ or MO data types only</p> <p>PQ or MO - Value of 
         * summary</p> Un-merged Business Name: SummaryTotalAmount 
         * Relationship: 
         * FICR_MT610201CA.AdjudResultsGroupSummaryData.value 
         * Conformance/Cardinality: REQUIRED (1) Un-merged Business 
         * Name: SummaryTotalAmt Relationship: 
         * FICR_MT630000CA.AdjudResultsGroupSummaryData.value 
         * Conformance/Cardinality: REQUIRED (1) <p>Constrain Value to 
         * PQ or MO data types only</p> <p>PQ or MO only - Value of 
         * summary</p> <p>Summary Total Amt</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"value"})]
        public PhysicalQuantity Value {
            get { return this.value.Value; }
            set { this.value.Value = value; }
        }

    }

}