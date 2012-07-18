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
namespace Ca.Infoway.Messagebuilder.Model.Sk_cerx_v01_r04_3.Pharmacy.Porx_mt010120ca {
    using Ca.Infoway.Messagebuilder.Annotation;
    using Ca.Infoway.Messagebuilder.Datatype;
    using Ca.Infoway.Messagebuilder.Datatype.Impl;
    using Ca.Infoway.Messagebuilder.Datatype.Lang;
    using Ca.Infoway.Messagebuilder.Model;
    using Ca.Infoway.Messagebuilder.Model.Sk_cerx_v01_r04_3.Common.Coct_mt040205ca;
    using Ca.Infoway.Messagebuilder.Model.Sk_cerx_v01_r04_3.Merged;
    using Ca.Infoway.Messagebuilder.Model.Sk_cerx_v01_r04_3.Pharmacy.Merged;
    using System;
    using System.Collections.Generic;


    /**
     * <summary>Dispense Instructions</summary>
     * 
     * <remarks><p>Specification of how the prescribed medication 
     * is to be dispensed to the patient. Dispensed instruction 
     * information includes the quantity to be dispensed, how often 
     * the quantity is to be dispensed, etc.</p> 
     * <p>A_BillablePharmacyDispense</p> <p>Sets the parameters 
     * within which the dispenser must operate in dispensing the 
     * medication to the patient.</p></remarks>
     */
    [Hl7PartTypeMappingAttribute(new string[] {"PORX_MT010120CA.SupplyRequest"})]
    public class DispenseInstructions : MessagePartBean {

        private IVL<TS, Interval<PlatformDate>> effectiveTime;
        private IList<Ca.Infoway.Messagebuilder.Model.Sk_cerx_v01_r04_3.Common.Coct_mt040205ca.ResponsiblePerson> receiverResponsibleParty;
        private Ca.Infoway.Messagebuilder.Model.Sk_cerx_v01_r04_3.Merged.RecordedAt location;
        private Ca.Infoway.Messagebuilder.Model.Sk_cerx_v01_r04_3.Pharmacy.Merged.DispenseShipToLocation destinationServiceDeliveryLocation;
        private IList<Ca.Infoway.Messagebuilder.Model.Sk_cerx_v01_r04_3.Pharmacy.Porx_mt010120ca.DrugDispenseInstructions> componentSupplyRequestItem;

