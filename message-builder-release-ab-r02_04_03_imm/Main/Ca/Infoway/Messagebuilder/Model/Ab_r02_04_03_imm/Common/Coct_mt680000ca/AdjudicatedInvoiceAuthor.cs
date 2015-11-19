/**
 * Copyright 2015 Canada Health Infoway, Inc.
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
namespace Ca.Infoway.Messagebuilder.Model.Ab_r02_04_03_imm.Common.Coct_mt680000ca {
    using Ca.Infoway.Messagebuilder.Annotation;
    using Ca.Infoway.Messagebuilder.Datatype;
    using Ca.Infoway.Messagebuilder.Datatype.Impl;
    using Ca.Infoway.Messagebuilder.Model;
    using System;


    [Hl7PartTypeMappingAttribute(new string[] {"COCT_MT680000CA.AdjudicatedInvoiceAuthor"})]
    public class AdjudicatedInvoiceAuthor : MessagePartBean {

        private ED<String> signatureText;
        private ST adjudicatorRolePlayingAdjudicatorDeviceSoftwareName;

        public AdjudicatedInvoiceAuthor() {
            this.signatureText = new EDImpl<String>();
            this.adjudicatorRolePlayingAdjudicatorDeviceSoftwareName = new STImpl();
        }
        /**
         * <summary>Business Name: EOB signature</summary>
         * 
         * <remarks>Relationship: 
         * COCT_MT680000CA.AdjudicatedInvoiceAuthor.signatureText 
         * Conformance/Cardinality: REQUIRED (0-1) <p>EOB signature</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"signatureText"})]
        public String SignatureText {
            get { return this.signatureText.Value; }
            set { this.signatureText.Value = value; }
        }

        /**
         * <summary>Business Name: Adjudicator Device Software Name</summary>
         * 
         * <remarks>Relationship: 
         * COCT_MT680000CA.AdjudicatorDevice.softwareName 
         * Conformance/Cardinality: MANDATORY (1) <p>(COB Source. Which 
         * s/w rules were used to create the COB CMET such as CPhA, 
         * NeCST. Use modifier for Invoice or PreDet</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"adjudicatorRole/playingAdjudicatorDevice/softwareName"})]
        public String AdjudicatorRolePlayingAdjudicatorDeviceSoftwareName {
            get { return this.adjudicatorRolePlayingAdjudicatorDeviceSoftwareName.Value; }
            set { this.adjudicatorRolePlayingAdjudicatorDeviceSoftwareName.Value = value; }
        }

    }

}