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
namespace Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Iehr.Repc_mt220004ca {
    using Ca.Infoway.Messagebuilder.Annotation;
    using Ca.Infoway.Messagebuilder.Datatype;
    using Ca.Infoway.Messagebuilder.Datatype.Impl;
    using Ca.Infoway.Messagebuilder.Datatype.Lang;
    using Ca.Infoway.Messagebuilder.Domainvalue;
    using Ca.Infoway.Messagebuilder.Model;
    using System;
    using System.Collections.Generic;


    /**
     * <summary>Query Definition</summary>
     * 
     * <remarks><p>Identifies the various parameters that act as 
     * filters on the records to be retrieved.</p> <p>Allows the 
     * user and/or the point-of-service application to constrain 
     * what EHR information they wish to retrieve.</p></remarks>
     */
    [Hl7PartTypeMappingAttribute(new string[] {"REPC_MT220004CA.ParameterList"})]
    public class QueryDefinition : MessagePartBean {

        private TS amendedSinceDateTimeValue;
        private BL attestedIndicatorValue;
        private IList<II> careCompositionIdValue;
        private IList<CV> careCompositionTypeValue;
        private II eHRRepositoryIdValue;
        private IVL<TS, Interval<PlatformDate>> effectiveTimeRangeValue;
        private IList<CV> eventCategoryValue;
        private II eventLocationIdValue;
        private CV eventLocationTypeValue;
        private IList<CD> healthConditionValue;
        private CD indicationValue;
        private BL mostRecentByTypeIndicatorValue;
        private IList<II> protocolIdValue;
        private II recipientLocationIdValue;
        private II recipientProviderIdValue;
        private IList<CS> recordStatusValue;
        private IList<CD> recordTypeValue;
        private II requestIdValue;
        private II requestingProviderIdValue;
        private II responsibleProviderIdValue;
        private CV responsibleProviderTypeValue;

