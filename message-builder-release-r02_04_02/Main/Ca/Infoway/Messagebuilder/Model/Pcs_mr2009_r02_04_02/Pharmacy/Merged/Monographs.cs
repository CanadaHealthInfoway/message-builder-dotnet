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
 * Last modified: $LastChangedDate: 2012-01-18 21:10:42 -0500 (Wed, 18 Jan 2012) $
 * Revision:      $LastChangedRevision: 3991 $
 */

/* This class was auto-generated by the message builder generator tools. */
namespace Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Pharmacy.Merged {
    using Ca.Infoway.Messagebuilder.Annotation;
    using Ca.Infoway.Messagebuilder.Datatype;
    using Ca.Infoway.Messagebuilder.Datatype.Impl;
    using Ca.Infoway.Messagebuilder.Datatype.Lang;
    using Ca.Infoway.Messagebuilder.Domainvalue;
    using Ca.Infoway.Messagebuilder.Model;
    using System;


    /**
     * <summary>POME_MT010040CA.Document: Monographs</summary>
     * 
     * <remarks><p>Information on the composition and use of a 
     * drug.</p> <p>Guides providers for specifying optimum use of 
     * drugs by patients. May also guide patients in appropriately 
     * using their medication.</p> PORR_MT050016CA.Document: 
     * Medication Documents <p>Information on the composition and 
     * use of a drug.</p> <p>Guides providers for specifying 
     * optimum use of drugs by patients. May also guide patients in 
     * appropriately using their medication.</p></remarks>
     */
    [Hl7PartTypeMappingAttribute(new string[] {"POME_MT010040CA.Document","PORR_MT050016CA.Document"})]
    public class Monographs : MessagePartBean {

        private II id;
        private CV code;
        private ED<EncapsulatedData> monographContent;
        private IVL<TS, Interval<PlatformDate>> effectiveTime;
        private CV writtenIn;
        private Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Pharmacy.Merged.AssignedEntity3 authorAssignedEntity;
        private ED<EncapsulatedData> medicationDocumentContentLanguage;

