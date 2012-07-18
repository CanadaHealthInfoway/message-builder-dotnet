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
 * Last modified: $LastChangedDate: 2012-01-18 21:08:39 -0500 (Wed, 18 Jan 2012) $
 * Revision:      $LastChangedRevision: 3976 $
 */

/* This class was auto-generated by the message builder generator tools. */
namespace Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Lab.Merged {
    using Ca.Infoway.Messagebuilder.Annotation;
    using Ca.Infoway.Messagebuilder.Datatype;
    using Ca.Infoway.Messagebuilder.Datatype.Impl;
    using Ca.Infoway.Messagebuilder.Model;
    using System;


    /**
     * <summary>ResultSortKey</summary>
     * 
     * <remarks>POLB_MT004000CA.ResultSortKey: Result Sort Key 
     * <p>String used for sorting of results.</p> <p>OLIS needs an 
     * alphanumeric sort key string to a test result to allow a 
     * laboratory to provide sorting information for test 
     * results.</p> POLB_MT004200CA.ResultSortKey: Result Sort Key 
     * <p>This must not be linked at ObservationReport level.</p> 
     * <p>String used for sorting of results.</p> <p>OLIS needs an 
     * alphanumeric sort key string to a test result to allow a 
     * laboratory to provide sorting information for test 
     * results.</p></remarks>
     */
    [Hl7PartTypeMappingAttribute(new string[] {"POLB_MT004000CA.ResultSortKey","POLB_MT004100CA.ResultSortKey","POLB_MT004200CA.ResultSortKey"})]
    public class ResultSortKey : MessagePartBean {

        private ST sortKeyText;

        public ResultSortKey() {
            this.sortKeyText = new STImpl();
        }
        /**
         * <summary>SortKeyText</summary>
         * 
         * <remarks>Sort Key Text Sort Key Text <p>Value used for 
         * sorting results.</p> <p>Attribute for communicating the 
         * actual sort key value.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"text"})]
        public String SortKeyText {
            get { return this.sortKeyText.Value; }
            set { this.sortKeyText.Value = value; }
        }

    }

}