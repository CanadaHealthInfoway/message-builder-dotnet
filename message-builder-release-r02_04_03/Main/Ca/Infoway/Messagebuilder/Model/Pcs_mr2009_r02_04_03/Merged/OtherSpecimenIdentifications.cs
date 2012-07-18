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
    using Ca.Infoway.Messagebuilder;
    using Ca.Infoway.Messagebuilder.Annotation;
    using Ca.Infoway.Messagebuilder.Datatype;
    using Ca.Infoway.Messagebuilder.Datatype.Impl;
    using Ca.Infoway.Messagebuilder.Datatype.Lang;
    using Ca.Infoway.Messagebuilder.Domainvalue;
    using Ca.Infoway.Messagebuilder.Model;
    using System;
    using System.Collections.Generic;


    /**
     * <summary>COCT_MT080100CA.IdentifiedEntity: Other Specimen 
     * Identifications</summary>
     * 
     * <remarks><p>Associated specimen identifiers.</p> <p>For 
     * referral and redirected orders, this information helps keep 
     * track of the different id's assigned during each phase of 
     * processing.</p> COCT_MT050007CA.IdentifiedEntity: Other 
     * Identifiers <p>This role object is used to store any other 
     * patient identification identifiers.</p> <p>Used for patient 
     * identification.</p> PRPA_MT101003CA.IdentifiedEntity: 
     * Identified Person <p>The IdentifiedEntity class is the entry 
     * point to the R-MIM and contains one or more identifiers (for 
     * example an &quot;internal&quot; id used only by computer 
     * systems and an &quot;external&quot; id for display to users) 
     * for the Person in the Client Registry. The statusCode is set 
     * to &quot;active&quot;. The beginning of the effectiveTime is 
     * when the record was added to the registry.</p> <p>Provides 
     * the message entry point required to add a person to the 
     * Client Registry</p></remarks>
     */
    [Hl7PartTypeMappingAttribute(new string[] {"COCT_MT050007CA.IdentifiedEntity","COCT_MT080100CA.IdentifiedEntity","PRPA_MT101003CA.IdentifiedEntity"})]
    public class OtherSpecimenIdentifications : MessagePartBean {

        private II id;
        private CV code;
        private Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Merged.ResponsibleOrganization assigningOrganization;
        private LIST<PN, PersonName> identifiedPersonName;
        private CV identifiedPersonAdministrativeGenderCode;
        private TS identifiedPersonBirthTime;

        public OtherSpecimenIdentifications() {
            this.id = new IIImpl();
            this.code = new CVImpl();
            this.identifiedPersonName = new LISTImpl<PN, PersonName>(typeof(PNImpl));
            this.identifiedPersonAdministrativeGenderCode = new CVImpl();
            this.identifiedPersonBirthTime = new TSImpl();
        }
        /**
         * <summary>Other Specimen Identifiers</summary>
         * 
         * <remarks><p>Associated specimen identifiers.</p> <p>For 
         * referral and redirected orders, this information helps keep 
         * track of the different id's assigned during each phase of 
         * processing.</p> K:Other Identifier <p>Alternate Identifiers 
         * for the Patient (e.g., Drivers License number, Health 
         * insurance number).</p> <p>Other identification numbers 
         * associated with identifying a patient.</p> Client Healthcare 
         * Identification Number <p>This identification attribute 
         * supports capture of a healthcare identifier specific to the 
         * client. This identifier may be assigned jurisdictionally or 
         * by care facility.</p> <p>Mandatory attribute supports unique 
         * identification of the client.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"id"})]
        public Identifier Id {
            get { return this.id.Value; }
            set { this.id.Value = value; }
        }

        /**
         * <summary>J:Other Identifier Type</summary>
         * 
         * <remarks><p>Describes the identification type (driver's 
         * license, etc.)</p> <p>Used to set the type of identier</p> 
         * Other Specimen Identifier Type <p>Describes the type of 
         * other specimen identifier (referral, primary, etc.)</p> 
         * <p>Categorized the type of role identifier.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"code"})]
        public Code Code {
            get { return (Code) this.code.Value; }
            set { this.code.Value = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"assigningOrganization"})]
        public Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Merged.ResponsibleOrganization AssigningOrganization {
            get { return this.assigningOrganization; }
            set { this.assigningOrganization = value; }
        }

        /**
         * <summary>ClientName</summary>
         * 
         * <remarks>Client Name <p>Name(s) for the Client</p> 
         * <p>Populated attribute supports the identification of the 
         * client</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"identifiedPerson/name"})]
        public IList<PersonName> IdentifiedPersonName {
            get { return this.identifiedPersonName.RawList(); }
        }

        /**
         * <summary>ClientGender</summary>
         * 
         * <remarks>Client Gender <p>Gender of the Client, this is not 
         * to be confused with Clinical Gender of a client. 
         * Administrative Gender is typically restricted to Male (M), 
         * Female (F) or Unknown (UN)</p> <p>Populated attribute 
         * supports the identification of the client</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"identifiedPerson/administrativeGenderCode"})]
        public AdministrativeGender IdentifiedPersonAdministrativeGenderCode {
            get { return (AdministrativeGender) this.identifiedPersonAdministrativeGenderCode.Value; }
            set { this.identifiedPersonAdministrativeGenderCode.Value = value; }
        }

        /**
         * <summary>ClientDateOfBirth</summary>
         * 
         * <remarks>Client Date of Birth <p>Date of birth of the 
         * Client</p> <p>Populated attribute supports the 
         * identification of the client</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"identifiedPerson/birthTime"})]
        public PlatformDate IdentifiedPersonBirthTime {
            get { return this.identifiedPersonBirthTime.Value; }
            set { this.identifiedPersonBirthTime.Value = value; }
        }

    }

}