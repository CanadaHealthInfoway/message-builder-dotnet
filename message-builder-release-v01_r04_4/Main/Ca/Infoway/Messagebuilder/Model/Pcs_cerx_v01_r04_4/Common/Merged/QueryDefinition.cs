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
namespace Ca.Infoway.Messagebuilder.Model.Pcs_cerx_v01_r04_4.Common.Merged {
    using Ca.Infoway.Messagebuilder.Annotation;
    using Ca.Infoway.Messagebuilder.Datatype;
    using Ca.Infoway.Messagebuilder.Datatype.Impl;
    using Ca.Infoway.Messagebuilder.Datatype.Lang;
    using Ca.Infoway.Messagebuilder.Model;
    using System;


    /**
     * <summary>Business Name: QueryDefinition</summary>
     * 
     * <remarks>QUQI_MT020000CA.QueryByParameter: Query definition 
     * <p>initialQuantityCode must be populated if and only if 
     * initialQuantity is populated</p> <p>Provides support for 
     * queries</p> <p>Identifies the content desired within a 
     * query.</p> QUQI_MT120000CA.QueryByParameter: Query 
     * definition <p>initialQuantityCode must be populated if and 
     * only if initialQuantity is populated</p> <p>Provides support 
     * for queries</p> <p>Identifies the content desired within a 
     * query.</p></remarks>
     */
    [Hl7PartTypeMappingAttribute(new string[] {"QUQI_MT020000CA.QueryByParameter","QUQI_MT120000CA.QueryByParameter"})]
    public class QueryDefinition<PL> : MessagePartBean {

        private II queryId;
        private INT initialQuantity;
        private PL parameterList;

        public QueryDefinition() {
            this.queryId = new IIImpl();
            this.initialQuantity = new INTImpl();
        }
        /**
         * <summary>Business Name: QueryIdentifier</summary>
         * 
         * <remarks>Un-merged Business Name: QueryIdentifier 
         * Relationship: QUQI_MT020000CA.QueryByParameter.queryId 
         * Conformance/Cardinality: MANDATORY (1) <p>Needed to allow 
         * continuation of queries and linking of query requests and 
         * responses and therefore mandatory.</p> <p>Unique number for 
         * this particular query.</p> Un-merged Business Name: 
         * QueryIdentifier Relationship: 
         * QUQI_MT120000CA.QueryByParameter.queryId 
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
         * <summary>Business Name: QueryLimit</summary>
         * 
         * <remarks>Un-merged Business Name: QueryLimit Relationship: 
         * QUQI_MT020000CA.QueryByParameter.initialQuantity 
         * Conformance/Cardinality: REQUIRED (0-1) <p>There may be a 
         * very large number of matching rows. To manage communication 
         * bandwidth, a limited set may initially be returned with 
         * further data retrieved by using query continuations.</p> 
         * <p>If not specified, the default behavior is to return all 
         * repetitions. However the recipient of a query may always 
         * choose to limit the quantity returned to be less than the 
         * number requested. Regardless of the number specified here, 
         * the number of rows returned will never exceed the number of 
         * matching rows based on the query parameters.</p> <p>The 
         * number of response item repetitions that should be included 
         * in the initial response.</p> Un-merged Business Name: 
         * QueryLimit Relationship: 
         * QUQI_MT120000CA.QueryByParameter.initialQuantity 
         * Conformance/Cardinality: REQUIRED (0-1) <p>There may be a 
         * very large number of matching rows. To manage communication 
         * bandwidth, a limited set may initially be returned with 
         * further data retrieved by using query continuations. If not 
         * specified, the default behavior is to return all 
         * repetitions. However the recipient of a query may always 
         * choose to limit the quantity returned to be less than the 
         * number requested.</p> <p>The number of response item 
         * repetitions that should be included in the initial 
         * response.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"initialQuantity"})]
        public int? InitialQuantity {
            get { return this.initialQuantity.Value; }
            set { this.initialQuantity.Value = value; }
        }

        /**
         * <summary>Un-merged Business Name: (no business name 
         * specified)</summary>
         * 
         * <remarks>Relationship: 
         * QUQI_MT020000CA.QueryByParameter.parameterList 
         * Conformance/Cardinality: MANDATORY (1) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * QUQI_MT120000CA.QueryByParameter.parameterList 
         * Conformance/Cardinality: MANDATORY (1)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"parameterList"})]
        public PL ParameterList {
            get { return this.parameterList; }
            set { this.parameterList = value; }
        }

    }

}