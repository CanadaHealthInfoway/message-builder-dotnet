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
 * Last modified: $LastChangedDate: 2012-02-16 11:13:36 -0500 (Thu, 16 Feb 2012) $
 * Revision:      $LastChangedRevision: 5552 $
 */
/* This class was auto-generated by the message builder generator tools. */
namespace Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r02.Pharmacy.Pome_mt010040ca {
    using Ca.Infoway.Messagebuilder.Annotation;
    using Ca.Infoway.Messagebuilder.Datatype;
    using Ca.Infoway.Messagebuilder.Datatype.Impl;
    using Ca.Infoway.Messagebuilder.Model;
    using Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r02.Common.Coct_mt120402ca;
    using Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r02.Common.Coct_mt270010ca;
    using System;
    using System.Collections.Generic;


    /**
     * <summary>Recommended Administration Instructions</summary>
     * 
     * <remarks><p>This comprises the route of administration, 
     * maximum/minimum daily dose, and overall use instructions for 
     * the drug.</p> <p>Gives guidance to prescribers on how the 
     * drug might be/should be used</p></remarks>
     */
    [Hl7PartTypeMappingAttribute(new string[] {"POME_MT010040CA.AdministrationGuideline"})]
    public class RecommendedAdministrationInstructions : MessagePartBean {

        private Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r02.Pharmacy.Pome_mt010040ca.Patient subjectPatient;
        private ST authorAssignedEntityAssignedOrganizationName;
        private IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r02.Common.Coct_mt270010ca.AdministrationInstructions> optionDosageInstruction;
        private IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r02.Common.Coct_mt120402ca.IIndications> reasonIndications;
        private IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r02.Pharmacy.Pome_mt010040ca.PatientCharacteristics> preconditionObservationEventCriterion;

        public RecommendedAdministrationInstructions() {
            this.authorAssignedEntityAssignedOrganizationName = new STImpl();
            this.optionDosageInstruction = new List<Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r02.Common.Coct_mt270010ca.AdministrationInstructions>();
            this.reasonIndications = new List<Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r02.Common.Coct_mt120402ca.IIndications>();
            this.preconditionObservationEventCriterion = new List<Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r02.Pharmacy.Pome_mt010040ca.PatientCharacteristics>();
        }
        [Hl7XmlMappingAttribute(new string[] {"subject/patient"})]
        public Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r02.Pharmacy.Pome_mt010040ca.Patient SubjectPatient {
            get { return this.subjectPatient; }
            set { this.subjectPatient = value; }
        }

        /**
         * <summary>Recommending Authority Name</summary>
         * 
         * <remarks><p>Indicates the name of the organization or agency 
         * that created the dosage recommendation</p> <p>The source of 
         * a recommendation may influence prescriber's willingness to 
         * use the recommended dose and is therefore mandatory</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"author/assignedEntity/assignedOrganization/name"})]
        public String AuthorAssignedEntityAssignedOrganizationName {
            get { return this.authorAssignedEntityAssignedOrganizationName.Value; }
            set { this.authorAssignedEntityAssignedOrganizationName.Value = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"option/dosageInstruction"})]
        public IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r02.Common.Coct_mt270010ca.AdministrationInstructions> OptionDosageInstruction {
            get { return this.optionDosageInstruction; }
        }

        [Hl7XmlMappingAttribute(new string[] {"reason/indications"})]
        public IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r02.Common.Coct_mt120402ca.IIndications> ReasonIndications {
            get { return this.reasonIndications; }
        }

        [Hl7XmlMappingAttribute(new string[] {"precondition/observationEventCriterion"})]
        public IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r02.Pharmacy.Pome_mt010040ca.PatientCharacteristics> PreconditionObservationEventCriterion {
            get { return this.preconditionObservationEventCriterion; }
        }

    }

}