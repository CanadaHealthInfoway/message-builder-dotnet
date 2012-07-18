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
namespace Ca.Infoway.Messagebuilder.Model.Sk_cerx_v01_r04_3.Common.Coct_mt141007ca {
    using Ca.Infoway.Messagebuilder.Annotation;
    using Ca.Infoway.Messagebuilder.Datatype;
    using Ca.Infoway.Messagebuilder.Datatype.Impl;
    using Ca.Infoway.Messagebuilder.Domainvalue;
    using Ca.Infoway.Messagebuilder.Model;
    using System;


    /**
     * <summary>Device Product</summary>
     * 
     * <remarks><p>A medical device product intended to be supplied 
     * and/or used by a patient. Encompasses supplies, aids, 
     * etc.</p> <p>A_BillablePharmacyDispense</p> <p>Allows devices 
     * to be clearly described and referenced. Also allows 
     * searching for and examining information about devices that 
     * can be or are being used by a patient.</p></remarks>
     */
    [Hl7PartTypeMappingAttribute(new string[] {"COCT_MT141007CA.ManufacturedProduct"})]
    public class DeviceProduct : MessagePartBean {

        private CV manufacturedClinicalDeviceCode;
        private ST manufacturedClinicalDeviceName;
        private ST manufacturedClinicalDeviceDesc;
        private INT manufacturedClinicalDeviceAsContentQuantity;

        public DeviceProduct() {
            this.manufacturedClinicalDeviceCode = new CVImpl();
            this.manufacturedClinicalDeviceName = new STImpl();
            this.manufacturedClinicalDeviceDesc = new STImpl();
            this.manufacturedClinicalDeviceAsContentQuantity = new INTImpl();
        }
        /**
         * <summary>A:Device Code</summary>
         * 
         * <remarks><p>An identifier for a type of device.</p> <p>Used 
         * to ensure clear communication by uniquely identifying a 
         * particular device product when prescribing or dispensing. 
         * This attribute is only marked as 'populated' because some 
         * devices will not have codes associated with them.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"manufacturedClinicalDevice/code"})]
        public ClinicalDeviceEntity ManufacturedClinicalDeviceCode {
            get { return (ClinicalDeviceEntity) this.manufacturedClinicalDeviceCode.Value; }
            set { this.manufacturedClinicalDeviceCode.Value = value; }
        }

        /**
         * <summary>B:Device Name</summary>
         * 
         * <remarks><p>The name assigned to a type of device.</p> 
         * <p>Names are used for human reference communication, to 
         * allow selection from dropdowns and for local searching. If a 
         * code is available, the name acts as a cross-check. If the 
         * code is not available the name acts as the primary 
         * identifier. The attribute is therefore mandatory.</p> 
         * <p>First occurrence is preferred for display.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"manufacturedClinicalDevice/name"})]
        public String ManufacturedClinicalDeviceName {
            get { return this.manufacturedClinicalDeviceName.Value; }
            set { this.manufacturedClinicalDeviceName.Value = value; }
        }

        /**
         * <summary>C:Device Description</summary>
         * 
         * <remarks><p>A free form textual description of a device and 
         * its characteristics (e.g. size, shape, etc.). This is used 
         * when additional information must be conveyed that is not 
         * apparent by just specifying code and name.</p> <p>Allows 
         * description of characteristics of the device not necessarily 
         * conveyed by the code or name.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"manufacturedClinicalDevice/desc"})]
        public String ManufacturedClinicalDeviceDesc {
            get { return this.manufacturedClinicalDeviceDesc.Value; }
            set { this.manufacturedClinicalDeviceDesc.Value = value; }
        }

        /**
         * <summary>F:Device Package Quantity</summary>
         * 
         * <remarks><p>The quantity of devices contained in the package 
         * given or to be given to the patient.</p> <p>Sometimes 
         * ordering and dispensing is by package rather than individual 
         * units, and package is important in calculating total amount 
         * supplied.</p><p>Attribute is marked as &quot;mandatory&quot; 
         * to ensure that quantity in a package is always known.</p> 
         * <p>Sometimes ordering and dispensing is by package rather 
         * than individual units, and package is important in 
         * calculating total amount supplied.</p><p>Attribute is marked 
         * as &quot;mandatory&quot; to ensure that quantity in a 
         * package is always known.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"manufacturedClinicalDevice/asContent/quantity"})]
        public int? ManufacturedClinicalDeviceAsContentQuantity {
            get { return this.manufacturedClinicalDeviceAsContentQuantity.Value; }
            set { this.manufacturedClinicalDeviceAsContentQuantity.Value = value; }
        }

    }

}