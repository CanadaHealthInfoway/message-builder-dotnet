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
 * Last modified: $LastChangedDate: 2012-01-18 21:10:51 -0500 (Wed, 18 Jan 2012) $
 * Revision:      $LastChangedRevision: 3992 $
 */

/* This class was auto-generated by the message builder generator tools. */
namespace Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Pharmacy.Pome_mt010040ca {
    using Ca.Infoway.Messagebuilder.Annotation;
    using Ca.Infoway.Messagebuilder.Datatype;
    using Ca.Infoway.Messagebuilder.Datatype.Impl;
    using Ca.Infoway.Messagebuilder.Datatype.Lang;
    using Ca.Infoway.Messagebuilder.Domainvalue;
    using Ca.Infoway.Messagebuilder.Model;
    using Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Merged;
    using Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Pharmacy.Merged;
    using System;
    using System.Collections.Generic;


    /**
     * <summary>Drug or Compound</summary>
     * 
     * <remarks><p>A catalog of drugs (manufactured material) from 
     * which drugs may be selected for prescribing/dispensing. This 
     * includes: TC - Therapeutic Class; GD - Generic Drug; GF - 
     * Generic Formulation; MD - Manufactured Drug; and CMP - 
     * Compound</p> <p>Provides a list of drugs available for 
     * prescribing/dispensing.</p></remarks>
     */
    [Hl7PartTypeMappingAttribute(new string[] {"POME_MT010040CA.Medicine"})]
    public class DrugOrCompound : MessagePartBean {

        private CV drugCode;
        private SET<TN, TrivialName> drugNames;
        private ST description;
        private CV drugForm;
        private Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Merged.Manufacturer asManufacturedProductManufacturer;
        private CS regulatoryStatusCode;
        private Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Merged.DispensedIn asContent;
        private IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Pharmacy.Merged.GroupedWithin> asSpecializedKind;
        private IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Merged.DrugContains> ingredient;

        public DrugOrCompound() {
            this.drugCode = new CVImpl();
            this.drugNames = new SETImpl<TN, TrivialName>(typeof(TNImpl));
            this.description = new STImpl();
            this.drugForm = new CVImpl();
            this.regulatoryStatusCode = new CSImpl();
            this.asSpecializedKind = new List<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Pharmacy.Merged.GroupedWithin>();
            this.ingredient = new List<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Merged.DrugContains>();
        }
        /**
         * <summary>Drug Code</summary>
         * 
         * <remarks><p>An identifier for a type of drug. Depending on 
         * where the drug is being referenced, the drug may be 
         * identified at different levels of abstraction. E.g. 
         * Manufactured drug (including vaccines), generic formulation, 
         * generic, therapeutic class, etc.</p> <p>Used to ensure clear 
         * communication by uniquely identifying a particular drug 
         * product when prescribing or dispensing. This attribute is 
         * mandatory because querying by drug code can only return drug 
         * codes.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"code"})]
        public ClinicalDrug DrugCode {
            get { return (ClinicalDrug) this.drugCode.Value; }
            set { this.drugCode.Value = value; }
        }

        /**
         * <summary>Drug Names</summary>
         * 
         * <remarks><p>The name assigned to a drug.</p> <p>Names are 
         * used for human reference communication, to allow selection 
         * from dropdowns and for local searching. Up to two names are 
         * supported: a 'search name' which is fully formed with no 
         * abbreviations, and a 'display name' which may contain 
         * abbreviations to fit within a smaller area on the 
         * screen.</p><p>This attribute is marked as 'mandatory' as 
         * drugs at any level of the drug hierarchy is supposed to have 
         * a name.</p> <p>Names are used for human reference 
         * communication, to allow selection from dropdowns and for 
         * local searching. Up to two names are supported: a 'search 
         * name' which is fully formed with no abbreviations, and a 
         * 'display name' which may contain abbreviations to fit within 
         * a smaller area on the screen.</p><p>This attribute is marked 
         * as 'mandatory' as drugs at any level of the drug hierarchy 
         * is supposed to have a name.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"name"})]
        public ICollection<TrivialName> DrugNames {
            get { return this.drugNames.RawSet(); }
        }

        /**
         * <summary>Description</summary>
         * 
         * <remarks><p>A free form textual description of a drug. This 
         * usually is only populated for custom compounds, providing 
         * instructions on the composition and creation of the 
         * compound.</p> <p>Allows description of compound ingredients 
         * and/or recipe in free text form.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"desc"})]
        public String Description {
            get { return this.description.Value; }
            set { this.description.Value = value; }
        }

        /**
         * <summary>Drug Form</summary>
         * 
         * <remarks><p>Indicates the form in which the drug product 
         * must be, or has been manufactured or custom prepared.</p> 
         * <p>Provides a constrained vocabulary for describing dose 
         * forms. The form of the drug influences how it can be used by 
         * the patient.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"formCode"})]
        public OrderableDrugForm DrugForm {
            get { return (OrderableDrugForm) this.drugForm.Value; }
            set { this.drugForm.Value = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"asManufacturedProduct/manufacturer"})]
        public Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Merged.Manufacturer AsManufacturedProductManufacturer {
            get { return this.asManufacturedProductManufacturer; }
            set { this.asManufacturedProductManufacturer = value; }
        }

        /**
         * <summary>Regulatory Status Code</summary>
         * 
         * <remarks><p>Indicates whether the drug is approved for use 
         * in Canada or not. (active = currently approved, terminated 
         * or pending = not approved)</p> <p>Allows providers to 
         * evaluate the validity of the medication for use in 
         * Canada.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"asRegulatedProduct/statusCode"})]
        public RoleStatusNormal RegulatoryStatusCode {
            get { return (RoleStatusNormal) this.regulatoryStatusCode.Value; }
            set { this.regulatoryStatusCode.Value = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"asContent"})]
        public Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Merged.DispensedIn AsContent {
            get { return this.asContent; }
            set { this.asContent = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"asSpecializedKind"})]
        public IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Pharmacy.Merged.GroupedWithin> AsSpecializedKind {
            get { return this.asSpecializedKind; }
        }

        [Hl7XmlMappingAttribute(new string[] {"ingredient"})]
        public IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Merged.DrugContains> Ingredient {
            get { return this.ingredient; }
        }

    }

}