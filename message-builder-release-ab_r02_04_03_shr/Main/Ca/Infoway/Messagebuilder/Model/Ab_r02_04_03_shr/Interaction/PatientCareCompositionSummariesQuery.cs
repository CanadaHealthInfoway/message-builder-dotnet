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
namespace Ca.Infoway.Messagebuilder.Model.Ab_r02_04_03_shr.Interaction {
    using Ca.Infoway.Messagebuilder.Annotation;
    using Ca.Infoway.Messagebuilder.Model;
    using Ca.Infoway.Messagebuilder.Model.Ab_r02_04_03_shr.Common.Mcci_mt002100ca;
    using Ca.Infoway.Messagebuilder.Model.Ab_r02_04_03_shr.Common.Quqi_mt020000ab;
    using Ca.Infoway.Messagebuilder.Model.Ab_r02_04_03_shr.Common.Repc_mt500005ab;


    /**
     * <summary>Business Name: REPC_IN041100AB: Patient care 
     * composition summaries query</summary>
     * 
     * <p>Requests retrieval of a list of encounters, episodes and 
     * similar structures for a particular patient or group of 
     * patients, potentially filtered by date or other criteria. 
     * &lt;p/&gt;</p> Message: MCCI_MT002100CA.Message Control Act: 
     * QUQI_MT020000AB.ControlActEvent --> Payload: 
     * REPC_MT500005AB.ParameterList
     */
    [Hl7PartTypeMappingAttribute(new string[] {"REPC_IN041100AB"})]
    public class PatientCareCompositionSummariesQuery : HL7Message<Ca.Infoway.Messagebuilder.Model.Ab_r02_04_03_shr.Common.Quqi_mt020000ab.TriggerEvent<Ca.Infoway.Messagebuilder.Model.Ab_r02_04_03_shr.Common.Repc_mt500005ab.QueryDefinition>>, IInteraction {


        public PatientCareCompositionSummariesQuery() {
        }
    }

}