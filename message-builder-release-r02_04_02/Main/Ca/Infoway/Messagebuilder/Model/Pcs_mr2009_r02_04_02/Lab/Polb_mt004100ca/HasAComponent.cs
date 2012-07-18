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
 * Last modified: $LastChangedDate: 2012-01-18 21:09:22 -0500 (Wed, 18 Jan 2012) $
 * Revision:      $LastChangedRevision: 3983 $
 */

/* This class was auto-generated by the message builder generator tools. */
namespace Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Lab.Polb_mt004100ca {
    using Ca.Infoway.Messagebuilder.Annotation;
    using Ca.Infoway.Messagebuilder.Datatype;
    using Ca.Infoway.Messagebuilder.Datatype.Impl;
    using Ca.Infoway.Messagebuilder.Model;
    using System;


    /**
     * <summary>has a component</summary>
     * 
     * <remarks><p>Associates a Culture with a 
     * SpecimenObservationCluster.</p></remarks>
     */
    [Hl7PartTypeMappingAttribute(new string[] {"POLB_MT004100CA.Component2"})]
    public class HasAComponent : MessagePartBean {

        private BL contextConductionInd;
        private Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Lab.Polb_mt004100ca.SpecimenObservationCluster specimenObservationCluster;

        public HasAComponent() {
            this.contextConductionInd = new BLImpl();
        }
        [Hl7XmlMappingAttribute(new string[] {"contextConductionInd"})]
        public bool? ContextConductionInd {
            get { return this.contextConductionInd.Value; }
            set { this.contextConductionInd.Value = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"specimenObservationCluster"})]
        public Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Lab.Polb_mt004100ca.SpecimenObservationCluster SpecimenObservationCluster {
            get { return this.specimenObservationCluster; }
            set { this.specimenObservationCluster = value; }
        }

    }

}