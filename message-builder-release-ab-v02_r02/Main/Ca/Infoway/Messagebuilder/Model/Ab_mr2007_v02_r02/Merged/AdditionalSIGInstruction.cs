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
namespace Ca.Infoway.Messagebuilder.Model.Ab_mr2007_v02_r02.Merged {
    using Ca.Infoway.Messagebuilder.Annotation;
    using Ca.Infoway.Messagebuilder.Datatype;
    using Ca.Infoway.Messagebuilder.Datatype.Impl;
    using Ca.Infoway.Messagebuilder.Domainvalue;
    using Ca.Infoway.Messagebuilder.Model;
    using System;


    /**
     * <summary>AdditionalSIGInstruction</summary>
     * 
     * <remarks>COCT_MT270010CA.SupplementalInstruction: Additional 
     * SIG Instruction <p>- moodCode must be DEFN for drug 
     * definitions (such as as monographs) - moodCode must be RQO 
     * for orders; - moodCode must be EVN for dispenses and 
     * recording of other medications { x.; }</p> <p>This is a 
     * modifier for a specific dosage line or for the entire SIG. 
     * Examples are: On empty stomach, At breakfast, before 
     * bedtime, etc.</p> <p>Adds further constraint or flexibility 
     * to the primary administration instruction.</p> 
     * PORX_MT980040CA.SupplementalInstruction: Additional SIG 
     * Instruction <p>- moodCode must be DEFN for drug definitions 
     * (such as as monographs) - moodCode must be RQO for orders; - 
     * moodCode must be EVN for dispenses and recording of other 
     * medications { x.; }</p> <p>This is a modifier for a specific 
     * dosage line or for the entire SIG. Examples are: On empty 
     * stomach, At breakfast, before bedtime, etc.</p> <p>Adds 
     * further constraint or flexibility to the primary 
     * administration instruction.</p></remarks>
     */
    [Hl7PartTypeMappingAttribute(new string[] {"COCT_MT270010CA.SupplementalInstruction","PORX_MT980040CA.SupplementalInstruction"})]
    public class AdditionalSIGInstruction : MessagePartBean {

        private CS moodCode;
        private ST text;

        public AdditionalSIGInstruction() {
            this.moodCode = new CSImpl();
            this.text = new STImpl();
        }
        /**
         * <summary>DosageUsageContext</summary>
         * 
         * <remarks>Dosage Usage Context <p>Indicates the context of 
         * the administration.</p><p>moodCode = RQO, for administration 
         * instruction on orders</p><p>moodCode = EVN, for 
         * administration instruction on dispenses</p><p>moodCode = 
         * DEF, for administration instruction on medication definition 
         * documents/references (typically, monographs).</p> 
         * <p>Indicates the context of the 
         * administration.</p><p>moodCode = RQO, for administration 
         * instruction on orders</p><p>moodCode = EVN, for 
         * administration instruction on dispenses</p><p>moodCode = 
         * DEF, for administration instruction on medication definition 
         * documents/references (typically, monographs).</p> 
         * <p>Indicates the context of the 
         * administration.</p><p>moodCode = RQO, for administration 
         * instruction on orders</p><p>moodCode = EVN, for 
         * administration instruction on dispenses</p><p>moodCode = 
         * DEF, for administration instruction on medication definition 
         * documents/references (typically, monographs).</p> 
         * <p>Indicates the context of the 
         * administration.</p><p>moodCode = RQO, for administration 
         * instruction on orders</p><p>moodCode = EVN, for 
         * administration instruction on dispenses</p><p>moodCode = 
         * DEF, for administration instruction on medication definition 
         * documents/references (typically, monographs).</p> <p>Puts 
         * the class in context, and is therefore mandatory.</p> Dosage 
         * Usage Context <p>Indicates the context of the 
         * administration.</p><p>moodCode = RQO, for administration 
         * instruction on orders</p><p>moodCode = EVN, for 
         * administration instruction on dispenses</p><p>moodCode = 
         * DEF, for administration instruction on medication definition 
         * documents/references (typically, monographs).</p> 
         * <p>Indicates the context of the 
         * administration.</p><p>moodCode = RQO, for administration 
         * instruction on orders</p><p>moodCode = EVN, for 
         * administration instruction on dispenses</p><p>moodCode = 
         * DEF, for administration instruction on medication definition 
         * documents/references (typically, monographs).</p> 
         * <p>Indicates the context of the 
         * administration.</p><p>moodCode = RQO, for administration 
         * instruction on orders</p><p>moodCode = EVN, for 
         * administration instruction on dispenses</p><p>moodCode = 
         * DEF, for administration instruction on medication definition 
         * documents/references (typically, monographs).</p> 
         * <p>Indicates the context of the 
         * administration.</p><p>moodCode = RQO, for administration 
         * instruction on orders</p><p>moodCode = EVN, for 
         * administration instruction on dispenses</p><p>moodCode = 
         * DEF, for administration instruction on medication definition 
         * documents/references (typically, monographs).</p> <p>Puts 
         * the class in context, and is therefore mandatory.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"moodCode"})]
        public x_ActMoodDefEvnRqo MoodCode {
            get { return (x_ActMoodDefEvnRqo) this.moodCode.Value; }
            set { this.moodCode.Value = value; }
        }

        /**
         * <summary>AdditionalDosageInstruction</summary>
         * 
         * <remarks>F:Additional Dosage Instruction <p>A free form 
         * textual description of extended instruction regarding the 
         * administration of the drug.</p> <p>ZDP.13.8</p> <p>Allows 
         * for expression of non-codable qualifiers such as: 'on an 
         * empty stomach', 'add water' etc; which do not affect 
         * calculations of frequencies or quantity.</p><p>This 
         * attribute is marked as 'mandatory' as it is the only 
         * information that can be specified here.</p> <p>Allows for 
         * expression of non-codable qualifiers such as: 'on an empty 
         * stomach', 'add water' etc; which do not affect calculations 
         * of frequencies or quantity.</p><p>This attribute is marked 
         * as 'mandatory' as it is the only information that can be 
         * specified here.</p> F:Additional Dosage Instruction <p>A 
         * free form textual description of extended instruction 
         * regarding the administration of the drug.</p> 
         * <p>ZDP.13.8</p> <p>Allows for expression of non-codable 
         * qualifiers such as: 'on an empty stomach', 'add water' etc; 
         * which do not affect calculations of frequencies or 
         * quantity.</p><p>This attribute is marked as 'mandatory' as 
         * it is the only information that can be specified here.</p> 
         * <p>Allows for expression of non-codable qualifiers such as: 
         * 'on an empty stomach', 'add water' etc; which do not affect 
         * calculations of frequencies or quantity.</p><p>This 
         * attribute is marked as 'mandatory' as it is the only 
         * information that can be specified here.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"text"})]
        public String Text {
            get { return this.text.Value; }
            set { this.text.Value = value; }
        }

    }

}