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
namespace Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Pharmacy.Merged {
    using Ca.Infoway.Messagebuilder.Annotation;
    using Ca.Infoway.Messagebuilder.Datatype;
    using Ca.Infoway.Messagebuilder.Datatype.Impl;
    using Ca.Infoway.Messagebuilder.Datatype.Lang;
    using Ca.Infoway.Messagebuilder.Model;
    using System;


    /**
     * <summary>FirstDispenseInformation</summary>
     * 
     * <remarks>PORX_MT060060CA.SupplyEventFirstSummary: First 
     * Dispense Information <p>Provides summary information about 
     * the first dispense event on the prescription</p> <p>Useful 
     * in understanding the status of a prescription and in 
     * planning for renewals.</p> 
     * PORX_MT060040CA.SupplyEventFirstSummary: First Dispense 
     * Information <p>Provides summary information about the first 
     * dispense event on the prescription</p> <p>Useful in 
     * understanding the status of a prescription and in planning 
     * for renewals.</p></remarks>
     */
    [Hl7PartTypeMappingAttribute(new string[] {"PORX_MT060040CA.SupplyEventFirstSummary","PORX_MT060060CA.SupplyEventFirstSummary"})]
    public class FirstDispenseInformation_2 : MessagePartBean {

        private IVL<TS, Interval<PlatformDate>> effectiveTime;
        private INT quantity;

        public FirstDispenseInformation_2() {
            this.effectiveTime = new IVLImpl<TS, Interval<PlatformDate>>();
            this.quantity = new INTImpl();
        }
        /**
         * <summary>FirstDispensePickupDate</summary>
         * 
         * <remarks>A:First Dispense Pickup Date <p>Indicates when the 
         * first dispense against the prescription was picked up.</p> 
         * <p>Useful in establishing start of therapy.</p><p>Important 
         * information for compliance.</p> <p>Useful in establishing 
         * start of therapy.</p><p>Important information for 
         * compliance.</p> First Dispense Pickup Date <p>Indicates when 
         * the first dispense against the prescription was picked 
         * up.</p> <p>Useful in establishing start of 
         * therapy.</p><p>Important information for compliance.</p> 
         * <p>Useful in establishing start of therapy.</p><p>Important 
         * information for compliance.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"effectiveTime"})]
        public Interval<PlatformDate> EffectiveTime {
            get { return this.effectiveTime.Value; }
            set { this.effectiveTime.Value = value; }
        }

        /**
         * <summary>FirstQuantityDispensed</summary>
         * 
         * <remarks>B:First Quantity Dispensed <p>Indicates the number 
         * of devices first dispensed on the prescription.</p> 
         * <p>Usually establishes trial quantities for a 
         * prescription.</p><p>Because the quantity should always be 
         * known if the first dispense is known, this attribute is 
         * mandatory.</p> <p>Usually establishes trial quantities for a 
         * prescription.</p><p>Because the quantity should always be 
         * known if the first dispense is known, this attribute is 
         * mandatory.</p> First Quantity Dispensed <p>Indicates the 
         * amount of device first dispensed on the prescription.</p> 
         * <p>Usually establishes trial quantities for a prescription. 
         * If the first dispense is known, then the quantity must be 
         * known, thus the element is mandatory.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"quantity"})]
        public int? Quantity {
            get { return this.quantity.Value; }
            set { this.quantity.Value = value; }
        }

    }

}