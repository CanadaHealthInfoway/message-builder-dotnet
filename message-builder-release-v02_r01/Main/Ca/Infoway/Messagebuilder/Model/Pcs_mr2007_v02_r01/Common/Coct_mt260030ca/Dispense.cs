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
 * Last modified: $LastChangedDate: 2012-02-16 11:04:19 -0500 (Thu, 16 Feb 2012) $
 * Revision:      $LastChangedRevision: 5436 $
 */
/* This class was auto-generated by the message builder generator tools. */
namespace Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r01.Common.Coct_mt260030ca {
    using Ca.Infoway.Messagebuilder.Annotation;
    using Ca.Infoway.Messagebuilder.Datatype;
    using Ca.Infoway.Messagebuilder.Datatype.Impl;
    using Ca.Infoway.Messagebuilder.Datatype.Lang;
    using Ca.Infoway.Messagebuilder.Domainvalue;
    using Ca.Infoway.Messagebuilder.Model;
    using Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r01.Merged;
    using System;


    /**
     * <summary>Dispense</summary>
     * 
     * <remarks><p>Indicates a particular dispense event that 
     * resulted in the issue.</p> <p>Used when the issue pertains 
     * to the supply of the drug rather than the drug itself. E.g. 
     * Duplicate pharmacy, refill too soon, etc.</p></remarks>
     */
    [Hl7PartTypeMappingAttribute(new string[] {"COCT_MT260030CA.SupplyEvent"})]
    public class Dispense : MessagePartBean, Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r01.Common.Merged.ICausalActs {

        private II id;
        private CS statusCode;
        private IVL<TS, Interval<PlatformDate>> effectiveTime;
        private CV confidentialityCode;
        private Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r01.Common.Coct_mt260030ca.Dispensed product;
        private Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r01.Merged.CreatedAt location;

        public Dispense() {
            this.id = new IIImpl();
            this.statusCode = new CSImpl();
            this.effectiveTime = new IVLImpl<TS, Interval<PlatformDate>>();
            this.confidentialityCode = new CVImpl();
        }
        /**
         * <summary>A:Prescription Dispense Number</summary>
         * 
         * <remarks><p>Unique identifier of the dispensed event that 
         * triggered the issue.</p> <p>Allows provider to drill down 
         * and retrieve additional information about the dispense event 
         * for consideration in their issue management decision.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"id"})]
        public Identifier Id {
            get { return this.id.Value; }
            set { this.id.Value = value; }
        }

        /**
         * <summary>B:Dispense Status</summary>
         * 
         * <remarks><p>Indicates the status of the dispense record 
         * created on the EHR/DIS. If 'Active' it means that the 
         * dispense has been processed but not yet given to the 
         * patient. If 'Complete', it indicates that the medication has 
         * been delivered to the patient.</p> <p>Important in 
         * understanding what medication the patient actually has on 
         * hand, thus the attribute is mandatory. May also influence 
         * the ability of a different pharmacy to dispense the 
         * medication.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"statusCode"})]
        public ActStatus StatusCode {
            get { return (ActStatus) this.statusCode.Value; }
            set { this.statusCode.Value = value; }
        }

        /**
         * <summary>B:Dispensed Date</summary>
         * 
         * <remarks><p>The date and time on which the product was 
         * issued to the patient.</p> <p>ZDU.4.5</p> <p>Allows 
         * evaluation of 'refill too soon' and similar 
         * issues.</p><p>Attribute is marked as &quot;populated&quot; 
         * as a dispense record may not exist without processing 
         * date.</p> <p>Allows evaluation of 'refill too soon' and 
         * similar issues.</p><p>Attribute is marked as 
         * &quot;populated&quot; as a dispense record may not exist 
         * without processing date.</p> <p>Applications should specify 
         * a null flavor of &quot;Not Applicable&quot; for dispenses 
         * that have not yet been picked up.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"effectiveTime"})]
        public Interval<PlatformDate> EffectiveTime {
            get { return this.effectiveTime.Value; }
            set { this.effectiveTime.Value = value; }
        }

        /**
         * <summary>C:Dispense Masking Indicator</summary>
         * 
         * <remarks><p>An indication of sensitivity surrounding the 
         * related drug, and thus defines the required sensitivity for 
         * the detected issue.</p> <p>Conveys the patient's wishes 
         * relating to the sensitivity of the drug 
         * information.</p><p>The attribute is optional because not all 
         * systems will support masking.</p> <p>Conveys the patient's 
         * wishes relating to the sensitivity of the drug 
         * information.</p><p>The attribute is optional because not all 
         * systems will support masking.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"confidentialityCode"})]
        public x_VeryBasicConfidentialityKind ConfidentialityCode {
            get { return (x_VeryBasicConfidentialityKind) this.confidentialityCode.Value; }
            set { this.confidentialityCode.Value = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"product"})]
        public Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r01.Common.Coct_mt260030ca.Dispensed Product {
            get { return this.product; }
            set { this.product = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"location"})]
        public Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r01.Merged.CreatedAt Location {
            get { return this.location; }
            set { this.location = value; }
        }

    }

}