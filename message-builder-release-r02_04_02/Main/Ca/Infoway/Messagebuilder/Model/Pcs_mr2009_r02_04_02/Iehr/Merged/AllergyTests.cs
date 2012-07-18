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
 * Last modified: $LastChangedDate: 2012-01-18 21:06:13 -0500 (Wed, 18 Jan 2012) $
 * Revision:      $LastChangedRevision: 3939 $
 */

/* This class was auto-generated by the message builder generator tools. */
namespace Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Iehr.Merged {
    using Ca.Infoway.Messagebuilder.Annotation;
    using Ca.Infoway.Messagebuilder.Datatype;
    using Ca.Infoway.Messagebuilder.Datatype.Impl;
    using Ca.Infoway.Messagebuilder.Datatype.Lang;
    using Ca.Infoway.Messagebuilder.Domainvalue;
    using Ca.Infoway.Messagebuilder.Model;
    using System;


    /**
     * <summary>AllergyTests</summary>
     * 
     * <remarks>REPC_MT000005CA.AllergyTestEvent: Allergy Tests 
     * <p>Indicates the specific allergy test that supports the 
     * recording of the allergy/intolerance.</p> <p>Provides 
     * evidence for recording the allergy/intolerance.</p> 
     * REPC_MT000001CA.AllergyTestEvent: Allergy Tests <p>At least 
     * one of Id or Value must be specified.</p> <p>Indicates the 
     * specific allergy test that supports the recording of the 
     * allergy/intolerance.</p> <p>Provides evidence for recording 
     * the allergy/intolerance.</p> 
     * REPC_MT000013CA.AllergyTestEvent: Allergy Tests <p>At least 
     * one of Id or Value must be specified</p> <p>Indicates the 
     * specific allergy test that supports the recording of the 
     * allergy/intolerance.</p> <p>Provides evidence for recording 
     * the allergy/intolerance.</p> 
     * REPC_MT000009CA.AllergyTestEvent: Allergy Tests <p>At least 
     * one of Id or Value must be specified.</p> <p>Indicates the 
     * specific allergy test that supports the recording of the 
     * allergy/intolerance.</p> <p>Provides evidence for recording 
     * the allergy/intolerance.</p></remarks>
     */
    [Hl7PartTypeMappingAttribute(new string[] {"REPC_MT000001CA.AllergyTestEvent","REPC_MT000005CA.AllergyTestEvent","REPC_MT000009CA.AllergyTestEvent","REPC_MT000013CA.AllergyTestEvent"})]
    public class AllergyTests : MessagePartBean, Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Iehr.Merged.IRecords {

        private II allergyTestRecordId;
        private CD allergyTestType;
        private TS allergyTestDate;
        private CV allergyTestResult;

        public AllergyTests() {
            this.allergyTestRecordId = new IIImpl();
            this.allergyTestType = new CDImpl();
            this.allergyTestDate = new TSImpl();
            this.allergyTestResult = new CVImpl();
        }
        /**
         * <summary>AllergyTestRecordId</summary>
         * 
         * <remarks>B:Allergy Test Record Id <p>An identifier for a 
         * specific instance of an allergy/intolerance test.</p> 
         * <p>Allows an allergy/intolerance test record to be directly 
         * referenced.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"id"})]
        public Identifier AllergyTestRecordId {
            get { return this.allergyTestRecordId.Value; }
            set { this.allergyTestRecordId.Value = value; }
        }

        /**
         * <summary>AllergyTestType</summary>
         * 
         * <remarks>A:Allergy Test Type <p>A coded value denoting the 
         * type of allergy test conducted.</p> <p>Allows different 
         * kinds of allergy/intolerance tests to be distinguishable and 
         * is therefore mandatory. It uses the CD type to support 
         * SNOMED post-coordination.</p> A:Allergy Test Type <p>At 
         * least one of Id or Value must be specified.</p> <p>A coded 
         * value denoting the type of allergy test conducted.</p> 
         * <p>Allows different kinds of allergy/intolerance tests to be 
         * distinguishable and is therefore mandatory. It uses the CD 
         * type to support SNOMED post-coordination.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"code"})]
        public ObservationAllergyTestType AllergyTestType {
            get { return (ObservationAllergyTestType) this.allergyTestType.Value; }
            set { this.allergyTestType.Value = value; }
        }

        /**
         * <summary>AllergyTestDate</summary>
         * 
         * <remarks>D:Allergy Test Date <p>The date on which the 
         * allergy test was performed.</p> <p>Allows providers to 
         * evaluate the currency of the test.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"effectiveTime"})]
        public PlatformDate AllergyTestDate {
            get { return this.allergyTestDate.Value; }
            set { this.allergyTestDate.Value = value; }
        }

        /**
         * <summary>AllergyTestResult</summary>
         * 
         * <remarks>C:Allergy Test Result <p>Value is required if not 
         * using SNOMED</p> <p>A code indicating result of the allergy 
         * test.</p> <p>Allows other providers to evaluate the test. 
         * There is no point in associating an allergy test with 
         * unknown results with an allergy or intolerance however the 
         * element is optional because this information may be 
         * post-coordinated in the 'code' attribute using SNOMED.</p> 
         * C:Allergy Test Result <p>Value is mandatory if not using 
         * SNOMED</p> <p>A code indicating result of the allergy 
         * test.</p> <p>Allows other providers to evaluate the test. 
         * There is no point in associating an allergy test with 
         * unknown results with an allergy or intolerance however the 
         * element is optional because this information may be 
         * post-coordinated in the 'code' attribute using SNOMED.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"value"})]
        public AllergyTestValue AllergyTestResult {
            get { return (AllergyTestValue) this.allergyTestResult.Value; }
            set { this.allergyTestResult.Value = value; }
        }

    }

}