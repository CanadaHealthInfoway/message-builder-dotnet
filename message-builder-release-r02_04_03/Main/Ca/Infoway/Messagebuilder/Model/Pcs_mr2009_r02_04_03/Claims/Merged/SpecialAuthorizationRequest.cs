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
namespace Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Claims.Merged {
    using Ca.Infoway.Messagebuilder;
    using Ca.Infoway.Messagebuilder.Annotation;
    using Ca.Infoway.Messagebuilder.Datatype;
    using Ca.Infoway.Messagebuilder.Datatype.Impl;
    using Ca.Infoway.Messagebuilder.Datatype.Lang;
    using Ca.Infoway.Messagebuilder.Domainvalue;
    using Ca.Infoway.Messagebuilder.Model;
    using Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Claims.Ficr_mt400001ca;
    using Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Common.Merged;
    using Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Merged;
    using System;
    using System.Collections.Generic;


    [Hl7PartTypeMappingAttribute(new string[] {"FICR_MT400001CA.SpecialAuthorizationRequest","FICR_MT400003CA.SpecialAuthorizationRequest","FICR_MT400004CA.SpecialAuthorizationRequest","FICR_MT490003CA.SpecialAuthorizationRequest","FICR_MT490101CA.SpecialAuthorizationRequest"})]
    public class SpecialAuthorizationRequest : MessagePartBean {

        private II id;
        private CV code;
        private CS statusCode;
        private Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Common.Merged.HealthcareWorker authorAssignedEntity;
        private Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Claims.Merged.Subject3 subject;
        private Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Claims.Merged.SpecialAuthorization fulfillmentSpecialAuthorization;
        private IVL<TS, Interval<PlatformDate>> effectiveTime;
        private CV priorityCode;
        private SET<CV, Code> confidentialityCode;
        private Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Claims.Ficr_mt400001ca.FormRole directTargetFormRole;
        private Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Claims.Merged.ContactParty callBackContactContactParty;
        private Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Claims.Merged.SpecialAuthorizationRequestCrossReference predecessorSpecialAuthorizationRequestCrossReference;
        private IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Claims.Merged.SpecialAuthorizationCriteria> supportSpecialAuthorizationCriteria;
        private Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Claims.Merged.PolicyOrAccount_1 coveragePolicyOrAccount;
        private IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Claims.Merged.HealthDocumentAttachment_1> pertinentInformationHealthDocumentAttachment;
        private IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Merged.Includes> subjectOf;
        private IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Claims.Merged.Subject5> subject1;
        private Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Claims.Merged.SpecialAuthorizationAdditionalInformationRequest referenceSpecialAuthorizationAdditionalInformationRequest;

