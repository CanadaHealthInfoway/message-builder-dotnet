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
namespace Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Merged {
    using Ca.Infoway.Messagebuilder.Annotation;
    using Ca.Infoway.Messagebuilder.Datatype;
    using Ca.Infoway.Messagebuilder.Datatype.Impl;
    using Ca.Infoway.Messagebuilder.Datatype.Lang;
    using Ca.Infoway.Messagebuilder.Domainvalue;
    using Ca.Infoway.Messagebuilder.Model;
    using System.Collections.Generic;


    /**
     * <summary>ContactPoints</summary>
     * 
     * <remarks>PRPA_MT202302CA.ContactParty: Contact Points <p>At 
     * least one of addr or telecom must be supplied.</p> 
     * <p>Administrative contacts within a location, allowing for 
     * communication with various departments or areas.</p> <p>One 
     * of the most common reasons for looking up a service delivery 
     * location is to find contact information for the 
     * location.</p> PRPA_MT202301CA.ContactParty: Contact Points 
     * <p>At least one of addr or telecom must be supplied.</p> 
     * <p>Administrative contacts within a location, allowing for 
     * communication with various departments or areas.</p> <p>One 
     * of the most common reasons for looking up a service delivery 
     * location is to find contact information for the 
     * location.</p> PRPA_MT202303CA.ContactParty: Contact Points 
     * <p>At least one of addr or telecom must be supplied.</p> 
     * <p>Administrative contacts within a location, allowing for 
     * communication with various departments or areas.</p> <p>One 
     * of the most common reasons for looking up a service delivery 
     * location is to find contact information for the 
     * location.</p></remarks>
     */
    [Hl7PartTypeMappingAttribute(new string[] {"PRPA_MT202301CA.ContactParty","PRPA_MT202302CA.ContactParty","PRPA_MT202303CA.ContactParty"})]
    public class ContactPoints : MessagePartBean {

        private CV code;
        private AD addr;
        private SET<TEL, TelecommunicationAddress> telecom;

        public ContactPoints() {
            this.code = new CVImpl();
            this.addr = new ADImpl();
            this.telecom = new SETImpl<TEL, TelecommunicationAddress>(typeof(TELImpl));
        }
        /**
         * <summary>ContactType</summary>
         * 
         * <remarks>A: Contact Type <p>Identifies the general purpose 
         * for which this contact information is appropriate. E.g. 
         * Admitting, billing, after-hours, etc.</p> <p>Helps the user 
         * to know which set of contact information should be used in a 
         * particular circumstance. This is a key differentiator of 
         * each contact point, and is therefore mandatory.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"code"})]
        public AdministrativeContactRoleType Code {
            get { return (AdministrativeContactRoleType) this.code.Value; }
            set { this.code.Value = value; }
        }

        /**
         * <summary>ContactAddress</summary>
         * 
         * <remarks>B: Contact Address <p>Provides a mailing address 
         * for the location</p> <p>Used when communicating by post. 
         * Physical addresses may also be used for courier-type 
         * deliveries.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"addr"})]
        public PostalAddress Addr {
            get { return this.addr.Value; }
            set { this.addr.Value = value; }
        }

        /**
         * <summary>ContactPhoneNumberAndEmails</summary>
         * 
         * <remarks>C: Contact Phone Number and Emails <p>Information 
         * used to communicate with the location by phone, fax or 
         * e-mail.</p> <p>Used for more immediate contact 
         * requirements</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"telecom"})]
        public ICollection<TelecommunicationAddress> Telecom {
            get { return this.telecom.RawSet(); }
        }

    }

}