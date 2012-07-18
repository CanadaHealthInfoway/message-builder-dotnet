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
namespace Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Pharmacy.Porx_mt060080ca {
    using Ca.Infoway.Messagebuilder.Annotation;
    using Ca.Infoway.Messagebuilder.Datatype;
    using Ca.Infoway.Messagebuilder.Datatype.Impl;
    using Ca.Infoway.Messagebuilder.Datatype.Lang;
    using Ca.Infoway.Messagebuilder.Domainvalue;
    using Ca.Infoway.Messagebuilder.Model;
    using System.Collections.Generic;


    /**
     * <summary>Generic Query Parameters</summary>
     * 
     * <remarks><p>Defines the set of parameters that may be used 
     * to filter the query response.</p> <p>Root class for query 
     * definition</p></remarks>
     */
    [Hl7PartTypeMappingAttribute(new string[] {"PORX_MT060080CA.ParameterList"})]
    public class GenericQueryParameters : MessagePartBean {

        private CV issueFilterCodeValue;
        private SET<II, Identifier> prescriptionOrderNumberValue;

        public GenericQueryParameters() {
            this.issueFilterCodeValue = new CVImpl();
            this.prescriptionOrderNumberValue = new SETImpl<II, Identifier>(typeof(IIImpl));
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
         * <summary>D:Prescription Order Number</summary>
         * 
         * <remarks><p>Identifier of the prescription for which 
         * detailed information is required.</p><p>The result set will 
         * be filtered to only the specific prescription.</p> 
         * <p>Identifier of the prescription for which detailed 
         * information is required.</p><p>The result set will be 
         * filtered to only the specific prescription.</p> 
         * <p>Identifies the prescription that is to be retrieved and 
         * is therefore mandatory.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"prescriptionOrderNumber/value"})]
        public ICollection<Identifier> PrescriptionOrderNumberValue {
            get { return this.prescriptionOrderNumberValue.RawSet(); }
        }

    }

}