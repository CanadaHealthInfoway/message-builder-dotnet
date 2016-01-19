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
namespace Ca.Infoway.Messagebuilder.Model.Ccda_pcs_r1_1.Dischargesummary {
    using Ca.Infoway.Messagebuilder.Annotation;
    using Ca.Infoway.Messagebuilder.Datatype;
    using Ca.Infoway.Messagebuilder.Datatype.Impl;
    using Ca.Infoway.Messagebuilder.Datatype.Lang;
    using Ca.Infoway.Messagebuilder.Model;
    using Ca.Infoway.Messagebuilder.Model.Ccda_pcs_r1_1.Hospitaldischargemedicationssectionentriesrequired;
    using System.Collections.Generic;


    [Hl7PartTypeMappingAttribute(new string[] {"DischargeSummary.HospitalDischargeMedicationsSectionentriesRequiredComponent3"})]
    public class HospitalDischargeMedicationsSectionentriesRequiredComponent3 : MessagePartBean, Ca.Infoway.Messagebuilder.Model.Ccda_pcs_r1_1.Dischargesummary.IComponent3Choice {

        private II typeId;
        private LIST<II, Identifier> templateId;
        private Ca.Infoway.Messagebuilder.Model.Ccda_pcs_r1_1.Hospitaldischargemedicationssectionentriesrequired.Section section;

        public HospitalDischargeMedicationsSectionentriesRequiredComponent3() {
            this.typeId = new IIImpl();
            this.templateId = new LISTImpl<II, Identifier>(typeof(IIImpl));
        }
        /**
         * <summary>Relationship: 
         * DischargeSummary.HospitalDischargeMedicationsSectionentriesRequiredComponent3.typeId</summary>
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
         * DischargeSummary.HospitalDischargeMedicationsSectionentriesRequiredComponent3.templateId</summary>
         * 
         * <remarks>Conformance/Cardinality: OPTIONAL (0-*)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"templateId"})]
        public IList<Identifier> TemplateId {
            get { return this.templateId.RawList(); }
        }

        /**
         * <summary>Relationship: 
         * DischargeSummary.HospitalDischargeMedicationsSectionentriesRequiredComponent3.section</summary>
         * 
         * <remarks>Conformance/Cardinality: POPULATED (1)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"section"})]
        public Ca.Infoway.Messagebuilder.Model.Ccda_pcs_r1_1.Hospitaldischargemedicationssectionentriesrequired.Section Section {
            get { return this.section; }
            set { this.section = value; }
        }

    }

}