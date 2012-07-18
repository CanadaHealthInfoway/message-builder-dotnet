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
 * Last modified: $LastChangedDate: 2012-01-18 21:10:42 -0500 (Wed, 18 Jan 2012) $
 * Revision:      $LastChangedRevision: 3991 $
 */

/* This class was auto-generated by the message builder generator tools. */
namespace Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Pharmacy.Merged {
    using Ca.Infoway.Messagebuilder.Annotation;
    using Ca.Infoway.Messagebuilder.Datatype;
    using Ca.Infoway.Messagebuilder.Datatype.Impl;
    using Ca.Infoway.Messagebuilder.Datatype.Lang;
    using Ca.Infoway.Messagebuilder.Model;
    using System;


    /**
     * <summary>PORX_MT060160CA.SubsequentSupplyRequest: (no 
     * business name)</summary>
     * 
     * <remarks><p>Dispensing instruction for all dispenses 
     * subsequent to the first fill.</p> 
     * PORX_MT060340CA.SubsequentSupplyRequest: (no business name) 
     * <p>Dispensing instruction for all dispenses subsequent to 
     * the first fill.</p></remarks>
     */
    [Hl7PartTypeMappingAttribute(new string[] {"PORX_MT010120CA.SubsequentSupplyRequest","PORX_MT060160CA.SubsequentSupplyRequest","PORX_MT060340CA.SubsequentSupplyRequest"})]
    public class SubsequentSupplyRequest : MessagePartBean {

        private IVL<TS, Interval<PlatformDate>> dispenseInterval;
        private INT numberOfFills;
        private PQ fillQuantity;
        private IVL<TS, Interval<PlatformDate>> daysSupply;

