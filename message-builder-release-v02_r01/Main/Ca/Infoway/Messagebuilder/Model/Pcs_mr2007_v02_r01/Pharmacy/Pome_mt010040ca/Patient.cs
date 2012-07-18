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
 * Last modified: $LastChangedDate: 2012-02-16 11:07:03 -0500 (Thu, 16 Feb 2012) $
 * Revision:      $LastChangedRevision: 5471 $
 */
/* This class was auto-generated by the message builder generator tools. */
namespace Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r01.Pharmacy.Pome_mt010040ca {
    using Ca.Infoway.Messagebuilder.Annotation;
    using Ca.Infoway.Messagebuilder.Datatype;
    using Ca.Infoway.Messagebuilder.Datatype.Impl;
    using Ca.Infoway.Messagebuilder.Domainvalue;
    using Ca.Infoway.Messagebuilder.Model;


    /**
     * <summary>Patient</summary>
     * 
     * <remarks><p>Indicates the type of patient for whom the 
     * dosage instruction applies.</p> <p>Important for qualifying 
     * and filtering dosage specifications.</p></remarks>
     */
    [Hl7PartTypeMappingAttribute(new string[] {"POME_MT010040CA.Patient"})]
    public class Patient : MessagePartBean {

        private CV patientLivingSubjectKindAdministrativeGenderCode;

        public Patient() {
            this.patientLivingSubjectKindAdministrativeGenderCode = new CVImpl();
        }
        /**
         * <summary>Patient Gender</summary>
         * 
         * <remarks><p>Indicates the gender of patient to whom the 
         * dosage specification applies.</p> <p>Some dosage 
         * specifications are gender-specific.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"patientLivingSubjectKind/administrativeGenderCode"})]
        public AdministrativeGender PatientLivingSubjectKindAdministrativeGenderCode {
            get { return (AdministrativeGender) this.patientLivingSubjectKindAdministrativeGenderCode.Value; }
            set { this.patientLivingSubjectKindAdministrativeGenderCode.Value = value; }
        }

    }

}