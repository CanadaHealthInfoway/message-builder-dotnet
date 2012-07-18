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
namespace Ca.Infoway.Messagebuilder.Model.Sk_cerx_v01_r04_3.Pharmacy.Merged {
    using Ca.Infoway.Messagebuilder.Annotation;
    using Ca.Infoway.Messagebuilder.Datatype;
    using Ca.Infoway.Messagebuilder.Datatype.Impl;
    using Ca.Infoway.Messagebuilder.Datatype.Lang;
    using Ca.Infoway.Messagebuilder.Model;
    using System;


    /**
     * <summary>IssueDescription</summary>
     * 
     * <remarks>PORX_MT980010CA.DetectedIssueDefinition: Issue 
     * Description <p>This is the decision support rule that 
     * triggered the issue.</p> <p>Provides detailed background for 
     * providers in evaluating the issue.</p> 
     * PORX_MT980020CA.DetectedIssueDefinition: Issue Description 
     * <p>This is the decision support rule that triggered the 
     * issue.</p> <p>Provides detailed background for providers in 
     * evaluating the issue.</p> 
     * PORX_MT980030CA.DetectedIssueDefinition: Issue Description 
     * <p>This is the decision support rule that triggered the 
     * issue.</p> <p>Provides detailed background for providers in 
     * evaluating the issue.</p></remarks>
     */
    [Hl7PartTypeMappingAttribute(new string[] {"PORX_MT980010CA.DetectedIssueDefinition","PORX_MT980020CA.DetectedIssueDefinition","PORX_MT980030CA.DetectedIssueDefinition"})]
    public class IssueDescription : MessagePartBean {

        private II id;
        private ANY<object> text;
        private TS authorTime;
        private ST authorAssignedEntityAssignedOrganizationName;
        private Ca.Infoway.Messagebuilder.Model.Sk_cerx_v01_r04_3.Pharmacy.Merged.RecommendedDosage componentSubstanceAdministrationEventCriterion;

        public IssueDescription() {
            this.id = new IIImpl();
            this.text = new ANYImpl<object>();
            this.authorTime = new TSImpl();
            this.authorAssignedEntityAssignedOrganizationName = new STImpl();
        }
        /**
         * <summary>IssueMonographId</summary>
         * 
         * <remarks>A:Issue Monograph Id <p>Knowledgebase organization 
         * specific identifier for the issue definition.</p> 
         * <p>DDIMonograph.DDIMonographId</p><p>ZPE.2</p><p>MB.05.03C</p><p>ZPS.14</p><p>ZDU.5.2</p><p>A_DetectedMedicationIssue</p><p>Monograph 
         * Code</p> 
         * <p>DDIMonograph.DDIMonographId</p><p>ZPE.2</p><p>MB.05.03C</p><p>ZPS.14</p><p>ZDU.5.2</p><p>A_DetectedMedicationIssue</p><p>Monograph 
         * Code</p> 
         * <p>DDIMonograph.DDIMonographId</p><p>ZPE.2</p><p>MB.05.03C</p><p>ZPS.14</p><p>ZDU.5.2</p><p>A_DetectedMedicationIssue</p><p>Monograph 
         * Code</p> 
         * <p>DDIMonograph.DDIMonographId</p><p>ZPE.2</p><p>MB.05.03C</p><p>ZPS.14</p><p>ZDU.5.2</p><p>A_DetectedMedicationIssue</p><p>Monograph 
         * Code</p> 
         * <p>DDIMonograph.DDIMonographId</p><p>ZPE.2</p><p>MB.05.03C</p><p>ZPS.14</p><p>ZDU.5.2</p><p>A_DetectedMedicationIssue</p><p>Monograph 
         * Code</p> 
         * <p>DDIMonograph.DDIMonographId</p><p>ZPE.2</p><p>MB.05.03C</p><p>ZPS.14</p><p>ZDU.5.2</p><p>A_DetectedMedicationIssue</p><p>Monograph 
         * Code</p> 
         * <p>DDIMonograph.DDIMonographId</p><p>ZPE.2</p><p>MB.05.03C</p><p>ZPS.14</p><p>ZDU.5.2</p><p>A_DetectedMedicationIssue</p><p>Monograph 
         * Code</p> <p>Allows applications to match with local 
         * Knowledge-bases and avoid displaying duplicate issues to 
         * providers.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"id"})]
        public Identifier Id {
            get { return this.id.Value; }
            set { this.id.Value = value; }
        }

        /**
         * <summary>IssueDescription</summary>
         * 
         * <remarks>C:Issue Description <p>A free form textual 
         * description of the issue. This is usually in the form of a 
         * monograph.</p> <p>Monograph URI (Reference)</p><p>Monograph 
         * description</p> <p>Monograph URI (Reference)</p><p>Monograph 
         * description</p> <p>Provides detailed clinical background on 
         * reasons for issue.</p> C:Issue Description <p>A free form 
         * textual description of the issue. This is usually in the 
         * form of a monograph.</p> <p>Monograph URI 
         * (Reference)</p><p>Monograph description</p> <p>Monograph URI 
         * (Reference)</p><p>Monograph description</p> <p>Provides 
         * detailed clinical background on reasons for issue.</p> 
         * <p>monograph ID is not recognized by PIN.&nbsp;</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"text"})]
        public object Text {
            get { return this.text.Value; }
            set { this.text.Value = value; }
        }

        /**
         * <summary>IssueMonographEffectiveDate</summary>
         * 
         * <remarks>B:Issue Monograph Effective Date <p>The date and 
         * time on which the monograph becomes valid and 
         * applicable.</p> 
         * <p>DDIMonograph.EffectiveDate</p><p>A_DetectedMedicationIssue</p> 
         * <p>DDIMonograph.EffectiveDate</p><p>A_DetectedMedicationIssue</p> 
         * <p>Allows detailed matching of local knowledgebase record 
         * with that of the central. (The monograph id may remain the 
         * same, but the effective date will always change).</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"author/time"})]
        public PlatformDate AuthorTime {
            get { return this.authorTime.Value; }
            set { this.authorTime.Value = value; }
        }

        /**
         * <summary>KnowledgebaseVendorName</summary>
         * 
         * <remarks>C:Knowledgebase Vendor Name <p>The name of a 
         * clinical knowledgebase vendor organization.</p> <p>Allows a 
         * knowledgebase vendor to be referenced by name.</p><p>The 
         * attribute is mandatory because it is the only information 
         * collected about a knowledgebase vendor.</p> <p>Allows a 
         * knowledgebase vendor to be referenced by name.</p><p>The 
         * attribute is mandatory because it is the only information 
         * collected about a knowledgebase vendor.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"author/assignedEntity/assignedOrganization/name"})]
        public String AuthorAssignedEntityAssignedOrganizationName {
            get { return this.authorAssignedEntityAssignedOrganizationName.Value; }
            set { this.authorAssignedEntityAssignedOrganizationName.Value = value; }
        }

        /**
         * <summary>Reccomended Dosage</summary>
         * 
         * <remarks><p>various age groups, weight classes, 
         * etc.&nbsp;</p> Recommended Dosage <div>various age groups, 
         * weight classes, etc.</div></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"component/substanceAdministrationEventCriterion"})]
        public Ca.Infoway.Messagebuilder.Model.Sk_cerx_v01_r04_3.Pharmacy.Merged.RecommendedDosage ComponentSubstanceAdministrationEventCriterion {
            get { return this.componentSubstanceAdministrationEventCriterion; }
            set { this.componentSubstanceAdministrationEventCriterion = value; }
        }

    }

}