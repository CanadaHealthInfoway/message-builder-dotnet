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
 * Last modified: $LastChangedDate: 2012-01-18 21:11:22 -0500 (Wed, 18 Jan 2012) $
 * Revision:      $LastChangedRevision: 4000 $
 */

/* This class was auto-generated by the message builder generator tools. */
namespace Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Pharmacy.Porx_mt050010ca {
    using Ca.Infoway.Messagebuilder.Annotation;
    using Ca.Infoway.Messagebuilder.Datatype;
    using Ca.Infoway.Messagebuilder.Datatype.Impl;
    using Ca.Infoway.Messagebuilder.Domainvalue;
    using Ca.Infoway.Messagebuilder.Model;
    using System.Collections.Generic;


    /**
     * <summary>Generic Query Parameters</summary>
     * 
     * <remarks><p>Defines the set of parameters that may be used 
     * to filter the query response.</p> <p>Root class for query 
     * definition</p></remarks>
     */
    [Hl7PartTypeMappingAttribute(new string[] {"PORX_MT050010CA.ParameterList"})]
    public class GenericQueryParameters : MessagePartBean {

        private IList<CV> drugCodes;

        public GenericQueryParameters() {
            this.drugCodes = new List<CV>();
        }
        /**
         * <summary>Drug Codes</summary>
         * 
         * <remarks><p>Indicates that the result set is to be filtered 
         * to include only those contraindications involving the 
         * specified drugs.</p><p>The codes may refer to administerable 
         * medications, orderable medications or higher level drug 
         * classifications.</p><p>The set of contraindication records 
         * retrieved would include all potential DDI between and 
         * amongst the drugs.</p> <p>Indicates that the result set is 
         * to be filtered to include only those contraindications 
         * involving the specified drugs.</p><p>The codes may refer to 
         * administerable medications, orderable medications or higher 
         * level drug classifications.</p><p>The set of 
         * contraindication records retrieved would include all 
         * potential DDI between and amongst the drugs.</p> 
         * <p>Indicates that the result set is to be filtered to 
         * include only those contraindications involving the specified 
         * drugs.</p><p>The codes may refer to administerable 
         * medications, orderable medications or higher level drug 
         * classifications.</p><p>The set of contraindication records 
         * retrieved would include all potential DDI between and 
         * amongst the drugs.</p> <p>Allows for the retrieval of all 
         * potential contraindications that would result from drug 
         * profile scenarios.</p><p>This will most commonly be used by 
         * providers to test the viability of prescribing/dispensing 
         * medications into profile scenarios.</p> <p>Allows for the 
         * retrieval of all potential contraindications that would 
         * result from drug profile scenarios.</p><p>This will most 
         * commonly be used by providers to test the viability of 
         * prescribing/dispensing medications into profile 
         * scenarios.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"drugCode/value"})]
        public IList<ClinicalDrug> DrugCodes {
            get { return new RawListWrapper<CV, ClinicalDrug>(drugCodes, typeof(CVImpl)); }
        }

    }

}