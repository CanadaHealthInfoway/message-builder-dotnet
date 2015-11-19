/**
 * Copyright 2015 Canada Health Infoway, Inc.
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
 * Last modified: $LastChangedDate: 2011-05-04 15:47:15 -0400 (Wed, 04 May 2011) $
 * Revision:      $LastChangedRevision: 2623 $
 */
/* This class was auto-generated by the message builder generator tools. */
namespace Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_05_00.Iehr.Merged {
    using Ca.Infoway.Messagebuilder.Annotation;
    using Ca.Infoway.Messagebuilder.Datatype;
    using Ca.Infoway.Messagebuilder.Datatype.Impl;
    using Ca.Infoway.Messagebuilder.Datatype.Lang;
    using Ca.Infoway.Messagebuilder.Domainvalue;
    using Ca.Infoway.Messagebuilder.Model;
    using Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_05_00.Merged;
    using System;
    using System.Collections.Generic;


    /**
     * <summary>Business Name: ClinicalObservationDocument</summary>
     * 
     * <remarks>REPC_MT230001CA.Observation: A: Clinical 
     * Observation Document <p>Provides contextual overview 
     * information for searching and filtering</p> <p>Discrete 
     * information about the observation or procedure or other 
     * report or note being written</p> 
     * REPC_MT230003CA.Observation: A: Clinical Observation 
     * Document <p>Provides contextual overview information for 
     * searching and filtering</p> <p>Discrete information about 
     * the observation or procedure or other report or note being 
     * written</p> REPC_MT230002CA.Observation: A: Clinical 
     * Observation Document <p>Provides contextual overview 
     * information for searching and filtering</p> <p>Discrete 
     * information about the observation or procedure or other 
     * report or note being written</p></remarks>
     */
    [Hl7PartTypeMappingAttribute(new string[] {"REPC_MT230001CA.Observation","REPC_MT230002CA.Observation","REPC_MT230003CA.Observation"})]
    public class ClinicalObservationDocument : MessagePartBean, Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_05_00.Iehr.Merged.IDocumentContent_3 {

        private CD code;
        private IVL<TS, Interval<PlatformDate>> effectiveTime;
        private Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_05_00.Merged.OccurredAt location;
        private Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_05_00.Iehr.Merged.Request_2 inFulfillmentOfActRequest;
        private IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_05_00.Merged.BecauseOf> reason;
        private Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_05_00.Iehr.Merged.ActEvent subjectActEvent;
        private CS statusCode;

