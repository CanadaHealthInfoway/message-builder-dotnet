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
    using Ca.Infoway.Messagebuilder.Model;
    using System.Collections.Generic;


    [Hl7PartTypeMappingAttribute(new string[] {"REPC_MT210003CA.OldClinicalDocumentEvent","REPC_MT220001CA.OldClinicalDocumentEvent","REPC_MT220002CA.OldClinicalDocumentEvent","REPC_MT220003CA.OldClinicalDocumentEvent","REPC_MT230001CA.OldClinicalDocumentEvent","REPC_MT230002CA.OldClinicalDocumentEvent","REPC_MT230003CA.OldClinicalDocumentEvent"})]
    public class ReplacesRecordIds : MessagePartBean {

        private SET<II, Identifier> id;

        public ReplacesRecordIds() {
            this.id = new SETImpl<II, Identifier>(typeof(IIImpl));
        }
        /**
         * <summary>Business Name: ReplacesRecordIds</summary>
         * 
         * <remarks>Un-merged Business Name: ReplacesRecordIds 
         * Relationship: REPC_MT210003CA.OldClinicalDocumentEvent.id 
         * Conformance/Cardinality: MANDATORY (2) <p> <i>Used in 
         * circumstances where information initially captured about an 
         * event is erroneous, incomplete or not captured at the 
         * desired level of detail and the change cannot be made by 
         * retracting the original record. (E.g. Too much time has 
         * elapsed, change is being made by a provider other than the 
         * original author of the vent record, etc.) May also be used 
         * to reference multiple records in the case where the same 
         * event has been accidentally captured more than once. May 
         * also be used when this is a newer &quot;version&quot; of the 
         * type of Referral than those records being referenced.</i> 
         * </p> <p> <i>Used to identify any records that are 
         * &quot;superseded&quot; by the current record. This will 
         * cause the referenced records to be marked as 
         * &quot;obsolete&quot; with a reference pointing to this 
         * record.</i> </p> Un-merged Business Name: ReplacesRecordIds 
         * Relationship: REPC_MT220003CA.OldClinicalDocumentEvent.id 
         * Conformance/Cardinality: MANDATORY (2) <p> <i>Used in 
         * circumstances where information initially captured about an 
         * event is erroneous, incomplete or not captured at the 
         * desired level of detail and the change cannot be made by 
         * retracting the original record. (E.g. Too much time has 
         * elapsed, change is being made by a provider other than the 
         * original author of the vent record, etc.) May also be used 
         * to reference multiple records in the case where the same 
         * event has been accidentally captured more than once. May 
         * also be used when this is a newer &quot;version&quot; of the 
         * type of Discharge-Care Summary than those records being 
         * referenced.</i> </p> <p> <i>Used to identify any records 
         * that are &quot;superseded&quot; by the current record. This 
         * will cause the referenced records to be marked as 
         * &quot;obsolete&quot; with a reference pointing to this 
         * record.</i> </p> Un-merged Business Name: ReplacesRecordIds 
         * Relationship: REPC_MT220001CA.OldClinicalDocumentEvent.id 
         * Conformance/Cardinality: MANDATORY (1-2) <p>Used in 
         * circumstances where information initially captured about an 
         * event is erroneous, incomplete or not captured at the 
         * desired level of detail and the change cannot be made by 
         * retracting the original record. (E.g. Too much time has 
         * elapsed, change is being made by a provider other than the 
         * original author of the vent record, etc.) May also be used 
         * to reference multiple records in the case where the same 
         * event has been accidentally captured more than once. May 
         * also be used when this is a newer &quot;version&quot; of the 
         * type of Discharge-Care Summary than those records being 
         * referenced.</p> <p>Used to identify any records that are 
         * &quot;superseded&quot; by the current record. This will 
         * cause the referenced records to be marked as 
         * &quot;obsolete&quot; with a reference pointing to this 
         * record.</p> Un-merged Business Name: ReplacesRecordIds 
         * Relationship: REPC_MT230003CA.OldClinicalDocumentEvent.id 
         * Conformance/Cardinality: MANDATORY (2) <p>Used in 
         * circumstances where information initially captured about an 
         * event is erroneous, incomplete or not captured at the 
         * desired level of detail and the change cannot be made by 
         * retracting the original record. (E.g. Too much time has 
         * elapsed, change is being made by a provider other than the 
         * original author of the vent record, etc.) May also be used 
         * to reference multiple records in the case where the same 
         * event has been accidentally captured more than once. May 
         * also be used when this is a newer &quot;version&quot; of the 
         * type of Clinical Observation Document than those records 
         * being referenced.</p> <p>Used to identify any records that 
         * are &quot;superseded&quot; by the current record. This will 
         * cause the referenced records to be marked as 
         * &quot;obsolete&quot; with a reference pointing to this 
         * record.</p> Un-merged Business Name: ReplacesRecordIds 
         * Relationship: REPC_MT220002CA.OldClinicalDocumentEvent.id 
         * Conformance/Cardinality: MANDATORY (2) <p> <i>Used in 
         * circumstances where information initially captured about an 
         * event is erroneous, incomplete or not captured at the 
         * desired level of detail and the change cannot be made by 
         * retracting the original record. (E.g. Too much time has 
         * elapsed, change is being made by a provider other than the 
         * original author of the vent record, etc.) May also be used 
         * to reference multiple records in the case where the same 
         * event has been accidentally captured more than once. May 
         * also be used when this is a newer &quot;version&quot; of the 
         * type of Discharge-Care Summary than those records being 
         * referenced.</i> </p> <p> <i>Used to identify any records 
         * that are &quot;superseded&quot; by the current record. This 
         * will cause the referenced records to be marked as 
         * &quot;obsolete&quot; with a reference pointing to this 
         * record.</i> </p> Un-merged Business Name: ReplacesRecordIds 
         * Relationship: REPC_MT230001CA.OldClinicalDocumentEvent.id 
         * Conformance/Cardinality: MANDATORY (1-2) <p> <i>Used in 
         * circumstances where information initially captured about an 
         * event is erroneous, incomplete or not captured at the 
         * desired level of detail and the change cannot be made by 
         * retracting the original record. (E.g. Too much time has 
         * elapsed, change is being made by a provider other than the 
         * original author of the vent record, etc.) May also be used 
         * to reference multiple records in the case where the same 
         * event has been accidentally captured more than once. May 
         * also be used when this is a newer &quot;version&quot; of the 
         * type of Clinical Observation Document than those records 
         * being referenced.</i> </p> <p> <i>Used to identify any 
         * records that are &quot;superseded&quot; by the current 
         * record. This will cause the referenced records to be marked 
         * as &quot;obsolete&quot; with a reference pointing to this 
         * record.</i> </p> Un-merged Business Name: ReplacesRecordIds 
         * Relationship: REPC_MT230002CA.OldClinicalDocumentEvent.id 
         * Conformance/Cardinality: MANDATORY (2) <p>Used in 
         * circumstances where information initially captured about an 
         * event is erroneous, incomplete or not captured at the 
         * desired level of detail and the change cannot be made by 
         * retracting the original record. (E.g. Too much time has 
         * elapsed, change is being made by a provider other than the 
         * original author of the vent record, etc.) May also be used 
         * to reference multiple records in the case where the same 
         * event has been accidentally captured more than once. May 
         * also be used when this is a newer &quot;version&quot; of the 
         * type of Clinical Observation Document than those records 
         * being referenced.</p> <p>Used to identify any records that 
         * are &quot;superseded&quot; by the current record. This will 
         * cause the referenced records to be marked as 
         * &quot;obsolete&quot; with a reference pointing to this 
         * record.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"id"})]
        public ICollection<Identifier> Id {
            get { return this.id.RawSet(); }
        }

    }

}