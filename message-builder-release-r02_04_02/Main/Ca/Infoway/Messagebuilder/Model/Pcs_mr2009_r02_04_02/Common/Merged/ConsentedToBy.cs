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
 * Last modified: $LastChangedDate: 2012-01-18 21:05:07 -0500 (Wed, 18 Jan 2012) $
 * Revision:      $LastChangedRevision: 3929 $
 */

/* This class was auto-generated by the message builder generator tools. */
namespace Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Common.Merged {
    using Ca.Infoway.Messagebuilder.Annotation;
    using Ca.Infoway.Messagebuilder.Datatype;
    using Ca.Infoway.Messagebuilder.Datatype.Impl;
    using Ca.Infoway.Messagebuilder.Domainvalue;
    using Ca.Infoway.Messagebuilder.Model;
    using Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Merged;
    using System;


    /**
     * <summary>ConsentedToBy</summary>
     * 
     * <remarks>COCT_MT470012CA.Author: b:consented to by 
     * <p>Indicates that the consent was provided by the patient, 
     * client, provider or representative.</p> 
     * <p>Authorization.Person</p><p>Authorization.signatory(PT)</p> 
     * <p>Authorization.Person</p><p>Authorization.signatory(PT)</p> 
     * <p>Consent can be provided by the patient or representative 
     * or the provider.</p> COCT_MT470002CA.Author: b:consented to 
     * by <p>Indicates that the consent was provided by the patient 
     * or representative.</p> 
     * <p>Authorization.Person</p><p>Authorization.signatory(PT)</p> 
     * <p>Authorization.Person</p><p>Authorization.signatory(PT)</p> 
     * <p>Consent can be provided by the patient or representative 
     * or the provider.</p></remarks>
     */
    [Hl7PartTypeMappingAttribute(new string[] {"COCT_MT470002CA.Author","COCT_MT470012CA.Author"})]
    public class ConsentedToBy : MessagePartBean {

        private CV patientConsentMechanism;
        private ST keyword;
        private Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Merged.RelatedPerson personalRelationship;

        public ConsentedToBy() {
            this.patientConsentMechanism = new CVImpl();
            this.keyword = new STImpl();
        }
        /**
         * <summary>PatientConsentMechanism</summary>
         * 
         * <remarks>Patient Consent Mechanism <p>Indicates whether the 
         * patient's consent is written or verbal.</p> <p>Verbal 
         * consents may trigger a higher level of auditing.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"modeCode"})]
        public x_PhysicalVerbalParticipationMode PatientConsentMechanism {
            get { return (x_PhysicalVerbalParticipationMode) this.patientConsentMechanism.Value; }
            set { this.patientConsentMechanism.Value = value; }
        }

        /**
         * <summary>Keyword</summary>
         * 
         * <remarks>Keyword <p>Indicates the keyword appropriate to the 
         * action being performed by the message.</p> <p>Allows 
         * providers who know the keyword to access information 
         * protected by patient keywords.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"signatureText"})]
        public String Keyword {
            get { return this.keyword.Value; }
            set { this.keyword.Value = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"personalRelationship"})]
        public Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Merged.RelatedPerson PersonalRelationship {
            get { return this.personalRelationship; }
            set { this.personalRelationship = value; }
        }

    }

}