        public SubsequentSupplyRequest() {
            this.dispenseInterval = new IVLImpl<TS, Interval<PlatformDate>>();
            this.numberOfFills = new INTImpl();
            this.fillQuantity = new PQImpl();
            this.daysSupply = new IVLImpl<TS, Interval<PlatformDate>>();
        }
        /**
         * <summary>DispenseInterval</summary>
         * 
         * <remarks>F:Dispense Interval <p>Indicates a minimum amount 
         * of time that must occur between dispenses.</p> <p>Helps the 
         * prescriber ensure that the patient does not ever receive 
         * more than the appropriate amount of medication in a 
         * particular timeframe.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"effectiveTime"})]
        public Interval<PlatformDate> DispenseInterval {
            get { return this.dispenseInterval.Value; }
            set { this.dispenseInterval.Value = value; }
        }

        /**
         * <summary>NumberOfFills</summary>
         * 
         * <remarks>G:Number of Fills <p>The number of times the 
         * prescribed quantity is to be dispensed including the initial 
         * standard fill.</p> <p>Used to calculate total prescribed 
         * quantity; and also used for compliance 
         * checking.</p><p>Expressed as Number of Fills rather than 
         * number of refills due to HL7 modeling constraints.</p> 
         * <p>Used to calculate total prescribed quantity; and also 
         * used for compliance checking.</p><p>Expressed as Number of 
         * Fills rather than number of refills due to HL7 modeling 
         * constraints.</p> G:Number of Fills <p>The number of times 
         * the prescribed quantity is to be dispensed, including the 
         * initial standard fill.</p> 
         * <p>D54.03</p><p>DRU.060-02</p><p>Claim,415-DF</p><p>ZDP.15.1</p><p>Prescription.numberOfRefills</p> 
         * <p>D54.03</p><p>DRU.060-02</p><p>Claim,415-DF</p><p>ZDP.15.1</p><p>Prescription.numberOfRefills</p> 
         * <p>D54.03</p><p>DRU.060-02</p><p>Claim,415-DF</p><p>ZDP.15.1</p><p>Prescription.numberOfRefills</p> 
         * <p>D54.03</p><p>DRU.060-02</p><p>Claim,415-DF</p><p>ZDP.15.1</p><p>Prescription.numberOfRefills</p> 
         * <p>D54.03</p><p>DRU.060-02</p><p>Claim,415-DF</p><p>ZDP.15.1</p><p>Prescription.numberOfRefills</p> 
         * <p>Used to calculate total prescribed quantity; and also 
         * used for compliance checking.</p><p>Expressed as Number of 
         * Fills rather than number of refills due to HL7 modeling 
         * constraints.</p> <p>Used to calculate total prescribed 
         * quantity; and also used for compliance 
         * checking.</p><p>Expressed as Number of Fills rather than 
         * number of refills due to HL7 modeling constraints.</p> 
         * G:Number of Fills <p>The number of times the prescribed 
         * quantity is to be dispensed including the initial standard 
         * fill.</p> 
         * <p>D54.03</p><p>DRU.060-02</p><p>Claim,415-DF</p><p>ZDP.15.1</p><p>Prescription.numberOfRefills</p> 
         * <p>D54.03</p><p>DRU.060-02</p><p>Claim,415-DF</p><p>ZDP.15.1</p><p>Prescription.numberOfRefills</p> 
         * <p>D54.03</p><p>DRU.060-02</p><p>Claim,415-DF</p><p>ZDP.15.1</p><p>Prescription.numberOfRefills</p> 
         * <p>D54.03</p><p>DRU.060-02</p><p>Claim,415-DF</p><p>ZDP.15.1</p><p>Prescription.numberOfRefills</p> 
         * <p>D54.03</p><p>DRU.060-02</p><p>Claim,415-DF</p><p>ZDP.15.1</p><p>Prescription.numberOfRefills</p> 
         * <p>Used to calculate total prescribed quantity; and also 
         * used for compliance checking.</p><p>Expressed as Number of 
         * Fills rather than number of refills due to HL7 modeling 
         * constraints.</p> <p>Used to calculate total prescribed 
         * quantity; and also used for compliance 
         * checking.</p><p>Expressed as Number of Fills rather than 
         * number of refills due to HL7 modeling constraints.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"repeatNumber"})]
        public int? NumberOfFills {
            get { return this.numberOfFills.Value; }
            set { this.numberOfFills.Value = value; }
        }

        /**
         * <summary>FillQuantity</summary>
         * 
         * <remarks>D:Fill Quantity <p>The amount of medication to be 
         * dispensed to the patient for each normal fill (excluding 
         * trial or other special first fills).</p> 
         * <p>Prescription.fillAmount</p><p>Prescription.maximumDispensedAmount 
         * (when SupplyRequest.effectiveTime id populated with an 
         * interval)</p><p>Quantity</p> 
         * <p>Prescription.fillAmount</p><p>Prescription.maximumDispensedAmount 
         * (when SupplyRequest.effectiveTime id populated with an 
         * interval)</p><p>Quantity</p> 
         * <p>Prescription.fillAmount</p><p>Prescription.maximumDispensedAmount 
         * (when SupplyRequest.effectiveTime id populated with an 
         * interval)</p><p>Quantity</p> <p>Limits the quantity of 
         * medication in patient's possession at a time. Used in 
         * compliance checking</p> D:Fill Quantity <p>The amount of 
         * medication to be dispensed to the patient for each normal 
         * fill (excluding trial or other special first fills).</p> 
         * <p>Limits the quantity of medication in patient's possession 
         * at a time. Used in compliance checking.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"quantity"})]
        public PhysicalQuantity FillQuantity {
            get { return this.fillQuantity.Value; }
            set { this.fillQuantity.Value = value; }
        }

        /**
         * <summary>DaysSupply</summary>
         * 
         * <remarks>E:Days Supply <p>The number of days that each 
         * standard fill is expected to last. The dispenser must use 
         * the administration instructions together with the Days 
         * Supply to calculate the total quantity to dispense per fill. 
         * May be specified in addition to quantity to indicate the 
         * length of time a quantity of 'as needed' medication is 
         * expected to last.</p> <p>Useful in determining and managing 
         * certain contraindications ('Fill-Too-Soon', 'Fill-Too-Late', 
         * and 'Duration of Therapy'). Also provides guidance to the 
         * pharmacy on how much to dispense. Also useful in 
         * research.</p> E:Days Supply <p>The number of days that each 
         * standard fill is expected to last. The dispenser must use 
         * the administration instructions together with the Days 
         * Supply to calculate the total quantity to dispense per fill. 
         * May be specified in addition to quantity to indicate the 
         * length of time a quantity of &quot;as needed&quot; 
         * medication is expected to last.</p> <p>Useful in determining 
         * and managing certain contraindications ('Fill-Too-Soon', 
         * 'Fill-Too-Late', and 'Duration of Therapy'). Also provides 
         * guidance to the pharmacy on how much to dispense. Also 
         * useful in research</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"expectedUseTime"})]
        public Interval<PlatformDate> DaysSupply {
            get { return this.daysSupply.Value; }
            set { this.daysSupply.Value = value; }
        }

    }

}