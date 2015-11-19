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
 * Last modified: $LastChangedDate: 2011-05-04 15:47:15 -0400 (Wed, 04 May 2011) $
 * Revision:      $LastChangedRevision: 2623 $
 */
/* This class was auto-generated by the message builder generator tools. */
namespace Ca.Infoway.Messagebuilder.Model.Ab_mr2007_v02_r02.Si.Rcmr_mt010001ca {
    using Ca.Infoway.Messagebuilder.Annotation;
    using Ca.Infoway.Messagebuilder.Model;
    using Ca.Infoway.Messagebuilder.Model.Ab_mr2007_v02_r02.Common.Coct_mt090108ca;
    using Ca.Infoway.Messagebuilder.Model.Ab_mr2007_v02_r02.Sessionmgmt.Coct_mt240003ca;


    /**
     * <summary>Business Name: *consent given to</summary>
     * 
     * <p>Identifies the beneficiary of the consent as being a 
     * Provider or Service Location.</p> <p>Indicates who is being 
     * authorized to receive the information, and is therefore 
     * populated.</p>
     */
    [Hl7PartTypeMappingAttribute(new string[] {"RCMR_MT010001CA.Receiver"})]
    public class ConsentGivenTo : MessagePartBean {

        private Ca.Infoway.Messagebuilder.Model.Ab_mr2007_v02_r02.Si.Rcmr_mt010001ca.IRecipient recipient;

        public ConsentGivenTo() {
        }
        /**
         * <summary>Relationship: RCMR_MT010001CA.Receiver.recipient</summary>
         * 
         * <remarks>Conformance/Cardinality: POPULATED (1)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"recipient"})]
        public Ca.Infoway.Messagebuilder.Model.Ab_mr2007_v02_r02.Si.Rcmr_mt010001ca.IRecipient Recipient {
            get { return this.recipient; }
            set { this.recipient = value; }
        }

        public Ca.Infoway.Messagebuilder.Model.Ab_mr2007_v02_r02.Common.Coct_mt090108ca.HealthcareWorker RecipientAsAssignedEntity {
            get { return this.recipient is Ca.Infoway.Messagebuilder.Model.Ab_mr2007_v02_r02.Common.Coct_mt090108ca.HealthcareWorker ? (Ca.Infoway.Messagebuilder.Model.Ab_mr2007_v02_r02.Common.Coct_mt090108ca.HealthcareWorker) this.recipient : (Ca.Infoway.Messagebuilder.Model.Ab_mr2007_v02_r02.Common.Coct_mt090108ca.HealthcareWorker) null; }
        }
        public bool HasRecipientAsAssignedEntity() {
            return (this.recipient is Ca.Infoway.Messagebuilder.Model.Ab_mr2007_v02_r02.Common.Coct_mt090108ca.HealthcareWorker);
        }

        public Ca.Infoway.Messagebuilder.Model.Ab_mr2007_v02_r02.Sessionmgmt.Coct_mt240003ca.ServiceLocation RecipientAsServiceDeliveryLocation {
            get { return this.recipient is Ca.Infoway.Messagebuilder.Model.Ab_mr2007_v02_r02.Sessionmgmt.Coct_mt240003ca.ServiceLocation ? (Ca.Infoway.Messagebuilder.Model.Ab_mr2007_v02_r02.Sessionmgmt.Coct_mt240003ca.ServiceLocation) this.recipient : (Ca.Infoway.Messagebuilder.Model.Ab_mr2007_v02_r02.Sessionmgmt.Coct_mt240003ca.ServiceLocation) null; }
        }
        public bool HasRecipientAsServiceDeliveryLocation() {
            return (this.recipient is Ca.Infoway.Messagebuilder.Model.Ab_mr2007_v02_r02.Sessionmgmt.Coct_mt240003ca.ServiceLocation);
        }

    }

}