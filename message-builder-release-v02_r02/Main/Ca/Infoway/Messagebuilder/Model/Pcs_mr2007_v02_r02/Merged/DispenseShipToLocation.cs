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
 * Last modified: $LastChangedDate: 2012-02-16 11:10:09 -0500 (Thu, 16 Feb 2012) $
 * Revision:      $LastChangedRevision: 5502 $
 */
/* This class was auto-generated by the message builder generator tools. */
namespace Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r02.Merged {
    using Ca.Infoway.Messagebuilder.Annotation;
    using Ca.Infoway.Messagebuilder.Datatype;
    using Ca.Infoway.Messagebuilder.Datatype.Impl;
    using Ca.Infoway.Messagebuilder.Datatype.Lang;
    using Ca.Infoway.Messagebuilder.Domainvalue;
    using Ca.Infoway.Messagebuilder.Model;
    using System;


    /**
     * <summary>PRPM_MT303010CA.ServiceDeliveryLocation: Service 
     * Delivery Location</summary>
     * 
     * <remarks><p>A role played by a place at which services may 
     * be provided. The RIM defines two specializations of service 
     * delivery location: 1. incidental service delivery location - 
     * A role played by a place at which health care services may 
     * be provided without prior designation or authorization and 
     * 2. dedicated service delivery location - A role played by a 
     * place that is intended to house the provision of services. 
     * Scoper is the Entity (typically Organization) that provides 
     * these services. This is not synonymous with 
     * &quot;ownership&quot;. This can be further characterized by 
     * a role code of: A)DedicatedClinicalLocationRoleType - A role 
     * of a place that further classifies the clinical setting 
     * (e.g., cardiology clinic, primary care clinic, 
     * rehabilitation hospital, skilled nursing facility) in which 
     * care is delivered during an encounter or 
     * B)DedicatedNonClinicalLocationRoleType - A role of a place 
     * that further classifies the setting in which non-clinical 
     * services are delivered. A given physical place can play 
     * multiple service delivery location roles each with its own 
     * attributes. For example, a Podiatric clinic and Research 
     * clinic may meet on alternate days in the same physical 
     * location; each clinic uses its own mailing address and 
     * telephone number.</p> <p>Roleclass required to support the 
     * identification of the physical location where healthcare 
     * services are provided</p> 
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
     * PORX_MT060010CA.ServiceDeliveryLocation: Dispense Ship-To 
     * Location <p>The location where the dispensed product is 
     * expected to be delivered.</p> <p>Important as part of a 
     * claim for justifying shipping charges.</p> 
     * PORX_MT060160CA.ServiceDeliveryLocation: Dispense Ship-To 
     * Location <p>The location where the dispensed product is 
     * expected to be delivered.</p> <p>Important as part of a 
     * claim for justifying shipping charges.</p> 
     * PORX_MT060040CA.ServiceDeliveryLocation: Dispense Ship-To 
     * Location <p>The location where the dispensed product is 
     * expected to be delivered.</p> <p>Important as part of a 
     * claim for justifying shipping charges.</p> 
     * PRPM_MT301010CA.ServiceDeliveryLocation: Service Delivery 
     * Location <p>A role played by a place at which services may 
     * be provided. The RIM defines two specializations of service 
     * delivery location: 1. incidental service delivery location - 
     * A role played by a place at which health care services may 
     * be provided without prior designation or authorization and 
     * 2. dedicated service delivery location - A role played by a 
     * place that is intended to house the provision of services. 
     * Scoper is the Entity (typically Organization) that provides 
     * these services. This is not synonymous with 
     * &quot;ownership&quot;. This can be further characterized by 
     * a role code of: A)DedicatedClinicalLocationRoleType - A role 
     * of a place that further classifies the clinical setting 
     * (e.g., cardiology clinic, primary care clinic, 
     * rehabilitation hospital, skilled nursing facility) in which 
     * care is delivered during an encounter or 
     * B)DedicatedNonClinicalLocationRoleType - A role of a place 
     * that further classifies the setting in which non-clinical 
     * services are delivered. A given physical place can play 
     * multiple service delivery location roles each with its own 
     * attributes. For example, a Podiatric clinic and Research 
     * clinic may meet on alternate days in the same physical 
     * location; each clinic uses its own mailing address and 
     * telephone number.</p> <p>Roleclass required to support the 
     * identification of the physical location where healthcare 
     * services are provided</p> 
     * PORX_MT060090CA.ServiceDeliveryLocation: Dispense Ship-To 
     * Location <p>The location where the dispensed product is 
     * expected to be delivered.</p> <p>Important as part of a 
     * claim for justifying shipping charges.</p></remarks>
     */
    [Hl7PartTypeMappingAttribute(new string[] {"PORX_MT010110CA.ServiceDeliveryLocation","PORX_MT010120CA.ServiceDeliveryLocation","PORX_MT020060CA.ServiceDeliveryLocation","PORX_MT020070CA.ServiceDeliveryLocation","PORX_MT060010CA.ServiceDeliveryLocation","PORX_MT060040CA.ServiceDeliveryLocation","PORX_MT060040CA.ServiceDeliveryLocation2","PORX_MT060090CA.ServiceDeliveryLocation","PORX_MT060160CA.ServiceDeliveryLocation","PORX_MT060160CA.ServiceDeliveryLocation2","PORX_MT060340CA.ServiceDeliveryLocation","PORX_MT060340CA.ServiceDeliveryLocation2","PRPM_MT301010CA.ServiceDeliveryLocation","PRPM_MT303010CA.ServiceDeliveryLocation"})]
    public class DispenseShipToLocation : MessagePartBean, Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r02.Merged.IChoice {

