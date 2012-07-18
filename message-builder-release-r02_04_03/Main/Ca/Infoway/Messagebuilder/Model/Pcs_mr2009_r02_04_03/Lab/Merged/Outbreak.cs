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
namespace Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Lab.Merged {
    using Ca.Infoway.Messagebuilder.Annotation;
    using Ca.Infoway.Messagebuilder.Datatype;
    using Ca.Infoway.Messagebuilder.Datatype.Impl;
    using Ca.Infoway.Messagebuilder.Datatype.Lang;
    using Ca.Infoway.Messagebuilder.Model;


    /**
     * <summary>Outbreak</summary>
     * 
     * <remarks>POLB_MT004100CA.OutbreakEvent: Outbreak 
     * <p>Identifies an outbreak which the reporting lab suspects 
     * this result might be a part of.</p> <p>Used as an indicator 
     * to public health that this lab result may indicate the 
     * subject is a part of an outbreak. This does not confirm that 
     * lab result is an outbreak subject, only that the potential 
     * exists and public health should disposition.</p> 
     * POLB_MT004200CA.OutbreakEvent: Outbreak <p>Identifies an 
     * outbreak which the reporting lab suspects this result might 
     * be a part of.</p> <p>Used as an indicator to public health 
     * that this lab result may indicate the subject is a part of 
     * an outbreak. This does not confirm that lab result is an 
     * outbreak subject, only that the potential exists and public 
     * health should disposition.</p> 
     * POLB_MT004000CA.OutbreakEvent: Outbreak <p>Identifies an 
     * outbreak which the reporting lab suspects this result might 
     * be a part of.</p> <p>Used as an indicator to public health 
     * that this lab result may indicate the subject is a part of 
     * an outbreak. This does not confirm that lab result is an 
     * outbreak subject, only that the potential exists and public 
     * health should disposition.</p></remarks>
     */
    [Hl7PartTypeMappingAttribute(new string[] {"POLB_MT001000CA.OutbreakEvent","POLB_MT001010CA.OutbreakEvent","POLB_MT001999CA.OutbreakEvent","POLB_MT002000CA.OutbreakEvent","POLB_MT004000CA.OutbreakEvent","POLB_MT004100CA.OutbreakEvent","POLB_MT004200CA.OutbreakEvent"})]
    public class Outbreak : MessagePartBean {

        private II id;

        public Outbreak() {
            this.id = new IIImpl();
        }
        /**
         * <summary>OutbreakIdentifier</summary>
         * 
         * <remarks>Outbreak Identifier <p>Identifies an outbreak which 
         * the reporting lab suspects this result might be a part 
         * of.</p> <p>Used as an indicator to public health that this 
         * lab result may indicate the subject is a part of an 
         * outbreak. This does not confirm that lab result is an 
         * outbreak subject, only that the potential exists and public 
         * health should disposition.</p> Outbreak Identifier <p>Allows 
         * public health to identify an outbreak for which this test is 
         * being conducted.</p> Outbreak Identifier</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"id"})]
        public Identifier Id {
            get { return this.id.Value; }
            set { this.id.Value = value; }
        }

    }

}