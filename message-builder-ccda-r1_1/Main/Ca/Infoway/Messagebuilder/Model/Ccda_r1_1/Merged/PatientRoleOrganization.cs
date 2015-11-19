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
 * Author:        $LastChangedBy: tmcgrady $
 * Last modified: $LastChangedDate: 2011-05-04 15:47:15 -0400 (Wed, 04 May 2011) $
 * Revision:      $LastChangedRevision: 2623 $
 */
/* This class was auto-generated by the message builder generator tools. */
namespace Ca.Infoway.Messagebuilder.Model.Ccda_r1_1.Merged {
    using Ca.Infoway.Messagebuilder;
    using Ca.Infoway.Messagebuilder.Annotation;
    using Ca.Infoway.Messagebuilder.Datatype;
    using Ca.Infoway.Messagebuilder.Datatype.Impl;
    using Ca.Infoway.Messagebuilder.Datatype.Lang;
    using Ca.Infoway.Messagebuilder.Model;
    using Ca.Infoway.Messagebuilder.Model.Ccda_r1_1.Basemodel;
    using System.Collections.Generic;


    [Hl7PartTypeMappingAttribute(new string[] {"ConsultationNote.PatientRoleOrganization","ContinuityOfCareDocumentCCD.PatientRoleOrganization","DiagnosticImagingReport.PatientRoleOrganization","DischargeSummary.PatientRoleOrganization","HistoryAndPhysical.PatientRoleOrganization","OperativeNote.PatientRoleOrganization","ProcedureNote.PatientRoleOrganization","ProgressNote.PatientRoleOrganization","USRealmHeader.PatientRoleOrganization","UnstructuredDocument.PatientRoleOrganization"})]
    public class PatientRoleOrganization : MessagePartBean {

        private LIST<CS_R2<Code>, CodedTypeR2<Code>> realmCode;
        private II typeId;
        private LIST<II, Identifier> templateId;
        private LIST<II, Identifier> id;
        private LIST<ON, OrganizationName> name;
        private LIST<TEL, TelecommunicationAddress> telecom;
        private LIST<AD, PostalAddress> addr;
        private CE_R2<Code> standardIndustryClassCode;
        private Ca.Infoway.Messagebuilder.Model.Ccda_r1_1.Basemodel.OrganizationPartOf asOrganizationPartOf;

