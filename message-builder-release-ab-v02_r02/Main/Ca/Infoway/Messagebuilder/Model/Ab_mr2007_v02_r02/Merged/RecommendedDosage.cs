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
namespace Ca.Infoway.Messagebuilder.Model.Ab_mr2007_v02_r02.Merged {
    using Ca.Infoway.Messagebuilder.Annotation;
    using Ca.Infoway.Messagebuilder.Datatype;
    using Ca.Infoway.Messagebuilder.Datatype.Impl;
    using Ca.Infoway.Messagebuilder.Datatype.Lang;
    using Ca.Infoway.Messagebuilder.Model;
    using System;
    using System.Collections.Generic;


    /**
     * <summary>RecommendedDosage</summary>
     * 
     * <remarks>COCT_MT260030CA.SubstanceAdministrationEventCriterion: 
     * Recommended Dosage <p>Identifies the outer dosage boundaries 
     * that were exceeded and triggered the issue. Included in this 
     * information are the drug-specific recommended dosage ranges 
     * for various age groups and weight classes.</p> <p>Provides a 
     * reference for calculating optimum dose of medication for 
     * patients.</p> 
     * COCT_MT260010CA.SubstanceAdministrationEventCriterion: 
     * Recommended Dosage <p>Identifies the outer dosage boundaries 
     * that were exceeded and triggered the issue. Included in this 
     * information are the drug-specific recommended dosage ranges 
     * for various age groups and weight classes.</p> <p>Provides a 
     * reference for calculating optimum dose of medication for 
     * patients.</p> 
     * PORX_MT980030CA.SubstanceAdministrationEventCriterion: 
     * Recommended Dosage <p>Identifies the outer dosage boundaries 
     * that were exceeded and triggered the issue. Included in this 
     * information are the drug-specific recommended dosage ranges 
     * for various age groups and weight classes.</p> <p>Provides a 
     * reference for calculating optimum dose of medication for 
     * patients.</p> 
     * PORX_MT980020CA.SubstanceAdministrationEventCriterion: 
     * Recommended Dosage <p>Identifies the outer dosage boundaries 
     * that were exceeded and triggered the issue. Included in this 
     * information are the drug-specific recommended dosage ranges 
     * for various age groups, weight classes, etc.</p> <p>Provides 
     * a reference for calculating optimum dose of medication for 
     * patients.</p> 
     * PORX_MT980010CA.SubstanceAdministrationEventCriterion: 
     * Recommended Dosage <p>Identifies the outer dosage boundaries 
     * that were exceeded and triggered the issue. Included in this 
     * information are the drug-specific recommended dosage ranges 
     * for various age groups and weight classes.</p> <p>Provides a 
     * reference for calculating optimum dose of medication for 
     * patients.</p> 
     * COCT_MT260020CA.SubstanceAdministrationEventCriterion: 
     * Recommended Dosage <p>Identifies the outer dosage boundaries 
     * that were exceeded and triggered the issue. Included in this 
     * information are the drug-specific recommended dosage ranges 
     * for various age groups, weight classes, etc.</p> <p>Provides 
     * a reference for calculating optimum dose of medication for 
     * patients.</p></remarks>
     */
    [Hl7PartTypeMappingAttribute(new string[] {"COCT_MT260010CA.SubstanceAdministrationEventCriterion","COCT_MT260020CA.SubstanceAdministrationEventCriterion","COCT_MT260030CA.SubstanceAdministrationEventCriterion","PORX_MT980010CA.SubstanceAdministrationEventCriterion","PORX_MT980020CA.SubstanceAdministrationEventCriterion","PORX_MT980030CA.SubstanceAdministrationEventCriterion"})]
    public class RecommendedDosage : MessagePartBean {

        private IVL<TS, Interval<PlatformDate>> effectiveTime;
        private URG<PQ, PhysicalQuantity> doseQuantity;
        private IList<Ca.Infoway.Messagebuilder.Model.Ab_mr2007_v02_r02.Merged.DosagePreconditions> componentObservationEventCriterion;

        public RecommendedDosage() {
            this.effectiveTime = new IVLImpl<TS, Interval<PlatformDate>>();
            this.doseQuantity = new URGImpl<PQ, PhysicalQuantity>();
            this.componentObservationEventCriterion = new List<Ca.Infoway.Messagebuilder.Model.Ab_mr2007_v02_r02.Merged.DosagePreconditions>();
        }
        /**
         * <summary>DoseDuration</summary>
         * 
         * <remarks>A:Dose Duration <p>Indicates the recommended 
         * duration for drug therapy that was exceeded or not met.</p> 
         * <p>Recommended Duration (width)</p> <p>Allows calculation of 
         * amount under or over.</p> A:Dose Duration <p>Indicates the 
         * recommended duration for drug therapy that was exceeded or 
         * not met.</p> <p>Recommended Duration (width)</p> <p>Allows 
         * calculation of amount under or over.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"effectiveTime"})]
        public Interval<PlatformDate> EffectiveTime {
            get { return this.effectiveTime.Value; }
            set { this.effectiveTime.Value = value; }
        }

        /**
         * <summary>DosageRange</summary>
         * 
         * <remarks>B:Dosage Range <p>This is a specification of the 
         * range of quantity of medication (Min/Max figures) that is 
         * recommended for the drug to avoid triggering of dosage 
         * issues.</p> 
         * <p>ContraIndication.recommendedRange</p><p>Maximum Dosage 
         * Level (high)</p><p>Minimum Dosage Level (low)</p> 
         * <p>ContraIndication.recommendedRange</p><p>Maximum Dosage 
         * Level (high)</p><p>Minimum Dosage Level (low)</p> 
         * <p>ContraIndication.recommendedRange</p><p>Maximum Dosage 
         * Level (high)</p><p>Minimum Dosage Level (low)</p> <p>Allows 
         * calculation of amount over/under.</p> B:Dosage Range <p>This 
         * is a specification of the range of quantity of medication 
         * (Min/Max figures) that is recommended for the drug to avoid 
         * triggering of dosage issues.</p> 
         * <p>ContraIndication.recommendedRange</p><p>Maximum Dosage 
         * Level (high)</p><p>Minimum Dosage Level (low)</p> 
         * <p>ContraIndication.recommendedRange</p><p>Maximum Dosage 
         * Level (high)</p><p>Minimum Dosage Level (low)</p> 
         * <p>ContraIndication.recommendedRange</p><p>Maximum Dosage 
         * Level (high)</p><p>Minimum Dosage Level (low)</p> <p>Allows 
         * calculation of amount over/under.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"doseQuantity"})]
        public UncertainRange<PhysicalQuantity> DoseQuantity {
            get { return this.doseQuantity.Value; }
            set { this.doseQuantity.Value = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"component/observationEventCriterion"})]
        public IList<Ca.Infoway.Messagebuilder.Model.Ab_mr2007_v02_r02.Merged.DosagePreconditions> ComponentObservationEventCriterion {
            get { return this.componentObservationEventCriterion; }
        }

    }

}