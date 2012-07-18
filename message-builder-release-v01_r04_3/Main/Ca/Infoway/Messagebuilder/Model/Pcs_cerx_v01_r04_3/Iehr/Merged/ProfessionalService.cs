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
 * Last modified: $LastChangedDate: 2012-02-16 10:57:39 -0500 (Thu, 16 Feb 2012) $
 * Revision:      $LastChangedRevision: 5361 $
 */
/* This class was auto-generated by the message builder generator tools. */
namespace Ca.Infoway.Messagebuilder.Model.Pcs_cerx_v01_r04_3.Iehr.Merged {
    using Ca.Infoway.Messagebuilder.Annotation;
    using Ca.Infoway.Messagebuilder.Datatype;
    using Ca.Infoway.Messagebuilder.Datatype.Impl;
    using Ca.Infoway.Messagebuilder.Datatype.Lang;
    using Ca.Infoway.Messagebuilder.Domainvalue;
    using Ca.Infoway.Messagebuilder.Model;
    using Ca.Infoway.Messagebuilder.Model.Pcs_cerx_v01_r04_3.Common.Coct_mt090107ca;
    using Ca.Infoway.Messagebuilder.Model.Pcs_cerx_v01_r04_3.Common.Merged;
    using Ca.Infoway.Messagebuilder.Model.Pcs_cerx_v01_r04_3.Merged;
    using System;
    using System.Collections.Generic;


    /**
     * <summary>ProfessionalService</summary>
     * 
     * <remarks>REPC_MT000017CA.ProcedureEvent: Professional 
     * Service <p>This is the information that is recorded and 
     * maintained on a consultative service provided to a patient. 
     * This service may or may not be related to a prescribed, 
     * dispensed or administered drug.</p> 
     * <p>A_BillableClinicalService</p> <p>May be pertinent 
     * information with respect to a patient's drug therapy 
     * regime.</p> REPC_MT100001CA.ProcedureEvent: Professional 
     * Service <p>Annotation is only permitted if Annotation 
     * Indicator is not present and vice versa</p> <p>This is the 
     * information that is recorded and maintained on a 
     * consultative service provided to a patient. This service may 
     * or may not be related to a prescribed, dispensed or 
     * administered drug.</p> <p>A_BillableClinicalService</p> 
     * <p>May be pertinent information with respect to a patient's 
     * drug therapy regime.</p></remarks>
     */
    [Hl7PartTypeMappingAttribute(new string[] {"REPC_MT000017CA.ProcedureEvent","REPC_MT100001CA.ProcedureEvent"})]
    public class ProfessionalService : MessagePartBean {

        private CV code;
        private IVL<TS, Interval<PlatformDate>> effectiveTime;
        private CV confidentialityCode;
        private Ca.Infoway.Messagebuilder.Model.Pcs_cerx_v01_r04_3.Common.Merged.Patient subjectPatient;
        private Ca.Infoway.Messagebuilder.Model.Pcs_cerx_v01_r04_3.Iehr.Merged.OrderForService inFulfillmentOfActRequest;
        private IList<Ca.Infoway.Messagebuilder.Model.Pcs_cerx_v01_r04_3.Merged.Comment> subjectOf2Annotation;
        private II id;
        private Ca.Infoway.Messagebuilder.Model.Pcs_cerx_v01_r04_3.Common.Coct_mt090107ca.Provider responsiblePartyAssignedPerson;
        private Ca.Infoway.Messagebuilder.Model.Pcs_cerx_v01_r04_3.Common.Coct_mt090107ca.Provider performerAssignedPerson;
        private Ca.Infoway.Messagebuilder.Model.Pcs_cerx_v01_r04_3.Merged.RecordedAt location;
        private BL subjectOf1AnnotationIndicator;

