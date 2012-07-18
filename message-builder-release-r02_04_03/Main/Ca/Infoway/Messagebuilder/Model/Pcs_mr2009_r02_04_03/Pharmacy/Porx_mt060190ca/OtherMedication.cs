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
namespace Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Pharmacy.Porx_mt060190ca {
    using Ca.Infoway.Messagebuilder;
    using Ca.Infoway.Messagebuilder.Annotation;
    using Ca.Infoway.Messagebuilder.Datatype;
    using Ca.Infoway.Messagebuilder.Datatype.Impl;
    using Ca.Infoway.Messagebuilder.Datatype.Lang;
    using Ca.Infoway.Messagebuilder.Domainvalue;
    using Ca.Infoway.Messagebuilder.Model;
    using Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Common.Coct_mt220110ca;
    using Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Common.Merged;
    using Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Merged;
    using System;
    using System.Collections.Generic;


    /**
     * <summary>Other Medication</summary>
     * 
     * <remarks><p>A record of a medication the patient is believed 
     * to be taking, but for which an electronic order does not 
     * exist. &quot;Other medications&quot; include any drug 
     * product deemed relevant to the patient's drug profile, but 
     * which was not specifically ordered by a prescriber in a 
     * DIS-enabled jurisdiction. Examples include over-the counter 
     * medications that were not specifically ordered, herbal 
     * remedies, and recreational drugs. Prescription drugs that 
     * the patient may be taking but was not prescribed on the EHR 
     * (e.g. institutionally administered or out-of-jurisdiction 
     * prescriptions) will also be recorded here.</p> <p>Necessary 
     * component of a person's overall medication profile. Allows 
     * DUR checking against a more complete drug profile.</p></remarks>
     */
    [Hl7PartTypeMappingAttribute(new string[] {"PORX_MT060190CA.OtherMedication"})]
    public class OtherMedication : MessagePartBean, Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Pharmacy.Merged.IMedicationRecord {

        private SET<II, Identifier> id;
        private CD code;
        private CS statusCode;
        private IVL<TS, Interval<PlatformDate>> effectiveTime;
        private SET<CV, Code> confidentialityCode;
        private CV routeCode;
        private Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Common.Coct_mt220110ca.DrugProduct consumableMedication;
        private Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Common.Merged.HealthcareWorker responsiblePartyAssignedEntity;
        private Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Merged.RefusedBy author;
        private Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Merged.OccurredAt location;
        private BL subjectOf1DetectedIssueIndicator;
        private BL subjectOf2AnnotationIndicator;
        private IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Merged.CareCompositions> componentOfPatientCareProvisionEvent;

