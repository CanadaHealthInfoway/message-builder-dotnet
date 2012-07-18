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
namespace Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Claims.Ficr_mt500201ca {
    using Ca.Infoway.Messagebuilder.Annotation;
    using Ca.Infoway.Messagebuilder.Datatype;
    using Ca.Infoway.Messagebuilder.Datatype.Impl;
    using Ca.Infoway.Messagebuilder.Datatype.Lang;
    using Ca.Infoway.Messagebuilder.Domainvalue;
    using Ca.Infoway.Messagebuilder.Model;
    using System;


    [Hl7PartTypeMappingAttribute(new string[] {"FICR_MT500201CA.CoveredPartyAsPatientPerson"})]
    public class CoveredPartyAsPatientPerson : MessagePartBean, Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Claims.Merged.ICoveredPartyAsPatientChoice {

        private PN name;
        private CV administrativeGenderCode;
        private TS birthTime;
        private TS deceasedTime;
        private BL multipleBirthInd;
        private INT multipleBirthOrderNumber;
        private Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Claims.Ficr_mt500201ca.ParentOrGuardianRole parentOrGuardianRole;

        public CoveredPartyAsPatientPerson() {
            this.name = new PNImpl();
            this.administrativeGenderCode = new CVImpl();
            this.birthTime = new TSImpl();
            this.deceasedTime = new TSImpl();
            this.multipleBirthInd = new BLImpl();
            this.multipleBirthOrderNumber = new INTImpl();
        }
        /**
         * <summary>Patient Name</summary>
         */
        [Hl7XmlMappingAttribute(new string[] {"name"})]
        public PersonName Name {
            get { return this.name.Value; }
            set { this.name.Value = value; }
        }

        /**
         * <summary>Person Gender</summary>
         */
        [Hl7XmlMappingAttribute(new string[] {"administrativeGenderCode"})]
        public AdministrativeGender AdministrativeGenderCode {
            get { return (AdministrativeGender) this.administrativeGenderCode.Value; }
            set { this.administrativeGenderCode.Value = value; }
        }

        /**
         * <summary>Person Date of birth</summary>
         */
        [Hl7XmlMappingAttribute(new string[] {"birthTime"})]
        public PlatformDate BirthTime {
            get { return this.birthTime.Value; }
            set { this.birthTime.Value = value; }
        }

        /**
         * <summary>time of death</summary>
         */
        [Hl7XmlMappingAttribute(new string[] {"deceasedTime"})]
        public PlatformDate DeceasedTime {
            get { return this.deceasedTime.Value; }
            set { this.deceasedTime.Value = value; }
        }

        /**
         * <summary>Person multiple birth indicator</summary>
         */
        [Hl7XmlMappingAttribute(new string[] {"multipleBirthInd"})]
        public bool? MultipleBirthInd {
            get { return this.multipleBirthInd.Value; }
            set { this.multipleBirthInd.Value = value; }
        }

        /**
         * <summary>Person multiple birth order number</summary>
         */
        [Hl7XmlMappingAttribute(new string[] {"multipleBirthOrderNumber"})]
        public int? MultipleBirthOrderNumber {
            get { return this.multipleBirthOrderNumber.Value; }
            set { this.multipleBirthOrderNumber.Value = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"parentOrGuardianRole"})]
        public Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Claims.Ficr_mt500201ca.ParentOrGuardianRole ParentOrGuardianRole {
            get { return this.parentOrGuardianRole; }
            set { this.parentOrGuardianRole = value; }
        }

    }

}