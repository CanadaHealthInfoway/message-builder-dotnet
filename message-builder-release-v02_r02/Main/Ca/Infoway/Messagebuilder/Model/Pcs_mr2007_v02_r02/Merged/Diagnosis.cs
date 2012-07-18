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
namespace Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r02.Merged {
    using Ca.Infoway.Messagebuilder.Annotation;
    using Ca.Infoway.Messagebuilder.Datatype;
    using Ca.Infoway.Messagebuilder.Datatype.Impl;
    using Ca.Infoway.Messagebuilder.Domainvalue;
    using Ca.Infoway.Messagebuilder.Model;
    using System;


    /**
     * <summary>Diagnosis</summary>
     * 
     * <remarks>COCT_MT290000CA.Diagnosis: Diagnosis 
     * <p>Diagnosis</p> <p>More than 1 diagnosis may be specified 
     * to justify the performing of a particular service.</p><p>A 
     * specific diagnosis code must always be specified, and may be 
     * supplemented by descriptive text.</p><p>For some services 
     * (e.g. provider's review of a file), the diagnosis may not be 
     * known.</p> <p>More than 1 diagnosis may be specified to 
     * justify the performing of a particular service.</p><p>A 
     * specific diagnosis code must always be specified, and may be 
     * supplemented by descriptive text.</p><p>For some services 
     * (e.g. provider's review of a file), the diagnosis may not be 
     * known.</p> <p>More than 1 diagnosis may be specified to 
     * justify the performing of a particular service.</p><p>A 
     * specific diagnosis code must always be specified, and may be 
     * supplemented by descriptive text.</p><p>For some services 
     * (e.g. provider's review of a file), the diagnosis may not be 
     * known.</p> COCT_MT490000CA.Diagnosis: Diagnosis <p>Patient 
     * Diagnosis</p> COMT_MT400001CA.Diagnosis: Diagnosis <p>If 
     * code is SNOMED, value must not be specified. Otherwise value 
     * is mandatory and code must be DX</p> <p>Conveys information 
     * about a diagnosis to be masked</p> <p>Allows masking of 
     * items related to a particular medical condition.</p></remarks>
     */
    [Hl7PartTypeMappingAttribute(new string[] {"COCT_MT290000CA.Diagnosis","COCT_MT490000CA.Diagnosis","COMT_MT400001CA.Diagnosis"})]
    public class Diagnosis : MessagePartBean {

        private CV code;
        private ST text;
        private CV value;

        public Diagnosis() {
            this.code = new CVImpl();
            this.text = new STImpl();
            this.value = new CVImpl();
        }
        /**
         * <summary>A:Diagnosis Type</summary>
         * 
         * <remarks><p>Used to indicate that this observation is a 
         * diagnosis, and for SNOMED, provides details of what the 
         * diagnosis is.</p> <p>Needed to convey the diagnosis 
         * information to be masked, and attribute is therefore 
         * mandatory.</p> Diagnosis type <p>admit, intermediate, 
         * discharge diagnosis</p> Diagnosis Code 
         * <p>ObservationDiagnosis Type</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"code"})]
        public ActCode Code {
            get { return (ActCode) this.code.Value; }
            set { this.code.Value = value; }
        }

        /**
         * <summary>DiagnosisDescription</summary>
         * 
         * <remarks>Diagnosis Description <p>Can be used to supplement 
         * a diagnostic code</p> <p>Can be used to supplement a 
         * diagnostic code</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"text"})]
        public String Text {
            get { return this.text.Value; }
            set { this.text.Value = value; }
        }

        /**
         * <summary>Diagnosis Value</summary>
         * 
         * <remarks><p>coded Value denoting diagnosis</p> B:Diagnosis 
         * <p>The diagnosis whose associated records should be 
         * masked.</p> <p>Allows masking of all records (prescriptions, 
         * dispenses, encounters, lab tests, etc.) associated with the 
         * specified diagnosis. This element is optional because it is 
         * not used for SNOMED.</p> Diagnosis Value <p>Diagnosis Code 
         * eg. ICD-10-CA code.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"value"})]
        public DiagnosisValue Value {
            get { return (DiagnosisValue) this.value.Value; }
            set { this.value.Value = value; }
        }

    }

}