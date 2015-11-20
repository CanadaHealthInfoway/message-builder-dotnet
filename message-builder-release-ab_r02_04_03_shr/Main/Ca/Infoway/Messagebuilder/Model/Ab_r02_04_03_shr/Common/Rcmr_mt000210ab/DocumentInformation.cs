/* This class was auto-generated by the message builder generator tools. */
namespace Ca.Infoway.Messagebuilder.Model.Ab_r02_04_03_shr.Common.Rcmr_mt000210ab {
    using Ca.Infoway.Messagebuilder.Annotation;
    using Ca.Infoway.Messagebuilder.Datatype;
    using Ca.Infoway.Messagebuilder.Datatype.Impl;
    using Ca.Infoway.Messagebuilder.Datatype.Lang;
    using Ca.Infoway.Messagebuilder.Domainvalue;
    using Ca.Infoway.Messagebuilder.Model;
    using Ca.Infoway.Messagebuilder.Model.Ab_r02_04_03_shr.Common.Coct_mt050205ab;
    using Ca.Infoway.Messagebuilder.Model.Ab_r02_04_03_shr.Common.Merged;
    using System;
    using System.Collections.Generic;


    /**
     * <summary>Business Name: Document Information</summary>
     * 
     * <p>Contains information about the clinical document</p>
     */
    [Hl7PartTypeMappingAttribute(new string[] {"RCMR_MT000210AB.Document"})]
    public class DocumentInformation : MessagePartBean {

        private II id;
        private CV code;
        private ST title;
        private ED<EncapsulatedData> text;
        private CS statusCode;
        private TS effectiveTime;
        private CV confidentialityCode;
        private INT versionNumber;
        private Ca.Infoway.Messagebuilder.Model.Ab_r02_04_03_shr.Common.Coct_mt050205ab.Patient recordTargetPatient;
        private Ca.Infoway.Messagebuilder.Model.Ab_r02_04_03_shr.Common.Merged.AuthoredBy_1 author;
        private Ca.Infoway.Messagebuilder.Model.Ab_r02_04_03_shr.Common.Merged.Transcriber dataEnterer;
        private Ca.Infoway.Messagebuilder.Model.Ab_r02_04_03_shr.Common.Merged.ObtainedFrom informant;
        private II custodianAssignedCustodianRepresentedRepositoryId;
        private IList<Ca.Infoway.Messagebuilder.Model.Ab_r02_04_03_shr.Common.Merged.ToBeSentTo> informationRecipient;
        private Ca.Infoway.Messagebuilder.Model.Ab_r02_04_03_shr.Common.Merged.AuthenticatedBy authenticator;
        private CV documentationOfServiceEventCode;
        private Ca.Infoway.Messagebuilder.Model.Ab_r02_04_03_shr.Common.Merged.AdministrativeObservation pertinentInformationDocumentObservation;
        private II subjectOfClinicalDocumentSubscriptionRequestSubjectAssignedRecipientId;

