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
 * Last modified: $LastChangedDate: 2012-02-16 11:08:07 -0500 (Thu, 16 Feb 2012) $
 * Revision:      $LastChangedRevision: 5492 $
 */
/* This class was auto-generated by the message builder generator tools. */
namespace Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r01.Pharmacy.Porx_mt060220ca {
    using Ca.Infoway.Messagebuilder.Annotation;
    using Ca.Infoway.Messagebuilder.Datatype;
    using Ca.Infoway.Messagebuilder.Datatype.Impl;
    using Ca.Infoway.Messagebuilder.Datatype.Lang;
    using Ca.Infoway.Messagebuilder.Domainvalue;
    using Ca.Infoway.Messagebuilder.Model;
    using System;
    using System.Collections.Generic;


    /**
     * <summary><p>Defines the set of parameters that may be used 
     * to filter the query response.</p></summary>
     * 
     * <remarks><p>Root class for query definition</p></remarks>
     */
    [Hl7PartTypeMappingAttribute(new string[] {"PORX_MT060220CA.ParameterList"})]
    public class ParameterList : MessagePartBean {

        private IVL<TS, Interval<PlatformDate>> administrationEffectivePeriodValue;
        private IVL<TS, Interval<PlatformDate>> amendedInTimeRangeValue;
        private IList<II> careCompositionIDValue;
        private IList<CV> careCompositionTypeValue;
        private BL includeIssuesIndicatorValue;
        private BL includeNotesIndicatorValue;
        private CV issueFilterCodeValue;
        private II otherMedicationRecordIdValue;

        public ParameterList() {
            this.administrationEffectivePeriodValue = new IVLImpl<TS, Interval<PlatformDate>>();
            this.amendedInTimeRangeValue = new IVLImpl<TS, Interval<PlatformDate>>();
            this.careCompositionIDValue = new List<II>();
            this.careCompositionTypeValue = new List<CV>();
            this.includeIssuesIndicatorValue = new BLImpl();
            this.includeNotesIndicatorValue = new BLImpl();
            this.issueFilterCodeValue = new CVImpl();
            this.otherMedicationRecordIdValue = new IIImpl();
        }
        /**
         * <summary>Administration Effective Period</summary>
         * 
         * <remarks><p>Indicates the administration period for which 
         * the request/query applies.</p><p>Filter the result set to 
         * include only those other medication records for which the 
         * patient was deemed to be taking the drug within the 
         * specified period.</p> <p>Indicates the administration period 
         * for which the request/query applies.</p><p>Filter the result 
         * set to include only those other medication records for which 
         * the patient was deemed to be taking the drug within the 
         * specified period.</p> <p>Allows the requester to specify the 
         * administration period of interest for the retrieval. Useful 
         * for constraining run-away queries.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"administrationEffectivePeriod/value"})]
        public Interval<PlatformDate> AdministrationEffectivePeriodValue {
            get { return this.administrationEffectivePeriodValue.Value; }
            set { this.administrationEffectivePeriodValue.Value = value; }
        }

        /**
         * <summary>Amended in Time Range</summary>
         * 
         * <remarks><p>Indicates that the returned records should be 
         * filtered to only include those which have been amended in 
         * some way (had status changed, been annotated, prescription 
         * was dispensed, etc.) within the indicated time-period. This 
         * will commonly be used to 'retrieve everything that has been 
         * amended since xxx'.</p> <p>Allows the requester to specify 
         * the event period of interest for the retrieval of medication 
         * records.</p><p>Useful for constraining run-away queries</p> 
         * <p>Allows the requester to specify the event period of 
         * interest for the retrieval of medication 
         * records.</p><p>Useful for constraining run-away queries</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"amendedInTimeRange/value"})]
        public Interval<PlatformDate> AmendedInTimeRangeValue {
            get { return this.amendedInTimeRangeValue.Value; }
            set { this.amendedInTimeRangeValue.Value = value; }
        }

        /**
         * <summary>Care Composition IDs</summary>
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
        [Hl7XmlMappingAttribute(new string[] {"careCompositionID/value"})]
        public IList<Identifier> CareCompositionIDValue {
            get { return new RawListWrapper<II, Identifier>(careCompositionIDValue, typeof(IIImpl)); }
        }

        /**
         * <summary>Care Composition Types</summary>
         * 
         * <remarks><p>Desc: Filters the records retrieved to only 
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
         * <summary>Include Issues Indicator</summary>
         * 
         * <remarks><p>Indicates whether or not Issues (detected and/or 
         * managed) attached to the other medication records are to be 
         * returned along with the detailed information.</p> <p>Allows 
         * for the flexibility of omitting/including issues in the 
         * retrieval of medication data.</p><p>Because the attribute is 
         * boolean, it must explicitly indicate a 'TRUE' or 'FALSE', 
         * and thus it is mandatory.</p> <p>Allows for the flexibility 
         * of omitting/including issues in the retrieval of medication 
         * data.</p><p>Because the attribute is boolean, it must 
         * explicitly indicate a 'TRUE' or 'FALSE', and thus it is 
         * mandatory.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"includeIssuesIndicator/value"})]
        public bool? IncludeIssuesIndicatorValue {
            get { return this.includeIssuesIndicatorValue.Value; }
            set { this.includeIssuesIndicatorValue.Value = value; }
        }

        /**
         * <summary>Include Notes Indicator</summary>
         * 
         * <remarks><p>Indicates whether or not notes attached to the 
         * other medication records are to be returned along with the 
         * detailed information.</p> <p>Allows for the flexibility of 
         * omitting/including notes in the retrieval of information for 
         * medication data.</p><p>Because the attribute is boolean, it 
         * must explicitly indicate a 'TRUE' or 'FALSE', and thus it is 
         * mandatory.</p> <p>Allows for the flexibility of 
         * omitting/including notes in the retrieval of information for 
         * medication data.</p><p>Because the attribute is boolean, it 
         * must explicitly indicate a 'TRUE' or 'FALSE', and thus it is 
         * mandatory.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"includeNotesIndicator/value"})]
        public bool? IncludeNotesIndicatorValue {
            get { return this.includeNotesIndicatorValue.Value; }
            set { this.includeNotesIndicatorValue.Value = value; }
        }

        /**
         * <summary>Issue Filter Code</summary>
         * 
         * <remarks><p>Indicates whether records to be returned (e.g. 
         * prescription order, prescription dispense and/or other 
         * medication) should be filtered to those with at least one 
         * persistent un-managed issue (against the record), with at 
         * least one persistent issues or should return all records, 
         * independent of the presence of persistent issues.</p> <p>By 
         * filtering returned records to include only those which have 
         * unmanaged issues or any issues at all, allows a provider to 
         * focus on those aspects of care where extra attention is 
         * needed. Because the attribute must be known, it is 
         * mandatory.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"issueFilterCode/value"})]
        public IssueFilterCode IssueFilterCodeValue {
            get { return (IssueFilterCode) this.issueFilterCodeValue.Value; }
            set { this.issueFilterCodeValue.Value = value; }
        }

        /**
         * <summary>E:Other Medication Record Id</summary>
         * 
         * <remarks><p>Identifier of the other medication record for 
         * which detailed information is to be retrieved.</p> <p>Allows 
         * for the retrieval of medication records based on a specific 
         * active medication record.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"otherMedicationRecordId/value"})]
        public Identifier OtherMedicationRecordIdValue {
            get { return this.otherMedicationRecordIdValue.Value; }
            set { this.otherMedicationRecordIdValue.Value = value; }
        }

    }

}