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
namespace Ca.Infoway.Messagebuilder.Model.Ccda_pcs_r1_1.Operativenote {
    using Ca.Infoway.Messagebuilder.Annotation;
    using Ca.Infoway.Messagebuilder.Datatype;
    using Ca.Infoway.Messagebuilder.Datatype.Impl;
    using Ca.Infoway.Messagebuilder.Datatype.Lang;
    using Ca.Infoway.Messagebuilder.Model;
    using Ca.Infoway.Messagebuilder.Model.Ccda_pcs_r1_1.Basemodel;
    using Ca.Infoway.Messagebuilder.Model.Ccda_pcs_r1_1.Domainvalue;
    using Ca.Infoway.Messagebuilder.Model.Ccda_pcs_r1_1.Merged;
    using System;
    using System.Collections.Generic;


    [Hl7PartTypeMappingAttribute(new string[] {"OperativeNote.ClinicalDocument"})]
    public class OperativeNote : MessagePartBean {

        private II typeId;
        private LIST<II, Identifier> templateId;
        private II id;
        private CE code;
        private ST title;
        private TSCDAR1 effectiveTime;
        private CE confidentialityCode;
        private CS languageCode;
        private II setId;
        private INT versionNumber;
        private TSCDAR1 copyTime;
        private IList<Ca.Infoway.Messagebuilder.Model.Ccda_pcs_r1_1.Merged.RecordTarget> recordTarget;
        private IList<Ca.Infoway.Messagebuilder.Model.Ccda_pcs_r1_1.Merged.Author_2> author;
        private Ca.Infoway.Messagebuilder.Model.Ccda_pcs_r1_1.Merged.DataEnterer dataEnterer;
        private IList<Ca.Infoway.Messagebuilder.Model.Ccda_pcs_r1_1.Merged.IInformant12Choice> informant;
        private Ca.Infoway.Messagebuilder.Model.Ccda_pcs_r1_1.Merged.Custodian custodian;
        private IList<Ca.Infoway.Messagebuilder.Model.Ccda_pcs_r1_1.Merged.InformationRecipient> informationRecipient;
        private Ca.Infoway.Messagebuilder.Model.Ccda_pcs_r1_1.Merged.LegalAuthenticator legalAuthenticator;
        private IList<Ca.Infoway.Messagebuilder.Model.Ccda_pcs_r1_1.Merged.Authenticator> authenticator;
        private IList<Ca.Infoway.Messagebuilder.Model.Ccda_pcs_r1_1.Merged.IParticipant1Choice> participant;
        private IList<Ca.Infoway.Messagebuilder.Model.Ccda_pcs_r1_1.Merged.InFulfillmentOf> inFulfillmentOf;
        private IList<Ca.Infoway.Messagebuilder.Model.Ccda_pcs_r1_1.Operativenote.DocumentationOf> documentationOf;
        private IList<Ca.Infoway.Messagebuilder.Model.Ccda_pcs_r1_1.Basemodel.RelatedDocument> relatedDocument;
        private IList<Ca.Infoway.Messagebuilder.Model.Ccda_pcs_r1_1.Merged.IAuthorizationChoice> authorization;
        private Ca.Infoway.Messagebuilder.Model.Ccda_pcs_r1_1.Merged.Component1_1 componentOf;
        private Ca.Infoway.Messagebuilder.Model.Ccda_pcs_r1_1.Operativenote.Component2 component;

