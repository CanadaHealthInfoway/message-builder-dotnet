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
namespace Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Lab.Polb_mt004100ca {
    using Ca.Infoway.Messagebuilder;
    using Ca.Infoway.Messagebuilder.Annotation;
    using Ca.Infoway.Messagebuilder.Datatype;
    using Ca.Infoway.Messagebuilder.Datatype.Impl;
    using Ca.Infoway.Messagebuilder.Datatype.Lang;
    using Ca.Infoway.Messagebuilder.Domainvalue;
    using Ca.Infoway.Messagebuilder.Model;
    using Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Lab.Merged;
    using Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Merged;
    using System;
    using System.Collections.Generic;


    /**
     * <summary>Culture Observations</summary>
     * 
     * <remarks><p>Act for describing any observations about the 
     * culture e.g. Protein measurements, gram stains, 
     * culture-level supporting clinical information observations 
     * use this act and are associated using the 
     * pertinentInformation act relationship. Those test (result) 
     * components which are not supporting but are observation 
     * which are &quot;part of&quot; the resulted values should be 
     * associated using this act and the component act 
     * relationship.</p></remarks>
     */
    [Hl7PartTypeMappingAttribute(new string[] {"POLB_MT004100CA.CultureObservationEvent"})]
    public class CultureObservations : MessagePartBean {

        private CD code;
        private ST text;
        private CS statusCode;
        private IVL<TS, Interval<PlatformDate>> effectiveTime;
        private ANY<object> value;
        private IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Merged.Includes> subjectOf1;
        private Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Lab.Merged.ResultStatusProcessStep subjectOf2ResultStatusProcessStep;

        public CultureObservations() {
            this.code = new CDImpl();
            this.text = new STImpl();
            this.statusCode = new CSImpl();
            this.effectiveTime = new IVLImpl<TS, Interval<PlatformDate>>();
            this.value = new ANYImpl<object>();
            this.subjectOf1 = new List<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Merged.Includes>();
        }
        /**
         * <summary>Culture Observation Type</summary>
         * 
         * <remarks><p>Act for describing the type of observations 
         * about the culture e.g. gram stain, etc.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"code"})]
        public Code Code {
            get { return (Code) this.code.Value; }
            set { this.code.Value = value; }
        }

        /**
         * <summary>Culture Observation Comment</summary>
         * 
         * <remarks><p>Comments associated with the Culture 
         * Observation.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"text"})]
        public String Text {
            get { return this.text.Value; }
            set { this.text.Value = value; }
        }

        /**
         * <summary>Culture Observation Status</summary>
         * 
         * <remarks><p>Status associated with the Culture 
         * Observation.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"statusCode"})]
        public ActStatus StatusCode {
            get { return (ActStatus) this.statusCode.Value; }
            set { this.statusCode.Value = value; }
        }

        /**
         * <summary>Culture Observation Date/Time</summary>
         * 
         * <remarks><p>The date/time interval when this culture 
         * observation took place.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"effectiveTime"})]
        public Interval<PlatformDate> EffectiveTime {
            get { return this.effectiveTime.Value; }
            set { this.effectiveTime.Value = value; }
        }

        /**
         * <summary>Culture Observation Value</summary>
         * 
         * <remarks><p>The result value of this culture observation 
         * e.g. the number value associated with a protein measurement, 
         * etc. When a coded value applies, values must be selected 
         * from the CultureObservationValue Concept Domain.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"value"})]
        public object Value {
            get { return this.value.Value; }
            set { this.value.Value = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"subjectOf1"})]
        public IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Merged.Includes> SubjectOf1 {
            get { return this.subjectOf1; }
        }

        [Hl7XmlMappingAttribute(new string[] {"subjectOf2/resultStatusProcessStep"})]
        public Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Lab.Merged.ResultStatusProcessStep SubjectOf2ResultStatusProcessStep {
            get { return this.subjectOf2ResultStatusProcessStep; }
            set { this.subjectOf2ResultStatusProcessStep = value; }
        }

    }

}