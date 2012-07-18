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
 * Last modified: $LastChangedDate: 2012-02-16 11:05:28 -0500 (Thu, 16 Feb 2012) $
 * Revision:      $LastChangedRevision: 5451 $
 */
/* This class was auto-generated by the message builder generator tools. */
namespace Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r01.Common.Merged {
    using Ca.Infoway.Messagebuilder.Annotation;
    using Ca.Infoway.Messagebuilder.Datatype;
    using Ca.Infoway.Messagebuilder.Datatype.Impl;
    using Ca.Infoway.Messagebuilder.Datatype.Lang;
    using Ca.Infoway.Messagebuilder.Model;
    using System;


    [Hl7PartTypeMappingAttribute(new string[] {"MCCI_MT002100CA.Sender","MCCI_MT002200CA.Sender","MCCI_MT002300CA.Sender","MCCI_MT102001CA.Sender"})]
    public class Sender : MessagePartBean {

        private TEL telecom;
        private II deviceId;
        private ST deviceName;
        private ST deviceDesc;
        private IVL<TS, Interval<PlatformDate>> deviceExistenceTime;
        private ST deviceManufacturerModelName;
        private ST deviceSoftwareName;

        public Sender() {
            this.telecom = new TELImpl();
            this.deviceId = new IIImpl();
            this.deviceName = new STImpl();
            this.deviceDesc = new STImpl();
            this.deviceExistenceTime = new IVLImpl<TS, Interval<PlatformDate>>();
            this.deviceManufacturerModelName = new STImpl();
            this.deviceSoftwareName = new STImpl();
        }
        /**
         * <summary>SendingNetworkAddress</summary>
         * 
         * <remarks>IB:Sending Network Address <p>The network address 
         * of the application which sent the message.</p> 
         * <p>soap:Header\wsa:From</p> <p>May be important for sender 
         * validation. Usually also the address to which responses are 
         * sent. This is optional because not all environments require 
         * network addresses. It is mandatory when communicating using 
         * SOAP.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"telecom"})]
        public TelecommunicationAddress Telecom {
            get { return this.telecom.Value; }
            set { this.telecom.Value = value; }
        }

        /**
         * <summary>SendingApplicationIdentifier</summary>
         * 
         * <remarks>IA:Sending Application Identifier <p>The unique 
         * identifier of the application or system to whom the message 
         * is being routed.</p> <p>soap:Header\wsa:From\@endpointID</p> 
         * <p>Because this is the key identifier of where the message 
         * is intended to go, this attribute is mandatory.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"device/id"})]
        public Identifier DeviceId {
            get { return this.deviceId.Value; }
            set { this.deviceId.Value = value; }
        }

        /**
         * <summary>SendingApplicationName</summary>
         * 
         * <remarks>IE:Sending Application Name <p>This is the name 
         * associated with the system or application sending the 
         * message.</p> <p>Provides useful information when 
         * debugging.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"device/name"})]
        public String DeviceName {
            get { return this.deviceName.Value; }
            set { this.deviceName.Value = value; }
        }

        /**
         * <summary>SendingApplicationConfigurationInformation</summary>
         * 
         * <remarks>II:Sending Application Configuration Information 
         * <p>Provides additional information about the configuration 
         * of the sending application. Useful when debugging.</p> 
         * <p>Provides additional information that may assist in 
         * debugging interactions.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"device/desc"})]
        public String DeviceDesc {
            get { return this.deviceDesc.Value; }
            set { this.deviceDesc.Value = value; }
        }

        /**
         * <summary>SendingApplicationVersionDate</summary>
         * 
         * <remarks>IH:Sending Application Version Date <p>Indicates 
         * the last time the sending application was modified or 
         * reconfigured.</p> <p>Can help to isolate the source of a 
         * problem when debugging.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"device/existenceTime"})]
        public Interval<PlatformDate> DeviceExistenceTime {
            get { return this.deviceExistenceTime.Value; }
            set { this.deviceExistenceTime.Value = value; }
        }

        /**
         * <summary>SendingSoftwareVersionNumber</summary>
         * 
         * <remarks>IG:Sending Software Version Number <p>Indicates the 
         * version number of the piece of software used to construct 
         * the message.</p> <p>May be used to filter messages based on 
         * the compliance testing of the sending software.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"device/manufacturerModelName"})]
        public String DeviceManufacturerModelName {
            get { return this.deviceManufacturerModelName.Value; }
            set { this.deviceManufacturerModelName.Value = value; }
        }

        /**
         * <summary>SendingApplicationSoftwareName</summary>
         * 
         * <remarks>IF:Sending Application Software Name <p>Indicates 
         * the name of the software used to construct the message.</p> 
         * <p>May be used to filter messages based on sending 
         * application compliance testing.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"device/softwareName"})]
        public String DeviceSoftwareName {
            get { return this.deviceSoftwareName.Value; }
            set { this.deviceSoftwareName.Value = value; }
        }

    }

}