        public OperativeNote() {
            this.typeId = new IIImpl();
            this.templateId = new LISTImpl<II, Identifier>(typeof(IIImpl));
            this.id = new IIImpl();
            this.code = new CEImpl();
            this.title = new STImpl();
            this.effectiveTime = new TSCDAR1Impl();
            this.confidentialityCode = new CEImpl();
            this.languageCode = new CSImpl();
            this.setId = new IIImpl();
            this.versionNumber = new INTImpl();
            this.copyTime = new TSCDAR1Impl();
            this.recordTarget = new List<Ca.Infoway.Messagebuilder.Model.Ccda_pcs_r1_1.Merged.RecordTarget>();
            this.author = new List<Ca.Infoway.Messagebuilder.Model.Ccda_pcs_r1_1.Merged.Author_2>();
            this.informant = new List<Ca.Infoway.Messagebuilder.Model.Ccda_pcs_r1_1.Merged.IInformant12Choice>();
            this.informationRecipient = new List<Ca.Infoway.Messagebuilder.Model.Ccda_pcs_r1_1.Merged.InformationRecipient>();
            this.authenticator = new List<Ca.Infoway.Messagebuilder.Model.Ccda_pcs_r1_1.Merged.Authenticator>();
            this.participant = new List<Ca.Infoway.Messagebuilder.Model.Ccda_pcs_r1_1.Merged.IParticipant1Choice>();
            this.inFulfillmentOf = new List<Ca.Infoway.Messagebuilder.Model.Ccda_pcs_r1_1.Merged.InFulfillmentOf>();
            this.documentationOf = new List<Ca.Infoway.Messagebuilder.Model.Ccda_pcs_r1_1.Operativenote.DocumentationOf>();
            this.relatedDocument = new List<Ca.Infoway.Messagebuilder.Model.Ccda_pcs_r1_1.Basemodel.RelatedDocument>();
            this.authorization = new List<Ca.Infoway.Messagebuilder.Model.Ccda_pcs_r1_1.Merged.IAuthorizationChoice>();
        }
        /**
         * <summary>Relationship: OperativeNote.ClinicalDocument.typeId</summary>
         * 
         * <remarks>Conformance/Cardinality: MANDATORY (1)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"typeId"})]
        public Identifier TypeId {
            get { return this.typeId.Value; }
            set { this.typeId.Value = value; }
        }

        /**
         * <summary>Relationship: 
         * OperativeNote.ClinicalDocument.templateId</summary>
         * 
         * <remarks>Conformance/Cardinality: MANDATORY (*)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"templateId"})]
        public IList<Identifier> TemplateId {
            get { return this.templateId.RawList(); }
        }

        /**
         * <summary>Relationship: OperativeNote.ClinicalDocument.id</summary>
         * 
         * <remarks>Conformance/Cardinality: POPULATED (1)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"id"})]
        public Identifier Id {
            get { return this.id.Value; }
            set { this.id.Value = value; }
        }

        /**
         * <summary>Relationship: OperativeNote.ClinicalDocument.code</summary>
         * 
         * <remarks>Conformance/Cardinality: POPULATED (1)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"code"})]
        public Ca.Infoway.Messagebuilder.Model.Ccda_pcs_r1_1.Domainvalue.SurgicalOperationNoteDocumentTypeCode Code {
            get { return (Ca.Infoway.Messagebuilder.Model.Ccda_pcs_r1_1.Domainvalue.SurgicalOperationNoteDocumentTypeCode) this.code.Value; }
            set { this.code.Value = value; }
        }

        /**
         * <summary>Relationship: OperativeNote.ClinicalDocument.title</summary>
         * 
         * <remarks>Conformance/Cardinality: POPULATED (1)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"title"})]
        public String Title {
            get { return this.title.Value; }
            set { this.title.Value = value; }
        }

        /**
         * <summary>Relationship: 
         * OperativeNote.ClinicalDocument.effectiveTime</summary>
         * 
         * <remarks>Conformance/Cardinality: POPULATED (1)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"effectiveTime"})]
        public MbDate EffectiveTime {
            get { return this.effectiveTime.Value; }
            set { this.effectiveTime.Value = value; }
        }

        /**
         * <summary>Relationship: 
         * OperativeNote.ClinicalDocument.confidentialityCode</summary>
         * 
         * <remarks>Conformance/Cardinality: POPULATED (1)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"confidentialityCode"})]
        public Ca.Infoway.Messagebuilder.Model.Ccda_pcs_r1_1.Domainvalue.BasicConfidentialityKind ConfidentialityCode {
            get { return (Ca.Infoway.Messagebuilder.Model.Ccda_pcs_r1_1.Domainvalue.BasicConfidentialityKind) this.confidentialityCode.Value; }
            set { this.confidentialityCode.Value = value; }
        }

        /**
         * <summary>Relationship: 
         * OperativeNote.ClinicalDocument.languageCode</summary>
         * 
         * <remarks>Conformance/Cardinality: POPULATED (1)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"languageCode"})]
        public Ca.Infoway.Messagebuilder.Model.Ccda_pcs_r1_1.Domainvalue.Language LanguageCode {
            get { return (Ca.Infoway.Messagebuilder.Model.Ccda_pcs_r1_1.Domainvalue.Language) this.languageCode.Value; }
            set { this.languageCode.Value = value; }
        }

        /**
         * <summary>Relationship: OperativeNote.ClinicalDocument.setId</summary>
         * 
         * <remarks>Conformance/Cardinality: OPTIONAL (0-1)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"setId"})]
        public Identifier SetId {
            get { return this.setId.Value; }
            set { this.setId.Value = value; }
        }

        /**
         * <summary>Relationship: 
         * OperativeNote.ClinicalDocument.versionNumber</summary>
         * 
         * <remarks>Conformance/Cardinality: OPTIONAL (0-1)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"versionNumber"})]
        public int? VersionNumber {
            get { return this.versionNumber.Value; }
            set { this.versionNumber.Value = value; }
        }

        /**
         * <summary>Relationship: 
         * OperativeNote.ClinicalDocument.copyTime</summary>
         * 
         * <remarks>Conformance/Cardinality: OPTIONAL (0-1)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"copyTime"})]
        public MbDate CopyTime {
            get { return this.copyTime.Value; }
            set { this.copyTime.Value = value; }
        }

        /**
         * <summary>Relationship: 
         * OperativeNote.ClinicalDocument.recordTarget</summary>
         * 
         * <remarks>Conformance/Cardinality: POPULATED (*)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"recordTarget"})]
        public IList<Ca.Infoway.Messagebuilder.Model.Ccda_pcs_r1_1.Merged.RecordTarget> RecordTarget {
            get { return this.recordTarget; }
        }

        /**
         * <summary>Relationship: OperativeNote.ClinicalDocument.author</summary>
         * 
         * <remarks>Conformance/Cardinality: POPULATED (*)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"author"})]
        public IList<Ca.Infoway.Messagebuilder.Model.Ccda_pcs_r1_1.Merged.Author_2> Author {
            get { return this.author; }
        }

        /**
         * <summary>Relationship: 
         * OperativeNote.ClinicalDocument.dataEnterer</summary>
         * 
         * <remarks>Conformance/Cardinality: OPTIONAL (0-1)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"dataEnterer"})]
        public Ca.Infoway.Messagebuilder.Model.Ccda_pcs_r1_1.Merged.DataEnterer DataEnterer {
            get { return this.dataEnterer; }
            set { this.dataEnterer = value; }
        }

        /**
         * <summary>Relationship: 
         * OperativeNote.ClinicalDocument.informant</summary>
         * 
         * <remarks>Conformance/Cardinality: OPTIONAL (0-*)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"informant"})]
        public IList<Ca.Infoway.Messagebuilder.Model.Ccda_pcs_r1_1.Merged.IInformant12Choice> Informant {
            get { return this.informant; }
        }

        /**
         * <summary>Relationship: 
         * OperativeNote.ClinicalDocument.custodian</summary>
         * 
         * <remarks>Conformance/Cardinality: POPULATED (1)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"custodian"})]
        public Ca.Infoway.Messagebuilder.Model.Ccda_pcs_r1_1.Merged.Custodian Custodian {
            get { return this.custodian; }
            set { this.custodian = value; }
        }

        /**
         * <summary>Relationship: 
         * OperativeNote.ClinicalDocument.informationRecipient</summary>
         * 
         * <remarks>Conformance/Cardinality: OPTIONAL (0-*)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"informationRecipient"})]
        public IList<Ca.Infoway.Messagebuilder.Model.Ccda_pcs_r1_1.Merged.InformationRecipient> InformationRecipient {
            get { return this.informationRecipient; }
        }

        /**
         * <summary>Relationship: 
         * OperativeNote.ClinicalDocument.legalAuthenticator</summary>
         * 
         * <remarks>Conformance/Cardinality: OPTIONAL (0-1)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"legalAuthenticator"})]
        public Ca.Infoway.Messagebuilder.Model.Ccda_pcs_r1_1.Merged.LegalAuthenticator LegalAuthenticator {
            get { return this.legalAuthenticator; }
            set { this.legalAuthenticator = value; }
        }

        /**
         * <summary>Relationship: 
         * OperativeNote.ClinicalDocument.authenticator</summary>
         * 
         * <remarks>Conformance/Cardinality: OPTIONAL (0-*)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"authenticator"})]
        public IList<Ca.Infoway.Messagebuilder.Model.Ccda_pcs_r1_1.Merged.Authenticator> Authenticator {
            get { return this.authenticator; }
        }

        /**
         * <summary>Relationship: 
         * OperativeNote.ClinicalDocument.participant</summary>
         * 
         * <remarks>Conformance/Cardinality: OPTIONAL (0-*)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"participant"})]
        public IList<Ca.Infoway.Messagebuilder.Model.Ccda_pcs_r1_1.Merged.IParticipant1Choice> Participant {
            get { return this.participant; }
        }

        /**
         * <summary>Relationship: 
         * OperativeNote.ClinicalDocument.inFulfillmentOf</summary>
         * 
         * <remarks>Conformance/Cardinality: OPTIONAL (0-*)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"inFulfillmentOf"})]
        public IList<Ca.Infoway.Messagebuilder.Model.Ccda_pcs_r1_1.Merged.InFulfillmentOf> InFulfillmentOf {
            get { return this.inFulfillmentOf; }
        }

        /**
         * <summary>Relationship: 
         * OperativeNote.ClinicalDocument.documentationOf</summary>
         * 
         * <remarks>Conformance/Cardinality: POPULATED (*)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"documentationOf"})]
        public IList<Ca.Infoway.Messagebuilder.Model.Ccda_pcs_r1_1.Operativenote.DocumentationOf> DocumentationOf {
            get { return this.documentationOf; }
        }

        /**
         * <summary>Relationship: 
         * OperativeNote.ClinicalDocument.relatedDocument</summary>
         * 
         * <remarks>Conformance/Cardinality: OPTIONAL (0-*)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"relatedDocument"})]
        public IList<Ca.Infoway.Messagebuilder.Model.Ccda_pcs_r1_1.Basemodel.RelatedDocument> RelatedDocument {
            get { return this.relatedDocument; }
        }

        /**
         * <summary>Relationship: 
         * OperativeNote.ClinicalDocument.authorization</summary>
         * 
         * <remarks>Conformance/Cardinality: OPTIONAL (0-*)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"authorization"})]
        public IList<Ca.Infoway.Messagebuilder.Model.Ccda_pcs_r1_1.Merged.IAuthorizationChoice> Authorization {
            get { return this.authorization; }
        }

        /**
         * <summary>Relationship: 
         * OperativeNote.ClinicalDocument.componentOf</summary>
         * 
         * <remarks>Conformance/Cardinality: OPTIONAL (0-1)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"componentOf"})]
        public Ca.Infoway.Messagebuilder.Model.Ccda_pcs_r1_1.Merged.Component1_1 ComponentOf {
            get { return this.componentOf; }
            set { this.componentOf = value; }
        }

        /**
         * <summary>Relationship: 
         * OperativeNote.ClinicalDocument.component</summary>
         * 
         * <remarks>Conformance/Cardinality: POPULATED (1)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"component"})]
        public Ca.Infoway.Messagebuilder.Model.Ccda_pcs_r1_1.Operativenote.Component2 Component {
            get { return this.component; }
            set { this.component = value; }
        }

    }

}