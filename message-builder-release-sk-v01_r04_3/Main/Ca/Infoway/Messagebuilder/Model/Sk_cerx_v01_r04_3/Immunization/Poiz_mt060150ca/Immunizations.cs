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
namespace Ca.Infoway.Messagebuilder.Model.Sk_cerx_v01_r04_3.Immunization.Poiz_mt060150ca {
    using Ca.Infoway.Messagebuilder.Annotation;
    using Ca.Infoway.Messagebuilder.Datatype;
    using Ca.Infoway.Messagebuilder.Datatype.Impl;
    using Ca.Infoway.Messagebuilder.Datatype.Lang;
    using Ca.Infoway.Messagebuilder.Domainvalue;
    using Ca.Infoway.Messagebuilder.Model;
    using Ca.Infoway.Messagebuilder.Model.Sk_cerx_v01_r04_3.Common.Coct_mt090107ca;
    using Ca.Infoway.Messagebuilder.Model.Sk_cerx_v01_r04_3.Common.Coct_mt220210ca;
    using Ca.Infoway.Messagebuilder.Model.Sk_cerx_v01_r04_3.Common.Merged;
    using Ca.Infoway.Messagebuilder.Model.Sk_cerx_v01_r04_3.Immunization.Merged;
    using Ca.Infoway.Messagebuilder.Model.Sk_cerx_v01_r04_3.Merged;
    using Ca.Infoway.Messagebuilder.Model.Sk_cerx_v01_r04_3.Pharmacy.Merged;
    using System;
    using System.Collections.Generic;


    /**
     * <summary>Immunizations</summary>
     * 
     * <remarks><p>approachSite must be required if not using 
     * SNOMED</p><p>Route must be requires if not using 
     * SNOMED</p><p>If immunization was not refused, then refusal 
     * reason must not be specified otherwise field should be 
     * treated as populated.</p> <p>approachSite must be required 
     * if not using SNOMED</p><p>Route must be requires if not 
     * using SNOMED</p><p>If immunization was not refused, then 
     * refusal reason must not be specified otherwise field should 
     * be treated as populated.</p> <p>approachSite must be 
     * required if not using SNOMED</p><p>Route must be requires if 
     * not using SNOMED</p><p>If immunization was not refused, then 
     * refusal reason must not be specified otherwise field should 
     * be treated as populated.</p> <p>A record of a patient's 
     * immunizations.</p> <p>Necessary component of a person's 
     * overall medication profile. Helps deal with outbreaks and 
     * also drug contraindication checking.</p></remarks>
     */
    [Hl7PartTypeMappingAttribute(new string[] {"POIZ_MT060150CA.Immunization"})]
    public class Immunizations : MessagePartBean {

        private II id;
        private CD code;
        private BL negationInd;
        private TS effectiveTime;
        private CV confidentialityCode;
        private CV reasonCode;
        private CV routeCode;
        private CV approachSiteCode;
        private PQ doseQuantity;
        private Ca.Infoway.Messagebuilder.Model.Sk_cerx_v01_r04_3.Common.Merged.Patient subjectPatient;
        private Ca.Infoway.Messagebuilder.Model.Sk_cerx_v01_r04_3.Common.Coct_mt220210ca.DrugProduct consumableMedication;
        private Ca.Infoway.Messagebuilder.Model.Sk_cerx_v01_r04_3.Common.Coct_mt090107ca.Provider responsiblePartyAssignedPerson;
        private Ca.Infoway.Messagebuilder.Model.Sk_cerx_v01_r04_3.Merged.RefusedBy author;
        private Ca.Infoway.Messagebuilder.Model.Sk_cerx_v01_r04_3.Immunization.Merged.InformationSourceRole informantInformationSourceRole;
        private Ca.Infoway.Messagebuilder.Model.Sk_cerx_v01_r04_3.Merged.RecordedAt location;
        private Ca.Infoway.Messagebuilder.Model.Sk_cerx_v01_r04_3.Immunization.Merged.PartOf inFulfillmentOf;
        private IList<Ca.Infoway.Messagebuilder.Model.Sk_cerx_v01_r04_3.Pharmacy.Merged.Issues> subjectOf1DetectedIssueEvent;
        private IList<Ca.Infoway.Messagebuilder.Model.Sk_cerx_v01_r04_3.Merged.Comment> subjectOf2Annotation;
        private BL subjectOf3DetectedIssueIndicator;
        private BL subjectOf4AnnotationIndicator;
        private BL causeAdverseReactionObservationEvent;

