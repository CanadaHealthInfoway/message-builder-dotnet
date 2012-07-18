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
 * Last modified: $LastChangedDate: 2012-01-18 21:05:07 -0500 (Wed, 18 Jan 2012) $
 * Revision:      $LastChangedRevision: 3929 $
 */

/* This class was auto-generated by the message builder generator tools. */
namespace Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Common.Merged {
    using Ca.Infoway.Messagebuilder.Annotation;
    using Ca.Infoway.Messagebuilder.Datatype;
    using Ca.Infoway.Messagebuilder.Datatype.Impl;
    using Ca.Infoway.Messagebuilder.Datatype.Lang;
    using Ca.Infoway.Messagebuilder.Domainvalue;
    using Ca.Infoway.Messagebuilder.Model;
    using System;
    using System.Collections.Generic;


    /**
     * <summary>QueryByParameter</summary>
     * 
     * <remarks>MFMI_MT700751CA.QueryByParameter: Query By 
     * Parameter <p>InitialQuantity must only be specified if 
     * InitialQuantityCode is specified.</p> <p>Class which 
     * describes the query specifics and parameter list.</p></remarks>
     */
    [Hl7PartTypeMappingAttribute(new string[] {"MFMI_MT700746CA.QueryByParameter","MFMI_MT700751CA.QueryByParameter","QUQI_MT020000CA.QueryByParameter","QUQI_MT020002CA.QueryByParameter","QUQI_MT120006CA.QueryByParameter","QUQI_MT120008CA.QueryByParameter"})]
    public class QueryByParameter<PL> : MessagePartBean {

        private II queryIdentifier;
        private CS expeditedQueryIndicator;
        private INT queryLimit;
        private CV queryLimitType;
        private PL parameterList;
        private IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Common.Merged.SortControl> sortControl;

        public QueryByParameter() {
            this.queryIdentifier = new IIImpl();
            this.expeditedQueryIndicator = new CSImpl();
            this.queryLimit = new INTImpl();
            this.queryLimitType = new CVImpl();
            this.sortControl = new List<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Common.Merged.SortControl>();
        }
        /**
         * <summary>QueryIdentifier</summary>
         * 
         * <remarks>H:Query Identifier <p>Unique number for this 
         * particular query.</p> <p>Needed to allow continuation of 
         * queries and linking of query requests and responses and 
         * therefore mandatory.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"queryId"})]
        public Identifier QueryIdentifier {
            get { return this.queryIdentifier.Value; }
            set { this.queryIdentifier.Value = value; }
        }

        /**
         * <summary>ExpeditedQueryIndicator</summary>
         * 
         * <remarks>K: Expedited Query Indicator <p>This allows the 
         * sender to indicate to the receiver that this query should 
         * follow an expedited processing flow.</p> <p>Intended to 
         * convey the requested 'packaging' of query results. This 
         * attribute does not affect which rows are selected by the 
         * query, just the manner in which they are returned. For 
         * example, a batch file containing responses, a response 
         * message containing multiple payloads, or a stream of 
         * response messages (notifications) each identifying itself as 
         * a response to a query request.</p> K: Expedited Query 
         * Indicator <p>This allows the sender to indicate to the 
         * receiver that this query should follow an expedited 
         * processing flow.</p> <p>Intended to convey the 'packaging' 
         * of query results. This attribute does not affect which rows 
         * are selected by the query, just the manner in which they are 
         * returned. For example, a batch file containing responses, a 
         * response message containing multiple payloads, or a stream 
         * of response messages (notifications) each identifying itself 
         * as a response to a query request.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"responseModalityCode"})]
        public ResponseModality ExpeditedQueryIndicator {
            get { return (ResponseModality) this.expeditedQueryIndicator.Value; }
            set { this.expeditedQueryIndicator.Value = value; }
        }

        /**
         * <summary>QueryLimit</summary>
         * 
         * <remarks>I:Query Limit <p>The number of response item 
         * repetitions that should be included in the initial 
         * response.</p> <p>There may be a very large number of 
         * matching rows. To manage communication bandwidth, a limited 
         * set may initially be returned with further data retrieved by 
         * using query continuations.</p> I:Query Limit <p>The number 
         * of response item repetitions that should be included in the 
         * initial response.</p> <p>There may be a very large number of 
         * matching rows. To manage communication bandwidth, a limited 
         * set may initially be returned with further data retrieved by 
         * using query continuations.</p> <p>If not specified, the 
         * default behavior is to return all repetitions. However the 
         * recipient of a query may always choose to limit the quantity 
         * returned to be less than the number requested. Regardless of 
         * the number specified here, the number of rows returned will 
         * never exceed the number of matching rows based on the query 
         * parameters.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"initialQuantity"})]
        public int? QueryLimit {
            get { return this.queryLimit.Value; }
            set { this.queryLimit.Value = value; }
        }

        /**
         * <summary>QueryLimitType</summary>
         * 
         * <remarks>J:Query Limit Type <p>Defines the units associated 
         * with the magnitude of the maximum size limit of a query 
         * response that can be accepted by the requesting 
         * application.</p> <p>Needed to quantify the types of records 
         * requested to be returned in the query.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"initialQuantityCode"})]
        public QueryRequestLimit QueryLimitType {
            get { return (QueryRequestLimit) this.queryLimitType.Value; }
            set { this.queryLimitType.Value = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"parameterList"})]
        public PL ParameterList {
            get { return this.parameterList; }
            set { this.parameterList = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"sortControl"})]
        public IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Common.Merged.SortControl> SortControl {
            get { return this.sortControl; }
        }

    }

}