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
 * Last modified: $LastChangedDate: 2012-02-16 11:12:39 -0500 (Thu, 16 Feb 2012) $
 * Revision:      $LastChangedRevision: 5543 $
 */
/* This class was auto-generated by the message builder generator tools. */
namespace Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r02.Cr.Prpa_mt101106ca {
    using Ca.Infoway.Messagebuilder.Annotation;
    using Ca.Infoway.Messagebuilder.Datatype;
    using Ca.Infoway.Messagebuilder.Datatype.Impl;
    using Ca.Infoway.Messagebuilder.Domainvalue;
    using Ca.Infoway.Messagebuilder.Model;
    using System;


    /**
     * <summary>Confidence Value</summary>
     * 
     * <remarks><p>Each returned IdentifiedPerson can have an 
     * associated ObservationEvent reporting the confidence value 
     * (degree of certainty) and the name of the matching algorithm 
     * that resulted in that record's inclusion in the result 
     * set.</p> <p>Supports the business requirement to provide a 
     * confidence value associated with the identifiedEntity 
     * returned in the responsedistinguishes these different 
     * representations.</p></remarks>
     */
    [Hl7PartTypeMappingAttribute(new string[] {"PRPA_MT101106CA.ObservationEvent"})]
    public class ConfidenceValue : MessagePartBean {

        private CD code;
        private REAL value;

        public ConfidenceValue() {
            this.code = new CDImpl();
            this.value = new REALImpl();
        }
        /**
         * <summary>*Probability Match Code</summary>
         * 
         * <remarks><p>Supports the business requirement to identify 
         * type of confidence matching used i.e. the code would be the 
         * name for the algorithm for the confidence value</p> 
         * <p>Mandatory attribute supports confident identification of 
         * intended client</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"code"})]
        public ActCode Code {
            get { return (ActCode) this.code.Value; }
            set { this.code.Value = value; }
        }

        /**
         * <summary>Confidence Value</summary>
         * 
         * <remarks><p>A real number value indicating the confidence of 
         * the query with regard to finding the intended target client 
         * i.e. the value would be the computed confidence value.</p> 
         * <p>Required attribute to provide information about success 
         * of query</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"value"})]
        public BigDecimal Value {
            get { return this.value.Value; }
            set { this.value.Value = value; }
        }

    }

}