        private II id;
        private CV code;
        private AD addr;
        private TEL telecom;
        private IVL<TS, Interval<PlatformDate>> effectiveTime;
        private ST locationName;

        public DispenseShipToLocation() {
            this.id = new IIImpl();
            this.code = new CVImpl();
            this.addr = new ADImpl();
            this.telecom = new TELImpl();
            this.effectiveTime = new IVLImpl<TS, Interval<PlatformDate>>();
            this.locationName = new STImpl();
        }
        /**
         * <summary>ServiceDeliveryLocationIdentifier</summary>
         * 
         * <remarks>Service Delivery Location Identifier <p>A unique 
         * identifier for the service delivery location.</p> 
         * <p>Required attribute supports the validation and 
         * identification of the service delivery location</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"id"})]
        public Identifier Id {
            get { return this.id.Value; }
            set { this.id.Value = value; }
        }

        /**
         * <summary>ServiceDeliveryLocationType</summary>
         * 
         * <remarks>Service Delivery Location Type <p>The code 
         * identifying the specific service delivery location</p> 
         * <p>Mandatory attribute supports the validation and 
         * identification of the service delivery location</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"code"})]
        public ServiceDeliveryLocationRoleType Code {
            get { return (ServiceDeliveryLocationRoleType) this.code.Value; }
            set { this.code.Value = value; }
        }

        /**
         * <summary>I:Ship-To Address</summary>
         * 
         * <remarks><p>Indicates where the dispensed product was 
         * sent.</p> <p>Important as part of a claim for justifying 
         * shipping charges.</p> Ship To Address <p>Indicates where the 
         * dispensed product was sent.</p> <p>Important as part of a 
         * claim for justifying shipping charges.</p> H:Prescription 
         * Ship to Address <p>Indicates the location the dispensed 
         * device should be shipped to, at the request of the patient 
         * or provider.</p> <p>In some cases devices need to be 
         * delivered to the patient instead of being picked up. In 
         * other cases, devices need to be shipped to the physician's 
         * office to replace stock used for the patient.</p> 
         * H:Prescription Ship to Address <p>Indicates the location the 
         * dispensed medication should be shipped to, at the request of 
         * the patient or provider.</p> <p>In some cases drugs need to 
         * be delivered to the patient instead of being picked up. In 
         * other cases, drugs need to be shipped to the physician's 
         * office to replace stock used for the patient.</p> Service 
         * Delivery Location Address <p>Address of the specific service 
         * delivery location</p> <p>Required attribute supports the 
         * validation and identification of the service delivery 
         * location</p> Service Delivery Location Address <p>Address of 
         * the specific service delivery location</p> <p>Populated 
         * attribute supports the validation and identification of the 
         * service delivery location</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"addr"})]
        public PostalAddress Addr {
            get { return this.addr.Value; }
            set { this.addr.Value = value; }
        }

        /**
         * <summary>ServiceDeliveryLocationTelecom</summary>
         * 
         * <remarks>Service Delivery Location Telecom <p>The telecom 
         * for the specific service delivery location</p> <p>Required 
         * attribute supports the validation and identification of the 
         * service delivery location</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"telecom"})]
        public TelecommunicationAddress Telecom {
            get { return this.telecom.Value; }
            set { this.telecom.Value = value; }
        }

        /**
         * <summary>ServiceDeliveryLocationEffectiveDate</summary>
         * 
         * <remarks>Service Delivery Location Effective Date 
         * <p>Effective date of the specific service delivery 
         * location</p> <p>Required attribute supports the validation 
         * and identification of the service delivery location</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"effectiveTime"})]
        public Interval<PlatformDate> EffectiveTime {
            get { return this.effectiveTime.Value; }
            set { this.effectiveTime.Value = value; }
        }

        /**
         * <summary>ServiceDeliveryLocationName</summary>
         * 
         * <remarks>Service Delivery Location Name <p>The name of the 
         * service delivery location</p> <p>Mandatory attribute 
         * supports the validation and identification of the service 
         * delivery location</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"location/name"})]
        public String LocationName {
            get { return this.locationName.Value; }
            set { this.locationName.Value = value; }
        }

    }

}