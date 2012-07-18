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
    using Ca.Infoway.Messagebuilder.Datatype.Lang;
    using Ca.Infoway.Messagebuilder.Model;


    /**
     * <summary>DispenseShipToLocation</summary>
     * 
     * <remarks>PORX_MT060160CA.ServiceDeliveryLocation: Dispense 
     * Ship-To Location <p>The location where the dispensed product 
     * is expected to be delivered.</p> <p>Important as part of a 
     * claim for justifying shipping charges.</p> 
     * PORX_MT060040CA.ServiceDeliveryLocation: Dispense Ship-To 
     * Location <p>The location where the dispensed product is 
     * expected to be delivered.</p> <p>Important as part of a 
     * claim for justifying shipping charges.</p> 
     * PORX_MT060340CA.ServiceDeliveryLocation: Dispense Ship-To 
     * Location <p>The location where the dispensed product is 
     * expected to be delivered.</p> <p>Important as part of a 
     * claim for justifying shipping charges.</p> 
     * PORX_MT020070CA.ServiceDeliveryLocation: Dispense Ship-To 
     * Location <p>The location where the dispensed product is 
     * expected to be delivered.</p> <p>Important as part of a 
     * claim for justifying shipping charges.</p> 
     * PORX_MT020060CA.ServiceDeliveryLocation: Dispense Ship-To 
     * Location <p>The location where the dispensed product is 
     * expected to be delivered.</p> <p>Important as part of a 
     * claim for justifying shipping charges.</p> 
     * PORX_MT060090CA.ServiceDeliveryLocation: Dispense Ship-To 
     * Location <p>The location where the dispensed product is 
     * expected to be delivered.</p> <p>Important as part of a 
     * claim for justifying shipping charges.</p> 
     * PORX_MT060010CA.ServiceDeliveryLocation: Dispense Ship-To 
     * Location <p>The location where the dispensed product is 
     * expected to be delivered.</p> <p>Important as part of a 
     * claim for justifying shipping charges.</p></remarks>
     */
    [Hl7PartTypeMappingAttribute(new string[] {"PORX_MT010110CA.ServiceDeliveryLocation","PORX_MT010120CA.ServiceDeliveryLocation","PORX_MT020060CA.ServiceDeliveryLocation","PORX_MT020070CA.ServiceDeliveryLocation","PORX_MT060010CA.ServiceDeliveryLocation","PORX_MT060040CA.ServiceDeliveryLocation","PORX_MT060040CA.ServiceDeliveryLocation2","PORX_MT060090CA.ServiceDeliveryLocation","PORX_MT060160CA.ServiceDeliveryLocation","PORX_MT060160CA.ServiceDeliveryLocation2","PORX_MT060340CA.ServiceDeliveryLocation","PORX_MT060340CA.ServiceDeliveryLocation2"})]
    public class DispenseShipToLocation : MessagePartBean {

        private AD addr;

        public DispenseShipToLocation() {
            this.addr = new ADImpl();
        }
        /**
         * <summary>I:Ship-To Address</summary>
         * 
         * <remarks><p>Indicates where the dispensed product was 
         * sent.</p> <p>Important as part of a claim for justifying 
         * shipping charges.</p> H:Prescription Ship to Address 
         * <p>Indicates the location the dispensed device should be 
         * shipped to, at the request of the patient or provider.</p> 
         * <p>In some cases devices need to be delivered to the patient 
         * instead of being picked up. In other cases, devices need to 
         * be shipped to the physician's office to replace stock used 
         * for the patient.</p> Ship To Address <p>Indicates where the 
         * dispensed product was sent.</p> <p>Important as part of a 
         * claim for justifying shipping charges.</p> H:Prescription 
         * Ship to Address <p>Indicates the location the dispensed 
         * medication should be shipped to, at the request of the 
         * patient or provider.</p> <p>In some cases drugs need to be 
         * delivered to the patient instead of being picked up. In 
         * other cases, drugs need to be shipped to the physician's 
         * office to replace stock used for the patient.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"addr"})]
        public PostalAddress Addr {
            get { return this.addr.Value; }
            set { this.addr.Value = value; }
        }

    }

}