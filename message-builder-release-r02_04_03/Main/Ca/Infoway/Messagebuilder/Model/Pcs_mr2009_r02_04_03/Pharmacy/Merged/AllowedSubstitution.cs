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
namespace Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Pharmacy.Merged {
    using Ca.Infoway.Messagebuilder.Annotation;
    using Ca.Infoway.Messagebuilder.Datatype;
    using Ca.Infoway.Messagebuilder.Datatype.Impl;
    using Ca.Infoway.Messagebuilder.Domainvalue;
    using Ca.Infoway.Messagebuilder.Model;
    using System;


    /**
     * <summary>AllowedSubstitution</summary>
     * 
     * <remarks>PORX_MT060340CA.SubstitutionPermission: Allowed 
     * Substitution <p>A prescriber's instruction that a specific 
     * prescribed product be dispensed as is, or not.</p> <p>May 
     * have financial and therapeutic conformance ramifications for 
     * a patient.</p> PORX_MT010120CA.SubstitutionPermission: 
     * Allowed Substitution <p>A prescriber's instruction that a 
     * specific prescribed product be dispensed as is, or not.</p> 
     * <p>May have financial and therapeutic conformance 
     * ramifications for a patient.</p> 
     * PORX_MT060160CA.SubstitutionPermission: Allowed Substitution 
     * <p>A prescriber's instruction that a specific prescribed 
     * product be dispensed as is, or not.</p> <p>May have 
     * financial and therapeutic conformance ramifications for a 
     * patient.</p></remarks>
     */
    [Hl7PartTypeMappingAttribute(new string[] {"PORX_MT010120CA.SubstitutionPermission","PORX_MT060160CA.SubstitutionPermission","PORX_MT060340CA.SubstitutionPermission"})]
    public class AllowedSubstitution : MessagePartBean {

        private CV code;
        private BL negationInd;
        private CV reasonCode;

        public AllowedSubstitution() {
            this.code = new CVImpl();
            this.negationInd = new BLImpl();
            this.reasonCode = new CVImpl();
        }
        /**
         * <summary>Substituion Allowed</summary>
         * 
         * <remarks><p>Provides the ability for a prescriber to 
         * indicate the type of allowed subsitution</p> <p>Provides 
         * direction to the dispensing provider/ facility</p> 
         * Substitution allowed <p>Provides the ability for a 
         * prescriber to indicate the type of allowed substitution</p> 
         * <p>Provides direction to the dispensing provider/ 
         * facility</p> Substitution Allowed <p>Provides the ability 
         * for a prescriber to indicate the type of allowed 
         * substitution</p> <p>Provides direction to the dispensing 
         * provider/ facility</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"code"})]
        public ActSubstanceAdminSubstitutionCode Code {
            get { return (ActSubstanceAdminSubstitutionCode) this.code.Value; }
            set { this.code.Value = value; }
        }

        /**
         * <summary>A:Substitution Not Allowed?</summary>
         * 
         * <remarks><p>If true, indicates that the prescriber has 
         * prohibited substitution. Default is that substitution is 
         * allowed.</p> <p>Indicates whether substitutions are allowed. 
         * The attribute is mandatory because whether substitution is 
         * allowed must be declared.</p> A:Substitution Not Allowed 
         * Indicator <p>If true, indicates that the drug must be 
         * dispensed exactly as prescribed</p> <p>Many jurisdictions 
         * allow substitution by default and require prescribers to 
         * explicitly declare when they do not want 
         * substitution.</p><p>The attribute is mandatory because it 
         * must be known whether the indicator is true or false.</p> 
         * <p>Many jurisdictions allow substitution by default and 
         * require prescribers to explicitly declare when they do not 
         * want substitution.</p><p>The attribute is mandatory because 
         * it must be known whether the indicator is true or false.</p> 
         * A:Substitution Not Allowed Indicator <p>If true, indicates 
         * that the drug must be dispensed exactly as prescribed</p> 
         * <p>Many jurisdictions allow substitution by default and 
         * require prescribers to explicitly declare when they do not 
         * want substitution. The element is mandatory because it must 
         * be explicitly true or false.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"negationInd"})]
        public bool? NegationInd {
            get { return this.negationInd.Value; }
            set { this.negationInd.Value = value; }
        }

        /**
         * <summary>B:Substitution Not Allowed Reason</summary>
         * 
         * <remarks><p>The reason why the prescriber has indicated that 
         * substitution is not allowed by the dispensing pharmacy.</p> 
         * <p>Some jurisdictions demand that a prescriber gives a 
         * reason for prohibiting substitution. The field is marked as 
         * 'Populated' because the reason for substitution is important 
         * to understanding the decision. However when a prescription 
         * is being recorded in the pharmacy, the information may not 
         * be available.</p> Not Allowed Reason <p>The reason why the 
         * prescriber has indicated that substitution is not allowed by 
         * the dispensing pharmacy.</p> <p>Some jurisdictions demand 
         * that a prescriber gives a reason for prohibiting 
         * substitution.</p><p>The field is marked as 'Populated' 
         * because the reason for substitution is important to 
         * understanding the decision. However when a prescription is 
         * being recorded in the pharmacy, the information may not be 
         * available.</p> <p>Some jurisdictions demand that a 
         * prescriber gives a reason for prohibiting 
         * substitution.</p><p>The field is marked as 'Populated' 
         * because the reason for substitution is important to 
         * understanding the decision. However when a prescription is 
         * being recorded in the pharmacy, the information may not be 
         * available.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"reasonCode"})]
        public SubstanceAdminSubstitutionNotAllowedReason ReasonCode {
            get { return (SubstanceAdminSubstitutionNotAllowedReason) this.reasonCode.Value; }
            set { this.reasonCode.Value = value; }
        }

    }

}