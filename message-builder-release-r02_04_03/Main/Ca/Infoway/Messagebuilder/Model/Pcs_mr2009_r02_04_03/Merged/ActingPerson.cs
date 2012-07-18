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
namespace Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Merged {
    using Ca.Infoway.Messagebuilder.Annotation;
    using Ca.Infoway.Messagebuilder.Datatype;
    using Ca.Infoway.Messagebuilder.Datatype.Impl;
    using Ca.Infoway.Messagebuilder.Datatype.Lang;
    using Ca.Infoway.Messagebuilder.Domainvalue;
    using Ca.Infoway.Messagebuilder.Model;
    using System;
    using System.Collections.Generic;


    /**
     * <summary>ActingPerson</summary>
     * 
     * <remarks>COCT_MT090102CA.Person: Acting Person <p>Describes 
     * the person actually involved in the action.</p> <p>Even when 
     * an organization is taking responsibility, a person is 
     * generally involved in the work.</p></remarks>
     */
    [Hl7PartTypeMappingAttribute(new string[] {"COCT_MT050007CA.Person","COCT_MT050202CA.Person","COCT_MT050207CA.Person","COCT_MT050208CA.Person","COCT_MT090102CA.Person","COCT_MT090108CA.Person","COCT_MT910108CA.Person","POIZ_MT030050CA.Person","POIZ_MT030060CA.Person","POIZ_MT060150CA.Person"})]
    public class ActingPerson : MessagePartBean {

        private PN name;
        private CV administrativeGenderCode;
        private TS birthTime;
        private II asHealthCareProviderId;
        private SET<TEL, TelecommunicationAddress> telecom;
        private AD addr;
        private BL deceasedInd;
        private TS deceasedTime;
        private IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Merged.OtherSpecimenIdentifications> asIdentifiedEntity;

        public ActingPerson() {
            this.name = new PNImpl();
            this.administrativeGenderCode = new CVImpl();
            this.birthTime = new TSImpl();
            this.asHealthCareProviderId = new IIImpl();
            this.telecom = new SETImpl<TEL, TelecommunicationAddress>(typeof(TELImpl));
            this.addr = new ADImpl();
            this.deceasedInd = new BLImpl();
            this.deceasedTime = new TSImpl();
            this.asIdentifiedEntity = new List<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Merged.OtherSpecimenIdentifications>();
        }
        /**
         * <summary>B:Patient Name</summary>
         * 
         * <remarks><p>The name by which the patient is known and which 
         * apply to a particular clinical action that has been reported 
         * or recorded.</p> <p>Used, with other patient identity 
         * attributes, to confirm patient identity, as well as when 
         * addressing the patient. Element is populated because the 
         * patient's name is frequently necessary for positive 
         * identification of the patient in the jurisdictional client 
         * registry.</p> B:Patient Name <p>The name by which the 
         * patient is known.</p> <p>ZPA.1 (partType=Given)</p><p>ZPA.2 
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
         * Initials</p><p>PID.5</p><p>Patient.310-CA 
         * (partType=Given)</p><p>Patient.311-CB 
         * (partType=Family)</p><p>Recipient Name First 
         * (partType=Given)</p><p>Recipient Name Last 
         * (partType=Family)</p><p>PID.5</p><p>PID.9 (any name other 
         * than first repetition is an 
         * alias)</p><p>ZDU.3</p><p>ZKW.2</p><p>Person.givenName</p><p>Person.lastName</p><p>Person.middleName</p><p>Person.namePrefix</p><p>Person.nameSuffix</p> 
         * <p>ZPA.1 (partType=Given)</p><p>ZPA.2 
         * (partType=Family)</p><p>ZPA.3 (partType=Given - all
         * ... [rest of documentation truncated due to excessive length]
         */
        [Hl7XmlMappingAttribute(new string[] {"name"})]
        public PersonName Name {
            get { return this.name.Value; }
            set { this.name.Value = value; }
        }

