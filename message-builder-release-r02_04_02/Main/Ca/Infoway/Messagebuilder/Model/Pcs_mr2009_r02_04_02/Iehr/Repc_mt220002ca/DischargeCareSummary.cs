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
 * Last modified: $LastChangedDate: 2012-01-18 21:07:02 -0500 (Wed, 18 Jan 2012) $
 * Revision:      $LastChangedRevision: 3953 $
 */

/* This class was auto-generated by the message builder generator tools. */
namespace Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Iehr.Repc_mt220002ca {
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
     * <summary>Discharge-Care Summary</summary>
     * 
     * <remarks><p>Annotation is only permitted if Annotation 
     * Indicator is not present and vice versa</p> <p>Represents a 
     * particular health-related document pertaining to a single 
     * patient.</p> <p>Allows the capture of patient health data in 
     * an encapsulated, contextualized manner with capability of 
     * displaying rendered content and communication between simple 
     * systems.</p></remarks>
     */
    [Hl7PartTypeMappingAttribute(new string[] {"REPC_MT220002CA.Document"})]
    public class DischargeCareSummary : MessagePartBean, Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Iehr.Comt_mt111111ca.ISHR {

        private II documentIdentifier;
        private CV documentCategory;
        private ST documentTitle;
        private SET<CV, Code> documentMaskingIndicators;
        private Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Common.Coct_mt911108ca.IActingPerson responsiblePartyActingPerson;
        private Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Iehr.Merged.RequestedBy author;
        private Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Common.Merged.ServiceLocation custodian1ServiceDeliveryLocation;
        private Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Common.Merged.EHRRepository custodian2AssignedDevice;
        private IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Iehr.Merged.IRecipients> primaryInformationRecipientRecipients;
        private IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Iehr.Merged.OldClinicalDocumentEvent> predecessorOldClinicalDocumentEvent;
        private Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Iehr.Merged.IDocumentContent_2 componentStructuredBodyComponentSectionComponentDocumentContent;
        private Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Iehr.Merged.NewClinicalDocumentEvent successorNewClinicalDocumentEvent;
        private Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Merged.Includes subjectOf1;
        private BL subjectOf2AnnotationIndicator;
        private IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Merged.CareCompositions> componentOfPatientCareProvisionEvent;

