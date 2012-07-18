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
 * Last modified: $LastChangedDate: 2012-02-16 11:02:05 -0500 (Thu, 16 Feb 2012) $
 * Revision:      $LastChangedRevision: 5406 $
 */
/* This class was auto-generated by the message builder generator tools. */
namespace Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r01.Interaction {
    using Ca.Infoway.Messagebuilder.Annotation;
    using Ca.Infoway.Messagebuilder.Model;
    using Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r01.Common.Merged;
    using Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r01.Common.Mfmi_mt700746ca;
    using Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r01.Cr.Merged;
    using Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r01.Cr.Prpa_mt101101ca;


    [Hl7PartTypeMappingAttribute(new string[] {"PRPA_IN101106CA"})]
    public class FindAssociatedIndentifiersResponse : HL7Message_1<Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r01.Common.Mfmi_mt700746ca.TriggerEvent<Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r01.Cr.Merged.IdentifiedPerson,Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r01.Cr.Prpa_mt101101ca.ParameterList>>, IInteraction {


        public FindAssociatedIndentifiersResponse() {
        }
    }

}