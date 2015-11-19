/**
 * Copyright 2013 Canada Health Infoway, Inc.
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
 * Author:        $LastChangedBy: gng $
 * Last modified: $LastChangedDate: 2015-11-19 18:20:12 -0500 (Fri, 30 Jan 2015) $
 * Revision:      $LastChangedRevision: 9755 $
 */

/* This class was auto-generated by the message builder generator tools. */
namespace Ca.Infoway.Messagebuilder.Model.Ab_r02_04_03_shr.Common.Merged {
    using Ca.Infoway.Messagebuilder.Annotation;
    using Ca.Infoway.Messagebuilder.Datatype;
    using Ca.Infoway.Messagebuilder.Datatype.Impl;
    using Ca.Infoway.Messagebuilder.Model;
    using Ca.Infoway.Messagebuilder.Model.Ab_r02_04_03_shr.Domainvalue;


    /**
     * <summary>Business Name: ToBeSentTo</summary>
     * 
     * <remarks>RCMR_MT000210AB.Participant: to be sent to 
     * <p>Provides context for the document. In the future, may 
     * also allow for automated routing of documents to their 
     * intended recipients.</p> <p>Identifies the people and 
     * facilities that the document was written for or is intended 
     * to be sent to.</p> RCMR_MT000002AB.Participant: to be sent 
     * to <p>Provides context for the document. In the future, may 
     * also allow for automated routing of documents to their 
     * intended recipients.</p> <p>Identifies the people and 
     * facilities that the document was written for or is intended 
     * to be sent to.</p> RCMR_MT000220AB.Participant: to be sent 
     * to <p>Provides context for the document. In the future, may 
     * also allow for automated routing of documents to their 
     * intended recipients.</p> <p>Identifies the people and 
     * facilities that the document was written for or is intended 
     * to be sent to.</p></remarks>
     */
    [Hl7PartTypeMappingAttribute(new string[] {"RCMR_MT000002AB.Participant","RCMR_MT000210AB.Participant","RCMR_MT000220AB.Participant"})]
    public class ToBeSentTo : MessagePartBean {

        private CS typeCode;
        private Ca.Infoway.Messagebuilder.Model.Ab_r02_04_03_shr.Common.Merged.IntendedRecipient intendedRecipient;

        public ToBeSentTo() {
            this.typeCode = new CSImpl();
        }
        /**
         * <summary>Un-merged Business Name: (no business name 
         * specified)</summary>
         * 
         * <remarks>Relationship: RCMR_MT000210AB.Participant.typeCode 
         * Conformance/Cardinality: MANDATORY (1) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * RCMR_MT000002AB.Participant.typeCode 
         * Conformance/Cardinality: MANDATORY (1) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * RCMR_MT000220AB.Participant.typeCode 
         * Conformance/Cardinality: MANDATORY (1)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"typeCode"})]
        public x_InformationRecipient TypeCode {
            get { return (x_InformationRecipient) this.typeCode.Value; }
            set { this.typeCode.Value = value; }
        }

        /**
         * <summary>Un-merged Business Name: (no business name 
         * specified)</summary>
         * 
         * <remarks>Relationship: 
         * RCMR_MT000210AB.Participant.intendedRecipient 
         * Conformance/Cardinality: REQUIRED (1) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * RCMR_MT000002AB.Participant.intendedRecipient 
         * Conformance/Cardinality: REQUIRED (1) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * RCMR_MT000220AB.Participant.intendedRecipient 
         * Conformance/Cardinality: REQUIRED (1)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"intendedRecipient"})]
        public Ca.Infoway.Messagebuilder.Model.Ab_r02_04_03_shr.Common.Merged.IntendedRecipient IntendedRecipient {
            get { return this.intendedRecipient; }
            set { this.intendedRecipient = value; }
        }

    }

}