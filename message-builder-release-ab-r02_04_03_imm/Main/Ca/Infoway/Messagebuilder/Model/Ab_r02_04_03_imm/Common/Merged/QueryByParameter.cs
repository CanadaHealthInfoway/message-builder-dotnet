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
namespace Ca.Infoway.Messagebuilder.Model.Ab_r02_04_03_imm.Common.Merged {
    using Ca.Infoway.Messagebuilder.Annotation;
    using Ca.Infoway.Messagebuilder.Datatype;
    using Ca.Infoway.Messagebuilder.Datatype.Impl;
    using Ca.Infoway.Messagebuilder.Datatype.Lang;
    using Ca.Infoway.Messagebuilder.Domainvalue;
    using Ca.Infoway.Messagebuilder.Model;


    [Hl7PartTypeMappingAttribute(new string[] {"QUQI_MT020000AB.QueryByParameter","QUQI_MT020002AB.QueryByParameter","QUQI_MT120006AB.QueryByParameter","QUQI_MT120008AB.QueryByParameter"})]
    public class QueryByParameter<PL> : MessagePartBean {

        private II queryId;
        private CS responseModalityCode;
        private PL parameterList;

        public QueryByParameter() {
            this.queryId = new IIImpl();
            this.responseModalityCode = new CSImpl();
        }
        /**
         * <summary>Business Name: QueryIdentifier</summary>
         * 
         * <remarks>Un-merged Business Name: QueryIdentifier 
         * Relationship: QUQI_MT020002AB.QueryByParameter.queryId 
         * Conformance/Cardinality: MANDATORY (1) <p>Needed to allow 
         * continuation of queries and linking of query requests and 
         * responses and therefore mandatory.</p> <p>Unique number for 
         * this particular query.</p> Un-merged Business Name: 
         * QueryIdentifier Relationship: 
         * QUQI_MT120008AB.QueryByParameter.queryId 
         * Conformance/Cardinality: MANDATORY (1) <p>Needed to allow 
         * continuation of queries and linking of query requests and 
         * responses and therefore mandatory.</p> <p>Unique number for 
         * this particular query.</p> Un-merged Business Name: 
         * QueryIdentifier Relationship: 
         * QUQI_MT120006AB.QueryByParameter.queryId 
         * Conformance/Cardinality: MANDATORY (1) <p>Needed to allow 
         * continuation of queries and linking of query requests and 
         * responses and therefore mandatory.</p> <p>Unique number for 
         * this particular query.</p> Un-merged Business Name: 
         * QueryIdentifier Relationship: 
         * QUQI_MT020000AB.QueryByParameter.queryId 
         * Conformance/Cardinality: MANDATORY (1) <p>Needed to allow 
         * continuation of queries and linking of query requests and 
         * responses and therefore mandatory.</p> <p>Unique number for 
         * this particular query.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"queryId"})]
        public Identifier QueryId {
            get { return this.queryId.Value; }
            set { this.queryId.Value = value; }
        }

        /**
         * <summary>Business Name: ExpeditedQueryIndicator</summary>
         * 
         * <remarks>Un-merged Business Name: ExpeditedQueryIndicator 
         * Relationship: 
         * QUQI_MT020002AB.QueryByParameter.responseModalityCode 
         * Conformance/Cardinality: REQUIRED (0-1) <p>Intended to 
         * convey the 'packaging' of query results. This attribute does 
         * not affect which rows are selected by the query, just the 
         * manner in which they are returned. For example, a batch file 
         * containing responses, a response message containing multiple 
         * payloads, or a stream of response messages (notifications) 
         * each identifying itself as a response to a query 
         * request.</p> <p>This allows the sender to indicate to the 
         * receiver that this query should follow an expedited 
         * processing flow.</p> Un-merged Business Name: 
         * ExpeditedQueryIndicator Relationship: 
         * QUQI_MT120008AB.QueryByParameter.responseModalityCode 
         * Conformance/Cardinality: REQUIRED (0-1) <p>Intended to 
         * convey the 'packaging' of query results. This attribute does 
         * not affect which rows are selected by the query, just the 
         * manner in which they are returned. For example, a batch file 
         * containing responses, a response message containing multiple 
         * payloads, or a stream of response messages (notifications) 
         * each identifying itself as a response to a query 
         * request.</p> <p>This allows the sender to indicate to the 
         * receiver that this query should follow an expedited 
         * processing flow.</p> Un-merged Business Name: 
         * ExpeditedQueryIndicator Relationship: 
         * QUQI_MT120006AB.QueryByParameter.responseModalityCode 
         * Conformance/Cardinality: REQUIRED (0-1) <p>Intended to 
         * convey the 'packaging' of query results. This attribute does 
         * not affect which rows are selected by the query, just the 
         * manner in which they are returned. For example, a batch file 
         * containing responses, a response message containing multiple 
         * payloads, or a stream of response messages (notifications) 
         * each identifying itself as a response to a query 
         * request.</p> <p>This allows the sender to indicate to the 
         * receiver that this query should follow an expedited 
         * processing flow.</p> Un-merged Business Name: 
         * ExpeditedQueryIndicator Relationship: 
         * QUQI_MT020000AB.QueryByParameter.responseModalityCode 
         * Conformance/Cardinality: REQUIRED (0-1) <p>Intended to 
         * convey the requested 'packaging' of query results. This 
         * attribute does not affect which rows are selected by the 
         * query, just the manner in which they are returned. For 
         * example, a batch file containing responses, a response 
         * message containing multiple payloads, or a stream of 
         * response messages (notifications) each identifying itself as 
         * a response to a query request.</p> <p>This allows the sender 
         * to indicate to the receiver that this query should follow an 
         * expedited processing flow.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"responseModalityCode"})]
        public ResponseModality ResponseModalityCode {
            get { return (ResponseModality) this.responseModalityCode.Value; }
            set { this.responseModalityCode.Value = value; }
        }

        /**
         * <summary>Un-merged Business Name: (no business name 
         * specified)</summary>
         * 
         * <remarks>Relationship: 
         * QUQI_MT020002AB.QueryByParameter.parameterList 
         * Conformance/Cardinality: MANDATORY (1) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * QUQI_MT120008AB.QueryByParameter.parameterList 
         * Conformance/Cardinality: MANDATORY (1) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * QUQI_MT120006AB.QueryByParameter.parameterList 
         * Conformance/Cardinality: MANDATORY (1) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * QUQI_MT020000AB.QueryByParameter.parameterList 
         * Conformance/Cardinality: MANDATORY (1)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"parameterList"})]
        public PL ParameterList {
            get { return this.parameterList; }
            set { this.parameterList = value; }
        }

    }

}