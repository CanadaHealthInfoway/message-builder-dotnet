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
namespace Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Common.Coct_mt050202ca {
    using Ca.Infoway.Messagebuilder.Annotation;
    using Ca.Infoway.Messagebuilder.Datatype;
    using Ca.Infoway.Messagebuilder.Datatype.Impl;
    using Ca.Infoway.Messagebuilder.Datatype.Lang;
    using Ca.Infoway.Messagebuilder.Model;
    using Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Merged;
    using System.Collections.Generic;


    /**
     * <summary>Patient</summary>
     * 
     * <remarks><p>A person who is receiving or may receive 
     * healthcare services and has personal attributes (e.g. name, 
     * birth date).</p> <p>Information used to identify the patient 
     * and confirm their identity against the client registry.</p> 
     * <p>Only the identifier attribute is intended to be 
     * persisted, with the remaining attributes confirmed against 
     * the provider registry.</p></remarks>
     */
    [Hl7PartTypeMappingAttribute(new string[] {"COCT_MT050202CA.Patient"})]
    public class Patient : MessagePartBean, Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Iehr.Merged.IParty, Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Common.Coct_mt470012ca.ISubjectChoice, Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Merged.IChoice, Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Merged.IPatient {

        private SET<II, Identifier> id;
        private Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Merged.ActingPerson patientPerson;

