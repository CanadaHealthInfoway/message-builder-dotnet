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
namespace Ca.Infoway.Messagebuilder.Model.Ccda_r1_1.Merged {
    using Ca.Infoway.Messagebuilder.Annotation;
    using Ca.Infoway.Messagebuilder.Datatype;
    using Ca.Infoway.Messagebuilder.Datatype.Impl;
    using Ca.Infoway.Messagebuilder.Datatype.Lang;
    using Ca.Infoway.Messagebuilder.Model;
    using Ca.Infoway.Messagebuilder.Model.Ccda_r1_1.Basemodel;
    using Ca.Infoway.Messagebuilder.Model.Ccda_r1_1.Boundaryobservation;
    using Ca.Infoway.Messagebuilder.Model.Ccda_r1_1.Domainvalue;
    using Ca.Infoway.Messagebuilder.Model.Ccda_r1_1.Instructions;
    using System;
    using System.Collections.Generic;


    [Hl7PartTypeMappingAttribute(new string[] {"BaseModel.EntryRelationship","MedicationSupplyOrder.EntryRelationship","ReferencedFramesObservation.EntryRelationship"})]
    public class EntryRelationship_2 : MessagePartBean, Ca.Infoway.Messagebuilder.Model.Ccda_r1_1.Reactionobservation.IEntryRelationshipChoice, Ca.Infoway.Messagebuilder.Model.Ccda_r1_1.Immunizationactivity.IEntryRelationshipChoice, Ca.Infoway.Messagebuilder.Model.Ccda_r1_1.Allergyproblemact.IEntryRelationshipChoice, Ca.Infoway.Messagebuilder.Model.Ccda_r1_1.Medicationdispense.IEntryRelationshipChoice, Ca.Infoway.Messagebuilder.Model.Ccda_r1_1.Procedureactivityobservation.IEntryRelationshipChoice, Ca.Infoway.Messagebuilder.Model.Ccda_r1_1.Studyact.IEntryRelationshipChoice, Ca.Infoway.Messagebuilder.Model.Ccda_r1_1.Problemobservation.IEntryRelationshipChoice, Ca.Infoway.Messagebuilder.Model.Ccda_r1_1.Coverageactivity.IEntryRelationshipChoice, Ca.Infoway.Messagebuilder.Model.Ccda_r1_1.Familyhistoryobservation.IEntryRelationshipChoice, Ca.Infoway.Messagebuilder.Model.Ccda_r1_1.Encounteractivities.IEntryRelationshipChoice, Ca.Infoway.Messagebuilder.Model.Ccda_r1_1.Merged.IEntryRelationshipChoice_1, Ca.Infoway.Messagebuilder.Model.Ccda_r1_1.Merged.IEntryRelationshipChoice_6, Ca.Infoway.Messagebuilder.Model.Ccda_r1_1.Policyactivity.IEntryRelationshipChoice, Ca.Infoway.Messagebuilder.Model.Ccda_r1_1.Merged.IEntryRelationshipChoice_4, Ca.Infoway.Messagebuilder.Model.Ccda_r1_1.Merged.IEntryRelationshipChoice_3, Ca.Infoway.Messagebuilder.Model.Ccda_r1_1.Assessmentscaleobservation.IEntryRelationshipChoice, Ca.Infoway.Messagebuilder.Model.Ccda_r1_1.Pressureulcerobservation.IEntryRelationshipChoice, Ca.Infoway.Messagebuilder.Model.Ccda_r1_1.Merged.IEntryRelationshipChoice_5, Ca.Infoway.Messagebuilder.Model.Ccda_r1_1.Sopinstanceobservation.IEntryRelationshipChoice, Ca.Infoway.Messagebuilder.Model.Ccda_r1_1.Merged.IEntryRelationshipChoice_7, Ca.Infoway.Messagebuilder.Model.Ccda_r1_1.Medicationactivity.IEntryRelationshipChoice, Ca.Infoway.Messagebuilder.Model.Ccda_r1_1.Pregnancyobservation.IEntryRelationshipChoice, Ca.Infoway.Messagebuilder.Model.Ccda_r1_1.Merged.IEntryRelationshipChoice_2, Ca.Infoway.Messagebuilder.Model.Ccda_r1_1.Authorizationactivity.IEntryRelationshipChoice {

