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
 * Last modified: $LastChangedDate: 2012-02-16 11:14:51 -0500 (Thu, 16 Feb 2012) $
 * Revision:      $LastChangedRevision: 5575 $
 */
/* This class was auto-generated by the message builder generator tools. */
namespace Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r02.Pr.Merged {
    using Ca.Infoway.Messagebuilder.Annotation;
    using Ca.Infoway.Messagebuilder.Datatype;
    using Ca.Infoway.Messagebuilder.Datatype.Impl;
    using Ca.Infoway.Messagebuilder.Domainvalue;
    using Ca.Infoway.Messagebuilder.Model;
    using System;


    [Hl7PartTypeMappingAttribute(new string[] {"PRPM_MT306011CA.Location","PRPM_MT309000CA.Location"})]
    public class Location_2 : MessagePartBean {

        private CS typeCode;
        private INT sequenceNumber;
        private Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r02.Pr.Merged.ServiceDeliveryLocation serviceDeliveryLocation;

        public Location_2() {
            this.typeCode = new CSImpl();
            this.sequenceNumber = new INTImpl();
        }
        [Hl7XmlMappingAttribute(new string[] {"typeCode"})]
        public ParticipationType TypeCode {
            get { return (ParticipationType) this.typeCode.Value; }
            set { this.typeCode.Value = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"sequenceNumber"})]
        public int? SequenceNumber {
            get { return this.sequenceNumber.Value; }
            set { this.sequenceNumber.Value = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"serviceDeliveryLocation"})]
        public Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r02.Pr.Merged.ServiceDeliveryLocation ServiceDeliveryLocation {
            get { return this.serviceDeliveryLocation; }
            set { this.serviceDeliveryLocation = value; }
        }

    }

}