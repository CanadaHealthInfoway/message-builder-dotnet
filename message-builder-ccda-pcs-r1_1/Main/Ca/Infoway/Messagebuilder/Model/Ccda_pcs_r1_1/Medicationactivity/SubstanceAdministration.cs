/**
 * Copyright 2013 Canada Health Infoway, Inc.
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
 * Author:        $LastChangedBy: gng $
 * Last modified: $LastChangedDate: 2015-11-19 18:20:12 -0500 (Fri, 30 Jan 2015) $
 * Revision:      $LastChangedRevision: 9755 $
 */


/* This class was auto-generated by the message builder generator tools. */
namespace Ca.Infoway.Messagebuilder.Model.Ccda_pcs_r1_1.Medicationactivity {
    using Ca.Infoway.Messagebuilder;
    using Ca.Infoway.Messagebuilder.Annotation;
    using Ca.Infoway.Messagebuilder.Datatype;
    using Ca.Infoway.Messagebuilder.Datatype.Impl;
    using Ca.Infoway.Messagebuilder.Datatype.Lang;
    using Ca.Infoway.Messagebuilder.Model;
    using Ca.Infoway.Messagebuilder.Model.Ccda_pcs_r1_1.Basemodel;
    using Ca.Infoway.Messagebuilder.Model.Ccda_pcs_r1_1.Domainvalue;
    using Ca.Infoway.Messagebuilder.Model.Ccda_pcs_r1_1.Merged;
    using System;
    using System.Collections.Generic;


    [Hl7PartTypeMappingAttribute(new string[] {"MedicationActivity.SubstanceAdministration"})]
    public class SubstanceAdministration : MessagePartBean {

        private CS moodCode;
        private BL negationInd;
        private II typeId;
        private LIST<II, Identifier> templateId;
        private LIST<II, Identifier> id;
        private CD code;
        private ED<EncapsulatedData> text;
        private CS statusCode;
        private LIST<SXCMTSCDAR1, MbDate> effectiveTime;
        private CE priorityCode;
        private IVL<INT, Interval<int?>> repeatNumber;
        private CE routeCode;
        private CD approachSiteCode;
        private IVL<PQ, Interval<PhysicalQuantity>> doseQuantity;
        private IVL<PQ, Interval<PhysicalQuantity>> rateQuantity;
        private RTO<PhysicalQuantity, PhysicalQuantity> maxDoseQuantity;
        private CE administrationUnitCode;
        private Ca.Infoway.Messagebuilder.Model.Ccda_pcs_r1_1.Basemodel.Subject subject;
        private IList<Ca.Infoway.Messagebuilder.Model.Ccda_pcs_r1_1.Merged.Specimen> specimen;
        private Ca.Infoway.Messagebuilder.Model.Ccda_pcs_r1_1.Medicationactivity.Consumable consumable;
        private Ca.Infoway.Messagebuilder.Model.Ccda_pcs_r1_1.Merged.Performer2_1 performer;
        private IList<Ca.Infoway.Messagebuilder.Model.Ccda_pcs_r1_1.Merged.Author_1> author;
        private IList<Ca.Infoway.Messagebuilder.Model.Ccda_pcs_r1_1.Merged.Informant12> informant;
        private IList<Ca.Infoway.Messagebuilder.Model.Ccda_pcs_r1_1.Medicationactivity.IParticipant2Choice> participant;
        private IList<Ca.Infoway.Messagebuilder.Model.Ccda_pcs_r1_1.Medicationactivity.IEntryRelationshipChoice> entryRelationship;
        private IList<Ca.Infoway.Messagebuilder.Model.Ccda_pcs_r1_1.Basemodel.Reference> reference;
        private IList<Ca.Infoway.Messagebuilder.Model.Ccda_pcs_r1_1.Merged.IPreconditionChoice> precondition;

