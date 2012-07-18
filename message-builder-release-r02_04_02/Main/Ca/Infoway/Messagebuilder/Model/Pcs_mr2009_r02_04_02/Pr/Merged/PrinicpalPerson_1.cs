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
 * Last modified: $LastChangedDate: 2012-01-18 21:12:19 -0500 (Wed, 18 Jan 2012) $
 * Revision:      $LastChangedRevision: 4014 $
 */

/* This class was auto-generated by the message builder generator tools. */
namespace Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Pr.Merged {
    using Ca.Infoway.Messagebuilder.Annotation;
    using Ca.Infoway.Messagebuilder.Datatype;
    using Ca.Infoway.Messagebuilder.Datatype.Impl;
    using Ca.Infoway.Messagebuilder.Datatype.Lang;
    using Ca.Infoway.Messagebuilder.Domainvalue;
    using Ca.Infoway.Messagebuilder.Model;
    using Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Merged;
    using System;
    using System.Collections.Generic;


    /**
     * <summary>PrinicpalPerson</summary>
     * 
     * <remarks>PRPM_MT303010CA.PrincipalPerson: Prinicpal Person 
     * <p>Identification of playing entity is required (0..1) to 
     * support the case in which information directly related to 
     * the playing party is not needed.</p> <p>Provides additional 
     * information about the person playing the role of Healthcare 
     * Provider</p> PRPM_MT301010CA.PrincipalPerson: Prinicpal 
     * Person <p>Identification of playing entity is required 
     * (0..1) to support the case in which information directly 
     * related to the playing party is not needed.</p> <p>Provides 
     * additional information about the person playing the role of 
     * Healthcare Provider</p></remarks>
     */
    [Hl7PartTypeMappingAttribute(new string[] {"PRPM_MT301010CA.PrincipalPerson","PRPM_MT303010CA.PrincipalPerson"})]
    public class PrinicpalPerson_1 : MessagePartBean {

        private II principalPersonAggregateIdentifier;
        private LIST<PN, PersonName> principalPersonName;
        private CV principalPersonGender;
        private TS principalPersonDateOfBirth;
        private BL principalPersonDeceasedIndicator;
        private TS principalPersonDeceasedDate;
        private AD birthplaceAddress;
        private IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Merged.LanguageCommunication> languageCommunication;

        public PrinicpalPerson_1() {
            this.principalPersonAggregateIdentifier = new IIImpl();
            this.principalPersonName = new LISTImpl<PN, PersonName>(typeof(PNImpl));
            this.principalPersonGender = new CVImpl();
            this.principalPersonDateOfBirth = new TSImpl();
            this.principalPersonDeceasedIndicator = new BLImpl();
            this.principalPersonDeceasedDate = new TSImpl();
            this.birthplaceAddress = new ADImpl();
            this.languageCommunication = new List<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Merged.LanguageCommunication>();
        }
        /**
         * <summary>PrincipalPersonAggregateIdentifier</summary>
         * 
         * <remarks>Principal Person Aggregate Identifier <p>A unique 
         * identifier for the person who may play various healthcare 
         * provider roles. This identifier is specific to the person 
         * not their roles.</p> <p>Required attribute supports the 
         * identification of the healthcare provider</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"id"})]
        public Identifier PrincipalPersonAggregateIdentifier {
            get { return this.principalPersonAggregateIdentifier.Value; }
            set { this.principalPersonAggregateIdentifier.Value = value; }
        }

        /**
         * <summary>PrincipalPersonName</summary>
         * 
         * <remarks>Principal Person Name <p>The persons name 
         * independent of any role they may play.</p> <p>Required 
         * attribute supports the identification of the healthcare 
         * provider</p> <p>If Principal Person is included in the 
         * message, then Person Name Must Exist.</p> Principal Person 
         * Name <p>The persons name independent of any role they may 
         * play.</p> <p>13, STF:3; ROL:4:2-7,10,16,21</p> <p>Required 
         * attribute supports the identification of the healthcare 
         * provider</p> <p>If Principal Person is included in the 
         * message, then Prinicpal Person Name Must Exist.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"name"})]
        public IList<PersonName> PrincipalPersonName {
            get { return this.principalPersonName.RawList(); }
        }

        /**
         * <summary>PrincipalPersonGender</summary>
         * 
         * <remarks>Principal Person Gender <p>The principal persons 
         * gender.</p> <p>STF.5</p> <p>Mandatory attribute supports the 
         * identification of the healthcare provider</p> <p>If 
         * Principal Person is included in the message, then Person 
         * Gender is Expected to Exist.</p> Principal Person Gender 
         * <p>The principal persons gender.</p> <p>Mandatory attribute 
         * supports the identification of the healthcare provider</p> 
         * <p>If Principal Person is included in the message, then 
         * Person Gender is Expected to Exist.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"administrativeGenderCode"})]
        public AdministrativeGender PrincipalPersonGender {
            get { return (AdministrativeGender) this.principalPersonGender.Value; }
            set { this.principalPersonGender.Value = value; }
        }

        /**
         * <summary>PrincipalPersonDateOfBirth</summary>
         * 
         * <remarks>Principal Person Date of Birth <p>The principal 
         * persons date of birth.</p> <p>Populated attribute supports 
         * the identification of the healthcare provider</p> <p>If 
         * Principal Person is included in the message, then Prinicpal 
         * Person Date of Birth is Expected to Exist.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"birthTime"})]
        public PlatformDate PrincipalPersonDateOfBirth {
            get { return this.principalPersonDateOfBirth.Value; }
            set { this.principalPersonDateOfBirth.Value = value; }
        }

        /**
         * <summary>PrincipalPersonDeceasedIndicator</summary>
         * 
         * <remarks>Principal Person Deceased Indicator <p>An 
         * indication that the principal person is deceased.</p> 
         * <p>Required attribute supports the identification of the 
         * healthcare provider</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"deceasedInd"})]
        public bool? PrincipalPersonDeceasedIndicator {
            get { return this.principalPersonDeceasedIndicator.Value; }
            set { this.principalPersonDeceasedIndicator.Value = value; }
        }

        /**
         * <summary>PrincipalPersonDeceasedDate</summary>
         * 
         * <remarks>Principal Person Deceased Date <p>The date and time 
         * that a healthcare provider's death occurred.</p> 
         * <p>Attribute supports verification of death from official 
         * source such as Vital Statistics.</p><p>Optional attribute in 
         * order to meet jurisdictional legislation which does not 
         * allow the sharing of this information.</p> <p>Attribute 
         * supports verification of death from official source such as 
         * Vital Statistics.</p><p>Optional attribute in order to meet 
         * jurisdictional legislation which does not allow the sharing 
         * of this information.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"deceasedTime"})]
        public PlatformDate PrincipalPersonDeceasedDate {
            get { return this.principalPersonDeceasedDate.Value; }
            set { this.principalPersonDeceasedDate.Value = value; }
        }

        /**
         * <summary>BirthplaceAddress</summary>
         * 
         * <remarks>Birthplace Address <p>Principal person's address at 
         * time of birth</p> <p>Mandatory attribute supports the 
         * identification of the healthcare provider</p> <p>If 
         * Birthplace is included in the message, then Address is 
         * Expected to Exist.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"birthplace/addr"})]
        public PostalAddress BirthplaceAddress {
            get { return this.birthplaceAddress.Value; }
            set { this.birthplaceAddress.Value = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"languageCommunication"})]
        public IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Merged.LanguageCommunication> LanguageCommunication {
            get { return this.languageCommunication; }
        }

    }

}