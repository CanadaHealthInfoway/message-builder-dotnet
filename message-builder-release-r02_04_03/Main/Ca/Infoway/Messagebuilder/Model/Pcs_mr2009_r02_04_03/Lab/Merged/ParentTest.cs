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
namespace Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Lab.Merged {
    using Ca.Infoway.Messagebuilder.Annotation;
    using Ca.Infoway.Messagebuilder.Datatype;
    using Ca.Infoway.Messagebuilder.Datatype.Impl;
    using Ca.Infoway.Messagebuilder.Datatype.Lang;
    using Ca.Infoway.Messagebuilder.Model;


    /**
     * <summary>ParentTest</summary>
     * 
     * <remarks>POLB_MT001999CA.ActParentPointer: Parent Test 
     * <p>Communicates the parent order (id) in a repeating child 
     * order.</p> <p>Associates a repeating child order with it's 
     * parent order.</p> POLB_MT001010CA.ActParentPointer: Parent 
     * Test <p>The classCode shall carry one of ACT, BATTERY or OBS 
     * according to the parent order classCode.</p> <p>Communicates 
     * the parent order (id) in a repeating child order.</p> 
     * <p>Associates a repeating child order with it's parent 
     * order.</p> POLB_MT001001CA.ActParentPointer: Parent Test 
     * <p>The classCode shall carry one of ACT, BATTERY or OBS 
     * according to the parent order classCode.</p> <p>Communicates 
     * the parent order (id) in a repeating child order.</p> 
     * <p>Associates a repeating child order with it's parent 
     * order.</p> POLB_MT001000CA.ActParentPointer: Parent Test 
     * <p>The classCode shall carry one of ACT, BATTERY or OBS 
     * according to the parent order classCode.</p> <p>Communicates 
     * the parent order (id) in a repeating child order.</p> 
     * <p>Associates a repeating child order with it's parent 
     * order.</p></remarks>
     */
    [Hl7PartTypeMappingAttribute(new string[] {"POLB_MT001000CA.ActParentPointer","POLB_MT001001CA.ActParentPointer","POLB_MT001010CA.ActParentPointer","POLB_MT001999CA.ActParentPointer"})]
    public class ParentTest : MessagePartBean {

        private II id;

        public ParentTest() {
            this.id = new IIImpl();
        }
        /**
         * <summary>ParentTestIdentifier</summary>
         * 
         * <remarks>Parent Test Identifier <p>Communicates the parent 
         * order (id) in a repeating child order.</p> <p>Used to 
         * associate a repeating child order with it's parent 
         * order.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"id"})]
        public Identifier Id {
            get { return this.id.Value; }
            set { this.id.Value = value; }
        }

    }

}