        /**
         * <summary>PatientGender</summary>
         * 
         * <remarks>F:Patient Gender <p>Indicates the gender (sex) of 
         * the patient as known by the client registry. Complex genetic 
         * genders are handled as observations if they are considered 
         * relevant.</p> <p>C40 
         * eScript:PTT.040</p><p>3</p><p>Sex</p><p>PID.8</p><p>Patient.305-C5</p><p>PID.8</p> 
         * <p>C40 
         * eScript:PTT.040</p><p>3</p><p>Sex</p><p>PID.8</p><p>Patient.305-C5</p><p>PID.8</p> 
         * <p>C40 
         * eScript:PTT.040</p><p>3</p><p>Sex</p><p>PID.8</p><p>Patient.305-C5</p><p>PID.8</p> 
         * <p>C40 
         * eScript:PTT.040</p><p>3</p><p>Sex</p><p>PID.8</p><p>Patient.305-C5</p><p>PID.8</p> 
         * <p>C40 
         * eScript:PTT.040</p><p>3</p><p>Sex</p><p>PID.8</p><p>Patient.305-C5</p><p>PID.8</p> 
         * <p>C40 
         * eScript:PTT.040</p><p>3</p><p>Sex</p><p>PID.8</p><p>Patient.305-C5</p><p>PID.8</p> 
         * <p>Used to confirm patient identity. May affect clinical 
         * decision support such as drug dosing, lab test 
         * appropriateness, etc.</p><p>The element is 'populated' 
         * because there are some situations where the patient's gender 
         * may not be known by the sending system when dealing with 
         * non-client registry patients.</p> <p>Used to confirm patient 
         * identity. May affect clinical decision support such as drug 
         * dosing, lab test appropriateness, etc.</p><p>The element is 
         * 'populated' because there are some situations where the 
         * patient's gender may not be known by the sending system when 
         * dealing with non-client registry patients.</p> F:Patient 
         * Gender <p>Indicates the gender (sex) of the patient as known 
         * by the client registry. Complex genetic genders are handled 
         * as observations if they are considered relevant.</p> <p>Used 
         * to confirm patient identity.</p><p>The element is mandatory 
         * because the patient's gender is necessary for positive 
         * identification of the patient in the jurisdictional client 
         * registry and should always be known.</p> <p>Used to confirm 
         * patient identity.</p><p>The element is mandatory because the 
         * patient's gender is necessary for positive identification of 
         * the patient in the jurisdictional client registry and should 
         * always be known.</p> F:Patient Gender <p>Indicates the 
         * gender (sex) of the patient as known by the client registry. 
         * Complex genetic genders are handled as observations if they 
         * are considered relevant.</p> <p>C40 
         * eScript:PTT.040</p><p>3</p><p>Sex</p><p>PID.8</p><p>Patient.305-C5</p><p>PID.8</p> 
         * <p>C40 
         * eScript:PTT.040</p><p>3</p><p>Sex</p><p>PID.8</p><p>Patient.305-C5</p><p>PID.8</p> 
         * <p>C40 
         * eScript:PTT.040</p><p>3</p><p>Sex</p><p>PID.8</p><p>Patient.305-C5</p><p>PID.8</p> 
         * <p>C40 
         * eScript:PTT.040</p><p>3</p><p>Sex</p><p>PID.8</p><p>Patient.305-C5</p><p>PID.8</p> 
         * <p>C40 
         * eScript:PTT.040</p><p>3</p><p>Sex</p><p>PID.8</p><p>Patient.305-C5</p><p>PID.8</p> 
         * <p>C40 
         * eScript:PTT.040</p><p>3</p><p>Sex</p><p>PID.8</p><p>Patient.305-C5</p><p>PID.8</p> 
         * <p>Used to confirm patient identity. May affect clinical 
         * decision support such as drug dosing, lab test 
         * appropriateness, etc.</p><p>Element is mandatory because the 
         * patient's gender is necessary for positive identification of 
         * the patient in the jurisdictional client registry and should 
         * always be known.</p> <p>Used to confirm patient identity. 
         * May affect clinical decision support such as drug dosing, 
         * lab test appropriateness, etc.</p><p>Element is mandatory 
         * because the patient's gender is necessary for positive 
         * identification of the patient in the jurisdictional client 
         * registry and should always be known.</p> D:Patient Gender 
         * <p>Indicates the gender (sex) of the patient. Complex 
         * genetic genders are handled as observations if they are 
         * considered relevant.</p> <p>Used to confirm patient 
         * identity.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"administrativeGenderCode"})]
        public AdministrativeGender AdministrativeGenderCode {
            get { return (AdministrativeGender) this.administrativeGenderCode.Value; }
            set { this.administrativeGenderCode.Value = value; }
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
         * of birth is not known to the registry.</p> C: Patient Birth 
         * Datetime <p>Indicates the date on which the patient was 
         * born.</p> <p>Used to confirm patient identity.</p> E:Patient 
         * Birth Date <p>Indicates the date on which the patient was 
         * born as known by the client registry.</p> 
         * <p>C34</p><p>PTT.020</p><p>A.2b</p><p>HC-SA</p><p>PID.7</p><p>patient.304-C4</p><p>PID.7</p> 
         * <p>C34</p><p>PTT.020</p><p>A.2b</p><p>HC-SA</p><p>PID.7</p><p>patient.304-C4</p><p>PID.7</p> 
         * <p>C34</p><p>PTT.020</p><p>A.2b</p><p>HC-SA</p><p>PID.7</p><p>patient.304-C4</p><p>PID.7</p> 
         * <p>C34</p><p>PTT.020</p><p>A.2b</p><p>HC-SA</p><p>PID.7</p><p>patient.304-C4</p><p>PID.7</p> 
         * <p>C34</p><p>PTT.020</p><p>A.2b</p><p>HC-SA</p><p>PID.7</p><p>patient.304-C4</p><p>PID.7</p> 
         * <p>C34</p><p>PTT.020</p><p>A.2b</p><p>HC-SA</p><p>PID.7</p><p>patient.304-C4</p><p>PID.7</p> 
         * <p>C34</p><p>PTT.020</p><p>A.2b</p><p>HC-SA</p><p>PID.7</p><p>patient.304-C4</p><p>PID.7</p> 
         * <p>Used to confirm patient identity.</p><p>May also 
         * influence clinical decision support such as dosage and 
         * therapy appropriateness.</p><p>The element is populated 
         * because the patient's birth date is necessary for positive 
         * identification of the patient in the jurisdictional client 
         * registry. However, in some cases the date of birth may not 
         * be known to the client registry</p> <p>Used to confirm 
         * patient identity.</p><p>May also influence clinical decision 
         * support such as dosage and therapy 
         * appropriateness.</p><p>The element is populated because the 
         * patient's birth date is necessary for positive 
         * identification of the patient in the jurisdictional client 
         * registry. However, in some cases the date of birth may not 
         * be known to the client registry</p> <p>Used to confirm 
         * patient identity.</p><p>May also influence clinical decision 
         * support such as dosage and therapy 
         * appropriateness.</p><p>The element is populated because the 
         * patient's birth date is necessary for positive 
         * identification of the patient in the jurisdictional client 
         * registry. However, in some cases the date of birth may not 
         * be known to the client registry</p> E:Patient Birth Date 
         * <p>Indicates the date on which the patient was born as known 
         * by the client registry.</p> 
         * <p>C34</p><p>PTT.020</p><p>A.2b</p><p>HC-SA</p><p>PID.7</p><p>patient.304-C4</p><p>PID.7</p> 
         * <p>C34</p><p>PTT.020</p><p>A.2b</p><p>HC-SA</p><p>PID.7</p><p>patient.304-C4</p><p>PID.7</p> 
         * <p>C34</p><p>PTT.020</p><p>A.2b</p><p>HC-SA</p><p>PID.7</p><p>patient.304-C4</p><p>PID.7</p> 
         * <p>C34</p><p>PTT.020</p><p>A.2b</p><p>HC-SA</p><p>PID.7</p><p>patient.304-C4</p><p>PID.7</p> 
         * <p>C34</p><p>PTT.020</p><p>A.2b</p><p>HC-SA</p><p>PID.7</p><p>patient.304-C4</p><p>PID.7</p> 
         * <p>C34</p><p>PTT.020</p><p>A.2b</p><p>HC-SA</p><p>PID.7</p><p>patient.304-C4</p><p>PID.7</p> 
         * <p>C34</p><p>PTT.020</p><p>A.2b</p><p>HC-SA</p><p>PID.7</p><p>patient.304-C4</p><p>PID.7</p> 
         * <p>Used to confirm patient identity.</p><p>May also 
         * influence clinical decision support such as dosage and 
         * therapy appropriateness.</p><p>The element is populated 
         * because the patient's birth date may not be known, 
         * particularly for patients not found in the client 
         * registry.</p> <p>Used to confirm patient identity.</p><p>May 
         * also influence clinical decision support such as dosage and 
         * therapy appropriateness.</p><p>The element is populated 
         * because the patient's birth date may not be known, 
         * particularly for patients not found in the client 
         * registry.</p> <p>Used to confirm patient identity.</p><p>May 
         * also influence clinical decision support such as dosage and 
         * therapy appropriateness.</p><p>The element is populated 
         * because the patient's birth date may not be known, 
         * particularly for patients not found in the client 
         * registry.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"birthTime"})]
        public PlatformDate BirthTime {
            get { return this.birthTime.Value; }
            set { this.birthTime.Value = value; }
        }

        /**
         * <summary>LicenseNumber</summary>
         * 
         * <remarks>D: License Number <p>The license number issued to 
         * the provider and relevant to the current action.</p> 
         * <p>Allows lookup on college website, confirmation of 
         * identity, etc. Regulations occasionally require license 
         * numbers to be specified as part of clinical records.</p> 
         * <p>If the identifier used in the root of AssignedEntity 
         * class is the same as the license number, the license number 
         * should be sent in both places.</p><p>Detailed information 
         * about the status and effective period of licenses must be 
         * retrieved from the provider registry.</p> <p>If the 
         * identifier used in the root of AssignedEntity class is the 
         * same as the license number, the license number should be 
         * sent in both places.</p><p>Detailed information about the 
         * status and effective period of licenses must be retrieved 
         * from the provider registry.</p> C: License Number <p>The 
         * license number issued to the provider and relevant to the 
         * current action.</p> <p>Allows lookup on college website, 
         * confirmation of identity, etc. Regulations occasionally 
         * require license numbers to be specified as part of clinical 
         * records.</p> <p>If the identifier used in the root of the 
         * CMET is the same as the license number, the license number 
         * should be sent in both places.</p> D: License Number <p>The 
         * license number issued to the provider and relevant to the 
         * current action.</p> <p>Allows lookup on college website, 
         * confirmation of identity, etc. Regulations occasionally 
         * require license numbers to be specified as part of clinical 
         * records.</p> <p>If the identifier used in the root of the 
         * CMET is the same as the license number, the license number 
         * should be sent in both places.</p><p>Detailed information 
         * about the status and effective period of licenses must be 
         * retrieved from the provider registry.</p> <p>If the 
         * identifier used in the root of the CMET is the same as the 
         * license number, the license number should be sent in both 
         * places.</p><p>Detailed information about the status and 
         * effective period of licenses must be retrieved from the 
         * provider registry.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"asHealthCareProvider/id"})]
        public Identifier AsHealthCareProviderId {
            get { return this.asHealthCareProviderId.Value; }
            set { this.asHealthCareProviderId.Value = value; }
        }

        /**
         * <summary>RelatedPersonPhonesAndEmails</summary>
         * 
         * <remarks>E:Related Person Phones and Emails <p>The phone 
         * number(s) and email address(s) by which a related person may 
         * be contacted as known by the client registry.</p> <p>Used to 
         * contact the related person.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"telecom"})]
        public ICollection<TelecommunicationAddress> Telecom {
            get { return this.telecom.RawSet(); }
        }

        /**
         * <summary>RelatedPersonAddress</summary>
         * 
         * <remarks>D:Related Person Address <p>The mail and/or 
         * physical address associated with a related person as known 
         * by the client registry.</p> <p>Used to contact the related 
         * person.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"addr"})]
        public PostalAddress Addr {
            get { return this.addr.Value; }
            set { this.addr.Value = value; }
        }

        /**
         * <summary>PatientDeceasedIndicator</summary>
         * 
         * <remarks>G:Patient Deceased Indicator <p>Indicates whether 
         * the patient is deceased.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"deceasedInd"})]
        public bool? DeceasedInd {
            get { return this.deceasedInd.Value; }
            set { this.deceasedInd.Value = value; }
        }

        /**
         * <summary>PatientDeceasedDatetime</summary>
         * 
         * <remarks>H:Patient Deceased Datetime <p>The date/time the 
         * patient died or was ruled &quot;deceased.&quot;</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"deceasedTime"})]
        public PlatformDate DeceasedTime {
            get { return this.deceasedTime.Value; }
            set { this.deceasedTime.Value = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"asIdentifiedEntity"})]
        public IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Merged.OtherSpecimenIdentifications> AsIdentifiedEntity {
            get { return this.asIdentifiedEntity; }
        }

    }

}