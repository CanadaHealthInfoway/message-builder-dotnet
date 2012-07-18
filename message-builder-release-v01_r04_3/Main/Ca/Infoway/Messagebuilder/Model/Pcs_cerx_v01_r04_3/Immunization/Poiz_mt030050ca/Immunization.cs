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
 * Last modified: $LastChangedDate: 2012-02-16 10:58:08 -0500 (Thu, 16 Feb 2012) $
 * Revision:      $LastChangedRevision: 5370 $
 */
/* This class was auto-generated by the message builder generator tools. */
namespace Ca.Infoway.Messagebuilder.Model.Pcs_cerx_v01_r04_3.Immunization.Poiz_mt030050ca {
    using Ca.Infoway.Messagebuilder.Annotation;
    using Ca.Infoway.Messagebuilder.Datatype;
    using Ca.Infoway.Messagebuilder.Datatype.Impl;
    using Ca.Infoway.Messagebuilder.Datatype.Lang;
    using Ca.Infoway.Messagebuilder.Domainvalue;
    using Ca.Infoway.Messagebuilder.Model;
    using Ca.Infoway.Messagebuilder.Model.Pcs_cerx_v01_r04_3.Common.Coct_mt220200ca;
    using Ca.Infoway.Messagebuilder.Model.Pcs_cerx_v01_r04_3.Common.Merged;
    using Ca.Infoway.Messagebuilder.Model.Pcs_cerx_v01_r04_3.Immunization.Merged;
    using Ca.Infoway.Messagebuilder.Model.Pcs_cerx_v01_r04_3.Merged;
    using System;


    /**
     * <summary>Immunization</summary>
     * 
     * <remarks><p>approachSite must be required if not using 
     * SNOMED</p><p>Route must be required if not using 
     * SNOMED</p><p>If immunization was not refused, then refusal 
     * reason must not be specified otherwise field should be 
     * treated as populated.</p> <p>approachSite must be required 
     * if not using SNOMED</p><p>Route must be required if not 
     * using SNOMED</p><p>If immunization was not refused, then 
     * refusal reason must not be specified otherwise field should 
     * be treated as populated.</p> <p>approachSite must be 
     * required if not using SNOMED</p><p>Route must be required if 
     * not using SNOMED</p><p>If immunization was not refused, then 
     * refusal reason must not be specified otherwise field should 
     * be treated as populated.</p> <p>Represents a single 
     * immunization occurrence for a particular patient</p> 
     * <p>Allows capturing a patient's immunization profile</p></remarks>
     */
    [Hl7PartTypeMappingAttribute(new string[] {"POIZ_MT030050CA.Immunization"})]
    public class Immunization : MessagePartBean {

        private CD code;
        private BL negationInd;
        private TS effectiveTime;
        private CV confidentialityCode;
        private CV reasonCode;
        private CV routeCode;
        private CV approachSiteCode;
        private PQ doseQuantity;
        private Ca.Infoway.Messagebuilder.Model.Pcs_cerx_v01_r04_3.Common.Merged.Patient subjectPatient;
        private Ca.Infoway.Messagebuilder.Model.Pcs_cerx_v01_r04_3.Common.Coct_mt220200ca.DrugProduct consumableMedication;
        private Ca.Infoway.Messagebuilder.Model.Pcs_cerx_v01_r04_3.Immunization.Poiz_mt030050ca.InformantionSourceRole informantInformantionSourceRole;
        private Ca.Infoway.Messagebuilder.Model.Pcs_cerx_v01_r04_3.Immunization.Merged.PartOf inFulfillmentOf;
        private Ca.Infoway.Messagebuilder.Model.Pcs_cerx_v01_r04_3.Merged.Comment subjectOfAnnotation;
        private BL causeAdverseReactionObservationEvent;