        public SpecialAuthorizationRequest() {
            this.id = new IIImpl();
            this.code = new CVImpl();
            this.statusCode = new CSImpl();
            this.effectiveTime = new IVLImpl<TS, Interval<PlatformDate>>();
            this.priorityCode = new CVImpl();
            this.confidentialityCode = new SETImpl<CV, Code>(typeof(CVImpl));
            this.supportSpecialAuthorizationCriteria = new List<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Claims.Merged.SpecialAuthorizationCriteria>();
            this.pertinentInformationHealthDocumentAttachment = new List<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Claims.Merged.HealthDocumentAttachment_1>();
            this.subjectOf = new List<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Merged.Includes>();
            this.subject1 = new List<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Claims.Merged.Subject5>();
        }
        /**
         * <summary>SpecialAuthorizationRequestID</summary>
         * 
         * <remarks>Special Authorization Request ID</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"id"})]
        public Identifier Id {
            get { return this.id.Value; }
            set { this.id.Value = value; }
        }

        /**
         * <summary>SpecialAuthorizationRequestType</summary>
         * 
         * <remarks>Special Authorization Request Type</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"code"})]
        public Code Code {
            get { return (Code) this.code.Value; }
            set { this.code.Value = value; }
        }

        /**
         * <summary>RequestStatus</summary>
         * 
         * <remarks>Request Status</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"statusCode"})]
        public ActStatus StatusCode {
            get { return (ActStatus) this.statusCode.Value; }
            set { this.statusCode.Value = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"author/assignedEntity"})]
        public Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Common.Merged.HealthcareWorker AuthorAssignedEntity {
            get { return this.authorAssignedEntity; }
            set { this.authorAssignedEntity = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"subject","subject2"})]
        [Hl7MapByPartType(Name="subject", Type="FICR_MT400001CA.Subject3")]
        [Hl7MapByPartType(Name="subject", Type="FICR_MT400003CA.Subject3")]
        [Hl7MapByPartType(Name="subject", Type="FICR_MT400004CA.Subject3")]
        [Hl7MapByPartType(Name="subject2", Type="FICR_MT490101CA.Subject3")]
        public Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Claims.Merged.Subject3 Subject {
            get { return this.subject; }
            set { this.subject = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"fulfillment/specialAuthorization"})]
        public Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Claims.Merged.SpecialAuthorization FulfillmentSpecialAuthorization {
            get { return this.fulfillmentSpecialAuthorization; }
            set { this.fulfillmentSpecialAuthorization = value; }
        }

        /**
         * <summary>SpecialAuthorizationRequestEffectiveDate</summary>
         * 
         * <remarks>Special Authorization Request Effective Date</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"effectiveTime"})]
        public Interval<PlatformDate> EffectiveTime {
            get { return this.effectiveTime.Value; }
            set { this.effectiveTime.Value = value; }
        }

        /**
         * <summary>SpecialAuthorizationPriorityCode</summary>
         * 
         * <remarks>Special Authorization Priority Code</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"priorityCode"})]
        public ActPriority PriorityCode {
            get { return (ActPriority) this.priorityCode.Value; }
            set { this.priorityCode.Value = value; }
        }

        /**
         * <summary>ConfidentialityRestrictionS</summary>
         * 
         * <remarks>Confidentiality Restriction(s</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"confidentialityCode"})]
        public ICollection<x_BasicConfidentialityKind> ConfidentialityCode {
            get { return this.confidentialityCode.RawSet<x_BasicConfidentialityKind>(); }
        }

        [Hl7XmlMappingAttribute(new string[] {"directTarget/formRole"})]
        public Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Claims.Ficr_mt400001ca.FormRole DirectTargetFormRole {
            get { return this.directTargetFormRole; }
            set { this.directTargetFormRole = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"callBackContact/contactParty"})]
        public Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Claims.Merged.ContactParty CallBackContactContactParty {
            get { return this.callBackContactContactParty; }
            set { this.callBackContactContactParty = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"predecessor/specialAuthorizationRequestCrossReference"})]
        public Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Claims.Merged.SpecialAuthorizationRequestCrossReference PredecessorSpecialAuthorizationRequestCrossReference {
            get { return this.predecessorSpecialAuthorizationRequestCrossReference; }
            set { this.predecessorSpecialAuthorizationRequestCrossReference = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"support/specialAuthorizationCriteria"})]
        public IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Claims.Merged.SpecialAuthorizationCriteria> SupportSpecialAuthorizationCriteria {
            get { return this.supportSpecialAuthorizationCriteria; }
        }

        [Hl7XmlMappingAttribute(new string[] {"coverage/policyOrAccount"})]
        public Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Claims.Merged.PolicyOrAccount_1 CoveragePolicyOrAccount {
            get { return this.coveragePolicyOrAccount; }
            set { this.coveragePolicyOrAccount = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"pertinentInformation/healthDocumentAttachment"})]
        public IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Claims.Merged.HealthDocumentAttachment_1> PertinentInformationHealthDocumentAttachment {
            get { return this.pertinentInformationHealthDocumentAttachment; }
        }

        [Hl7XmlMappingAttribute(new string[] {"subjectOf"})]
        public IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Merged.Includes> SubjectOf {
            get { return this.subjectOf; }
        }

        [Hl7XmlMappingAttribute(new string[] {"subject1"})]
        public IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Claims.Merged.Subject5> Subject1 {
            get { return this.subject1; }
        }

        [Hl7XmlMappingAttribute(new string[] {"reference/specialAuthorizationAdditionalInformationRequest"})]
        public Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Claims.Merged.SpecialAuthorizationAdditionalInformationRequest ReferenceSpecialAuthorizationAdditionalInformationRequest {
            get { return this.referenceSpecialAuthorizationAdditionalInformationRequest; }
            set { this.referenceSpecialAuthorizationAdditionalInformationRequest = value; }
        }

    }

}