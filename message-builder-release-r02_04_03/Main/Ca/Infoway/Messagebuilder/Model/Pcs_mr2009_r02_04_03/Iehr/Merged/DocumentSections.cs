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
 * Last modified: $LastChangedDate: 2011-05-04 16:47:15 -0300 (Wed, 04 May 2011) $
 * Revision:      $LastChangedRevision: 2623 $
 */
/* This class was auto-generated by the message builder generator tools. */
namespace Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Iehr.Merged {
    using Ca.Infoway.Messagebuilder.Annotation;
    using Ca.Infoway.Messagebuilder.Datatype;
    using Ca.Infoway.Messagebuilder.Datatype.Impl;
    using Ca.Infoway.Messagebuilder.Datatype.Lang;
    using Ca.Infoway.Messagebuilder.Domainvalue;
    using Ca.Infoway.Messagebuilder.Model;
    using System;
    using System.Collections.Generic;


    /**
     * <summary>DocumentSections</summary>
     * 
     * <remarks>REPC_MT220001CA.SubSection: Document Sections 
     * <p>Used to document additional relevant information about 
     * the patient such as allergies, medications, problem list, 
     * etc.</p> <p>Provides contextual information for 
     * understanding the Discharge-Care Summary by sharing a 
     * filtered, rendered view of portions of the patient's 
     * record.</p> REPC_MT230003CA.SubSection: Document Sections 
     * <p>Used to document additional relevant information about 
     * the patient such as allergies, medications, problem list, 
     * etc.</p> <p>Provides contextual information for 
     * understanding the Clinical Observation Document by sharing a 
     * filtered, rendered view of portions of the patient's 
     * record.</p> REPC_MT220003CA.SubSection: Document Sections 
     * <p>Used to document additional relevant information about 
     * the patient such as allergies, medications, problem list, 
     * etc.</p> <p>Provides contextual information for 
     * understanding the Discharge-Care Summary by sharing a 
     * filtered, rendered view of portions of the patient's 
     * record.</p> REPC_MT210003CA.SubSection: Document Sections 
     * <p>Used to document additional relevant information about 
     * the patient such as allergies, medications, problem list, 
     * etc.</p> <p>Provides contextual information for 
     * understanding the Referral by sharing a filtered, rendered 
     * view of portions of the patient's record.</p> 
     * REPC_MT230001CA.SubSection: Document Sections <p>Used to 
     * document additional relevant information about the patient 
     * such as allergies, medications, problem list, etc.</p> 
     * <p>Provides contextual information for understanding the 
     * Clinical Observation Document by sharing a filtered, 
     * rendered view of portions of the patient's record.</p></remarks>
     */
    [Hl7PartTypeMappingAttribute(new string[] {"REPC_MT210001CA.SubSection","REPC_MT210003CA.SubSection","REPC_MT220001CA.SubSection","REPC_MT220003CA.SubSection","REPC_MT230001CA.SubSection","REPC_MT230003CA.SubSection"})]
    public class DocumentSections : MessagePartBean {

        private CV code;
        private ST title;
        private ED<EncapsulatedData> text;
        private IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Iehr.Merged.Reference> componentReference;

        public DocumentSections() {
            this.code = new CVImpl();
            this.title = new STImpl();
            this.text = new EDImpl<EncapsulatedData>();
            this.componentReference = new List<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Iehr.Merged.Reference>();
        }
        /**
         * <summary>SectionType</summary>
         * 
         * <remarks>A: Section Type </p><p>Examples: allergy list, 
         * problem list, medication list, etc.</p> </p><p>Examples: 
         * allergy list, problem list, medication list, etc.</p> </p> 
         * </p> </p> A: Section Type A: Section Type </p><p>Examples: 
         * allergy list, problem list, medication list, etc.</p> 
         * </p><p>Examples: allergy list, problem list, medication 
         * list, etc.</p> </p> </p> </p> A: Section Type 
         * </p><p>Examples: allergy list, problem list, medication 
         * list, etc.</p> </p><p>Examples: allergy list, problem list, 
         * medication list, etc.</p> </p> </p> </p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"code"})]
        public DocumentSectionType Code {
            get { return (DocumentSectionType) this.code.Value; }
            set { this.code.Value = value; }
        }

        /**
         * <summary>SectionTitle</summary>
         * 
         * <remarks>B: Section Title <p>Represents the label associated 
         * with this particular portion of the document. These are a 
         * human-readable equivalents to the Section Type code. E.g. 
         * &quot;Allergies&quot;, &quot;Assessment&quot;, 
         * &quot;Recommendations&quot;, etc.</p> <p>Provides a human 
         * readable label for the section. Because it is used as part 
         * of the document rendering, the attribute is mandatory.</p> 
         * B: Section Title <p>Represents the label associated with 
         * this particular portion of the document. These are 
         * human-readable equivalents to the Section Type code. E.g. 
         * &quot;Allergies&quot;, &quot;Assessment&quot;, 
         * &quot;Recommendations&quot;, etc.</p> <p>Provides a human 
         * readable label for the section. Because it is used as part 
         * of the document rendering, the attribute is mandatory.</p> 
         * B: Section Title</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"title"})]
        public String Title {
            get { return this.title.Value; }
            set { this.title.Value = value; }
        }

        /**
         * <summary>SectionContent</summary>
         * 
         * <remarks>M: Section Content M: Section Content <p>Represents 
         * the rendered text content for the section.</p> <p>Provides a 
         * human-readable view of data that is accessible without 
         * sophisticated PoS applications. Allows data to be filtered 
         * and rendered in a manner to focus on the content deemed 
         * relevant by the author of the document. Because it conveys 
         * the content, the attribute must be mandatory.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"text"})]
        public EncapsulatedData Text {
            get { return this.text.Value; }
            set { this.text.Value = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"component/reference"})]
        public IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Iehr.Merged.Reference> ComponentReference {
            get { return this.componentReference; }
        }

    }

}