        public ClinicalObservationDocument() {
            this.code = new CDImpl();
            this.effectiveTime = new IVLImpl<TS, Interval<PlatformDate>>();
            this.reason = new List<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_05_00.Merged.BecauseOf>();
            this.statusCode = new CSImpl();
        }
        /**
         * <summary>Business Name: ClinicalObservationDocumentType</summary>
         * 
         * <remarks>Un-merged Business Name: 
         * ClinicalObservationDocumentType Relationship: 
         * REPC_MT230001CA.Observation.code Conformance/Cardinality: 
         * MANDATORY (1) <p> <i>Clinical Observation Document Type is 
         * used for searching and for organizing Clinical Observation 
         * Document records as well as sorting them for 
         * presentation.</i> </p><p> <i>This is a key attribute for 
         * understanding the type of record and is therefore 
         * mandatory.</i> </p><p> <i>This element makes use of the CD 
         * datatype to allow for use of the SNOMED code system that in 
         * some circumstances requires the use of post-coordination. 
         * Post-coordination is only supported by the CD datatype.</i> 
         * </p> <p> <i>Identifies the type of Clinical Observation 
         * Document represented by this record.</i> </p><p>e.g. family 
         * history, environmental history, social history, etc.</p> 
         * Un-merged Business Name: ClinicalObservationDocumentType 
         * Relationship: REPC_MT230003CA.Observation.code 
         * Conformance/Cardinality: MANDATORY (1) <p>Clinical 
         * Observation Document Type is used for searching and for 
         * organizing Clinical Observation Document records as well as 
         * sorting them for presentation.</p><p>This is a key attribute 
         * for understanding the type of record and is therefore 
         * mandatory.</p><p>This element makes use of the CD datatype 
         * to allow for use of the SNOMED code system that in some 
         * circumstances requires the use of post-coordination. 
         * Post-coordination is only supported by the CD datatype.</p> 
         * <p>Identifies the type of Clinical Observation Document 
         * represented by this record.</p><p>e.g. family history, 
         * environmental history, social history, etc.</p> Un-merged 
         * Business Name: ClinicalObservationDocumentType Relationship: 
         * REPC_MT230002CA.Observation.code Conformance/Cardinality: 
         * MANDATORY (1) <p>Clinical Observation Document Type is used 
         * for searching and for organizing Clinical Observation 
         * Document records as well as sorting them for 
         * presentation.</p><p>This is a key attribute for 
         * understanding the type of record and is therefore 
         * mandatory.</p> <p>Identifies the type of Clinical 
         * Observation Document represented by this record.</p><p>e.g. 
         * family history, environmental history, social history, 
         * etc.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"code"})]
        public ClinicalReportObservationType Code {
            get { return (ClinicalReportObservationType) this.code.Value; }
            set { this.code.Value = value; }
        }

        /**
         * <summary>Business Name: ClinicalObservationDocumentTimeRange</summary>
         * 
         * <remarks>Un-merged Business Name: 
         * ClinicalObservationDocumentTimeRange Relationship: 
         * REPC_MT230001CA.Observation.effectiveTime 
         * Conformance/Cardinality: REQUIRED (1) <p> <i>Identifies the 
         * time-period of relevance to the record that is useful in 
         * filtering and organizing &quot;time-view&quot; presentations 
         * of data. Because the timing information won't always be 
         * known, this attribute is marked as 'populated'.</i> </p> 
         * <p>Indicates the period of time over which the assessment 
         * described by the clinical note applies. If the assessment 
         * applies over the entire life of the patient, only the end 
         * date (the point up to which the assessment is current) needs 
         * to be specified.</p> Un-merged Business Name: 
         * ClinicalObservationDocumentTimeRange Relationship: 
         * REPC_MT230003CA.Observation.effectiveTime 
         * Conformance/Cardinality: REQUIRED (1) <p>Identifies the 
         * time-period of relevance to the record that is useful in 
         * filtering and organizing &quot;time-view&quot; presentations 
         * of data. Because the timing information won't always be 
         * known, this attribute is marked as 'populated'.</p> 
         * <p>Indicates the period of time over which the assessment 
         * described by the clinical note applies. If the assessment 
         * applies over the entire life of the patient, only the end 
         * date (the point up to which the assessment is current) needs 
         * to be specified.</p> Un-merged Business Name: 
         * ClinicalObservationDocumentTimeRange Relationship: 
         * REPC_MT230002CA.Observation.effectiveTime 
         * Conformance/Cardinality: REQUIRED (1) <p>Identifies the 
         * time-period of relevance to the record that is useful in 
         * filtering and organizing &quot;time-view&quot; presentations 
         * of data. Because the timing information won't always be 
         * known, this attribute is marked as 'populated'.</p> 
         * <p>Indicates the period of time over which the assessment 
         * described by the clinical note applies. If the assessment 
         * applies over the entire life of the patient, only the end 
         * date (the point up to which the assessment is current) needs 
         * to be specified.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"effectiveTime"})]
        public Interval<PlatformDate> EffectiveTime {
            get { return this.effectiveTime.Value; }
            set { this.effectiveTime.Value = value; }
        }

        /**
         * <summary>Un-merged Business Name: (no business name 
         * specified)</summary>
         * 
         * <remarks>Relationship: REPC_MT230001CA.Observation.location 
         * Conformance/Cardinality: REQUIRED (0-1) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * REPC_MT230003CA.DocumentContent.location 
         * Conformance/Cardinality: REQUIRED (0-1) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * REPC_MT230002CA.DocumentContent.location 
         * Conformance/Cardinality: REQUIRED (0-1)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"location"})]
        public Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_05_00.Merged.OccurredAt Location {
            get { return this.location; }
            set { this.location = value; }
        }

        /**
         * <summary>Un-merged Business Name: (no business name 
         * specified)</summary>
         * 
         * <remarks>Relationship: 
         * REPC_MT230001CA.InFulfillmentOf3.actRequest 
         * Conformance/Cardinality: REQUIRED (1) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * REPC_MT230003CA.InFulfillmentOf3.actRequest 
         * Conformance/Cardinality: REQUIRED (1) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * REPC_MT230002CA.InFulfillmentOf3.actRequest 
         * Conformance/Cardinality: REQUIRED (1)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"inFulfillmentOf/actRequest"})]
        public Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_05_00.Iehr.Merged.Request_2 InFulfillmentOfActRequest {
            get { return this.inFulfillmentOfActRequest; }
            set { this.inFulfillmentOfActRequest = value; }
        }

        /**
         * <summary>Un-merged Business Name: (no business name 
         * specified)</summary>
         * 
         * <remarks>Relationship: 
         * REPC_MT230001CA.DocumentContent.reason 
         * Conformance/Cardinality: REQUIRED (0-5) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * REPC_MT230003CA.DocumentContent.reason 
         * Conformance/Cardinality: REQUIRED (0-5) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * REPC_MT230002CA.DocumentContent.reason 
         * Conformance/Cardinality: REQUIRED (0-5)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"reason"})]
        public IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_05_00.Merged.BecauseOf> Reason {
            get { return this.reason; }
        }

        /**
         * <summary>Un-merged Business Name: (no business name 
         * specified)</summary>
         * 
         * <remarks>Relationship: REPC_MT230001CA.Subject.actEvent 
         * Conformance/Cardinality: REQUIRED (1) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * REPC_MT230003CA.Subject.actEvent Conformance/Cardinality: 
         * REQUIRED (1) Un-merged Business Name: (no business name 
         * specified) Relationship: REPC_MT230002CA.Subject.actEvent 
         * Conformance/Cardinality: REQUIRED (1)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"subject/actEvent"})]
        public Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_05_00.Iehr.Merged.ActEvent SubjectActEvent {
            get { return this.subjectActEvent; }
            set { this.subjectActEvent = value; }
        }

        /**
         * <summary>Un-merged Business Name: (no business name 
         * specified)</summary>
         * 
         * <remarks>Relationship: 
         * REPC_MT230003CA.Observation.statusCode 
         * Conformance/Cardinality: MANDATORY (1) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * REPC_MT230002CA.Observation.statusCode 
         * Conformance/Cardinality: MANDATORY (1)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"statusCode"})]
        public ActStatus StatusCode {
            get { return (ActStatus) this.statusCode.Value; }
            set { this.statusCode.Value = value; }
        }

    }

}