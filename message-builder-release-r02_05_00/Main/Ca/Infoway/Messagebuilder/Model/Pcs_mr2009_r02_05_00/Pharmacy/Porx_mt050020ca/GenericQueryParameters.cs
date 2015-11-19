/**
 * Copyright 2015 Canada Health Infoway, Inc.
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
 * Last modified: $LastChangedDate: 2011-05-04 15:47:15 -0400 (Wed, 04 May 2011) $
 * Revision:      $LastChangedRevision: 2623 $
 */
/* This class was auto-generated by the message builder generator tools. */
namespace Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_05_00.Pharmacy.Porx_mt050020ca {
    using Ca.Infoway.Messagebuilder.Annotation;
    using Ca.Infoway.Messagebuilder.Datatype;
    using Ca.Infoway.Messagebuilder.Datatype.Impl;
    using Ca.Infoway.Messagebuilder.Domainvalue;
    using Ca.Infoway.Messagebuilder.Model;


    /**
     * <summary>Business Name: Generic Query Parameters</summary>
     * 
     * <p>Root class for query definition</p> <p>Defines the set of 
     * parameters that may be used to filter the query 
     * response.</p>
     */
    [Hl7PartTypeMappingAttribute(new string[] {"PORX_MT050020CA.ParameterList"})]
    public class GenericQueryParameters : MessagePartBean {

        private CV drugCodeValue;

        public GenericQueryParameters() {
            this.drugCodeValue = new CVImpl();
        }
        /**
         * <summary>Business Name: E:Drug Code</summary>
         * 
         * <remarks>Relationship: PORX_MT050020CA.DrugCode.value 
         * Conformance/Cardinality: MANDATORY (1) <p>Allows for the 
         * retrieval of all potential contraindications based on a 
         * specific medication being introduced onto the patient's 
         * medication profile. Contraindications can't be found without 
         * specifying the medication, therefore this attribute is 
         * mandatory.</p><p>This will most commonly be used by 
         * providers to test the viability of prescribing/dispensing a 
         * medication to a patient (in view of the patient's existing 
         * medication profile).</p> <p>Indicates that the result set is 
         * to be filtered to include only those contraindications 
         * pertaining to the specified drug.</p><p>The code may refer 
         * to an administerable medication, an orderable medication or 
         * a higher level drug classification.</p><p>The 
         * contraindication records retrieve would comprise the 
         * drug-drug interactions between this specified and each of 
         * the drugs on the patient's profile, as well as drug-disease 
         * and drug-allergy contraindications that might result (based 
         * on the information on the patient's profile).</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"drugCode/value"})]
        public ClinicalDrug DrugCodeValue {
            get { return (ClinicalDrug) this.drugCodeValue.Value; }
            set { this.drugCodeValue.Value = value; }
        }

    }

}