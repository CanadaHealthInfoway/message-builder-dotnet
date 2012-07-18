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
    using Ca.Infoway.Messagebuilder.Annotation;
    using Ca.Infoway.Messagebuilder.Datatype;
    using Ca.Infoway.Messagebuilder.Datatype.Impl;
    using Ca.Infoway.Messagebuilder.Datatype.Lang;
    using Ca.Infoway.Messagebuilder.Model;
    using Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Claims.Merged;
    using System.Collections.Generic;


    [Hl7PartTypeMappingAttribute(new string[] {"FICR_MT510201CA.AdjudicationResultReason"})]
    public class AdjudicationResultReason : MessagePartBean, Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Claims.Ficr_mt510201ca.IAdjudicationCodeChoice {

        private IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Claims.Merged.AdjudicationResultRequiredAct> triggerAdjudicationResultRequiredAct;
        private ED<EncapsulatedData> adjudicatedResultReason;

        public AdjudicationResultReason() {
            this.triggerAdjudicationResultRequiredAct = new List<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Claims.Merged.AdjudicationResultRequiredAct>();
            this.adjudicatedResultReason = new EDImpl<EncapsulatedData>();
        }
        [Hl7XmlMappingAttribute(new string[] {"trigger/adjudicationResultRequiredAct"})]
        public IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Claims.Merged.AdjudicationResultRequiredAct> TriggerAdjudicationResultRequiredAct {
            get { return this.triggerAdjudicationResultRequiredAct; }
        }

        /**
         * <summary>Adjudicated Result Reason</summary>
         */
        [Hl7XmlMappingAttribute(new string[] {"value"})]
        public EncapsulatedData AdjudicatedResultReason {
            get { return this.adjudicatedResultReason.Value; }
            set { this.adjudicatedResultReason.Value = value; }
        }

    }

}