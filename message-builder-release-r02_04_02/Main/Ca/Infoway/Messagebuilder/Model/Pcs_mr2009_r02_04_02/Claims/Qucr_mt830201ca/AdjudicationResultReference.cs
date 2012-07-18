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
 * Last modified: $LastChangedDate: 2012-01-18 21:01:57 -0500 (Wed, 18 Jan 2012) $
 * Revision:      $LastChangedRevision: 3899 $
 */

/* This class was auto-generated by the message builder generator tools. */
namespace Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Claims.Qucr_mt830201ca {
    using Ca.Infoway.Messagebuilder.Annotation;
    using Ca.Infoway.Messagebuilder.Model;
    using Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Claims.Merged;


    /**
     * <summary><p>Multiple references to submitted invoice 
     * elements provides support for code substitution where the 
     * number of submitted fee items is consolidated on the 
     * adjudication results (e.g. 3 items to 1).</p></summary>
     */
    [Hl7PartTypeMappingAttribute(new string[] {"QUCR_MT830201CA.AdjudicationResultReference"})]
    public class AdjudicationResultReference : MessagePartBean {

        private Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Claims.Merged.InvoiceType invoiceElementGroup;

        public AdjudicationResultReference() {
        }
        [Hl7XmlMappingAttribute(new string[] {"invoiceElementGroup"})]
        public Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Claims.Merged.InvoiceType InvoiceElementGroup {
            get { return this.invoiceElementGroup; }
            set { this.invoiceElementGroup = value; }
        }

    }

}