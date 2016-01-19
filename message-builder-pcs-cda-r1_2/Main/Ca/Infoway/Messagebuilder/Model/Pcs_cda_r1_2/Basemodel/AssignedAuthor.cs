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
namespace Ca.Infoway.Messagebuilder.Model.Pcs_cda_r1_2.Basemodel {
    using Ca.Infoway.Messagebuilder;
    using Ca.Infoway.Messagebuilder.Annotation;
    using Ca.Infoway.Messagebuilder.Datatype;
    using Ca.Infoway.Messagebuilder.Datatype.Impl;
    using Ca.Infoway.Messagebuilder.Datatype.Lang;
    using Ca.Infoway.Messagebuilder.Model;
    using Ca.Infoway.Messagebuilder.Model.Pcs_cda_r1_2.Merged;
    using System.Collections.Generic;


    [Hl7PartTypeMappingAttribute(new string[] {"BaseModel.AssignedAuthor"})]
    public class AssignedAuthor : MessagePartBean {

        private II typeId;
        private LIST<II, Identifier> templateId;
        private LIST<II, Identifier> id;
        private CE code;
        private LIST<AD, PostalAddress> addr;
        private LIST<TEL, TelecommunicationAddress> telecom;
        private Ca.Infoway.Messagebuilder.Model.Pcs_cda_r1_2.Basemodel.IAssignedAuthorChoice assignedAuthorChoice;
        private Ca.Infoway.Messagebuilder.Model.Pcs_cda_r1_2.Basemodel.Organization representedOrganization;

        public AssignedAuthor() {
            this.typeId = new IIImpl();
            this.templateId = new LISTImpl<II, Identifier>(typeof(IIImpl));
            this.id = new LISTImpl<II, Identifier>(typeof(IIImpl));
            this.code = new CEImpl();
            this.addr = new LISTImpl<AD, PostalAddress>(typeof(ADImpl));
            this.telecom = new LISTImpl<TEL, TelecommunicationAddress>(typeof(TELImpl));
        }
        /**
         * <summary>Relationship: BaseModel.AssignedAuthor.typeId</summary>
         * 
         * <remarks>Conformance/Cardinality: OPTIONAL (0-1)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"typeId"})]
        public Identifier TypeId {
            get { return this.typeId.Value; }
            set { this.typeId.Value = value; }
        }

        /**
         * <summary>Relationship: BaseModel.AssignedAuthor.templateId</summary>
         * 
         * <remarks>Conformance/Cardinality: OPTIONAL (0-*)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"templateId"})]
        public IList<Identifier> TemplateId {
            get { return this.templateId.RawList(); }
        }

        /**
         * <summary>Relationship: BaseModel.AssignedAuthor.id</summary>
         * 
         * <remarks>Conformance/Cardinality: POPULATED (*)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"id"})]
        public IList<Identifier> Id {
            get { return this.id.RawList(); }
        }

        /**
         * <summary>Relationship: BaseModel.AssignedAuthor.code</summary>
         * 
         * <remarks>Conformance/Cardinality: OPTIONAL (0-1)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"code"})]
        public Code Code {
            get { return (Code) this.code.Value; }
            set { this.code.Value = value; }
        }

        /**
         * <summary>Relationship: BaseModel.AssignedAuthor.addr</summary>
         * 
         * <remarks>Conformance/Cardinality: OPTIONAL (0-*)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"addr"})]
        public IList<PostalAddress> Addr {
            get { return this.addr.RawList(); }
        }

        /**
         * <summary>Relationship: BaseModel.AssignedAuthor.telecom</summary>
         * 
         * <remarks>Conformance/Cardinality: OPTIONAL (0-*)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"telecom"})]
        public IList<TelecommunicationAddress> Telecom {
            get { return this.telecom.RawList(); }
        }

        /**
         * <summary>Relationship: 
         * BaseModel.AssignedAuthor.assignedAuthorChoice</summary>
         * 
         * <remarks>Conformance/Cardinality: OPTIONAL (0-1)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"assignedAuthorChoice"})]
        public Ca.Infoway.Messagebuilder.Model.Pcs_cda_r1_2.Basemodel.IAssignedAuthorChoice AssignedAuthorChoice {
            get { return this.assignedAuthorChoice; }
            set { this.assignedAuthorChoice = value; }
        }

        public Ca.Infoway.Messagebuilder.Model.Pcs_cda_r1_2.Basemodel.Person AssignedAuthorChoiceAsAssignedPerson {
            get { return this.assignedAuthorChoice is Ca.Infoway.Messagebuilder.Model.Pcs_cda_r1_2.Basemodel.Person ? (Ca.Infoway.Messagebuilder.Model.Pcs_cda_r1_2.Basemodel.Person) this.assignedAuthorChoice : (Ca.Infoway.Messagebuilder.Model.Pcs_cda_r1_2.Basemodel.Person) null; }
        }
        public bool HasAssignedAuthorChoiceAsAssignedPerson() {
            return (this.assignedAuthorChoice is Ca.Infoway.Messagebuilder.Model.Pcs_cda_r1_2.Basemodel.Person);
        }

        public Ca.Infoway.Messagebuilder.Model.Pcs_cda_r1_2.Merged.AuthoringDevice AssignedAuthorChoiceAsAssignedAuthoringDevice {
            get { return this.assignedAuthorChoice is Ca.Infoway.Messagebuilder.Model.Pcs_cda_r1_2.Merged.AuthoringDevice ? (Ca.Infoway.Messagebuilder.Model.Pcs_cda_r1_2.Merged.AuthoringDevice) this.assignedAuthorChoice : (Ca.Infoway.Messagebuilder.Model.Pcs_cda_r1_2.Merged.AuthoringDevice) null; }
        }
        public bool HasAssignedAuthorChoiceAsAssignedAuthoringDevice() {
            return (this.assignedAuthorChoice is Ca.Infoway.Messagebuilder.Model.Pcs_cda_r1_2.Merged.AuthoringDevice);
        }

        /**
         * <summary>Relationship: 
         * BaseModel.AssignedAuthor.representedOrganization</summary>
         * 
         * <remarks>Conformance/Cardinality: OPTIONAL (0-1)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"representedOrganization"})]
        public Ca.Infoway.Messagebuilder.Model.Pcs_cda_r1_2.Basemodel.Organization RepresentedOrganization {
            get { return this.representedOrganization; }
            set { this.representedOrganization = value; }
        }

    }

}