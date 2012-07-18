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
 * Last modified: $LastChangedDate: 2012-01-19 07:10:44 -0500 (Thu, 19 Jan 2012) $
 * Revision:      $LastChangedRevision: 4367 $
 */

/* This class was auto-generated by the message builder generator tools. */
namespace Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Claims.Merged {
    using Ca.Infoway.Messagebuilder;
    using Ca.Infoway.Messagebuilder.Annotation;
    using Ca.Infoway.Messagebuilder.Datatype;
    using Ca.Infoway.Messagebuilder.Datatype.Impl;
    using Ca.Infoway.Messagebuilder.Model;
    using Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Claims.Ficr_mt510201ca;


    /**
     * <summary>FICR_MT510201CA.AdjudicationResultRequiredAct: (no 
     * business name)</summary>
     * 
     * <remarks><p>Id allows for consolidating identical required 
     * acts on 1 form</p> 
     * FICR_MT610201CA.AdjudicationResultRequiredAct: (no business 
     * name) <p>Id allows for consolidating identical required acts 
     * on 1 form</p></remarks>
     */
    [Hl7PartTypeMappingAttribute(new string[] {"FICR_MT510201CA.AdjudicationResultRequiredAct","FICR_MT610201CA.AdjudicationResultRequiredAct"})]
    public class AdjudicationResultRequiredAct : MessagePartBean {

        private CV requiredActionType;
        private Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Claims.Ficr_mt510201ca.FormRole directTargetFormRole;

        public AdjudicationResultRequiredAct() {
            this.requiredActionType = new CVImpl();
        }
        /**
         * <summary>RequiredActionType</summary>
         * 
         * <remarks>Required Action Type</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"code"})]
        public Code RequiredActionType {
            get { return (Code) this.requiredActionType.Value; }
            set { this.requiredActionType.Value = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"directTarget/formRole"})]
        public Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Claims.Ficr_mt510201ca.FormRole DirectTargetFormRole {
            get { return this.directTargetFormRole; }
            set { this.directTargetFormRole = value; }
        }

    }

}