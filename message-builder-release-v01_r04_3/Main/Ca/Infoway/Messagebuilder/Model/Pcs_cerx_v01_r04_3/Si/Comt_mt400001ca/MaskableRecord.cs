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
 * Last modified: $LastChangedDate: 2012-02-16 11:00:33 -0500 (Thu, 16 Feb 2012) $
 * Revision:      $LastChangedRevision: 5401 $
 */
/* This class was auto-generated by the message builder generator tools. */
namespace Ca.Infoway.Messagebuilder.Model.Pcs_cerx_v01_r04_3.Si.Comt_mt400001ca {
    using Ca.Infoway.Messagebuilder.Annotation;
    using Ca.Infoway.Messagebuilder.Datatype;
    using Ca.Infoway.Messagebuilder.Datatype.Impl;
    using Ca.Infoway.Messagebuilder.Datatype.Lang;
    using Ca.Infoway.Messagebuilder.Domainvalue;
    using Ca.Infoway.Messagebuilder.Model;
    using Ca.Infoway.Messagebuilder.Model.Pcs_cerx_v01_r04_3.Common.Merged;


    /**
     * <summary>Maskable Record</summary>
     * 
     * <remarks><p>A particular record or type of record for which 
     * masking is supported.</p> <p>The root construct for masking 
     * and unmasking specific record or type of record.</p></remarks>
     */
    [Hl7PartTypeMappingAttribute(new string[] {"COMT_MT400001CA.MaskableActType"})]
    public class MaskableRecord : MessagePartBean {

        private II id;
        private CV code;
        private CV confidentialityCode;
        private Ca.Infoway.Messagebuilder.Model.Pcs_cerx_v01_r04_3.Si.Comt_mt400001ca.Role directTargetRole;
        private Ca.Infoway.Messagebuilder.Model.Pcs_cerx_v01_r04_3.Common.Merged.Patient recordTargetPatient;
        private Ca.Infoway.Messagebuilder.Model.Pcs_cerx_v01_r04_3.Si.Comt_mt400001ca.Diagnosis reasonDiagnosis;

        public MaskableRecord() {
            this.id = new IIImpl();
            this.code = new CVImpl();
            this.confidentialityCode = new CVImpl();
        }
        /**
         * <summary>C:Record Identifier</summary>
         * 
         * <remarks><p>The identifier of the prescription, dispense, 
         * allergy, lab test result or other record for which the 
         * masking status is being changed.</p> <p>Allows unique 
         * reference to a particular record to be masked or 
         * unmasked.</p> <p>In many systems, masking a 'child' may 
         * result in automatic masking of the parent. For example, 
         * masking a dispense record may cause the prescription to 
         * become masked as well.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"id"})]
        public Identifier Id {
            get { return this.id.Value; }
            set { this.id.Value = value; }
        }

        /**
         * <summary>B:Record Type</summary>
         * 
         * <remarks><p>Indicates a detailed type of record to be 
         * masked. E.g. All lab tests of a given type.</p> <p>Allows 
         * automatic masking of a particular type of record rather than 
         * requiring each occurrence to be masked individually.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"code"})]
        public ActInformationCategoryCode Code {
            get { return (ActInformationCategoryCode) this.code.Value; }
            set { this.code.Value = value; }
        }

        /**
         * <summary>A:Masked Indicator</summary>
         * 
         * <remarks><p>Indicates the new value for the masking status 
         * of the item.</p> <p>Forces the sender of the message to 
         * assert what the new value should be, rather than performing 
         * a 'toggle' and potentially ending up in the wrong state. 
         * Therefore, the attribute is mandatory.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"confidentialityCode"})]
        public x_VeryBasicConfidentialityKind ConfidentialityCode {
            get { return (x_VeryBasicConfidentialityKind) this.confidentialityCode.Value; }
            set { this.confidentialityCode.Value = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"directTarget/role"})]
        public Ca.Infoway.Messagebuilder.Model.Pcs_cerx_v01_r04_3.Si.Comt_mt400001ca.Role DirectTargetRole {
            get { return this.directTargetRole; }
            set { this.directTargetRole = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"recordTarget/patient"})]
        public Ca.Infoway.Messagebuilder.Model.Pcs_cerx_v01_r04_3.Common.Merged.Patient RecordTargetPatient {
            get { return this.recordTargetPatient; }
            set { this.recordTargetPatient = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"reason/diagnosis"})]
        public Ca.Infoway.Messagebuilder.Model.Pcs_cerx_v01_r04_3.Si.Comt_mt400001ca.Diagnosis ReasonDiagnosis {
            get { return this.reasonDiagnosis; }
            set { this.reasonDiagnosis = value; }
        }

    }

}