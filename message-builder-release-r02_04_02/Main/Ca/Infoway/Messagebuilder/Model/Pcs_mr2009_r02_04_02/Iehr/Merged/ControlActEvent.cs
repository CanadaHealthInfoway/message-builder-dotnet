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
 * Last modified: $LastChangedDate: 2012-01-18 21:06:13 -0500 (Wed, 18 Jan 2012) $
 * Revision:      $LastChangedRevision: 3939 $
 */

/* This class was auto-generated by the message builder generator tools. */
namespace Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Iehr.Merged {
    using Ca.Infoway.Messagebuilder.Annotation;
    using Ca.Infoway.Messagebuilder.Datatype;
    using Ca.Infoway.Messagebuilder.Datatype.Impl;
    using Ca.Infoway.Messagebuilder.Domainvalue;
    using Ca.Infoway.Messagebuilder.Model;


    /**
     * <summary>AmendmentSummary</summary>
     * 
     * <remarks>REPC_MT500004CA.ControlActEvent: Amendment Summary 
     * </p> </p> REPC_MT500003CA.ControlActEvent: Amendment Summary 
     * </p> </p></remarks>
     */
    [Hl7PartTypeMappingAttribute(new string[] {"REPC_MT500003CA.ControlActEvent","REPC_MT500004CA.ControlActEvent"})]
    public class ControlActEvent : MessagePartBean {

        private CV amendReason;
        private Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Iehr.Merged.RequestedBy author;

        public ControlActEvent() {
            this.amendReason = new CVImpl();
        }
        /**
         * <summary>AmendReason</summary>
         * 
         * <remarks>Amend Reason </p> </p> </p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"reasonCode"})]
        public ControlActReason AmendReason {
            get { return (ControlActReason) this.amendReason.Value; }
            set { this.amendReason.Value = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"author"})]
        public Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Iehr.Merged.RequestedBy Author {
            get { return this.author; }
            set { this.author = value; }
        }

    }

}