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
 * Last modified: $LastChangedDate: 2012-02-16 11:15:02 -0500 (Thu, 16 Feb 2012) $
 * Revision:      $LastChangedRevision: 5577 $
 */
/* This class was auto-generated by the message builder generator tools. */
namespace Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r02.Pr.Prpm_mt303010ca {
    using Ca.Infoway.Messagebuilder.Annotation;
    using Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r02.Pr.Merged;
    using System.Collections.Generic;


    [Hl7PartTypeMappingAttribute(new string[] {"PRPM_MT303010CA.RoleChoice"})]
    public interface IRoleChoice {

        [Hl7XmlMappingAttribute(new string[] {"responsibleFor/privilege"})]
        IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r02.Pr.Merged.Privilege> ResponsibleForPrivilege {
            get;
        }

        [Hl7XmlMappingAttribute(new string[] {"relatedTo"})]
        IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r02.Pr.Prpm_mt303010ca.RelatedTo> RelatedTo {
            get;
        }

    }

}