        public ProfessionalService() {
            this.code = new CVImpl();
            this.effectiveTime = new IVLImpl<TS, Interval<PlatformDate>>();
            this.confidentialityCode = new CVImpl();
            this.subjectOf2Annotation = new List<Ca.Infoway.Messagebuilder.Model.Pcs_cerx_v01_r04_3.Merged.Comment>();
            this.id = new IIImpl();
            this.subjectOf1AnnotationIndicator = new BLImpl(false);
        }
        /**
         * <summary>ServiceCode</summary>
         * 
         * <remarks>B:Service Code <p>Identifies the specific service 
         * that has been performed. This is obtained from the 
         * professional service catalog pertaining to the discipline of 
         * the health service provider.</p> 
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
         * (modifier)</p><p>A_BillableClinicalService</p> <p>Allows the 
         * service to be sorted and filtered. Ensures consistency for 
         * analysis and reporting purposes and is therefore 
         * mandatory</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"code"})]
        public ActProfessionalServiceCode Code {
            get { return (ActProfessionalServiceCode) this.code.Value; }
            set { this.code.Value = value; }
        }

        /**
         * <summary>ConsultationTimeAndLength</summary>
         * 
         * <remarks>C:Consultation Time and Length <p>Center date 
         * cannot be null But duration can be left unspecified if not 
         * known.</p> <p>The date and time on which the professional 
         * service was performed, as well as the duration of the 
         * service.</p> 
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
         * <p>Allows the service-event to be located in a particular 
         * time. Because a time won't always be known, the attribute is 
         * only marked as &quot;populated&quot;. The duration of the 
         * consultation may also be of clinical interest.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"effectiveTime"})]
        public Interval<PlatformDate> EffectiveTime {
            get { return this.effectiveTime.Value; }
            set { this.effectiveTime.Value = value; }
        }

        /**
         * <summary>ProfessionalServiceMaskingIndicator</summary>
         * 
         * <remarks>D:Professional Service Masking Indicator 
         * <p>Communicates the intent of the patient to restrict access 
         * to their professional service records. Provides support for 
         * additional confidentiality constraint, giving patients a 
         * level of control over their information. Valid values are: 
         * 'NORMAL' (denotes 'Not Masked'); and 'RESTRICTED' (denotes 
         * 'Masked'). The default is 'NORMAL' signifying 'Not 
         * Masked'.</p> <p>Allows the patient to have discrete control 
         * over access to their medication data.</p><p>The attribute is 
         * optional because not all systems will support masking.</p> 
         * <p>Allows the patient to have discrete control over access 
         * to their medication data.</p><p>The attribute is optional 
         * because not all systems will support masking.</p> 
         * D:Professional Service Masking Indicator <p>Communicates the 
         * intent of the patient to restrict access to their 
         * professional service record. Provides support for additional 
         * confidentiality constraint, giving patients a level of 
         * control over their information. Valid values are: 'NORMAL' 
         * (denotes 'Not Masked'); and 'RESTRICTED' (denotes 'Masked'). 
         * The default is 'NORMAL' signifying 'Not Masked'.</p> 
         * <p>Allows the patient to have discrete control over access 
         * to their medication data.</p><p>The attribute is optional 
         * because not all systems will support masking.</p> <p>Allows 
         * the patient to have discrete control over access to their 
         * medication data.</p><p>The attribute is optional because not 
         * all systems will support masking.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"confidentialityCode"})]
        public x_VeryBasicConfidentialityKind ConfidentialityCode {
            get { return (x_VeryBasicConfidentialityKind) this.confidentialityCode.Value; }
            set { this.confidentialityCode.Value = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"subject/patient"})]
        public Ca.Infoway.Messagebuilder.Model.Pcs_cerx_v01_r04_3.Common.Merged.Patient SubjectPatient {
            get { return this.subjectPatient; }
            set { this.subjectPatient = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"inFulfillmentOf/actRequest"})]
        public Ca.Infoway.Messagebuilder.Model.Pcs_cerx_v01_r04_3.Iehr.Merged.OrderForService InFulfillmentOfActRequest {
            get { return this.inFulfillmentOfActRequest; }
            set { this.inFulfillmentOfActRequest = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"subjectOf/annotation","subjectOf2/annotation"})]
        [Hl7MapByPartType(Name="subjectOf", Type="REPC_MT000017CA.Subject2")]
        [Hl7MapByPartType(Name="subjectOf/annotation", Type="COCT_MT120600CA.Annotation")]
        [Hl7MapByPartType(Name="subjectOf2", Type="REPC_MT100001CA.Subject2")]
        [Hl7MapByPartType(Name="subjectOf2/annotation", Type="COCT_MT120600CA.Annotation")]
        public IList<Ca.Infoway.Messagebuilder.Model.Pcs_cerx_v01_r04_3.Merged.Comment> SubjectOf2Annotation {
            get { return this.subjectOf2Annotation; }
        }

        /**
         * <summary>ServiceRecordIdentifier</summary>
         * 
         * <remarks>A:Service Record Identifier <p>A unique identifier 
         * for a patient consultation service record.</p> 
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
         * (extension)</p><p>A_BillableClinicalService</p> <p>Allows 
         * cognitive services to be uniquely referenced and is 
         * therefore mandatory.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"id"})]
        public Identifier Id {
            get { return this.id.Value; }
            set { this.id.Value = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"responsibleParty/assignedPerson"})]
        public Ca.Infoway.Messagebuilder.Model.Pcs_cerx_v01_r04_3.Common.Coct_mt090107ca.Provider ResponsiblePartyAssignedPerson {
            get { return this.responsiblePartyAssignedPerson; }
            set { this.responsiblePartyAssignedPerson = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"performer/assignedPerson"})]
        public Ca.Infoway.Messagebuilder.Model.Pcs_cerx_v01_r04_3.Common.Coct_mt090107ca.Provider PerformerAssignedPerson {
            get { return this.performerAssignedPerson; }
            set { this.performerAssignedPerson = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"location"})]
        public Ca.Infoway.Messagebuilder.Model.Pcs_cerx_v01_r04_3.Merged.RecordedAt Location {
            get { return this.location; }
            set { this.location = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"subjectOf1/annotationIndicator"})]
        public bool? SubjectOf1AnnotationIndicator {
            get { return this.subjectOf1AnnotationIndicator.Value; }
            set { this.subjectOf1AnnotationIndicator.Value = value; }
        }

    }

}