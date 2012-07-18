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
 * Last modified: $LastChangedDate: 2012-02-16 11:06:56 -0500 (Thu, 16 Feb 2012) $
 * Revision:      $LastChangedRevision: 5470 $
 */
/* This class was auto-generated by the message builder generator tools. */
namespace Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r01.Pharmacy.Merged {
    using Ca.Infoway.Messagebuilder.Annotation;
    using Ca.Infoway.Messagebuilder.Datatype;
    using Ca.Infoway.Messagebuilder.Datatype.Impl;
    using Ca.Infoway.Messagebuilder.Model;
    using System;


    /**
     * <summary>RemainingDispenseInformation</summary>
     * 
     * <remarks>PORX_MT060040CA.SupplyEventFutureSummary: Remaining 
     * Dispense Information <p>At least one of quantity and 
     * repeatNumber must be specified.</p> <p>Provides summary 
     * information about what dispenses remain to be performed 
     * against the prescription</p> <p>Useful in understanding the 
     * status of a prescription and in planning for renewals.</p> 
     * PORX_MT060060CA.SupplyEventFutureSummary: Remaining Dispense 
     * Information <p>At least one of quantity and repeatNumber 
     * must be specified.</p> <p>Provides summary information about 
     * what dispenses remain to be performed against the 
     * prescription</p> <p>Useful in understanding the status of a 
     * prescription and in planning for renewals.</p></remarks>
     */
    [Hl7PartTypeMappingAttribute(new string[] {"PORX_MT060040CA.SupplyEventFutureSummary","PORX_MT060060CA.SupplyEventFutureSummary"})]
    public class RemainingDispenseInformation_2 : MessagePartBean {

        private INT repeatNumber;
        private INT quantity;

        public RemainingDispenseInformation_2() {
            this.repeatNumber = new INTImpl();
            this.quantity = new INTImpl();
        }
        /**
         * <summary>FillsRemaining</summary>
         * 
         * <remarks>A:Fills Remaining <p>Indicates the number of 
         * remaining dispenses estimated, assuming that each fill is 
         * equal to the quantity prescribed for a single fill, rounding 
         * up.</p> <p>Indicates the number of dispenses that may still 
         * occur.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"repeatNumber"})]
        public int? RepeatNumber {
            get { return this.repeatNumber.Value; }
            set { this.repeatNumber.Value = value; }
        }

        /**
         * <summary>RemainingTotalQuantity</summary>
         * 
         * <remarks>B:Remaining Total Quantity <p>Indicates the total 
         * remaining undispensed quantity authorized against the 
         * prescription.</p> <p>Indicates how much can still be 
         * dispensed.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"quantity"})]
        public int? Quantity {
            get { return this.quantity.Value; }
            set { this.quantity.Value = value; }
        }

    }

}