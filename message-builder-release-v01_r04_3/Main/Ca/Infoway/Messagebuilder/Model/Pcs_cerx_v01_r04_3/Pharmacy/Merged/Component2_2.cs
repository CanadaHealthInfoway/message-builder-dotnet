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
 * Last modified: $LastChangedDate: 2012-02-16 10:58:52 -0500 (Thu, 16 Feb 2012) $
 * Revision:      $LastChangedRevision: 5374 $
 */
/* This class was auto-generated by the message builder generator tools. */
namespace Ca.Infoway.Messagebuilder.Model.Pcs_cerx_v01_r04_3.Pharmacy.Merged {
    using Ca.Infoway.Messagebuilder.Annotation;
    using Ca.Infoway.Messagebuilder.Datatype;
    using Ca.Infoway.Messagebuilder.Datatype.Impl;
    using Ca.Infoway.Messagebuilder.Model;
    using System;


    /**
     * <summary>Includes</summary>
     * 
     * <remarks>PORX_MT020070CA.Component2: (no business name) 
     * <p>Component must be specified if the id is null and can not 
     * be specified if the id is not null.</p> 
     * PORX_MT030040CA.Component6: f:includes <p>Identifies the 
     * instructions for how the prescribed medication should be 
     * dispensed to the patient.</p> <p>An essential part of most 
     * prescriptions is the authorization to dispense. Multiple 
     * repetitions are included to accommodate circumstances where 
     * multiple drug products may need to be dispensed to complete 
     * a therapy. E.g. 100 x 20mg tablets and 50 x 10mg tablets. 
     * The association is marked as Populated because the 
     * authorization to dispense is a critical portion of a 
     * prescription. However the association is allowed to be 
     * 'null' when the order is for a medication which requires no 
     * dispense authorization (e.g. over-the-counter medications), 
     * or when the patient already has sufficient supply of the 
     * medication on hand to complete the therapy.</p> 
     * PORX_MT060190CA.Component6: f:includes <p>Identifies the 
     * instructions for how the prescribed medication should be 
     * dispensed to the patient.</p> <p>An essential part of most 
     * prescriptions is the authorization to dispense. Multiple 
     * repetitions are included to accommodate circumstances where 
     * multiple drug products may need to be dispensed to complete 
     * a therapy. E.g. 100 x 20mg tablets and 50 x 10mg tablets. 
     * The association is marked as Populated because the 
     * authorization to dispense is a critical portion of a 
     * prescription. However the association is allowed to be 
     * 'null' when the order is for a medication which requires no 
     * dispense authorization (e.g. over-the-counter medications), 
     * or when the patient already has sufficient supply of the 
     * medication on hand to complete the therapy.</p></remarks>
     */
    [Hl7PartTypeMappingAttribute(new string[] {"PORX_MT020070CA.Component2","PORX_MT030040CA.Component6","PORX_MT060190CA.Component6"})]
    public class Component2_2 : MessagePartBean {

        private BL contextConductionInd;
        private Ca.Infoway.Messagebuilder.Model.Pcs_cerx_v01_r04_3.Pharmacy.Merged.DispenseInstructions_2 supplyRequest;

        public Component2_2() {
            this.contextConductionInd = new BLImpl();
        }
        [Hl7XmlMappingAttribute(new string[] {"contextConductionInd"})]
        public bool? ContextConductionInd {
            get { return this.contextConductionInd.Value; }
            set { this.contextConductionInd.Value = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"supplyRequest"})]
        public Ca.Infoway.Messagebuilder.Model.Pcs_cerx_v01_r04_3.Pharmacy.Merged.DispenseInstructions_2 SupplyRequest {
            get { return this.supplyRequest; }
            set { this.supplyRequest = value; }
        }

    }

}