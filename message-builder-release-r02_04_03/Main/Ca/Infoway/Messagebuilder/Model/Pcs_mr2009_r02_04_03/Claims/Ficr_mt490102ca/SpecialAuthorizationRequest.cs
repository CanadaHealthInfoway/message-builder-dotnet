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
namespace Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Claims.Ficr_mt490102ca {
    using Ca.Infoway.Messagebuilder;
    using Ca.Infoway.Messagebuilder.Annotation;
    using Ca.Infoway.Messagebuilder.Datatype;
    using Ca.Infoway.Messagebuilder.Datatype.Impl;
    using Ca.Infoway.Messagebuilder.Datatype.Lang;
    using Ca.Infoway.Messagebuilder.Domainvalue;
    using Ca.Infoway.Messagebuilder.Model;
    using Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Claims.Merged;
    using Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Common.Merged;
    using Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Merged;
    using System;
    using System.Collections.Generic;


    [Hl7PartTypeMappingAttribute(new string[] {"FICR_MT490102CA.SpecialAuthorizationRequest"})]
    public class SpecialAuthorizationRequest : MessagePartBean {

        private II id;
        private CV code;
        private IVL<TS, Interval<PlatformDate>> effectiveTime;
        private CV priorityCode;
        private SET<CV, Code> confidentialityCode;
        private Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Common.Merged.HealthcareWorker authorAssignedEntity;
        private Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Claims.Merged.SpecialAuthorizationRequestCrossReference predecessorSpecialAuthorizationRequestCrossReference;
        private IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Claims.Ficr_mt490102ca.SpecialAuthorizationCriteria> supportSpecialAuthorizationCriteria;
        private Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Claims.Merged.Subject3 subject1;
        private IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Claims.Merged.Subject5> subject2;
        private Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Claims.Ficr_mt490102ca.PolicyOrAccount coveragePolicyOrAccount;
        private IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Claims.Merged.HealthDocumentAttachment_1> pertinentInformationHealthDocumentAttachment;
        private Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Claims.Ficr_mt490102ca.SpecialAuthorization fulfillmentSpecialAuthorization;
        private IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Merged.Includes> subjectOf;

        public SpecialAuthorizationRequest() {
            this.id = new IIImpl();
            this.code = new CVImpl();
            this.effectiveTime = new IVLImpl<TS, Interval<PlatformDate>>();
            this.priorityCode = new CVImpl();
            this.confidentialityCode = new SETImpl<CV, Code>(typeof(CVImpl));
            this.supportSpecialAuthorizationCriteria = new List<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Claims.Ficr_mt490102ca.SpecialAuthorizationCriteria>();
            this.subject2 = new List<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Claims.Merged.Subject5>();
            this.pertinentInformationHealthDocumentAttachment = new List<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Claims.Merged.HealthDocumentAttachment_1>();
            this.subjectOf = new List<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Merged.Includes>();
        }
        /**
         * <summary>Special Authority Request ID</summary>
         */
        [Hl7XmlMappingAttribute(new string[] {"id"})]
        public Identifier Id {
            get { return this.id.Value; }
            set { this.id.Value = value; }
        }

        /**
         * <summary>Special Authorization Request Type</summary>
         */
        [Hl7XmlMappingAttribute(new string[] {"code"})]
        public Code Code {
            get { return (Code) this.code.Value; }
            set { this.code.Value = value; }
        }

        /**
         * <summary>Special Authorization Request Effective Date</summary>
         */
        [Hl7XmlMappingAttribute(new string[] {"effectiveTime"})]
        public Interval<PlatformDate> EffectiveTime {
            get { return this.effectiveTime.Value; }
            set { this.effectiveTime.Value = value; }
        }

        /**
         * <summary>Special Authorization Priority Code</summary>
         */
        [Hl7XmlMappingAttribute(new string[] {"priorityCode"})]
        public ActPriority PriorityCode {
            get { return (ActPriority) this.priorityCode.Value; }
            set { this.priorityCode.Value = value; }
        }

        /**
         * <summary>Confidentiality Restriction(s</summary>
         */
        [Hl7XmlMappingAttribute(new string[] {"confidentialityCode"})]
        public ICollection<x_VeryBasicConfidentialityKind> ConfidentialityCode {
            get { return this.confidentialityCode.RawSet<x_VeryBasicConfidentialityKind>(); }
        }

        [Hl7XmlMappingAttribute(new string[] {"author/assignedEntity"})]
        public Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Common.Merged.HealthcareWorker AuthorAssignedEntity {
            get { return this.authorAssignedEntity; }
            set { this.authorAssignedEntity = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"predecessor/specialAuthorizationRequestCrossReference"})]
        public Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Claims.Merged.SpecialAuthorizationRequestCrossReference PredecessorSpecialAuthorizationRequestCrossReference {
            get { return this.predecessorSpecialAuthorizationRequestCrossReference; }
            set { this.predecessorSpecialAuthorizationRequestCrossReference = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"support/specialAuthorizationCriteria"})]
        public IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Claims.Ficr_mt490102ca.SpecialAuthorizationCriteria> SupportSpecialAuthorizationCriteria {
            get { return this.supportSpecialAuthorizationCriteria; }
        }

        [Hl7XmlMappingAttribute(new string[] {"subject1"})]
        public Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Claims.Merged.Subject3 Subject1 {
            get { return this.subject1; }
            set { this.subject1 = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"subject2"})]
        public IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Claims.Merged.Subject5> Subject2 {
            get { return this.subject2; }
        }

        [Hl7XmlMappingAttribute(new string[] {"coverage/policyOrAccount"})]
        public Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Claims.Ficr_mt490102ca.PolicyOrAccount CoveragePolicyOrAccount {
            get { return this.coveragePolicyOrAccount; }
            set { this.coveragePolicyOrAccount = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"pertinentInformation/healthDocumentAttachment"})]
        public IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Claims.Merged.HealthDocumentAttachment_1> PertinentInformationHealthDocumentAttachment {
            get { return this.pertinentInformationHealthDocumentAttachment; }
        }

        [Hl7XmlMappingAttribute(new string[] {"fulfillment/specialAuthorization"})]
        public Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Claims.Ficr_mt490102ca.SpecialAuthorization FulfillmentSpecialAuthorization {
            get { return this.fulfillmentSpecialAuthorization; }
            set { this.fulfillmentSpecialAuthorization = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"subjectOf"})]
        public IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Merged.Includes> SubjectOf {
            get { return this.subjectOf; }
        }

    }

}