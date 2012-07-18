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
namespace Ca.Infoway.Messagebuilder.Model.Ab_mr2007_v02_r02.Pharmacy.Pome_mt010040ca {
    using Ca.Infoway.Messagebuilder.Annotation;
    using Ca.Infoway.Messagebuilder.Model;
    using Ca.Infoway.Messagebuilder.Model.Ab_mr2007_v02_r02.Pharmacy.Merged;
    using System.Collections.Generic;


    /**
     * <summary>Medication</summary>
     * 
     * <remarks><p>Represents a particular medicine or herbal 
     * product which might be prescribed or administered.</p> 
     * <p>Allows retrieval of details about a product at a 
     * particular level of granularity (therapeutic class, generic, 
     * manufactured, etc.)</p></remarks>
     */
    [Hl7PartTypeMappingAttribute(new string[] {"POME_MT010040CA.Medication"})]
    public class Medication : MessagePartBean {

        private Ca.Infoway.Messagebuilder.Model.Ab_mr2007_v02_r02.Pharmacy.Pome_mt010040ca.DrugOrCompound player;
        private IList<Ca.Infoway.Messagebuilder.Model.Ab_mr2007_v02_r02.Pharmacy.Merged.Monographs> subjectOf1Document;
        private Ca.Infoway.Messagebuilder.Model.Ab_mr2007_v02_r02.Pharmacy.Pome_mt010040ca.DrugHalfLife subjectOf2HalfLife;
        private IList<Ca.Infoway.Messagebuilder.Model.Ab_mr2007_v02_r02.Pharmacy.Merged.AppearanceCharacteristics> subjectOf3Characteristic;
        private IList<Ca.Infoway.Messagebuilder.Model.Ab_mr2007_v02_r02.Pharmacy.Pome_mt010040ca.MonitoringPrograms> subjectOf4MonitoringProgram;
        private Ca.Infoway.Messagebuilder.Model.Ab_mr2007_v02_r02.Pharmacy.Merged.DrugCost subjectOf5PotentialCharge;
        private IList<Ca.Infoway.Messagebuilder.Model.Ab_mr2007_v02_r02.Pharmacy.Pome_mt010040ca.RecommendedAdministrationInstructions> consumedInAdministrationGuideline;
        private Ca.Infoway.Messagebuilder.Model.Ab_mr2007_v02_r02.Pharmacy.Pome_mt010040ca.DispenseInformation productOf1DispenseGuidelines;
        private IList<Ca.Infoway.Messagebuilder.Model.Ab_mr2007_v02_r02.Pharmacy.Pome_mt010040ca.Formularies> productOf2PotentialSupply;

        public Medication() {
            this.subjectOf1Document = new List<Ca.Infoway.Messagebuilder.Model.Ab_mr2007_v02_r02.Pharmacy.Merged.Monographs>();
            this.subjectOf3Characteristic = new List<Ca.Infoway.Messagebuilder.Model.Ab_mr2007_v02_r02.Pharmacy.Merged.AppearanceCharacteristics>();
            this.subjectOf4MonitoringProgram = new List<Ca.Infoway.Messagebuilder.Model.Ab_mr2007_v02_r02.Pharmacy.Pome_mt010040ca.MonitoringPrograms>();
            this.consumedInAdministrationGuideline = new List<Ca.Infoway.Messagebuilder.Model.Ab_mr2007_v02_r02.Pharmacy.Pome_mt010040ca.RecommendedAdministrationInstructions>();
            this.productOf2PotentialSupply = new List<Ca.Infoway.Messagebuilder.Model.Ab_mr2007_v02_r02.Pharmacy.Pome_mt010040ca.Formularies>();
        }
        [Hl7XmlMappingAttribute(new string[] {"player"})]
        public Ca.Infoway.Messagebuilder.Model.Ab_mr2007_v02_r02.Pharmacy.Pome_mt010040ca.DrugOrCompound Player {
            get { return this.player; }
            set { this.player = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"subjectOf1/document"})]
        public IList<Ca.Infoway.Messagebuilder.Model.Ab_mr2007_v02_r02.Pharmacy.Merged.Monographs> SubjectOf1Document {
            get { return this.subjectOf1Document; }
        }

        [Hl7XmlMappingAttribute(new string[] {"subjectOf2/halfLife"})]
        public Ca.Infoway.Messagebuilder.Model.Ab_mr2007_v02_r02.Pharmacy.Pome_mt010040ca.DrugHalfLife SubjectOf2HalfLife {
            get { return this.subjectOf2HalfLife; }
            set { this.subjectOf2HalfLife = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"subjectOf3/characteristic"})]
        public IList<Ca.Infoway.Messagebuilder.Model.Ab_mr2007_v02_r02.Pharmacy.Merged.AppearanceCharacteristics> SubjectOf3Characteristic {
            get { return this.subjectOf3Characteristic; }
        }

        [Hl7XmlMappingAttribute(new string[] {"subjectOf4/monitoringProgram"})]
        public IList<Ca.Infoway.Messagebuilder.Model.Ab_mr2007_v02_r02.Pharmacy.Pome_mt010040ca.MonitoringPrograms> SubjectOf4MonitoringProgram {
            get { return this.subjectOf4MonitoringProgram; }
        }

        [Hl7XmlMappingAttribute(new string[] {"subjectOf5/potentialCharge"})]
        public Ca.Infoway.Messagebuilder.Model.Ab_mr2007_v02_r02.Pharmacy.Merged.DrugCost SubjectOf5PotentialCharge {
            get { return this.subjectOf5PotentialCharge; }
            set { this.subjectOf5PotentialCharge = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"consumedIn/administrationGuideline"})]
        public IList<Ca.Infoway.Messagebuilder.Model.Ab_mr2007_v02_r02.Pharmacy.Pome_mt010040ca.RecommendedAdministrationInstructions> ConsumedInAdministrationGuideline {
            get { return this.consumedInAdministrationGuideline; }
        }

        [Hl7XmlMappingAttribute(new string[] {"productOf1/dispenseGuidelines"})]
        public Ca.Infoway.Messagebuilder.Model.Ab_mr2007_v02_r02.Pharmacy.Pome_mt010040ca.DispenseInformation ProductOf1DispenseGuidelines {
            get { return this.productOf1DispenseGuidelines; }
            set { this.productOf1DispenseGuidelines = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"productOf2/potentialSupply"})]
        public IList<Ca.Infoway.Messagebuilder.Model.Ab_mr2007_v02_r02.Pharmacy.Pome_mt010040ca.Formularies> ProductOf2PotentialSupply {
            get { return this.productOf2PotentialSupply; }
        }

    }

}