        public Immunization() {
            this.code = new CDImpl();
            this.negationInd = new BLImpl();
            this.effectiveTime = new TSImpl();
            this.confidentialityCode = new CVImpl();
            this.reasonCode = new CVImpl();
            this.routeCode = new CVImpl();
            this.approachSiteCode = new CVImpl();
            this.doseQuantity = new PQImpl();
            this.causeAdverseReactionObservationEvent = new BLImpl(false);
        }
        /**
         * <summary>Immunization Type</summary>
         * 
         * <remarks><p>Indicates what type of administration is being 
         * performed.</p> <p>Indicates that the type of administration 
         * is an administration, and for SNOMED, also indicates the 
         * specific type of administration. Thus the attribute is 
         * mandatory. The datatype is CD to allow for SNOMED 
         * post-coordination.</p></remarks>
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
         * indicated.</p> <p>NotImmunizedFlag</p><p>CompletionStstus 
         * (true = Not administered)</p> 
         * <p>NotImmunizedFlag</p><p>CompletionStstus (true = Not 
         * administered)</p> <p>Tracking failures to be immunized is 
         * also important in immunization reporting. This flag must 
         * always be known and is always mandatory.</p></remarks>
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
         * patient.</p> <p>DateOfVaccination</p> <p>Important 
         * information for establishing the validity of the 
         * immunization records, and therefore mandatory. Also used in 
         * the scheduling of subsequent immunizations.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"effectiveTime"})]
        public PlatformDate EffectiveTime {
            get { return this.effectiveTime.Value; }
            set { this.effectiveTime.Value = value; }
        }

        /**
         * <summary>D:Immunization Masking Indicator</summary>
         * 
         * <remarks><p>Denotes access restriction placed on the 
         * immunization record. Methods for accessing masked 
         * immunization records will be governed by each jurisdiction 
         * (e.g. court orders, shared secret/consent, etc.).</p><p>The 
         * default is 'NORMAL'.</p> <p>Denotes access restriction 
         * placed on the immunization record. Methods for accessing 
         * masked immunization records will be governed by each 
         * jurisdiction (e.g. court orders, shared secret/consent, 
         * etc.).</p><p>The default is 'NORMAL'.</p> <p>Provides 
         * support for additional confidentiality constraint to reflect 
         * the wishes of the patient.</p><p>The attribute is optional 
         * because not all systems will support masking.</p> 
         * <p>Provides support for additional confidentiality 
         * constraint to reflect the wishes of the patient.</p><p>The 
         * attribute is optional because not all systems will support 
         * masking.</p></remarks>
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
         * etc</p> <p>CompletionStatus (Refused)</p> <p>Useful 
         * information for planning future immunization encounters for 
         * the patient.</p></remarks>
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
         * administered to the patient.</p> <p>RXR-1</p> <p>Ensures 
         * consistency in description of routes.</p><p>Attribute is 
         * marked &quot;optional&quot; to allow for use of 
         * pre-coordinated SNOMED Codes.</p> <p>Ensures consistency in 
         * description of routes.</p><p>Attribute is marked 
         * &quot;optional&quot; to allow for use of pre-coordinated 
         * SNOMED Codes.</p></remarks>
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
         * immunization was administered.</p><p>This is also referred 
         * to as the anatomical site of vaccination.</p> <p>A coded 
         * value denoting the body area where the immunization was 
         * administered.</p><p>This is also referred to as the 
         * anatomical site of vaccination.</p> <p>RXR.2</p> <p>Some 
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
        public Ca.Infoway.Messagebuilder.Model.Pcs_cerx_v01_r04_3.Common.Merged.Patient SubjectPatient {
            get { return this.subjectPatient; }
            set { this.subjectPatient = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"consumable/medication"})]
        public Ca.Infoway.Messagebuilder.Model.Pcs_cerx_v01_r04_3.Common.Coct_mt220200ca.DrugProduct ConsumableMedication {
            get { return this.consumableMedication; }
            set { this.consumableMedication = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"informant/informantionSourceRole"})]
        public Ca.Infoway.Messagebuilder.Model.Pcs_cerx_v01_r04_3.Immunization.Poiz_mt030050ca.InformantionSourceRole InformantInformantionSourceRole {
            get { return this.informantInformantionSourceRole; }
            set { this.informantInformantionSourceRole = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"inFulfillmentOf"})]
        public Ca.Infoway.Messagebuilder.Model.Pcs_cerx_v01_r04_3.Immunization.Merged.PartOf InFulfillmentOf {
            get { return this.inFulfillmentOf; }
            set { this.inFulfillmentOf = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"subjectOf/annotation"})]
        public Ca.Infoway.Messagebuilder.Model.Pcs_cerx_v01_r04_3.Merged.Comment SubjectOfAnnotation {
            get { return this.subjectOfAnnotation; }
            set { this.subjectOfAnnotation = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"cause/adverseReactionObservationEvent"})]
        public bool? CauseAdverseReactionObservationEvent {
            get { return this.causeAdverseReactionObservationEvent.Value; }
            set { this.causeAdverseReactionObservationEvent.Value = value; }
        }

    }

}