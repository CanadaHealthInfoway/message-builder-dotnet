/**
 * Copyright 2012 Canada Health Infoway, Inc.
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
 * Last modified: $LastChangedDate: 2012-01-18 21:08:29 -0500 (Wed, 18 Jan 2012) $
 * Revision:      $LastChangedRevision: 3975 $
 */

/* This class was auto-generated by the message builder generator tools. */
namespace Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Immunization.Poiz_mt070020ca {
    using Ca.Infoway.Messagebuilder.Annotation;
    using Ca.Infoway.Messagebuilder.Datatype;
    using Ca.Infoway.Messagebuilder.Datatype.Impl;
    using Ca.Infoway.Messagebuilder.Datatype.Lang;
    using Ca.Infoway.Messagebuilder.Model;


    [Hl7PartTypeMappingAttribute(new string[] {"POIZ_MT070020CA.Attachment"})]
    public class Attachment : MessagePartBean {

        private II attachmentIdentifier;
        private ED<EncapsulatedData> attachmentContent;

        public Attachment() {
            this.attachmentIdentifier = new IIImpl();
            this.attachmentContent = new EDImpl<EncapsulatedData>();
        }
        /**
         * <summary>Attachment Identifier</summary>
         */
        [Hl7XmlMappingAttribute(new string[] {"id"})]
        public Identifier AttachmentIdentifier {
            get { return this.attachmentIdentifier.Value; }
            set { this.attachmentIdentifier.Value = value; }
        }

        /**
         * <summary>Attachment Content</summary>
         */
        [Hl7XmlMappingAttribute(new string[] {"text"})]
        public EncapsulatedData AttachmentContent {
            get { return this.attachmentContent.Value; }
            set { this.attachmentContent.Value = value; }
        }

    }

}