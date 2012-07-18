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
namespace Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Iehr.Merged {
    using Ca.Infoway.Messagebuilder;
    using Ca.Infoway.Messagebuilder.Annotation;
    using Ca.Infoway.Messagebuilder.Datatype;
    using Ca.Infoway.Messagebuilder.Datatype.Impl;
    using Ca.Infoway.Messagebuilder.Datatype.Lang;
    using Ca.Infoway.Messagebuilder.Domainvalue;
    using Ca.Infoway.Messagebuilder.Model;
    using System;
    using System.Collections.Generic;


    /**
     * <summary>REPC_MT000016CA.ParameterList: Adverse Reactions 
     * Query Parameters</summary>
     * 
     * <remarks><p>Defines the set of parameters that may be used 
     * to filter the query response.</p> <p>Root class for query 
     * definition</p> REPC_MT000008CA.ParameterList: Query 
     * Definition <p>Identifies the various parameters that act as 
     * filters on the records to be retrieved.</p> <p>Allows the 
     * user and/or the point-of-service application to constrain 
     * what EHR information they wish to retrieve.</p> 
     * REPC_MT500006CA.ParameterList: Query Definition 
     * <p>Identifies the various parameters that act as filters on 
     * the records to be retrieved.</p> <p>Allows the user and/or 
     * the point-of-service application to constrain what EHR 
     * information they wish to retrieve.</p></remarks>
     */
    [Hl7PartTypeMappingAttribute(new string[] {"REPC_MT000008CA.ParameterList","REPC_MT000016CA.ParameterList","REPC_MT500006CA.ParameterList"})]
    public class QueryDefinition : MessagePartBean {

        private IList<II> careCompositionIDValue;
        private IList<CV> careCompositionTypeValue;
        private BL includeNotesIndicatorValue;
        private IVL<TS, Interval<PlatformDate>> reactionPeriodValue;
        private CV reactionTypeValue;
        private TS amendedSinceDateTimeValue;
        private IList<II> careCompositionIdValue;
        private IList<CV> discreteRecordTypesValue;
        private IList<CV> documentRecordTypesValue;
        private II eHRRepositoryIdValue;
        private IVL<TS, Interval<PlatformDate>> effectiveTimeRangeValue;
        private II eventLocationIdValue;
        private CV eventLocationTypeValue;
        private II filterTemplateIdValue;
        private IList<CD> healthConditionValue;
        private CD indicationValue;
        private BL mostRecentByTypeIndicatorValue;
        private IList<II> protocolIdValue;
        private IList<CS> recordStatusValue;
        private IList<CD> recordTypeValue;
        private II requestingProviderIdValue;
        private II responsibleProviderIdValue;
        private CV responsibleProviderTypeValue;
        private BL includeHistoryIndicatorValue;
        private IList<II> recordIdValue;

