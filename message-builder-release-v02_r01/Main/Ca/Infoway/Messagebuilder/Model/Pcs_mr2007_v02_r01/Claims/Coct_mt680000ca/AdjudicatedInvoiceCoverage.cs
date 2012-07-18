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
 * Last modified: $LastChangedDate: 2012-02-16 11:02:52 -0500 (Thu, 16 Feb 2012) $
 * Revision:      $LastChangedRevision: 5414 $
 */
/* This class was auto-generated by the message builder generator tools. */
namespace Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r01.Claims.Coct_mt680000ca {
    using Ca.Infoway.Messagebuilder.Annotation;
    using Ca.Infoway.Messagebuilder.Datatype;
    using Ca.Infoway.Messagebuilder.Datatype.Impl;
    using Ca.Infoway.Messagebuilder.Model;
    using System;


    /**
     * <summary><p>Association is required, 1..1 and not mandatory, 
     * as EOB may have been generated from a non-HL7 EOB and the 
     * Provider s/w will not know the Policy Type to put in the 
     * target act.</p></summary>
     */
    [Hl7PartTypeMappingAttribute(new string[] {"COCT_MT680000CA.AdjudicatedInvoiceCoverage"})]
    public class AdjudicatedInvoiceCoverage : MessagePartBean {

        private INT sequenceNumber;
        private Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r01.Claims.Coct_mt680000ca.PolicyOrAccount policyOrAccount;

        public AdjudicatedInvoiceCoverage() {
            this.sequenceNumber = new INTImpl();
        }
        /**
         * <summary><p>COB priority as adjudicated primary, secondary, 
         * etc.</p></summary>
         */
        [Hl7XmlMappingAttribute(new string[] {"sequenceNumber"})]
        public int? SequenceNumber {
            get { return this.sequenceNumber.Value; }
            set { this.sequenceNumber.Value = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"policyOrAccount"})]
        public Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r01.Claims.Coct_mt680000ca.PolicyOrAccount PolicyOrAccount {
            get { return this.policyOrAccount; }
            set { this.policyOrAccount = value; }
        }

    }

}