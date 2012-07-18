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
    using Ca.Infoway.Messagebuilder.Model;


    /**
     * <summary>QUCR_MT810201CA.AdjudResultsGroupSummaryData: 
     * Adjudicated Results Group Summary Data</summary>
     * 
     * <remarks><p>Constrain Value to PQ or MO data types only</p> 
     * <p>Used for SOFA queries only</p> 
     * FICR_MT610201CA.AdjudResultsGroupSummaryData: Summary 
     * Details <p>Constrain Value to PQ or MO data types only</p> 
     * <p>Used for SOFA queries only</p> 
     * FICR_MT630000CA.AdjudResultsGroupSummaryData: Summary 
     * Details <p>Constrain Value to PQ or MO data types only</p></remarks>
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
         * <summary>Summary Period Amt</summary>
         * 
         * <remarks><p>Summary Period Amt</p> <p>(defines the 
         * 'categorization'. Only really relevant for summaries.</p> 
         * Summary Type Code <p>summary type</p> Code for Type of 
         * Adjudicated Result</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"code"})]
        public Code Code {
            get { return (Code) this.code.Value; }
            set { this.code.Value = value; }
        }

        /**
         * <summary>Summary Total Amount</summary>
         * 
         * <remarks><p>Summary Total</p> <p>Data type can be PQ or MO 
         * only.</p> Value of summary <p>PQ or MO - Value of 
         * summary</p> Summary Total Amt <p>Summary Total Amt</p> <p>PQ 
         * or MO only - Value of summary</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"value"})]
        public PhysicalQuantity Value {
            get { return this.value.Value; }
            set { this.value.Value = value; }
        }

    }

}