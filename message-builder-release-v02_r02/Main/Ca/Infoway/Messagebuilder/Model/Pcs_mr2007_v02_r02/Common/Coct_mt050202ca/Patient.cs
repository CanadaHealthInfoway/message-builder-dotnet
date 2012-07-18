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
 * Last modified: $LastChangedDate: 2012-02-16 11:10:18 -0500 (Thu, 16 Feb 2012) $
 * Revision:      $LastChangedRevision: 5505 $
 */
/* This class was auto-generated by the message builder generator tools. */
namespace Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r02.Common.Coct_mt050202ca {
    using Ca.Infoway.Messagebuilder.Annotation;
    using Ca.Infoway.Messagebuilder.Datatype;
    using Ca.Infoway.Messagebuilder.Datatype.Impl;
    using Ca.Infoway.Messagebuilder.Datatype.Lang;
    using Ca.Infoway.Messagebuilder.Domainvalue;
    using Ca.Infoway.Messagebuilder.Model;
    using System;


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
    public class Patient : MessagePartBean, Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r02.Merged.IChoice, Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r02.Iehr.Merged.IParty, Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r02.Common.Merged.ISubjectChoice, Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r02.Common.Merged.IPatient_2 {

        private II id;
        private PN patientPersonName;
        private CV patientPersonAdministrativeGenderCode;
        private TS patientPersonBirthTime;