        public Monographs() {
            this.id = new IIImpl();
            this.code = new CVImpl();
            this.monographContent = new EDImpl<EncapsulatedData>();
            this.effectiveTime = new IVLImpl<TS, Interval<PlatformDate>>();
            this.writtenIn = new CVImpl();
            this.medicationDocumentContentLanguage = new EDImpl<EncapsulatedData>();
        }
        /**
         * <summary>B:Medication Document Id</summary>
         * 
         * <remarks><p>Unique identifier assigned to a medication 
         * document record.</p> <p>Allows matching and replacing of 
         * locally-stored medication documents.</p><p>This attribute is 
         * marked as 'mandatory', as it is always available.</p> 
         * <p>Allows matching and replacing of locally-stored 
         * medication documents.</p><p>This attribute is marked as 
         * 'mandatory', as it is always available.</p> Monograph Id 
         * <p>Unique identifier assigned to a monograph record.</p> 
         * <p>Allows matching and replacing of locally-stored 
         * monographs.</p><p>This attribute is marked as 'mandatory', 
         * as it is always available.</p> <p>Allows matching and 
         * replacing of locally-stored monographs.</p><p>This attribute 
         * is marked as 'mandatory', as it is always available.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"id"})]
        public Identifier Id {
            get { return this.id.Value; }
            set { this.id.Value = value; }
        }

        /**
         * <summary>Monograph Type</summary>
         * 
         * <remarks><p>Distinguishes between different kinds of 
         * documents and monographs. Kinds of monographs include: 
         * Clinical Monograph, Patient Education Monograph, etc.</p> 
         * <p>Allows monograph types to be distinguished for display, 
         * printing, etc.</p><p>Code is mandatory because an 
         * application can't know what to do with a monograph without 
         * knowing its type.</p> <p>Allows monograph types to be 
         * distinguished for display, printing, etc.</p><p>Code is 
         * mandatory because an application can't know what to do with 
         * a monograph without knowing its type.</p> A:Medication 
         * Document Type <p>Distinguishes between different kinds of 
         * documents and medication documents. Kinds of medication 
         * documents include: Clinical Medication document, Patient 
         * Education Medication document, Indication Protocol, etc</p> 
         * <p>Allows medication document types to be distinguished for 
         * display, printing, etc. Code is mandatory because an 
         * application can't know what to do with a medication document 
         * without knowing its type.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"code"})]
        public ActMedicationDocumentCode Code {
            get { return (ActMedicationDocumentCode) this.code.Value; }
            set { this.code.Value = value; }
        }

        /**
         * <summary>MonographContent</summary>
         * 
         * <remarks>Monograph Content <p>Includes either the full-blown 
         * content of the monograph (as a PDF, HTML or HL7 CDA 
         * document), or provides a reference to where the monograph 
         * can be accessed on the network via HTTP or FTP</p> <p>Allows 
         * delivery of the monograph information to the provider either 
         * embedded or by reference</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"text"})]
        public EncapsulatedData MonographContent {
            get { return this.monographContent.Value; }
            set { this.monographContent.Value = value; }
        }

        /**
         * <summary>C:Medication Document Effective/Expiry Date</summary>
         * 
         * <remarks><p>The date on which the information in the 
         * medication document became effective, and/or the date on 
         * which the information in the medication document was 
         * superseded.</p> <p>Indicates currency of information or when 
         * monograph no longer applies. Different systems may update 
         * their monographs at different times, and it is important to 
         * know what version contains the most current 
         * information</p><p>Monograph effective and/or expiry date 
         * should be available in most situations and is clinically 
         * relevant; thus attribute is marked as 'populated'.</p> 
         * <p>Indicates currency of information or when monograph no 
         * longer applies. Different systems may update their 
         * monographs at different times, and it is important to know 
         * what version contains the most current 
         * information</p><p>Monograph effective and/or expiry date 
         * should be available in most situations and is clinically 
         * relevant; thus attribute is marked as 'populated'.</p> 
         * Monograph Effective/Expiry Date <p>The date on which the 
         * information in the monograph became effective, and/or the 
         * date on which the information in the monograph was 
         * superseded</p> <p>Indicates currency of information or when 
         * monograph no longer applies. Different systems may update 
         * their monographs at different times, and it is important to 
         * know what version contains the most current 
         * information.</p><p>Monograph effective and/or expiry date 
         * should be available in most situations and is clinically 
         * relevant; thus attribute is marked as 'populated'.</p> 
         * <p>Indicates currency of information or when monograph no 
         * longer applies. Different systems may update their 
         * monographs at different times, and it is important to know 
         * what version contains the most current 
         * information.</p><p>Monograph effective and/or expiry date 
         * should be available in most situations and is clinically 
         * relevant; thus attribute is marked as 'populated'.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"effectiveTime"})]
        public Interval<PlatformDate> EffectiveTime {
            get { return this.effectiveTime.Value; }
            set { this.effectiveTime.Value = value; }
        }

        /**
         * <summary>WrittenIn</summary>
         * 
         * <remarks>Written in <p>A coded value denoting the language 
         * in which the monograph is written.</p> <p>Allows providers 
         * to request or display monographs in the language of their 
         * choice.</p><p>This attribute is marked as 'populated' 
         * because the language of the monograph must always be 
         * known/available or a null flavor must be specified.</p> 
         * <p>Allows providers to request or display monographs in the 
         * language of their choice.</p><p>This attribute is marked as 
         * 'populated' because the language of the monograph must 
         * always be known/available or a null flavor must be 
         * specified.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"languageCode"})]
        public HumanLanguage WrittenIn {
            get { return (HumanLanguage) this.writtenIn.Value; }
            set { this.writtenIn.Value = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"author/assignedEntity"})]
        public Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Pharmacy.Merged.AssignedEntity3 AuthorAssignedEntity {
            get { return this.authorAssignedEntity; }
            set { this.authorAssignedEntity = value; }
        }

        /**
         * <summary>MedicationDocumentContentLanguage</summary>
         * 
         * <remarks>F:Medication Document Content + Language 
         * <p>Includes either the full-blown content of the medication 
         * document (as a PDF, HTML or HL7 CDA document), or provides a 
         * reference to where the medication document can be accessed 
         * on the network via HTTP or FTP.</p><p>This attribute will 
         * also include a coded value denoting the language in which 
         * the medication document is written.</p> <p>Includes either 
         * the full-blown content of the medication document (as a PDF, 
         * HTML or HL7 CDA document), or provides a reference to where 
         * the medication document can be accessed on the network via 
         * HTTP or FTP.</p><p>This attribute will also include a coded 
         * value denoting the language in which the medication document 
         * is written.</p> <p>Allows delivery of the medication 
         * document information to the provider either embedded or by 
         * reference.</p><p>The inclusion of document language allows 
         * providers to determine what language the medication document 
         * is written in.</p><p>The attribute is mandatory because 
         * there is no point in having a medication document with no 
         * content.</p> <p>Allows delivery of the medication document 
         * information to the provider either embedded or by 
         * reference.</p><p>The inclusion of document language allows 
         * providers to determine what language the medication document 
         * is written in.</p><p>The attribute is mandatory because 
         * there is no point in having a medication document with no 
         * content.</p> <p>Allows delivery of the medication document 
         * information to the provider either embedded or by 
         * reference.</p><p>The inclusion of document language allows 
         * providers to determine what language the medication document 
         * is written in.</p><p>The attribute is mandatory because 
         * there is no point in having a medication document with no 
         * content.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"component/documentBodyEvent/text"})]
        public EncapsulatedData MedicationDocumentContentLanguage {
            get { return this.medicationDocumentContentLanguage.Value; }
            set { this.medicationDocumentContentLanguage.Value = value; }
        }

    }

}