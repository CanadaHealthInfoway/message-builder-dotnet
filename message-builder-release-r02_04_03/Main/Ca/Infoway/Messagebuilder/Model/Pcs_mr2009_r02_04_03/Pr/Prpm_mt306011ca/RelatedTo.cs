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
namespace Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Pr.Prpm_mt306011ca {
    using Ca.Infoway.Messagebuilder.Annotation;
    using Ca.Infoway.Messagebuilder.Datatype;
    using Ca.Infoway.Messagebuilder.Datatype.Impl;
    using Ca.Infoway.Messagebuilder.Datatype.Lang;
    using Ca.Infoway.Messagebuilder.Model;
    using System;


    [Hl7PartTypeMappingAttribute(new string[] {"PRPM_MT306011CA.RelatedTo"})]
    public class RelatedTo : MessagePartBean {

        private IVL<TS, Interval<PlatformDate>> effectiveTime;
        private Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Pr.Prpm_mt306011ca.IRoleChoice roleChoice;

        public RelatedTo() {
            this.effectiveTime = new IVLImpl<TS, Interval<PlatformDate>>();
        }
        /**
         * <summary>Relationship Effective Date and Time</summary>
         */
        [Hl7XmlMappingAttribute(new string[] {"effectiveTime"})]
        public Interval<PlatformDate> EffectiveTime {
            get { return this.effectiveTime.Value; }
            set { this.effectiveTime.Value = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"roleChoice"})]
        public Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Pr.Prpm_mt306011ca.IRoleChoice RoleChoice {
            get { return this.roleChoice; }
            set { this.roleChoice = value; }
        }

        public Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Pr.Prpm_mt306011ca.AssignedEntity RoleChoiceAsAssignedEntity {
            get { return this.roleChoice is Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Pr.Prpm_mt306011ca.AssignedEntity ? (Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Pr.Prpm_mt306011ca.AssignedEntity) this.roleChoice : (Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Pr.Prpm_mt306011ca.AssignedEntity) null; }
        }
        public bool HasRoleChoiceAsAssignedEntity() {
            return (this.roleChoice is Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Pr.Prpm_mt306011ca.AssignedEntity);
        }

        public Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Pr.Prpm_mt306011ca.QualifiedEntity RoleChoiceAsQualifiedEntity {
            get { return this.roleChoice is Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Pr.Prpm_mt306011ca.QualifiedEntity ? (Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Pr.Prpm_mt306011ca.QualifiedEntity) this.roleChoice : (Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Pr.Prpm_mt306011ca.QualifiedEntity) null; }
        }
        public bool HasRoleChoiceAsQualifiedEntity() {
            return (this.roleChoice is Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Pr.Prpm_mt306011ca.QualifiedEntity);
        }

        public Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Pr.Prpm_mt306011ca.HealthcareProvider RoleChoiceAsHealthCareProvider {
            get { return this.roleChoice is Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Pr.Prpm_mt306011ca.HealthcareProvider ? (Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Pr.Prpm_mt306011ca.HealthcareProvider) this.roleChoice : (Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Pr.Prpm_mt306011ca.HealthcareProvider) null; }
        }
        public bool HasRoleChoiceAsHealthCareProvider() {
            return (this.roleChoice is Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Pr.Prpm_mt306011ca.HealthcareProvider);
        }

    }

}