        public OtherMedication() {
            this.id = new SETImpl<II, Identifier>(typeof(IIImpl));
            this.code = new CDImpl();
            this.statusCode = new CSImpl();
            this.effectiveTime = new IVLImpl<TS, Interval<PlatformDate>>();
            this.confidentialityCode = new SETImpl<CV, Code>(typeof(CVImpl));
            this.routeCode = new CVImpl();
            this.subjectOf1DetectedIssueIndicator = new BLImpl(false);
            this.subjectOf2AnnotationIndicator = new BLImpl(false);
            this.componentOfPatientCareProvisionEvent = new List<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Merged.CareCompositions>();
        }
        /**
         * <summary>A:Other Medication Record Number</summary>
         * 
         * <remarks><p>This is an identifier assigned to a unique 
         * instance of an other medication record.</p> <p>Allows for 
         * the unique referencing of a specific other medication 
         * record. Thus the mandatory requirement. .</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"id"})]
        public ICollection<Identifier> Id {
            get { return this.id.RawSet(); }
        }

        /**
         * <summary>Other Medication Type</summary>
         * 
         * <remarks><p>Must be 'DRUG' unless using SNOMED</p> 
         * <p>Indicates that the record is a drug administration rather 
         * than an immunization or other type of administration. For 
         * SNOMED, may also include route, drug and other 
         * information.</p> <p>Needed to convey the meaning of this 
         * class and is therefore mandatory.</p><p>The element allows 
         * 'CD' to provide support for SNOMED.</p> <p>Needed to convey 
         * the meaning of this class and is therefore 
         * mandatory.</p><p>The element allows 'CD' to provide support 
         * for SNOMED.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"code"})]
        public Code Code {
            get { return (Code) this.code.Value; }
            set { this.code.Value = value; }
        }

        /**
         * <summary>B:Other Medication Status</summary>
         * 
         * <remarks><p>Status can only be ACTIVE or COMPLETED</p> 
         * <p>Indicates the status of the other medication record 
         * created on the EHR/DIS. Valid statuses for other medication 
         * records are: ACTIVE, COMPLETE only.</p> <p>Used to determine 
         * whether the medication should be considered in performing 
         * DUR checking and therefore mandatory.</p><p>Note ------ The 
         * provider might know that the patient is not taking the 
         * medication but not necessarily when the patient stopped it. 
         * Thus the status of the medication could be set to 
         * 'COMPLETED' by the provider without necessarily setting an 
         * End Date on the medication record.</p> <p>Used to determine 
         * whether the medication should be considered in performing 
         * DUR checking and therefore mandatory.</p><p>Note ------ The 
         * provider might know that the patient is not taking the 
         * medication but not necessarily when the patient stopped it. 
         * Thus the status of the medication could be set to 
         * 'COMPLETED' by the provider without necessarily setting an 
         * End Date on the medication record.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"statusCode"})]
        public ActStatus StatusCode {
            get { return (ActStatus) this.statusCode.Value; }
            set { this.statusCode.Value = value; }
        }

        /**
         * <summary>C:Drug Active Period</summary>
         * 
         * <remarks><p>Indicates the time-period in which the patient 
         * has been taking or is expected to be taking the active 
         * medication.</p> <p>Used to indicate help determine whether 
         * the medication is currently active. Because this information 
         * won't always be available, the attribute is marked as 
         * 'populated'.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"effectiveTime"})]
        public Interval<PlatformDate> EffectiveTime {
            get { return this.effectiveTime.Value; }
            set { this.effectiveTime.Value = value; }
        }

        /**
         * <summary>D:Other Medication Masking Indicators</summary>
         * 
         * <remarks><p>Denotes access restriction place on the other 
         * medication record.</p><p>Provides support for additional 
         * confidentiality constraint, giving patients a level of 
         * control over their information.</p><p>Valid values are: 'N' 
         * (normal - denotes 'Not Masked'); 'R' (restricted - denotes 
         * 'Masked'); 'V' (very restricted - denotes very restricted 
         * access as declared by the Privacy Officer of the record 
         * holder) and 'T' (taboo - denotes 'Patient Access 
         * Restricted').</p><p>The default is 'normal' signifying 'Not 
         * Masked'.</p> <p>Denotes access restriction place on the 
         * other medication record.</p><p>Provides support for 
         * additional confidentiality constraint, giving patients a 
         * level of control over their information.</p><p>Valid values 
         * are: 'N' (normal - denotes 'Not Masked'); 'R' (restricted - 
         * denotes 'Masked'); 'V' (very restricted - denotes very 
         * restricted access as declared by the Privacy Officer of the 
         * record holder) and 'T' (taboo - denotes 'Patient Access 
         * Restricted').</p><p>The default is 'normal' signifying 'Not 
         * Masked'.</p> <p>Denotes access restriction place on the 
         * other medication record.</p><p>Provides support for 
         * additional confidentiality constraint, giving patients a 
         * level of control over their information.</p><p>Valid values 
         * are: 'N' (normal - denotes 'Not Masked'); 'R' (restricted - 
         * denotes 'Masked'); 'V' (very restricted - denotes very 
         * restricted access as declared by the Privacy Officer of the 
         * record holder) and 'T' (taboo - denotes 'Patient Access 
         * Restricted').</p><p>The default is 'normal' signifying 'Not 
         * Masked'.</p> <p>Denotes access restriction place on the 
         * other medication record.</p><p>Provides support for 
         * additional confidentiality constraint, giving patients a 
         * level of control over their information.</p><p>Valid values 
         * are: 'N' (normal - denotes 'Not Masked'); 'R' (restricted - 
         * denotes 'Masked'); 'V' (very restricted - denotes very 
         * restricted access as declared by the Privacy Officer of the 
         * record holder) and 'T' (taboo - denotes 'Patient Access 
         * Restricted').</p><p>The default is 'normal' signifying 'Not 
         * Masked'.</p> <p>Provides support for additional 
         * confidentiality constraint to reflect the wishes of the 
         * patient.</p><p>Taboo allows the provider to request 
         * restricted access to patient or their care 
         * giver.</p><p>Constraint: Cant have both normal and one of 
         * the other codes simultaneously.</p><p>The attribute is 
         * required because even if a jurisdiction doesn't support 
         * masking on the way in, it will need to need to communicate 
         * masked data returned from other jurisdictions.</p> 
         * <p>Provides support for additional confidentiality 
         * constraint to reflect the wishes of the patient.</p><p>Taboo 
         * allows the provider to request restricted access to patient 
         * or their care giver.</p><p>Constraint: Cant have both normal 
         * and one of the other codes simultaneously.</p><p>The 
         * attribute is required because even if a jurisdiction doesn't 
         * support masking on the way in, it will need to need to 
         * communicate masked data returned from other 
         * jurisdictions.</p> <p>Provides support for additional 
         * confidentiality constraint to reflect the wishes of the 
         * patient.</p><p>Taboo allows the provider to request 
         * restricted access to patient or their care 
         * giver.</p><p>Constraint: Cant have both normal and one of 
         * the other codes simultaneously.</p><p>The attribute is 
         * required because even if a jurisdiction doesn't support 
         * masking on the way in, it will need to need to communicate 
         * masked data returned from other jurisdictions.</p> 
         * <p>Provides support for additional confidentiality 
         * constraint to reflect the wishes of the patient.</p><p>Taboo 
         * allows the provider to request restricted access to patient 
         * or their care giver.</p><p>Constraint: Cant have both normal 
         * and one of the other codes simultaneously.</p><p>The 
         * attribute is required because even if a jurisdiction doesn't 
         * support masking on the way in, it will need to need to 
         * communicate masked data returned from other 
         * jurisdictions.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"confidentialityCode"})]
        public ICollection<x_BasicConfidentialityKind> ConfidentialityCode {
            get { return this.confidentialityCode.RawSet<x_BasicConfidentialityKind>(); }
        }

        /**
         * <summary>E:Route of Administration</summary>
         * 
         * <remarks><p>routeCode must not be used when code is SNOMED 
         * and is mandatory otherwise</p> <p>Ensures consistency in 
         * description of routes. Provides potential for cross-checking 
         * dosage form and route. Because this information is 
         * pre-coordinated into 'code' for SNOMED, it is marked as 
         * optional.</p> <p>Ensures consistency in description of 
         * routes. Provides potential for cross-checking dosage form 
         * and route.</p><p>Because this information can be 
         * pre-coordinated with code by SNOMED, the attribute is 
         * optional.</p> <p>Ensures consistency in description of 
         * routes. Provides potential for cross-checking dosage form 
         * and route.</p><p>Because this information can be 
         * pre-coordinated with code by SNOMED, the attribute is 
         * optional.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"routeCode"})]
        public RouteOfAdministration RouteCode {
            get { return (RouteOfAdministration) this.routeCode.Value; }
            set { this.routeCode.Value = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"consumable/medication"})]
        public Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Common.Coct_mt220110ca.DrugProduct ConsumableMedication {
            get { return this.consumableMedication; }
            set { this.consumableMedication = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"responsibleParty/assignedEntity"})]
        public Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Common.Merged.HealthcareWorker ResponsiblePartyAssignedEntity {
            get { return this.responsiblePartyAssignedEntity; }
            set { this.responsiblePartyAssignedEntity = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"author"})]
        public Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Merged.RefusedBy Author {
            get { return this.author; }
            set { this.author = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"location"})]
        public Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Merged.OccurredAt Location {
            get { return this.location; }
            set { this.location = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"subjectOf1/detectedIssueIndicator"})]
        public bool? SubjectOf1DetectedIssueIndicator {
            get { return this.subjectOf1DetectedIssueIndicator.Value; }
            set { this.subjectOf1DetectedIssueIndicator.Value = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"subjectOf2/annotationIndicator"})]
        public bool? SubjectOf2AnnotationIndicator {
            get { return this.subjectOf2AnnotationIndicator.Value; }
            set { this.subjectOf2AnnotationIndicator.Value = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"componentOf/patientCareProvisionEvent"})]
        public IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Merged.CareCompositions> ComponentOfPatientCareProvisionEvent {
            get { return this.componentOfPatientCareProvisionEvent; }
        }

    }

}