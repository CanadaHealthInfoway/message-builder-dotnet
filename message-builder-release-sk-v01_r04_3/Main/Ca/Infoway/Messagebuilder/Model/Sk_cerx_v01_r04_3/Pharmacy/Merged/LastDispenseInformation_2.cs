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
namespace Ca.Infoway.Messagebuilder.Model.Sk_cerx_v01_r04_3.Pharmacy.Merged {
    using Ca.Infoway.Messagebuilder.Annotation;
    using Ca.Infoway.Messagebuilder.Datatype;
    using Ca.Infoway.Messagebuilder.Datatype.Impl;
    using Ca.Infoway.Messagebuilder.Datatype.Lang;
    using Ca.Infoway.Messagebuilder.Model;
    using System;


    /**
     * <summary>LastDispenseInformation</summary>
     * 
     * <remarks>PORX_MT060060CA.SupplyEventLastSummary: Last 
     * Dispense Information <p>Provides summary information about 
     * the most recent dispense event performed against the 
     * prescription</p> <p>Useful in understanding the status of a 
     * prescription and in planning for renewals.</p> 
     * PORX_MT060040CA.SupplyEventLastSummary: Last Dispense 
     * Information <p>Provides summary information about the most 
     * recent dispense event performed against the prescription</p> 
     * <p>Useful in understanding the status of a prescription and 
     * in planning for renewals.</p></remarks>
     */
    [Hl7PartTypeMappingAttribute(new string[] {"PORX_MT060040CA.SupplyEventLastSummary","PORX_MT060060CA.SupplyEventLastSummary"})]
    public class LastDispenseInformation_2 : MessagePartBean {

        private IVL<TS, Interval<PlatformDate>> effectiveTime;
        private INT quantity;

        public LastDispenseInformation_2() {
            this.effectiveTime = new IVLImpl<TS, Interval<PlatformDate>>();
            this.quantity = new INTImpl();
        }
        /**
         * <summary>LastDispensePickupDate</summary>
         * 
         * <remarks>A:Last Dispense Pickup Date <p>Indicates the most 
         * recent date on which a dispense on the prescription was 
         * picked up.</p> <p>Useful in determining when a prescription 
         * will next need to be dispensed. Also provides an indication 
         * of compliance.</p> Last Dispense Pickup Date <p>Indicates 
         * the most recent date on which a dispense on the prescription 
         * was picked up.</p> <p>Useful in determining when a 
         * prescription will next need to be dispensed. Also provides 
         * an indication of compliance.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"effectiveTime"})]
        public Interval<PlatformDate> EffectiveTime {
            get { return this.effectiveTime.Value; }
            set { this.effectiveTime.Value = value; }
        }

        /**
         * <summary>LastQuantityDispensed</summary>
         * 
         * <remarks>Last Quantity Dispensed <p>Indicates the most 
         * recent quantity of the drug that was picked up for the 
         * prescription.</p> <p>Useful in determining number of devices 
         * that a patient should have on-hand. Also provides an 
         * indication of compliance.</p><p>If the last dispense is 
         * known, then the quantity must be known, thus the element is 
         * mandatory.</p> <p>Useful in determining number of devices 
         * that a patient should have on-hand. Also provides an 
         * indication of compliance.</p><p>If the last dispense is 
         * known, then the quantity must be known, thus the element is 
         * mandatory.</p> B:Last Quantity Dispensed <p>Indicates the 
         * most recent quantity of the drug that was picked up for the 
         * prescription.</p> <p>Useful in determining number of devices 
         * that a patient should have on-hand. Also provides an 
         * indication of compliance.</p><p>Because the quantity should 
         * always be known if the last dispense is known, this 
         * attribute is mandatory.</p> <p>Useful in determining number 
         * of devices that a patient should have on-hand. Also provides 
         * an indication of compliance.</p><p>Because the quantity 
         * should always be known if the last dispense is known, this 
         * attribute is mandatory.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"quantity"})]
        public int? Quantity {
            get { return this.quantity.Value; }
            set { this.quantity.Value = value; }
        }

    }

}