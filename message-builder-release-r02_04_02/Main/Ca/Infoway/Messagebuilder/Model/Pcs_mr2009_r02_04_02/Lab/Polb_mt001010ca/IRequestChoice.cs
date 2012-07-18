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
 * Last modified: $LastChangedDate: 2012-01-18 21:08:54 -0500 (Wed, 18 Jan 2012) $
 * Revision:      $LastChangedRevision: 3979 $
 */

/* This class was auto-generated by the message builder generator tools. */
namespace Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Lab.Polb_mt001010ca {
    using Ca.Infoway.Messagebuilder.Annotation;
    using Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Common.Coct_mt090508ca;
    using Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Common.Coct_mt130001ca;
    using Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Common.Merged;
    using Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Lab.Merged;
    using Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Merged;
    using System.Collections.Generic;


    [Hl7PartTypeMappingAttribute(new string[] {"POLB_MT001010CA.RequestChoice"})]
    public interface IRequestChoice {

        [Hl7XmlMappingAttribute(new string[] {"specimen/specimen"})]
        IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Merged.SpecimenRole> SpecimenSpecimen {
            get;
        }

        [Hl7XmlMappingAttribute(new string[] {"recordTarget/patient"})]
        Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Common.Merged.Patient_1 RecordTargetPatient {
            get;
            set;
        }

        [Hl7XmlMappingAttribute(new string[] {"performer/assignedEntity"})]
        Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Common.Coct_mt090508ca.HealthcareOrganization PerformerAssignedEntity {
            get;
            set;
        }

        [Hl7XmlMappingAttribute(new string[] {"callBackContact/assignedEntity"})]
        IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Common.Merged.HealthcareWorker> CallBackContactAssignedEntity {
            get;
        }

        [Hl7XmlMappingAttribute(new string[] {"informationRecipient/recipientChoice"})]
        IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Lab.Merged.IRecipientChoice> InformationRecipientRecipientChoice {
            get;
        }

        [Hl7XmlMappingAttribute(new string[] {"verifier/assignedEntity"})]
        IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Common.Merged.HealthcareWorker> VerifierAssignedEntity {
            get;
        }

        [Hl7XmlMappingAttribute(new string[] {"occurrenceOf/actParentPointer"})]
        Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Lab.Merged.ParentTest OccurrenceOfActParentPointer {
            get;
            set;
        }

        [Hl7XmlMappingAttribute(new string[] {"pertinentInformation1/outbreakEvent"})]
        Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Lab.Merged.Outbreak PertinentInformation1OutbreakEvent {
            get;
            set;
        }

        [Hl7XmlMappingAttribute(new string[] {"pertinentInformation2/supportingClinicalObservationEvent"})]
        IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Lab.Merged.SupportingClinicalInformation> PertinentInformation2SupportingClinicalObservationEvent {
            get;
        }

        [Hl7XmlMappingAttribute(new string[] {"component1/referralRedirectIndicator"})]
        Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Lab.Merged.ReferralRedirectIndicator Component1ReferralRedirectIndicator {
            get;
            set;
        }

        [Hl7XmlMappingAttribute(new string[] {"component2/requestSortKey"})]
        Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Lab.Merged.OrderSortKey Component2RequestSortKey {
            get;
            set;
        }

        [Hl7XmlMappingAttribute(new string[] {"component3/labInitiatedOrderIndicator"})]
        Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Lab.Merged.LabInitiatedOrderIndicator Component3LabInitiatedOrderIndicator {
            get;
            set;
        }

        [Hl7XmlMappingAttribute(new string[] {"component4/requestChoice"})]
        IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Lab.Polb_mt001010ca.IRequestChoice> Component4RequestChoice {
            get;
        }

        [Hl7XmlMappingAttribute(new string[] {"subjectOf1"})]
        IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Merged.Includes> SubjectOf1 {
            get;
        }

        [Hl7XmlMappingAttribute(new string[] {"subjectOf2/controlActEvent"})]
        Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Common.Coct_mt130001ca.VersionInformation SubjectOf2ControlActEvent {
            get;
            set;
        }

        [Hl7XmlMappingAttribute(new string[] {"componentOf/priorActRequest"})]
        Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Lab.Merged.PriorTestRequest ComponentOfPriorActRequest {
            get;
            set;
        }

    }

}