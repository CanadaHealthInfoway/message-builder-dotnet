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
namespace Ca.Infoway.Messagebuilder.Model.Ab_mr2007_v02_r02.Cr.Merged {
    using Ca.Infoway.Messagebuilder.Annotation;
    using Ca.Infoway.Messagebuilder.Datatype;
    using Ca.Infoway.Messagebuilder.Datatype.Impl;
    using Ca.Infoway.Messagebuilder.Domainvalue;
    using Ca.Infoway.Messagebuilder.Model;
    using System;
    using System.Collections.Generic;


    /**
     * <summary>LanguageCommunication</summary>
     * 
     * <remarks>PRPA_MT101102CA.LanguageCommunication: Language 
     * Communication <p>Information about what language(s) should 
     * be used to communicate with the focal person can be sent in 
     * the LanguageCommunication class.</p> <p>Supports the 
     * business requirement to identify languages used by client 
     * for the purposes of communication</p> 
     * PRPA_MT101104CA.LanguageCommunication: LanguageCommunication 
     * <p>Information about what language(s) should be used to 
     * communicate with the focal person can be sent in the 
     * LanguageCommunication class.</p> <p>Supports the business 
     * requirement to identify languages used by client for the 
     * purposes of communication</p></remarks>
     */
    [Hl7PartTypeMappingAttribute(new string[] {"PRPA_MT101102CA.LanguageCommunication","PRPA_MT101104CA.LanguageCommunication"})]
    public class LanguageCommunication : MessagePartBean {

        private IList<BL> preferenceInd;
        private CV languageCode;

        public LanguageCommunication() {
            this.preferenceInd = new List<BL>();
            this.languageCode = new CVImpl();
        }
        /**
         * <summary>LanguageOfCommunicationPreferenceIndicator</summary>
         * 
         * <remarks>Language of Communication Preference Indicator 
         * <p>Indicates the preferred language for all 
         * communications.</p> <p>Required attribute that supports the 
         * business requirement to indicate the preferred language for 
         * all communications.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"preferenceInd"})]
        public IList<bool?> PreferenceInd {
            get { return new RawListWrapper<BL, bool?>(preferenceInd, typeof(BLImpl)); }
        }

        /**
         * <summary>LanguageOfCommunicationCode</summary>
         * 
         * <remarks>Language of Communication Code <p>A code indicating 
         * the language of communication</p> <p>Mandatory attribute 
         * conveying the expected language message elements are to be 
         * transmitted in</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"languageCode"})]
        public HumanLanguage LanguageCode {
            get { return (HumanLanguage) this.languageCode.Value; }
            set { this.languageCode.Value = value; }
        }

    }

}