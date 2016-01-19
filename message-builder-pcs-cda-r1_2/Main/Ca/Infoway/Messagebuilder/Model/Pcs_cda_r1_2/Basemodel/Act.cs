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
namespace Ca.Infoway.Messagebuilder.Model.Pcs_cda_r1_2.Basemodel {
    using Ca.Infoway.Messagebuilder;
    using Ca.Infoway.Messagebuilder.Annotation;
    using Ca.Infoway.Messagebuilder.Datatype;
    using Ca.Infoway.Messagebuilder.Datatype.Impl;
    using Ca.Infoway.Messagebuilder.Datatype.Lang;
    using Ca.Infoway.Messagebuilder.Model;
    using Ca.Infoway.Messagebuilder.Model.Pcs_cda_r1_2.Domainvalue;
    using Ca.Infoway.Messagebuilder.Model.Pcs_cda_r1_2.Merged;
    using System;
    using System.Collections.Generic;


    [Hl7PartTypeMappingAttribute(new string[] {"BaseModel.Act"})]
    public class Act : MessagePartBean, Ca.Infoway.Messagebuilder.Model.Pcs_cda_r1_2.Basemodel.IEntryChoice, Ca.Infoway.Messagebuilder.Model.Pcs_cda_r1_2.Basemodel.IComponent4Choice, Ca.Infoway.Messagebuilder.Model.Pcs_cda_r1_2.Basemodel.IEntryRelationshipChoice {

        private CS classCode;
        private CS moodCode;
        private BL negationInd;
        private II typeId;
        private LIST<II, Identifier> templateId;
        private LIST<II, Identifier> id;
        private CD code;
        private ED<EncapsulatedData> text;
        private CS statusCode;
        private IVLTSCDAR1 effectiveTime;
        private CE priorityCode;
        private CS languageCode;
        private Ca.Infoway.Messagebuilder.Model.Pcs_cda_r1_2.Basemodel.Subject subject;
        private IList<Ca.Infoway.Messagebuilder.Model.Pcs_cda_r1_2.Basemodel.Specimen> specimen;
        private IList<Ca.Infoway.Messagebuilder.Model.Pcs_cda_r1_2.Merged.Performer2> performer;
        private IList<Ca.Infoway.Messagebuilder.Model.Pcs_cda_r1_2.Basemodel.Author> author;
        private IList<Ca.Infoway.Messagebuilder.Model.Pcs_cda_r1_2.Merged.Informant12> informant;
        private IList<Ca.Infoway.Messagebuilder.Model.Pcs_cda_r1_2.Merged.Participant2> participant;
        private IList<Ca.Infoway.Messagebuilder.Model.Pcs_cda_r1_2.Basemodel.EntryRelationship> entryRelationship;
        private IList<Ca.Infoway.Messagebuilder.Model.Pcs_cda_r1_2.Basemodel.Reference> reference;
        private IList<Ca.Infoway.Messagebuilder.Model.Pcs_cda_r1_2.Basemodel.Precondition> precondition;

