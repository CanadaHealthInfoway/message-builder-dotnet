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
    using Ca.Infoway.Messagebuilder;
    using Ca.Infoway.Messagebuilder.Annotation;
    using Ca.Infoway.Messagebuilder.Datatype;
    using Ca.Infoway.Messagebuilder.Datatype.Impl;
    using Ca.Infoway.Messagebuilder.Datatype.Lang;
    using Ca.Infoway.Messagebuilder.Model;
    using Ca.Infoway.Messagebuilder.Model.Ccda_r1_1.Basemodel;
    using Ca.Infoway.Messagebuilder.Model.Ccda_r1_1.Domainvalue;
    using System.Collections.Generic;


    [Hl7PartTypeMappingAttribute(new string[] {"ConsultationNote.RelatedEntityInformant12","ContinuityOfCareDocumentCCD.RelatedEntityInformant12","DiagnosticImagingReport.RelatedEntityInformant12","DischargeSummary.RelatedEntityInformant12","HistoryAndPhysical.RelatedEntityInformant12","OperativeNote.RelatedEntityInformant12","ProcedureNote.RelatedEntityInformant12","ProgressNote.RelatedEntityInformant12","USRealmHeader.RelatedEntityInformant12","UnstructuredDocument.RelatedEntityInformant12"})]
    public class RelatedEntityInformant12 : MessagePartBean, Ca.Infoway.Messagebuilder.Model.Ccda_r1_1.Merged.IInformant12Choice {

        private II typeId;
        private LIST<II, Identifier> templateId;
        private CS_R2<Ca.Infoway.Messagebuilder.Model.Ccda_r1_1.Domainvalue.RoleClassMutualRelationship> relatedEntityClassCode;
        private II relatedEntityTypeId;
        private LIST<II, Identifier> relatedEntityTemplateId;
        private CE_R2<Code> relatedEntityCode;
        private LIST<AD, PostalAddress> relatedEntityAddr;
        private LIST<TEL, TelecommunicationAddress> relatedEntityTelecom;
        private IVL_TS relatedEntityEffectiveTime;
        private Ca.Infoway.Messagebuilder.Model.Ccda_r1_1.Basemodel.Person relatedEntityRelatedPerson;

        public RelatedEntityInformant12() {
            this.typeId = new IIImpl();
            this.templateId = new LISTImpl<II, Identifier>(typeof(IIImpl));
            this.relatedEntityClassCode = new CS_R2Impl<Ca.Infoway.Messagebuilder.Model.Ccda_r1_1.Domainvalue.RoleClassMutualRelationship>();
            this.relatedEntityTypeId = new IIImpl();
            this.relatedEntityTemplateId = new LISTImpl<II, Identifier>(typeof(IIImpl));
            this.relatedEntityCode = new CE_R2Impl<Code>();
            this.relatedEntityAddr = new LISTImpl<AD, PostalAddress>(typeof(ADImpl));
            this.relatedEntityTelecom = new LISTImpl<TEL, TelecommunicationAddress>(typeof(TELImpl));
            this.relatedEntityEffectiveTime = new IVL_TSImpl();
        }
        /**
         * <summary>Un-merged Business Name: (no business name 
         * specified)</summary>
         * 
         * <remarks>Relationship: 
         * ProcedureNote.RelatedEntityInformant12.typeId 
         * Conformance/Cardinality: OPTIONAL (0-1) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * HistoryAndPhysical.RelatedEntityInformant12.typeId 
         * Conformance/Cardinality: OPTIONAL (0-1) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * DischargeSummary.RelatedEntityInformant12.typeId 
         * Conformance/Cardinality: OPTIONAL (0-1) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * DiagnosticImagingReport.RelatedEntityInformant12.typeId 
         * Conformance/Cardinality: OPTIONAL (0-1) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * OperativeNote.RelatedEntityInformant12.typeId 
         * Conformance/Cardinality: OPTIONAL (0-1) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * ContinuityOfCareDocumentCCD.RelatedEntityInformant12.typeId 
         * Conformance/Cardinality: OPTIONAL (0-1) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * USRealmHeader.RelatedEntityInformant12.typeId 
         * Conformance/Cardinality: OPTIONAL (0-1) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * ProgressNote.RelatedEntityInformant12.typeId 
         * Conformance/Cardinality: OPTIONAL (0-1) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * ConsultationNote.RelatedEntityInformant12.typeId 
         * Conformance/Cardinality: OPTIONAL (0-1) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * UnstructuredDocument.RelatedEntityInformant12.typeId 
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
         * ProcedureNote.RelatedEntityInformant12.templateId 
         * Conformance/Cardinality: OPTIONAL (0-*) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * HistoryAndPhysical.RelatedEntityInformant12.templateId 
         * Conformance/Cardinality: OPTIONAL (0-*) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * DischargeSummary.RelatedEntityInformant12.templateId 
         * Conformance/Cardinality: OPTIONAL (0-*) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * DiagnosticImagingReport.RelatedEntityInformant12.templateId 
         * Conformance/Cardinality: OPTIONAL (0-*) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * OperativeNote.RelatedEntityInformant12.templateId 
         * Conformance/Cardinality: OPTIONAL (0-*) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * ContinuityOfCareDocumentCCD.RelatedEntityInformant12.templateId 
         * Conformance/Cardinality: OPTIONAL (0-*) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * USRealmHeader.RelatedEntityInformant12.templateId 
         * Conformance/Cardinality: OPTIONAL (0-*) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * ProgressNote.RelatedEntityInformant12.templateId 
         * Conformance/Cardinality: OPTIONAL (0-*) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * ConsultationNote.RelatedEntityInformant12.templateId 
         * Conformance/Cardinality: OPTIONAL (0-*) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * UnstructuredDocument.RelatedEntityInformant12.templateId 
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
         * ProcedureNote.RelatedEntityRelatedEntity.classCode 
         * Conformance/Cardinality: MANDATORY (1) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * HistoryAndPhysical.RelatedEntityRelatedEntity.classCode 
         * Conformance/Cardinality: MANDATORY (1) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * DischargeSummary.RelatedEntityRelatedEntity.classCode 
         * Conformance/Cardinality: MANDATORY (1) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * DiagnosticImagingReport.RelatedEntityRelatedEntity.classCode 
         * Conformance/Cardinality: MANDATORY (1) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * OperativeNote.RelatedEntityRelatedEntity.classCode 
         * Conformance/Cardinality: MANDATORY (1) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * ContinuityOfCareDocumentCCD.RelatedEntityRelatedEntity.classCode 
         * Conformance/Cardinality: MANDATORY (1) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * USRealmHeader.RelatedEntityRelatedEntity.classCode 
         * Conformance/Cardinality: MANDATORY (1) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * ProgressNote.RelatedEntityRelatedEntity.classCode 
         * Conformance/Cardinality: MANDATORY (1) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * ConsultationNote.RelatedEntityRelatedEntity.classCode 
         * Conformance/Cardinality: MANDATORY (1) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * UnstructuredDocument.RelatedEntityRelatedEntity.classCode 
         * Conformance/Cardinality: MANDATORY (1)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"relatedEntity/classCode"})]
        public CodedTypeR2<Ca.Infoway.Messagebuilder.Model.Ccda_r1_1.Domainvalue.RoleClassMutualRelationship> RelatedEntityClassCode {
            get { return (CodedTypeR2<Ca.Infoway.Messagebuilder.Model.Ccda_r1_1.Domainvalue.RoleClassMutualRelationship>) this.relatedEntityClassCode.Value; }
            set { this.relatedEntityClassCode.Value = value; }
        }

        /**
         * <summary>Un-merged Business Name: (no business name 
         * specified)</summary>
         * 
         * <remarks>Relationship: 
         * ProcedureNote.RelatedEntityRelatedEntity.typeId 
         * Conformance/Cardinality: OPTIONAL (0-1) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * HistoryAndPhysical.RelatedEntityRelatedEntity.typeId 
         * Conformance/Cardinality: OPTIONAL (0-1) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * DischargeSummary.RelatedEntityRelatedEntity.typeId 
         * Conformance/Cardinality: OPTIONAL (0-1) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * DiagnosticImagingReport.RelatedEntityRelatedEntity.typeId 
         * Conformance/Cardinality: OPTIONAL (0-1) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * OperativeNote.RelatedEntityRelatedEntity.typeId 
         * Conformance/Cardinality: OPTIONAL (0-1) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * ContinuityOfCareDocumentCCD.RelatedEntityRelatedEntity.typeId 
         * Conformance/Cardinality: OPTIONAL (0-1) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * USRealmHeader.RelatedEntityRelatedEntity.typeId 
         * Conformance/Cardinality: OPTIONAL (0-1) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * ProgressNote.RelatedEntityRelatedEntity.typeId 
         * Conformance/Cardinality: OPTIONAL (0-1) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * ConsultationNote.RelatedEntityRelatedEntity.typeId 
         * Conformance/Cardinality: OPTIONAL (0-1) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * UnstructuredDocument.RelatedEntityRelatedEntity.typeId 
         * Conformance/Cardinality: OPTIONAL (0-1)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"relatedEntity/typeId"})]
        public Identifier RelatedEntityTypeId {
            get { return this.relatedEntityTypeId.Value; }
            set { this.relatedEntityTypeId.Value = value; }
        }

        /**
         * <summary>Un-merged Business Name: (no business name 
         * specified)</summary>
         * 
         * <remarks>Relationship: 
         * ProcedureNote.RelatedEntityRelatedEntity.templateId 
         * Conformance/Cardinality: OPTIONAL (0-*) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * HistoryAndPhysical.RelatedEntityRelatedEntity.templateId 
         * Conformance/Cardinality: OPTIONAL (0-*) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * DischargeSummary.RelatedEntityRelatedEntity.templateId 
         * Conformance/Cardinality: OPTIONAL (0-*) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * DiagnosticImagingReport.RelatedEntityRelatedEntity.templateId 
         * Conformance/Cardinality: OPTIONAL (0-*) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * OperativeNote.RelatedEntityRelatedEntity.templateId 
         * Conformance/Cardinality: OPTIONAL (0-*) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * ContinuityOfCareDocumentCCD.RelatedEntityRelatedEntity.templateId 
         * Conformance/Cardinality: OPTIONAL (0-*) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * USRealmHeader.RelatedEntityRelatedEntity.templateId 
         * Conformance/Cardinality: OPTIONAL (0-*) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * ProgressNote.RelatedEntityRelatedEntity.templateId 
         * Conformance/Cardinality: OPTIONAL (0-*) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * ConsultationNote.RelatedEntityRelatedEntity.templateId 
         * Conformance/Cardinality: OPTIONAL (0-*) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * UnstructuredDocument.RelatedEntityRelatedEntity.templateId 
         * Conformance/Cardinality: OPTIONAL (0-*)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"relatedEntity/templateId"})]
        public IList<Identifier> RelatedEntityTemplateId {
            get { return this.relatedEntityTemplateId.RawList(); }
        }

        /**
         * <summary>Un-merged Business Name: (no business name 
         * specified)</summary>
         * 
         * <remarks>Relationship: 
         * ProcedureNote.RelatedEntityRelatedEntity.code 
         * Conformance/Cardinality: OPTIONAL (0-1) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * HistoryAndPhysical.RelatedEntityRelatedEntity.code 
         * Conformance/Cardinality: OPTIONAL (0-1) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * DischargeSummary.RelatedEntityRelatedEntity.code 
         * Conformance/Cardinality: OPTIONAL (0-1) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * DiagnosticImagingReport.RelatedEntityRelatedEntity.code 
         * Conformance/Cardinality: OPTIONAL (0-1) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * OperativeNote.RelatedEntityRelatedEntity.code 
         * Conformance/Cardinality: OPTIONAL (0-1) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * ContinuityOfCareDocumentCCD.RelatedEntityRelatedEntity.code 
         * Conformance/Cardinality: OPTIONAL (0-1) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * USRealmHeader.RelatedEntityRelatedEntity.code 
         * Conformance/Cardinality: OPTIONAL (0-1) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * ProgressNote.RelatedEntityRelatedEntity.code 
         * Conformance/Cardinality: OPTIONAL (0-1) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * ConsultationNote.RelatedEntityRelatedEntity.code 
         * Conformance/Cardinality: OPTIONAL (0-1) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * UnstructuredDocument.RelatedEntityRelatedEntity.code 
         * Conformance/Cardinality: OPTIONAL (0-1)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"relatedEntity/code"})]
        public CodedTypeR2<Code> RelatedEntityCode {
            get { return (CodedTypeR2<Code>) this.relatedEntityCode.Value; }
            set { this.relatedEntityCode.Value = value; }
        }

        /**
         * <summary>Un-merged Business Name: (no business name 
         * specified)</summary>
         * 
         * <remarks>Relationship: 
         * ProcedureNote.RelatedEntityRelatedEntity.addr 
         * Conformance/Cardinality: OPTIONAL (0-*) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * HistoryAndPhysical.RelatedEntityRelatedEntity.addr 
         * Conformance/Cardinality: OPTIONAL (0-*) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * DischargeSummary.RelatedEntityRelatedEntity.addr 
         * Conformance/Cardinality: OPTIONAL (0-*) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * DiagnosticImagingReport.RelatedEntityRelatedEntity.addr 
         * Conformance/Cardinality: OPTIONAL (0-*) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * OperativeNote.RelatedEntityRelatedEntity.addr 
         * Conformance/Cardinality: OPTIONAL (0-*) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * ContinuityOfCareDocumentCCD.RelatedEntityRelatedEntity.addr 
         * Conformance/Cardinality: OPTIONAL (0-*) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * USRealmHeader.RelatedEntityRelatedEntity.addr 
         * Conformance/Cardinality: OPTIONAL (0-*) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * ProgressNote.RelatedEntityRelatedEntity.addr 
         * Conformance/Cardinality: OPTIONAL (0-*) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * ConsultationNote.RelatedEntityRelatedEntity.addr 
         * Conformance/Cardinality: OPTIONAL (0-*) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * UnstructuredDocument.RelatedEntityRelatedEntity.addr 
         * Conformance/Cardinality: OPTIONAL (0-*)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"relatedEntity/addr"})]
        public IList<PostalAddress> RelatedEntityAddr {
            get { return this.relatedEntityAddr.RawList(); }
        }

        /**
         * <summary>Un-merged Business Name: (no business name 
         * specified)</summary>
         * 
         * <remarks>Relationship: 
         * ProcedureNote.RelatedEntityRelatedEntity.telecom 
         * Conformance/Cardinality: OPTIONAL (0-*) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * HistoryAndPhysical.RelatedEntityRelatedEntity.telecom 
         * Conformance/Cardinality: OPTIONAL (0-*) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * DischargeSummary.RelatedEntityRelatedEntity.telecom 
         * Conformance/Cardinality: OPTIONAL (0-*) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * DiagnosticImagingReport.RelatedEntityRelatedEntity.telecom 
         * Conformance/Cardinality: OPTIONAL (0-*) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * OperativeNote.RelatedEntityRelatedEntity.telecom 
         * Conformance/Cardinality: OPTIONAL (0-*) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * ContinuityOfCareDocumentCCD.RelatedEntityRelatedEntity.telecom 
         * Conformance/Cardinality: OPTIONAL (0-*) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * USRealmHeader.RelatedEntityRelatedEntity.telecom 
         * Conformance/Cardinality: OPTIONAL (0-*) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * ProgressNote.RelatedEntityRelatedEntity.telecom 
         * Conformance/Cardinality: OPTIONAL (0-*) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * ConsultationNote.RelatedEntityRelatedEntity.telecom 
         * Conformance/Cardinality: OPTIONAL (0-*) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * UnstructuredDocument.RelatedEntityRelatedEntity.telecom 
         * Conformance/Cardinality: OPTIONAL (0-*)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"relatedEntity/telecom"})]
        public IList<TelecommunicationAddress> RelatedEntityTelecom {
            get { return this.relatedEntityTelecom.RawList(); }
        }

        /**
         * <summary>Un-merged Business Name: (no business name 
         * specified)</summary>
         * 
         * <remarks>Relationship: 
         * ProcedureNote.RelatedEntityRelatedEntity.effectiveTime 
         * Conformance/Cardinality: OPTIONAL (0-1) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * HistoryAndPhysical.RelatedEntityRelatedEntity.effectiveTime 
         * Conformance/Cardinality: OPTIONAL (0-1) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * DischargeSummary.RelatedEntityRelatedEntity.effectiveTime 
         * Conformance/Cardinality: OPTIONAL (0-1) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * DiagnosticImagingReport.RelatedEntityRelatedEntity.effectiveTime 
         * Conformance/Cardinality: OPTIONAL (0-1) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * OperativeNote.RelatedEntityRelatedEntity.effectiveTime 
         * Conformance/Cardinality: OPTIONAL (0-1) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * ContinuityOfCareDocumentCCD.RelatedEntityRelatedEntity.effectiveTime 
         * Conformance/Cardinality: OPTIONAL (0-1) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * USRealmHeader.RelatedEntityRelatedEntity.effectiveTime 
         * Conformance/Cardinality: OPTIONAL (0-1) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * ProgressNote.RelatedEntityRelatedEntity.effectiveTime 
         * Conformance/Cardinality: OPTIONAL (0-1) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * ConsultationNote.RelatedEntityRelatedEntity.effectiveTime 
         * Conformance/Cardinality: OPTIONAL (0-1) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * UnstructuredDocument.RelatedEntityRelatedEntity.effectiveTime 
         * Conformance/Cardinality: OPTIONAL (0-1)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"relatedEntity/effectiveTime"})]
        public DateInterval RelatedEntityEffectiveTime {
            get { return this.relatedEntityEffectiveTime.Value; }
            set { this.relatedEntityEffectiveTime.Value = value; }
        }

        /**
         * <summary>Un-merged Business Name: (no business name 
         * specified)</summary>
         * 
         * <remarks>Relationship: 
         * ProcedureNote.RelatedEntityRelatedEntity.relatedPerson 
         * Conformance/Cardinality: OPTIONAL (0-1) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * HistoryAndPhysical.RelatedEntityRelatedEntity.relatedPerson 
         * Conformance/Cardinality: OPTIONAL (0-1) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * DischargeSummary.RelatedEntityRelatedEntity.relatedPerson 
         * Conformance/Cardinality: OPTIONAL (0-1) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * DiagnosticImagingReport.RelatedEntityRelatedEntity.relatedPerson 
         * Conformance/Cardinality: OPTIONAL (0-1) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * OperativeNote.RelatedEntityRelatedEntity.relatedPerson 
         * Conformance/Cardinality: OPTIONAL (0-1) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * ContinuityOfCareDocumentCCD.RelatedEntityRelatedEntity.relatedPerson 
         * Conformance/Cardinality: OPTIONAL (0-1) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * USRealmHeader.RelatedEntityRelatedEntity.relatedPerson 
         * Conformance/Cardinality: OPTIONAL (0-1) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * ProgressNote.RelatedEntityRelatedEntity.relatedPerson 
         * Conformance/Cardinality: OPTIONAL (0-1) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * ConsultationNote.RelatedEntityRelatedEntity.relatedPerson 
         * Conformance/Cardinality: OPTIONAL (0-1) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * UnstructuredDocument.RelatedEntityRelatedEntity.relatedPerson 
         * Conformance/Cardinality: OPTIONAL (0-1)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"relatedEntity/relatedPerson"})]
        public Ca.Infoway.Messagebuilder.Model.Ccda_r1_1.Basemodel.Person RelatedEntityRelatedPerson {
            get { return this.relatedEntityRelatedPerson; }
            set { this.relatedEntityRelatedPerson = value; }
        }

    }

}