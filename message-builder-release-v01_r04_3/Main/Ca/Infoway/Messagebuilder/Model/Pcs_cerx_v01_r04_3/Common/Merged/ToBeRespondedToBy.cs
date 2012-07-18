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
 * Last modified: $LastChangedDate: 2012-02-16 10:57:23 -0500 (Thu, 16 Feb 2012) $
 * Revision:      $LastChangedRevision: 5358 $
 */
/* This class was auto-generated by the message builder generator tools. */
namespace Ca.Infoway.Messagebuilder.Model.Pcs_cerx_v01_r04_3.Common.Merged {
    using Ca.Infoway.Messagebuilder.Annotation;
    using Ca.Infoway.Messagebuilder.Datatype;
    using Ca.Infoway.Messagebuilder.Datatype.Impl;
    using Ca.Infoway.Messagebuilder.Datatype.Lang;
    using Ca.Infoway.Messagebuilder.Model;


    /**
     * <summary>ToBeRespondedToBy</summary>
     * 
     * <remarks>MCCI_MT102001CA.RespondTo: to be responded to by 
     * <p>Indicates the interaction that should receive the 
     * response to this interaction. Used when different from the 
     * sender of the original interaction.</p> <p>In complex 
     * routing environments, the acknowledgements may need to be 
     * sent to a system other than the one which constructed the 
     * original message. This association is optional because not 
     * all environments will support responses to systems other 
     * than the original sender.</p> MCCI_MT000100CA.RespondTo: to 
     * be responded to by <p>Indicates the interaction that should 
     * receive the response to this interaction. Used when 
     * different from the sender of the original interaction.</p> 
     * <p>In complex routing environments, the acknowledgements may 
     * need to be sent to a system other than the one which 
     * constructed the original message. This association is 
     * optional because not all environments will support responses 
     * to systems other than the original sender.</p> 
     * MCCI_MT000200CA.RespondTo: to be responded to by 
     * <p>Indicates the interaction that should receive the 
     * response to this interaction. Used when different from the 
     * sender of the original interaction.</p> <p>In complex 
     * routing environments, the acknowledgements may need to be 
     * sent to a system other than the one which constructed the 
     * original message. This association is optional because not 
     * all environments will support responses to systems other 
     * than the original sender.</p> MCCI_MT000300CA.RespondTo: to 
     * be responded to by <p>Indicates the interaction that should 
     * receive the response to this interaction. Used when 
     * different from the sender of the original interaction.</p> 
     * <p>In complex routing environments, the acknowledgements may 
     * need to be sent to a system other than the one which 
     * constructed the original message. This association is 
     * optional because not all environments will support responses 
     * to systems other than the original sender.</p></remarks>
     */
    [Hl7PartTypeMappingAttribute(new string[] {"MCCI_MT000100CA.RespondTo","MCCI_MT000200CA.RespondTo","MCCI_MT000300CA.RespondTo","MCCI_MT102001CA.RespondTo"})]
    public class ToBeRespondedToBy : MessagePartBean {

        private TEL telecom;
        private II deviceId;
        private II deviceAsAgentRepresentedOrganizationId;
        private II deviceAsLocatedEntityLocationId;

        public ToBeRespondedToBy() {
            this.telecom = new TELImpl();
            this.deviceId = new IIImpl();
            this.deviceAsAgentRepresentedOrganizationId = new IIImpl();
            this.deviceAsLocatedEntityLocationId = new IIImpl();
        }
        /**
         * <summary>RespondToNetworkAddress</summary>
         * 
         * <remarks>KB:Respond to Network Address <p>Indicates the 
         * address to send acknowledgments of this message to.</p> 
         * <p>Needed when the address to respond to is different than 
         * that of the sender. This is optional because not all 
         * environments require network addresses.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"telecom"})]
        public TelecommunicationAddress Telecom {
            get { return this.telecom.Value; }
            set { this.telecom.Value = value; }
        }

        /**
         * <summary>RespondToApplicationIdentifier</summary>
         * 
         * <remarks>KA:Respond to Application Identifier <p>The unique 
         * identifier of the applications to which responses should be 
         * sent. Only populated when different from the sending 
         * application id.</p> <p>Allows unique identification and 
         * routing to the application to be responded to. This 
         * attribute is mandatory be cause it is the principal 
         * identifier of the application to respond to.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"device/id"})]
        public Identifier DeviceId {
            get { return this.deviceId.Value; }
            set { this.deviceId.Value = value; }
        }

        /**
         * <summary>RespondToOrganizationId</summary>
         * 
         * <remarks>KC:Respond to Organization Id <p>The unique 
         * identifier of the application who is to be responsible for 
         * responses to this message.</p> <p>Needed for circumstances 
         * where the 'respond to' organization is different than the 
         * sending organization. This attribute is optional because not 
         * all environments require communicating this information.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"device/asAgent/representedOrganization/id"})]
        public Identifier DeviceAsAgentRepresentedOrganizationId {
            get { return this.deviceAsAgentRepresentedOrganizationId.Value; }
            set { this.deviceAsAgentRepresentedOrganizationId.Value = value; }
        }

        /**
         * <summary>RespondToFacilityId</summary>
         * 
         * <remarks>KD:Respond to Facility Id <p>Indicates the clinic 
         * or other facility to which responses to this interaction 
         * should be sent.</p> <p>May affect the routing of a message. 
         * This attribute is optional because not all environments 
         * require communicating this information.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"device/asLocatedEntity/location/id"})]
        public Identifier DeviceAsLocatedEntityLocationId {
            get { return this.deviceAsLocatedEntityLocationId.Value; }
            set { this.deviceAsLocatedEntityLocationId.Value = value; }
        }

    }

}