        public DispenseInstructions() {
            this.effectiveTime = new IVLImpl<TS, Interval<PlatformDate>>();
            this.receiverResponsibleParty = new List<Ca.Infoway.Messagebuilder.Model.Sk_cerx_v01_r04_3.Common.Coct_mt040205ca.ResponsiblePerson>();
            this.componentSupplyRequestItem = new List<Ca.Infoway.Messagebuilder.Model.Sk_cerx_v01_r04_3.Pharmacy.Porx_mt010120ca.DrugDispenseInstructions>();
        }
        /**
         * <summary>A:Dispensing Allowed Period</summary>
         * 
         * <remarks><p>This indicates the validity period of a 
         * prescription (stale dating the Prescription).</p><p>It 
         * reflects the prescriber perspective for the validity of the 
         * prescription. Dispenses must not be made against the 
         * prescription outside of this period. The lower-bound of the 
         * Prescription Effective Period signifies the earliest date 
         * that the prescription can be filled for the first time. If 
         * an upper-bound is not specified then the Prescription is 
         * open-ended or will default to a stale-date based on 
         * regulations.</p> <p>This indicates the validity period of a 
         * prescription (stale dating the Prescription).</p><p>It 
         * reflects the prescriber perspective for the validity of the 
         * prescription. Dispenses must not be made against the 
         * prescription outside of this period. The lower-bound of the 
         * Prescription Effective Period signifies the earliest date 
         * that the prescription can be filled for the first time. If 
         * an upper-bound is not specified then the Prescription is 
         * open-ended or will default to a stale-date based on 
         * regulations.</p> <p>ZPB3.9</p><p>DRU.040-02 (low, 
         * qualifier=07, format=102) eScript:DRU.040-02 (low, 
         * qualifier=36, format=102) HC-SA:Number of days (width) 
         * HC-SA:When will drug be administered?(low) PECS:ZDP.17 
         * (high) PEI:Last date dispensed(when summary type is 'most 
         * recent')</p><p>Prescription.dispensingInterval(period)</p><p>Prescription.effectiveDate 
         * (low) PIN:Prescription.expiryDate (high)</p> 
         * <p>ZPB3.9</p><p>DRU.040-02 (low, qualifier=07, format=102) 
         * eScript:DRU.040-02 (low, qualifier=36, format=102) 
         * HC-SA:Number of days (width) HC-SA:When will drug be 
         * administered?(low) PECS:ZDP.17 (high) PEI:Last date 
         * dispensed(when summary type is 'most 
         * recent')</p><p>Prescription.dispensingInterval(period)</p><p>Prescription.effectiveDate 
         * (low) PIN:Prescription.expiryDate (high)</p> 
         * <p>ZPB3.9</p><p>DRU.040-02 (low, qualifier=07, format=102) 
         * eScript:DRU.040-02 (low, qualifier=36, format=102) 
         * HC-SA:Number of days (width) HC-SA:When will drug be 
         * administered?(low) PECS:ZDP.17 (high) PEI:Last date 
         * dispensed(when summary type is 'most 
         * recent')</p><p>Prescription.dispensingInterval(period)</p><p>Prescription.effectiveDate 
         * (low) PIN:Prescription.expiryDate (high)</p> 
         * <p>ZPB3.9</p><p>DRU.040-02 (low, qualifier=07, format=102) 
         * eScript:DRU.040-02 (low, qualifier=36, format=102) 
         * HC-SA:Number of days (width) HC-SA:When will drug be 
         * administered?(low) PECS:ZDP.17 (high) PEI:Last date 
         * dispensed(when summary type is 'most 
         * recent')</p><p>Prescription.dispensingInterval(period)</p><p>Prescription.effectiveDate 
         * (low) PIN:Prescription.expiryDate (high)</p> <p>Indicates 
         * when the Prescription becomes valid, and when it ceases to 
         * be a dispensable Prescription.</p><p>Some jurisdictions 
         * place a 'stale date' on prescriptions that cause them to 
         * become invalid a certain amount of time after they are 
         * written. This time may vary by medication.</p> <p>Indicates 
         * when the Prescription becomes valid, and when it ceases to 
         * be a dispensable Prescription.</p><p>Some jurisdictions 
         * place a 'stale date' on prescriptions that cause them to 
         * become invalid a certain amount of time after they are 
         * written. This time may vary by medication.</p> <p><strong>If 
         * specified, this interval will be used to set the 
         * Prescription Effective Date and the Prescription Last Fill 
         * Expiry Date. If not specified, the Prescription Effective 
         * Date will be set to the effective date of the Control Act 
         * Event.</strong></p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"effectiveTime"})]
        public Interval<PlatformDate> EffectiveTime {
            get { return this.effectiveTime.Value; }
            set { this.effectiveTime.Value = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"receiver/responsibleParty"})]
        public IList<Ca.Infoway.Messagebuilder.Model.Sk_cerx_v01_r04_3.Common.Coct_mt040205ca.ResponsiblePerson> ReceiverResponsibleParty {
            get { return this.receiverResponsibleParty; }
        }

        /**
         * <summary><div>responsibility for dispensing the 
         * prescription.&nbsp;</div></summary>
         * 
         * <remarks><div>assigned to a pharmacy outside of the&nbsp;PIN 
         * CeRx Business Requirements&nbsp;jurisdiction&rsquo;s list of 
         * pharmacies.&nbsp;</div></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"location"})]
        public Ca.Infoway.Messagebuilder.Model.Sk_cerx_v01_r04_3.Merged.RecordedAt Location {
            get { return this.location; }
            set { this.location = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"destination/serviceDeliveryLocation"})]
        public Ca.Infoway.Messagebuilder.Model.Sk_cerx_v01_r04_3.Pharmacy.Merged.DispenseShipToLocation DestinationServiceDeliveryLocation {
            get { return this.destinationServiceDeliveryLocation; }
            set { this.destinationServiceDeliveryLocation = value; }
        }

        /**
         * <summary><div>dispensed.</div></summary>
         */
        [Hl7XmlMappingAttribute(new string[] {"component/supplyRequestItem"})]
        public IList<Ca.Infoway.Messagebuilder.Model.Sk_cerx_v01_r04_3.Pharmacy.Porx_mt010120ca.DrugDispenseInstructions> ComponentSupplyRequestItem {
            get { return this.componentSupplyRequestItem; }
        }

    }

}