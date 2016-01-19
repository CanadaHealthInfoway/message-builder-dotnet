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
    using System.Collections.Generic;


    [Hl7PartTypeMappingAttribute(new string[] {"ConsultationNote.DataEntererPerson","ContinuityOfCareDocumentCCD.DataEntererPerson","DiagnosticImagingReport.DataEntererPerson","DischargeSummary.DataEntererPerson","HistoryAndPhysical.DataEntererPerson","OperativeNote.DataEntererPerson","ProcedureNote.DataEntererPerson","ProgressNote.DataEntererPerson","USRealmHeader.DataEntererPerson","UnstructuredDocument.DataEntererPerson"})]
    public class DataEntererPerson : MessagePartBean {

        private II typeId;
        private LIST<II, Identifier> templateId;
        private LIST<PN, PersonName> name;

        public DataEntererPerson() {
            this.typeId = new IIImpl();
            this.templateId = new LISTImpl<II, Identifier>(typeof(IIImpl));
            this.name = new LISTImpl<PN, PersonName>(typeof(PNImpl));
        }
        /**
         * <summary>Un-merged Business Name: (no business name 
         * specified)</summary>
         * 
         * <remarks>Relationship: 
         * ContinuityOfCareDocumentCCD.DataEntererPerson.typeId 
         * Conformance/Cardinality: OPTIONAL (0-1) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * ConsultationNote.DataEntererPerson.typeId 
         * Conformance/Cardinality: OPTIONAL (0-1) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * DischargeSummary.DataEntererPerson.typeId 
         * Conformance/Cardinality: OPTIONAL (0-1) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * ProcedureNote.DataEntererPerson.typeId 
         * Conformance/Cardinality: OPTIONAL (0-1) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * OperativeNote.DataEntererPerson.typeId 
         * Conformance/Cardinality: OPTIONAL (0-1) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * DiagnosticImagingReport.DataEntererPerson.typeId 
         * Conformance/Cardinality: OPTIONAL (0-1) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * UnstructuredDocument.DataEntererPerson.typeId 
         * Conformance/Cardinality: OPTIONAL (0-1) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * USRealmHeader.DataEntererPerson.typeId 
         * Conformance/Cardinality: OPTIONAL (0-1) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * HistoryAndPhysical.DataEntererPerson.typeId 
         * Conformance/Cardinality: OPTIONAL (0-1) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * ProgressNote.DataEntererPerson.typeId 
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
         * ContinuityOfCareDocumentCCD.DataEntererPerson.templateId 
         * Conformance/Cardinality: OPTIONAL (0-*) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * ConsultationNote.DataEntererPerson.templateId 
         * Conformance/Cardinality: OPTIONAL (0-*) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * DischargeSummary.DataEntererPerson.templateId 
         * Conformance/Cardinality: OPTIONAL (0-*) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * ProcedureNote.DataEntererPerson.templateId 
         * Conformance/Cardinality: OPTIONAL (0-*) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * OperativeNote.DataEntererPerson.templateId 
         * Conformance/Cardinality: OPTIONAL (0-*) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * DiagnosticImagingReport.DataEntererPerson.templateId 
         * Conformance/Cardinality: OPTIONAL (0-*) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * UnstructuredDocument.DataEntererPerson.templateId 
         * Conformance/Cardinality: OPTIONAL (0-*) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * USRealmHeader.DataEntererPerson.templateId 
         * Conformance/Cardinality: OPTIONAL (0-*) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * HistoryAndPhysical.DataEntererPerson.templateId 
         * Conformance/Cardinality: OPTIONAL (0-*) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * ProgressNote.DataEntererPerson.templateId 
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
         * ContinuityOfCareDocumentCCD.DataEntererPerson.name 
         * Conformance/Cardinality: POPULATED (*) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * ConsultationNote.DataEntererPerson.name 
         * Conformance/Cardinality: POPULATED (*) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * DischargeSummary.DataEntererPerson.name 
         * Conformance/Cardinality: POPULATED (*) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * ProcedureNote.DataEntererPerson.name 
         * Conformance/Cardinality: POPULATED (*) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * OperativeNote.DataEntererPerson.name 
         * Conformance/Cardinality: POPULATED (*) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * DiagnosticImagingReport.DataEntererPerson.name 
         * Conformance/Cardinality: POPULATED (*) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * UnstructuredDocument.DataEntererPerson.name 
         * Conformance/Cardinality: POPULATED (*) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * USRealmHeader.DataEntererPerson.name 
         * Conformance/Cardinality: POPULATED (*) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * HistoryAndPhysical.DataEntererPerson.name 
         * Conformance/Cardinality: POPULATED (*) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * ProgressNote.DataEntererPerson.name Conformance/Cardinality: 
         * POPULATED (*)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"name"})]
        public IList<PersonName> Name {
            get { return this.name.RawList(); }
        }

    }

}