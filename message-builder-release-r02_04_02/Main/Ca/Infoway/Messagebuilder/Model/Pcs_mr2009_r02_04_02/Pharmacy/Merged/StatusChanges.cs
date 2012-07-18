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
    using Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Common.Merged;
    using Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Merged;
    using System;


    /**
     * <summary>PORX_MT060340CA.ControlActEvent: Status Changes</summary>
     * 
     * <remarks><p>This records the history of changes that have 
     * been made to the prescription, including why the changes 
     * were made, who made them and when.</p> <p>Provides an audit 
     * trail of a patient's therapy adjustments. Status changes may 
     * affect evaluations of compliance.</p> 
     * PORX_MT060160CA.ControlActEvent: Status Changes <p>This 
     * records the history of changes that have been made to the 
     * prescription, including why the changes were made, who made 
     * them and when.</p> <p>Provides an audit trail of a patient's 
     * therapy adjustments. Status changes may affect evaluations 
     * of compliance.</p> PORX_MT060210CA.ControlActEvent: Other 
     * Medication Status Changes <p>This records the history of 
     * changes that have been made to the other medication record, 
     * including why the changes were made, who made them and 
     * when.</p> <p>Provides an audit trail of a patient's use of 
     * other medications.</p> PORX_MT060040CA.ControlActEvent: 
     * Status Changes <p>This records the history of changes that 
     * have been made to the prescription, including why the 
     * changes were made, who made them and when.</p> <p>Provides 
     * an audit trail of a patient's therapy adjustments. Status 
     * changes may affect evaluations of compliance.</p> 
     * PORX_MT060090CA.ControlActEvent: Dispense Status Changes 
     * <p>This records the history of changes that have been made 
     * to the prescription dispense, including why the changes were 
     * made, who made them and when.</p> <p>Provides an audit trail 
     * of a patient's therapy adjustments. Status changes may 
     * affect evaluations of compliance.</p> 
     * PORX_MT060010CA.ControlActEvent: Dispense Status Changes 
     * <p>This records the history of changes that have been made 
     * to the prescription dispense, including why the changes were 
     * made, who made them and when.</p> <p>Provides an audit trail 
     * of a patient's therapy adjustments. Status changes may 
     * affect evaluations of compliance.</p></remarks>
     */
    [Hl7PartTypeMappingAttribute(new string[] {"PORX_MT060010CA.ControlActEvent","PORX_MT060040CA.ControlActEvent","PORX_MT060090CA.ControlActEvent","PORX_MT060160CA.ControlActEvent","PORX_MT060210CA.ControlActEvent","PORX_MT060340CA.ControlActEvent"})]
    public class StatusChanges : MessagePartBean {

        private CV code;
        private IVL<TS, Interval<PlatformDate>> effectiveTime;
        private CV reasonCode;
        private Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Common.Merged.HealthcareWorker responsiblePartyAssignedEntity;
        private Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Merged.ChangedBy author;

        public StatusChanges() {
            this.code = new CVImpl();
            this.effectiveTime = new IVLImpl<TS, Interval<PlatformDate>>();
            this.reasonCode = new CVImpl();
        }
        /**
         * <summary>Dispense Status Change Type</summary>
         * 
         * <remarks><p>Identifies what kind of change occurred. 
         * Examples include Suspended, Aborted, etc.</p> <p>This 
         * attribute is mandatory to ensure that change types are 
         * distinguishable.</p> Change Type <p>Identifies what kind of 
         * change occurred. Examples include Suspended, Superseded, 
         * Released, Aborted (stopped), etc.</p> <p>This attribute is 
         * mandatory to ensure that change types are 
         * distinguishable.</p> Other Medication Status Change Type 
         * <p>Identifies what kind of change occurred. Examples include 
         * Completed, Aborted, etc.</p> <p>This attribute is mandatory 
         * to ensure that change types are distinguishable</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"code"})]
        public HL7TriggerEventCode Code {
            get { return (HL7TriggerEventCode) this.code.Value; }
            set { this.code.Value = value; }
        }

        /**
         * <summary>Change Effective Period</summary>
         * 
         * <remarks><p>The date on which the various status changes of 
         * a prescription become valid and applicable. In the case of a 
         * suspend, may also indicate the scheduled time at which the 
         * status change will end.</p> <p>Allows applications to sort 
         * and filter by time.</p><p>The effective date can be 
         * defaulted to change date, and thus is mandatory.</p> 
         * <p>Allows applications to sort and filter by time.</p><p>The 
         * effective date can be defaulted to change date, and thus is 
         * mandatory.</p> Dispense Status Change Effective Date <p>The 
         * date on which the various status changes of a prescription 
         * dispense become valid and applicable. In the case of a 
         * suspend, may also indicate the scheduled time at which the 
         * status change will end.</p> <p>Allows applications to sort 
         * and filter by time.</p><p>The effective date can be 
         * defaulted to change date, and thus is mandatory.</p> 
         * <p>Allows applications to sort and filter by time.</p><p>The 
         * effective date can be defaulted to change date, and thus is 
         * mandatory.</p> Other Medication Status Change Effective 
         * Period <p>The date on which the various status changes of an 
         * other medication record become valid and applicable. In the 
         * case of a suspend, may also indicate the scheduled time at 
         * which the status change will end.</p> <p>Allows applications 
         * to sort and filter by time.</p><p>The effective date can be 
         * defaulted to change date, and thus is mandatory.</p> 
         * <p>Allows applications to sort and filter by time.</p><p>The 
         * effective date can be defaulted to change date, and thus is 
         * mandatory.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"effectiveTime"})]
        public Interval<PlatformDate> EffectiveTime {
            get { return this.effectiveTime.Value; }
            set { this.effectiveTime.Value = value; }
        }

        /**
         * <summary>Dispense Status Change Reason</summary>
         * 
         * <remarks><p>Denotes the reason the status of the 
         * prescription dispense was changed.</p> <p>Ensures consistent 
         * terminology in capturing and interpreting reasons for 
         * change. Allows CWE because not all reasons will correspond 
         * to a pre-defined code.</p> Other Medication Status Change 
         * Reason <p>Denotes the reason the status of the other 
         * medication was changed.</p> <p>Ensures consistent 
         * terminology in capturing and interpreting reasons for 
         * change. Allows CWE because not all reasons will correspond 
         * to a pre-defined code.</p> Change Reason <p>Denotes the 
         * reason the status of the prescription was changed.</p> 
         * <p>Ensures consistent terminology in capturing and 
         * interpreting reasons for change. Allows CWE because not all 
         * reasons will correspond to a pre-defined code.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"reasonCode"})]
        public ControlActReason ReasonCode {
            get { return (ControlActReason) this.reasonCode.Value; }
            set { this.reasonCode.Value = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"responsibleParty/assignedEntity"})]
        public Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Common.Merged.HealthcareWorker ResponsiblePartyAssignedEntity {
            get { return this.responsiblePartyAssignedEntity; }
            set { this.responsiblePartyAssignedEntity = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"author"})]
        public Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Merged.ChangedBy Author {
            get { return this.author; }
            set { this.author = value; }
        }

    }

}