        public Patient() {
            this.id = new IIImpl();
            this.patientPersonName = new PNImpl();
            this.patientPersonAdministrativeGenderCode = new CVImpl();
            this.patientPersonBirthTime = new TSImpl();
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
         * capabilities of the EHR application.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"id"})]
        public Identifier Id {
            get { return this.id.Value; }
            set { this.id.Value = value; }
        }

        /**
         * <summary>B:Patient Name</summary>
         * 
         * <remarks><p>The name by which the patient is known to the 
         * underlying client registry application</p> <p>ZPA.1 
         * (partType=Given)</p><p>ZPA.2 (partType=Family)</p><p>ZPA.3 
         * (partType=Given - all repetitions except first)</p><p>C37 
         * (partType=Given)</p><p>C38 
         * (partType=Family)</p><p>PTT.030-01 
         * (partType=Family)</p><p>PTT.030-02 (partType=Given - 1st 
         * occurrence)</p><p>PTT.030-03 (partType=Given - subsequen 
         * occurrences)</p><p>PTT.030-04 
         * (partType=Suffix)</p><p>PTT.030-05 
         * (partType=Prefix)</p><p>patient 
         * Initials</p><p>PID.5</p><p>Patient.310-CA 
         * (partType=Given)</p><p>Patient.311-CB 
         * (partType=Family)</p><p>Recipient Name First 
         * (partType=Given)</p><p>Recipient Name Last 
         * (partType=Family)</p><p>PID.5</p><p>PID.9 (any name other 
         * than first repetition is an 
         * alias)</p><p>ZDU.3</p><p>ZKW.2</p><p>Person.givenName</p><p>Person.lastName</p><p>Person.middleName</p><p>Person.namePrefix</p><p>Person.nameSuffix</p> 
         * <p>ZPA.1 (partType=Given)</p><p>ZPA.2 
         * (partType=Family)</p><p>ZPA.3 (partType=Given - all 
         * repetitions except first)</p><p>C37 
         * (partType=Given)</p><p>C38 
         * (partType=Family)</p><p>PTT.030-01 
         * (partType=Family)</p><p>PTT.030-02 (partType=Given - 1st 
         * occurrence)</p><p>PTT.030-03 (partType=Given - subsequen 
         * occurrences)</p><p>PTT.030-04 
         * (partType=Suffix)</p><p>PTT.030-05 
         * (partType=Prefix)</p><p>patient 
         * Initials</p><p>PID.5</p><p>Patient.310-CA 
         * (partType=Given)</p><p>Patient.311-CB 
         * (partType=Family)</p><p>Recipient Name First 
         * (partType=Given)</p><p>Recipient Name Last 
         * (partType=Family)</p><p>PID.5</p><p>PID.9 (any name other 
         * than first repetition is an 
         * alias)</p><p>ZDU.3</p><p>ZKW.2</p><p>Person.givenName</p><p>Person.lastName</p><p>Person.middleName</p><p>Person.namePrefix</p><p>Person.nameSuffix</p> 
         * <p>ZPA.1 (partType=Given)</p><p>ZPA.2 
         * (partType=Family)</p><p>ZPA.3 (partType=Given - all 
         * repetitions except first)</p><p>C37 
         * (partType=Given)</p><p>C38 
         * (partType=Family)</p><p>PTT.030-01 
         * (partType=Family)</p><p>PTT.030-02 (partType=Given - 1st 
         * occurrence)</p><p>PTT.030-03 (partType=Given - subsequen 
         * occurrences)</p><p>PTT.030-04 
         * (partType=Suffix)</p><p>PTT.030-05 
         * (partType=Prefix)</p><p>patient 
         * Initials</p><p>PID.5</p><p>Patient.310-CA 
         * (partType=Given)</p><p>Patient.311-CB 
         * (partType=Family)</p><p>Recipient Name First 
         * (partType=Given)</p><p>Recipient Name Last 
         * (partType=Family)</p><p>PID.5</p><p>PID.9 (any name other 
         * than first repetition is an 
         * alias)</p><p>ZDU.3</p><p>ZKW.2</p><p>Person.givenName</p><p>Person.lastName</p><p>Person.middleName</p><p>Person.namePrefix</p><p>Person.nameSuffix</p> 
         * <p>ZPA.1 (partType=Given)</p><p>ZPA.2 
         * (partType=Family)</p><p>ZPA.3 (partType=Given - all 
         * repetitions except first)</p><p>C37 
         * (partType=Given)</p><p>C38 
         * (partType=Family)</p><p>PTT.030-01 
         * (partType=Family)</p><p>PTT.030-02 (partType=Given - 1st 
         * occurrence)</p><p>PTT.030-03 (partType=Given - subsequen 
         * occurrences)</p><p>PTT.030-04 
         * (partType=Suffix)</p><p>PTT.030-05 
         * (partType=Prefix)</p><p>patient 
         * Initials</p><p>PID.5</p><p>Patient.310-CA 
         * (partType=Given)</p><p>Patient.311-CB 
         * (partType=Family)</p><p>Recipient Name First 
         * (partType=Given)</p><p>Recipient Name Last 
         * (partType=Family)</p><p>PID.5</p><p>PID.9 (any name other 
         * than first repetition is an 
         * alias)</p><p>ZDU.3</p><p>ZKW.2</p><p>Person.givenName</p><p>Person.lastName</p><p>Person.middleName</p><p>Person.namePrefix</p><p>Person.nameSuffix</p> 
         * <p>ZPA.1 (partType=Given)</p><p>ZPA.2 
         * (partType=Family)</p><p>ZPA.3 (partType=Given - all 
         * repetitions except first)</p><p>C37 
         * (partType=Given)</p><p>C38 
         * (partType=Family)</p><p>PTT.030-01 
         * (partType=Family)</p><p>PTT.030-02 (partType=Given - 1st 
         * occurrence)</p><p>PTT.030-03 (partType=Given - subsequen 
         * occurrences)</p><p>PTT.030-04 
         * (partType=Suffix)</p><p>PTT.030-05 
         * (partType=Prefix)</p><p>patient 
         * Initials</p><p>PID.5</p><p>Patient.310-CA 
         * (partType=Given)</p><p>Patient.311-CB 
         * (partType=Family)</p><p>Recipient Name First 
         * (partType=Given)</p><p>Recipient Name Last 
         * (partType=Family)</p><p>PID.5</p><p>PID.9 (any name other 
         * than first repetition is an 
         * alias)</p><p>ZDU.3</p><p>ZKW.2</p><p>Person.givenName</p><p>Person.lastName</p><p>Person.middleName</p><p>Person.namePrefix</p><p>Person.nameSuffix</p> 
         * <p>ZPA.1 (partType=Given)</p><p>ZPA.2 
         * (partType=Family)</p><p>ZPA.3 (partType=Given - all 
         * repetitions except first)</p><p>C37 
         * (partType=Given)</p><p>C38 
         * (partType=Family)</p><p>PTT.030-01 
         * (partType=Family)</p><p>PTT.030-02 (partType=Given - 1st 
         * occurrence)</p><p>PTT.030-03 (partType=Given - subsequen 
         * occurrences)</p><p>PTT.030-04 
         * (partType=Suffix)</p><p>PTT.030-05 
         * (partType=Prefix)</p><p>patient 
         * Initials</p><p>PID.5</p><p>Patient.310-CA 
         * (partType=Given)</p><p>Patient.311-CB 
         * (partType=Family)</p><p>Recipient Name First 
         * (partType=Given)</p><p>Recipient Name Last 
         * (partType=Family)</p><p>PID.5</p><p>PID.9 (any name other 
         * than first repetition is an 
         * alias)</p><p>ZDU.3</p><p>ZKW.2</p><p>Person.givenName</p><p>Person.lastName</p><p>Person.middleName</p><p>Person.namePrefix</p><p>Person.nameSuffix</p> 
         * <p>ZPA.1 (partType=Given)</p><p>ZPA.2 
         * (partType=Family)</p><p>ZPA.3 (partType=Given - all 
         * repetitions except first)</p><p>C37 
         * (partType=Given)</p><p>C38 
         * (partType=Family)</p><p>PTT.030-01 
         * (partType=Family)</p><p>PTT.030-02 (partType=Given - 1st 
         * occurrence)</p><p>PTT.030-03 (partType=Given - subsequen 
         * occurrences)</p><p>PTT.030-04 
         * (partType=Suffix)</p><p>PTT.030-05 
         * (partType=Prefix)</p><p>patient 
         * Initials</p><p>PID.5</p><p>Patient.310-CA 
         * (partType=Given)</p><p>Patient.311-CB 
         * (partType=Family)</p><p>Recipient Name First 
         * (partType=Given)</p><p>Recipient Name Last 
         * (partType=Family)</p><p>PID.5</p><p>PID.9 (any name other 
         * than first repetition is an 
         * alias)</p><p>ZDU.3</p><p>ZKW.2</p><p>Person.givenName</p><p>Person.lastName</p><p>Person.middleName</p><p>Person.namePrefix</p><p>Person.nameSuffix</p> 
         * <p>ZPA.1 (partType=Given)</p><p>ZPA.2 
         * (partType=Family)</p><p>ZPA.3 (partType=Given - all 
         * repetitions except first)</p><p>C37 
         * (partType=Given)</p><p>C38 
         * (partType=Family)</p><p>PTT.030-01 
         * (partType=Family)</p><p>PTT.030-02 (partType=Given - 1st 
         * occurrence)</p><p>PTT.030-03 (partType=Given - subsequen 
         * occurrences)</p><p>PTT.030-04 
         * (partType=Suffix)</p><p>PTT.030-05 
         * (partType=Prefix)</p><p>patient 
         * Initials</p><p>PID.5</p><p>Patient.310-CA 
         * (partType=Given)</p><p>Patient.311-CB 
         * (partType=Family)</p><p>Recipient Name First 
         * (partType=Given)</p><p>Recipient Name Last 
         * (partType=Family)</p><p>PID.5</p><p>PID.9 (any name other 
         * than first repetition is an 
         * alias)</p><p>ZDU.3</p><p>ZKW.2</p><p>Person.givenName</p><p>Person.lastName</p><p>Person.middleName</p><p>Person.namePrefix</p><p>Person.nameSuffix</p> 
         * <p>ZPA.1 (partType=Given)</p><p>ZPA.2 
         * (partType=Family)</p><p>ZPA.3 (partType=Given - all 
         * repetitions except first)</p><p>C37 
         * (partType=Given)</p><p>C38 
         * (partType=Family)</p><p>PTT.030-01 
         * (partType=Family)</p><p>PTT.030-02 (partType=Given - 1st 
         * occurrence)</p><p>PTT.030-03 (partType=Given - subsequen 
         * occurrences)</p><p>PTT.030-04 
         * (partType=Suffix)</p><p>PTT.030-05 
         * (partType=Prefix)</p><p>patient 
         * Initials</p><p>PID.5</p><p>Patient.310-CA 
         * (partType=Given)</p><p>Patient.311-CB 
         * (partType=Family)</p><p>Recipient Name First 
         * (partType=Given)</p><p>Recipient Name Last 
         * (partType=Family)</p><p>PID.5</p><p>PID.9 (any name other 
         * than first repetition is an 
         * alias)</p><p>ZDU.3</p><p>ZKW.2</p><p>Person.givenName</p><p>Person.lastName</p><p>Person.middleName</p><p>Person.namePrefix</p><p>Person.nameSuffix</p> 
         * <p>ZPA.1 (partType=Given)</p><p>ZPA.2 
         * (partType=Family)</p><p>ZPA.3 (partType=Given - all 
         * repetitions except first)</p><p>C37 
         * (partType=Given)</p><p>C38 
         * (partType=Family)</p><p>PTT.030-01 
         * (partType=Family)</p><p>PTT.030-02 (partType=Given - 1st 
         * occurrence)</p><p>PTT.030-03 (partType=Given - subsequen 
         * occurrences)</p><p>PTT.030-04 
         * (partType=Suffix)</p><p>PTT.030-05 
         * (partType=Prefix)</p><p>patient 
         * Initials</p><p>PID.5</p><p>Patient.310-C
         * ... [rest of documentation truncated due to excessive length]
         */
        [Hl7XmlMappingAttribute(new string[] {"patientPerson/name"})]
        public PersonName PatientPersonName {
            get { return this.patientPersonName.Value; }
            set { this.patientPersonName.Value = value; }
        }

        /**
         * <summary>F:Patient Gender</summary>
         * 
         * <remarks><p>Indicates the gender (sex) of the patient as 
         * known by the client registry. Complex genetic genders are 
         * handled as observations if they are considered relevant.</p> 
         * <p>Used to confirm patient identity.</p><p>The element is 
         * mandatory because the patient's gender is necessary for 
         * positive identification of the patient in the jurisdictional 
         * client registry and should always be known.</p> <p>Used to 
         * confirm patient identity.</p><p>The element is mandatory 
         * because the patient's gender is necessary for positive 
         * identification of the patient in the jurisdictional client 
         * registry and should always be known.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"patientPerson/administrativeGenderCode"})]
        public AdministrativeGender PatientPersonAdministrativeGenderCode {
            get { return (AdministrativeGender) this.patientPersonAdministrativeGenderCode.Value; }
            set { this.patientPersonAdministrativeGenderCode.Value = value; }
        }

        /**
         * <summary>E:Patient Birth Date</summary>
         * 
         * <remarks><p>Indicates the date on which the patient was 
         * born, as known by the client registry.</p> <p>Used to 
         * confirm patient identity.</p><p>This element is 'populated' 
         * because the patient's birth date is necessary for positive 
         * identification of the patient in the jurisdictional client 
         * registry. However, there may be circumstances where the date 
         * of birth is not known to the registry.</p> <p>Used to 
         * confirm patient identity.</p><p>This element is 'populated' 
         * because the patient's birth date is necessary for positive 
         * identification of the patient in the jurisdictional client 
         * registry. However, there may be circumstances where the date 
         * of birth is not known to the registry.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"patientPerson/birthTime"})]
        public PlatformDate PatientPersonBirthTime {
            get { return this.patientPersonBirthTime.Value; }
            set { this.patientPersonBirthTime.Value = value; }
        }

    }

}