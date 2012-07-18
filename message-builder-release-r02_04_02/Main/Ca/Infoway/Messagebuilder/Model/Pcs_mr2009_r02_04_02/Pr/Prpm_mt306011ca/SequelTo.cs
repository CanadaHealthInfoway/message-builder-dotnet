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
 * Last modified: $LastChangedDate: 2012-01-18 21:12:42 -0500 (Wed, 18 Jan 2012) $
 * Revision:      $LastChangedRevision: 4018 $
 */

/* This class was auto-generated by the message builder generator tools. */
namespace Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Pr.Prpm_mt306011ca {
    using Ca.Infoway.Messagebuilder.Annotation;
    using Ca.Infoway.Messagebuilder.Datatype;
    using Ca.Infoway.Messagebuilder.Datatype.Impl;
    using Ca.Infoway.Messagebuilder.Model;
    using System;


    [Hl7PartTypeMappingAttribute(new string[] {"PRPM_MT306011CA.SequelTo"})]
    public class SequelTo : MessagePartBean {

        private INT orderOfInformRequests;
        private Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Pr.Prpm_mt306011ca.InformRequest informRequest;

        public SequelTo() {
            this.orderOfInformRequests = new INTImpl();
        }
        /**
         * <summary>Order of Inform Requests</summary>
         * 
         * <remarks><p>Allows each Inform Request to be sequentially 
         * listed.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"sequenceNumber"})]
        public int? OrderOfInformRequests {
            get { return this.orderOfInformRequests.Value; }
            set { this.orderOfInformRequests.Value = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"informRequest"})]
        public Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Pr.Prpm_mt306011ca.InformRequest InformRequest {
            get { return this.informRequest; }
            set { this.informRequest = value; }
        }

    }

}