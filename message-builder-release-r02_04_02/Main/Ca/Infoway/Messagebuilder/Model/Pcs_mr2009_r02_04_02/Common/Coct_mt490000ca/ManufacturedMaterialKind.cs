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
 * Last modified: $LastChangedDate: 2012-01-18 21:04:17 -0500 (Wed, 18 Jan 2012) $
 * Revision:      $LastChangedRevision: 3924 $
 */

/* This class was auto-generated by the message builder generator tools. */
namespace Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Common.Coct_mt490000ca {
    using Ca.Infoway.Messagebuilder;
    using Ca.Infoway.Messagebuilder.Annotation;
    using Ca.Infoway.Messagebuilder.Datatype;
    using Ca.Infoway.Messagebuilder.Datatype.Impl;
    using Ca.Infoway.Messagebuilder.Datatype.Lang;
    using Ca.Infoway.Messagebuilder.Model;
    using System;


    /**
     * <summary>Manufactured Material Kind</summary>
     * 
     * <remarks><p>Type of Product</p></remarks>
     */
    [Hl7PartTypeMappingAttribute(new string[] {"COCT_MT490000CA.ManufacturedMaterialKind"})]
    public class ManufacturedMaterialKind : MessagePartBean {

        private CV manufacturedMaterialCode;
        private ST packageDescription;
        private IVL<TS, Interval<PlatformDate>> timeOfWarranty;
        private ST warrantorOrganisationName;
        private TEL warrantorOrganisationTelecom;
        private PQ packageQuantity;
        private Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Common.Coct_mt490000ca.ManufacturedMaterialKind contentPackagedProductContainedManufacturedMaterialKind;

        public ManufacturedMaterialKind() {
            this.manufacturedMaterialCode = new CVImpl();
            this.packageDescription = new STImpl();
            this.timeOfWarranty = new IVLImpl<TS, Interval<PlatformDate>>();
            this.warrantorOrganisationName = new STImpl();
            this.warrantorOrganisationTelecom = new TELImpl();
            this.packageQuantity = new PQImpl();
        }
        /**
         * <summary>Manufactured material code</summary>
         * 
         * <remarks><p>Code for manufactured material</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"code"})]
        public Code ManufacturedMaterialCode {
            get { return (Code) this.manufacturedMaterialCode.Value; }
            set { this.manufacturedMaterialCode.Value = value; }
        }

        /**
         * <summary>Package description</summary>
         * 
         * <remarks><p>box, blister pack, compliance packaging, etc. 
         * HC-PCS?</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"desc"})]
        public String PackageDescription {
            get { return this.packageDescription.Value; }
            set { this.packageDescription.Value = value; }
        }

        /**
         * <summary>Time of warranty</summary>
         * 
         * <remarks><p>time of warranty</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"asWarrantor/effectiveTime"})]
        public Interval<PlatformDate> TimeOfWarranty {
            get { return this.timeOfWarranty.Value; }
            set { this.timeOfWarranty.Value = value; }
        }

        /**
         * <summary>Warrantor Organisation Name</summary>
         * 
         * <remarks><p>name of Organization that holds warranty</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"asWarrantor/warrantingWarrantorOrganization/name"})]
        public String WarrantorOrganisationName {
            get { return this.warrantorOrganisationName.Value; }
            set { this.warrantorOrganisationName.Value = value; }
        }

        /**
         * <summary>Warrantor Organisation telecom</summary>
         * 
         * <remarks><p>Warrantor Organization telephone number</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"asWarrantor/warrantingWarrantorOrganization/telecom"})]
        public TelecommunicationAddress WarrantorOrganisationTelecom {
            get { return this.warrantorOrganisationTelecom.Value; }
            set { this.warrantorOrganisationTelecom.Value = value; }
        }

        /**
         * <summary>Package Quantity</summary>
         * 
         * <remarks><p>number of items in the package</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"contentPackagedProduct/quantity"})]
        public PhysicalQuantity PackageQuantity {
            get { return this.packageQuantity.Value; }
            set { this.packageQuantity.Value = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"contentPackagedProduct/containedManufacturedMaterialKind"})]
        public Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Common.Coct_mt490000ca.ManufacturedMaterialKind ContentPackagedProductContainedManufacturedMaterialKind {
            get { return this.contentPackagedProductContainedManufacturedMaterialKind; }
            set { this.contentPackagedProductContainedManufacturedMaterialKind = value; }
        }

    }

}