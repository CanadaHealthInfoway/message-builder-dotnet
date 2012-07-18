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
namespace Ca.Infoway.Messagebuilder.Model.Ab_mr2007_v02_r02.Merged {
    using Ca.Infoway.Messagebuilder.Annotation;
    using Ca.Infoway.Messagebuilder.Datatype;
    using Ca.Infoway.Messagebuilder.Datatype.Impl;
    using Ca.Infoway.Messagebuilder.Model;
    using System;


    /**
     * <summary>ConsistsOf</summary>
     * 
     * <remarks>PORX_MT980040CA.Component17: b:consists of 
     * <p>Dosage instructions may be given as textual information 
     * (as in Ad-hoc Dosage Instructions specified above) or as a 
     * structured set of dosage lines. This association allows for 
     * the specification of structured dosage lines.</p> 
     * <p>Structured dosage lines facilitate the checking of dosage 
     * appropriateness. It also allows for the formal calculation 
     * of days supply based on administration instructions and 
     * supplied quantity.</p> COCT_MT270010CA.Component17: 
     * b:consists of <p>Dosage instructions may be given as textual 
     * information (as in Ad-hoc Dosage Instructions specified 
     * above) or as a structured set of dosage lines. This 
     * association allows for the specification of structured 
     * dosage lines.</p> <p>Structured dosage lines facilitate the 
     * checking of dosage appropriateness. It also allows for the 
     * formal calculation of days supply based on administration 
     * instructions and supplied quantity.</p></remarks>
     */
    [Hl7PartTypeMappingAttribute(new string[] {"COCT_MT270010CA.Component17","PORX_MT980040CA.Component17"})]
    public class ConsistsOf : MessagePartBean {

        private INT sequenceNumber;
        private Ca.Infoway.Messagebuilder.Model.Ab_mr2007_v02_r02.Merged.StructuredDosageLines dosageLine;

        public ConsistsOf() {
            this.sequenceNumber = new INTImpl();
        }
        /**
         * <summary>DosageLineOrder</summary>
         * 
         * <remarks>A:Dosage Line Order <p>Indicates the order in which 
         * dosage lines should be performed. Ensures that each step of 
         * multiple and complex SIGs (e.g ramp up/down) is in the 
         * desired order. Dosage lines with the same sequence number 
         * should be performed in parallel. E.g. 2 tabs tid for 3 days 
         * (sequence 1) and then 1 tab tid for 4 days (sequence 2) E.g. 
         * 1 tab in the morning (sequence 1) and 2 tabs at bedtime 
         * (sequence 1)</p> <p>ZDP.13.10</p> <p>Clearly expresses the 
         * order of each dosage line to ensure the correct dosage is 
         * given. Element is mandatory to ensure that dosage lines are 
         * specified and followed in the order intended.</p> <p>Need 
         * examples to illustrate use of sequence lines with 'ANDs' and 
         * 'THENs'.</p> A:Dosage Line Order <p>Indicates the order in 
         * which dosage lines should be performed. Ensures that each 
         * step of multiple and complex SIGs (e.g ramp up/down) is in 
         * the desired order. Dosage lines with the same sequence 
         * number should be performed in parallel. E.g. 2 tabs tid for 
         * 3 days (sequence 1) and then 1 tab tid for 4 days (sequence 
         * 2) E.g. 1 tab in the morning (sequence 1) and 2 tabs at 
         * bedtime (sequence 1)</p> <p>ZDP.13.10</p> <p>Clearly 
         * expresses the order of each dosage line to ensure the 
         * correct dosage is given. Element is mandatory to ensure that 
         * dosage lines are specified and followed in the order 
         * intended.</p> <p>Need examples to illustrate use of sequence 
         * lines with 'ANDs' and 'THENs'.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"sequenceNumber"})]
        public int? SequenceNumber {
            get { return this.sequenceNumber.Value; }
            set { this.sequenceNumber.Value = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"dosageLine"})]
        public Ca.Infoway.Messagebuilder.Model.Ab_mr2007_v02_r02.Merged.StructuredDosageLines DosageLine {
            get { return this.dosageLine; }
            set { this.dosageLine = value; }
        }

    }

}