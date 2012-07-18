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
 * Last modified: $LastChangedDate: 2012-02-16 11:10:32 -0500 (Thu, 16 Feb 2012) $
 * Revision:      $LastChangedRevision: 5509 $
 */
/* This class was auto-generated by the message builder generator tools. */
namespace Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r02.Common.Coct_mt120600ca {
    using Ca.Infoway.Messagebuilder.Annotation;
    using Ca.Infoway.Messagebuilder.Datatype;
    using Ca.Infoway.Messagebuilder.Datatype.Impl;
    using Ca.Infoway.Messagebuilder.Model;
    using Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r02.Common.Coct_mt910108ca;
    using Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r02.Common.Coct_mt911108ca;
    using Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r02.Common.Merged;
    using Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r02.Merged;
    using System;


    /**
     * <summary>Notes</summary>
     * 
     * <remarks><p>Identified-confirmable is used on requests 
     * Identified-information is used on responses</p> <p>This is a 
     * list of comments made about the record by providers. 
     * Information captured here includes the provider making the 
     * comments; and excludes information that would render the 
     * record invalid. This information will only be seen when 
     * another provider reviews the record. Urgent or targeted 
     * messages should be sent using a different mechanism (e.g. 
     * phone).</p> <p>Public Health requires all clinical notes to 
     * be 'verified' by a responsible party if not created by 
     * physician in charge. This model conveys the correct 
     * semantics, but is inconsistent with other uses of 
     * &quot;author&quot; participation in POIZ models. Any changes 
     * here will have to be reconciled with other projects using 
     * this same cmet.</p> <p>Allows various Providers to attach 
     * comments to an existing record, and thus improving 
     * cross-provider communications.</p></remarks>
     */
    [Hl7PartTypeMappingAttribute(new string[] {"COCT_MT120600CA.Annotation"})]
    public class Notes : MessagePartBean {

        private ST text;
        private TS authorTime;
        private Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r02.Common.Coct_mt120600ca.IAssignedPerson authorAssignedPerson;

