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
    using Ca.Infoway.Messagebuilder.Domainvalue;
    using Ca.Infoway.Messagebuilder.Model;
    using Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Merged;
    using System;


    /**
     * <summary>PORX_MT020070CA.SupplyRequest: (no business name)</summary>
     * 
     * <remarks><p>Additional information about the prescription 
     * being fulfilled.</p> <p>Important in understanding the 
     * patient's treatment. May also be required by the EHR 
     * repository.</p> PORX_MT020060CA.SupplyRequest2: (no business 
     * name) <p>At least one of Total Prescribed Quantity and Total 
     * Days Supply must be present and not Null.</p> <p>Additional 
     * information about the prescription being fulfilled.</p> 
     * <p>Important in understanding the patient's treatment. May 
     * also be required by the EHR repository.</p></remarks>
     */
    [Hl7PartTypeMappingAttribute(new string[] {"PORX_MT020060CA.SupplyRequest2","PORX_MT020070CA.SupplyRequest","PORX_MT060190CA.SupplyRequest"})]
    public class SupplyRequest : MessagePartBean {

        private CS prescriptionDispensableIndicator;
        private PQ totalPrescribedQuantity;
        private Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Merged.OccurredAt location;
        private INT numberOfAuthorizedFills;
        private IVL<TS, Interval<PlatformDate>> totalDaysSupply;

        public SupplyRequest() {
            this.prescriptionDispensableIndicator = new CSImpl();
            this.totalPrescribedQuantity = new PQImpl();
            this.numberOfAuthorizedFills = new INTImpl();
            this.totalDaysSupply = new IVLImpl<TS, Interval<PlatformDate>>();
        }
        /**
         * <summary>PrescriptionDispensableIndicator</summary>
         * 
         * <remarks>A:Prescription Dispensable Indicator <p>This 
         * generally mirrors the status for the prescription, but in 
         * some circumstances may be changed to 'aborted' while the 
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
         * be known.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"statusCode"})]
        public ActStatus PrescriptionDispensableIndicator {
            get { return (ActStatus) this.prescriptionDispensableIndicator.Value; }
            set { this.prescriptionDispensableIndicator.Value = value; }
        }

        /**
         * <summary>TotalPrescribedQuantity</summary>
         * 
         * <remarks>B:Total Prescribed Quantity <p>The overall amount 
         * of amount medication to be dispensed under this 
         * prescription. Includes any first fills (trials, aligning 
         * quantities), the initial standard fill plus all refills.</p> 
         * <p>Sets upper limit for medication to be dispensed. Can be 
         * used to verify the intention of the prescriber with respect 
         * to the overall medication. Used for comparison when 
         * determining whether additional quantity may be dispensed in 
         * the context of a part-fill prescription.</p> Total 
         * Prescribed Quantity <p>The overall amount of amount 
         * medication to be dispensed under this prescription. Includes 
         * any first fills (trials, aligning quantities), the initial 
         * standard fill plus all refills.</p> <p>Critical in 
         * understanding the patient's medication profile, both past 
         * and current. This also allows determination of the amount 
         * that remains to be dispensed against the prescription.</p> 
         * Total Prescribed Quantity <p>The overall amount to be 
         * dispensed under this prescription. Includes the initial 
         * standard fill plus all refills</p> <p>Critical in 
         * understanding the patient's profile, both past and current. 
         * This also allows determination of the amount that remains to 
         * be dispensed against the prescription.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"quantity"})]
        public PhysicalQuantity TotalPrescribedQuantity {
            get { return this.totalPrescribedQuantity.Value; }
            set { this.totalPrescribedQuantity.Value = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"location"})]
        public Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Merged.OccurredAt Location {
            get { return this.location; }
            set { this.location = value; }
        }

        /**
         * <summary>NumberOfAuthorizedFills</summary>
         * 
         * <remarks>Number of Authorized Fills <p>Records the total 
         * number of fills authorized</p> <p>Regulation prevents this 
         * number from being calculated in some jurisdictions.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"repeatNumber"})]
        public int? NumberOfAuthorizedFills {
            get { return this.numberOfAuthorizedFills.Value; }
            set { this.numberOfAuthorizedFills.Value = value; }
        }

        /**
         * <summary>TotalDaysSupply</summary>
         * 
         * <remarks>Total Days Supply <p>The number of days that the 
         * overall prescribed item is expected to last, if the patient 
         * is compliant with the dispensing and administration of the 
         * prescription.</p> <p>Useful in monitoring patient 
         * compliance. May also be useful in determining and managing 
         * certain contraindications ('Fill-Too-Soon', 'Fill-Too-Late', 
         * and 'Duration of Therapy').</p><p>As it should always be 
         * known and for the reasons cited, the attribute is 
         * Mandatory.</p> <p>Useful in monitoring patient compliance. 
         * May also be useful in determining and managing certain 
         * contraindications ('Fill-Too-Soon', 'Fill-Too-Late', and 
         * 'Duration of Therapy').</p><p>As it should always be known 
         * and for the reasons cited, the attribute is Mandatory.</p> 
         * Total Days Supply <p>The number of days that the overall 
         * prescribed item is expected to last, if the patient is 
         * compliant with the dispensing and use of the 
         * prescription.</p> <p>Useful in monitoring patient 
         * compliance. May also be useful in determining and managing 
         * certain contraindications ('Fill-Too-Soon', 'Fill-Too-Late', 
         * and 'Duration of Therapy').</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"expectedUseTime"})]
        public Interval<PlatformDate> TotalDaysSupply {
            get { return this.totalDaysSupply.Value; }
            set { this.totalDaysSupply.Value = value; }
        }

    }

}