        public SubstanceAdministration() {
            this.moodCode = new CSImpl();
            this.negationInd = new BLImpl();
            this.typeId = new IIImpl();
            this.templateId = new LISTImpl<II, Identifier>(typeof(IIImpl));
            this.id = new LISTImpl<II, Identifier>(typeof(IIImpl));
            this.code = new CDImpl();
            this.text = new EDImpl<EncapsulatedData>();
            this.statusCode = new CSImpl();
            this.effectiveTime = new LISTImpl<SXCMTSCDAR1, MbDate>(typeof(SXCMTSCDAR1Impl));
            this.priorityCode = new CEImpl();
            this.repeatNumber = new IVLImpl<INT, Interval<int?>>();
            this.routeCode = new CEImpl();
            this.approachSiteCode = new CDImpl();
            this.doseQuantity = new IVLImpl<PQ, Interval<PhysicalQuantity>>();
            this.rateQuantity = new IVLImpl<PQ, Interval<PhysicalQuantity>>();
            this.maxDoseQuantity = new RTOImpl<PhysicalQuantity, PhysicalQuantity>();
            this.administrationUnitCode = new CEImpl();
            this.specimen = new List<Ca.Infoway.Messagebuilder.Model.Ccda_pcs_r1_1.Merged.Specimen>();
            this.author = new List<Ca.Infoway.Messagebuilder.Model.Ccda_pcs_r1_1.Merged.Author_1>();
            this.informant = new List<Ca.Infoway.Messagebuilder.Model.Ccda_pcs_r1_1.Merged.Informant12>();
            this.participant = new List<Ca.Infoway.Messagebuilder.Model.Ccda_pcs_r1_1.Medicationactivity.IParticipant2Choice>();
            this.entryRelationship = new List<Ca.Infoway.Messagebuilder.Model.Ccda_pcs_r1_1.Medicationactivity.IEntryRelationshipChoice>();
            this.reference = new List<Ca.Infoway.Messagebuilder.Model.Ccda_pcs_r1_1.Basemodel.Reference>();
            this.precondition = new List<Ca.Infoway.Messagebuilder.Model.Ccda_pcs_r1_1.Merged.IPreconditionChoice>();
        }
        /**
         * <summary>Relationship: 
         * MedicationActivity.SubstanceAdministration.moodCode</summary>
         * 
         * <remarks>Conformance/Cardinality: MANDATORY (1)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"moodCode"})]
        public Ca.Infoway.Messagebuilder.Model.Ccda_pcs_r1_1.Domainvalue.EvnIntMoodCode MoodCode {
            get { return (Ca.Infoway.Messagebuilder.Model.Ccda_pcs_r1_1.Domainvalue.EvnIntMoodCode) this.moodCode.Value; }
            set { this.moodCode.Value = value; }
        }

        /**
         * <summary>Relationship: 
         * MedicationActivity.SubstanceAdministration.negationInd</summary>
         * 
         * <remarks>Conformance/Cardinality: OPTIONAL (0-1)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"negationInd"})]
        public bool? NegationInd {
            get { return this.negationInd.Value; }
            set { this.negationInd.Value = value; }
        }

        /**
         * <summary>Relationship: 
         * MedicationActivity.SubstanceAdministration.typeId</summary>
         * 
         * <remarks>Conformance/Cardinality: OPTIONAL (0-1)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"typeId"})]
        public Identifier TypeId {
            get { return this.typeId.Value; }
            set { this.typeId.Value = value; }
        }

        /**
         * <summary>Relationship: 
         * MedicationActivity.SubstanceAdministration.templateId</summary>
         * 
         * <remarks>Conformance/Cardinality: MANDATORY (*)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"templateId"})]
        public IList<Identifier> TemplateId {
            get { return this.templateId.RawList(); }
        }

        /**
         * <summary>Relationship: 
         * MedicationActivity.SubstanceAdministration.id</summary>
         * 
         * <remarks>Conformance/Cardinality: POPULATED (*)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"id"})]
        public IList<Identifier> Id {
            get { return this.id.RawList(); }
        }

        /**
         * <summary>Relationship: 
         * MedicationActivity.SubstanceAdministration.code</summary>
         * 
         * <remarks>Conformance/Cardinality: OPTIONAL (0-1)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"code"})]
        public Code Code {
            get { return (Code) this.code.Value; }
            set { this.code.Value = value; }
        }

        /**
         * <summary>Relationship: 
         * MedicationActivity.SubstanceAdministration.text</summary>
         * 
         * <remarks>Conformance/Cardinality: OPTIONAL (0-1)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"text"})]
        public EncapsulatedData Text {
            get { return this.text.Value; }
            set { this.text.Value = value; }
        }

        /**
         * <summary>Relationship: 
         * MedicationActivity.SubstanceAdministration.statusCode</summary>
         * 
         * <remarks>Conformance/Cardinality: POPULATED (1)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"statusCode"})]
        public Code StatusCode {
            get { return (Code) this.statusCode.Value; }
            set { this.statusCode.Value = value; }
        }

        /**
         * <summary>Relationship: 
         * MedicationActivity.SubstanceAdministration.effectiveTime</summary>
         * 
         * <remarks>Conformance/Cardinality: POPULATED (*)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"effectiveTime"})]
        public IList<MbDate> EffectiveTime {
            get { return this.effectiveTime.RawList(); }
        }

        /**
         * <summary>Relationship: 
         * MedicationActivity.SubstanceAdministration.priorityCode</summary>
         * 
         * <remarks>Conformance/Cardinality: OPTIONAL (0-1)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"priorityCode"})]
        public Code PriorityCode {
            get { return (Code) this.priorityCode.Value; }
            set { this.priorityCode.Value = value; }
        }

        /**
         * <summary>Relationship: 
         * MedicationActivity.SubstanceAdministration.repeatNumber</summary>
         * 
         * <remarks>Conformance/Cardinality: OPTIONAL (0-1)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"repeatNumber"})]
        public Interval<int?> RepeatNumber {
            get { return this.repeatNumber.Value; }
            set { this.repeatNumber.Value = value; }
        }

        /**
         * <summary>Relationship: 
         * MedicationActivity.SubstanceAdministration.routeCode</summary>
         * 
         * <remarks>Conformance/Cardinality: OPTIONAL (0-1)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"routeCode"})]
        public Ca.Infoway.Messagebuilder.Model.Ccda_pcs_r1_1.Domainvalue.MedicationRoute RouteCode {
            get { return (Ca.Infoway.Messagebuilder.Model.Ccda_pcs_r1_1.Domainvalue.MedicationRoute) this.routeCode.Value; }
            set { this.routeCode.Value = value; }
        }

        /**
         * <summary>Relationship: 
         * MedicationActivity.SubstanceAdministration.approachSiteCode</summary>
         * 
         * <remarks>Conformance/Cardinality: OPTIONAL (0-1)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"approachSiteCode"})]
        public Ca.Infoway.Messagebuilder.Model.Ccda_pcs_r1_1.Domainvalue.BodySite ApproachSiteCode {
            get { return (Ca.Infoway.Messagebuilder.Model.Ccda_pcs_r1_1.Domainvalue.BodySite) this.approachSiteCode.Value; }
            set { this.approachSiteCode.Value = value; }
        }

        /**
         * <summary>Relationship: 
         * MedicationActivity.SubstanceAdministration.doseQuantity</summary>
         * 
         * <remarks>Conformance/Cardinality: OPTIONAL (0-1)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"doseQuantity"})]
        public Interval<PhysicalQuantity> DoseQuantity {
            get { return this.doseQuantity.Value; }
            set { this.doseQuantity.Value = value; }
        }

        /**
         * <summary>Relationship: 
         * MedicationActivity.SubstanceAdministration.rateQuantity</summary>
         * 
         * <remarks>Conformance/Cardinality: OPTIONAL (0-1)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"rateQuantity"})]
        public Interval<PhysicalQuantity> RateQuantity {
            get { return this.rateQuantity.Value; }
            set { this.rateQuantity.Value = value; }
        }

        /**
         * <summary>Relationship: 
         * MedicationActivity.SubstanceAdministration.maxDoseQuantity</summary>
         * 
         * <remarks>Conformance/Cardinality: OPTIONAL (0-1)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"maxDoseQuantity"})]
        public Ratio<PhysicalQuantity, PhysicalQuantity> MaxDoseQuantity {
            get { return this.maxDoseQuantity.Value; }
            set { this.maxDoseQuantity.Value = value; }
        }

        /**
         * <summary>Relationship: 
         * MedicationActivity.SubstanceAdministration.administrationUnitCode</summary>
         * 
         * <remarks>Conformance/Cardinality: OPTIONAL (0-1)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"administrationUnitCode"})]
        public Ca.Infoway.Messagebuilder.Model.Ccda_pcs_r1_1.Domainvalue.MedicationProductForm AdministrationUnitCode {
            get { return (Ca.Infoway.Messagebuilder.Model.Ccda_pcs_r1_1.Domainvalue.MedicationProductForm) this.administrationUnitCode.Value; }
            set { this.administrationUnitCode.Value = value; }
        }

        /**
         * <summary>Relationship: 
         * MedicationActivity.SubstanceAdministration.subject</summary>
         * 
         * <remarks>Conformance/Cardinality: OPTIONAL (0-1)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"subject"})]
        public Ca.Infoway.Messagebuilder.Model.Ccda_pcs_r1_1.Basemodel.Subject Subject {
            get { return this.subject; }
            set { this.subject = value; }
        }

        /**
         * <summary>Relationship: 
         * MedicationActivity.SubstanceAdministration.specimen</summary>
         * 
         * <remarks>Conformance/Cardinality: OPTIONAL (0-*)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"specimen"})]
        public IList<Ca.Infoway.Messagebuilder.Model.Ccda_pcs_r1_1.Merged.Specimen> Specimen {
            get { return this.specimen; }
        }

        /**
         * <summary>Relationship: 
         * MedicationActivity.SubstanceAdministration.consumable</summary>
         * 
         * <remarks>Conformance/Cardinality: POPULATED (1)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"consumable"})]
        public Ca.Infoway.Messagebuilder.Model.Ccda_pcs_r1_1.Medicationactivity.Consumable Consumable {
            get { return this.consumable; }
            set { this.consumable = value; }
        }

        /**
         * <summary>Relationship: 
         * MedicationActivity.SubstanceAdministration.performer</summary>
         * 
         * <remarks>Conformance/Cardinality: OPTIONAL (0-1)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"performer"})]
        public Ca.Infoway.Messagebuilder.Model.Ccda_pcs_r1_1.Merged.Performer2_1 Performer {
            get { return this.performer; }
            set { this.performer = value; }
        }

        /**
         * <summary>Relationship: 
         * MedicationActivity.SubstanceAdministration.author</summary>
         * 
         * <remarks>Conformance/Cardinality: OPTIONAL (0-*)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"author"})]
        public IList<Ca.Infoway.Messagebuilder.Model.Ccda_pcs_r1_1.Merged.Author_1> Author {
            get { return this.author; }
        }

        /**
         * <summary>Relationship: 
         * MedicationActivity.SubstanceAdministration.informant</summary>
         * 
         * <remarks>Conformance/Cardinality: OPTIONAL (0-*)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"informant"})]
        public IList<Ca.Infoway.Messagebuilder.Model.Ccda_pcs_r1_1.Merged.Informant12> Informant {
            get { return this.informant; }
        }

        /**
         * <summary>Relationship: 
         * MedicationActivity.SubstanceAdministration.participant</summary>
         * 
         * <remarks>Conformance/Cardinality: OPTIONAL (0-*)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"participant"})]
        public IList<Ca.Infoway.Messagebuilder.Model.Ccda_pcs_r1_1.Medicationactivity.IParticipant2Choice> Participant {
            get { return this.participant; }
        }

        /**
         * <summary>Relationship: 
         * MedicationActivity.SubstanceAdministration.entryRelationship</summary>
         * 
         * <remarks>Conformance/Cardinality: OPTIONAL (0-*)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"entryRelationship"})]
        public IList<Ca.Infoway.Messagebuilder.Model.Ccda_pcs_r1_1.Medicationactivity.IEntryRelationshipChoice> EntryRelationship {
            get { return this.entryRelationship; }
        }

        /**
         * <summary>Relationship: 
         * MedicationActivity.SubstanceAdministration.reference</summary>
         * 
         * <remarks>Conformance/Cardinality: OPTIONAL (0-*)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"reference"})]
        public IList<Ca.Infoway.Messagebuilder.Model.Ccda_pcs_r1_1.Basemodel.Reference> Reference {
            get { return this.reference; }
        }

        /**
         * <summary>Relationship: 
         * MedicationActivity.SubstanceAdministration.precondition</summary>
         * 
         * <remarks>Conformance/Cardinality: OPTIONAL (0-*)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"precondition"})]
        public IList<Ca.Infoway.Messagebuilder.Model.Ccda_pcs_r1_1.Merged.IPreconditionChoice> Precondition {
            get { return this.precondition; }
        }

    }

}