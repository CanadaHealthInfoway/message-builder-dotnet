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
namespace Ca.Infoway.Messagebuilder.Model.Ccda_pcs_r1_1.Basemodel {
    using Ca.Infoway.Messagebuilder.Annotation;
    using Ca.Infoway.Messagebuilder.Datatype;
    using Ca.Infoway.Messagebuilder.Datatype.Impl;
    using Ca.Infoway.Messagebuilder.Datatype.Lang;
    using Ca.Infoway.Messagebuilder.Model;
    using Ca.Infoway.Messagebuilder.Model.Ccda_pcs_r1_1.Domainvalue;
    using System;
    using System.Collections.Generic;


    [Hl7PartTypeMappingAttribute(new string[] {"BaseModel.Reference"})]
    public class Reference : MessagePartBean, Ca.Infoway.Messagebuilder.Model.Ccda_pcs_r1_1.Advancedirectiveobservation.IReferenceChoice {

        private CS typeCode;
        private II typeId;
        private LIST<II, Identifier> templateId;
        private BL seperatableInd;
        private Ca.Infoway.Messagebuilder.Model.Ccda_pcs_r1_1.Basemodel.IReferenceChoice referenceChoice;

        public Reference() {
            this.typeCode = new CSImpl();
            this.typeId = new IIImpl();
            this.templateId = new LISTImpl<II, Identifier>(typeof(IIImpl));
            this.seperatableInd = new BLImpl();
        }
        /**
         * <summary>Relationship: BaseModel.Reference.typeCode</summary>
         * 
         * <remarks>Conformance/Cardinality: MANDATORY (1)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"typeCode"})]
        public Ca.Infoway.Messagebuilder.Model.Ccda_pcs_r1_1.Domainvalue.x_ActRelationshipExternalReference TypeCode {
            get { return (Ca.Infoway.Messagebuilder.Model.Ccda_pcs_r1_1.Domainvalue.x_ActRelationshipExternalReference) this.typeCode.Value; }
            set { this.typeCode.Value = value; }
        }

        /**
         * <summary>Relationship: BaseModel.Reference.typeId</summary>
         * 
         * <remarks>Conformance/Cardinality: OPTIONAL (0-1)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"typeId"})]
        public Identifier TypeId {
            get { return this.typeId.Value; }
            set { this.typeId.Value = value; }
        }

        /**
         * <summary>Relationship: BaseModel.Reference.templateId</summary>
         * 
         * <remarks>Conformance/Cardinality: OPTIONAL (0-*)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"templateId"})]
        public IList<Identifier> TemplateId {
            get { return this.templateId.RawList(); }
        }

        /**
         * <summary>Relationship: BaseModel.Reference.seperatableInd</summary>
         * 
         * <remarks>Conformance/Cardinality: OPTIONAL (0-1)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"seperatableInd"})]
        public bool? SeperatableInd {
            get { return this.seperatableInd.Value; }
            set { this.seperatableInd.Value = value; }
        }

        /**
         * <summary>Relationship: BaseModel.Reference.referenceChoice</summary>
         * 
         * <remarks>Conformance/Cardinality: MANDATORY (1)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"referenceChoice"})]
        public Ca.Infoway.Messagebuilder.Model.Ccda_pcs_r1_1.Basemodel.IReferenceChoice ReferenceChoice {
            get { return this.referenceChoice; }
            set { this.referenceChoice = value; }
        }

        public Ca.Infoway.Messagebuilder.Model.Ccda_pcs_r1_1.Basemodel.ExternalAct ReferenceChoiceAsExternalAct {
            get { return this.referenceChoice is Ca.Infoway.Messagebuilder.Model.Ccda_pcs_r1_1.Basemodel.ExternalAct ? (Ca.Infoway.Messagebuilder.Model.Ccda_pcs_r1_1.Basemodel.ExternalAct) this.referenceChoice : (Ca.Infoway.Messagebuilder.Model.Ccda_pcs_r1_1.Basemodel.ExternalAct) null; }
        }
        public bool HasReferenceChoiceAsExternalAct() {
            return (this.referenceChoice is Ca.Infoway.Messagebuilder.Model.Ccda_pcs_r1_1.Basemodel.ExternalAct);
        }

        public Ca.Infoway.Messagebuilder.Model.Ccda_pcs_r1_1.Basemodel.ExternalObservation ReferenceChoiceAsExternalObservation {
            get { return this.referenceChoice is Ca.Infoway.Messagebuilder.Model.Ccda_pcs_r1_1.Basemodel.ExternalObservation ? (Ca.Infoway.Messagebuilder.Model.Ccda_pcs_r1_1.Basemodel.ExternalObservation) this.referenceChoice : (Ca.Infoway.Messagebuilder.Model.Ccda_pcs_r1_1.Basemodel.ExternalObservation) null; }
        }
        public bool HasReferenceChoiceAsExternalObservation() {
            return (this.referenceChoice is Ca.Infoway.Messagebuilder.Model.Ccda_pcs_r1_1.Basemodel.ExternalObservation);
        }

        public Ca.Infoway.Messagebuilder.Model.Ccda_pcs_r1_1.Basemodel.ExternalProcedure ReferenceChoiceAsExternalProcedure {
            get { return this.referenceChoice is Ca.Infoway.Messagebuilder.Model.Ccda_pcs_r1_1.Basemodel.ExternalProcedure ? (Ca.Infoway.Messagebuilder.Model.Ccda_pcs_r1_1.Basemodel.ExternalProcedure) this.referenceChoice : (Ca.Infoway.Messagebuilder.Model.Ccda_pcs_r1_1.Basemodel.ExternalProcedure) null; }
        }
        public bool HasReferenceChoiceAsExternalProcedure() {
            return (this.referenceChoice is Ca.Infoway.Messagebuilder.Model.Ccda_pcs_r1_1.Basemodel.ExternalProcedure);
        }

        public Ca.Infoway.Messagebuilder.Model.Ccda_pcs_r1_1.Basemodel.ExternalDocument ReferenceChoiceAsExternalDocument {
            get { return this.referenceChoice is Ca.Infoway.Messagebuilder.Model.Ccda_pcs_r1_1.Basemodel.ExternalDocument ? (Ca.Infoway.Messagebuilder.Model.Ccda_pcs_r1_1.Basemodel.ExternalDocument) this.referenceChoice : (Ca.Infoway.Messagebuilder.Model.Ccda_pcs_r1_1.Basemodel.ExternalDocument) null; }
        }
        public bool HasReferenceChoiceAsExternalDocument() {
            return (this.referenceChoice is Ca.Infoway.Messagebuilder.Model.Ccda_pcs_r1_1.Basemodel.ExternalDocument);
        }

    }

}