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
namespace Ca.Infoway.Messagebuilder.Model.Pcs_cerx_v01_r04_3.Pharmacy.Porx_mt060070ca {
    using Ca.Infoway.Messagebuilder.Annotation;
    using Ca.Infoway.Messagebuilder.Datatype;
    using Ca.Infoway.Messagebuilder.Datatype.Impl;
    using Ca.Infoway.Messagebuilder.Datatype.Lang;
    using Ca.Infoway.Messagebuilder.Domainvalue;
    using Ca.Infoway.Messagebuilder.Model;
    using System;
    using System.Collections.Generic;


    /**
     * <summary>Business Name: Query Parameters</summary>
     * 
     * <p>Root class for query definition</p> <p>Defines the set of 
     * parameters that may be used to filter the query 
     * response.</p>
     */
    [Hl7PartTypeMappingAttribute(new string[] {"PORX_MT060070CA.ParameterList"})]
    public class QueryParameters : MessagePartBean {

        private IVL<TS, Interval<PlatformDate>> amendedInTimeRangeValue;
        private CV issueFilterCodeValue;
        private BL mostRecentByDeviceIndicatorValue;
        private TS patientBirthDateValue;
        private CV patientGenderValue;
        private II patientIDValue;
        private PN patientNameValue;
        private IList<CV> rxDispenseIndicatorValue;
        private IVL<TS, Interval<PlatformDate>> usageEffectivePeriodValue;

