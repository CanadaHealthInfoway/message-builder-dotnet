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
 * Last modified: $LastChangedDate: 2012-01-18 21:07:45 -0500 (Wed, 18 Jan 2012) $
 * Revision:      $LastChangedRevision: 3965 $
 */

/* This class was auto-generated by the message builder generator tools. */
namespace Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Iehr.Repc_mt610002ca {
    using Ca.Infoway.Messagebuilder;
    using Ca.Infoway.Messagebuilder.Annotation;
    using Ca.Infoway.Messagebuilder.Datatype;
    using Ca.Infoway.Messagebuilder.Datatype.Impl;
    using Ca.Infoway.Messagebuilder.Datatype.Lang;
    using Ca.Infoway.Messagebuilder.Domainvalue;
    using Ca.Infoway.Messagebuilder.Model;
    using Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Common.Coct_mt090508ca;
    using Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Common.Coct_mt910108ca;
    using Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Common.Coct_mt911108ca;
    using Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Common.Merged;
    using Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Iehr.Merged;
    using Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Merged;
    using System;
    using System.Collections.Generic;


    /**
     * <summary>Professional Service</summary>
     * 
     * <remarks><p>Annotation is only permitted if Annotation 
     * Indicator is not present and vice versa</p> <p>This is the 
     * information that is recorded and maintained on a 
     * consultative, surgical or physical service (procedure) 
     * provided to the patient.</p><p>Counseling, education, 
     * surgeries and physical therapy are examples of the types of 
     * services that can be captured.</p> <p>This is the 
     * information that is recorded and maintained on a 
     * consultative, surgical or physical service (procedure) 
     * provided to the patient.</p><p>Counseling, education, 
     * surgeries and physical therapy are examples of the types of 
     * services that can be captured.</p> 
     * <p>A_BillableClinicalService</p> <p>Information about 
     * surgeries, councilling and other professional services is a 
     * key element of the EHR. It provides context around services 
     * provided and may inform choices about how best to manage the 
     * patient's healthcare.</p></remarks>
     */
    [Hl7PartTypeMappingAttribute(new string[] {"REPC_MT610002CA.ProcedureEvent"})]
    public class ProfessionalService : MessagePartBean, Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Iehr.Comt_mt111111ca.ISHR {

        private II serviceRecordId;
        private CD serviceType;
        private BL refutedIndicator;
        private IVL<TS, Interval<PlatformDate>> serviceTimeAndLength;
        private SET<CV, Code> serviceMaskingIndicators;
        private Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Common.Coct_mt911108ca.IActingPerson responsiblePartyActingPerson;
        private IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Common.Coct_mt911108ca.IActingPerson> performerActingPerson;
        private Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Merged.ChangedBy author;
        private Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Common.Merged.IActingPerson informantActingPerson;
        private Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Common.Merged.EHRRepository custodian1AssignedDevice;
        private Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Common.Merged.ServiceLocation custodian2ServiceDeliveryLocation;
        private Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Merged.OccurredAt location;
        private Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Iehr.Merged.Request_3 inFulfillmentOfActRequest;
        private IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Iehr.Merged.ActDefinition> definitionActDefinition;
        private IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Iehr.Merged.OldProcedureEvent> predecessorOldProcedureEvent;
        private IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Merged.BecauseOf> reason;
        private Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Iehr.Repc_mt610002ca.NewProcedureEvent successorNewProcedureEvent;
        private IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Merged.Includes> subjectOf1;
        private BL subjectOf2AnnotationIndicator;
        private Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Iehr.Merged.ClinicalDocumentEvent subjectOf3ClinicalDocumentEvent;
        private IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Iehr.Merged.Component2> componentOf1;
        private IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Merged.CareCompositions> componentOf2PatientCareProvisionEvent;