        public Immunizations() {
            this.id = new IIImpl();
            this.code = new CDImpl();
            this.negationInd = new BLImpl();
            this.effectiveTime = new TSImpl();
            this.confidentialityCode = new CVImpl();
            this.reasonCode = new CVImpl();
            this.routeCode = new CVImpl();
            this.approachSiteCode = new CVImpl();
            this.doseQuantity = new PQImpl();
            this.subjectOf1DetectedIssueEvent = new List<Ca.Infoway.Messagebuilder.Model.Sk_cerx_v01_r04_3.Pharmacy.Merged.Issues>();
            this.subjectOf2Annotation = new List<Ca.Infoway.Messagebuilder.Model.Sk_cerx_v01_r04_3.Merged.Comment>();
            this.subjectOf3DetectedIssueIndicator = new BLImpl(false);
            this.subjectOf4AnnotationIndicator = new BLImpl(false);
            this.causeAdverseReactionObservationEvent = new BLImpl(false);
        }
        /**
         * <summary>A:Immunization Record Id</summary>
         * 
         * <remarks><p>This is an identifier assigned to a unique 
         * instance of an immunization record.</p> <p>Allows for the 
         * unique referencing of a specific immunization record. Thus 
         * the mandatory requirement.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"id"})]
        public Identifier Id {
            get { return this.id.Value; }
            set { this.id.Value = value; }
        }

        /**
         * <summary>Immunization Type</summary>
         * 
         * <remarks><p>Indicates what type of administration is being 
         * performed.</p> <p>Indicates that the type of administration 
         * is an administration, and for SNOMED, also indicates the 
         * specific type of administration. Therefore, the attribute is 
         * mandatory. The attribute is CD to allow for SNOMED 
         * post-coordination</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"code"})]
        public ActCode Code {
            get { return (ActCode) this.code.Value; }
            set { this.code.Value = value; }
        }

        /**
         * <summary>Not Immunized?</summary>
         * 
         * <remarks><p>An explicit indication that a person has not 
         * been immunized with the specified vaccine at the time 
         * indicated.</p> <p>NotImmunized</p><p>CompletionStstus (true 
         * = Not administered)</p> 
         * <p>NotImmunized</p><p>CompletionStstus (true = Not 
         * administered)</p> <p>Tracking failures to be immunized is 
         * also important in immunization reporting. Marked as 
         * mandatory because it is not meaningful for this flag to be 
         * 'unknown'.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"negationInd"})]
        public bool? NegationInd {
            get { return this.negationInd.Value; }
            set { this.negationInd.Value = value; }
        }

        /**
         * <summary>C:Immunization Date</summary>
         * 
         * <remarks><p>The date vaccination(s) was administered to the 
         * patient.</p> 
         * <p>ZDP.13.2.2</p><p>ZDP.13.3</p><p>ZDP.13.4</p><p>ZDP.13.5</p> 
         * <p>ZDP.13.2.2</p><p>ZDP.13.3</p><p>ZDP.13.4</p><p>ZDP.13.5</p> 
         * <p>ZDP.13.2.2</p><p>ZDP.13.3</p><p>ZDP.13.4</p><p>ZDP.13.5</p> 
         * <p>ZDP.13.2.2</p><p>ZDP.13.3</p><p>ZDP.13.4</p><p>ZDP.13.5</p> 
         * <p>Important information for establishing the validity of 
         * the immunization records, and therefore mandatory. Also used 
         * in the scheduling of subsequent immunizations.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"effectiveTime"})]
        public PlatformDate EffectiveTime {
            get { return this.effectiveTime.Value; }
            set { this.effectiveTime.Value = value; }
        }

        /**
         * <summary>D:Immunization Masking Indicator</summary>
         * 
         * <remarks><p>Denotes access restriction place on the 
         * immunization record.</p> <p>Provides support for additional 
         * confidentiality constraint to reflect the wishes of the 
         * patient.</p><p>The attribute is optional because not all 
         * systems will support masking.</p> <p>Provides support for 
         * additional confidentiality constraint to reflect the wishes 
         * of the patient.</p><p>The attribute is optional because not 
         * all systems will support masking.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"confidentialityCode"})]
        public x_VeryBasicConfidentialityKind ConfidentialityCode {
            get { return (x_VeryBasicConfidentialityKind) this.confidentialityCode.Value; }
            set { this.confidentialityCode.Value = value; }
        }

        /**
         * <summary>Immunization Refusal Reason</summary>
         * 
         * <remarks><p>A coded value denoting a patient's reason for 
         * refusing to be immunized.</p><p>Typical reasons include: 
         * Parental decision, Religious exemption, Patient decision, 
         * etc</p> <p>A coded value denoting a patient's reason for 
         * refusing to be immunized.</p><p>Typical reasons include: 
         * Parental decision, Religious exemption, Patient decision, 
         * etc</p> <p>CompletionStatus (Refused)</p> <p>Allows sorting 
         * and categorizing different kinds of refusal reasons. Ensures 
         * that reasons are gathered in a consistent analyzable 
         * manner.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"reasonCode"})]
        public ActNoImmunizationReason ReasonCode {
            get { return (ActNoImmunizationReason) this.reasonCode.Value; }
            set { this.reasonCode.Value = value; }
        }

        /**
         * <summary>E:Route of Administration</summary>
         * 
         * <remarks><p>This is the means by which the drug was 
         * administered to the patient.</p> <p>Route of 
         * administration</p> <p>Ensures consistency in description of 
         * routes.</p><p>Attribute is marked 'optional' to allow for 
         * use of pre-coordinated SNOMED Codes.</p> <p>Ensures 
         * consistency in description of routes.</p><p>Attribute is 
         * marked 'optional' to allow for use of pre-coordinated SNOMED 
         * Codes.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"routeCode"})]
        public RouteOfAdministration RouteCode {
            get { return (RouteOfAdministration) this.routeCode.Value; }
            set { this.routeCode.Value = value; }
        }

        /**
         * <summary>Administration Site</summary>
         * 
         * <remarks><p>A coded value denoting the body area where the 
         * immunization was administered.</p> <p>RXR.2</p> <p>Some 
         * immunizations are intended to adjust from site to site. 
         * (E.g. if first injection is given in right deltoid, first 
         * booster should be given in left deltoid.)</p><p>Attribute is 
         * marked &quot;optional&quot; to allow for use of 
         * pre-coordinated SNOMED Codes.</p> <p>Some immunizations are 
         * intended to adjust from site to site. (E.g. if first 
         * injection is given in right deltoid, first booster should be 
         * given in left deltoid.)</p><p>Attribute is marked 
         * &quot;optional&quot; to allow for use of pre-coordinated 
         * SNOMED Codes.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"approachSiteCode"})]
        public HumanSubstanceAdministrationSite ApproachSiteCode {
            get { return (HumanSubstanceAdministrationSite) this.approachSiteCode.Value; }
            set { this.approachSiteCode.Value = value; }
        }

        /**
         * <summary>Quantity Administered</summary>
         * 
         * <remarks><p>The amount of the vaccine administered to/by the 
         * patient.</p> <p>Useful for evaluating reaction and for 
         * checking contraindication.</p><p>Attribute is populated to 
         * allow for situations where quantity may not be known and 
         * thus null flavor must be specified.</p> <p>Useful for 
         * evaluating reaction and for checking 
         * contraindication.</p><p>Attribute is populated to allow for 
         * situations where quantity may not be known and thus null 
         * flavor must be specified.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"doseQuantity"})]
        public PhysicalQuantity DoseQuantity {
            get { return this.doseQuantity.Value; }
            set { this.doseQuantity.Value = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"subject/patient"})]
        public Ca.Infoway.Messagebuilder.Model.Sk_cerx_v01_r04_3.Common.Merged.Patient SubjectPatient {
            get { return this.subjectPatient; }
            set { this.subjectPatient = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"consumable/medication"})]
        public Ca.Infoway.Messagebuilder.Model.Sk_cerx_v01_r04_3.Common.Coct_mt220210ca.DrugProduct ConsumableMedication {
            get { return this.consumableMedication; }
            set { this.consumableMedication = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"responsibleParty/assignedPerson"})]
        public Ca.Infoway.Messagebuilder.Model.Sk_cerx_v01_r04_3.Common.Coct_mt090107ca.Provider ResponsiblePartyAssignedPerson {
            get { return this.responsiblePartyAssignedPerson; }
            set { this.responsiblePartyAssignedPerson = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"author"})]
        public Ca.Infoway.Messagebuilder.Model.Sk_cerx_v01_r04_3.Merged.RefusedBy Author {
            get { return this.author; }
            set { this.author = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"informant/informationSourceRole"})]
        public Ca.Infoway.Messagebuilder.Model.Sk_cerx_v01_r04_3.Immunization.Merged.InformationSourceRole InformantInformationSourceRole {
            get { return this.informantInformationSourceRole; }
            set { this.informantInformationSourceRole = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"location"})]
        public Ca.Infoway.Messagebuilder.Model.Sk_cerx_v01_r04_3.Merged.RecordedAt Location {
            get { return this.location; }
            set { this.location = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"inFulfillmentOf"})]
        public Ca.Infoway.Messagebuilder.Model.Sk_cerx_v01_r04_3.Immunization.Merged.PartOf InFulfillmentOf {
            get { return this.inFulfillmentOf; }
            set { this.inFulfillmentOf = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"subjectOf1/detectedIssueEvent"})]
        public IList<Ca.Infoway.Messagebuilder.Model.Sk_cerx_v01_r04_3.Pharmacy.Merged.Issues> SubjectOf1DetectedIssueEvent {
            get { return this.subjectOf1DetectedIssueEvent; }
        }

        [Hl7XmlMappingAttribute(new string[] {"subjectOf2/annotation"})]
        public IList<Ca.Infoway.Messagebuilder.Model.Sk_cerx_v01_r04_3.Merged.Comment> SubjectOf2Annotation {
            get { return this.subjectOf2Annotation; }
        }

        [Hl7XmlMappingAttribute(new string[] {"subjectOf3/detectedIssueIndicator"})]
        public bool? SubjectOf3DetectedIssueIndicator {
            get { return this.subjectOf3DetectedIssueIndicator.Value; }
            set { this.subjectOf3DetectedIssueIndicator.Value = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"subjectOf4/annotationIndicator"})]
        public bool? SubjectOf4AnnotationIndicator {
            get { return this.subjectOf4AnnotationIndicator.Value; }
            set { this.subjectOf4AnnotationIndicator.Value = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"cause/adverseReactionObservationEvent"})]
        public bool? CauseAdverseReactionObservationEvent {
            get { return this.causeAdverseReactionObservationEvent.Value; }
            set { this.causeAdverseReactionObservationEvent.Value = value; }
        }

    }

}