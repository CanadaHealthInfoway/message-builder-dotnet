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
namespace Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Iehr.Merged {
    using Ca.Infoway.Messagebuilder;
    using Ca.Infoway.Messagebuilder.Annotation;
    using Ca.Infoway.Messagebuilder.Datatype;
    using Ca.Infoway.Messagebuilder.Datatype.Impl;
    using Ca.Infoway.Messagebuilder.Datatype.Lang;
    using Ca.Infoway.Messagebuilder.Model;


    /**
     * <summary>ComponentObservations</summary>
     * 
     * <remarks>REPC_MT410001CA.SubObservationEvent: Component 
     * Observations <p>Captures components of a more complex 
     * observation, such as apgar or blood pressure.</p> <p>Not all 
     * observations can be expressed as a single code or code and 
     * value.</p> REPC_MT410003CA.SubObservationEvent: Component 
     * Observations <p>Captures components of a more complex 
     * observation, such as apgar or blood pressure.</p> <p>Not all 
     * observations can be expressed as a single code or code and 
     * value.</p></remarks>
     */
    [Hl7PartTypeMappingAttribute(new string[] {"REPC_MT410001CA.SubObservationEvent","REPC_MT410003CA.SubObservationEvent"})]
    public class ComponentObservations_1 : MessagePartBean {

        private CD code;
        private PQ value;

        public ComponentObservations_1() {
            this.code = new CDImpl();
            this.value = new PQImpl();
        }
        /**
         * <summary>ComponentObservationType</summary>
         * 
         * <remarks>Q: Component Observation Type <p>Identifies the 
         * type of sub-observation being made.</p><p>E.g. systolic 
         * blood pressure.</p> <p>Identifies the type of 
         * sub-observation being made.</p><p>E.g. systolic blood 
         * pressure.</p> </p> </p> </p> </p> <p>EPHS: need fixed value 
         * for &quot;COMPLICATIONS&quot;</p><p>EPHS:need fixed value 
         * for IMMUNIZATION VACCINE; VALID IMMUNIZATION DOSES 
         * RECEIVED;IMMUNIZATION DOSES NEEDED;ADDITIONAL 
         * COMPLICATION;CAUSE OF DEATH;OTHER COMPLICATION; RISK FACTOR 
         * CATEGORY;RISK FACTOR FREQUENCY; RISK FACTOR 
         * COMMENT;</p><p>EPHS: need fixed value for OUTBREAK 
         * COMPLICATION AGGREGATE COUNT; OUTBREAK SIGN AND SYMPTOM 
         * UNIDENTIFIED AGGREGATE COUNT</p> <p>EPHS: need fixed value 
         * for &quot;COMPLICATIONS&quot;</p><p>EPHS:need fixed value 
         * for IMMUNIZATION VACCINE; VALID IMMUNIZATION DOSES 
         * RECEIVED;IMMUNIZATION DOSES NEEDED;ADDITIONAL 
         * COMPLICATION;CAUSE OF DEATH;OTHER COMPLICATION; RISK FACTOR 
         * CATEGORY;RISK FACTOR FREQUENCY; RISK FACTOR 
         * COMMENT;</p><p>EPHS: need fixed value for OUTBREAK 
         * COMPLICATION AGGREGATE COUNT; OUTBREAK SIGN AND SYMPTOM 
         * UNIDENTIFIED AGGREGATE COUNT</p> <p>EPHS: need fixed value 
         * for &quot;COMPLICATIONS&quot;</p><p>EPHS:need fixed value 
         * for IMMUNIZATION VACCINE; VALID IMMUNIZATION DOSES 
         * RECEIVED;IMMUNIZATION DOSES NEEDED;ADDITIONAL 
         * COMPLICATION;CAUSE OF DEATH;OTHER COMPLICATION; RISK FACTOR 
         * CATEGORY;RISK FACTOR FREQUENCY; RISK FACTOR 
         * COMMENT;</p><p>EPHS: need fixed value for OUTBREAK 
         * COMPLICATION AGGREGATE COUNT; OUTBREAK SIGN AND SYMPTOM 
         * UNIDENTIFIED AGGREGATE COUNT</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"code"})]
        public Code Code {
            get { return (Code) this.code.Value; }
            set { this.code.Value = value; }
        }

        /**
         * <summary>ComponentObservationValue</summary>
         * 
         * <remarks>Component Observation Value <p>Indicates what was 
         * actually observed when the sub-observation was 
         * made.</p><p>E.g. 120 mmHg for systolic blood pressure.</p> 
         * <p>Indicates what was actually observed when the 
         * sub-observation was made.</p><p>E.g. 120 mmHg for systolic 
         * blood pressure.</p> <p>PHS 07-feb-02. Some appropriate vocab 
         * concept is needed for observation.code, to pair with EPHS 
         * mappings.</p> <p>Conveys the clinical information resulting 
         * from the sub-observation in a standardized 
         * representation.</p><p>There's no point sending a 
         * sub-observation if no value is known. Therefore, the 
         * attribute is mandatory.</p> <p>Conveys the clinical 
         * information resulting from the sub-observation in a 
         * standardized representation.</p><p>There's no point sending 
         * a sub-observation if no value is known. Therefore, the 
         * attribute is mandatory.</p> <p>EPHS: datatype needs to be 
         * constrained at runtime to CV, PQ or ST depending upon type 
         * of observation being reported. EPHS: vocab domains needed 
         * for CAUSE OF DEATH;VACCINE</p> R: Component Observation 
         * Value <p>Indicates what was actually observed when the 
         * sub-observation was made.</p><p>E.g. 120 mmHg for systolic 
         * blood pressure.</p> <p>Indicates what was actually observed 
         * when the sub-observation was made.</p><p>E.g. 120 mmHg for 
         * systolic blood pressure.</p> <p>PHS 07-feb-02. Some 
         * appropriate vocab concept is needed for observation.code, to 
         * pair with EPHS mappings.</p> <p>Conveys the clinical 
         * information resulting from the sub-observation in a 
         * standardized representation.</p><p>There's no point sending 
         * a sub-observation if no value is known. Therefore, the 
         * attribute is mandatory.</p> <p>Conveys the clinical 
         * information resulting from the sub-observation in a 
         * standardized representation.</p><p>There's no point sending 
         * a sub-observation if no value is known. Therefore, the 
         * attribute is mandatory.</p> <p>EPHS: datatype needs to be 
         * constrained at runtime to CV, PQ or ST depending upon type 
         * of observation being reported. EPHS: vocab domains needed 
         * for CAUSE OF DEATH;VACCINE</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"value"})]
        public PhysicalQuantity Value {
            get { return this.value.Value; }
            set { this.value.Value = value; }
        }

    }

}