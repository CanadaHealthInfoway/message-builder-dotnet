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
 * Last modified: $LastChangedDate: 2012-01-18 21:08:39 -0500 (Wed, 18 Jan 2012) $
 * Revision:      $LastChangedRevision: 3976 $
 */

/* This class was auto-generated by the message builder generator tools. */
namespace Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Lab.Merged {
    using Ca.Infoway.Messagebuilder.Annotation;
    using Ca.Infoway.Messagebuilder.Datatype;
    using Ca.Infoway.Messagebuilder.Datatype.Impl;
    using Ca.Infoway.Messagebuilder.Datatype.Lang;
    using Ca.Infoway.Messagebuilder.Domainvalue;
    using Ca.Infoway.Messagebuilder.Model;


    /**
     * <summary>PriorTestRequest</summary>
     * 
     * <remarks>POLB_MT001999CA.PriorActRequest: Prior Test Request 
     * <p>Must contain a value assigned by the order-placing 
     * organization that uniquely identifies this test request 
     * among all test requests in the receiving application.</p> 
     * <p>This is used primarily for Order referrals.</p> 
     * POLB_MT001010CA.PriorActRequest: Prior Test Request <p>The 
     * classCode shall carry one of ACT, BATTERY or OBS according 
     * to the parent order classCode.</p> <p>Must contain a value 
     * assigned by the order-placing organization that uniquely 
     * identifies this test request among all test requests in the 
     * receiving application.</p> <p>This is used primarily for 
     * Order referrals.</p> POLB_MT001001CA.PriorActRequest: Prior 
     * Test Request <p>The classCode shall carry one of ACT, 
     * BATTERY or OBS according to the parent order classCode.</p> 
     * <p>Must contain a value assigned by the order-placing 
     * organization that uniquely identifies this test request 
     * among all test requests in the receiving application.</p> 
     * <p>This is used primarily for Order referrals.</p></remarks>
     */
    [Hl7PartTypeMappingAttribute(new string[] {"POLB_MT001000CA.PriorActRequest","POLB_MT001001CA.PriorActRequest","POLB_MT001010CA.PriorActRequest","POLB_MT001999CA.PriorActRequest"})]
    public class PriorTestRequest : MessagePartBean {

        private II priorTestIdentifier;
        private CS priorTestStatus;

        public PriorTestRequest() {
            this.priorTestIdentifier = new IIImpl();
            this.priorTestStatus = new CSImpl();
        }
        /**
         * <summary>PriorTestIdentifier</summary>
         * 
         * <remarks>Prior Test Identifier <p>Uniquely identifies this 
         * test request among all test requests in the receiving 
         * application.</p> <p>Used for order referrals. This attribute 
         * communicates the identifier of the original test request 
         * (target) from which the (source) referral request 
         * originated.</p> Prior Test Identifier</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"id"})]
        public Identifier PriorTestIdentifier {
            get { return this.priorTestIdentifier.Value; }
            set { this.priorTestIdentifier.Value = value; }
        }

        /**
         * <summary>PriorTestStatus</summary>
         * 
         * <remarks>Prior Test Status Prior Test Status <p>The status 
         * of the prior test request.</p> <p>Used for order 
         * referrals.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"statusCode"})]
        public ActStatus PriorTestStatus {
            get { return (ActStatus) this.priorTestStatus.Value; }
            set { this.priorTestStatus.Value = value; }
        }

    }

}