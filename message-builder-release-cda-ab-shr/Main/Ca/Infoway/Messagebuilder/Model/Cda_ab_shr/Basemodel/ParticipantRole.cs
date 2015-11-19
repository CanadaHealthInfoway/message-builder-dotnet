/* This class was auto-generated by the message builder generator tools. */
namespace Ca.Infoway.Messagebuilder.Model.Cda_ab_shr.Basemodel {
    using Ca.Infoway.Messagebuilder;
    using Ca.Infoway.Messagebuilder.Annotation;
    using Ca.Infoway.Messagebuilder.Datatype;
    using Ca.Infoway.Messagebuilder.Datatype.Impl;
    using Ca.Infoway.Messagebuilder.Datatype.Lang;
    using Ca.Infoway.Messagebuilder.Domainvalue;
    using Ca.Infoway.Messagebuilder.Model;
    using System.Collections.Generic;


    [Hl7PartTypeMappingAttribute(new string[] {"BaseModel.ParticipantRole"})]
    public class ParticipantRole : MessagePartBean {

        private CS_R2<RoleClassRoot> classCode;
        private LIST<CS_R2<Code>, CodedTypeR2<Code>> realmCode;
        private II typeId;
        private LIST<II, Identifier> templateId;
        private LIST<II, Identifier> id;
        private CE_R2<Code> code;
        private LIST<AD, PostalAddress> addr;
        private LIST<TEL, TelecommunicationAddress> telecom;
        private Ca.Infoway.Messagebuilder.Model.Cda_ab_shr.Basemodel.IParticipantRoleChoice participantRoleChoice;
        private Ca.Infoway.Messagebuilder.Model.Cda_ab_shr.Basemodel.Entity scopingEntity;

        public ParticipantRole() {
            this.classCode = new CS_R2Impl<RoleClassRoot>();
            this.realmCode = new LISTImpl<CS_R2<Code>, CodedTypeR2<Code>>(typeof(CS_R2Impl<Code>));
            this.typeId = new IIImpl();
            this.templateId = new LISTImpl<II, Identifier>(typeof(IIImpl));
            this.id = new LISTImpl<II, Identifier>(typeof(IIImpl));
            this.code = new CE_R2Impl<Code>();
            this.addr = new LISTImpl<AD, PostalAddress>(typeof(ADImpl));
            this.telecom = new LISTImpl<TEL, TelecommunicationAddress>(typeof(TELImpl));
        }
        /**
         * <summary>Relationship: BaseModel.ParticipantRole.classCode</summary>
         * 
         * <remarks>Conformance/Cardinality: OPTIONAL (0-1)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"classCode"})]
        public CodedTypeR2<RoleClassRoot> ClassCode {
            get { return (CodedTypeR2<RoleClassRoot>) this.classCode.Value; }
            set { this.classCode.Value = value; }
        }

        /**
         * <summary>Relationship: BaseModel.ParticipantRole.realmCode</summary>
         * 
         * <remarks>Conformance/Cardinality: OPTIONAL (0-*)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"realmCode"})]
        public IList<CodedTypeR2<Code>> RealmCode {
            get { return this.realmCode.RawList<CodedTypeR2<Code>>(); }
        }

        /**
         * <summary>Relationship: BaseModel.ParticipantRole.typeId</summary>
         * 
         * <remarks>Conformance/Cardinality: OPTIONAL (0-1)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"typeId"})]
        public Identifier TypeId {
            get { return this.typeId.Value; }
            set { this.typeId.Value = value; }
        }

        /**
         * <summary>Relationship: BaseModel.ParticipantRole.templateId</summary>
         * 
         * <remarks>Conformance/Cardinality: OPTIONAL (0-*)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"templateId"})]
        public IList<Identifier> TemplateId {
            get { return this.templateId.RawList(); }
        }

        /**
         * <summary>Relationship: BaseModel.ParticipantRole.id</summary>
         * 
         * <remarks>Conformance/Cardinality: OPTIONAL (0-*)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"id"})]
        public IList<Identifier> Id {
            get { return this.id.RawList(); }
        }

        /**
         * <summary>Relationship: BaseModel.ParticipantRole.code</summary>
         * 
         * <remarks>Conformance/Cardinality: OPTIONAL (0-1)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"code"})]
        public CodedTypeR2<Code> Code {
            get { return (CodedTypeR2<Code>) this.code.Value; }
            set { this.code.Value = value; }
        }

        /**
         * <summary>Relationship: BaseModel.ParticipantRole.addr</summary>
         * 
         * <remarks>Conformance/Cardinality: OPTIONAL (0-*)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"addr"})]
        public IList<PostalAddress> Addr {
            get { return this.addr.RawList(); }
        }

        /**
         * <summary>Relationship: BaseModel.ParticipantRole.telecom</summary>
         * 
         * <remarks>Conformance/Cardinality: OPTIONAL (0-*)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"telecom"})]
        public IList<TelecommunicationAddress> Telecom {
            get { return this.telecom.RawList(); }
        }

        /**
         * <summary>Relationship: 
         * BaseModel.ParticipantRole.participantRoleChoice</summary>
         * 
         * <remarks>Conformance/Cardinality: OPTIONAL (0-1)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"participantRoleChoice"})]
        public Ca.Infoway.Messagebuilder.Model.Cda_ab_shr.Basemodel.IParticipantRoleChoice ParticipantRoleChoice {
            get { return this.participantRoleChoice; }
            set { this.participantRoleChoice = value; }
        }

        public Ca.Infoway.Messagebuilder.Model.Cda_ab_shr.Basemodel.Device ParticipantRoleChoiceAsPlayingDevice {
            get { return this.participantRoleChoice is Ca.Infoway.Messagebuilder.Model.Cda_ab_shr.Basemodel.Device ? (Ca.Infoway.Messagebuilder.Model.Cda_ab_shr.Basemodel.Device) this.participantRoleChoice : (Ca.Infoway.Messagebuilder.Model.Cda_ab_shr.Basemodel.Device) null; }
        }
        public bool HasParticipantRoleChoiceAsPlayingDevice() {
            return (this.participantRoleChoice is Ca.Infoway.Messagebuilder.Model.Cda_ab_shr.Basemodel.Device);
        }

        public Ca.Infoway.Messagebuilder.Model.Cda_ab_shr.Basemodel.PlayingEntity ParticipantRoleChoiceAsPlayingEntity {
            get { return this.participantRoleChoice is Ca.Infoway.Messagebuilder.Model.Cda_ab_shr.Basemodel.PlayingEntity ? (Ca.Infoway.Messagebuilder.Model.Cda_ab_shr.Basemodel.PlayingEntity) this.participantRoleChoice : (Ca.Infoway.Messagebuilder.Model.Cda_ab_shr.Basemodel.PlayingEntity) null; }
        }
        public bool HasParticipantRoleChoiceAsPlayingEntity() {
            return (this.participantRoleChoice is Ca.Infoway.Messagebuilder.Model.Cda_ab_shr.Basemodel.PlayingEntity);
        }

        /**
         * <summary>Relationship: 
         * BaseModel.ParticipantRole.scopingEntity</summary>
         * 
         * <remarks>Conformance/Cardinality: OPTIONAL (0-1)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"scopingEntity"})]
        public Ca.Infoway.Messagebuilder.Model.Cda_ab_shr.Basemodel.Entity ScopingEntity {
            get { return this.scopingEntity; }
            set { this.scopingEntity = value; }
        }

    }

}