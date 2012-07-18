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
 * Last modified: $LastChangedDate: 2012-01-18 21:00:08 -0500 (Wed, 18 Jan 2012) $
 * Revision:      $LastChangedRevision: 3886 $
 */

/* This class was auto-generated by the message builder generator tools. */
namespace Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Merged {
    using Ca.Infoway.Messagebuilder.Annotation;
    using Ca.Infoway.Messagebuilder.Datatype;
    using Ca.Infoway.Messagebuilder.Datatype.Impl;
    using Ca.Infoway.Messagebuilder.Domainvalue;
    using Ca.Infoway.Messagebuilder.Model;
    using System;


    [Hl7PartTypeMappingAttribute(new string[] {"FICR_MT400001CA.Medicine","FICR_MT400003CA.Medicine","FICR_MT400004CA.Medicine","FICR_MT490101CA.Medicine"})]
    public class Medicine : MessagePartBean {

        private CV drugCode;
        private ST drugName;
        private ST drugDescription;
        private CV drugForm;
        private Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Merged.DrugContains ingredient;

        public Medicine() {
            this.drugCode = new CVImpl();
            this.drugName = new STImpl();
            this.drugDescription = new STImpl();
            this.drugForm = new CVImpl();
        }
        /**
         * <summary>DrugCode</summary>
         * 
         * <remarks>Drug Code</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"code"})]
        public ClinicalDrug DrugCode {
            get { return (ClinicalDrug) this.drugCode.Value; }
            set { this.drugCode.Value = value; }
        }

        /**
         * <summary>DrugName</summary>
         * 
         * <remarks>Drug Name</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"name"})]
        public String DrugName {
            get { return this.drugName.Value; }
            set { this.drugName.Value = value; }
        }

        /**
         * <summary>DrugDescription</summary>
         * 
         * <remarks>Drug Description</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"desc"})]
        public String DrugDescription {
            get { return this.drugDescription.Value; }
            set { this.drugDescription.Value = value; }
        }

        /**
         * <summary>DrugForm</summary>
         * 
         * <remarks>Drug Form <p>Indicates the form in which the drug 
         * product must be, or has been manufactured or custom 
         * prepared. Examples include: tablet, suspension, liquid, 
         * injectable, capsule, etc.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"formCode"})]
        public OrderableDrugForm DrugForm {
            get { return (OrderableDrugForm) this.drugForm.Value; }
            set { this.drugForm.Value = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"ingredient"})]
        public Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Merged.DrugContains Ingredient {
            get { return this.ingredient; }
            set { this.ingredient = value; }
        }

    }

}