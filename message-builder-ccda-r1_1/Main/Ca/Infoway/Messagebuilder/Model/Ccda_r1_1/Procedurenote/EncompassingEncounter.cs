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
namespace Ca.Infoway.Messagebuilder.Model.Ccda_r1_1.Procedurenote {
    using Ca.Infoway.Messagebuilder;
    using Ca.Infoway.Messagebuilder.Annotation;
    using Ca.Infoway.Messagebuilder.Datatype;
    using Ca.Infoway.Messagebuilder.Datatype.Impl;
    using Ca.Infoway.Messagebuilder.Datatype.Lang;
    using Ca.Infoway.Messagebuilder.Model;
    using Ca.Infoway.Messagebuilder.Model.Ccda_r1_1.Merged;
    using System.Collections.Generic;


    [Hl7PartTypeMappingAttribute(new string[] {"ProcedureNote.EncompassingEncounter"})]
    public class EncompassingEncounter : MessagePartBean {

        private II typeId;
        private LIST<II, Identifier> templateId;
        private LIST<II, Identifier> id;
        private CE_R2<Code> code;
        private IVL_TS effectiveTime;
        private CE_R2<Code> dischargeDispositionCode;
        private Ca.Infoway.Messagebuilder.Model.Ccda_r1_1.Merged.ResponsibleParty responsibleParty;
        private IList<Ca.Infoway.Messagebuilder.Model.Ccda_r1_1.Procedurenote.IEncounterParticipantChoice> encounterParticipant;
        private IList<Ca.Infoway.Messagebuilder.Model.Ccda_r1_1.Procedurenote.Location> location;

        public EncompassingEncounter() {
            this.typeId = new IIImpl();
            this.templateId = new LISTImpl<II, Identifier>(typeof(IIImpl));
            this.id = new LISTImpl<II, Identifier>(typeof(IIImpl));
            this.code = new CE_R2Impl<Code>();
            this.effectiveTime = new IVL_TSImpl();
            this.dischargeDispositionCode = new CE_R2Impl<Code>();
            this.encounterParticipant = new List<Ca.Infoway.Messagebuilder.Model.Ccda_r1_1.Procedurenote.IEncounterParticipantChoice>();
            this.location = new List<Ca.Infoway.Messagebuilder.Model.Ccda_r1_1.Procedurenote.Location>();
        }
        /**
         * <summary>Relationship: 
         * ProcedureNote.EncompassingEncounter.typeId</summary>
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
         * ProcedureNote.EncompassingEncounter.templateId</summary>
         * 
         * <remarks>Conformance/Cardinality: OPTIONAL (0-*)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"templateId"})]
        public IList<Identifier> TemplateId {
            get { return this.templateId.RawList(); }
        }

        /**
         * <summary>Relationship: 
         * ProcedureNote.EncompassingEncounter.id</summary>
         * 
         * <remarks>Conformance/Cardinality: POPULATED (*)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"id"})]
        public IList<Identifier> Id {
            get { return this.id.RawList(); }
        }

        /**
         * <summary>Relationship: 
         * ProcedureNote.EncompassingEncounter.code</summary>
         * 
         * <remarks>Conformance/Cardinality: POPULATED (1)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"code"})]
        public CodedTypeR2<Code> Code {
            get { return (CodedTypeR2<Code>) this.code.Value; }
            set { this.code.Value = value; }
        }

        /**
         * <summary>Relationship: 
         * ProcedureNote.EncompassingEncounter.effectiveTime</summary>
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
         * ProcedureNote.EncompassingEncounter.dischargeDispositionCode</summary>
         * 
         * <remarks>Conformance/Cardinality: OPTIONAL (0-1)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"dischargeDispositionCode"})]
        public CodedTypeR2<Code> DischargeDispositionCode {
            get { return (CodedTypeR2<Code>) this.dischargeDispositionCode.Value; }
            set { this.dischargeDispositionCode.Value = value; }
        }

        /**
         * <summary>Relationship: 
         * ProcedureNote.EncompassingEncounter.responsibleParty</summary>
         * 
         * <remarks>Conformance/Cardinality: OPTIONAL (0-1)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"responsibleParty"})]
        public Ca.Infoway.Messagebuilder.Model.Ccda_r1_1.Merged.ResponsibleParty ResponsibleParty {
            get { return this.responsibleParty; }
            set { this.responsibleParty = value; }
        }

        /**
         * <summary>Relationship: 
         * ProcedureNote.EncompassingEncounter.encounterParticipant</summary>
         * 
         * <remarks>Conformance/Cardinality: OPTIONAL (0-*)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"encounterParticipant"})]
        public IList<Ca.Infoway.Messagebuilder.Model.Ccda_r1_1.Procedurenote.IEncounterParticipantChoice> EncounterParticipant {
            get { return this.encounterParticipant; }
        }

        /**
         * <summary>Relationship: 
         * ProcedureNote.EncompassingEncounter.location</summary>
         * 
         * <remarks>Conformance/Cardinality: POPULATED (*)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"location"})]
        public IList<Ca.Infoway.Messagebuilder.Model.Ccda_r1_1.Procedurenote.Location> Location {
            get { return this.location; }
        }

    }

}