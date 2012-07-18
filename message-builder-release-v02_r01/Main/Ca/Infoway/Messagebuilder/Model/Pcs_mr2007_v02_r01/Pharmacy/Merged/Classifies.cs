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
 * Last modified: $LastChangedDate: 2012-02-16 11:06:56 -0500 (Thu, 16 Feb 2012) $
 * Revision:      $LastChangedRevision: 5470 $
 */
/* This class was auto-generated by the message builder generator tools. */
namespace Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r01.Pharmacy.Merged {
    using Ca.Infoway.Messagebuilder.Annotation;
    using Ca.Infoway.Messagebuilder.Model;


    /**
     * <summary>PORX_MT060340CA.Component4: classifies</summary>
     * 
     * <remarks><p>Indicates the clinical use category in which the 
     * prescription has been put.</p> <p>Allows prescriptions to be 
     * categorized in multiple ways.</p> 
     * PORX_MT010120CA.Component4: classified by <p>Indicates the 
     * clinical use category in which the prescription has been 
     * put.</p> <p>Allows prescriptions to be categorized in 
     * multiple ways.</p> PORX_MT060160CA.Component4: classifies 
     * <p>Indicates the clinical use category in which the 
     * prescription has been put.</p> <p>Allows prescriptions to be 
     * categorized in multiple ways.</p><p>Attribute is marked 
     * &quot;populated' to ensure that an item on the medication 
     * profile is categorized or 'null' value specified.</p> 
     * <p>Allows prescriptions to be categorized in multiple 
     * ways.</p><p>Attribute is marked &quot;populated' to ensure 
     * that an item on the medication profile is categorized or 
     * 'null' value specified.</p> PORX_MT030040CA.Component4: 
     * classifies <p>Indicates the clinical use category in which 
     * the prescription has been put.</p> <p>Allows prescriptions 
     * to be categorized in multiple ways.</p> 
     * PORX_MT060190CA.Component4: classifies <p>Indicates the 
     * clinical use category in which the prescription has been 
     * put.</p> <p>Allows prescriptions to be categorized in 
     * multiple ways.</p></remarks>
     */
    [Hl7PartTypeMappingAttribute(new string[] {"PORX_MT010120CA.Component4","PORX_MT030040CA.Component4","PORX_MT060160CA.Component4","PORX_MT060190CA.Component4","PORX_MT060340CA.Component4"})]
    public class Classifies : MessagePartBean {

        private Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r01.Pharmacy.Merged.DrugUse workingListEvent;

        public Classifies() {
        }
        [Hl7XmlMappingAttribute(new string[] {"workingListEvent"})]
        public Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r01.Pharmacy.Merged.DrugUse WorkingListEvent {
            get { return this.workingListEvent; }
            set { this.workingListEvent = value; }
        }

    }

}