        public PatientRoleOrganization() {
            this.realmCode = new LISTImpl<CS_R2<Code>, CodedTypeR2<Code>>(typeof(CS_R2Impl<Code>));
            this.typeId = new IIImpl();
            this.templateId = new LISTImpl<II, Identifier>(typeof(IIImpl));
            this.id = new LISTImpl<II, Identifier>(typeof(IIImpl));
            this.name = new LISTImpl<ON, OrganizationName>(typeof(ONImpl));
            this.telecom = new LISTImpl<TEL, TelecommunicationAddress>(typeof(TELImpl));
            this.addr = new LISTImpl<AD, PostalAddress>(typeof(ADImpl));
            this.standardIndustryClassCode = new CE_R2Impl<Code>();
        }
        /**
         * <summary>Un-merged Business Name: (no business name 
         * specified)</summary>
         * 
         * <remarks>Relationship: 
         * OperativeNote.PatientRoleOrganization.realmCode 
         * Conformance/Cardinality: OPTIONAL (0-*) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * UnstructuredDocument.PatientRoleOrganization.realmCode 
         * Conformance/Cardinality: OPTIONAL (0-*) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * DiagnosticImagingReport.PatientRoleOrganization.realmCode 
         * Conformance/Cardinality: OPTIONAL (0-*) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * ContinuityOfCareDocumentCCD.PatientRoleOrganization.realmCode 
         * Conformance/Cardinality: OPTIONAL (0-*) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * ConsultationNote.PatientRoleOrganization.realmCode 
         * Conformance/Cardinality: OPTIONAL (0-*) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * ProcedureNote.PatientRoleOrganization.realmCode 
         * Conformance/Cardinality: OPTIONAL (0-*) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * USRealmHeader.PatientRoleOrganization.realmCode 
         * Conformance/Cardinality: OPTIONAL (0-*) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * HistoryAndPhysical.PatientRoleOrganization.realmCode 
         * Conformance/Cardinality: OPTIONAL (0-*) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * DischargeSummary.PatientRoleOrganization.realmCode 
         * Conformance/Cardinality: OPTIONAL (0-*) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * ProgressNote.PatientRoleOrganization.realmCode 
         * Conformance/Cardinality: OPTIONAL (0-*)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"realmCode"})]
        public IList<CodedTypeR2<Code>> RealmCode {
            get { return this.realmCode.RawList<CodedTypeR2<Code>>(); }
        }

        /**
         * <summary>Un-merged Business Name: (no business name 
         * specified)</summary>
         * 
         * <remarks>Relationship: 
         * OperativeNote.PatientRoleOrganization.typeId 
         * Conformance/Cardinality: OPTIONAL (0-1) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * UnstructuredDocument.PatientRoleOrganization.typeId 
         * Conformance/Cardinality: OPTIONAL (0-1) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * DiagnosticImagingReport.PatientRoleOrganization.typeId 
         * Conformance/Cardinality: OPTIONAL (0-1) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * ContinuityOfCareDocumentCCD.PatientRoleOrganization.typeId 
         * Conformance/Cardinality: OPTIONAL (0-1) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * ConsultationNote.PatientRoleOrganization.typeId 
         * Conformance/Cardinality: OPTIONAL (0-1) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * ProcedureNote.PatientRoleOrganization.typeId 
         * Conformance/Cardinality: OPTIONAL (0-1) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * USRealmHeader.PatientRoleOrganization.typeId 
         * Conformance/Cardinality: OPTIONAL (0-1) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * HistoryAndPhysical.PatientRoleOrganization.typeId 
         * Conformance/Cardinality: OPTIONAL (0-1) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * DischargeSummary.PatientRoleOrganization.typeId 
         * Conformance/Cardinality: OPTIONAL (0-1) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * ProgressNote.PatientRoleOrganization.typeId 
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
         * OperativeNote.PatientRoleOrganization.templateId 
         * Conformance/Cardinality: OPTIONAL (0-*) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * UnstructuredDocument.PatientRoleOrganization.templateId 
         * Conformance/Cardinality: OPTIONAL (0-*) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * DiagnosticImagingReport.PatientRoleOrganization.templateId 
         * Conformance/Cardinality: OPTIONAL (0-*) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * ContinuityOfCareDocumentCCD.PatientRoleOrganization.templateId 
         * Conformance/Cardinality: OPTIONAL (0-*) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * ConsultationNote.PatientRoleOrganization.templateId 
         * Conformance/Cardinality: OPTIONAL (0-*) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * ProcedureNote.PatientRoleOrganization.templateId 
         * Conformance/Cardinality: OPTIONAL (0-*) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * USRealmHeader.PatientRoleOrganization.templateId 
         * Conformance/Cardinality: OPTIONAL (0-*) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * HistoryAndPhysical.PatientRoleOrganization.templateId 
         * Conformance/Cardinality: OPTIONAL (0-*) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * DischargeSummary.PatientRoleOrganization.templateId 
         * Conformance/Cardinality: OPTIONAL (0-*) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * ProgressNote.PatientRoleOrganization.templateId 
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
         * OperativeNote.PatientRoleOrganization.id 
         * Conformance/Cardinality: MANDATORY (*) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * UnstructuredDocument.PatientRoleOrganization.id 
         * Conformance/Cardinality: MANDATORY (*) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * DiagnosticImagingReport.PatientRoleOrganization.id 
         * Conformance/Cardinality: MANDATORY (*) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * ContinuityOfCareDocumentCCD.PatientRoleOrganization.id 
         * Conformance/Cardinality: MANDATORY (*) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * ConsultationNote.PatientRoleOrganization.id 
         * Conformance/Cardinality: MANDATORY (*) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * ProcedureNote.PatientRoleOrganization.id 
         * Conformance/Cardinality: MANDATORY (*) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * USRealmHeader.PatientRoleOrganization.id 
         * Conformance/Cardinality: MANDATORY (*) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * HistoryAndPhysical.PatientRoleOrganization.id 
         * Conformance/Cardinality: MANDATORY (*) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * DischargeSummary.PatientRoleOrganization.id 
         * Conformance/Cardinality: MANDATORY (*) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * ProgressNote.PatientRoleOrganization.id 
         * Conformance/Cardinality: MANDATORY (*)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"id"})]
        public IList<Identifier> Id {
            get { return this.id.RawList(); }
        }

        /**
         * <summary>Un-merged Business Name: (no business name 
         * specified)</summary>
         * 
         * <remarks>Relationship: 
         * OperativeNote.PatientRoleOrganization.name 
         * Conformance/Cardinality: POPULATED (*) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * UnstructuredDocument.PatientRoleOrganization.name 
         * Conformance/Cardinality: POPULATED (*) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * DiagnosticImagingReport.PatientRoleOrganization.name 
         * Conformance/Cardinality: POPULATED (*) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * ContinuityOfCareDocumentCCD.PatientRoleOrganization.name 
         * Conformance/Cardinality: POPULATED (*) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * ConsultationNote.PatientRoleOrganization.name 
         * Conformance/Cardinality: POPULATED (*) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * ProcedureNote.PatientRoleOrganization.name 
         * Conformance/Cardinality: POPULATED (*) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * USRealmHeader.PatientRoleOrganization.name 
         * Conformance/Cardinality: POPULATED (*) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * HistoryAndPhysical.PatientRoleOrganization.name 
         * Conformance/Cardinality: POPULATED (*) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * DischargeSummary.PatientRoleOrganization.name 
         * Conformance/Cardinality: POPULATED (*) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * ProgressNote.PatientRoleOrganization.name 
         * Conformance/Cardinality: POPULATED (*)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"name"})]
        public IList<OrganizationName> Name {
            get { return this.name.RawList(); }
        }

        /**
         * <summary>Un-merged Business Name: (no business name 
         * specified)</summary>
         * 
         * <remarks>Relationship: 
         * OperativeNote.PatientRoleOrganization.telecom 
         * Conformance/Cardinality: POPULATED (*) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * UnstructuredDocument.PatientRoleOrganization.telecom 
         * Conformance/Cardinality: POPULATED (*) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * DiagnosticImagingReport.PatientRoleOrganization.telecom 
         * Conformance/Cardinality: POPULATED (*) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * ContinuityOfCareDocumentCCD.PatientRoleOrganization.telecom 
         * Conformance/Cardinality: POPULATED (*) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * ConsultationNote.PatientRoleOrganization.telecom 
         * Conformance/Cardinality: POPULATED (*) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * ProcedureNote.PatientRoleOrganization.telecom 
         * Conformance/Cardinality: POPULATED (*) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * USRealmHeader.PatientRoleOrganization.telecom 
         * Conformance/Cardinality: POPULATED (*) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * HistoryAndPhysical.PatientRoleOrganization.telecom 
         * Conformance/Cardinality: POPULATED (*) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * DischargeSummary.PatientRoleOrganization.telecom 
         * Conformance/Cardinality: POPULATED (*) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * ProgressNote.PatientRoleOrganization.telecom 
         * Conformance/Cardinality: POPULATED (*)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"telecom"})]
        public IList<TelecommunicationAddress> Telecom {
            get { return this.telecom.RawList(); }
        }

        /**
         * <summary>Un-merged Business Name: (no business name 
         * specified)</summary>
         * 
         * <remarks>Relationship: 
         * OperativeNote.PatientRoleOrganization.addr 
         * Conformance/Cardinality: POPULATED (*) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * UnstructuredDocument.PatientRoleOrganization.addr 
         * Conformance/Cardinality: POPULATED (*) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * DiagnosticImagingReport.PatientRoleOrganization.addr 
         * Conformance/Cardinality: POPULATED (*) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * ContinuityOfCareDocumentCCD.PatientRoleOrganization.addr 
         * Conformance/Cardinality: POPULATED (*) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * ConsultationNote.PatientRoleOrganization.addr 
         * Conformance/Cardinality: POPULATED (*) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * ProcedureNote.PatientRoleOrganization.addr 
         * Conformance/Cardinality: POPULATED (*) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * USRealmHeader.PatientRoleOrganization.addr 
         * Conformance/Cardinality: POPULATED (*) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * HistoryAndPhysical.PatientRoleOrganization.addr 
         * Conformance/Cardinality: POPULATED (*) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * DischargeSummary.PatientRoleOrganization.addr 
         * Conformance/Cardinality: POPULATED (*) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * ProgressNote.PatientRoleOrganization.addr 
         * Conformance/Cardinality: POPULATED (*)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"addr"})]
        public IList<PostalAddress> Addr {
            get { return this.addr.RawList(); }
        }

        /**
         * <summary>Un-merged Business Name: (no business name 
         * specified)</summary>
         * 
         * <remarks>Relationship: 
         * OperativeNote.PatientRoleOrganization.standardIndustryClassCode 
         * Conformance/Cardinality: OPTIONAL (0-1) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * UnstructuredDocument.PatientRoleOrganization.standardIndustryClassCode 
         * Conformance/Cardinality: OPTIONAL (0-1) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * DiagnosticImagingReport.PatientRoleOrganization.standardIndustryClassCode 
         * Conformance/Cardinality: OPTIONAL (0-1) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * ContinuityOfCareDocumentCCD.PatientRoleOrganization.standardIndustryClassCode 
         * Conformance/Cardinality: OPTIONAL (0-1) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * ConsultationNote.PatientRoleOrganization.standardIndustryClassCode 
         * Conformance/Cardinality: OPTIONAL (0-1) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * ProcedureNote.PatientRoleOrganization.standardIndustryClassCode 
         * Conformance/Cardinality: OPTIONAL (0-1) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * USRealmHeader.PatientRoleOrganization.standardIndustryClassCode 
         * Conformance/Cardinality: OPTIONAL (0-1) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * HistoryAndPhysical.PatientRoleOrganization.standardIndustryClassCode 
         * Conformance/Cardinality: OPTIONAL (0-1) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * DischargeSummary.PatientRoleOrganization.standardIndustryClassCode 
         * Conformance/Cardinality: OPTIONAL (0-1) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * ProgressNote.PatientRoleOrganization.standardIndustryClassCode 
         * Conformance/Cardinality: OPTIONAL (0-1)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"standardIndustryClassCode"})]
        public CodedTypeR2<Code> StandardIndustryClassCode {
            get { return (CodedTypeR2<Code>) this.standardIndustryClassCode.Value; }
            set { this.standardIndustryClassCode.Value = value; }
        }

        /**
         * <summary>Un-merged Business Name: (no business name 
         * specified)</summary>
         * 
         * <remarks>Relationship: 
         * OperativeNote.PatientRoleOrganization.asOrganizationPartOf 
         * Conformance/Cardinality: OPTIONAL (0-1) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * UnstructuredDocument.PatientRoleOrganization.asOrganizationPartOf 
         * Conformance/Cardinality: OPTIONAL (0-1) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * DiagnosticImagingReport.PatientRoleOrganization.asOrganizationPartOf 
         * Conformance/Cardinality: OPTIONAL (0-1) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * ContinuityOfCareDocumentCCD.PatientRoleOrganization.asOrganizationPartOf 
         * Conformance/Cardinality: OPTIONAL (0-1) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * ConsultationNote.PatientRoleOrganization.asOrganizationPartOf 
         * Conformance/Cardinality: OPTIONAL (0-1) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * ProcedureNote.PatientRoleOrganization.asOrganizationPartOf 
         * Conformance/Cardinality: OPTIONAL (0-1) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * USRealmHeader.PatientRoleOrganization.asOrganizationPartOf 
         * Conformance/Cardinality: OPTIONAL (0-1) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * HistoryAndPhysical.PatientRoleOrganization.asOrganizationPartOf 
         * Conformance/Cardinality: OPTIONAL (0-1) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * DischargeSummary.PatientRoleOrganization.asOrganizationPartOf 
         * Conformance/Cardinality: OPTIONAL (0-1) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * ProgressNote.PatientRoleOrganization.asOrganizationPartOf 
         * Conformance/Cardinality: OPTIONAL (0-1)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"asOrganizationPartOf"})]
        public Ca.Infoway.Messagebuilder.Model.Ccda_r1_1.Basemodel.OrganizationPartOf AsOrganizationPartOf {
            get { return this.asOrganizationPartOf; }
            set { this.asOrganizationPartOf = value; }
        }

    }

}