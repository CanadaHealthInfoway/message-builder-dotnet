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
namespace Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Pharmacy.Porx_mt060110ca {
    using Ca.Infoway.Messagebuilder.Annotation;
    using Ca.Infoway.Messagebuilder.Datatype;
    using Ca.Infoway.Messagebuilder.Datatype.Impl;
    using Ca.Infoway.Messagebuilder.Datatype.Lang;
    using Ca.Infoway.Messagebuilder.Domainvalue;
    using Ca.Infoway.Messagebuilder.Model;
    using System;


    /**
     * <summary><p>Defines the set of parameters that may be used 
     * to filter the query response.</p></summary>
     * 
     * <remarks><p>Root class for query definition</p></remarks>
     */
    [Hl7PartTypeMappingAttribute(new string[] {"PORX_MT060110CA.ParameterList"})]
    public class ParameterList : MessagePartBean {

        private IVL<TS, Interval<PlatformDate>> administrationEffectivePeriodValue;
        private CV issueFilterCodeValue;
        private BL mostRecentByDrugIndicatorValue;
        private BL mostRecentDispenseForEachRxIndicatorValue;

        public ParameterList() {
            this.administrationEffectivePeriodValue = new IVLImpl<TS, Interval<PlatformDate>>();
            this.issueFilterCodeValue = new CVImpl();
            this.mostRecentByDrugIndicatorValue = new BLImpl();
            this.mostRecentDispenseForEachRxIndicatorValue = new BLImpl();
        }
        /**
         * <summary>D:Administration Effective Period</summary>
         * 
         * <remarks><p>Indicates the administration period for which 
         * the request/query applies.</p><p>Filter the result set to 
         * include only those medication records (prescription order, 
         * prescription dispense and other active medication) for which 
         * the patient was deemed to be taking the drug within the 
         * specified period.</p> <p>Indicates the administration period 
         * for which the request/query applies.</p><p>Filter the result 
         * set to include only those medication records (prescription 
         * order, prescription dispense and other active medication) 
         * for which the patient was deemed to be taking the drug 
         * within the specified period.</p> <p>Allows the requester to 
         * specify the administration period of interest for the 
         * retrieval. Useful for constraining run-away queries.</p> 
         * <p>The determination for applicability for inclusion in the 
         * query response should be considered to be the 'Pick up date 
         * plus the days supply'</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"administrationEffectivePeriod/value"})]
        public Interval<PlatformDate> AdministrationEffectivePeriodValue {
            get { return this.administrationEffectivePeriodValue.Value; }
            set { this.administrationEffectivePeriodValue.Value = value; }
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
         * <summary>Most Recent By Drug Indicator</summary>
         * 
         * <remarks><p>Indicates whether or not the medication records 
         * are to be retrieved based on the most recent by Drug Code. 
         * If true, only the most recent prescription, dispense or 
         * other active medication for a particular drug generic 
         * classification will be returned. The default is 'FALSE' 
         * indicating that retrieval of prescription, dispense and 
         * other active medication records should not be limited to one 
         * per drug.</p> <p>Helps decrease the volume of records 
         * returned, while still maintaining information on all drugs 
         * that the patient is on.</p><p>Because this is a boolean 
         * attribute whose value must be known to evaluate the query, 
         * the attribute is mandatory.</p> <p>Helps decrease the volume 
         * of records returned, while still maintaining information on 
         * all drugs that the patient is on.</p><p>Because this is a 
         * boolean attribute whose value must be known to evaluate the 
         * query, the attribute is mandatory.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"mostRecentByDrugIndicator/value"})]
        public bool? MostRecentByDrugIndicatorValue {
            get { return this.mostRecentByDrugIndicatorValue.Value; }
            set { this.mostRecentByDrugIndicatorValue.Value = value; }
        }

        /**
         * <summary>Most Recent Dispense for each Rx Indicator</summary>
         * 
         * <remarks><p>Indicates whether or not prescription dispenses 
         * returned on a query should be limited to only the most 
         * recent dispense for a prescription order.</p><p>Allows for 
         * the returning of at most one prescription dispense record 
         * per a prescription.</p><p>The default is 'TRUE' indicating 
         * that retrieval should be for only the most recent dispense 
         * for a prescription is to be included in a query result.</p> 
         * <p>Indicates whether or not prescription dispenses returned 
         * on a query should be limited to only the most recent 
         * dispense for a prescription order.</p><p>Allows for the 
         * returning of at most one prescription dispense record per a 
         * prescription.</p><p>The default is 'TRUE' indicating that 
         * retrieval should be for only the most recent dispense for a 
         * prescription is to be included in a query result.</p> 
         * <p>Indicates whether or not prescription dispenses returned 
         * on a query should be limited to only the most recent 
         * dispense for a prescription order.</p><p>Allows for the 
         * returning of at most one prescription dispense record per a 
         * prescription.</p><p>The default is 'TRUE' indicating that 
         * retrieval should be for only the most recent dispense for a 
         * prescription is to be included in a query result.</p> 
         * <p>Helps to trim down volume of query response by 
         * eliminating multiple prescription dispenses for the same 
         * prescription order.</p><p>Because this is a boolean 
         * attribute whose value must be known to evaluate the query, 
         * the attribute is mandatory.</p> <p>Helps to trim down volume 
         * of query response by eliminating multiple prescription 
         * dispenses for the same prescription order.</p><p>Because 
         * this is a boolean attribute whose value must be known to 
         * evaluate the query, the attribute is mandatory.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"mostRecentDispenseForEachRxIndicator/value"})]
        public bool? MostRecentDispenseForEachRxIndicatorValue {
            get { return this.mostRecentDispenseForEachRxIndicatorValue.Value; }
            set { this.mostRecentDispenseForEachRxIndicatorValue.Value = value; }
        }

    }

}