        public Patient() {
            this.id = new SETImpl<II, Identifier>(typeof(IIImpl));
        }
        /**
         * <summary>A:Patient Identifier</summary>
         * 
         * <remarks><p>Unique identifier assigned to a person by 
         * Federal, Provincial and Territorial jurisdiction for the 
         * purposes of uniquely identifying the person within the 
         * EHR.</p><p>The EHR will define which identifier to use 
         * within a jurisdiction.</p> <p>Unique identifier assigned to 
         * a person by Federal, Provincial and Territorial jurisdiction 
         * for the purposes of uniquely identifying the person within 
         * the EHR.</p><p>The EHR will define which identifier to use 
         * within a jurisdiction.</p> <p>C39 
         * (Extension)</p><p>PTT.050.01 (Extension)</p><p>PTT.050.02 
         * (Root)</p><p>A.1</p><p>PID.2</p><p>Patient.332-CY 
         * (Extension)</p><p>Patient.331-CX 
         * (Root)</p><p>Claim.330-CW</p><p>Health Card 
         * Number</p><p>PID.2</p><p>PID.4</p><p>ZDU.2</p><p>ZKW.3</p><p>Jurisdiction 
         * (Root)</p><p>Person.PHN (Extension)</p> <p>C39 
         * (Extension)</p><p>PTT.050.01 (Extension)</p><p>PTT.050.02 
         * (Root)</p><p>A.1</p><p>PID.2</p><p>Patient.332-CY 
         * (Extension)</p><p>Patient.331-CX 
         * (Root)</p><p>Claim.330-CW</p><p>Health Card 
         * Number</p><p>PID.2</p><p>PID.4</p><p>ZDU.2</p><p>ZKW.3</p><p>Jurisdiction 
         * (Root)</p><p>Person.PHN (Extension)</p> <p>C39 
         * (Extension)</p><p>PTT.050.01 (Extension)</p><p>PTT.050.02 
         * (Root)</p><p>A.1</p><p>PID.2</p><p>Patient.332-CY 
         * (Extension)</p><p>Patient.331-CX 
         * (Root)</p><p>Claim.330-CW</p><p>Health Card 
         * Number</p><p>PID.2</p><p>PID.4</p><p>ZDU.2</p><p>ZKW.3</p><p>Jurisdiction 
         * (Root)</p><p>Person.PHN (Extension)</p> <p>C39 
         * (Extension)</p><p>PTT.050.01 (Extension)</p><p>PTT.050.02 
         * (Root)</p><p>A.1</p><p>PID.2</p><p>Patient.332-CY 
         * (Extension)</p><p>Patient.331-CX 
         * (Root)</p><p>Claim.330-CW</p><p>Health Card 
         * Number</p><p>PID.2</p><p>PID.4</p><p>ZDU.2</p><p>ZKW.3</p><p>Jurisdiction 
         * (Root)</p><p>Person.PHN (Extension)</p> <p>C39 
         * (Extension)</p><p>PTT.050.01 (Extension)</p><p>PTT.050.02 
         * (Root)</p><p>A.1</p><p>PID.2</p><p>Patient.332-CY 
         * (Extension)</p><p>Patient.331-CX 
         * (Root)</p><p>Claim.330-CW</p><p>Health Card 
         * Number</p><p>PID.2</p><p>PID.4</p><p>ZDU.2</p><p>ZKW.3</p><p>Jurisdiction 
         * (Root)</p><p>Person.PHN (Extension)</p> <p>C39 
         * (Extension)</p><p>PTT.050.01 (Extension)</p><p>PTT.050.02 
         * (Root)</p><p>A.1</p><p>PID.2</p><p>Patient.332-CY 
         * (Extension)</p><p>Patient.331-CX 
         * (Root)</p><p>Claim.330-CW</p><p>Health Card 
         * Number</p><p>PID.2</p><p>PID.4</p><p>ZDU.2</p><p>ZKW.3</p><p>Jurisdiction 
         * (Root)</p><p>Person.PHN (Extension)</p> <p>C39 
         * (Extension)</p><p>PTT.050.01 (Extension)</p><p>PTT.050.02 
         * (Root)</p><p>A.1</p><p>PID.2</p><p>Patient.332-CY 
         * (Extension)</p><p>Patient.331-CX 
         * (Root)</p><p>Claim.330-CW</p><p>Health Card 
         * Number</p><p>PID.2</p><p>PID.4</p><p>ZDU.2</p><p>ZKW.3</p><p>Jurisdiction 
         * (Root)</p><p>Person.PHN (Extension)</p> <p>C39 
         * (Extension)</p><p>PTT.050.01 (Extension)</p><p>PTT.050.02 
         * (Root)</p><p>A.1</p><p>PID.2</p><p>Patient.332-CY 
         * (Extension)</p><p>Patient.331-CX 
         * (Root)</p><p>Claim.330-CW</p><p>Health Card 
         * Number</p><p>PID.2</p><p>PID.4</p><p>ZDU.2</p><p>ZKW.3</p><p>Jurisdiction 
         * (Root)</p><p>Person.PHN (Extension)</p> <p>C39 
         * (Extension)</p><p>PTT.050.01 (Extension)</p><p>PTT.050.02 
         * (Root)</p><p>A.1</p><p>PID.2</p><p>Patient.332-CY 
         * (Extension)</p><p>Patient.331-CX 
         * (Root)</p><p>Claim.330-CW</p><p>Health Card 
         * Number</p><p>PID.2</p><p>PID.4</p><p>ZDU.2</p><p>ZKW.3</p><p>Jurisdiction 
         * (Root)</p><p>Person.PHN (Extension)</p> <p>C39 
         * (Extension)</p><p>PTT.050.01 (Extension)</p><p>PTT.050.02 
         * (Root)</p><p>A.1</p><p>PID.2</p><p>Patient.332-CY 
         * (Extension)</p><p>Patient.331-CX 
         * (Root)</p><p>Claim.330-CW</p><p>Health Card 
         * Number</p><p>PID.2</p><p>PID.4</p><p>ZDU.2</p><p>ZKW.3</p><p>Jurisdiction 
         * (Root)</p><p>Person.PHN (Extension)</p> <p>C39 
         * (Extension)</p><p>PTT.050.01 (Extension)</p><p>PTT.050.02 
         * (Root)</p><p>A.1</p><p>PID.2</p><p>Patient.332-CY 
         * (Extension)</p><p>Patient.331-CX 
         * (Root)</p><p>Claim.330-CW</p><p>Health Card 
         * Number</p><p>PID.2</p><p>PID.4</p><p>ZDU.2</p><p>ZKW.3</p><p>Jurisdiction 
         * (Root)</p><p>Person.PHN (Extension)</p> <p>C39 
         * (Extension)</p><p>PTT.050.01 (Extension)</p><p>PTT.050.02 
         * (Root)</p><p>A.1</p><p>PID.2</p><p>Patient.332-CY 
         * (Extension)</p><p>Patient.331-CX 
         * (Root)</p><p>Claim.330-CW</p><p>Health Card 
         * Number</p><p>PID.2</p><p>PID.4</p><p>ZDU.2</p><p>ZKW.3</p><p>Jurisdiction 
         * (Root)</p><p>Person.PHN (Extension)</p> <p>C39 
         * (Extension)</p><p>PTT.050.01 (Extension)</p><p>PTT.050.02 
         * (Root)</p><p>A.1</p><p>PID.2</p><p>Patient.332-CY 
         * (Extension)</p><p>Patient.331-CX 
         * (Root)</p><p>Claim.330-CW</p><p>Health Card 
         * Number</p><p>PID.2</p><p>PID.4</p><p>ZDU.2</p><p>ZKW.3</p><p>Jurisdiction 
         * (Root)</p><p>Person.PHN (Extension)</p> <p>C39 
         * (Extension)</p><p>PTT.050.01 (Extension)</p><p>PTT.050.02 
         * (Root)</p><p>A.1</p><p>PID.2</p><p>Patient.332-CY 
         * (Extension)</p><p>Patient.331-CX 
         * (Root)</p><p>Claim.330-CW</p><p>Health Card 
         * Number</p><p>PID.2</p><p>PID.4</p><p>ZDU.2</p><p>ZKW.3</p><p>Jurisdiction 
         * (Root)</p><p>Person.PHN (Extension)</p> <p>C39 
         * (Extension)</p><p>PTT.050.01 (Extension)</p><p>PTT.050.02 
         * (Root)</p><p>A.1</p><p>PID.2</p><p>Patient.332-CY 
         * (Extension)</p><p>Patient.331-CX 
         * (Root)</p><p>Claim.330-CW</p><p>Health Card 
         * Number</p><p>PID.2</p><p>PID.4</p><p>ZDU.2</p><p>ZKW.3</p><p>Jurisdiction 
         * (Root)</p><p>Person.PHN (Extension)</p> <p>Allows a patient 
         * to be referred to unambiguously. Because this is the 
         * principal mechanism for identifying patients to computer 
         * systems, the attribute is mandatory. If an identifier is not 
         * known, it should be looked up using the 'client registry' 
         * capabilities of the EHR application. The cardinality of 
         * patient identifiers is up to 3 based on the use case to 
         * support communication of a local and jurisdictional 
         * identifier along with the national identifier.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"id"})]
        public ICollection<Identifier> Id {
            get { return this.id.RawSet(); }
        }

        [Hl7XmlMappingAttribute(new string[] {"patientPerson"})]
        public Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Merged.ActingPerson PatientPerson {
            get { return this.patientPerson; }
            set { this.patientPerson = value; }
        }

    }

}