/**
 * Copyright 2013 Canada Health Infoway, Inc.
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
namespace Ca.Infoway.Messagebuilder.Model.Sk_cerx_v01_r04_2.Pharmacy.Merged {
    using Ca.Infoway.Messagebuilder.Annotation;
    using Ca.Infoway.Messagebuilder.Datatype;
    using Ca.Infoway.Messagebuilder.Datatype.Impl;
    using Ca.Infoway.Messagebuilder.Datatype.Lang;
    using Ca.Infoway.Messagebuilder.Domainvalue;
    using Ca.Infoway.Messagebuilder.Model;
    using Ca.Infoway.Messagebuilder.Model.Sk_cerx_v01_r04_2.Merged;
    using System;


    /**
     * <summary>Business Name: DispenseInstructions</summary>
     * 
     * <remarks>PORX_MT030040CA.SupplyRequest: Dispense 
     * Instructions <p>Specification of how the prescribed 
     * medication is to be dispensed to the patient. Dispensed 
     * instruction information includes the quantity to be 
     * dispensed, how often the quantity is to be dispensed, 
     * etc.</p> <p>A_BillablePharmacyDispense</p> <p>Sets the 
     * parameters within which the dispenser must operate in 
     * dispensing the medication to the patient.</p></remarks>
     */
    [Hl7PartTypeMappingAttribute(new string[] {"PORX_MT020070CA.SupplyRequest","PORX_MT030040CA.SupplyRequest","PORX_MT060190CA.SupplyRequest"})]
    public class DispenseInstructions_2 : MessagePartBean {

        private CS statusCode;
        private PQ quantity;
        private Ca.Infoway.Messagebuilder.Model.Sk_cerx_v01_r04_2.Merged.RecordedAt location;
        private IVL<TS, Interval<PlatformDate>> expectedUseTime;

        public DispenseInstructions_2() {
            this.statusCode = new CSImpl();
            this.quantity = new PQImpl();
            this.expectedUseTime = new IVLImpl<TS, Interval<PlatformDate>>();
        }
        /**
         * <summary>Un-merged Business Name: 
         * PrescriptionDispensableIndicator</summary>
         * 
         * <remarks>Relationship: 
         * PORX_MT060190CA.SupplyRequest.statusCode 
         * Conformance/Cardinality: MANDATORY (1) <p>This generally 
         * mirrors the status for the prescription, but in some 
         * circumstances may be changed to 'aborted' while the 
         * prescription is still active. When this occurs, it means the 
         * prescription may no longer be dispensed, though it may still 
         * be administered.</p> <p>Allows the dispensing authorization 
         * of the prescription to be controlled/manipulates as 
         * needed.</p><p>Attribute is marked as &quot;mandatory&quot; 
         * as the dispensing authority of the prescription will always 
         * be known.</p> <p>Allows the dispensing authorization of the 
         * prescription to be controlled/manipulates as 
         * needed.</p><p>Attribute is marked as &quot;mandatory&quot; 
         * as the dispensing authority of the prescription will always 
         * be known.</p> Un-merged Business Name: 
         * PrescriptionDispenseIndicator Relationship: 
         * PORX_MT030040CA.SupplyRequest.statusCode 
         * Conformance/Cardinality: MANDATORY (1) <p>This generally 
         * mirrors the status for the prescription, but in some 
         * circumstances may be changed to 'aborted' while the 
         * prescription is still active. When this occurs, it means the 
         * prescription may no longer be dispensed, though it may still 
         * be administered.</p> <p>Allows a prescriber to say 
         * &quot;Finish what you have on hand, but don't get any 
         * more.&quot;</p><p>Because the status should always be known, 
         * this element is mandatory.</p> <p>Allows a prescriber to say 
         * &quot;Finish what you have on hand, but don't get any 
         * more.&quot;</p><p>Because the status should always be known, 
         * this element is mandatory.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"statusCode"})]
        public ActStatus StatusCode {
            get { return (ActStatus) this.statusCode.Value; }
            set { this.statusCode.Value = value; }
        }

        /**
         * <summary>Business Name: TotalPrescribedQuantity</summary>
         * 
         * <remarks>Un-merged Business Name: TotalPrescribedQuantity 
         * Relationship: PORX_MT060190CA.SupplyRequest.quantity 
         * Conformance/Cardinality: REQUIRED (0-1) <p>The overall 
         * amount of amount medication to be dispensed under this 
         * prescription. Includes any first fills (trials, aligning 
         * quantities), the initial standard fill plus all refills.</p> 
         * <p>Sets upper limit for medication to be dispensed. Can be 
         * used to verify the intention of the prescriber with respect 
         * to the overall medication. Used for comparison when 
         * determining whether additional quantity may be dispensed in 
         * the context of a part-fill prescription.</p> Un-merged 
         * Business Name: TotalPrescribedQuantity Relationship: 
         * PORX_MT030040CA.SupplyRequest.quantity 
         * Conformance/Cardinality: REQUIRED (0-1) <p>The overall 
         * amount of amount medication to be dispensed under this 
         * prescription. Includes any first fills (trials, aligning 
         * quantities), the initial standard fill plus all refills.</p> 
         * <p>Sets upper limit for medication to be dispensed. Can be 
         * used to verify the intention of the prescriber with respect 
         * to the overall medication. Used for comparison when 
         * determining whether additional quantity may be dispensed in 
         * the context of a part-fill prescription.</p><p>Narcotics 
         * must always be specified as a total quantity.</p> <p>Sets 
         * upper limit for medication to be dispensed. Can be used to 
         * verify the intention of the prescriber with respect to the 
         * overall medication. Used for comparison when determining 
         * whether additional quantity may be dispensed in the context 
         * of a part-fill prescription.</p><p>Narcotics must always be 
         * specified as a total quantity.</p> Un-merged Business Name: 
         * TotalPrescribedQuantity Relationship: 
         * PORX_MT020070CA.SupplyRequest.quantity 
         * Conformance/Cardinality: REQUIRED (0-1) <p>The overall 
         * amount of amount medication to be dispensed under this 
         * prescription. Includes any first fills (trials, aligning 
         * quantities), the initial standard fill plus all refills.</p> 
         * <p>Critical in understanding the patient's medication 
         * profile, both past and current. This also allows 
         * determination of the amount that remains to be dispensed 
         * against the prescription.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"quantity"})]
        public PhysicalQuantity Quantity {
            get { return this.quantity.Value; }
            set { this.quantity.Value = value; }
        }

        /**
         * <summary>Un-merged Business Name: (no business name 
         * specified)</summary>
         * 
         * <remarks>Relationship: 
         * PORX_MT060190CA.SupplyRequest.location 
         * Conformance/Cardinality: POPULATED (1) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * PORX_MT030040CA.SupplyRequest.location 
         * Conformance/Cardinality: POPULATED (1) <div>Indicates the 
         * pharmacy to which the prescription</div> <div>has been 
         * directed or which has currently assumed</div> 
         * <p>responsibility for dispensing the prescription.&nbsp;</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"location"})]
        public Ca.Infoway.Messagebuilder.Model.Sk_cerx_v01_r04_2.Merged.RecordedAt Location {
            get { return this.location; }
            set { this.location = value; }
        }

        /**
         * <summary>Business Name: TotalDaysSupply</summary>
         * 
         * <remarks>Un-merged Business Name: TotalDaysSupply 
         * Relationship: PORX_MT020070CA.SupplyRequest.expectedUseTime 
         * Conformance/Cardinality: POPULATED (1) <p>The number of days 
         * that the overall prescribed item is expected to last, if the 
         * patient is compliant with the dispensing and administration 
         * of the prescription.</p> <p>Useful in monitoring patient 
         * compliance. May also be useful in determining and managing 
         * certain contraindications ('Fill-Too-Soon', 'Fill-Too-Late', 
         * and 'Duration of Therapy').</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"expectedUseTime"})]
        public Interval<PlatformDate> ExpectedUseTime {
            get { return this.expectedUseTime.Value; }
            set { this.expectedUseTime.Value = value; }
        }

    }

}