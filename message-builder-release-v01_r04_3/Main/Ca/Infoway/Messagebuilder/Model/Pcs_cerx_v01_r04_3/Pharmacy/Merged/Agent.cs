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
 * Last modified: $LastChangedDate: 2012-02-16 10:58:52 -0500 (Thu, 16 Feb 2012) $
 * Revision:      $LastChangedRevision: 5374 $
 */
/* This class was auto-generated by the message builder generator tools. */
namespace Ca.Infoway.Messagebuilder.Model.Pcs_cerx_v01_r04_3.Pharmacy.Merged {
    using Ca.Infoway.Messagebuilder.Annotation;
    using Ca.Infoway.Messagebuilder.Datatype;
    using Ca.Infoway.Messagebuilder.Datatype.Impl;
    using Ca.Infoway.Messagebuilder.Datatype.Lang;
    using Ca.Infoway.Messagebuilder.Model;


    /**
     * <summary>PORX_MT060090CA.Agent: (no business name)</summary>
     * 
     * <remarks><p>The identifier must be either the patient 
     * identifier, the prescriber identifier or the dispenser 
     * identifier</p> PORX_MT060340CA.Agent: (no business name) 
     * <p>The identifier must be either the patient identifier, the 
     * prescriber identifier or the dispenser identifier</p> 
     * PORX_MT020070CA.Agent: (no business name) <p>invariant( x) { 
     * The identifier must be either the patient identifier, the 
     * prescriber identifier or the dispenser identifier. }</p> 
     * PORX_MT060160CA.Agent: (no business name) <p>The identifier 
     * must be either the patient identifier, the prescriber 
     * identifier or the dispenser identifier</p></remarks>
     */
    [Hl7PartTypeMappingAttribute(new string[] {"PORX_MT020070CA.Agent","PORX_MT060090CA.Agent","PORX_MT060160CA.Agent","PORX_MT060340CA.Agent"})]
    public class Agent : MessagePartBean {

        private II id;

        public Agent() {
            this.id = new IIImpl();
        }
        /**
         * <summary>SubstitutingPersonIdentifier</summary>
         * 
         * <remarks>Substituting Person Identifier <p>Identity of the 
         * person who ultimately made the substitution decision.</p> 
         * <p>Provides a trace of responsibility for the 
         * substitution.</p> Substituting Person Identifier <p>The 
         * identity of the person who was ultimately responsible for 
         * the drug substitution.</p><p>This is either the patient, the 
         * prescriber of the dispenser.</p> <p>The identity of the 
         * person who was ultimately responsible for the drug 
         * substitution.</p><p>This is either the patient, the 
         * prescriber of the dispenser.</p> <p>Provides a trace of 
         * responsibility for the dispensed drug.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"id"})]
        public Identifier Id {
            get { return this.id.Value; }
            set { this.id.Value = value; }
        }

    }

}