        public Act() {
            this.classCode = new CSImpl();
            this.moodCode = new CSImpl();
            this.negationInd = new BLImpl();
            this.typeId = new IIImpl();
            this.templateId = new LISTImpl<II, Identifier>(typeof(IIImpl));
            this.id = new LISTImpl<II, Identifier>(typeof(IIImpl));
            this.code = new CDImpl();
            this.text = new EDImpl<EncapsulatedData>();
            this.statusCode = new CSImpl();
            this.effectiveTime = new IVLTSCDAR1Impl();
            this.priorityCode = new CEImpl();
            this.languageCode = new CSImpl();
            this.specimen = new List<Ca.Infoway.Messagebuilder.Model.Pcs_cda_r1_2.Basemodel.Specimen>();
            this.performer = new List<Ca.Infoway.Messagebuilder.Model.Pcs_cda_r1_2.Merged.Performer2>();
            this.author = new List<Ca.Infoway.Messagebuilder.Model.Pcs_cda_r1_2.Basemodel.Author>();
            this.informant = new List<Ca.Infoway.Messagebuilder.Model.Pcs_cda_r1_2.Merged.Informant12>();
            this.participant = new List<Ca.Infoway.Messagebuilder.Model.Pcs_cda_r1_2.Merged.Participant2>();
            this.entryRelationship = new List<Ca.Infoway.Messagebuilder.Model.Pcs_cda_r1_2.Basemodel.EntryRelationship>();
            this.reference = new List<Ca.Infoway.Messagebuilder.Model.Pcs_cda_r1_2.Basemodel.Reference>();
            this.precondition = new List<Ca.Infoway.Messagebuilder.Model.Pcs_cda_r1_2.Basemodel.Precondition>();
        }
        /**
         * <summary>Relationship: BaseModel.Act.classCode</summary>
         * 
         * <remarks>Conformance/Cardinality: MANDATORY (1)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"classCode"})]
        public x_ActClassDocumentEntryAct ClassCode {
            get { return (x_ActClassDocumentEntryAct) this.classCode.Value; }
            set { this.classCode.Value = value; }
        }

        /**
         * <summary>Relationship: BaseModel.Act.moodCode</summary>
         * 
         * <remarks>Conformance/Cardinality: MANDATORY (1)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"moodCode"})]
        public x_DocumentActMood MoodCode {
            get { return (x_DocumentActMood) this.moodCode.Value; }
            set { this.moodCode.Value = value; }
        }

        /**
         * <summary>Relationship: BaseModel.Act.negationInd</summary>
         * 
         * <remarks>Conformance/Cardinality: OPTIONAL (0-1)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"negationInd"})]
        public bool? NegationInd {
            get { return this.negationInd.Value; }
            set { this.negationInd.Value = value; }
        }

        /**
         * <summary>Relationship: BaseModel.Act.typeId</summary>
         * 
         * <remarks>Conformance/Cardinality: OPTIONAL (0-1)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"typeId"})]
        public Identifier TypeId {
            get { return this.typeId.Value; }
            set { this.typeId.Value = value; }
        }

        /**
         * <summary>Relationship: BaseModel.Act.templateId</summary>
         * 
         * <remarks>Conformance/Cardinality: OPTIONAL (0-*)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"templateId"})]
        public IList<Identifier> TemplateId {
            get { return this.templateId.RawList(); }
        }

        /**
         * <summary>Relationship: BaseModel.Act.id</summary>
         * 
         * <remarks>Conformance/Cardinality: OPTIONAL (0-*)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"id"})]
        public IList<Identifier> Id {
            get { return this.id.RawList(); }
        }

        /**
         * <summary>Relationship: BaseModel.Act.code</summary>
         * 
         * <remarks>Conformance/Cardinality: POPULATED (1)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"code"})]
        public Code Code {
            get { return (Code) this.code.Value; }
            set { this.code.Value = value; }
        }

        /**
         * <summary>Relationship: BaseModel.Act.text</summary>
         * 
         * <remarks>Conformance/Cardinality: OPTIONAL (0-1)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"text"})]
        public EncapsulatedData Text {
            get { return this.text.Value; }
            set { this.text.Value = value; }
        }

        /**
         * <summary>Relationship: BaseModel.Act.statusCode</summary>
         * 
         * <remarks>Conformance/Cardinality: OPTIONAL (0-1)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"statusCode"})]
        public Code StatusCode {
            get { return (Code) this.statusCode.Value; }
            set { this.statusCode.Value = value; }
        }

        /**
         * <summary>Relationship: BaseModel.Act.effectiveTime</summary>
         * 
         * <remarks>Conformance/Cardinality: OPTIONAL (0-1)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"effectiveTime"})]
        public DateInterval EffectiveTime {
            get { return this.effectiveTime.Value; }
            set { this.effectiveTime.Value = value; }
        }

        /**
         * <summary>Relationship: BaseModel.Act.priorityCode</summary>
         * 
         * <remarks>Conformance/Cardinality: OPTIONAL (0-1)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"priorityCode"})]
        public Code PriorityCode {
            get { return (Code) this.priorityCode.Value; }
            set { this.priorityCode.Value = value; }
        }

        /**
         * <summary>Relationship: BaseModel.Act.languageCode</summary>
         * 
         * <remarks>Conformance/Cardinality: OPTIONAL (0-1)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"languageCode"})]
        public Code LanguageCode {
            get { return (Code) this.languageCode.Value; }
            set { this.languageCode.Value = value; }
        }

        /**
         * <summary>Relationship: BaseModel.Act.subject</summary>
         * 
         * <remarks>Conformance/Cardinality: OPTIONAL (0-1)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"subject"})]
        public Ca.Infoway.Messagebuilder.Model.Pcs_cda_r1_2.Basemodel.Subject Subject {
            get { return this.subject; }
            set { this.subject = value; }
        }

        /**
         * <summary>Relationship: BaseModel.Act.specimen</summary>
         * 
         * <remarks>Conformance/Cardinality: OPTIONAL (0-*)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"specimen"})]
        public IList<Ca.Infoway.Messagebuilder.Model.Pcs_cda_r1_2.Basemodel.Specimen> Specimen {
            get { return this.specimen; }
        }

        /**
         * <summary>Relationship: BaseModel.Act.performer</summary>
         * 
         * <remarks>Conformance/Cardinality: OPTIONAL (0-*)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"performer"})]
        public IList<Ca.Infoway.Messagebuilder.Model.Pcs_cda_r1_2.Merged.Performer2> Performer {
            get { return this.performer; }
        }

        /**
         * <summary>Relationship: BaseModel.Act.author</summary>
         * 
         * <remarks>Conformance/Cardinality: OPTIONAL (0-*)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"author"})]
        public IList<Ca.Infoway.Messagebuilder.Model.Pcs_cda_r1_2.Basemodel.Author> Author {
            get { return this.author; }
        }

        /**
         * <summary>Relationship: BaseModel.Act.informant</summary>
         * 
         * <remarks>Conformance/Cardinality: OPTIONAL (0-*)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"informant"})]
        public IList<Ca.Infoway.Messagebuilder.Model.Pcs_cda_r1_2.Merged.Informant12> Informant {
            get { return this.informant; }
        }

        /**
         * <summary>Relationship: BaseModel.Act.participant</summary>
         * 
         * <remarks>Conformance/Cardinality: OPTIONAL (0-*)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"participant"})]
        public IList<Ca.Infoway.Messagebuilder.Model.Pcs_cda_r1_2.Merged.Participant2> Participant {
            get { return this.participant; }
        }

        /**
         * <summary>Relationship: BaseModel.Act.entryRelationship</summary>
         * 
         * <remarks>Conformance/Cardinality: OPTIONAL (0-*)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"entryRelationship"})]
        public IList<Ca.Infoway.Messagebuilder.Model.Pcs_cda_r1_2.Basemodel.EntryRelationship> EntryRelationship {
            get { return this.entryRelationship; }
        }

        /**
         * <summary>Relationship: BaseModel.Act.reference</summary>
         * 
         * <remarks>Conformance/Cardinality: OPTIONAL (0-*)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"reference"})]
        public IList<Ca.Infoway.Messagebuilder.Model.Pcs_cda_r1_2.Basemodel.Reference> Reference {
            get { return this.reference; }
        }

        /**
         * <summary>Relationship: BaseModel.Act.precondition</summary>
         * 
         * <remarks>Conformance/Cardinality: OPTIONAL (0-*)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"precondition"})]
        public IList<Ca.Infoway.Messagebuilder.Model.Pcs_cda_r1_2.Basemodel.Precondition> Precondition {
            get { return this.precondition; }
        }

    }

}