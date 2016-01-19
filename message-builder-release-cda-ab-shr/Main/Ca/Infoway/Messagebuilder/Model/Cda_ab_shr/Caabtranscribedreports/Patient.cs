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
namespace Ca.Infoway.Messagebuilder.Model.Cda_ab_shr.Caabtranscribedreports {
    using Ca.Infoway.Messagebuilder;
    using Ca.Infoway.Messagebuilder.Annotation;
    using Ca.Infoway.Messagebuilder.Datatype;
    using Ca.Infoway.Messagebuilder.Datatype.Impl;
    using Ca.Infoway.Messagebuilder.Datatype.Lang;
    using Ca.Infoway.Messagebuilder.Domainvalue;
    using Ca.Infoway.Messagebuilder.Model;
    using Ca.Infoway.Messagebuilder.Model.Cda_ab_shr.Basemodel;
    using Ca.Infoway.Messagebuilder.Model.Cda_ab_shr.Merged;
    using System.Collections.Generic;


    [Hl7PartTypeMappingAttribute(new string[] {"CAABTranscribedReports.Patient"})]
    public class Patient : MessagePartBean {

        private LIST<CS_R2<Code>, CodedTypeR2<Code>> realmCode;
        private II typeId;
        private LIST<II, Identifier> templateId;
        private II id;
        private PN name;
        private CV_R2<AdministrativeGender> administrativeGenderCode;
        private TS_R2 birthTime;
        private CE_R2<Code> ethnicGroupCode;
        private IList<Ca.Infoway.Messagebuilder.Model.Cda_ab_shr.Basemodel.Guardian> guardian;
        private Ca.Infoway.Messagebuilder.Model.Cda_ab_shr.Basemodel.Birthplace birthplace;
        private IList<Ca.Infoway.Messagebuilder.Model.Cda_ab_shr.Merged.LanguageCommunication> languageCommunication;

        public Patient() {
            this.realmCode = new LISTImpl<CS_R2<Code>, CodedTypeR2<Code>>(typeof(CS_R2Impl<Code>));
            this.typeId = new IIImpl();
            this.templateId = new LISTImpl<II, Identifier>(typeof(IIImpl));
            this.id = new IIImpl();
            this.name = new PNImpl();
            this.administrativeGenderCode = new CV_R2Impl<AdministrativeGender>();
            this.birthTime = new TS_R2Impl();
            this.ethnicGroupCode = new CE_R2Impl<Code>();
            this.guardian = new List<Ca.Infoway.Messagebuilder.Model.Cda_ab_shr.Basemodel.Guardian>();
            this.languageCommunication = new List<Ca.Infoway.Messagebuilder.Model.Cda_ab_shr.Merged.LanguageCommunication>();
        }
        /**
         * <summary>Relationship: 
         * CAABTranscribedReports.Patient.realmCode</summary>
         * 
         * <remarks>Conformance/Cardinality: OPTIONAL (0-*)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"realmCode"})]
        public IList<CodedTypeR2<Code>> RealmCode {
            get { return this.realmCode.RawList<CodedTypeR2<Code>>(); }
        }

        /**
         * <summary>Relationship: CAABTranscribedReports.Patient.typeId</summary>
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
         * CAABTranscribedReports.Patient.templateId</summary>
         * 
         * <remarks>Conformance/Cardinality: OPTIONAL (0-*)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"templateId"})]
        public IList<Identifier> TemplateId {
            get { return this.templateId.RawList(); }
        }

        /**
         * <summary>Relationship: CAABTranscribedReports.Patient.id</summary>
         * 
         * <remarks>Conformance/Cardinality: OPTIONAL (0-1)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"id"})]
        public Identifier Id {
            get { return this.id.Value; }
            set { this.id.Value = value; }
        }

        /**
         * <summary>Relationship: CAABTranscribedReports.Patient.name</summary>
         * 
         * <remarks>Conformance/Cardinality: MANDATORY (1)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"name"})]
        public PersonName Name {
            get { return this.name.Value; }
            set { this.name.Value = value; }
        }

        /**
         * <summary>Relationship: 
         * CAABTranscribedReports.Patient.administrativeGenderCode</summary>
         * 
         * <remarks>Conformance/Cardinality: POPULATED (1)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"administrativeGenderCode"})]
        public CodedTypeR2<AdministrativeGender> AdministrativeGenderCode {
            get { return (CodedTypeR2<AdministrativeGender>) this.administrativeGenderCode.Value; }
            set { this.administrativeGenderCode.Value = value; }
        }

        /**
         * <summary>Relationship: 
         * CAABTranscribedReports.Patient.birthTime</summary>
         * 
         * <remarks>Conformance/Cardinality: POPULATED (1)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"birthTime"})]
        public MbDate BirthTime {
            get { return this.birthTime.Value; }
            set { this.birthTime.Value = value; }
        }

        /**
         * <summary>Relationship: 
         * CAABTranscribedReports.Patient.ethnicGroupCode</summary>
         * 
         * <remarks>Conformance/Cardinality: OPTIONAL (0-1)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"ethnicGroupCode"})]
        public CodedTypeR2<Code> EthnicGroupCode {
            get { return (CodedTypeR2<Code>) this.ethnicGroupCode.Value; }
            set { this.ethnicGroupCode.Value = value; }
        }

        /**
         * <summary>Relationship: 
         * CAABTranscribedReports.Patient.guardian</summary>
         * 
         * <remarks>Conformance/Cardinality: OPTIONAL (0-*)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"guardian"})]
        public IList<Ca.Infoway.Messagebuilder.Model.Cda_ab_shr.Basemodel.Guardian> Guardian {
            get { return this.guardian; }
        }

        /**
         * <summary>Relationship: 
         * CAABTranscribedReports.Patient.birthplace</summary>
         * 
         * <remarks>Conformance/Cardinality: OPTIONAL (0-1)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"birthplace"})]
        public Ca.Infoway.Messagebuilder.Model.Cda_ab_shr.Basemodel.Birthplace Birthplace {
            get { return this.birthplace; }
            set { this.birthplace = value; }
        }

        /**
         * <summary>Relationship: 
         * CAABTranscribedReports.Patient.languageCommunication</summary>
         * 
         * <remarks>Conformance/Cardinality: OPTIONAL (0-*)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"languageCommunication"})]
        public IList<Ca.Infoway.Messagebuilder.Model.Cda_ab_shr.Merged.LanguageCommunication> LanguageCommunication {
            get { return this.languageCommunication; }
        }

    }

}