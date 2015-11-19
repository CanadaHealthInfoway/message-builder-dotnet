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
 * Author:        $LastChangedBy: tmcgrady $
 * Last modified: $LastChangedDate: 2011-05-04 15:47:15 -0400 (Wed, 04 May 2011) $
 * Revision:      $LastChangedRevision: 2623 $
 */
/* This class was auto-generated by the message builder generator tools. */
namespace Ca.Infoway.Messagebuilder.Model.Ab_mr2007_v02_r02.Merged {
    using Ca.Infoway.Messagebuilder.Annotation;
    using Ca.Infoway.Messagebuilder.Datatype;
    using Ca.Infoway.Messagebuilder.Datatype.Impl;
    using Ca.Infoway.Messagebuilder.Domainvalue;
    using Ca.Infoway.Messagebuilder.Model;
    using Ca.Infoway.Messagebuilder.Model.Ab_mr2007_v02_r02.Common.Coct_mt011001ca;
    using System;


    /**
     * <summary>QUQI_MT020000CA.Component: Care Compositions</summary>
     * 
     * <p>A care composition is a record, which summarizes the 
     * events that happened during care including who is 
     * responsible for the care provided.</p><p>Examples include 
     * encounters, health condition (episode)-based collections and 
     * general care-based collections such as &quot;gynecological 
     * care&quot;.</p> <p>A care composition is a record, which 
     * summarizes the events that happened during care including 
     * who is responsible for the care provided.</p><p>Examples 
     * include encounters, health condition (episode)-based 
     * collections and general care-based collections such as 
     * &quot;gynecological care&quot;.</p> <p>Allows linking 
     * records to encounters, condition and care-based 
     * compositions. Useful for searching and navigation of the 
     * patient's record.</p> MCAI_MT700211CA.Component: Care 
     * Compositions <p>A care composition is a record, which 
     * summarizes the events that happened during care including 
     * who is responsible for the care provided.</p><p>Examples 
     * include encounters, health condition (episode)-based 
     * collections and general care-based collections such as 
     * &quot;gynecological care&quot;.</p> <p>A care composition is 
     * a record, which summarizes the events that happened during 
     * care including who is responsible for the care 
     * provided.</p><p>Examples include encounters, health 
     * condition (episode)-based collections and general care-based 
     * collections such as &quot;gynecological care&quot;.</p> 
     * <p>Allows linking records to encounters, condition and 
     * care-based compositions. Useful for searching and navigation 
     * of the patient's record.</p> REPC_MT000006CA.Component: is 
     * part of <p>Associates the event with other care events</p> 
     * <p>Allows for grouping the current event with other care 
     * events.</p> PORX_MT060040CA.Component2: is part of 
     * <p>Associates the event with other care events</p> <p>Allows 
     * for grouping the current event with other care events.</p> 
     * REPC_MT000009CA.Component: is part of <p>Associates the 
     * event with other care events</p> <p>Allows for grouping the 
     * current event with other care events.</p> 
     * QUQI_MT120006CA.Component: Care Compositions <p>A care 
     * composition is a record, which summarizes the events that 
     * happened during care including who is responsible for the 
     * care provided.</p><p>Examples include encounters, health 
     * condition (episode)-based collections and general care-based 
     * collections such as &quot;gynecological care&quot;.</p> <p>A 
     * care composition is a record, which summarizes the events 
     * that happened during care including who is responsible for 
     * the care provided.</p><p>Examples include encounters, health 
     * condition (episode)-based collections and general care-based 
     * collections such as &quot;gynecological care&quot;.</p> 
     * <p>Allows linking records to encounters, condition and 
     * care-based compositions. Useful for searching and navigation 
     * of the patient's record.</p> PORX_MT060190CA.Component: is 
     * part of <p>Associates the event with other care events</p> 
     * <p>Allows for grouping the current event with other care 
     * events.</p> PORX_MT030040CA.Component: is part of 
     * <p>Associates the event with other care events</p> <p>Allows 
     * for grouping the current event with other care events.</p> 
     * REPC_MT000005CA.Component: is part of <p>Associates the 
     * event with other care events</p> <p>Allows for grouping the 
     * current event with other care events.</p> 
     * PORX_MT060190CA.Component2: is part of <p>Associates the 
     * event with other care events</p> <p>Allows for grouping the 
     * current event with other care events.</p> 
     * PORX_MT060210CA.Component2: is part of <p>Associates the 
     * event with other care events</p> <p>Allows for grouping the 
     * current event with other care events.</p> 
     * PORX_MT060060CA.Component: is part of <p>Associates the 
     * event with other care events</p> <p>Allows for grouping the 
     * current event with other care events.</p>
     */
    [Hl7PartTypeMappingAttribute(new string[] {"MCAI_MT700211CA.Component","PORX_MT030040CA.Component","PORX_MT060040CA.Component2","PORX_MT060060CA.Component","PORX_MT060190CA.Component","PORX_MT060190CA.Component2","PORX_MT060210CA.Component2","QUQI_MT020000CA.Component","QUQI_MT120006CA.Component","REPC_MT000005CA.Component","REPC_MT000006CA.Component","REPC_MT000009CA.Component"})]
    public class IsPartOf : MessagePartBean {

