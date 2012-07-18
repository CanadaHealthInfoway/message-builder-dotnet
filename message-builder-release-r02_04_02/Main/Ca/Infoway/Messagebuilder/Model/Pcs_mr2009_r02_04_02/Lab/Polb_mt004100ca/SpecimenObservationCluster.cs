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
    using Ca.Infoway.Messagebuilder.Datatype.Lang;
    using Ca.Infoway.Messagebuilder.Domainvalue;
    using Ca.Infoway.Messagebuilder.Model;
    using Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Lab.Merged;
    using System;
    using System.Collections.Generic;


    /**
     * <summary>Specimen Observation Cluster</summary>
     * 
     * <remarks><p>This act groups all the communicated objects for 
     * one or more isolate(s) including any antibiotic sensitivity 
     * tests all performed on those isolate(s). Typically the 
     * isolate determines the sensitivities to run.</p></remarks>
     */
    [Hl7PartTypeMappingAttribute(new string[] {"POLB_MT004100CA.SpecimenObservationCluster"})]
    public class SpecimenObservationCluster : MessagePartBean {

        private ST clusterComment;
        private CS clusterStatus;
        private IVL<TS, Interval<PlatformDate>> clusterEffectiveTime;
        private IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Lab.Merged.WasPerformedBy> performer;
        private IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Lab.Polb_mt004100ca.IsolateObservations> component1IsolateObservationEvent;
        private Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Lab.Polb_mt004100ca.HasComponent component2;
        private IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Lab.Polb_mt004100ca.SensitivityBattery> component3SensitivityBattery;
        private Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Lab.Merged.ResultStatusProcessStep subjectOfResultStatusProcessStep;

        public SpecimenObservationCluster() {
            this.clusterComment = new STImpl();
            this.clusterStatus = new CSImpl();
            this.clusterEffectiveTime = new IVLImpl<TS, Interval<PlatformDate>>();
            this.performer = new List<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Lab.Merged.WasPerformedBy>();
            this.component1IsolateObservationEvent = new List<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Lab.Polb_mt004100ca.IsolateObservations>();
            this.component3SensitivityBattery = new List<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Lab.Polb_mt004100ca.SensitivityBattery>();
        }
        /**
         * <summary>Cluster Comment</summary>
         * 
         * <remarks><p>Comments associated with the Isolate 
         * Cluster.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"text"})]
        public String ClusterComment {
            get { return this.clusterComment.Value; }
            set { this.clusterComment.Value = value; }
        }

        /**
         * <summary>Cluster Status</summary>
         * 
         * <remarks><p>Status associated with the isolate cluster.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"statusCode"})]
        public ActStatus ClusterStatus {
            get { return (ActStatus) this.clusterStatus.Value; }
            set { this.clusterStatus.Value = value; }
        }

        /**
         * <summary>Cluster Effective Time</summary>
         * 
         * <remarks><p>Effective time associated with the Isolate 
         * Cluster.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"effectiveTime"})]
        public Interval<PlatformDate> ClusterEffectiveTime {
            get { return this.clusterEffectiveTime.Value; }
            set { this.clusterEffectiveTime.Value = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"performer"})]
        public IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Lab.Merged.WasPerformedBy> Performer {
            get { return this.performer; }
        }

        [Hl7XmlMappingAttribute(new string[] {"component1/isolateObservationEvent"})]
        public IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Lab.Polb_mt004100ca.IsolateObservations> Component1IsolateObservationEvent {
            get { return this.component1IsolateObservationEvent; }
        }

        [Hl7XmlMappingAttribute(new string[] {"component2"})]
        public Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Lab.Polb_mt004100ca.HasComponent Component2 {
            get { return this.component2; }
            set { this.component2 = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"component3/sensitivityBattery"})]
        public IList<Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Lab.Polb_mt004100ca.SensitivityBattery> Component3SensitivityBattery {
            get { return this.component3SensitivityBattery; }
        }

        [Hl7XmlMappingAttribute(new string[] {"subjectOf/resultStatusProcessStep"})]
        public Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Lab.Merged.ResultStatusProcessStep SubjectOfResultStatusProcessStep {
            get { return this.subjectOfResultStatusProcessStep; }
            set { this.subjectOfResultStatusProcessStep = value; }
        }

    }

}