        public DischargeCareSummary() {
            this.documentIdentifier = new IIImpl();
            this.documentCategory = new CVImpl();
            this.documentTitle = new STImpl();
            this.documentMaskingIndicators = new SETImpl<CV, Code>(typeof(CVImpl));
            this.primaryInformationRecipientRecipients = new List<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Iehr.Merged.IRecipients>();
            this.predecessorOldClinicalDocumentEvent = new List<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Iehr.Merged.OldClinicalDocumentEvent>();
            this.subjectOf2AnnotationIndicator = new BLImpl(false);
            this.componentOfPatientCareProvisionEvent = new List<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Merged.CareCompositions>();
        }
        /**
         * <summary>A: Document Identifier</summary>
         * 
         * <remarks></p> </p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"id"})]
        public Identifier DocumentIdentifier {
            get { return this.documentIdentifier.Value; }
            set { this.documentIdentifier.Value = value; }
        }

        /**
         * <summary>B: Document Category</summary>
         * 
         * <remarks></p> </p> </p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"code"})]
        public CareSummaryDocumentType DocumentCategory {
            get { return (CareSummaryDocumentType) this.documentCategory.Value; }
            set { this.documentCategory.Value = value; }
        }

        /**
         * <summary>J: Document Title</summary>
         * 
         * <remarks><p>A human-readable label for this particular 
         * document.</p> <p>This is a human-recognizable name intended 
         * to be displayed on the screen in list transactions and is 
         * therefore mandatory. It provides a good indication of the 
         * content of the document at a quick glance.</p> <p>Titles do 
         * not necessarily need to be unique, but should be 
         * precise-enough to give a pretty good idea of what the 
         * document contains. For example &quot;Right Knee Arthroscopy 
         * Report, Jan 3, 2006&quot; would represent a good title. 
         * &quot;Surgery Report&quot; would not.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"title"})]
        public String DocumentTitle {
            get { return this.documentTitle.Value; }
            set { this.documentTitle.Value = value; }
        }

        /**
         * <summary>E: Document Masking Indicators</summary>
         * 
         * <remarks></p> </p> </p> </p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"confidentialityCode"})]
        public ICollection<x_BasicConfidentialityKind> DocumentMaskingIndicators {
            get { return this.documentMaskingIndicators.RawSet<x_BasicConfidentialityKind>(); }
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

        [Hl7XmlMappingAttribute(new string[] {"author"})]
        public Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Iehr.Merged.RequestedBy Author {
            get { return this.author; }
            set { this.author = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"custodian1/serviceDeliveryLocation"})]
        public Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Common.Merged.ServiceLocation Custodian1ServiceDeliveryLocation {
            get { return this.custodian1ServiceDeliveryLocation; }
            set { this.custodian1ServiceDeliveryLocation = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"custodian2/assignedDevice"})]
        public Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Common.Merged.EHRRepository Custodian2AssignedDevice {
            get { return this.custodian2AssignedDevice; }
            set { this.custodian2AssignedDevice = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"primaryInformationRecipient/recipients"})]
        public IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Iehr.Merged.IRecipients> PrimaryInformationRecipientRecipients {
            get { return this.primaryInformationRecipientRecipients; }
        }

        [Hl7XmlMappingAttribute(new string[] {"predecessor/oldClinicalDocumentEvent"})]
        public IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Iehr.Merged.OldClinicalDocumentEvent> PredecessorOldClinicalDocumentEvent {
            get { return this.predecessorOldClinicalDocumentEvent; }
        }

        [Hl7XmlMappingAttribute(new string[] {"component/structuredBody/component/section/component/documentContent"})]
        public Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Iehr.Merged.IDocumentContent_2 ComponentStructuredBodyComponentSectionComponentDocumentContent {
            get { return this.componentStructuredBodyComponentSectionComponentDocumentContent; }
            set { this.componentStructuredBodyComponentSectionComponentDocumentContent = value; }
        }

        public Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Iehr.Merged.DischargeCareSummaryReport ComponentStructuredBodyComponentSectionComponentDocumentContentAsPatientCareProvisionEvent {
            get { return this.componentStructuredBodyComponentSectionComponentDocumentContent is Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Iehr.Merged.DischargeCareSummaryReport ? (Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Iehr.Merged.DischargeCareSummaryReport) this.componentStructuredBodyComponentSectionComponentDocumentContent : (Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Iehr.Merged.DischargeCareSummaryReport) null; }
        }
        public bool HasComponentStructuredBodyComponentSectionComponentDocumentContentAsPatientCareProvisionEvent() {
            return (this.componentStructuredBodyComponentSectionComponentDocumentContent is Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Iehr.Merged.DischargeCareSummaryReport);
        }

        [Hl7XmlMappingAttribute(new string[] {"successor/newClinicalDocumentEvent"})]
        public Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Iehr.Merged.NewClinicalDocumentEvent SuccessorNewClinicalDocumentEvent {
            get { return this.successorNewClinicalDocumentEvent; }
            set { this.successorNewClinicalDocumentEvent = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"subjectOf1"})]
        public Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Merged.Includes SubjectOf1 {
            get { return this.subjectOf1; }
            set { this.subjectOf1 = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"subjectOf2/annotationIndicator"})]
        public bool? SubjectOf2AnnotationIndicator {
            get { return this.subjectOf2AnnotationIndicator.Value; }
            set { this.subjectOf2AnnotationIndicator.Value = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"componentOf/patientCareProvisionEvent"})]
        public IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Merged.CareCompositions> ComponentOfPatientCareProvisionEvent {
            get { return this.componentOfPatientCareProvisionEvent; }
        }

    }

}