        public QueryParameters() {
            this.amendedInTimeRangeValue = new IVLImpl<TS, Interval<PlatformDate>>();
            this.issueFilterCodeValue = new CVImpl();
            this.mostRecentByDeviceIndicatorValue = new BLImpl();
            this.patientBirthDateValue = new TSImpl();
            this.patientGenderValue = new CVImpl();
            this.patientIDValue = new IIImpl();
            this.patientNameValue = new PNImpl();
            this.rxDispenseIndicatorValue = new List<CV>();
            this.usageEffectivePeriodValue = new IVLImpl<TS, Interval<PlatformDate>>();
        }
        /**
         * <summary>Business Name: Amended in Time Range</summary>
         * 
         * <remarks>Relationship: 
         * PORX_MT060070CA.AmendedInTimeRange.value 
         * Conformance/Cardinality: MANDATORY (1) <p>Allows the 
         * requester to specify the event period of interest for the 
         * retrieval of medication records.</p><p>Useful for 
         * constraining run-away queries.</p> <p>Indicates that the 
         * returned records should be filtered to only include those 
         * which have been amended in some way (had status changed, 
         * been annotated, prescription was dispensed, etc.) within the 
         * indicated time-period. This will commonly be used to 
         * 'retrieve everything that has been amended since xxx'.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"amendedInTimeRange/value"})]
        public Interval<PlatformDate> AmendedInTimeRangeValue {
            get { return this.amendedInTimeRangeValue.Value; }
            set { this.amendedInTimeRangeValue.Value = value; }
        }

        /**
         * <summary>Business Name: Issue Filter Code</summary>
         * 
         * <remarks>Relationship: PORX_MT060070CA.IssueFilterCode.value 
         * Conformance/Cardinality: MANDATORY (1) <p>By filtering 
         * returned records to include only those which have unmanaged 
         * issues or any issues at all, allows a provider to focus on 
         * those aspects of care where extra attention is needed. 
         * Because the attribute must be known, it is mandatory.</p> 
         * <p>Indicates whether records to be returned (e.g. 
         * prescription order, prescription dispense and/or other 
         * medication) should be filtered to those with at least one 
         * persistent un-managed issue (against the record), with at 
         * least one persistent issues or should return all records, 
         * independent of the presence of persistent issues.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"issueFilterCode/value"})]
        public IssueFilterCode IssueFilterCodeValue {
            get { return (IssueFilterCode) this.issueFilterCodeValue.Value; }
            set { this.issueFilterCodeValue.Value = value; }
        }

        /**
         * <summary>Business Name: Most Recent By Device Indicator</summary>
         * 
         * <remarks>Relationship: 
         * PORX_MT060070CA.MostRecentByDeviceIndicator.value 
         * Conformance/Cardinality: MANDATORY (1) <p>Helps decrease the 
         * volume of records returned, while still maintaining 
         * information on all devices that the patient is 
         * using.</p><p>Because this is a boolean attribute whose value 
         * must be known to evaluate the query, the attribute is 
         * mandatory.</p> <p>Indicates whether or not the records are 
         * to be retrieved based on the most recent by Device Code. If 
         * true, only the most recent prescription or dispense for a 
         * particular device type will be returned. The default is 
         * 'FALSE' indicating that retrieval of prescription or 
         * dispense records should not be limited to one per device 
         * type.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"mostRecentByDeviceIndicator/value"})]
        public bool? MostRecentByDeviceIndicatorValue {
            get { return this.mostRecentByDeviceIndicatorValue.Value; }
            set { this.mostRecentByDeviceIndicatorValue.Value = value; }
        }

        /**
         * <summary>Business Name: Patient Birth Date</summary>
         * 
         * <remarks>Relationship: 
         * PORX_MT060070CA.PatientBirthDate.value 
         * Conformance/Cardinality: MANDATORY (1) <p>Used to confirm 
         * the identity of the patient for the query and is therefore 
         * mandatory.</p> <p>Indicates the date on which the patient 
         * was born.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"patientBirthDate/value"})]
        public PlatformDate PatientBirthDateValue {
            get { return this.patientBirthDateValue.Value; }
            set { this.patientBirthDateValue.Value = value; }
        }

        /**
         * <summary>Business Name: Patient Gender</summary>
         * 
         * <remarks>Relationship: PORX_MT060070CA.PatientGender.value 
         * Conformance/Cardinality: MANDATORY (1) <p>Used to confirm 
         * the identity of the patient for the query and is therefore 
         * mandatory.</p> <p>Indicates the gender (sex) of the 
         * patient.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"patientGender/value"})]
        public AdministrativeGender PatientGenderValue {
            get { return (AdministrativeGender) this.patientGenderValue.Value; }
            set { this.patientGenderValue.Value = value; }
        }

        /**
         * <summary>Business Name: B:Patient ID</summary>
         * 
         * <remarks>Relationship: PORX_MT060070CA.PatientID.value 
         * Conformance/Cardinality: MANDATORY (1) <p>Allows filtering 
         * of result set by patient Id. This is a mandatory field 
         * because a patient must be specified for the query to be 
         * valid</p> <p>Identifier of the patient who is the subject of 
         * the query. Filter the result set to include only those 
         * records pertaining to the patient with this Id.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"patientID/value"})]
        public Identifier PatientIDValue {
            get { return this.patientIDValue.Value; }
            set { this.patientIDValue.Value = value; }
        }

        /**
         * <summary>Business Name: C:Patient Name</summary>
         * 
         * <remarks>Relationship: PORX_MT060070CA.PatientName.value 
         * Conformance/Cardinality: MANDATORY (1) <p>Used to confirm 
         * the identity of the patient for the query and is therefore 
         * mandatory.</p> <p>The name by which the patient is 
         * known.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"patientName/value"})]
        public PersonName PatientNameValue {
            get { return this.patientNameValue.Value; }
            set { this.patientNameValue.Value = value; }
        }

        /**
         * <summary>Business Name: Rx Dispenser Indicators</summary>
         * 
         * <remarks>Relationship: 
         * PORX_MT060070CA.RxDispenseIndicator.value 
         * Conformance/Cardinality: MANDATORY (1) <p>Allows for finer 
         * sub-set of prescriptions to be retrieved based on the fill 
         * status of the prescription.</p> <p>A coded value indicating 
         * the dispensing (fill) status of the prescription to be 
         * included in the result set. Rx Dispense Indicators include: 
         * ND (Never Dispensed), DRR (Dispensed with Refills 
         * Remaining), etc.</p><p>The repetition of 3 allows for 
         * retrieval based on all three Rx Dispense Indicators.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"rxDispenseIndicator/value"})]
        public IList<PrescriptionDispenseFilterCode> RxDispenseIndicatorValue {
            get { return new RawListWrapper<CV, PrescriptionDispenseFilterCode>(rxDispenseIndicatorValue, typeof(CVImpl)); }
        }

        /**
         * <summary>Business Name: Usage Effective Period</summary>
         * 
         * <remarks>Relationship: 
         * PORX_MT060070CA.UsageEffectivePeriod.value 
         * Conformance/Cardinality: MANDATORY (1) <p>Allows the 
         * requester to specify the usage period of interest for the 
         * retrieval. Useful for constraining run-away queries.</p> 
         * <p>Indicates the usage period for which the request/query 
         * applies.</p><p>Filter the result set to include only those 
         * device records (device order and device dispense) for which 
         * the patient was deemed to be using the device within the 
         * specified period.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"usageEffectivePeriod/value"})]
        public Interval<PlatformDate> UsageEffectivePeriodValue {
            get { return this.usageEffectivePeriodValue.Value; }
            set { this.usageEffectivePeriodValue.Value = value; }
        }

    }

}