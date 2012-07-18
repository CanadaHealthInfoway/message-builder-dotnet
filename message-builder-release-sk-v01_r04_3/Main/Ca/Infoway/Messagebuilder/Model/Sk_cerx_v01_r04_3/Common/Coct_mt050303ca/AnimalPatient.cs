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
namespace Ca.Infoway.Messagebuilder.Model.Sk_cerx_v01_r04_3.Common.Coct_mt050303ca {
    using Ca.Infoway.Messagebuilder.Annotation;
    using Ca.Infoway.Messagebuilder.Datatype;
    using Ca.Infoway.Messagebuilder.Datatype.Impl;
    using Ca.Infoway.Messagebuilder.Datatype.Lang;
    using Ca.Infoway.Messagebuilder.Model;
    using System;
    using System.Collections.Generic;


    /**
     * <summary>Animal Patient</summary>
     * 
     * <remarks><p>An animal that is receiving or may receive 
     * healthcare services.</p> <p>Used when animal services are 
     * attached to a human patient record. E.g. narcotics 
     * prescribed for a pet may be attached to the owner's record 
     * for monitoring of abuse.</p></remarks>
     */
    [Hl7PartTypeMappingAttribute(new string[] {"COCT_MT050303CA.Patient"})]
    public class AnimalPatient : MessagePartBean, Ca.Infoway.Messagebuilder.Model.Sk_cerx_v01_r04_3.Pharmacy.Merged.IPatient {

        private ST patientAnimalName;
        private AD patientAnimalContactPartyAddr;
        private SET<TEL, TelecommunicationAddress> patientAnimalContactPartyTelecom;
        private PN patientAnimalContactPartyContactPersonName;

        public AnimalPatient() {
            this.patientAnimalName = new STImpl();
            this.patientAnimalContactPartyAddr = new ADImpl();
            this.patientAnimalContactPartyTelecom = new SETImpl<TEL, TelecommunicationAddress>(typeof(TELImpl));
            this.patientAnimalContactPartyContactPersonName = new PNImpl();
        }
        /**
         * <summary>B:Animal name</summary>
         * 
         * <remarks><p>Name by which the animal patient is known.</p> 
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
         * (partType=Given)</p><p>Patie
         * ... [rest of documentation truncated due to excessive length]
         */
        [Hl7XmlMappingAttribute(new string[] {"patientAnimal/name"})]
        public String PatientAnimalName {
            get { return this.patientAnimalName.Value; }
            set { this.patientAnimalName.Value = value; }
        }

        /**
         * <summary>Owner address</summary>
         * 
         * <remarks><p>The mail and/or physical address associated with 
         * the owner or contact person for the animal.</p> <p>Used to 
         * contact the owner or contact person</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"patientAnimal/contactParty/addr"})]
        public PostalAddress PatientAnimalContactPartyAddr {
            get { return this.patientAnimalContactPartyAddr.Value; }
            set { this.patientAnimalContactPartyAddr.Value = value; }
        }

        /**
         * <summary>Owner Phones and Emails</summary>
         * 
         * <remarks><p>The phone number(s) and email address(s) by 
         * which the owner may be contacted.</p> <p>Used to contact the 
         * owner or contact person</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"patientAnimal/contactParty/telecom"})]
        public ICollection<TelecommunicationAddress> PatientAnimalContactPartyTelecom {
            get { return this.patientAnimalContactPartyTelecom.RawSet(); }
        }

        /**
         * <summary>Owner Name</summary>
         * 
         * <remarks><p>The name by which the owner person is known</p> 
         * <p>Used when contacting or addressing the owner person. 
         * Because this will be the principle means of identifying the 
         * owner person, it is mandatory.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"patientAnimal/contactParty/contactPerson/name"})]
        public PersonName PatientAnimalContactPartyContactPersonName {
            get { return this.patientAnimalContactPartyContactPersonName.Value; }
            set { this.patientAnimalContactPartyContactPersonName.Value = value; }
        }

    }

}