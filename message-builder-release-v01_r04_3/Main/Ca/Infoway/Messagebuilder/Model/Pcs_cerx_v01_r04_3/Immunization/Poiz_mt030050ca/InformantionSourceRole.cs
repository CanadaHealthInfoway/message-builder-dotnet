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
 * Last modified: $LastChangedDate: 2012-02-16 10:58:08 -0500 (Thu, 16 Feb 2012) $
 * Revision:      $LastChangedRevision: 5370 $
 */
/* This class was auto-generated by the message builder generator tools. */
namespace Ca.Infoway.Messagebuilder.Model.Pcs_cerx_v01_r04_3.Immunization.Poiz_mt030050ca {
    using Ca.Infoway.Messagebuilder.Annotation;
    using Ca.Infoway.Messagebuilder.Datatype;
    using Ca.Infoway.Messagebuilder.Datatype.Impl;
    using Ca.Infoway.Messagebuilder.Domainvalue;
    using Ca.Infoway.Messagebuilder.Model;


    [Hl7PartTypeMappingAttribute(new string[] {"POIZ_MT030050CA.InformantionSourceRole"})]
    public class InformantionSourceRole : MessagePartBean {

        private CS classCode;

        public InformantionSourceRole() {
            this.classCode = new CSImpl();
        }
        /**
         * <summary>Information Source</summary>
         * 
         * <remarks><p>A coded value denoting a patient, patient's 
         * agent, or a provider as the source of the recorded 
         * immunization information.</p> <p>Allows for the explicit 
         * identification of the source of the recorded 
         * information.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"classCode"})]
        public x_InformationSource ClassCode {
            get { return (x_InformationSource) this.classCode.Value; }
            set { this.classCode.Value = value; }
        }

    }

}