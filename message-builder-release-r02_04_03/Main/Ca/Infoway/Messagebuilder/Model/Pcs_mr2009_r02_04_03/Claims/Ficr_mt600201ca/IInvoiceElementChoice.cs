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
namespace Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Claims.Ficr_mt600201ca {
    using Ca.Infoway.Messagebuilder.Annotation;
    using Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Common.Coct_mt280001ca;
    using System.Collections.Generic;


    /**
     * <summary><p>All Relationships to the InvoiceElementGroup can 
     * only be associated with the root level instance</p></summary>
     * 
     * <remarks><p>Data centre and sequence number must be the same 
     * for each complete group and detail hierarchy</p></remarks>
     */
    [Hl7PartTypeMappingAttribute(new string[] {"FICR_MT600201CA.InvoiceElementChoice"})]
    public interface IInvoiceElementChoice {

        [Hl7XmlMappingAttribute(new string[] {"reasonOf/billableActChoice"})]
        IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Common.Coct_mt280001ca.IA_BillableActChoice> ReasonOfBillableActChoice {
            get;
        }

    }

}