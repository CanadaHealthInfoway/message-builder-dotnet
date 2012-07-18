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
namespace Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Iehr.Merged {
    using Ca.Infoway.Messagebuilder;
    using Ca.Infoway.Messagebuilder.Annotation;
    using Ca.Infoway.Messagebuilder.Datatype;
    using Ca.Infoway.Messagebuilder.Datatype.Impl;
    using Ca.Infoway.Messagebuilder.Domainvalue;
    using Ca.Infoway.Messagebuilder.Model;


    /**
     * <summary>DischargeDiagnoses</summary>
     * 
     * <remarks>REPC_MT220002CA.ConditionEvent: Discharge Diagnoses 
     * <p>Describes one of the conditions associated with the 
     * patient as part of the encounter.</p> <p>Commonly used for 
     * reporting, but also useful for searching and for obtaining a 
     * general understanding of the encounter.</p> 
     * REPC_MT220001CA.ConditionEvent: Discharge Diagnoses 
     * <p>Describes one of the conditions associated with the 
     * patient as part of the encounter.</p> <p>Commonly used for 
     * reporting, but also useful for searching and for obtaining a 
     * general understanding of the encounter.</p> 
     * REPC_MT220003CA.ConditionEvent: Discharge Diagnoses 
     * <p>Describes one of the conditions associated with the 
     * patient as part of the encounter.</p> <p>Commonly used for 
     * reporting, but also useful for searching and for obtaining a 
     * general understanding of the encounter.</p></remarks>
     */
    [Hl7PartTypeMappingAttribute(new string[] {"REPC_MT220001CA.ConditionEvent","REPC_MT220002CA.ConditionEvent","REPC_MT220003CA.ConditionEvent"})]
    public class DischargeDiagnoses : MessagePartBean {

        private CD code;
        private CV value;

        public DischargeDiagnoses() {
            this.code = new CDImpl();
            this.value = new CVImpl();
        }
        /**
         * <summary>DischargeDiagnosisType</summary>
         * 
         * <remarks>A: Discharge Diagnosis Type <p>Code is fixed to DX 
         * if not using SNOMED</p> <p>Identifications of the type of 
         * diagnosis at the time of discharge.</p> </p> </p> <p>For 
         * SNOMED, the complete diagnosis appears here. For non-SNOMED 
         * this should be a fixed value of &quot;DX&quot;.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"code"})]
        public Code Code {
            get { return (Code) this.code.Value; }
            set { this.code.Value = value; }
        }

        /**
         * <summary>DiagnosisCode</summary>
         * 
         * <remarks>B:Diagnosis Code <p>Identifies the actual discharge 
         * diagnosis.</p> </p> </p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"value"})]
        public DiagnosisValue Value {
            get { return (DiagnosisValue) this.value.Value; }
            set { this.value.Value = value; }
        }

    }

}