        public Notes() {
            this.text = new STImpl();
            this.authorTime = new TSImpl();
        }
        /**
         * <summary>B: Note Text</summary>
         * 
         * <remarks><p>Free text comments. Additional textual 
         * iinformation entered about an object.</p> <p>Allows a 
         * provider to attach comments to objects for communication. 
         * This attribute is mandatory because there's no point in 
         * having a note class unless there's actually content in the 
         * note.</p><p>Language is supported to allow grouping or 
         * filtering comments based on language</p> <p>Allows a 
         * provider to attach comments to objects for communication. 
         * This attribute is mandatory because there's no point in 
         * having a note class unless there's actually content in the 
         * note.</p><p>Language is supported to allow grouping or 
         * filtering comments based on language</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"text"})]
        public String Text {
            get { return this.text.Value; }
            set { this.text.Value = value; }
        }

        /**
         * <summary>A: Note Timestamp</summary>
         * 
         * <remarks><p>The date and time at which the note was 
         * posted.</p> <p>Identifies timing of the annotation for 
         * sorting and for audit purposes.</p><p>This attribute is 
         * mandatory because the time of creation of the annotation 
         * will always be known.</p> <p>Identifies timing of the 
         * annotation for sorting and for audit purposes.</p><p>This 
         * attribute is mandatory because the time of creation of the 
         * annotation will always be known.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"author/time"})]
        public PlatformDate AuthorTime {
            get { return this.authorTime.Value; }
            set { this.authorTime.Value = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"author/assignedPerson"})]
        public Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r02.Common.Coct_mt120600ca.IAssignedPerson AuthorAssignedPerson {
            get { return this.authorAssignedPerson; }
            set { this.authorAssignedPerson = value; }
        }

        public Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r02.Common.Merged.HealthcareWorker AuthorAssignedPersonAsAssignedEntity1 {
            get { return this.authorAssignedPerson is Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r02.Common.Merged.HealthcareWorker ? (Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r02.Common.Merged.HealthcareWorker) this.authorAssignedPerson : (Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r02.Common.Merged.HealthcareWorker) null; }
        }
        public bool HasAuthorAssignedPersonAsAssignedEntity1() {
            return (this.authorAssignedPerson is Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r02.Common.Merged.HealthcareWorker);
        }

        public Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r02.Common.Merged.HealthcareOrganization AuthorAssignedPersonAsAssignedEntity2 {
            get { return this.authorAssignedPerson is Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r02.Common.Merged.HealthcareOrganization ? (Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r02.Common.Merged.HealthcareOrganization) this.authorAssignedPerson : (Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r02.Common.Merged.HealthcareOrganization) null; }
        }
        public bool HasAuthorAssignedPersonAsAssignedEntity2() {
            return (this.authorAssignedPerson is Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r02.Common.Merged.HealthcareOrganization);
        }

        public Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r02.Merged.RelatedPerson AuthorAssignedPersonAsPersonalRelationship1 {
            get { return this.authorAssignedPerson is Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r02.Merged.RelatedPerson ? (Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r02.Merged.RelatedPerson) this.authorAssignedPerson : (Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r02.Merged.RelatedPerson) null; }
        }
        public bool HasAuthorAssignedPersonAsPersonalRelationship1() {
            return (this.authorAssignedPerson is Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r02.Merged.RelatedPerson);
        }

        public Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r02.Common.Merged.IActingPerson AuthorAssignedPersonAsActingPerson1 {
            get { return this.authorAssignedPerson is Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r02.Common.Merged.IActingPerson ? (Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r02.Common.Merged.IActingPerson) this.authorAssignedPerson : (Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r02.Common.Merged.IActingPerson) null; }
        }
        public bool HasAuthorAssignedPersonAsActingPerson1() {
            return (this.authorAssignedPerson is Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r02.Common.Merged.IActingPerson);
        }

        public Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r02.Common.Merged.HealthcareWorker AuthorAssignedPersonAsAssignedEntity3 {
            get { return this.authorAssignedPerson is Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r02.Common.Merged.HealthcareWorker ? (Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r02.Common.Merged.HealthcareWorker) this.authorAssignedPerson : (Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r02.Common.Merged.HealthcareWorker) null; }
        }
        public bool HasAuthorAssignedPersonAsAssignedEntity3() {
            return (this.authorAssignedPerson is Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r02.Common.Merged.HealthcareWorker);
        }

        public Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r02.Common.Merged.HealthcareOrganization AuthorAssignedPersonAsAssignedEntity4 {
            get { return this.authorAssignedPerson is Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r02.Common.Merged.HealthcareOrganization ? (Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r02.Common.Merged.HealthcareOrganization) this.authorAssignedPerson : (Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r02.Common.Merged.HealthcareOrganization) null; }
        }
        public bool HasAuthorAssignedPersonAsAssignedEntity4() {
            return (this.authorAssignedPerson is Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r02.Common.Merged.HealthcareOrganization);
        }

        public Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r02.Common.Coct_mt910108ca.RelatedPerson AuthorAssignedPersonAsPersonalRelationship2 {
            get { return this.authorAssignedPerson is Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r02.Common.Coct_mt910108ca.RelatedPerson ? (Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r02.Common.Coct_mt910108ca.RelatedPerson) this.authorAssignedPerson : (Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r02.Common.Coct_mt910108ca.RelatedPerson) null; }
        }
        public bool HasAuthorAssignedPersonAsPersonalRelationship2() {
            return (this.authorAssignedPerson is Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r02.Common.Coct_mt910108ca.RelatedPerson);
        }

        public Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r02.Common.Coct_mt911108ca.IActingPerson AuthorAssignedPersonAsActingPerson2 {
            get { return this.authorAssignedPerson is Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r02.Common.Coct_mt911108ca.IActingPerson ? (Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r02.Common.Coct_mt911108ca.IActingPerson) this.authorAssignedPerson : (Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r02.Common.Coct_mt911108ca.IActingPerson) null; }
        }
        public bool HasAuthorAssignedPersonAsActingPerson2() {
            return (this.authorAssignedPerson is Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r02.Common.Coct_mt911108ca.IActingPerson);
        }

        public Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r02.Merged.RelatedPerson AuthorAssignedPersonAsPersonalRelationship4 {
            get { return this.authorAssignedPerson is Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r02.Merged.RelatedPerson ? (Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r02.Merged.RelatedPerson) this.authorAssignedPerson : (Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r02.Merged.RelatedPerson) null; }
        }
        public bool HasAuthorAssignedPersonAsPersonalRelationship4() {
            return (this.authorAssignedPerson is Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r02.Merged.RelatedPerson);
        }

    }

}