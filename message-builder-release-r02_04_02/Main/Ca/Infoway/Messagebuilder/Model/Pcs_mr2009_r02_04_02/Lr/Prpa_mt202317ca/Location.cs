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
 * Last modified: $LastChangedDate: 2012-01-18 21:10:15 -0500 (Wed, 18 Jan 2012) $
 * Revision:      $LastChangedRevision: 3990 $
 */

/* This class was auto-generated by the message builder generator tools. */
namespace Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Lr.Prpa_mt202317ca {
    using Ca.Infoway.Messagebuilder.Annotation;
    using Ca.Infoway.Messagebuilder.Datatype;
    using Ca.Infoway.Messagebuilder.Datatype.Impl;
    using Ca.Infoway.Messagebuilder.Datatype.Lang;
    using Ca.Infoway.Messagebuilder.Domainvalue;
    using Ca.Infoway.Messagebuilder.Model;
    using Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Common.Coct_mt960002ca;
    using Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Lr.Merged;
    using System;
    using System.Collections.Generic;


    /**
     * <summary>Location</summary>
     * 
     * <remarks><p>At least one of address or coordinate must be 
     * specified unless the place is mobile.</p> <p>Any location 
     * where health-related services may be provided. Note that a 
     * single physical place can play multiple service delivery 
     * location roles e.g. a Podiatry clinic and Research clinic 
     * may meet on alternate days in the same physical location; 
     * each clinic uses its own mailing address and telephone 
     * number.</p> <p>Provides location information which uniquely 
     * identifies where health services are provided. This includes 
     * details and other supporting information on locations e.g. 
     * name, address, organization and contact parties. Needed when 
     * looking up facilities to link to patient records. Also 
     * useful when trying to find facilities to meet particular 
     * patient needs, as well as looking up how to contact the 
     * location.</p></remarks>
     */
    [Hl7PartTypeMappingAttribute(new string[] {"PRPA_MT202317CA.ServiceDeliveryLocation"})]
    public class Location : MessagePartBean {

        private II locationIdentifier;
        private CV locationType;
        private SET<ST, String> locationNames;
        private AD locationAddress;
        private CS locationStatus;
        private Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Lr.Prpa_mt202317ca.Place locationValue;
        private IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Common.Coct_mt960002ca.GeographicCoordinates> subjectOfPosition;
        private Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Lr.Merged.IndirectAuthorithyOver indirectAuthority;

