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
 * Last modified: $LastChangedDate: 2012-01-18 21:00:53 -0500 (Wed, 18 Jan 2012) $
 * Revision:      $LastChangedRevision: 3894 $
 */

/* This class was auto-generated by the message builder generator tools. */
namespace Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Claims.Ficr_mt510201ca {
    using Ca.Infoway.Messagebuilder;
    using Ca.Infoway.Messagebuilder.Annotation;
    using Ca.Infoway.Messagebuilder.Datatype;
    using Ca.Infoway.Messagebuilder.Datatype.Impl;
    using Ca.Infoway.Messagebuilder.Model;
    using Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Merged;
    using System.Collections.Generic;


    [Hl7PartTypeMappingAttribute(new string[] {"FICR_MT510201CA.AdjudicationResult"})]
    public class AdjudicationResult : MessagePartBean {

        private CV adjudicationResultsAdjudicationCode;
        private IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Claims.Ficr_mt510201ca.Trigger1> trigger;
        private IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Merged.IInvoiceElementChoice> referenceInvoiceElementChoice;
        private IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Claims.Ficr_mt510201ca.IAdjudicationCodeChoice> pertinentInformationAdjudicationCodeChoice;
        private IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Merged.Issues> reasonOfDetectedIssueEvent;

        public AdjudicationResult() {
            this.adjudicationResultsAdjudicationCode = new CVImpl();
            this.trigger = new List<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Claims.Ficr_mt510201ca.Trigger1>();
            this.referenceInvoiceElementChoice = new List<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Merged.IInvoiceElementChoice>();
            this.pertinentInformationAdjudicationCodeChoice = new List<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Claims.Ficr_mt510201ca.IAdjudicationCodeChoice>();
            this.reasonOfDetectedIssueEvent = new List<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Merged.Issues>();
        }
        /**
         * <summary>Adjudication Results Adjudication Code</summary>
         */
        [Hl7XmlMappingAttribute(new string[] {"code"})]
        public Code AdjudicationResultsAdjudicationCode {
            get { return (Code) this.adjudicationResultsAdjudicationCode.Value; }
            set { this.adjudicationResultsAdjudicationCode.Value = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"trigger"})]
        public IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Claims.Ficr_mt510201ca.Trigger1> Trigger {
            get { return this.trigger; }
        }

        [Hl7XmlMappingAttribute(new string[] {"reference/invoiceElementChoice"})]
        public IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Merged.IInvoiceElementChoice> ReferenceInvoiceElementChoice {
            get { return this.referenceInvoiceElementChoice; }
        }

        [Hl7XmlMappingAttribute(new string[] {"pertinentInformation/adjudicationCodeChoice"})]
        public IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Claims.Ficr_mt510201ca.IAdjudicationCodeChoice> PertinentInformationAdjudicationCodeChoice {
            get { return this.pertinentInformationAdjudicationCodeChoice; }
        }

        [Hl7XmlMappingAttribute(new string[] {"reasonOf/detectedIssueEvent"})]
        public IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Merged.Issues> ReasonOfDetectedIssueEvent {
            get { return this.reasonOfDetectedIssueEvent; }
        }

    }

}