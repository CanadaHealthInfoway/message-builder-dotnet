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
 * Last modified: $LastChangedDate: 2012-01-18 21:07:59 -0500 (Wed, 18 Jan 2012) $
 * Revision:      $LastChangedRevision: 3967 $
 */

/* This class was auto-generated by the message builder generator tools. */
namespace Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Immunization.Merged {
    using Ca.Infoway.Messagebuilder.Annotation;
    using Ca.Infoway.Messagebuilder.Datatype;
    using Ca.Infoway.Messagebuilder.Datatype.Impl;
    using Ca.Infoway.Messagebuilder.Domainvalue;
    using Ca.Infoway.Messagebuilder.Model;
    using System;


    /**
     * <summary>POIZ_MT030060CA.NoImmunizationReason: (no business 
     * name)</summary>
     * 
     * <remarks><p>Identifies the reason why an immunization event 
     * did not occur.</p> <p>Needed for explicitly communicating 
     * the reason why a patient was not administered as 
     * vaccine.</p></remarks>
     */
    [Hl7PartTypeMappingAttribute(new string[] {"POIZ_MT030050CA.NoImmunizationReason","POIZ_MT030060CA.NoImmunizationReason","POIZ_MT060150CA.NoImmunizationReason"})]
    public class NoImmunizationReason : MessagePartBean, Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Merged.IChoice {

        private ST immunizationRefusalReasonText;
        private CV immunizationRefusalReason;

        public NoImmunizationReason() {
            this.immunizationRefusalReasonText = new STImpl();
            this.immunizationRefusalReason = new CVImpl();
        }
        /**
         * <summary>ImmunizationRefusalReasonText</summary>
         * 
         * <remarks>Immunization Refusal Reason Text <p>A textual or 
         * multimedia description (or reference to a description) of 
         * the reason.</p> <p>Provides additional context and 
         * description relating to the reason for not immunizing. Not 
         * all implementations will support text. As a result, this 
         * attribute is optional.</p> Immunization Refusal Reason Text</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"text"})]
        public String ImmunizationRefusalReasonText {
            get { return this.immunizationRefusalReasonText.Value; }
            set { this.immunizationRefusalReasonText.Value = value; }
        }

        /**
         * <summary>ImmunizationRefusalReason</summary>
         * 
         * <remarks>Immunization Refusal Reason <p>A coded value 
         * denoting a patient's reason for refusing to be 
         * immunized.</p><p>Typical reasons include: Parental decision, 
         * Religious exemption, Patient decision, previous adverse 
         * event etc.</p> <p>A coded value denoting a patient's reason 
         * for refusing to be immunized.</p><p>Typical reasons include: 
         * Parental decision, Religious exemption, Patient decision, 
         * previous adverse event etc.</p> <p>Allows sorting and 
         * categorizing different kinds of refusal reasons. Ensures 
         * that reasons are gathered in a consistent analyzable manner. 
         * As a result, this attribute is mandatory.</p> Immunization 
         * Refusal Reason</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"reasonCode"})]
        public ActNoImmunizationReason ImmunizationRefusalReason {
            get { return (ActNoImmunizationReason) this.immunizationRefusalReason.Value; }
            set { this.immunizationRefusalReason.Value = value; }
        }

    }

}