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
namespace Ca.Infoway.Messagebuilder.Model.Sk_cerx_v01_r04_3.Common.Quqi_mt120000ca {
    using Ca.Infoway.Messagebuilder.Annotation;
    using Ca.Infoway.Messagebuilder.Datatype;
    using Ca.Infoway.Messagebuilder.Datatype.Impl;
    using Ca.Infoway.Messagebuilder.Datatype.Lang;
    using Ca.Infoway.Messagebuilder.Domainvalue;
    using Ca.Infoway.Messagebuilder.Model;
    using System;


    /**
     * <summary>Query response information</summary>
     * 
     * <remarks><p>Describes the results of a particular query.</p> 
     * <p>Links a query response to the query that invoked it, and 
     * provides information about the overall result-set (which may 
     * not have been completely returned as part of the 
     * response.)</p></remarks>
     */
    [Hl7PartTypeMappingAttribute(new string[] {"QUQI_MT120000CA.QueryAck"})]
    public class QueryResponseInformation : MessagePartBean {

        private II queryId;
        private CS queryResponseCode;
        private INT resultTotalQuantity;
        private INT resultCurrentQuantity;
        private INT resultRemainingQuantity;

        public QueryResponseInformation() {
            this.queryId = new IIImpl();
            this.queryResponseCode = new CSImpl();
            this.resultTotalQuantity = new INTImpl();
            this.resultCurrentQuantity = new INTImpl();
            this.resultRemainingQuantity = new INTImpl();
        }
        /**
         * <summary>M:Query Identifier</summary>
         * 
         * <remarks><p>The identifier of the query this response is 
         * related to.</p> <p>A single query may involve multiple 
         * messages. (Multiple continuations.). This attribute links 
         * all messages related to the same query and is therefore 
         * mandatory.</p> <p>Query Identifier.)&nbsp;</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"queryId"})]
        public Identifier QueryId {
            get { return this.queryId.Value; }
            set { this.queryId.Value = value; }
        }

        /**
         * <summary>N:Query Result Status</summary>
         * 
         * <remarks><p>Indicates the overall result status of the 
         * query.</p> <p>Indicates whether the query was successful and 
         * is therefore mandatory</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"queryResponseCode"})]
        public QueryResponse QueryResponseCode {
            get { return (QueryResponse) this.queryResponseCode.Value; }
            set { this.queryResponseCode.Value = value; }
        }

        /**
         * <summary>O:Query Result-set Size</summary>
         * 
         * <remarks><p>The total number of matching rows found by the 
         * query. (This may differ from the number of rows actually 
         * returned.)</p> <p>Indicates whether additional content 
         * exists that may need to be retrieved by query continuations 
         * and is therefore mandatory</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"resultTotalQuantity"})]
        public int? ResultTotalQuantity {
            get { return this.resultTotalQuantity.Value; }
            set { this.resultTotalQuantity.Value = value; }
        }

        /**
         * <summary>P:Query Items Returned</summary>
         * 
         * <remarks><p>This is how many items are returned in this 
         * query.</p> <p>Provides a quick overview of the number of 
         * items without having to go through and count the data and is 
         * therefore mandatory.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"resultCurrentQuantity"})]
        public int? ResultCurrentQuantity {
            get { return this.resultCurrentQuantity.Value; }
            set { this.resultCurrentQuantity.Value = value; }
        }

        /**
         * <summary>Q:Query Items Remaining</summary>
         * 
         * <remarks><p>The number of item repetitions yet to be 
         * returned in the current response.</p> <p>Provides a means of 
         * evaluating the magnitude of the result and is therefore 
         * mandatory.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"resultRemainingQuantity"})]
        public int? ResultRemainingQuantity {
            get { return this.resultRemainingQuantity.Value; }
            set { this.resultRemainingQuantity.Value = value; }
        }

    }

}