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
 * Last modified: $LastChangedDate: 2012-01-18 21:12:42 -0500 (Wed, 18 Jan 2012) $
 * Revision:      $LastChangedRevision: 4018 $
 */

/* This class was auto-generated by the message builder generator tools. */
namespace Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Pr.Prpm_mt306011ca {
    using Ca.Infoway.Messagebuilder;
    using Ca.Infoway.Messagebuilder.Annotation;
    using Ca.Infoway.Messagebuilder.Datatype;
    using Ca.Infoway.Messagebuilder.Datatype.Impl;
    using Ca.Infoway.Messagebuilder.Domainvalue;
    using Ca.Infoway.Messagebuilder.Model;
    using Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Merged;
    using Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Pr.Merged;


    /**
     * <summary>Inform Request</summary>
     * 
     * <remarks><p>Class communicates request for routing of 
     * information to a provider or service delivery location 
     * provider.</p> <p>The use case for including this class is 
     * for requesting routing of health information where the code 
     * equals the information type. Examples include ECG results, 
     * DI - Diagnostic Image interpretation reports, Lab Test 
     * Results Transcripts</p></remarks>
     */
    [Hl7PartTypeMappingAttribute(new string[] {"PRPM_MT306011CA.InformRequest"})]
    public class InformRequest : MessagePartBean {

        private CD informRequestCode;
        private CE serviceDeliveryLocationParticipationMode;
        private Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Pr.Merged.ServiceDeliveryLocation subjectServiceDeliveryLocation;
        private Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Merged.IChoice indirectTargetChoice;

        public InformRequest() {
            this.informRequestCode = new CDImpl();
            this.serviceDeliveryLocationParticipationMode = new CEImpl();
        }
        /**
         * <summary>Inform Request Code</summary>
         * 
         * <remarks><p>A coded value denoting a specific document type 
         * that a provider expresses to have routed to them from the 
         * Service Delivery Location to which they are associated.</p> 
         * <p>Populated - Allows providers to request that specific 
         * document(s) be routed from an SDL to them.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"code"})]
        public Code InformRequestCode {
            get { return (Code) this.informRequestCode.Value; }
            set { this.informRequestCode.Value = value; }
        }

        /**
         * <summary>Service Delivery Location Participation Mode</summary>
         * 
         * <remarks><p>A code specifying the modality by which the 
         * Entity playing the Role is participating in the Act.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"subject/modeCode"})]
        public ParticipationMode ServiceDeliveryLocationParticipationMode {
            get { return (ParticipationMode) this.serviceDeliveryLocationParticipationMode.Value; }
            set { this.serviceDeliveryLocationParticipationMode.Value = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"subject/serviceDeliveryLocation"})]
        public Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Pr.Merged.ServiceDeliveryLocation SubjectServiceDeliveryLocation {
            get { return this.subjectServiceDeliveryLocation; }
            set { this.subjectServiceDeliveryLocation = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"indirectTarget/choice"})]
        public Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Merged.IChoice IndirectTargetChoice {
            get { return this.indirectTargetChoice; }
            set { this.indirectTargetChoice = value; }
        }

        public Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Pr.Prpm_mt306011ca.IRoleChoice IndirectTargetChoiceAsServiceDeliveryLocation {
            get { return this.indirectTargetChoice is Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Pr.Prpm_mt306011ca.IRoleChoice ? (Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Pr.Prpm_mt306011ca.IRoleChoice) this.indirectTargetChoice : (Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Pr.Prpm_mt306011ca.IRoleChoice) null; }
        }
        public bool HasIndirectTargetChoiceAsServiceDeliveryLocation() {
            return (this.indirectTargetChoice is Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Pr.Prpm_mt306011ca.IRoleChoice);
        }

        public Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Pr.Prpm_mt306011ca.HealthcareProvider IndirectTargetChoiceAsHealthCareProvider {
            get { return this.indirectTargetChoice is Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Pr.Prpm_mt306011ca.HealthcareProvider ? (Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Pr.Prpm_mt306011ca.HealthcareProvider) this.indirectTargetChoice : (Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Pr.Prpm_mt306011ca.HealthcareProvider) null; }
        }
        public bool HasIndirectTargetChoiceAsHealthCareProvider() {
            return (this.indirectTargetChoice is Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Pr.Prpm_mt306011ca.HealthcareProvider);
        }

    }

}