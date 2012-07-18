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
 * Last modified: $LastChangedDate: 2012-02-16 11:13:49 -0500 (Thu, 16 Feb 2012) $
 * Revision:      $LastChangedRevision: 5556 $
 */
/* This class was auto-generated by the message builder generator tools. */
namespace Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r02.Pharmacy.Porx_mt010120ca {
    using Ca.Infoway.Messagebuilder.Annotation;
    using Ca.Infoway.Messagebuilder.Datatype;
    using Ca.Infoway.Messagebuilder.Datatype.Impl;
    using Ca.Infoway.Messagebuilder.Model;
    using System;


    /**
     * <summary><p>Enables the indication of whether the 
     * prescription is ineligible for trial dispensing.</p></summary>
     * 
     * <remarks><p>Serves as reminder for dispenser that the 
     * prescription is not to be trial-filled. In some 
     * jurisdictions, the prescription must be so designated by the 
     * prescriber for the dispenser to do trial dispensing.</p></remarks>
     */
    [Hl7PartTypeMappingAttribute(new string[] {"PORX_MT010120CA.Component2"})]
    public class Component2 : MessagePartBean {

        private BL negationInd;

        public Component2() {
            this.negationInd = new BLImpl();
        }
        /**
         * <summary>G:Not Eligible for Trial?</summary>
         * 
         * <remarks><p>An indication that a prescription is or is not 
         * eligible for trial dispensing from a clinical (not 
         * financial) perspective. False = Eligible, True = Not 
         * Eligible.</p> <p>May affect dispensers' discretion to 
         * dispense anything other than prescribed fill 
         * quantity.</p><p>Expressed as 'Non-Eligibility' rather than 
         * 'Eligibility' due to restrictions in HL7 modeling.</p><p>The 
         * element is mandatory because it must always be known whether 
         * the element is true or false.</p> <p>May affect dispensers' 
         * discretion to dispense anything other than prescribed fill 
         * quantity.</p><p>Expressed as 'Non-Eligibility' rather than 
         * 'Eligibility' due to restrictions in HL7 modeling.</p><p>The 
         * element is mandatory because it must always be known whether 
         * the element is true or false.</p> <p>May affect dispensers' 
         * discretion to dispense anything other than prescribed fill 
         * quantity.</p><p>Expressed as 'Non-Eligibility' rather than 
         * 'Eligibility' due to restrictions in HL7 modeling.</p><p>The 
         * element is mandatory because it must always be known whether 
         * the element is true or false.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"negationInd"})]
        public bool? NegationInd {
            get { return this.negationInd.Value; }
            set { this.negationInd.Value = value; }
        }

    }

}