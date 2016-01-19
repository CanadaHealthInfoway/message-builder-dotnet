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
    using Ca.Infoway.Messagebuilder.Model.Ccda_r1_1.Nonmedicinalsupplyactivity;
    using System;
    using System.Collections.Generic;


    [Hl7PartTypeMappingAttribute(new string[] {"CognitiveStatusProblemObservation.NonMedicinalSupplyActivityEntryRelationship","CognitiveStatusResultObservation.NonMedicinalSupplyActivityEntryRelationship","FunctionalStatusProblemObservation.NonMedicinalSupplyActivityEntryRelationship","FunctionalStatusResultObservation.NonMedicinalSupplyActivityEntryRelationship"})]
    public class NonMedicinalSupplyActivityEntryRelationship : MessagePartBean, Ca.Infoway.Messagebuilder.Model.Ccda_r1_1.Merged.IEntryRelationshipChoice_4 {

        private BL inversionInd;
        private BL contextConductionInd;
        private BL negationInd;
        private II typeId;
        private LIST<II, Identifier> templateId;
        private INT sequenceNumber;
        private BL seperatableInd;
        private Ca.Infoway.Messagebuilder.Model.Ccda_r1_1.Nonmedicinalsupplyactivity.Supply supply;

        public NonMedicinalSupplyActivityEntryRelationship() {
            this.inversionInd = new BLImpl();
            this.contextConductionInd = new BLImpl();
            this.negationInd = new BLImpl();
            this.typeId = new IIImpl();
            this.templateId = new LISTImpl<II, Identifier>(typeof(IIImpl));
            this.sequenceNumber = new INTImpl();
            this.seperatableInd = new BLImpl();
        }
        /**
         * <summary>Un-merged Business Name: (no business name 
         * specified)</summary>
         * 
         * <remarks>Relationship: 
         * FunctionalStatusResultObservation.NonMedicinalSupplyActivityEntryRelationship.inversionInd 
         * Conformance/Cardinality: OPTIONAL (0-1) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * CognitiveStatusProblemObservation.NonMedicinalSupplyActivityEntryRelationship.inversionInd 
         * Conformance/Cardinality: OPTIONAL (0-1) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * CognitiveStatusResultObservation.NonMedicinalSupplyActivityEntryRelationship.inversionInd 
         * Conformance/Cardinality: OPTIONAL (0-1) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * FunctionalStatusProblemObservation.NonMedicinalSupplyActivityEntryRelationship.inversionInd 
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
         * FunctionalStatusResultObservation.NonMedicinalSupplyActivityEntryRelationship.contextConductionInd 
         * Conformance/Cardinality: OPTIONAL (0-1) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * CognitiveStatusProblemObservation.NonMedicinalSupplyActivityEntryRelationship.contextConductionInd 
         * Conformance/Cardinality: OPTIONAL (0-1) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * CognitiveStatusResultObservation.NonMedicinalSupplyActivityEntryRelationship.contextConductionInd 
         * Conformance/Cardinality: OPTIONAL (0-1) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * FunctionalStatusProblemObservation.NonMedicinalSupplyActivityEntryRelationship.contextConductionInd 
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
         * FunctionalStatusResultObservation.NonMedicinalSupplyActivityEntryRelationship.negationInd 
         * Conformance/Cardinality: OPTIONAL (0-1) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * CognitiveStatusProblemObservation.NonMedicinalSupplyActivityEntryRelationship.negationInd 
         * Conformance/Cardinality: OPTIONAL (0-1) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * CognitiveStatusResultObservation.NonMedicinalSupplyActivityEntryRelationship.negationInd 
         * Conformance/Cardinality: OPTIONAL (0-1) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * FunctionalStatusProblemObservation.NonMedicinalSupplyActivityEntryRelationship.negationInd 
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
         * FunctionalStatusResultObservation.NonMedicinalSupplyActivityEntryRelationship.typeId 
         * Conformance/Cardinality: OPTIONAL (0-1) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * CognitiveStatusProblemObservation.NonMedicinalSupplyActivityEntryRelationship.typeId 
         * Conformance/Cardinality: OPTIONAL (0-1) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * CognitiveStatusResultObservation.NonMedicinalSupplyActivityEntryRelationship.typeId 
         * Conformance/Cardinality: OPTIONAL (0-1) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * FunctionalStatusProblemObservation.NonMedicinalSupplyActivityEntryRelationship.typeId 
         * Conformance/Cardinality: OPTIONAL (0-1)</remarks>
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
         * FunctionalStatusResultObservation.NonMedicinalSupplyActivityEntryRelationship.templateId 
         * Conformance/Cardinality: OPTIONAL (0-*) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * CognitiveStatusProblemObservation.NonMedicinalSupplyActivityEntryRelationship.templateId 
         * Conformance/Cardinality: OPTIONAL (0-*) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * CognitiveStatusResultObservation.NonMedicinalSupplyActivityEntryRelationship.templateId 
         * Conformance/Cardinality: OPTIONAL (0-*) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * FunctionalStatusProblemObservation.NonMedicinalSupplyActivityEntryRelationship.templateId 
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
         * FunctionalStatusResultObservation.NonMedicinalSupplyActivityEntryRelationship.sequenceNumber 
         * Conformance/Cardinality: OPTIONAL (0-1) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * CognitiveStatusProblemObservation.NonMedicinalSupplyActivityEntryRelationship.sequenceNumber 
         * Conformance/Cardinality: OPTIONAL (0-1) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * CognitiveStatusResultObservation.NonMedicinalSupplyActivityEntryRelationship.sequenceNumber 
         * Conformance/Cardinality: OPTIONAL (0-1) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * FunctionalStatusProblemObservation.NonMedicinalSupplyActivityEntryRelationship.sequenceNumber 
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
         * FunctionalStatusResultObservation.NonMedicinalSupplyActivityEntryRelationship.seperatableInd 
         * Conformance/Cardinality: OPTIONAL (0-1) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * CognitiveStatusProblemObservation.NonMedicinalSupplyActivityEntryRelationship.seperatableInd 
         * Conformance/Cardinality: OPTIONAL (0-1) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * CognitiveStatusResultObservation.NonMedicinalSupplyActivityEntryRelationship.seperatableInd 
         * Conformance/Cardinality: OPTIONAL (0-1) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * FunctionalStatusProblemObservation.NonMedicinalSupplyActivityEntryRelationship.seperatableInd 
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
         * FunctionalStatusResultObservation.NonMedicinalSupplyActivityEntryRelationship.supply 
         * Conformance/Cardinality: MANDATORY (1) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * CognitiveStatusProblemObservation.NonMedicinalSupplyActivityEntryRelationship.supply 
         * Conformance/Cardinality: MANDATORY (1) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * CognitiveStatusResultObservation.NonMedicinalSupplyActivityEntryRelationship.supply 
         * Conformance/Cardinality: MANDATORY (1) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * FunctionalStatusProblemObservation.NonMedicinalSupplyActivityEntryRelationship.supply 
         * Conformance/Cardinality: MANDATORY (1)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"supply"})]
        public Ca.Infoway.Messagebuilder.Model.Ccda_r1_1.Nonmedicinalsupplyactivity.Supply Supply {
            get { return this.supply; }
            set { this.supply = value; }
        }

    }

}