        public DocumentInformation() {
            this.id = new IIImpl();
            this.code = new CVImpl();
            this.title = new STImpl();
            this.text = new EDImpl<EncapsulatedData>();
            this.statusCode = new CSImpl();
            this.effectiveTime = new TSImpl();
            this.confidentialityCode = new CVImpl();
            this.versionNumber = new INTImpl();
            this.custodianAssignedCustodianRepresentedRepositoryId = new IIImpl();
            this.informationRecipient = new List<Ca.Infoway.Messagebuilder.Model.Ab_r02_04_03_shr.Common.Merged.ToBeSentTo>();
            this.documentationOfServiceEventCode = new CVImpl();
            this.subjectOfClinicalDocumentSubscriptionRequestSubjectAssignedRecipientId = new IIImpl();
        }
        /**
         * <summary>Business Name: Document Identifier</summary>
         * 
         * <remarks>Relationship: RCMR_MT000210AB.Document.id 
         * Conformance/Cardinality: MANDATORY (1) <p>The 
         * repository-assigned identifier associated with the clinical 
         * document.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"id"})]
        public Identifier Id {
            get { return this.id.Value; }
            set { this.id.Value = value; }
        }

        /**
         * <summary>Business Name: Document Category</summary>
         * 
         * <remarks>Relationship: RCMR_MT000210AB.Document.code 
         * Conformance/Cardinality: MANDATORY (1) <p>A coded value used 
         * to categorize the clinical document.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"code"})]
        public DocumentType Code {
            get { return (DocumentType) this.code.Value; }
            set { this.code.Value = value; }
        }

        /**
         * <summary>Business Name: Document Title</summary>
         * 
         * <remarks>Relationship: RCMR_MT000210AB.Document.title 
         * Conformance/Cardinality: MANDATORY (1) <p>The title of the 
         * clinical document.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"title"})]
        public String Title {
            get { return this.title.Value; }
            set { this.title.Value = value; }
        }

        /**
         * <summary>Business Name: Document Content</summary>
         * 
         * <remarks>Relationship: RCMR_MT000210AB.Document.text 
         * Conformance/Cardinality: MANDATORY (1) <p>The full clinical 
         * document embedded as a MIME-encoded attachment.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"text"})]
        public EncapsulatedData Text {
            get { return this.text.Value; }
            set { this.text.Value = value; }
        }

        /**
         * <summary>Business Name: Document status</summary>
         * 
         * <remarks>Relationship: RCMR_MT000210AB.Document.statusCode 
         * Conformance/Cardinality: MANDATORY (1) <p>A coded value 
         * indicating the status of a clinical document - i.e. complete 
         * vs. interim.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"statusCode"})]
        public ActStatus StatusCode {
            get { return (ActStatus) this.statusCode.Value; }
            set { this.statusCode.Value = value; }
        }

        /**
         * <summary>Business Name: Document Date</summary>
         * 
         * <remarks>Relationship: 
         * RCMR_MT000210AB.Document.effectiveTime 
         * Conformance/Cardinality: MANDATORY (1) <p>The date of the 
         * clinical document.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"effectiveTime"})]
        public PlatformDate EffectiveTime {
            get { return this.effectiveTime.Value; }
            set { this.effectiveTime.Value = value; }
        }

        /**
         * <summary>Business Name: Document masking indicator</summary>
         * 
         * <remarks>Relationship: 
         * RCMR_MT000210AB.Document.confidentialityCode 
         * Conformance/Cardinality: REQUIRED (1) <p>Included to 
         * maintain conformance with HL7 UV models. Sent as a 
         * nullFlavor of 'NA' (Not Applicable) as this information is 
         * set at the patient level and not captured in the Netcare 
         * document repositories.</p> <p>A coded value that indicates 
         * the masking status associated with a clinical document.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"confidentialityCode"})]
        public x_BasicConfidentialityKind ConfidentialityCode {
            get { return (x_BasicConfidentialityKind) this.confidentialityCode.Value; }
            set { this.confidentialityCode.Value = value; }
        }

        /**
         * <summary>Business Name: ReportVersionNumber</summary>
         * 
         * <remarks>Relationship: 
         * RCMR_MT000210AB.Document.versionNumber 
         * Conformance/Cardinality: REQUIRED (1)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"versionNumber"})]
        public int? VersionNumber {
            get { return this.versionNumber.Value; }
            set { this.versionNumber.Value = value; }
        }

        /**
         * <summary>Relationship: RCMR_MT000210AB.RecordTarget.patient</summary>
         * 
         * <remarks>Conformance/Cardinality: MANDATORY (1)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"recordTarget/patient"})]
        public Ca.Infoway.Messagebuilder.Model.Ab_r02_04_03_shr.Common.Coct_mt050205ab.Patient RecordTargetPatient {
            get { return this.recordTargetPatient; }
            set { this.recordTargetPatient = value; }
        }

        /**
         * <summary>Relationship: RCMR_MT000210AB.Document.author</summary>
         * 
         * <remarks>Conformance/Cardinality: REQUIRED (1)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"author"})]
        public Ca.Infoway.Messagebuilder.Model.Ab_r02_04_03_shr.Common.Merged.AuthoredBy_1 Author {
            get { return this.author; }
            set { this.author = value; }
        }

        /**
         * <summary>Relationship: RCMR_MT000210AB.Document.dataEnterer</summary>
         * 
         * <remarks>Conformance/Cardinality: REQUIRED (0-1)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"dataEnterer"})]
        public Ca.Infoway.Messagebuilder.Model.Ab_r02_04_03_shr.Common.Merged.Transcriber DataEnterer {
            get { return this.dataEnterer; }
            set { this.dataEnterer = value; }
        }

        /**
         * <summary>Relationship: RCMR_MT000210AB.Document.informant</summary>
         * 
         * <remarks>Conformance/Cardinality: REQUIRED (1)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"informant"})]
        public Ca.Infoway.Messagebuilder.Model.Ab_r02_04_03_shr.Common.Merged.ObtainedFrom Informant {
            get { return this.informant; }
            set { this.informant = value; }
        }

        /**
         * <summary>Business Name: Repository ID</summary>
         * 
         * <remarks>Relationship: RCMR_MT000210AB.Repository.id 
         * Conformance/Cardinality: MANDATORY (1) <p>The identifer 
         * associated with the repository in which the clinical 
         * document is stored.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"custodian/assignedCustodian/representedRepository/id"})]
        public Identifier CustodianAssignedCustodianRepresentedRepositoryId {
            get { return this.custodianAssignedCustodianRepresentedRepositoryId.Value; }
            set { this.custodianAssignedCustodianRepresentedRepositoryId.Value = value; }
        }

        /**
         * <summary>Relationship: 
         * RCMR_MT000210AB.Document.informationRecipient</summary>
         * 
         * <remarks>Conformance/Cardinality: REQUIRED (0-100)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"informationRecipient"})]
        public IList<Ca.Infoway.Messagebuilder.Model.Ab_r02_04_03_shr.Common.Merged.ToBeSentTo> InformationRecipient {
            get { return this.informationRecipient; }
        }

        /**
         * <summary>Relationship: 
         * RCMR_MT000210AB.Document.authenticator</summary>
         * 
         * <remarks>Conformance/Cardinality: REQUIRED (0-1)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"authenticator"})]
        public Ca.Infoway.Messagebuilder.Model.Ab_r02_04_03_shr.Common.Merged.AuthenticatedBy Authenticator {
            get { return this.authenticator; }
            set { this.authenticator = value; }
        }

        /**
         * <summary>Business Name: Procedure Code</summary>
         * 
         * <remarks>Relationship: RCMR_MT000210AB.ServiceEvent.code 
         * Conformance/Cardinality: MANDATORY (1) <p>A coded value that 
         * represents the documented procedure</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"documentationOf/serviceEvent/code"})]
        public ActCode DocumentationOfServiceEventCode {
            get { return (ActCode) this.documentationOfServiceEventCode.Value; }
            set { this.documentationOfServiceEventCode.Value = value; }
        }

        /**
         * <summary>Relationship: 
         * RCMR_MT000210AB.PertinentInformation.documentObservation</summary>
         * 
         * <remarks>Conformance/Cardinality: REQUIRED (1)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"pertinentInformation/documentObservation"})]
        public Ca.Infoway.Messagebuilder.Model.Ab_r02_04_03_shr.Common.Merged.AdministrativeObservation PertinentInformationDocumentObservation {
            get { return this.pertinentInformationDocumentObservation; }
            set { this.pertinentInformationDocumentObservation = value; }
        }

        /**
         * <summary>Business Name: Recipient Identifier</summary>
         * 
         * <remarks>Relationship: RCMR_MT000210AB.AssignedRecipient.id 
         * Conformance/Cardinality: MANDATORY (1) <p>An identifier 
         * associated with the recipient of the information update. 
         * Examples include: provider ID, eDlivery mailbox, etc.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"subjectOf/clinicalDocumentSubscriptionRequest/subject/assignedRecipient/id"})]
        public Identifier SubjectOfClinicalDocumentSubscriptionRequestSubjectAssignedRecipientId {
            get { return this.subjectOfClinicalDocumentSubscriptionRequestSubjectAssignedRecipientId.Value; }
            set { this.subjectOfClinicalDocumentSubscriptionRequestSubjectAssignedRecipientId.Value = value; }
        }

    }

}