        private BL contextConductionInd;
        private Ca.Infoway.Messagebuilder.Model.Ab_mr2007_v02_r02.Common.Coct_mt011001ca.CareCompositions patientCareProvisionEvent;
        private CS typeCode;

        public IsPartOf() {
            this.contextConductionInd = new BLImpl();
            this.typeCode = new CSImpl();
        }
        /**
         * <summary>Un-merged Business Name: (no business name 
         * specified)</summary>
         * 
         * <remarks>Relationship: 
         * QUQI_MT020000CA.Component.contextConductionInd 
         * Conformance/Cardinality: MANDATORY (1) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * MCAI_MT700211CA.Component.contextConductionInd 
         * Conformance/Cardinality: MANDATORY (1) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * QUQI_MT120006CA.Component.contextConductionInd 
         * Conformance/Cardinality: MANDATORY (1)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"contextConductionInd"})]
        public bool? ContextConductionInd {
            get { return this.contextConductionInd.Value; }
            set { this.contextConductionInd.Value = value; }
        }

        /**
         * <summary>Un-merged Business Name: (no business name 
         * specified)</summary>
         * 
         * <remarks>Relationship: 
         * QUQI_MT020000CA.Component.patientCareProvisionEvent 
         * Conformance/Cardinality: POPULATED (1) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * MCAI_MT700211CA.Component.patientCareProvisionEvent 
         * Conformance/Cardinality: POPULATED (1) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * PORX_MT060040CA.Component2.patientCareProvisionEvent 
         * Conformance/Cardinality: POPULATED (1) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * REPC_MT000006CA.Component.patientCareProvisionEvent 
         * Conformance/Cardinality: POPULATED (1) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * REPC_MT000009CA.Component.patientCareProvisionEvent 
         * Conformance/Cardinality: POPULATED (1) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * PORX_MT030040CA.Component.patientCareProvisionEvent 
         * Conformance/Cardinality: POPULATED (1) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * PORX_MT060190CA.Component.patientCareProvisionEvent 
         * Conformance/Cardinality: POPULATED (1) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * QUQI_MT120006CA.Component.patientCareProvisionEvent 
         * Conformance/Cardinality: POPULATED (1) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * REPC_MT000005CA.Component.patientCareProvisionEvent 
         * Conformance/Cardinality: POPULATED (1) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * PORX_MT060190CA.Component2.patientCareProvisionEvent 
         * Conformance/Cardinality: POPULATED (1) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * PORX_MT060210CA.Component2.patientCareProvisionEvent 
         * Conformance/Cardinality: POPULATED (1) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * PORX_MT060060CA.Component.patientCareProvisionEvent 
         * Conformance/Cardinality: POPULATED (1)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"patientCareProvisionEvent"})]
        public Ca.Infoway.Messagebuilder.Model.Ab_mr2007_v02_r02.Common.Coct_mt011001ca.CareCompositions PatientCareProvisionEvent {
            get { return this.patientCareProvisionEvent; }
            set { this.patientCareProvisionEvent = value; }
        }

        /**
         * <summary>Un-merged Business Name: (no business name 
         * specified)</summary>
         * 
         * <remarks>Relationship: MCAI_MT700211CA.Component.typeCode 
         * Conformance/Cardinality: MANDATORY (1) Un-merged Business 
         * Name: (no business name specified) Relationship: 
         * QUQI_MT120006CA.Component.typeCode Conformance/Cardinality: 
         * MANDATORY (1)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"typeCode"})]
        public ActRelationshipType TypeCode {
            get { return (ActRelationshipType) this.typeCode.Value; }
            set { this.typeCode.Value = value; }
        }

    }

}