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
namespace Ca.Infoway.Messagebuilder.Model.Ccda_r1_1.Numberofpressureulcersobservation {
    using Ca.Infoway.Messagebuilder;
    using Ca.Infoway.Messagebuilder.Annotation;
    using Ca.Infoway.Messagebuilder.Datatype;
    using Ca.Infoway.Messagebuilder.Datatype.Impl;
    using Ca.Infoway.Messagebuilder.Datatype.Lang;
    using Ca.Infoway.Messagebuilder.Model;
    using Ca.Infoway.Messagebuilder.Model.Ccda_r1_1.Basemodel;
    using Ca.Infoway.Messagebuilder.Model.Ccda_r1_1.Merged;
    using System;
    using System.Collections.Generic;


    [Hl7PartTypeMappingAttribute(new string[] {"NumberOfPressureUlcersObservation.Observation"})]
    public class Observation : MessagePartBean {

        private BL negationInd;
        private II typeId;
        private LIST<II, Identifier> templateId;
        private LIST<II, Identifier> id;
        private ST derivationExpr;
        private ED<EncapsulatedData> text;
        private IVL_TS effectiveTime;
        private CE_R2<Code> priorityCode;
        private IVL<INT, Interval<int?>> repeatNumber;
        private CS_R2<Code> languageCode;
        private INT value;
        private LIST<CE_R2<Code>, CodedTypeR2<Code>> interpretationCode;
        private LIST<CE_R2<Code>, CodedTypeR2<Code>> methodCode;
        private LIST<CD_R2<Code>, CodedTypeR2<Code>> targetSiteCode;
        private Ca.Infoway.Messagebuilder.Model.Ccda_r1_1.Basemodel.Subject subject;
        private IList<Ca.Infoway.Messagebuilder.Model.Ccda_r1_1.Merged.Specimen> specimen;
        private IList<Ca.Infoway.Messagebuilder.Model.Ccda_r1_1.Merged.Performer2_1> performer;
        private Ca.Infoway.Messagebuilder.Model.Ccda_r1_1.Merged.Author_1 author;
        private IList<Ca.Infoway.Messagebuilder.Model.Ccda_r1_1.Merged.Informant12> informant;
        private IList<Ca.Infoway.Messagebuilder.Model.Ccda_r1_1.Merged.Participant2_2> participant;
        private Ca.Infoway.Messagebuilder.Model.Ccda_r1_1.Merged.EntryRelationship_4 entryRelationship;
        private IList<Ca.Infoway.Messagebuilder.Model.Ccda_r1_1.Basemodel.Reference> reference;
        private IList<Ca.Infoway.Messagebuilder.Model.Ccda_r1_1.Basemodel.Precondition> precondition;
        private IList<Ca.Infoway.Messagebuilder.Model.Ccda_r1_1.Merged.ReferenceRange> referenceRange;

