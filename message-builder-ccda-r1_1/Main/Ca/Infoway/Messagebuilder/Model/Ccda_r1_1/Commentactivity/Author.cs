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
namespace Ca.Infoway.Messagebuilder.Model.Ccda_r1_1.Commentactivity {
    using Ca.Infoway.Messagebuilder;
    using Ca.Infoway.Messagebuilder.Annotation;
    using Ca.Infoway.Messagebuilder.Datatype;
    using Ca.Infoway.Messagebuilder.Datatype.Impl;
    using Ca.Infoway.Messagebuilder.Datatype.Lang;
    using Ca.Infoway.Messagebuilder.Model;
    using System.Collections.Generic;


    [Hl7PartTypeMappingAttribute(new string[] {"CommentActivity.Author"})]
    public class Author : MessagePartBean {

        private II typeId;
        private LIST<II, Identifier> templateId;
        private CE_R2<Code> functionCode;
        private TS_R2 time;
        private Ca.Infoway.Messagebuilder.Model.Ccda_r1_1.Commentactivity.AssignedAuthor assignedAuthor;

        public Author() {
            this.typeId = new IIImpl();
            this.templateId = new LISTImpl<II, Identifier>(typeof(IIImpl));
            this.functionCode = new CE_R2Impl<Code>();
            this.time = new TS_R2Impl();
        }
        /**
         * <summary>Relationship: CommentActivity.Author.typeId</summary>
         * 
         * <remarks>Conformance/Cardinality: OPTIONAL (0-1)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"typeId"})]
        public Identifier TypeId {
            get { return this.typeId.Value; }
            set { this.typeId.Value = value; }
        }

        /**
         * <summary>Relationship: CommentActivity.Author.templateId</summary>
         * 
         * <remarks>Conformance/Cardinality: OPTIONAL (0-*)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"templateId"})]
        public IList<Identifier> TemplateId {
            get { return this.templateId.RawList(); }
        }

        /**
         * <summary>Relationship: CommentActivity.Author.functionCode</summary>
         * 
         * <remarks>Conformance/Cardinality: OPTIONAL (0-1)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"functionCode"})]
        public CodedTypeR2<Code> FunctionCode {
            get { return (CodedTypeR2<Code>) this.functionCode.Value; }
            set { this.functionCode.Value = value; }
        }

        /**
         * <summary>Relationship: CommentActivity.Author.time</summary>
         * 
         * <remarks>Conformance/Cardinality: POPULATED (1)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"time"})]
        public MbDate Time {
            get { return this.time.Value; }
            set { this.time.Value = value; }
        }

        /**
         * <summary>Relationship: CommentActivity.Author.assignedAuthor</summary>
         * 
         * <remarks>Conformance/Cardinality: POPULATED (1)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"assignedAuthor"})]
        public Ca.Infoway.Messagebuilder.Model.Ccda_r1_1.Commentactivity.AssignedAuthor AssignedAuthor {
            get { return this.assignedAuthor; }
            set { this.assignedAuthor = value; }
        }

    }

}