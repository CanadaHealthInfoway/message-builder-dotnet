/* This class was auto-generated by the message builder generator tools. */
namespace Ca.Infoway.Messagebuilder.Model.Ab_r02_04_03_shr.Common.Quqi_mt120006ab {
    using Ca.Infoway.Messagebuilder.Annotation;
    using Ca.Infoway.Messagebuilder.Datatype;
    using Ca.Infoway.Messagebuilder.Datatype.Impl;
    using Ca.Infoway.Messagebuilder.Datatype.Lang;
    using Ca.Infoway.Messagebuilder.Domainvalue;
    using Ca.Infoway.Messagebuilder.Model;
    using System;


    [Hl7PartTypeMappingAttribute(new string[] {"QUQI_MT120006AB.QueryAck"})]
    public class QueryAck : MessagePartBean {

        private II queryId;
        private CS queryResponseCode;
        private INT resultTotalQuantity;
        private INT resultCurrentQuantity;
        private INT resultRemainingQuantity;

        public QueryAck() {
            this.queryId = new IIImpl();
            this.queryResponseCode = new CSImpl();
            this.resultTotalQuantity = new INTImpl();
            this.resultCurrentQuantity = new INTImpl();
            this.resultRemainingQuantity = new INTImpl();
        }
        /**
         * <summary>Business Name: H:Query Identifier</summary>
         * 
         * <remarks>Relationship: QUQI_MT120006AB.QueryAck.queryId 
         * Conformance/Cardinality: MANDATORY (1) <p>Allows linking of 
         * a response back to the request that triggered it and is 
         * therefore mandatory. Particularly useful when responses are 
         * deferred or queued.</p> <p>Identifies the query being 
         * acknowledged</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"queryId"})]
        public Identifier QueryId {
            get { return this.queryId.Value; }
            set { this.queryId.Value = value; }
        }

        /**
         * <summary>Business Name: I:Query Status</summary>
         * 
         * <remarks>Relationship: 
         * QUQI_MT120006AB.QueryAck.queryResponseCode 
         * Conformance/Cardinality: MANDATORY (1) <p>Used to control 
         * receiver logic and is therefore mandatory.</p> <p>Indicates 
         * whether the query was successful or not.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"queryResponseCode"})]
        public QueryResponse QueryResponseCode {
            get { return (QueryResponse) this.queryResponseCode.Value; }
            set { this.queryResponseCode.Value = value; }
        }

        /**
         * <summary>Business Name: J:Total Matching Rows</summary>
         * 
         * <remarks>Relationship: 
         * QUQI_MT120006AB.QueryAck.resultTotalQuantity 
         * Conformance/Cardinality: MANDATORY (1) <p>Indicates the 
         * overall size of the result-set and is therefore mandatory. 
         * Particularly useful when only part of the result set is 
         * actually returned.</p> <p>Identifies the total number of 
         * rows identified that matched the query.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"resultTotalQuantity"})]
        public int? ResultTotalQuantity {
            get { return this.resultTotalQuantity.Value; }
            set { this.resultTotalQuantity.Value = value; }
        }

        /**
         * <summary>Business Name: K:Returned Rows</summary>
         * 
         * <remarks>Relationship: 
         * QUQI_MT120006AB.QueryAck.resultCurrentQuantity 
         * Conformance/Cardinality: MANDATORY (1) <p>Provides a quick 
         * overview of the results of the query and is therefore 
         * mandatory.</p> <p>Identifies the number of rows returned as 
         * part of this particular query response.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"resultCurrentQuantity"})]
        public int? ResultCurrentQuantity {
            get { return this.resultCurrentQuantity.Value; }
            set { this.resultCurrentQuantity.Value = value; }
        }

        /**
         * <summary>Business Name: L:Remaining Rows</summary>
         * 
         * <remarks>Relationship: 
         * QUQI_MT120006AB.QueryAck.resultRemainingQuantity 
         * Conformance/Cardinality: MANDATORY (1) <p>Identifies how 
         * much data remains to be queried and is therefore 
         * mandatory.</p> <p>Indicates the number of rows that still 
         * exist after the last row returned in this response.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"resultRemainingQuantity"})]
        public int? ResultRemainingQuantity {
            get { return this.resultRemainingQuantity.Value; }
            set { this.resultRemainingQuantity.Value = value; }
        }

    }

}