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
 * Author:        $LastChangedBy: tmcgrady $
 * Last modified: $LastChangedDate: 2011-05-04 16:47:15 -0300 (Wed, 04 May 2011) $
 * Revision:      $LastChangedRevision: 2623 $
 */
/* This class was auto-generated by the message builder generator tools. */
namespace Ca.Infoway.Messagebuilder.Model.Sk_cerx_v01_r04_2.Common.Coct_mt470000ca {
    using Ca.Infoway.Messagebuilder.Annotation;
    using Ca.Infoway.Messagebuilder.Model;


    /**
     * <summary>Business Name: Consent By Patient</summary>
     * 
     * <p>Indicates that the consent or keyword has been provided 
     * by the patient themselves (rather than a 
     * representative.)</p> <p>Distinguishing whether consent is 
     * granted by the patient or a representative can be important 
     * for audit purposes.</p>
     */
    [Hl7PartTypeMappingAttribute(new string[] {"COCT_MT470000CA.Patient"})]
    public class ConsentByPatient : MessagePartBean, Ca.Infoway.Messagebuilder.Model.Sk_cerx_v01_r04_2.Merged.IConsenter {


        public ConsentByPatient() {
        }
    }

}