        public Location() {
            this.locationIdentifier = new IIImpl();
            this.locationType = new CVImpl();
            this.locationNames = new SETImpl<ST, String>(typeof(STImpl));
            this.locationAddress = new ADImpl();
            this.locationStatus = new CSImpl();
            this.subjectOfPosition = new List<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Common.Coct_mt960002ca.GeographicCoordinates>();
        }
        /**
         * <summary>A: Location Identifier</summary>
         * 
         * <remarks></p> </p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"id"})]
        public Identifier LocationIdentifier {
            get { return this.locationIdentifier.Value; }
            set { this.locationIdentifier.Value = value; }
        }

        /**
         * <summary>B: Location Type</summary>
         * 
         * <remarks></p><p>For example, a service delivery location may 
         * be either an incidental service delivery location (a place 
         * at which health-related services may be provided without 
         * prior designation or authorization such as a church or 
         * school) or a dedicated service delivery location (a place 
         * that is intended to house the provision of health-related 
         * services such as a clinic or hospital). Dedicated service 
         * delivery locations can be further characterized as either 
         * clinical or non-clinical.</p> </p><p>For example, a service 
         * delivery location may be either an incidental service 
         * delivery location (a place at which health-related services 
         * may be provided without prior designation or authorization 
         * such as a church or school) or a dedicated service delivery 
         * location (a place that is intended to house the provision of 
         * health-related services such as a clinic or hospital). 
         * Dedicated service delivery locations can be further 
         * characterized as either clinical or non-clinical.</p> </p> 
         * </p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"code"})]
        public ServiceDeliveryLocationRoleType LocationType {
            get { return (ServiceDeliveryLocationRoleType) this.locationType.Value; }
            set { this.locationType.Value = value; }
        }

        /**
         * <summary>D:Location Names</summary>
         * 
         * <remarks><p>A textual name for the place where the service 
         * is provided e.g. Ottawa General Hospital.</p> <p>Provides a 
         * human-readable label for the location. The location name is 
         * not intended to be parsed or analyzed by when processing the 
         * record. (E.g. To determine if a location is a hospital, look 
         * at the location type, don't check the name for the word 
         * &quot;hospital&quot;.)</p><p>Multiple repetitions are 
         * allowed to capture historical names</p> <p>Provides a 
         * human-readable label for the location. The location name is 
         * not intended to be parsed or analyzed by when processing the 
         * record. (E.g. To determine if a location is a hospital, look 
         * at the location type, don't check the name for the word 
         * &quot;hospital&quot;.)</p><p>Multiple repetitions are 
         * allowed to capture historical names</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"name"})]
        public ICollection<String> LocationNames {
            get { return this.locationNames.RawSet(); }
        }

        /**
         * <summary>G:Location Address</summary>
         * 
         * <remarks><p>Restricted to physical address only</p> 
         * <p>Identifies the physical address for this service delivery 
         * location, I.e. What is the geographic location of the 
         * building.</p> <p>Allows location to be visited. May also be 
         * used for geographic profiling (e.g. a dispatcher may be 
         * looking for the closest hospital or ambulance that can help 
         * a patient in need of emergency care).</p><p>Because a 
         * physical address may not exist for mobile locations, and may 
         * not be expressible for non-dedicated locations such as water 
         * resevoirs, this element is only 'populated'. When no address 
         * exists, the null flavor should be set to NA.</p> <p>Allows 
         * location to be visited. May also be used for geographic 
         * profiling (e.g. a dispatcher may be looking for the closest 
         * hospital or ambulance that can help a patient in need of 
         * emergency care).</p><p>Because a physical address may not 
         * exist for mobile locations, and may not be expressible for 
         * non-dedicated locations such as water resevoirs, this 
         * element is only 'populated'. When no address exists, the 
         * null flavor should be set to NA.</p> <p>For mobile service 
         * delivery location, this can either be set to the address of 
         * the &quot;home&quot; site for the mobile unit or can be set 
         * to a null flavor of N/A.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"addr"})]
        public PostalAddress LocationAddress {
            get { return this.locationAddress.Value; }
            set { this.locationAddress.Value = value; }
        }

        /**
         * <summary>C: Location Status</summary>
         * 
         * <remarks></p><p>Allowed status values are 'active' (the 
         * location is actively used to deliver healthcare-related 
         * services), 'suspended' (the location has temporarily ceased 
         * delivering healthcare-related services) and 'terminated' 
         * (the location has permanently ceased delivering 
         * healthcare-related services and may no longer physically 
         * exist.)</p> </p><p>Allowed status values are 'active' (the 
         * location is actively used to deliver healthcare-related 
         * services), 'suspended' (the location has temporarily ceased 
         * delivering healthcare-related services) and 'terminated' 
         * (the location has permanently ceased delivering 
         * healthcare-related services and may no longer physically 
         * exist.)</p> </p> </p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"statusCode"})]
        public ServiceDeliveryRoleStatus LocationStatus {
            get { return (ServiceDeliveryRoleStatus) this.locationStatus.Value; }
            set { this.locationStatus.Value = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"location"})]
        public Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Lr.Prpa_mt202317ca.Place LocationValue {
            get { return this.locationValue; }
            set { this.locationValue = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"subjectOf/position"})]
        public IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Common.Coct_mt960002ca.GeographicCoordinates> SubjectOfPosition {
            get { return this.subjectOfPosition; }
        }

        [Hl7XmlMappingAttribute(new string[] {"indirectAuthority"})]
        public Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Lr.Merged.IndirectAuthorithyOver IndirectAuthority {
            get { return this.indirectAuthority; }
            set { this.indirectAuthority = value; }
        }

    }

}