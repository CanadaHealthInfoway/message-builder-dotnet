/**
 * Copyright 2013 Canada Health Infoway, Inc.
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
 * Author:        $LastChangedBy: gng $
 * Last modified: $LastChangedDate: 2015-11-19 18:20:12 -0500 (Fri, 30 Jan 2015) $
 * Revision:      $LastChangedRevision: 9755 $
 */


/* This class was auto-generated by the message builder generator tools. */
namespace Ca.Infoway.Messagebuilder.Model.Ccda_pcs_r1_1.Medicationinformation {
    using Ca.Infoway.Messagebuilder.Annotation;
    using Ca.Infoway.Messagebuilder.Datatype;
    using Ca.Infoway.Messagebuilder.Datatype.Impl;
    using Ca.Infoway.Messagebuilder.Datatype.Lang;
    using Ca.Infoway.Messagebuilder.Model;
    using Ca.Infoway.Messagebuilder.Model.Ccda_pcs_r1_1.Domainvalue;
    using Ca.Infoway.Messagebuilder.Model.Ccda_pcs_r1_1.Merged;
    using System;
    using System.Collections.Generic;


    [Hl7PartTypeMappingAttribute(new string[] {"MedicationInformation.ManufacturedProduct"})]
    public class ManufacturedProduct : MessagePartBean {

        private II typeId;
        private LIST<II, Identifier> templateId;
        private LIST<II, Identifier> id;
        private II manufacturedMaterialTypeId;
        private LIST<II, Identifier> manufacturedMaterialTemplateId;
        private CE manufacturedMaterialCode;
        private EN<EntityName> manufacturedMaterialName;
        private ST manufacturedMaterialLotNumberText;
        private Ca.Infoway.Messagebuilder.Model.Ccda_pcs_r1_1.Merged.Organization_1 manufacturerOrganization;

        public ManufacturedProduct() {
            this.typeId = new IIImpl();
            this.templateId = new LISTImpl<II, Identifier>(typeof(IIImpl));
            this.id = new LISTImpl<II, Identifier>(typeof(IIImpl));
            this.manufacturedMaterialTypeId = new IIImpl();
            this.manufacturedMaterialTemplateId = new LISTImpl<II, Identifier>(typeof(IIImpl));
            this.manufacturedMaterialCode = new CEImpl();
            this.manufacturedMaterialName = new ENImpl<EntityName>();
            this.manufacturedMaterialLotNumberText = new STImpl();
        }
        /**
         * <summary>Relationship: 
         * MedicationInformation.ManufacturedProduct.typeId</summary>
         * 
         * <remarks>Conformance/Cardinality: OPTIONAL (0-1)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"typeId"})]
        public Identifier TypeId {
            get { return this.typeId.Value; }
            set { this.typeId.Value = value; }
        }

        /**
         * <summary>Relationship: 
         * MedicationInformation.ManufacturedProduct.templateId</summary>
         * 
         * <remarks>Conformance/Cardinality: MANDATORY (*)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"templateId"})]
        public IList<Identifier> TemplateId {
            get { return this.templateId.RawList(); }
        }

        /**
         * <summary>Relationship: 
         * MedicationInformation.ManufacturedProduct.id</summary>
         * 
         * <remarks>Conformance/Cardinality: OPTIONAL (0-*)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"id"})]
        public IList<Identifier> Id {
            get { return this.id.RawList(); }
        }

        /**
         * <summary>Relationship: MedicationInformation.Material.typeId</summary>
         * 
         * <remarks>Conformance/Cardinality: OPTIONAL (0-1)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"manufacturedMaterial/typeId"})]
        public Identifier ManufacturedMaterialTypeId {
            get { return this.manufacturedMaterialTypeId.Value; }
            set { this.manufacturedMaterialTypeId.Value = value; }
        }

        /**
         * <summary>Relationship: 
         * MedicationInformation.Material.templateId</summary>
         * 
         * <remarks>Conformance/Cardinality: OPTIONAL (0-*)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"manufacturedMaterial/templateId"})]
        public IList<Identifier> ManufacturedMaterialTemplateId {
            get { return this.manufacturedMaterialTemplateId.RawList(); }
        }

        /**
         * <summary>Relationship: MedicationInformation.Material.code</summary>
         * 
         * <remarks>Conformance/Cardinality: POPULATED (1)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"manufacturedMaterial/code"})]
        public Ca.Infoway.Messagebuilder.Model.Ccda_pcs_r1_1.Domainvalue.MedicationClinicalDrugName ManufacturedMaterialCode {
            get { return (Ca.Infoway.Messagebuilder.Model.Ccda_pcs_r1_1.Domainvalue.MedicationClinicalDrugName) this.manufacturedMaterialCode.Value; }
            set { this.manufacturedMaterialCode.Value = value; }
        }

        /**
         * <summary>Relationship: MedicationInformation.Material.name</summary>
         * 
         * <remarks>Conformance/Cardinality: OPTIONAL (0-1)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"manufacturedMaterial/name"})]
        public EntityName ManufacturedMaterialName {
            get { return this.manufacturedMaterialName.Value; }
            set { this.manufacturedMaterialName.Value = value; }
        }

        /**
         * <summary>Relationship: 
         * MedicationInformation.Material.lotNumberText</summary>
         * 
         * <remarks>Conformance/Cardinality: OPTIONAL (0-1)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"manufacturedMaterial/lotNumberText"})]
        public String ManufacturedMaterialLotNumberText {
            get { return this.manufacturedMaterialLotNumberText.Value; }
            set { this.manufacturedMaterialLotNumberText.Value = value; }
        }

        /**
         * <summary>Relationship: 
         * MedicationInformation.ManufacturedProduct.manufacturerOrganization</summary>
         * 
         * <remarks>Conformance/Cardinality: OPTIONAL (0-1)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"manufacturerOrganization"})]
        public Ca.Infoway.Messagebuilder.Model.Ccda_pcs_r1_1.Merged.Organization_1 ManufacturerOrganization {
            get { return this.manufacturerOrganization; }
            set { this.manufacturerOrganization = value; }
        }

    }

}