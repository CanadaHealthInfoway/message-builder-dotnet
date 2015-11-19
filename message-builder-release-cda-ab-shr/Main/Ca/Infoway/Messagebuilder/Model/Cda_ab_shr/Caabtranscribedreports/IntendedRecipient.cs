/* This class was auto-generated by the message builder generator tools. */
namespace Ca.Infoway.Messagebuilder.Model.Cda_ab_shr.Caabtranscribedreports {
    using Ca.Infoway.Messagebuilder;
    using Ca.Infoway.Messagebuilder.Annotation;
    using Ca.Infoway.Messagebuilder.Datatype;
    using Ca.Infoway.Messagebuilder.Datatype.Impl;
    using Ca.Infoway.Messagebuilder.Datatype.Lang;
    using Ca.Infoway.Messagebuilder.Model;
    using Ca.Infoway.Messagebuilder.Model.Cda_ab_shr.Basemodel;
    using System.Collections.Generic;


    [Hl7PartTypeMappingAttribute(new string[] {"CAABTranscribedReports.IntendedRecipient"})]
    public class IntendedRecipient : MessagePartBean {

        private LIST<CS_R2<Code>, CodedTypeR2<Code>> realmCode;
        private II typeId;
        private LIST<II, Identifier> templateId;
        private LIST<CS_R2<Code>, CodedTypeR2<Code>> informationRecipientRealmCode;
        private II informationRecipientTypeId;
        private LIST<II, Identifier> informationRecipientTemplateId;
        private PN informationRecipientName;
        private LIST<CS_R2<Code>, CodedTypeR2<Code>> receivedOrganizationRealmCode;
        private II receivedOrganizationTypeId;
        private LIST<II, Identifier> receivedOrganizationTemplateId;
        private II receivedOrganizationId;
        private ON receivedOrganizationName;
        private AD receivedOrganizationAddr;
        private Ca.Infoway.Messagebuilder.Model.Cda_ab_shr.Basemodel.OrganizationPartOf receivedOrganizationAsOrganizationPartOf;

