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
namespace Ca.Infoway.Messagebuilder.Model.Ab_mr2007_v02_r02.Common.Coct_mt011001ca {
    using Ca.Infoway.Messagebuilder.Annotation;
    using Ca.Infoway.Messagebuilder.Datatype;
    using Ca.Infoway.Messagebuilder.Datatype.Impl;
    using Ca.Infoway.Messagebuilder.Datatype.Lang;
    using Ca.Infoway.Messagebuilder.Domainvalue;
    using Ca.Infoway.Messagebuilder.Model;


    /**
     * <summary>Care Compositions</summary>
     * 
     * <remarks><p>A care composition is a record with two 
     * purposes. It indicates that care of a given type has 
     * occurred or is occurring. It also acts as a collector for 
     * the events that happened during care, including who is 
     * responsible for the care provided.</p> <p>Allows linking 
     * records to encounters, condition and care-based 
     * compositions. Useful for searching and navigation of the 
     * patient's record.</p></remarks>
     */
    [Hl7PartTypeMappingAttribute(new string[] {"COCT_MT011001CA.PatientCareProvisionEvent"})]
    public class CareCompositions : MessagePartBean {

        private II id;
        private CV code;

        public CareCompositions() {
            this.id = new IIImpl();
            this.code = new CVImpl();
        }
        /**
         * <summary>B: Care Composition Identifier</summary>
         * 
         * <remarks><p>Unique identifier of an encounter, condition or 
         * care-based collection.</p> <p>IMMUNIZATION 
         * INTERPRETATION.REFERENCED DATA</p> <p>Allows care 
         * compositions to be uniquely identified and referenced, and 
         * is therefore mandatory</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"id"})]
        public Identifier Id {
            get { return this.id.Value; }
            set { this.id.Value = value; }
        }

        /**
         * <summary>A: Care Composition Type</summary>
         * 
         * <remarks><p>Identifies the kind of composition represented. 
         * Examples include encounters (&quot;Emergency 
         * Encounter&quot;, &quot;Long Term Care Encounter&quot;, etc), 
         * health condition (episode)-based collections (e.g. 
         * &quot;Diabetes&quot;, &quot;Hypertension&quot;, etc) and 
         * general care-based collections such as &quot;gynecological 
         * care&quot;.</p> <p>IMMUNIZATION INTERPRETATION.REFERENCED 
         * DATA</p> <p>EPHS: vocab concepts needed for LAB ID, Special 
         * Considerations ID etc.</p> <p>Allows care compositions to be 
         * captured and categorized at different levels of abstraction, 
         * and is therefore mandatory.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"code"})]
        public ActCareEventType Code {
            get { return (ActCareEventType) this.code.Value; }
            set { this.code.Value = value; }
        }

    }

}