/* This class was auto-generated by the message builder generator tools. */
namespace Ca.Infoway.Messagebuilder.Model.Cda_ab_shr.Basemodel {
    using Ca.Infoway.Messagebuilder;
    using Ca.Infoway.Messagebuilder.Annotation;
    using Ca.Infoway.Messagebuilder.Datatype;
    using Ca.Infoway.Messagebuilder.Datatype.Impl;
    using Ca.Infoway.Messagebuilder.Datatype.Lang;
    using Ca.Infoway.Messagebuilder.Model;
    using Ca.Infoway.Messagebuilder.Model.Cda_ab_shr.Domainvalue;
    using System.Collections.Generic;


    [Hl7PartTypeMappingAttribute(new string[] {"BaseModel.Entry"})]
    public class Entry : MessagePartBean {

        private CS_R2<Ca.Infoway.Messagebuilder.Model.Cda_ab_shr.Domainvalue.x_ActRelationshipEntry> typeCode;
        private LIST<CS_R2<Code>, CodedTypeR2<Code>> realmCode;
        private II typeId;
        private LIST<II, Identifier> templateId;
        private Ca.Infoway.Messagebuilder.Model.Cda_ab_shr.Basemodel.IEntryChoice entryChoice;

        public Entry() {
            this.typeCode = new CS_R2Impl<Ca.Infoway.Messagebuilder.Model.Cda_ab_shr.Domainvalue.x_ActRelationshipEntry>();
            this.realmCode = new LISTImpl<CS_R2<Code>, CodedTypeR2<Code>>(typeof(CS_R2Impl<Code>));
            this.typeId = new IIImpl();
            this.templateId = new LISTImpl<II, Identifier>(typeof(IIImpl));
        }
        /**
         * <summary>Relationship: BaseModel.Entry.typeCode</summary>
         * 
         * <remarks>Conformance/Cardinality: OPTIONAL (0-1)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"typeCode"})]
        public CodedTypeR2<Ca.Infoway.Messagebuilder.Model.Cda_ab_shr.Domainvalue.x_ActRelationshipEntry> TypeCode {
            get { return (CodedTypeR2<Ca.Infoway.Messagebuilder.Model.Cda_ab_shr.Domainvalue.x_ActRelationshipEntry>) this.typeCode.Value; }
            set { this.typeCode.Value = value; }
        }

        /**
         * <summary>Relationship: BaseModel.Entry.realmCode</summary>
         * 
         * <remarks>Conformance/Cardinality: OPTIONAL (0-*)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"realmCode"})]
        public IList<CodedTypeR2<Code>> RealmCode {
            get { return this.realmCode.RawList<CodedTypeR2<Code>>(); }
        }

        /**
         * <summary>Relationship: BaseModel.Entry.typeId</summary>
         * 
         * <remarks>Conformance/Cardinality: OPTIONAL (0-1)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"typeId"})]
        public Identifier TypeId {
            get { return this.typeId.Value; }
            set { this.typeId.Value = value; }
        }

        /**
         * <summary>Relationship: BaseModel.Entry.templateId</summary>
         * 
         * <remarks>Conformance/Cardinality: OPTIONAL (0-*)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"templateId"})]
        public IList<Identifier> TemplateId {
            get { return this.templateId.RawList(); }
        }

        /**
         * <summary>Relationship: BaseModel.Entry.entryChoice</summary>
         * 
         * <remarks>Conformance/Cardinality: MANDATORY (1)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"entryChoice"})]
        public Ca.Infoway.Messagebuilder.Model.Cda_ab_shr.Basemodel.IEntryChoice EntryChoice {
            get { return this.entryChoice; }
            set { this.entryChoice = value; }
        }

        public Ca.Infoway.Messagebuilder.Model.Cda_ab_shr.Basemodel.Act EntryChoiceAsAct {
            get { return this.entryChoice is Ca.Infoway.Messagebuilder.Model.Cda_ab_shr.Basemodel.Act ? (Ca.Infoway.Messagebuilder.Model.Cda_ab_shr.Basemodel.Act) this.entryChoice : (Ca.Infoway.Messagebuilder.Model.Cda_ab_shr.Basemodel.Act) null; }
        }
        public bool HasEntryChoiceAsAct() {
            return (this.entryChoice is Ca.Infoway.Messagebuilder.Model.Cda_ab_shr.Basemodel.Act);
        }

        public Ca.Infoway.Messagebuilder.Model.Cda_ab_shr.Basemodel.Encounter EntryChoiceAsEncounter {
            get { return this.entryChoice is Ca.Infoway.Messagebuilder.Model.Cda_ab_shr.Basemodel.Encounter ? (Ca.Infoway.Messagebuilder.Model.Cda_ab_shr.Basemodel.Encounter) this.entryChoice : (Ca.Infoway.Messagebuilder.Model.Cda_ab_shr.Basemodel.Encounter) null; }
        }
        public bool HasEntryChoiceAsEncounter() {
            return (this.entryChoice is Ca.Infoway.Messagebuilder.Model.Cda_ab_shr.Basemodel.Encounter);
        }

        public Ca.Infoway.Messagebuilder.Model.Cda_ab_shr.Basemodel.Observation EntryChoiceAsObservation {
            get { return this.entryChoice is Ca.Infoway.Messagebuilder.Model.Cda_ab_shr.Basemodel.Observation ? (Ca.Infoway.Messagebuilder.Model.Cda_ab_shr.Basemodel.Observation) this.entryChoice : (Ca.Infoway.Messagebuilder.Model.Cda_ab_shr.Basemodel.Observation) null; }
        }
        public bool HasEntryChoiceAsObservation() {
            return (this.entryChoice is Ca.Infoway.Messagebuilder.Model.Cda_ab_shr.Basemodel.Observation);
        }

        public Ca.Infoway.Messagebuilder.Model.Cda_ab_shr.Basemodel.ObservationMedia EntryChoiceAsObservationMedia {
            get { return this.entryChoice is Ca.Infoway.Messagebuilder.Model.Cda_ab_shr.Basemodel.ObservationMedia ? (Ca.Infoway.Messagebuilder.Model.Cda_ab_shr.Basemodel.ObservationMedia) this.entryChoice : (Ca.Infoway.Messagebuilder.Model.Cda_ab_shr.Basemodel.ObservationMedia) null; }
        }
        public bool HasEntryChoiceAsObservationMedia() {
            return (this.entryChoice is Ca.Infoway.Messagebuilder.Model.Cda_ab_shr.Basemodel.ObservationMedia);
        }

        public Ca.Infoway.Messagebuilder.Model.Cda_ab_shr.Basemodel.Organizer EntryChoiceAsOrganizer {
            get { return this.entryChoice is Ca.Infoway.Messagebuilder.Model.Cda_ab_shr.Basemodel.Organizer ? (Ca.Infoway.Messagebuilder.Model.Cda_ab_shr.Basemodel.Organizer) this.entryChoice : (Ca.Infoway.Messagebuilder.Model.Cda_ab_shr.Basemodel.Organizer) null; }
        }
        public bool HasEntryChoiceAsOrganizer() {
            return (this.entryChoice is Ca.Infoway.Messagebuilder.Model.Cda_ab_shr.Basemodel.Organizer);
        }

        public Ca.Infoway.Messagebuilder.Model.Cda_ab_shr.Basemodel.Procedure EntryChoiceAsProcedure {
            get { return this.entryChoice is Ca.Infoway.Messagebuilder.Model.Cda_ab_shr.Basemodel.Procedure ? (Ca.Infoway.Messagebuilder.Model.Cda_ab_shr.Basemodel.Procedure) this.entryChoice : (Ca.Infoway.Messagebuilder.Model.Cda_ab_shr.Basemodel.Procedure) null; }
        }
        public bool HasEntryChoiceAsProcedure() {
            return (this.entryChoice is Ca.Infoway.Messagebuilder.Model.Cda_ab_shr.Basemodel.Procedure);
        }

        public Ca.Infoway.Messagebuilder.Model.Cda_ab_shr.Basemodel.RegionOfInterest EntryChoiceAsRegionOfInterest {
            get { return this.entryChoice is Ca.Infoway.Messagebuilder.Model.Cda_ab_shr.Basemodel.RegionOfInterest ? (Ca.Infoway.Messagebuilder.Model.Cda_ab_shr.Basemodel.RegionOfInterest) this.entryChoice : (Ca.Infoway.Messagebuilder.Model.Cda_ab_shr.Basemodel.RegionOfInterest) null; }
        }
        public bool HasEntryChoiceAsRegionOfInterest() {
            return (this.entryChoice is Ca.Infoway.Messagebuilder.Model.Cda_ab_shr.Basemodel.RegionOfInterest);
        }

        public Ca.Infoway.Messagebuilder.Model.Cda_ab_shr.Basemodel.SubstanceAdministration EntryChoiceAsSubstanceAdministration {
            get { return this.entryChoice is Ca.Infoway.Messagebuilder.Model.Cda_ab_shr.Basemodel.SubstanceAdministration ? (Ca.Infoway.Messagebuilder.Model.Cda_ab_shr.Basemodel.SubstanceAdministration) this.entryChoice : (Ca.Infoway.Messagebuilder.Model.Cda_ab_shr.Basemodel.SubstanceAdministration) null; }
        }
        public bool HasEntryChoiceAsSubstanceAdministration() {
            return (this.entryChoice is Ca.Infoway.Messagebuilder.Model.Cda_ab_shr.Basemodel.SubstanceAdministration);
        }

        public Ca.Infoway.Messagebuilder.Model.Cda_ab_shr.Basemodel.Supply EntryChoiceAsSupply {
            get { return this.entryChoice is Ca.Infoway.Messagebuilder.Model.Cda_ab_shr.Basemodel.Supply ? (Ca.Infoway.Messagebuilder.Model.Cda_ab_shr.Basemodel.Supply) this.entryChoice : (Ca.Infoway.Messagebuilder.Model.Cda_ab_shr.Basemodel.Supply) null; }
        }
        public bool HasEntryChoiceAsSupply() {
            return (this.entryChoice is Ca.Infoway.Messagebuilder.Model.Cda_ab_shr.Basemodel.Supply);
        }

    }

}