        public IntendedRecipient() {
            this.realmCode = new LISTImpl<CS_R2<Code>, CodedTypeR2<Code>>(typeof(CS_R2Impl<Code>));
            this.typeId = new IIImpl();
            this.templateId = new LISTImpl<II, Identifier>(typeof(IIImpl));
            this.informationRecipientRealmCode = new LISTImpl<CS_R2<Code>, CodedTypeR2<Code>>(typeof(CS_R2Impl<Code>));
            this.informationRecipientTypeId = new IIImpl();
            this.informationRecipientTemplateId = new LISTImpl<II, Identifier>(typeof(IIImpl));
            this.informationRecipientName = new PNImpl();
            this.receivedOrganizationRealmCode = new LISTImpl<CS_R2<Code>, CodedTypeR2<Code>>(typeof(CS_R2Impl<Code>));
            this.receivedOrganizationTypeId = new IIImpl();
            this.receivedOrganizationTemplateId = new LISTImpl<II, Identifier>(typeof(IIImpl));
            this.receivedOrganizationId = new IIImpl();
            this.receivedOrganizationName = new ONImpl();
            this.receivedOrganizationAddr = new ADImpl();
        }
        /**
         * <summary>Relationship: 
         * CAABTranscribedReports.IntendedRecipient.realmCode</summary>
         * 
         * <remarks>Conformance/Cardinality: OPTIONAL (0-*)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"realmCode"})]
        public IList<CodedTypeR2<Code>> RealmCode {
            get { return this.realmCode.RawList<CodedTypeR2<Code>>(); }
        }

        /**
         * <summary>Relationship: 
         * CAABTranscribedReports.IntendedRecipient.typeId</summary>
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
         * CAABTranscribedReports.IntendedRecipient.templateId</summary>
         * 
         * <remarks>Conformance/Cardinality: OPTIONAL (0-*)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"templateId"})]
        public IList<Identifier> TemplateId {
            get { return this.templateId.RawList(); }
        }

        /**
         * <summary>Relationship: 
         * CAABTranscribedReports.IntendedRecipientPerson.realmCode</summary>
         * 
         * <remarks>Conformance/Cardinality: OPTIONAL (0-*)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"informationRecipient/realmCode"})]
        public IList<CodedTypeR2<Code>> InformationRecipientRealmCode {
            get { return this.informationRecipientRealmCode.RawList<CodedTypeR2<Code>>(); }
        }

        /**
         * <summary>Relationship: 
         * CAABTranscribedReports.IntendedRecipientPerson.typeId</summary>
         * 
         * <remarks>Conformance/Cardinality: OPTIONAL (0-1)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"informationRecipient/typeId"})]
        public Identifier InformationRecipientTypeId {
            get { return this.informationRecipientTypeId.Value; }
            set { this.informationRecipientTypeId.Value = value; }
        }

        /**
         * <summary>Relationship: 
         * CAABTranscribedReports.IntendedRecipientPerson.templateId</summary>
         * 
         * <remarks>Conformance/Cardinality: OPTIONAL (0-*)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"informationRecipient/templateId"})]
        public IList<Identifier> InformationRecipientTemplateId {
            get { return this.informationRecipientTemplateId.RawList(); }
        }

        /**
         * <summary>Relationship: 
         * CAABTranscribedReports.IntendedRecipientPerson.name</summary>
         * 
         * <remarks>Conformance/Cardinality: POPULATED (1)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"informationRecipient/name"})]
        public PersonName InformationRecipientName {
            get { return this.informationRecipientName.Value; }
            set { this.informationRecipientName.Value = value; }
        }

        /**
         * <summary>Relationship: 
         * CAABTranscribedReports.IntendedRecipientOrganization.realmCode</summary>
         * 
         * <remarks>Conformance/Cardinality: OPTIONAL (0-*)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"receivedOrganization/realmCode"})]
        public IList<CodedTypeR2<Code>> ReceivedOrganizationRealmCode {
            get { return this.receivedOrganizationRealmCode.RawList<CodedTypeR2<Code>>(); }
        }

        /**
         * <summary>Relationship: 
         * CAABTranscribedReports.IntendedRecipientOrganization.typeId</summary>
         * 
         * <remarks>Conformance/Cardinality: OPTIONAL (0-1)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"receivedOrganization/typeId"})]
        public Identifier ReceivedOrganizationTypeId {
            get { return this.receivedOrganizationTypeId.Value; }
            set { this.receivedOrganizationTypeId.Value = value; }
        }

        /**
         * <summary>Relationship: 
         * CAABTranscribedReports.IntendedRecipientOrganization.templateId</summary>
         * 
         * <remarks>Conformance/Cardinality: OPTIONAL (0-*)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"receivedOrganization/templateId"})]
        public IList<Identifier> ReceivedOrganizationTemplateId {
            get { return this.receivedOrganizationTemplateId.RawList(); }
        }

        /**
         * <summary>Relationship: 
         * CAABTranscribedReports.IntendedRecipientOrganization.id</summary>
         * 
         * <remarks>Conformance/Cardinality: POPULATED (1)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"receivedOrganization/id"})]
        public Identifier ReceivedOrganizationId {
            get { return this.receivedOrganizationId.Value; }
            set { this.receivedOrganizationId.Value = value; }
        }

        /**
         * <summary>Relationship: 
         * CAABTranscribedReports.IntendedRecipientOrganization.name</summary>
         * 
         * <remarks>Conformance/Cardinality: OPTIONAL (0-1)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"receivedOrganization/name"})]
        public OrganizationName ReceivedOrganizationName {
            get { return this.receivedOrganizationName.Value; }
            set { this.receivedOrganizationName.Value = value; }
        }

        /**
         * <summary>Relationship: 
         * CAABTranscribedReports.IntendedRecipientOrganization.addr</summary>
         * 
         * <remarks>Conformance/Cardinality: OPTIONAL (0-1)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"receivedOrganization/addr"})]
        public PostalAddress ReceivedOrganizationAddr {
            get { return this.receivedOrganizationAddr.Value; }
            set { this.receivedOrganizationAddr.Value = value; }
        }

        /**
         * <summary>Relationship: 
         * CAABTranscribedReports.IntendedRecipientOrganization.asOrganizationPartOf</summary>
         * 
         * <remarks>Conformance/Cardinality: OPTIONAL (0-1)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"receivedOrganization/asOrganizationPartOf"})]
        public Ca.Infoway.Messagebuilder.Model.Cda_ab_shr.Basemodel.OrganizationPartOf ReceivedOrganizationAsOrganizationPartOf {
            get { return this.receivedOrganizationAsOrganizationPartOf; }
            set { this.receivedOrganizationAsOrganizationPartOf = value; }
        }

    }

}