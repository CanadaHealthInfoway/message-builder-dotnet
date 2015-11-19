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
namespace Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_05_00.Common.Merged {
    using Ca.Infoway.Messagebuilder.Annotation;
    using Ca.Infoway.Messagebuilder.Datatype;
    using Ca.Infoway.Messagebuilder.Datatype.Impl;
    using Ca.Infoway.Messagebuilder.Datatype.Lang;
    using Ca.Infoway.Messagebuilder.Model;


    /**
     * <summary>Business Name: PriorRegistrationEvent</summary>
     * 
     * <remarks>MFMI_MT700711CA.PriorRegistration: Prior 
     * Registration Event <p>Used to associate (replace) a current 
     * registration with a regsitration already received (supports 
     * merges).</p> <p>This class describes the registration of a 
     * client, provider, location, etc. in the past.</p> 
     * MFMI_MT700717CA.PriorRegistration: Prior Registration Event 
     * <p>Used to associate (replace) a current registration with a 
     * regsitration already received (supports merges).</p> <p>This 
     * class describes the registration of a client, provider, 
     * location, etc. in the past.</p> 
     * MFMI_MT700746CA.PriorRegistration: Prior Registration Event 
     * <p>Used to associate (replace) a current registration with a 
     * regsitration already received (supports merges).</p> <p>This 
     * class describes the registration of a client, provider, 
     * location, etc. in the past.</p> 
     * MFMI_MT700726CA.PriorRegistration: Prior Registration Event 
     * <p>Used to associate (replace) a current registration with a 
     * regsitration already received (supports merges).</p> <p>This 
     * class describes the registration of a client, provider, 
     * location, etc. in the past.</p></remarks>
     */
    [Hl7PartTypeMappingAttribute(new string[] {"MFMI_MT700711CA.PriorRegistration","MFMI_MT700717CA.PriorRegistration","MFMI_MT700726CA.PriorRegistration","MFMI_MT700746CA.PriorRegistration"})]
    public class PriorRegistrationEvent : MessagePartBean {

        private II subjectPriorRegisteredRoleId;

        public PriorRegistrationEvent() {
            this.subjectPriorRegisteredRoleId = new IIImpl();
        }
        /**
         * <summary>Business Name: PriorRegisteredRoleIds</summary>
         * 
         * <remarks>Un-merged Business Name: PriorRegisteredRoleIds 
         * Relationship: MFMI_MT700711CA.PriorRegisteredRole.id 
         * Conformance/Cardinality: MANDATORY (1) <p>Provides support 
         * for merges.</p> <p>Identifies &quot;duplicate&quot; records 
         * of the registered item that have been superseded by this 
         * record.</p> Un-merged Business Name: PriorRegisteredRoleIds 
         * Relationship: MFMI_MT700717CA.PriorRegisteredRole.id 
         * Conformance/Cardinality: MANDATORY (1) <p>Provides support 
         * for merges.</p> <p>Identifies &quot;duplicate&quot; records 
         * of the registered item that have been superseded by this 
         * record.</p> Un-merged Business Name: PriorRegisteredRoleIds 
         * Relationship: MFMI_MT700746CA.PriorRegisteredRole.id 
         * Conformance/Cardinality: MANDATORY (1) <p>Provides support 
         * for merges.</p> <p>Identifies &quot;duplicate&quot; records 
         * of the registered item that have been superseded by this 
         * record.</p> Un-merged Business Name: PriorRegisteredRoleIds 
         * Relationship: MFMI_MT700726CA.PriorRegisteredRole.id 
         * Conformance/Cardinality: MANDATORY (1) <p>Provides support 
         * for merges.</p> <p>Identifies &quot;duplicate&quot; records 
         * of the registered item that have been superseded by this 
         * record.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"subject/priorRegisteredRole/id"})]
        public Identifier SubjectPriorRegisteredRoleId {
            get { return this.subjectPriorRegisteredRoleId.Value; }
            set { this.subjectPriorRegisteredRoleId.Value = value; }
        }

    }

}