        public QueryDefinition() {
            this.amendedSinceDateTimeValue = new TSImpl();
            this.attestedIndicatorValue = new BLImpl();
            this.careCompositionIdValue = new List<II>();
            this.careCompositionTypeValue = new List<CV>();
            this.eHRRepositoryIdValue = new IIImpl();
            this.effectiveTimeRangeValue = new IVLImpl<TS, Interval<PlatformDate>>();
            this.eventCategoryValue = new List<CV>();
            this.eventLocationIdValue = new IIImpl();
            this.eventLocationTypeValue = new CVImpl();
            this.healthConditionValue = new List<CD>();
            this.indicationValue = new CDImpl();
            this.mostRecentByTypeIndicatorValue = new BLImpl();
            this.protocolIdValue = new List<II>();
            this.recipientLocationIdValue = new IIImpl();
            this.recipientProviderIdValue = new IIImpl();
            this.recordStatusValue = new List<CS>();
            this.recordTypeValue = new List<CD>();
            this.requestIdValue = new IIImpl();
            this.requestingProviderIdValue = new IIImpl();
            this.responsibleProviderIdValue = new IIImpl();
            this.responsibleProviderTypeValue = new CVImpl();
        }
        /**
         * <summary>K: Updated Since DateTime</summary>
         * 
         * <remarks><p>Filters the records retrieved to only include 
         * those which have been created or revised since the specified 
         * date and time. If unspecified, no filter is applied.</p> 
         * <p>Useful to retrieve information &quot;since you last 
         * checked&quot;.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"amendedSinceDateTime/value"})]
        public PlatformDate AmendedSinceDateTimeValue {
            get { return this.amendedSinceDateTimeValue.Value; }
            set { this.amendedSinceDateTimeValue.Value = value; }
        }

        /**
         * <summary>ZM: Attested Indicator</summary>
         * 
         * <remarks><p>If specified, filters the returned documents to 
         * only include those which have been attested as correct by 
         * the document author or which have not been authenticated. If 
         * not specified, both attested and non-attested documents will 
         * be returned. Relevant for transcribed reports (e.g. the data 
         * enterer is different than the 'author'). Records where 
         * &quot;attestation&quot; is marked as &quot;Not 
         * applicable&quot; will be treated as attested.</p> <p>Allows 
         * filtering to only see those documents which are 
         * &quot;known&quot; to be accurate. May also be used to 
         * retrieve documents associated with a provider which are 
         * unauthenticated.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"attestedIndicator/value"})]
        public bool? AttestedIndicatorValue {
            get { return this.attestedIndicatorValue.Value; }
            set { this.attestedIndicatorValue.Value = value; }
        }

        /**
         * <summary>R: Care Composition Ids</summary>
         * 
         * <remarks><p>Filters the records retrieved to only include 
         * those associated with the specified encounter, episode or 
         * care event. If unspecified, no filter is 
         * applied.</p><p>Note: When matching on care composition id, 
         * systems should also retrieve records with a fulfillment id 
         * to requisitions associated with the care composition. E.g. 
         * When retrieving records associated with an encounter which 
         * includes a referral, the retrieved records should also 
         * include the care summary created in fulfillment of the 
         * referral.</p> <p>Filters the records retrieved to only 
         * include those associated with the specified encounter, 
         * episode or care event. If unspecified, no filter is 
         * applied.</p><p>Note: When matching on care composition id, 
         * systems should also retrieve records with a fulfillment id 
         * to requisitions associated with the care composition. E.g. 
         * When retrieving records associated with an encounter which 
         * includes a referral, the retrieved records should also 
         * include the care summary created in fulfillment of the 
         * referral.</p> <p>Allows retrieving all records associated 
         * with an encounter, episode or care event.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"careCompositionId/value"})]
        public IList<Identifier> CareCompositionIdValue {
            get { return new RawListWrapper<II, Identifier>(careCompositionIdValue, typeof(IIImpl)); }
        }

        /**
         * <summary>S: Care Composition Types</summary>
         * 
         * <remarks></p> </p> <p>Allows retrieving all records 
         * associated with a particular type of encounter, episode or 
         * care event. E.g.Orthopedic Clinic Encounter, ER encounter, 
         * Walk-in encounter, etc.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"careCompositionType/value"})]
        public IList<ActCareEventType> CareCompositionTypeValue {
            get { return new RawListWrapper<CV, ActCareEventType>(careCompositionTypeValue, typeof(CVImpl)); }
        }

        /**
         * <summary>Q: EHR Repository Id</summary>
         * 
         * <remarks><p>Filters the records retrieved to only include 
         * those records from a specific EHR repository. If 
         * unspecified, all &quot;connected&quot; EHR repositories will 
         * be searched.</p> <p>Primarily intended to allow filtering an 
         * initial search to a local EHR repository for performance 
         * reasons.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"eHRRepositoryId/value"})]
        public Identifier EHRRepositoryIdValue {
            get { return this.eHRRepositoryIdValue.Value; }
            set { this.eHRRepositoryIdValue.Value = value; }
        }

        /**
         * <summary>J: Effective Time Range</summary>
         * 
         * <remarks><p>Filters the set of records to be retrieved to 
         * those which occurred or were effective for the patient 
         * within the time boundaries specified. Either the lower bound 
         * or upper bound or both would be specified. If no value is 
         * specified, no filter will be applied. If there is any 
         * overlap between the specified time-range and the effective 
         * time of the record, the record will be returned.</p> 
         * <p>Allows constraining the retrieved records to those 
         * applicable at a particular time. Useful in retrieving those 
         * records &quot;currently in effect&quot; as well as 
         * retrieving views of what information was in effect at some 
         * point in the past.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"effectiveTimeRange/value"})]
        public Interval<PlatformDate> EffectiveTimeRangeValue {
            get { return this.effectiveTimeRangeValue.Value; }
            set { this.effectiveTimeRangeValue.Value = value; }
        }

        /**
         * <summary>ZJ: Event Categories</summary>
         * 
         * <remarks><p>If specified, filters the returned records to 
         * those having the specified category. E.g. 
         * &quot;Allergy/Intolerance&quot;, &quot;Measured 
         * Observation&quot;, &quot;Cognitive Procedure&quot;. 
         * (Contrast this with &quot;Type&quot; which would allow 
         * searching for &quot;Drug Allergies&quot;, &quot;Patient 
         * Weight&quot; and &quot;Smoking Cessation 
         * Counseling&quot;.)</p> <p>Allows filtering responses based 
         * on higher level categorization. Multiple repetitions are 
         * supported to allow for multiple categories to be 
         * returned.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"eventCategory/value"})]
        public IList<CareSummaryDocumentType> EventCategoryValue {
            get { return new RawListWrapper<CV, CareSummaryDocumentType>(eventCategoryValue, typeof(CVImpl)); }
        }

        /**
         * <summary>O: Event Location Id</summary>
         * 
         * <remarks><p>Filters the records retrieved to only include 
         * those records which are officially associated with and/or 
         * were performed by a particular facility. I.e. It will return 
         * records where either the &quot;Service Location&quot; or the 
         * &quot;Record Location&quot; has the specified location id. 
         * Records associated with &quot;sub-locations&quot; (e.g. 
         * departments, wards) will be returned when searching by the 
         * larger location (e.g. hospital).</p> <p>Allows retrieving 
         * those records associated with a particular facility.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"eventLocationId/value"})]
        public Identifier EventLocationIdValue {
            get { return this.eventLocationIdValue.Value; }
            set { this.eventLocationIdValue.Value = value; }
        }

        /**
         * <summary>P: Event Location Type</summary>
         * 
         * <remarks></p> </p> <p>Allows retrieving those records 
         * associated with a particular kind of facility. E.g. 
         * Hospital, clinic, pharmacy, patient residence, etc.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"eventLocationType/value"})]
        public ServiceDeliveryLocationRoleType EventLocationTypeValue {
            get { return (ServiceDeliveryLocationRoleType) this.eventLocationTypeValue.Value; }
            set { this.eventLocationTypeValue.Value = value; }
        }

        /**
         * <summary>T: Health Conditions</summary>
         * 
         * <remarks></p> </p> </p> </p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"healthCondition/value"})]
        public IList<ActHealthConditionType> HealthConditionValue {
            get { return new RawListWrapper<CD, ActHealthConditionType>(healthConditionValue, typeof(CDImpl)); }
        }

        /**
         * <summary>U: Indication</summary>
         * 
         * <remarks><p>Filters the records retrieved to only include 
         * those where the &quot;indication&quot; (reason) for the 
         * record was the specified code.</p><p>This is distinct from 
         * the Health Condition query parameter in that it will only 
         * return records with an explicit indication match (it will 
         * not match on discharge diagnosis, part of related episode, 
         * etc.) It also allows searching on indications such as 
         * prophylaxis, surgery prep, etc.</p> <p>Filters the records 
         * retrieved to only include those where the 
         * &quot;indication&quot; (reason) for the record was the 
         * specified code.</p><p>This is distinct from the Health 
         * Condition query parameter in that it will only return 
         * records with an explicit indication match (it will not match 
         * on discharge diagnosis, part of related episode, etc.) It 
         * also allows searching on indications such as prophylaxis, 
         * surgery prep, etc.</p> </p> </p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"indication/value"})]
        public ActIndicationType IndicationValue {
            get { return (ActIndicationType) this.indicationValue.Value; }
            set { this.indicationValue.Value = value; }
        }

        /**
         * <summary>V: Most Recent By Type Indicator</summary>
         * 
         * <remarks><p>If true, indicates that only the most recent 
         * records of a given type or category should be retrieved. 
         * I.e. If there are 10 records of the same kind, only the most 
         * recent one would be returned. If false, all occurrences will 
         * be returned.</p> <p>Provides a mechanism of getting a quick 
         * overview of the types of events that have occurred without 
         * needing to look at all occurrences. The attribute is 
         * mandatory because it must be known whether to return the 
         * most recent or all records.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"mostRecentByTypeIndicator/value"})]
        public bool? MostRecentByTypeIndicatorValue {
            get { return this.mostRecentByTypeIndicatorValue.Value; }
            set { this.mostRecentByTypeIndicatorValue.Value = value; }
        }

        /**
         * <summary>ZI: Protocol Ids</summary>
         * 
         * <remarks><p>Filters the records retrieved to only include 
         * those associated with the specified protocols. If 
         * unspecified, no filter is applied.</p> <p>Allows retrieving 
         * records associated with a particular protocol. Useful in 
         * clinical studies and other research.</p><p>The element is 
         * optional because support for protocols is not deemed a 
         * necessity for many healthcare providers.</p> <p>Allows 
         * retrieving records associated with a particular protocol. 
         * Useful in clinical studies and other research.</p><p>The 
         * element is optional because support for protocols is not 
         * deemed a necessity for many healthcare providers.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"protocolId/value"})]
        public IList<Identifier> ProtocolIdValue {
            get { return new RawListWrapper<II, Identifier>(protocolIdValue, typeof(IIImpl)); }
        }

        /**
         * <summary>ZO: Recipient Location Id</summary>
         * 
         * <remarks><p>If specified, filters the returned documents to 
         * only include those which were targeted to the specified 
         * location. If not specified, no filter is applied</p> 
         * <p>Allows retrieval of all documents sent to a particular 
         * location. E.g. &quot;Find all documents targeted to my 
         * location&quot;</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"recipientLocationId/value"})]
        public Identifier RecipientLocationIdValue {
            get { return this.recipientLocationIdValue.Value; }
            set { this.recipientLocationIdValue.Value = value; }
        }

        /**
         * <summary>ZN: Recipient Provider Id</summary>
         * 
         * <remarks><p>If specified, filters the returned documents to 
         * only include those which were targeted to the specified 
         * provider. If not specified, no filter is applied</p> 
         * <p>Allows retrieval of all documents sent to a particular 
         * provider. E.g. &quot;Find all documents targeted to 
         * me&quot;</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"recipientProviderId/value"})]
        public Identifier RecipientProviderIdValue {
            get { return this.recipientProviderIdValue.Value; }
            set { this.recipientProviderIdValue.Value = value; }
        }

        /**
         * <summary>I: Record Statuses</summary>
         * 
         * <remarks><p>Filters the set of records to be retrieved to 
         * only include those with the identified status(s). If no 
         * values are specified, no filter will be applied.</p> 
         * <p>Allows constraining the status of records to be 
         * retrieved. Multiple repetitions are present to allow 
         * selection of multiple statuses with a single query.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"recordStatus/value"})]
        public IList<ActStatus> RecordStatusValue {
            get { return new RawListWrapper<CS, ActStatus>(recordStatusValue, typeof(CSImpl)); }
        }

        /**
         * <summary>H:Record Types</summary>
         * 
         * <remarks></p> </p> </p> </p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"recordType/value"})]
        public IList<ActCareEventType> RecordTypeValue {
            get { return new RawListWrapper<CD, ActCareEventType>(recordTypeValue, typeof(CDImpl)); }
        }

        /**
         * <summary>ZL: Request Id</summary>
         * 
         * <remarks><p>If specified, filters the returned records to 
         * only include those which are in fulfillment of the specified 
         * request record. If unspecified, no filter is applied.</p> 
         * <p>Allows retrieving records in fulfillment of a particular 
         * request.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"requestId/value"})]
        public Identifier RequestIdValue {
            get { return this.requestIdValue.Value; }
            set { this.requestIdValue.Value = value; }
        }

        /**
         * <summary>N: Requesting Provider Id</summary>
         * 
         * <remarks><p>Filters the records retrieved to only include 
         * those whose creation/performance were requested by the 
         * identified provider. If unspecified, no filter is 
         * applied.</p> <p>Allows a provider to see the results of any 
         * requests they may have made.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"requestingProviderId/value"})]
        public Identifier RequestingProviderIdValue {
            get { return this.requestingProviderIdValue.Value; }
            set { this.requestingProviderIdValue.Value = value; }
        }

        /**
         * <summary>L: Responsible Provider Id</summary>
         * 
         * <remarks><p>Filters the records retrieved to only include 
         * those where the identified provider was the author, 
         * supervisor or performer. If unspecified, no filter is 
         * applied.</p> <p>Allows retrieving those records in which a 
         * particular provider has a vested interest.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"responsibleProviderId/value"})]
        public Identifier ResponsibleProviderIdValue {
            get { return this.responsibleProviderIdValue.Value; }
            set { this.responsibleProviderIdValue.Value = value; }
        }

        /**
         * <summary>M: Responsible Provider Type</summary>
         * 
         * <remarks></p> </p> <p>Allows retrieving those records in 
         * which a particular kind of provider has a vested 
         * interest.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"responsibleProviderType/value"})]
        public HealthcareProviderRoleType ResponsibleProviderTypeValue {
            get { return (HealthcareProviderRoleType) this.responsibleProviderTypeValue.Value; }
            set { this.responsibleProviderTypeValue.Value = value; }
        }

    }

}