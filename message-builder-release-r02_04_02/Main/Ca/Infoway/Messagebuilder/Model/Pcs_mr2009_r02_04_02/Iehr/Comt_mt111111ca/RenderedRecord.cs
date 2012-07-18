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
 * Last modified: $LastChangedDate: 2012-01-18 21:05:40 -0500 (Wed, 18 Jan 2012) $
 * Revision:      $LastChangedRevision: 3936 $
 */

/* This class was auto-generated by the message builder generator tools. */
namespace Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Iehr.Comt_mt111111ca {
    using Ca.Infoway.Messagebuilder;
    using Ca.Infoway.Messagebuilder.Annotation;
    using Ca.Infoway.Messagebuilder.Datatype;
    using Ca.Infoway.Messagebuilder.Datatype.Impl;
    using Ca.Infoway.Messagebuilder.Datatype.Lang;
    using Ca.Infoway.Messagebuilder.Model;


    /**
     * <summary>Rendered Record</summary>
     * 
     * <remarks><p>Conveys a portion of the patient's record as 
     * rendered content.</p> <p>Allows simple applications which do 
     * not yet support all of the discrete messaging specifications 
     * to still access data within the EHR.</p></remarks>
     */
    [Hl7PartTypeMappingAttribute(new string[] {"COMT_MT111111CA.RenderedContent"})]
    public class RenderedRecord : MessagePartBean, Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Iehr.Comt_mt111111ca.ISummary {

        private CV renderedContentType;
        private ED<EncapsulatedData> renderedContent;

        public RenderedRecord() {
            this.renderedContentType = new CVImpl();
            this.renderedContent = new EDImpl<EncapsulatedData>();
        }
        /**
         * <summary>Rendered Content Type</summary>
         * 
         * <remarks><p>Identifies the type of content contained within 
         * the rendered document portion of this class.</p> 
         * <p>Identifies what type of data has been returned. This 
         * attribute is mandatory because type of data returned must be 
         * known for presentation and consumption.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"code"})]
        public Code RenderedContentType {
            get { return (Code) this.renderedContentType.Value; }
            set { this.renderedContentType.Value = value; }
        }

        /**
         * <summary>Rendered Content</summary>
         * 
         * <remarks><p>Contains a rendered view of a particular portion 
         * of the patients records. E.g. Allergy List, Problem List, 
         * Drug List, etc.</p> <p>Provides a human-readable view of a 
         * portion of a patient's record when the PoS application may 
         * not be capable of handling the discrete data. This attribute 
         * is mandatory because the rendered content must be known.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"text"})]
        public EncapsulatedData RenderedContent {
            get { return this.renderedContent.Value; }
            set { this.renderedContent.Value = value; }
        }

    }

}