        private BL inversionInd;
        private BL contextConductionInd;
        private BL negationInd;
        private II typeId;
        private LIST<II, Identifier> templateId;
        private INT sequenceNumber;
        private BL seperatableInd;
        private Ca.Infoway.Messagebuilder.Model.Ccda_r1_1.Boundaryobservation.Observation observation;
        private Ca.Infoway.Messagebuilder.Model.Ccda_r1_1.Instructions.Act act;
        private CS_R2<Ca.Infoway.Messagebuilder.Model.Ccda_r1_1.Domainvalue.x_ActRelationshipEntryRelationship> typeCode;
        private Ca.Infoway.Messagebuilder.Model.Ccda_r1_1.Basemodel.IEntryRelationshipChoice entryRelationshipChoice;

        public EntryRelationship_2() {
            this.inversionInd = new BLImpl();
            this.contextConductionInd = new BLImpl();
            this.negationInd = new BLImpl();
            this.typeId = new IIImpl();
            this.templateId = new LISTImpl<II, Identifier>(typeof(IIImpl));
            this.sequenceNumber = new INTImpl();
            this.seperatableInd = new BLImpl();
            this.typeCode = new CS_R2Impl<Ca.Infoway.Messagebuilder.Model.Ccda_r1_1.Domainvalue.x_ActRelationshipEntryRelationship>();
        }
        /**
         * <summary>Un-merged Business Name: (no business name 
         * specified)</summary>
         * 
         * <remarks>Relationship: 
         * ReferencedFramesObservation.EntryRelationship.inversionInd 
         * Conformance/Cardinality: OPTIONAL (0-1) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * BaseModel.EntryRelationship.inversionInd 
         * Conformance/Cardinality: OPTIONAL (0-1)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"inversionInd"})]
        public bool? InversionInd {
            get { return this.inversionInd.Value; }
            set { this.inversionInd.Value = value; }
        }

        /**
         * <summary>Un-merged Business Name: (no business name 
         * specified)</summary>
         * 
         * <remarks>Relationship: 
         * ReferencedFramesObservation.EntryRelationship.contextConductionInd 
         * Conformance/Cardinality: OPTIONAL (0-1) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * MedicationSupplyOrder.EntryRelationship.contextConductionInd 
         * Conformance/Cardinality: OPTIONAL (0-1) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * BaseModel.EntryRelationship.contextConductionInd 
         * Conformance/Cardinality: OPTIONAL (0-1)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"contextConductionInd"})]
        public bool? ContextConductionInd {
            get { return this.contextConductionInd.Value; }
            set { this.contextConductionInd.Value = value; }
        }

        /**
         * <summary>Un-merged Business Name: (no business name 
         * specified)</summary>
         * 
         * <remarks>Relationship: 
         * ReferencedFramesObservation.EntryRelationship.negationInd 
         * Conformance/Cardinality: OPTIONAL (0-1) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * MedicationSupplyOrder.EntryRelationship.negationInd 
         * Conformance/Cardinality: OPTIONAL (0-1) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * BaseModel.EntryRelationship.negationInd 
         * Conformance/Cardinality: OPTIONAL (0-1)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"negationInd"})]
        public bool? NegationInd {
            get { return this.negationInd.Value; }
            set { this.negationInd.Value = value; }
        }

        /**
         * <summary>Un-merged Business Name: (no business name 
         * specified)</summary>
         * 
         * <remarks>Relationship: 
         * ReferencedFramesObservation.EntryRelationship.typeId 
         * Conformance/Cardinality: OPTIONAL (0-1) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * MedicationSupplyOrder.EntryRelationship.typeId 
         * Conformance/Cardinality: OPTIONAL (0-1) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * BaseModel.EntryRelationship.typeId Conformance/Cardinality: 
         * OPTIONAL (0-1)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"typeId"})]
        public Identifier TypeId {
            get { return this.typeId.Value; }
            set { this.typeId.Value = value; }
        }

        /**
         * <summary>Un-merged Business Name: (no business name 
         * specified)</summary>
         * 
         * <remarks>Relationship: 
         * ReferencedFramesObservation.EntryRelationship.templateId 
         * Conformance/Cardinality: OPTIONAL (0-*) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * MedicationSupplyOrder.EntryRelationship.templateId 
         * Conformance/Cardinality: OPTIONAL (0-*) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * BaseModel.EntryRelationship.templateId 
         * Conformance/Cardinality: OPTIONAL (0-*)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"templateId"})]
        public IList<Identifier> TemplateId {
            get { return this.templateId.RawList(); }
        }

        /**
         * <summary>Un-merged Business Name: (no business name 
         * specified)</summary>
         * 
         * <remarks>Relationship: 
         * ReferencedFramesObservation.EntryRelationship.sequenceNumber 
         * Conformance/Cardinality: OPTIONAL (0-1) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * MedicationSupplyOrder.EntryRelationship.sequenceNumber 
         * Conformance/Cardinality: OPTIONAL (0-1) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * BaseModel.EntryRelationship.sequenceNumber 
         * Conformance/Cardinality: OPTIONAL (0-1)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"sequenceNumber"})]
        public int? SequenceNumber {
            get { return this.sequenceNumber.Value; }
            set { this.sequenceNumber.Value = value; }
        }

        /**
         * <summary>Un-merged Business Name: (no business name 
         * specified)</summary>
         * 
         * <remarks>Relationship: 
         * ReferencedFramesObservation.EntryRelationship.seperatableInd 
         * Conformance/Cardinality: OPTIONAL (0-1) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * MedicationSupplyOrder.EntryRelationship.seperatableInd 
         * Conformance/Cardinality: OPTIONAL (0-1) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * BaseModel.EntryRelationship.seperatableInd 
         * Conformance/Cardinality: OPTIONAL (0-1)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"seperatableInd"})]
        public bool? SeperatableInd {
            get { return this.seperatableInd.Value; }
            set { this.seperatableInd.Value = value; }
        }

        /**
         * <summary>Un-merged Business Name: (no business name 
         * specified)</summary>
         * 
         * <remarks>Relationship: 
         * ReferencedFramesObservation.EntryRelationship.observation 
         * Conformance/Cardinality: MANDATORY (1)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"observation"})]
        public Ca.Infoway.Messagebuilder.Model.Ccda_r1_1.Boundaryobservation.Observation Observation {
            get { return this.observation; }
            set { this.observation = value; }
        }

        /**
         * <summary>Un-merged Business Name: (no business name 
         * specified)</summary>
         * 
         * <remarks>Relationship: 
         * MedicationSupplyOrder.EntryRelationship.act 
         * Conformance/Cardinality: MANDATORY (1)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"act"})]
        public Ca.Infoway.Messagebuilder.Model.Ccda_r1_1.Instructions.Act Act {
            get { return this.act; }
            set { this.act = value; }
        }

        /**
         * <summary>Un-merged Business Name: (no business name 
         * specified)</summary>
         * 
         * <remarks>Relationship: BaseModel.EntryRelationship.typeCode 
         * Conformance/Cardinality: MANDATORY (1)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"typeCode"})]
        public CodedTypeR2<Ca.Infoway.Messagebuilder.Model.Ccda_r1_1.Domainvalue.x_ActRelationshipEntryRelationship> TypeCode {
            get { return (CodedTypeR2<Ca.Infoway.Messagebuilder.Model.Ccda_r1_1.Domainvalue.x_ActRelationshipEntryRelationship>) this.typeCode.Value; }
            set { this.typeCode.Value = value; }
        }

        /**
         * <summary>Un-merged Business Name: (no business name 
         * specified)</summary>
         * 
         * <remarks>Relationship: 
         * BaseModel.EntryRelationship.entryRelationshipChoice 
         * Conformance/Cardinality: MANDATORY (1)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"entryRelationshipChoice"})]
        public Ca.Infoway.Messagebuilder.Model.Ccda_r1_1.Basemodel.IEntryRelationshipChoice EntryRelationshipChoice {
            get { return this.entryRelationshipChoice; }
            set { this.entryRelationshipChoice = value; }
        }

    }

}