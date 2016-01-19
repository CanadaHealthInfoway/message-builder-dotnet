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
namespace Ca.Infoway.Messagebuilder.Model.Ccda_r1_1.Policyactivity {
    using Ca.Infoway.Messagebuilder.Annotation;
    using Ca.Infoway.Messagebuilder.Datatype;
    using Ca.Infoway.Messagebuilder.Datatype.Impl;
    using Ca.Infoway.Messagebuilder.Datatype.Lang;
    using Ca.Infoway.Messagebuilder.Model;


    [Hl7PartTypeMappingAttribute(new string[] {"PolicyActivity.PayerPerformerPerformer2"})]
    public class PayerPerformerPerformer2 : MessagePartBean, Ca.Infoway.Messagebuilder.Model.Ccda_r1_1.Policyactivity.IPerformer2Choice {

        private II templateId;
        private Ca.Infoway.Messagebuilder.Model.Ccda_r1_1.Policyactivity.PayerPerformerAssignedEntity assignedEntity;

        public PayerPerformerPerformer2() {
            this.templateId = new IIImpl();
        }
        /**
         * <summary>Relationship: 
         * PolicyActivity.PayerPerformerPerformer2.templateId</summary>
         * 
         * <remarks>Conformance/Cardinality: MANDATORY (1)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"templateId"})]
        public Identifier TemplateId {
            get { return this.templateId.Value; }
            set { this.templateId.Value = value; }
        }

        /**
         * <summary>Relationship: 
         * PolicyActivity.PayerPerformerPerformer2.assignedEntity</summary>
         * 
         * <remarks>Conformance/Cardinality: POPULATED (1)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"assignedEntity"})]
        public Ca.Infoway.Messagebuilder.Model.Ccda_r1_1.Policyactivity.PayerPerformerAssignedEntity AssignedEntity {
            get { return this.assignedEntity; }
            set { this.assignedEntity = value; }
        }

    }

}