        public ProfessionalService() {
            this.serviceRecordId = new IIImpl();
            this.serviceType = new CDImpl();
            this.refutedIndicator = new BLImpl();
            this.serviceTimeAndLength = new IVLImpl<TS, Interval<PlatformDate>>();
            this.serviceMaskingIndicators = new SETImpl<CV, Code>(typeof(CVImpl));
            this.performerActingPerson = new List<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Common.Coct_mt911108ca.IActingPerson>();
            this.definitionActDefinition = new List<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Iehr.Merged.ActDefinition>();
            this.predecessorOldProcedureEvent = new List<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Iehr.Merged.OldProcedureEvent>();
            this.reason = new List<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Merged.BecauseOf>();
            this.subjectOf1 = new List<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Merged.Includes>();
            this.subjectOf2AnnotationIndicator = new BLImpl(false);
            this.componentOf1 = new List<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Iehr.Merged.Component2>();
            this.componentOf2PatientCareProvisionEvent = new List<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Merged.CareCompositions>();
        }
        /**
         * <summary>A:Service Record Id</summary>
         * 
         * <remarks></p> 
         * <p>PatientConsultation.patientConsultationkey</p><p>PatientConsultation.externalId</p><p>ZRV.5</p><p>ZPS.2</p><p>ZPS.3</p><p>Claim.455-EM 
         * (root)</p><p>Claim.402-D2 
         * (extension)</p><p>A_BillableClinicalService</p> 
         * <p>PatientConsultation.patientConsultationkey</p><p>PatientConsultation.externalId</p><p>ZRV.5</p><p>ZPS.2</p><p>ZPS.3</p><p>Claim.455-EM 
         * (root)</p><p>Claim.402-D2 
         * (extension)</p><p>A_BillableClinicalService</p> 
         * <p>PatientConsultation.patientConsultationkey</p><p>PatientConsultation.externalId</p><p>ZRV.5</p><p>ZPS.2</p><p>ZPS.3</p><p>Claim.455-EM 
         * (root)</p><p>Claim.402-D2 
         * (extension)</p><p>A_BillableClinicalService</p> 
         * <p>PatientConsultation.patientConsultationkey</p><p>PatientConsultation.externalId</p><p>ZRV.5</p><p>ZPS.2</p><p>ZPS.3</p><p>Claim.455-EM 
         * (root)</p><p>Claim.402-D2 
         * (extension)</p><p>A_BillableClinicalService</p> 
         * <p>PatientConsultation.patientConsultationkey</p><p>PatientConsultation.externalId</p><p>ZRV.5</p><p>ZPS.2</p><p>ZPS.3</p><p>Claim.455-EM 
         * (root)</p><p>Claim.402-D2 
         * (extension)</p><p>A_BillableClinicalService</p> 
         * <p>PatientConsultation.patientConsultationkey</p><p>PatientConsultation.externalId</p><p>ZRV.5</p><p>ZPS.2</p><p>ZPS.3</p><p>Claim.455-EM 
         * (root)</p><p>Claim.402-D2 
         * (extension)</p><p>A_BillableClinicalService</p> 
         * <p>PatientConsultation.patientConsultationkey</p><p>PatientConsultation.externalId</p><p>ZRV.5</p><p>ZPS.2</p><p>ZPS.3</p><p>Claim.455-EM 
         * (root)</p><p>Claim.402-D2 
         * (extension)</p><p>A_BillableClinicalService</p> 
         * <p>PatientConsultation.patientConsultationkey</p><p>PatientConsultation.externalId</p><p>ZRV.5</p><p>ZPS.2</p><p>ZPS.3</p><p>Claim.455-EM 
         * (root)</p><p>Claim.402-D2 
         * (extension)</p><p>A_BillableClinicalService</p> </p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"id"})]
        public Identifier ServiceRecordId {
            get { return this.serviceRecordId.Value; }
            set { this.serviceRecordId.Value = value; }
        }

        /**
         * <summary>B:Service Type</summary>
         * 
         * <remarks></p><p>e.g. appendectomy, smoking cessation 
         * counseling, physiotherapy</p> </p><p>e.g. appendectomy, 
         * smoking cessation counseling, physiotherapy</p> 
         * <p>PatientConsultation.category</p><p>D57</p><p>ZPS.5.1</p><p>ZPS.5.2 
         * (experience handled as qualifier)</p><p>Claim.436-E1 (code 
         * system)</p><p>Claim.407-D7 (mnemonic)</p><p>Claim.459-ER 
         * (modifier)</p><p>Claim.418-DI 
         * (modifier)</p><p>DUR/PPS.474-8E 
         * (modifier)</p><p>A_BillableClinicalService</p> 
         * <p>PatientConsultation.category</p><p>D57</p><p>ZPS.5.1</p><p>ZPS.5.2 
         * (experience handled as qualifier)</p><p>Claim.436-E1 (code 
         * system)</p><p>Claim.407-D7 (mnemonic)</p><p>Claim.459-ER 
         * (modifier)</p><p>Claim.418-DI 
         * (modifier)</p><p>DUR/PPS.474-8E 
         * (modifier)</p><p>A_BillableClinicalService</p> 
         * <p>PatientConsultation.category</p><p>D57</p><p>ZPS.5.1</p><p>ZPS.5.2 
         * (experience handled as qualifier)</p><p>Claim.436-E1 (code 
         * system)</p><p>Claim.407-D7 (mnemonic)</p><p>Claim.459-ER 
         * (modifier)</p><p>Claim.418-DI 
         * (modifier)</p><p>DUR/PPS.474-8E 
         * (modifier)</p><p>A_BillableClinicalService</p> 
         * <p>PatientConsultation.category</p><p>D57</p><p>ZPS.5.1</p><p>ZPS.5.2 
         * (experience handled as qualifier)</p><p>Claim.436-E1 (code 
         * system)</p><p>Claim.407-D7 (mnemonic)</p><p>Claim.459-ER 
         * (modifier)</p><p>Claim.418-DI 
         * (modifier)</p><p>DUR/PPS.474-8E 
         * (modifier)</p><p>A_BillableClinicalService</p> 
         * <p>PatientConsultation.category</p><p>D57</p><p>ZPS.5.1</p><p>ZPS.5.2 
         * (experience handled as qualifier)</p><p>Claim.436-E1 (code 
         * system)</p><p>Claim.407-D7 (mnemonic)</p><p>Claim.459-ER 
         * (modifier)</p><p>Claim.418-DI 
         * (modifier)</p><p>DUR/PPS.474-8E 
         * (modifier)</p><p>A_BillableClinicalService</p> 
         * <p>PatientConsultation.category</p><p>D57</p><p>ZPS.5.1</p><p>ZPS.5.2 
         * (experience handled as qualifier)</p><p>Claim.436-E1 (code 
         * system)</p><p>Claim.407-D7 (mnemonic)</p><p>Claim.459-ER 
         * (modifier)</p><p>Claim.418-DI 
         * (modifier)</p><p>DUR/PPS.474-8E 
         * (modifier)</p><p>A_BillableClinicalService</p> 
         * <p>PatientConsultation.category</p><p>D57</p><p>ZPS.5.1</p><p>ZPS.5.2 
         * (experience handled as qualifier)</p><p>Claim.436-E1 (code 
         * system)</p><p>Claim.407-D7 (mnemonic)</p><p>Claim.459-ER 
         * (modifier)</p><p>Claim.418-DI 
         * (modifier)</p><p>DUR/PPS.474-8E 
         * (modifier)</p><p>A_BillableClinicalService</p> 
         * <p>PatientConsultation.category</p><p>D57</p><p>ZPS.5.1</p><p>ZPS.5.2 
         * (experience handled as qualifier)</p><p>Claim.436-E1 (code 
         * system)</p><p>Claim.407-D7 (mnemonic)</p><p>Claim.459-ER 
         * (modifier)</p><p>Claim.418-DI 
         * (modifier)</p><p>DUR/PPS.474-8E 
         * (modifier)</p><p>A_BillableClinicalService</p> 
         * <p>PatientConsultation.category</p><p>D57</p><p>ZPS.5.1</p><p>ZPS.5.2 
         * (experience handled as qualifier)</p><p>Claim.436-E1 (code 
         * system)</p><p>Claim.407-D7 (mnemonic)</p><p>Claim.459-ER 
         * (modifier)</p><p>Claim.418-DI 
         * (modifier)</p><p>DUR/PPS.474-8E 
         * (modifier)</p><p>A_BillableClinicalService</p> 
         * <p>PatientConsultation.category</p><p>D57</p><p>ZPS.5.1</p><p>ZPS.5.2 
         * (experience handled as qualifier)</p><p>Claim.436-E1 (code 
         * system)</p><p>Claim.407-D7 (mnemonic)</p><p>Claim.459-ER 
         * (modifier)</p><p>Claim.418-DI 
         * (modifier)</p><p>DUR/PPS.474-8E 
         * (modifier)</p><p>A_BillableClinicalService</p> </p> </p> 
         * </p> </p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"code"})]
        public ActProfessionalServiceCode ServiceType {
            get { return (ActProfessionalServiceCode) this.serviceType.Value; }
            set { this.serviceType.Value = value; }
        }

        /**
         * <summary>C:Refuted Indicator</summary>
         * 
         * <remarks></p> </p> </p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"negationInd"})]
        public bool? RefutedIndicator {
            get { return this.refutedIndicator.Value; }
            set { this.refutedIndicator.Value = value; }
        }

        /**
         * <summary>E:Service Time and Length</summary>
         * 
         * <remarks><p>Center date cannot be null but duration can be 
         * left unspecified if not known.</p> <p>The date and time 
         * during which the professional service was performed, as well 
         * as the duration of the service. May be specified as any one 
         * or two of start time, end time and duration.</p> 
         * <p>PatientConsultation.eventTime(Low)</p><p>patientConsultation.eventDuration(Width)</p><p>ZPS.4 
         * (center)</p><p>ZPS.5.2(timing portion of code 
         * set)</p><p>Claim.457-EP</p><p>A_BillableClinicalService</p> 
         * <p>PatientConsultation.eventTime(Low)</p><p>patientConsultation.eventDuration(Width)</p><p>ZPS.4 
         * (center)</p><p>ZPS.5.2(timing portion of code 
         * set)</p><p>Claim.457-EP</p><p>A_BillableClinicalService</p> 
         * <p>PatientConsultation.eventTime(Low)</p><p>patientConsultation.eventDuration(Width)</p><p>ZPS.4 
         * (center)</p><p>ZPS.5.2(timing portion of code 
         * set)</p><p>Claim.457-EP</p><p>A_BillableClinicalService</p> 
         * <p>PatientConsultation.eventTime(Low)</p><p>patientConsultation.eventDuration(Width)</p><p>ZPS.4 
         * (center)</p><p>ZPS.5.2(timing portion of code 
         * set)</p><p>Claim.457-EP</p><p>A_BillableClinicalService</p> 
         * <p>PatientConsultation.eventTime(Low)</p><p>patientConsultation.eventDuration(Width)</p><p>ZPS.4 
         * (center)</p><p>ZPS.5.2(timing portion of code 
         * set)</p><p>Claim.457-EP</p><p>A_BillableClinicalService</p> 
         * <p>PatientConsultation.eventTime(Low)</p><p>patientConsultation.eventDuration(Width)</p><p>ZPS.4 
         * (center)</p><p>ZPS.5.2(timing portion of code 
         * set)</p><p>Claim.457-EP</p><p>A_BillableClinicalService</p> 
         * </p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"effectiveTime"})]
        public Interval<PlatformDate> ServiceTimeAndLength {
            get { return this.serviceTimeAndLength.Value; }
            set { this.serviceTimeAndLength.Value = value; }
        }

        /**
         * <summary>D:Service Masking Indicators</summary>
         * 
         * <remarks></p> </p> </p> </p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"confidentialityCode"})]
        public ICollection<x_BasicConfidentialityKind> ServiceMaskingIndicators {
            get { return this.serviceMaskingIndicators.RawSet<x_BasicConfidentialityKind>(); }
        }

        [Hl7XmlMappingAttribute(new string[] {"responsibleParty/actingPerson"})]
        public Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Common.Coct_mt911108ca.IActingPerson ResponsiblePartyActingPerson {
            get { return this.responsiblePartyActingPerson; }
            set { this.responsiblePartyActingPerson = value; }
        }

        public Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Common.Merged.HealthcareWorker ResponsiblePartyActingPersonAsAssignedEntity1 {
            get { return this.responsiblePartyActingPerson is Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Common.Merged.HealthcareWorker ? (Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Common.Merged.HealthcareWorker) this.responsiblePartyActingPerson : (Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Common.Merged.HealthcareWorker) null; }
        }
        public bool HasResponsiblePartyActingPersonAsAssignedEntity1() {
            return (this.responsiblePartyActingPerson is Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Common.Merged.HealthcareWorker);
        }

        public Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Common.Coct_mt090508ca.HealthcareOrganization ResponsiblePartyActingPersonAsAssignedEntity2 {
            get { return this.responsiblePartyActingPerson is Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Common.Coct_mt090508ca.HealthcareOrganization ? (Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Common.Coct_mt090508ca.HealthcareOrganization) this.responsiblePartyActingPerson : (Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Common.Coct_mt090508ca.HealthcareOrganization) null; }
        }
        public bool HasResponsiblePartyActingPersonAsAssignedEntity2() {
            return (this.responsiblePartyActingPerson is Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Common.Coct_mt090508ca.HealthcareOrganization);
        }

        public Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Common.Coct_mt910108ca.RelatedPerson ResponsiblePartyActingPersonAsPersonalRelationship {
            get { return this.responsiblePartyActingPerson is Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Common.Coct_mt910108ca.RelatedPerson ? (Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Common.Coct_mt910108ca.RelatedPerson) this.responsiblePartyActingPerson : (Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Common.Coct_mt910108ca.RelatedPerson) null; }
        }
        public bool HasResponsiblePartyActingPersonAsPersonalRelationship() {
            return (this.responsiblePartyActingPerson is Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Common.Coct_mt910108ca.RelatedPerson);
        }

        [Hl7XmlMappingAttribute(new string[] {"performer/actingPerson"})]
        public IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Common.Coct_mt911108ca.IActingPerson> PerformerActingPerson {
            get { return this.performerActingPerson; }
        }

        [Hl7XmlMappingAttribute(new string[] {"author"})]
        public Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Merged.ChangedBy Author {
            get { return this.author; }
            set { this.author = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"informant/actingPerson"})]
        public Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Common.Merged.IActingPerson InformantActingPerson {
            get { return this.informantActingPerson; }
            set { this.informantActingPerson = value; }
        }

        public Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Common.Merged.HealthcareWorker InformantActingPersonAsAssignedEntity1 {
            get { return this.informantActingPerson is Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Common.Merged.HealthcareWorker ? (Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Common.Merged.HealthcareWorker) this.informantActingPerson : (Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Common.Merged.HealthcareWorker) null; }
        }
        public bool HasInformantActingPersonAsAssignedEntity1() {
            return (this.informantActingPerson is Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Common.Merged.HealthcareWorker);
        }

        public Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Common.Coct_mt090508ca.HealthcareOrganization InformantActingPersonAsAssignedEntity2 {
            get { return this.informantActingPerson is Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Common.Coct_mt090508ca.HealthcareOrganization ? (Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Common.Coct_mt090508ca.HealthcareOrganization) this.informantActingPerson : (Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Common.Coct_mt090508ca.HealthcareOrganization) null; }
        }
        public bool HasInformantActingPersonAsAssignedEntity2() {
            return (this.informantActingPerson is Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Common.Coct_mt090508ca.HealthcareOrganization);
        }

        public Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Common.Merged.Patient_2 InformantActingPersonAsPatient {
            get { return this.informantActingPerson is Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Common.Merged.Patient_2 ? (Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Common.Merged.Patient_2) this.informantActingPerson : (Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Common.Merged.Patient_2) null; }
        }
        public bool HasInformantActingPersonAsPatient() {
            return (this.informantActingPerson is Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Common.Merged.Patient_2);
        }

        [Hl7XmlMappingAttribute(new string[] {"custodian1/assignedDevice"})]
        public Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Common.Merged.EHRRepository Custodian1AssignedDevice {
            get { return this.custodian1AssignedDevice; }
            set { this.custodian1AssignedDevice = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"custodian2/serviceDeliveryLocation"})]
        public Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Common.Merged.ServiceLocation Custodian2ServiceDeliveryLocation {
            get { return this.custodian2ServiceDeliveryLocation; }
            set { this.custodian2ServiceDeliveryLocation = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"location"})]
        public Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Merged.OccurredAt Location {
            get { return this.location; }
            set { this.location = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"inFulfillmentOf/actRequest"})]
        public Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Iehr.Merged.Request_3 InFulfillmentOfActRequest {
            get { return this.inFulfillmentOfActRequest; }
            set { this.inFulfillmentOfActRequest = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"definition/actDefinition"})]
        public IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Iehr.Merged.ActDefinition> DefinitionActDefinition {
            get { return this.definitionActDefinition; }
        }

        [Hl7XmlMappingAttribute(new string[] {"predecessor/oldProcedureEvent"})]
        public IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Iehr.Merged.OldProcedureEvent> PredecessorOldProcedureEvent {
            get { return this.predecessorOldProcedureEvent; }
        }

        [Hl7XmlMappingAttribute(new string[] {"reason"})]
        public IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Merged.BecauseOf> Reason {
            get { return this.reason; }
        }

        [Hl7XmlMappingAttribute(new string[] {"successor/newProcedureEvent"})]
        public Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Iehr.Repc_mt610002ca.NewProcedureEvent SuccessorNewProcedureEvent {
            get { return this.successorNewProcedureEvent; }
            set { this.successorNewProcedureEvent = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"subjectOf1"})]
        public IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Merged.Includes> SubjectOf1 {
            get { return this.subjectOf1; }
        }

        [Hl7XmlMappingAttribute(new string[] {"subjectOf2/annotationIndicator"})]
        public bool? SubjectOf2AnnotationIndicator {
            get { return this.subjectOf2AnnotationIndicator.Value; }
            set { this.subjectOf2AnnotationIndicator.Value = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"subjectOf3/clinicalDocumentEvent"})]
        public Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Iehr.Merged.ClinicalDocumentEvent SubjectOf3ClinicalDocumentEvent {
            get { return this.subjectOf3ClinicalDocumentEvent; }
            set { this.subjectOf3ClinicalDocumentEvent = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"componentOf1"})]
        public IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Iehr.Merged.Component2> ComponentOf1 {
            get { return this.componentOf1; }
        }

        [Hl7XmlMappingAttribute(new string[] {"componentOf2/patientCareProvisionEvent"})]
        public IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Merged.CareCompositions> ComponentOf2PatientCareProvisionEvent {
            get { return this.componentOf2PatientCareProvisionEvent; }
        }

    }

}