        public Observation() {
            this.negationInd = new BLImpl();
            this.typeId = new IIImpl();
            this.templateId = new LISTImpl<II, Identifier>(typeof(IIImpl));
            this.id = new LISTImpl<II, Identifier>(typeof(IIImpl));
            this.derivationExpr = new STImpl();
            this.text = new EDImpl<EncapsulatedData>();
            this.effectiveTime = new IVL_TSImpl();
            this.priorityCode = new CE_R2Impl<Code>();
            this.repeatNumber = new IVLImpl<INT, Interval<int?>>();
            this.languageCode = new CS_R2Impl<Code>();
            this.value = new INTImpl();
            this.interpretationCode = new LISTImpl<CE_R2<Code>, CodedTypeR2<Code>>(typeof(CE_R2Impl<Code>));
            this.methodCode = new LISTImpl<CE_R2<Code>, CodedTypeR2<Code>>(typeof(CE_R2Impl<Code>));
            this.targetSiteCode = new LISTImpl<CD_R2<Code>, CodedTypeR2<Code>>(typeof(CD_R2Impl<Code>));
            this.specimen = new List<Ca.Infoway.Messagebuilder.Model.Ccda_r1_1.Merged.Specimen>();
            this.performer = new List<Ca.Infoway.Messagebuilder.Model.Ccda_r1_1.Merged.Performer2_1>();
            this.informant = new List<Ca.Infoway.Messagebuilder.Model.Ccda_r1_1.Merged.Informant12>();
            this.participant = new List<Ca.Infoway.Messagebuilder.Model.Ccda_r1_1.Merged.Participant2_2>();
            this.reference = new List<Ca.Infoway.Messagebuilder.Model.Ccda_r1_1.Basemodel.Reference>();
            this.precondition = new List<Ca.Infoway.Messagebuilder.Model.Ccda_r1_1.Basemodel.Precondition>();
            this.referenceRange = new List<Ca.Infoway.Messagebuilder.Model.Ccda_r1_1.Merged.ReferenceRange>();
        }
        /**
         * <summary>Relationship: 
         * NumberOfPressureUlcersObservation.Observation.negationInd</summary>
         * 
         * <remarks>Conformance/Cardinality: OPTIONAL (0-1)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"negationInd"})]
        public bool? NegationInd {
            get { return this.negationInd.Value; }
            set { this.negationInd.Value = value; }
        }

        /**
         * <summary>Relationship: 
         * NumberOfPressureUlcersObservation.Observation.typeId</summary>
         * 
         * <remarks>Conformance/Cardinality: OPTIONAL (0-1)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"typeId"})]
        public Identifier TypeId {
            get { return this.typeId.Value; }
            set { this.typeId.Value = value; }
        }

        /**
         * <summary>Relationship: 
         * NumberOfPressureUlcersObservation.Observation.templateId</summary>
         * 
         * <remarks>Conformance/Cardinality: MANDATORY (*)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"templateId"})]
        public IList<Identifier> TemplateId {
            get { return this.templateId.RawList(); }
        }

        /**
         * <summary>Relationship: 
         * NumberOfPressureUlcersObservation.Observation.id</summary>
         * 
         * <remarks>Conformance/Cardinality: POPULATED (*)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"id"})]
        public IList<Identifier> Id {
            get { return this.id.RawList(); }
        }

        /**
         * <summary>Relationship: 
         * NumberOfPressureUlcersObservation.Observation.derivationExpr</summary>
         * 
         * <remarks>Conformance/Cardinality: OPTIONAL (0-1)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"derivationExpr"})]
        public String DerivationExpr {
            get { return this.derivationExpr.Value; }
            set { this.derivationExpr.Value = value; }
        }

        /**
         * <summary>Relationship: 
         * NumberOfPressureUlcersObservation.Observation.text</summary>
         * 
         * <remarks>Conformance/Cardinality: OPTIONAL (0-1)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"text"})]
        public EncapsulatedData Text {
            get { return this.text.Value; }
            set { this.text.Value = value; }
        }

        /**
         * <summary>Relationship: 
         * NumberOfPressureUlcersObservation.Observation.effectiveTime</summary>
         * 
         * <remarks>Conformance/Cardinality: POPULATED (1)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"effectiveTime"})]
        public DateInterval EffectiveTime {
            get { return this.effectiveTime.Value; }
            set { this.effectiveTime.Value = value; }
        }

        /**
         * <summary>Relationship: 
         * NumberOfPressureUlcersObservation.Observation.priorityCode</summary>
         * 
         * <remarks>Conformance/Cardinality: OPTIONAL (0-1)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"priorityCode"})]
        public CodedTypeR2<Code> PriorityCode {
            get { return (CodedTypeR2<Code>) this.priorityCode.Value; }
            set { this.priorityCode.Value = value; }
        }

        /**
         * <summary>Relationship: 
         * NumberOfPressureUlcersObservation.Observation.repeatNumber</summary>
         * 
         * <remarks>Conformance/Cardinality: OPTIONAL (0-1)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"repeatNumber"})]
        public Interval<int?> RepeatNumber {
            get { return this.repeatNumber.Value; }
            set { this.repeatNumber.Value = value; }
        }

        /**
         * <summary>Relationship: 
         * NumberOfPressureUlcersObservation.Observation.languageCode</summary>
         * 
         * <remarks>Conformance/Cardinality: OPTIONAL (0-1)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"languageCode"})]
        public CodedTypeR2<Code> LanguageCode {
            get { return (CodedTypeR2<Code>) this.languageCode.Value; }
            set { this.languageCode.Value = value; }
        }

        /**
         * <summary>Relationship: 
         * NumberOfPressureUlcersObservation.Observation.value</summary>
         * 
         * <remarks>Conformance/Cardinality: POPULATED (1)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"value"})]
        public int? Value {
            get { return this.value.Value; }
            set { this.value.Value = value; }
        }

        /**
         * <summary>Relationship: 
         * NumberOfPressureUlcersObservation.Observation.interpretationCode</summary>
         * 
         * <remarks>Conformance/Cardinality: OPTIONAL (0-*)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"interpretationCode"})]
        public IList<CodedTypeR2<Code>> InterpretationCode {
            get { return this.interpretationCode.RawList<CodedTypeR2<Code>>(); }
        }

        /**
         * <summary>Relationship: 
         * NumberOfPressureUlcersObservation.Observation.methodCode</summary>
         * 
         * <remarks>Conformance/Cardinality: OPTIONAL (0-*)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"methodCode"})]
        public IList<CodedTypeR2<Code>> MethodCode {
            get { return this.methodCode.RawList<CodedTypeR2<Code>>(); }
        }

        /**
         * <summary>Relationship: 
         * NumberOfPressureUlcersObservation.Observation.targetSiteCode</summary>
         * 
         * <remarks>Conformance/Cardinality: OPTIONAL (0-*)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"targetSiteCode"})]
        public IList<CodedTypeR2<Code>> TargetSiteCode {
            get { return this.targetSiteCode.RawList<CodedTypeR2<Code>>(); }
        }

        /**
         * <summary>Relationship: 
         * NumberOfPressureUlcersObservation.Observation.subject</summary>
         * 
         * <remarks>Conformance/Cardinality: OPTIONAL (0-1)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"subject"})]
        public Ca.Infoway.Messagebuilder.Model.Ccda_r1_1.Basemodel.Subject Subject {
            get { return this.subject; }
            set { this.subject = value; }
        }

        /**
         * <summary>Relationship: 
         * NumberOfPressureUlcersObservation.Observation.specimen</summary>
         * 
         * <remarks>Conformance/Cardinality: OPTIONAL (0-*)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"specimen"})]
        public IList<Ca.Infoway.Messagebuilder.Model.Ccda_r1_1.Merged.Specimen> Specimen {
            get { return this.specimen; }
        }

        /**
         * <summary>Relationship: 
         * NumberOfPressureUlcersObservation.Observation.performer</summary>
         * 
         * <remarks>Conformance/Cardinality: OPTIONAL (0-*)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"performer"})]
        public IList<Ca.Infoway.Messagebuilder.Model.Ccda_r1_1.Merged.Performer2_1> Performer {
            get { return this.performer; }
        }

        /**
         * <summary>Relationship: 
         * NumberOfPressureUlcersObservation.Observation.author</summary>
         * 
         * <remarks>Conformance/Cardinality: OPTIONAL (0-1)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"author"})]
        public Ca.Infoway.Messagebuilder.Model.Ccda_r1_1.Merged.Author_1 Author {
            get { return this.author; }
            set { this.author = value; }
        }

        /**
         * <summary>Relationship: 
         * NumberOfPressureUlcersObservation.Observation.informant</summary>
         * 
         * <remarks>Conformance/Cardinality: OPTIONAL (0-*)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"informant"})]
        public IList<Ca.Infoway.Messagebuilder.Model.Ccda_r1_1.Merged.Informant12> Informant {
            get { return this.informant; }
        }

        /**
         * <summary>Relationship: 
         * NumberOfPressureUlcersObservation.Observation.participant</summary>
         * 
         * <remarks>Conformance/Cardinality: OPTIONAL (0-*)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"participant"})]
        public IList<Ca.Infoway.Messagebuilder.Model.Ccda_r1_1.Merged.Participant2_2> Participant {
            get { return this.participant; }
        }

        /**
         * <summary>Relationship: 
         * NumberOfPressureUlcersObservation.Observation.entryRelationship</summary>
         * 
         * <remarks>Conformance/Cardinality: POPULATED (1)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"entryRelationship"})]
        public Ca.Infoway.Messagebuilder.Model.Ccda_r1_1.Merged.EntryRelationship_4 EntryRelationship {
            get { return this.entryRelationship; }
            set { this.entryRelationship = value; }
        }

        /**
         * <summary>Relationship: 
         * NumberOfPressureUlcersObservation.Observation.reference</summary>
         * 
         * <remarks>Conformance/Cardinality: OPTIONAL (0-*)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"reference"})]
        public IList<Ca.Infoway.Messagebuilder.Model.Ccda_r1_1.Basemodel.Reference> Reference {
            get { return this.reference; }
        }

        /**
         * <summary>Relationship: 
         * NumberOfPressureUlcersObservation.Observation.precondition</summary>
         * 
         * <remarks>Conformance/Cardinality: OPTIONAL (0-*)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"precondition"})]
        public IList<Ca.Infoway.Messagebuilder.Model.Ccda_r1_1.Basemodel.Precondition> Precondition {
            get { return this.precondition; }
        }

        /**
         * <summary>Relationship: 
         * NumberOfPressureUlcersObservation.Observation.referenceRange</summary>
         * 
         * <remarks>Conformance/Cardinality: OPTIONAL (0-*)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"referenceRange"})]
        public IList<Ca.Infoway.Messagebuilder.Model.Ccda_r1_1.Merged.ReferenceRange> ReferenceRange {
            get { return this.referenceRange; }
        }

    }

}