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
namespace Ca.Infoway.Messagebuilder.Model.Ab_r02_04_03_shr.Common.Rcmr_mt000004ab {
    using Ca.Infoway.Messagebuilder.Annotation;
    using Ca.Infoway.Messagebuilder.Datatype;
    using Ca.Infoway.Messagebuilder.Datatype.Impl;
    using Ca.Infoway.Messagebuilder.Datatype.Lang;
    using Ca.Infoway.Messagebuilder.Model;


    /**
     * <summary>Business Name: Query Definition</summary>
     * 
     * <p>Allows the user and/or the point-of-service application 
     * to constrain what EHR information they wish to retrieve.</p> 
     * <p>Identifies the various parameters that act as filters on 
     * the records to be retrieved.</p>
     */
    [Hl7PartTypeMappingAttribute(new string[] {"RCMR_MT000004AB.ParameterList"})]
    public class QueryDefinition : MessagePartBean {

        private II documentIdValue;
        private II repositoryIDValue;

        public QueryDefinition() {
            this.documentIdValue = new IIImpl();
            this.repositoryIDValue = new IIImpl();
        }
        /**
         * <summary>Business Name: Document ID</summary>
         * 
         * <remarks>Relationship: RCMR_MT000004AB.DocumentId.value 
         * Conformance/Cardinality: MANDATORY (1) <p>Specifically 
         * identifies the Document to be returned.</p><p>Because the 
         * primary purpose of the query is to retrieve identified 
         * documents, the element is mandatory.</p> <p>A globally 
         * unique identifier assigned by the EHR to the Document to be 
         * retrieved.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"documentId/value"})]
        public Identifier DocumentIdValue {
            get { return this.documentIdValue.Value; }
            set { this.documentIdValue.Value = value; }
        }

        /**
         * <summary>Business Name: Repository ID</summary>
         * 
         * <remarks>Relationship: RCMR_MT000004AB.RepositoryID.value 
         * Conformance/Cardinality: MANDATORY (1) <p>Repository Name is 
         * returned as part of the Document List (DocumentEvent) query 
         * response.</p> <p>The identifier of the EHR repository.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"repositoryID/value"})]
        public Identifier RepositoryIDValue {
            get { return this.repositoryIDValue.Value; }
            set { this.repositoryIDValue.Value = value; }
        }

    }

}