        public QueryDefinition() {
            this.careCompositionIDValue = new List<II>();
            this.careCompositionTypeValue = new List<CV>();
            this.includeNotesIndicatorValue = new BLImpl();
            this.reactionPeriodValue = new IVLImpl<TS, Interval<PlatformDate>>();
            this.reactionTypeValue = new CVImpl();
            this.amendedSinceDateTimeValue = new TSImpl();
            this.careCompositionIdValue = new List<II>();
            this.discreteRecordTypesValue = new List<CV>();
            this.documentRecordTypesValue = new List<CV>();
            this.eHRRepositoryIdValue = new IIImpl();
            this.effectiveTimeRangeValue = new IVLImpl<TS, Interval<PlatformDate>>();
            this.eventLocationIdValue = new IIImpl();
            this.eventLocationTypeValue = new CVImpl();
            this.filterTemplateIdValue = new IIImpl();
            this.healthConditionValue = new List<CD>();
            this.indicationValue = new CDImpl();
            this.mostRecentByTypeIndicatorValue = new BLImpl();
            this.protocolIdValue = new List<II>();
            this.recordStatusValue = new List<CS>();
            this.recordTypeValue = new List<CD>();
            this.requestingProviderIdValue = new IIImpl();
            this.responsibleProviderIdValue = new IIImpl();
            this.responsibleProviderTypeValue = new CVImpl();
            this.includeHistoryIndicatorValue = new BLImpl();
            this.recordIdValue = new List<II>();
        }
        /**
         * <summary>CareCompositionIDs</summary>
         * 
         * <remarks>Care Composition IDs <p>Filters the records 
         * retrieved to only include those associated with the 
         * specified encounter, episode or care event. If unspecified, 
         * no filter is applied.</p><p>Note: When matching on care 
         * composition id, systems should also retrieve records with a 
         * fulfillment id to requisitions associated with the care 
         * composition. E.g. When retrieving records associated with an 
         * encounter which includes a referral, the retrieved records 
         * should also include the care summary created in fulfillment 
         * of the referral.</p> <p>Filters the records retrieved to 
         * only include those associated with the specified encounter, 
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
        [Hl7XmlMappingAttribute(new string[] {"careCompositionID/value"})]
        public IList<Identifier> CareCompositionIDValue {
            get { return new RawListWrapper<II, Identifier>(careCompositionIDValue, typeof(IIImpl)); }
        }

        /**
         * <summary>CareCompositionTypes</summary>
         * 
         * <remarks>S: Care Composition Types </p> </p> <p>Allows 
         * retrieving all records associated with a particular type of 
         * encounter, episode or care event. E.g. Orthopedic Clinic 
         * Encounter, ER encounter, Walk-in encounter, etc.</p> Care 
         * Composition Types <p>Filters the records retrieved to only 
         * include those associated with the specified 'kind' of 
         * encounter, episode or care event. If unspecified, no filter 
         * is applied.</p> <p>Allows retrieving all records associated 
         * with a particular type of encounter, episode or care event. 
         * E.g.Orthopedic Clinic Encounter, ER encounter, Walk-in 
         * encounter, etc.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"careCompositionType/value"})]
        public IList<ActCareEventType> CareCompositionTypeValue {
            get { return new RawListWrapper<CV, ActCareEventType>(careCompositionTypeValue, typeof(CVImpl)); }
        }

        /**
         * <summary>IncludeNotesIndicator</summary>
         * 
         * <remarks>Include Notes Indicator <p>Indicates whether or not 
         * notes attached to the adverse reactions records are to be 
         * returned along with the detailed information.</p> <p>Allows 
         * for the flexibility of omitting/including notes in the 
         * retrieval of information for adverse reactions 
         * data.</p><p>Because the attribute is boolean, it must 
         * explicitly indicate a 'TRUE' or 'FALSE', and thus it is 
         * mandatory.</p> <p>Allows for the flexibility of 
         * omitting/including notes in the retrieval of information for 
         * adverse reactions data.</p><p>Because the attribute is 
         * boolean, it must explicitly indicate a 'TRUE' or 'FALSE', 
         * and thus it is mandatory.</p> F: Include Notes Indicator 
         * <p>If true, indicates that notes should be included when 
         * retrieving the record(s). If false, notes will not be 
         * returned.</p> <p>Allows filtering whether supplemental 
         * comments should be retrieved or not. Some uses of the record 
         * do not require having the supplemental information 
         * available. The attribute is mandatory because it must be 
         * known whether notes are to be returned or not.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"includeNotesIndicator/value"})]
        public bool? IncludeNotesIndicatorValue {
            get { return this.includeNotesIndicatorValue.Value; }
            set { this.includeNotesIndicatorValue.Value = value; }
        }

        /**
         * <summary>ReactionPeriod</summary>
         * 
         * <remarks>F:Reaction Period <p>The period in which the 
         * recorded adverse reaction occurred or was updated. I.e. 
         * Filters the result-set to those reactions whose onset 
         * occurred within the time-range specified by this 
         * parameter.</p> <p>Allows the requester to specify the 
         * adverse reaction period of interest for retrieval of adverse 
         * reaction records. Useful to avoid run-away queries.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"reactionPeriod/value"})]
        public Interval<PlatformDate> ReactionPeriodValue {
            get { return this.reactionPeriodValue.Value; }
            set { this.reactionPeriodValue.Value = value; }
        }

        /**
         * <summary>ReactionType</summary>
         * 
         * <remarks>G:Reaction Type <p>Indicates that the result set be 
         * filtered to include only those allergy/intolerance records 
         * for which specific type of reaction was 
         * recorded.</p><p>Reaction types include: STEVEN JOHNSON, 
         * ANAPHYLAXIS, NAUSEA, etc</p> <p>Indicates that the result 
         * set be filtered to include only those allergy/intolerance 
         * records for which specific type of reaction was 
         * recorded.</p><p>Reaction types include: STEVEN JOHNSON, 
         * ANAPHYLAXIS, NAUSEA, etc</p> <p>Allows the requester to 
         * retrieve only those allergy/intolerance records for which 
         * there was a specific type of reaction.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"reactionType/value"})]
        public SubjectReaction ReactionTypeValue {
            get { return (SubjectReaction) this.reactionTypeValue.Value; }
            set { this.reactionTypeValue.Value = value; }
        }

        /**
         * <summary>UpdatedSinceDateTime</summary>
         * 
         * <remarks>K: Updated Since DateTime <p>Filters the records 
         * retrieved to only include those which have been created or 
         * revised since the specified date and time. If unspecified, 
         * no filter is applied.</p> <p>Useful to retrieve information 
         * &quot;since you last checked&quot;.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"amendedSinceDateTime/value"})]
        public PlatformDate AmendedSinceDateTimeValue {
            get { return this.amendedSinceDateTimeValue.Value; }
            set { this.amendedSinceDateTimeValue.Value = value; }
        }

        /**
         * <summary>CareCompositionIds</summary>
         * 
         * <remarks>R: Care Composition Ids <p>Filters the records 
         * retrieved to only include those associated with the 
         * specified encounter, episode or care event. If unspecified, 
         * no filter is applied.</p><p>Note: When matching on care 
         * composition id, systems should also retrieve records with a 
         * fulfillment id to requisitions associated with the care 
         * composition. E.g. When retrieving records associated with an 
         * encounter which includes a referral, the retrieved records 
         * should also include the care summary created in fulfillment 
         * of the referral.</p> <p>Filters the records retrieved to 
         * only include those associated with the specified encounter, 
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
         * <summary>DiscreteRecordTypes</summary>
         * 
         * <remarks>X: Discrete Record Types </p> </p> <p>Allows 
         * filtering of the clinical summary to only include types of 
         * information required by the application and/or which it is 
         * capable of supporting.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"discreteRecordTypes/value"})]
        public IList<Code> DiscreteRecordTypesValue {
            get { return new RawListWrapper<CV, Code>(discreteRecordTypesValue, typeof(CVImpl)); }
        }

        /**
         * <summary>DocumentRecordTypes</summary>
         * 
         * <remarks>Y: Document Record Types </p> </p> <p>Allows 
         * returning discrete data rendered into document form for 
         * applications not capable of displaying data retrieved in 
         * discrete form.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"documentRecordTypes/value"})]
        public IList<Code> DocumentRecordTypesValue {
            get { return new RawListWrapper<CV, Code>(documentRecordTypesValue, typeof(CVImpl)); }
        }

        /**
         * <summary>EHRRepositoryId</summary>
         * 
         * <remarks>Q: EHR Repository Id <p>Filters the records 
         * retrieved to only include those records from a specific EHR 
         * repository. If unspecified, all &quot;connected&quot; EHR 
         * repositories will be searched.</p> <p>Primarily intended to 
         * allow filtering an initial search to a local EHR repository 
         * for performance reasons.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"eHRRepositoryId/value"})]
        public Identifier EHRRepositoryIdValue {
            get { return this.eHRRepositoryIdValue.Value; }
            set { this.eHRRepositoryIdValue.Value = value; }
        }

        /**
         * <summary>EffectiveDateRange</summary>
         * 
         * <remarks>J: Effective Date Range <p>Filters the set of 
         * records to be retrieved to those which occurred or were 
         * effective for the patient within the date boundaries 
         * specified. Either the lower bound or upper bound or both 
         * would be specified. If no value is specified, no filter will 
         * be applied. If there is any overlap between the specified 
         * date-range and the effective date of the record, the record 
         * will be returned.</p> <p>Allows constraining the retrieved 
         * records to those applicable on a particular date. Useful in 
         * retrieving those records &quot;currently in effect&quot; as 
         * well as retrieving views of what information was in effect 
         * at some point in the past.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"effectiveTimeRange/value"})]
        public Interval<PlatformDate> EffectiveTimeRangeValue {
            get { return this.effectiveTimeRangeValue.Value; }
            set { this.effectiveTimeRangeValue.Value = value; }
        }

        /**
         * <summary>EventLocationId</summary>
         * 
         * <remarks>O: Event Location Id <p>Filters the records 
         * retrieved to only include those records which are officially 
         * associated with and/or were performed by a particular 
         * facility. I.e. It will return records where either the 
         * &quot;Service Location&quot; or the &quot;Record 
         * Location&quot; has the specified location id. Records 
         * associated with &quot;sub-locations&quot; (e.g. departments, 
         * wards) will be returned when searching by the larger 
         * location (e.g. hospital).</p> <p>Allows retrieving those 
         * records associated with a particular facility.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"eventLocationId/value"})]
        public Identifier EventLocationIdValue {
            get { return this.eventLocationIdValue.Value; }
            set { this.eventLocationIdValue.Value = value; }
        }

        /**
         * <summary>EventLocationType</summary>
         * 
         * <remarks>P: Event Location Type </p> </p> <p>Allows 
         * retrieving those records associated with a particular kind 
         * of facility. E.g. Hospital, clinic, pharmacy, patient 
         * residence, etc.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"eventLocationType/value"})]
        public ServiceDeliveryLocationRoleType EventLocationTypeValue {
            get { return (ServiceDeliveryLocationRoleType) this.eventLocationTypeValue.Value; }
            set { this.eventLocationTypeValue.Value = value; }
        }

        /**
         * <summary>FilterTemplateId</summary>
         * 
         * <remarks>W: Filter Template Id <p>Indicates that the 
         * returned results are to be filtered according to the 
         * specified template. If not specified, no filter is applied. 
         * The specific types of templates available are undefined and 
         * may vary by jurisdiction.</p> <p>Allows the application of 
         * complex filtering rules such as &quot;All information 
         * relevant to diabetes management&quot; or &quot;cardiologist 
         * view of patient record&quot;. The query allows distinct 
         * filters to be applied to different types of records. E.g. 
         * all allergies, only most recent lab tests of a particular 
         * type, drugs of one of 5 types, etc. In some cases, the 
         * template may influence how document views of different 
         * information types are rendered.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"filterTemplateId/value"})]
        public Identifier FilterTemplateIdValue {
            get { return this.filterTemplateIdValue.Value; }
            set { this.filterTemplateIdValue.Value = value; }
        }

        /**
         * <summary>HealthConditions</summary>
         * 
         * <remarks>T: Health Conditions </p> </p> </p> </p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"healthCondition/value"})]
        public IList<ActHealthConditionType> HealthConditionValue {
            get { return new RawListWrapper<CD, ActHealthConditionType>(healthConditionValue, typeof(CDImpl)); }
        }

        /**
         * <summary>Indication</summary>
         * 
         * <remarks>U: Indication <p>Filters the records retrieved to 
         * only include those where the &quot;indication&quot; (reason) 
         * for the record was the specified code.</p><p>This is 
         * distinct from the Health Condition query parameter in that 
         * it will only return records with an explicit indication 
         * match (it will not match on discharge diagnosis, part of 
         * related episode, etc.) It also allows searching on 
         * indications such as prophylaxis, surgery prep, etc.</p> 
         * <p>Filters the records retrieved to only include those where 
         * the &quot;indication&quot; (reason) for the record was the 
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
         * <summary>MostRecentByTypeIndicator</summary>
         * 
         * <remarks>V: Most Recent By Type Indicator <p>If true, 
         * indicates that only the most recent records of a given type 
         * or category should be retrieved. I.e. If there are 10 
         * records of the same kind, only the most recent one would be 
         * returned. If false, all occurrences will be returned.</p> 
         * <p>Provides a mechanism of getting a quick overview of the 
         * types of events that have occurred without needing to look 
         * at all occurrences. The attribute is mandatory because it 
         * must be known whether to return the most recent or all 
         * records.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"mostRecentByTypeIndicator/value"})]
        public bool? MostRecentByTypeIndicatorValue {
            get { return this.mostRecentByTypeIndicatorValue.Value; }
            set { this.mostRecentByTypeIndicatorValue.Value = value; }
        }

        /**
         * <summary>ProtocolIds</summary>
         * 
         * <remarks>ZI: Protocol Ids <p>Filters the records retrieved 
         * to only include those associated with the specified 
         * protocols. If unspecified, no filter is applied.</p> 
         * <p>Allows retrieving records associated with a particular 
         * protocol. Useful in clinical studies and other 
         * research.</p><p>The element is optional because support for 
         * protocols is not deemed a necessity for many healthcare 
         * providers.</p> <p>Allows retrieving records associated with 
         * a particular protocol. Useful in clinical studies and other 
         * research.</p><p>The element is optional because support for 
         * protocols is not deemed a necessity for many healthcare 
         * providers.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"protocolId/value"})]
        public IList<Identifier> ProtocolIdValue {
            get { return new RawListWrapper<II, Identifier>(protocolIdValue, typeof(IIImpl)); }
        }

        /**
         * <summary>RecordStatuses</summary>
         * 
         * <remarks>I: Record Statuses <p>Filters the set of records to 
         * be retrieved to only include those with the identified 
         * status(s). If no values are specified, no filter will be 
         * applied.</p> <p>Allows constraining the status of records to 
         * be retrieved. Multiple repetitions are present to allow 
         * selection of multiple statuses with a single query.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"recordStatus/value"})]
        public IList<ActStatus> RecordStatusValue {
            get { return new RawListWrapper<CS, ActStatus>(recordStatusValue, typeof(CSImpl)); }
        }

        /**
         * <summary>RecordTypes</summary>
         * 
         * <remarks>H:Record Types <p>The following are the valid 
         * concept domains / value-sets for the abstract 
         * CanadianEHRRecordDetailType domain: - 
         * ActCareProvisionRequestType (Referral Types) - 
         * ActCareEventType (Discharge-Care Summary Types; Care 
         * Composition Types) - ClinicalReportObservation Type 
         * (Clinical Report Types) - 
         * SimpleMeasurableClinicalObservationType (Measured 
         * Observation Types) - CommomCodedClinicalObservationType 
         * (Coded Observation Types) - ActProfessionalCode 
         * (Professional Service Types) - Act DiagnosisCode (Health 
         * Condition Types)</p> </p> </p> </p> </p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"recordType/value"})]
        public IList<Code> RecordTypeValue {
            get { return new RawListWrapper<CD, Code>(recordTypeValue, typeof(CDImpl)); }
        }

        /**
         * <summary>RequestingProviderId</summary>
         * 
         * <remarks>N: Requesting Provider Id <p>Filters the records 
         * retrieved to only include those whose creation/performance 
         * were requested by the identified provider. If unspecified, 
         * no filter is applied.</p> <p>Allows a provider to see the 
         * results of any requests they may have made.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"requestingProviderId/value"})]
        public Identifier RequestingProviderIdValue {
            get { return this.requestingProviderIdValue.Value; }
            set { this.requestingProviderIdValue.Value = value; }
        }

        /**
         * <summary>ResponsibleProviderId</summary>
         * 
         * <remarks>L: Responsible Provider Id <p>Filters the records 
         * retrieved to only include those where the identified 
         * provider was the author, supervisor or performer. If 
         * unspecified, no filter is applied.</p> <p>Allows retrieving 
         * those records in which a particular provider has a vested 
         * interest.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"responsibleProviderId/value"})]
        public Identifier ResponsibleProviderIdValue {
            get { return this.responsibleProviderIdValue.Value; }
            set { this.responsibleProviderIdValue.Value = value; }
        }

        /**
         * <summary>ResponsibleProviderType</summary>
         * 
         * <remarks>M: Responsible Provider Type </p> </p> <p>Allows 
         * retrieving those records in which a particular kind of 
         * provider has a vested interest.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"responsibleProviderType/value"})]
        public HealthcareProviderRoleType ResponsibleProviderTypeValue {
            get { return (HealthcareProviderRoleType) this.responsibleProviderTypeValue.Value; }
            set { this.responsibleProviderTypeValue.Value = value; }
        }

        /**
         * <summary>IncludeHistoryIndicator</summary>
         * 
         * <remarks>G: Include History Indicator <p>If true, indicates 
         * that historical versions of the record(s) should be 
         * included. If false, only the current version will be 
         * returned.</p> <p>Allows a user to filter whether historical 
         * information is needed. Retrieving historical information 
         * will be needed in some circumstances, but it makes sense to 
         * constrain. The attribute is mandatory because it must be 
         * known whether history is to be returned or not.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"includeHistoryIndicator/value"})]
        public bool? IncludeHistoryIndicatorValue {
            get { return this.includeHistoryIndicatorValue.Value; }
            set { this.includeHistoryIndicatorValue.Value = value; }
        }

        /**
         * <summary>RecordIds</summary>
         * 
         * <remarks>E: Record Ids <p>A globally unique identifier 
         * assigned by the EHR to the record (or records) to be 
         * retrieved.</p> <p>Specifically identifies the record to be 
         * returned.</p><p>Because the primary purpose of the query is 
         * to retrieve identified records, the element is 
         * mandatory.</p><p>Multiple repetitions are allowed to support 
         * multiple detail records as part of one query for efficiency 
         * reasons.</p> <p>Specifically identifies the record to be 
         * returned.</p><p>Because the primary purpose of the query is 
         * to retrieve identified records, the element is 
         * mandatory.</p><p>Multiple repetitions are allowed to support 
         * multiple detail records as part of one query for efficiency 
         * reasons.</p> <p>Specifically identifies the record to be 
         * returned.</p><p>Because the primary purpose of the query is 
         * to retrieve identified records, the element is 
         * mandatory.</p><p>Multiple repetitions are allowed to support 
         * multiple detail records as part of one query for efficiency 
         * reasons.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"recordId/value"})]
        public IList<Identifier> RecordIdValue {
            get { return new RawListWrapper<II, Identifier>(recordIdValue, typeof(IIImpl)); }
        }

    }

}