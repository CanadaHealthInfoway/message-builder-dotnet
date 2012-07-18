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
namespace Ca.Infoway.Messagebuilder.Model.Ab_mr2007_v02_r02.Sessionmgmt.Merged {
    using Ca.Infoway.Messagebuilder.Annotation;
    using Ca.Infoway.Messagebuilder.Datatype;
    using Ca.Infoway.Messagebuilder.Datatype.Impl;
    using Ca.Infoway.Messagebuilder.Datatype.Lang;
    using Ca.Infoway.Messagebuilder.Domainvalue;
    using Ca.Infoway.Messagebuilder.Model;
    using Ca.Infoway.Messagebuilder.Model.Ab_mr2007_v02_r02.Merged;
    using Ca.Infoway.Messagebuilder.Model.Ab_mr2007_v02_r02.Sessionmgmt.Coct_mt090107ca;
    using System;


    /**
     * <summary>StatusChanges</summary>
     * 
     * <remarks>PORX_MT060340CA.ControlActEvent: Status Changes 
     * <p>This records the history of changes that have been made 
     * to the prescription, including why the changes were made, 
     * who made them and when.</p> <p>Provides an audit trail of a 
     * patient's therapy adjustments. Status changes may affect 
     * evaluations of compliance.</p> 
     * PORX_MT060160CA.ControlActEvent: Status Changes <p>This 
     * records the history of changes that have been made to the 
     * prescription, including why the changes were made, who made 
     * them and when.</p> <p>Provides an audit trail of a patient's 
     * therapy adjustments. Status changes may affect evaluations 
     * of compliance.</p></remarks>
     */
    [Hl7PartTypeMappingAttribute(new string[] {"PORX_MT060160CA.ControlActEvent","PORX_MT060340CA.ControlActEvent"})]
    public class StatusChanges : MessagePartBean {

        private CV code;
        private IVL<TS, Interval<PlatformDate>> effectiveTime;
        private CV reasonCode;
        private Ca.Infoway.Messagebuilder.Model.Ab_mr2007_v02_r02.Sessionmgmt.Coct_mt090107ca.Provider responsiblePartyAssignedPerson;
        private Ca.Infoway.Messagebuilder.Model.Ab_mr2007_v02_r02.Merged.Author1 author;

        public StatusChanges() {
            this.code = new CVImpl();
            this.effectiveTime = new IVLImpl<TS, Interval<PlatformDate>>();
            this.reasonCode = new CVImpl();
        }
        /**
         * <summary>ChangeType</summary>
         * 
         * <remarks>Change Type <p>Identifies what kind of change 
         * occurred. Examples include Suspended, Superseded, Released, 
         * Aborted (stopped), etc.</p> <p>Distinguishes 
         * discontinueStatus, holdStatus, reactivateStatus and 
         * releaseStatus</p> <p>This attribute is mandatory to ensure 
         * that change types are distinguishable.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"code"})]
        public HL7TriggerEventCode Code {
            get { return (HL7TriggerEventCode) this.code.Value; }
            set { this.code.Value = value; }
        }

        /**
         * <summary>ChangeEffectivePeriod</summary>
         * 
         * <remarks>Change Effective Period <p>The date on which the 
         * various status changes of a prescription become valid and 
         * applicable. In the case of a suspend, may also indicate the 
         * scheduled time at which the status change will end.</p> 
         * <p>PrescriptionStatus.initialEndDate</p><p>PrescriptionStatus.actualEndDate</p><p>Prescription.cancelTime</p><p>Prescription.holdReleaseDate</p><p>Prescription.holdStartDate</p><p>Prescription.modificationTime</p><p>Prescription.stopDate</p><p>Prescription.reactivateDate</p><p>ZPB3.14(when 
         * code is discontinued)</p> 
         * <p>PrescriptionStatus.initialEndDate</p><p>PrescriptionStatus.actualEndDate</p><p>Prescription.cancelTime</p><p>Prescription.holdReleaseDate</p><p>Prescription.holdStartDate</p><p>Prescription.modificationTime</p><p>Prescription.stopDate</p><p>Prescription.reactivateDate</p><p>ZPB3.14(when 
         * code is discontinued)</p> 
         * <p>PrescriptionStatus.initialEndDate</p><p>PrescriptionStatus.actualEndDate</p><p>Prescription.cancelTime</p><p>Prescription.holdReleaseDate</p><p>Prescription.holdStartDate</p><p>Prescription.modificationTime</p><p>Prescription.stopDate</p><p>Prescription.reactivateDate</p><p>ZPB3.14(when 
         * code is discontinued)</p> 
         * <p>PrescriptionStatus.initialEndDate</p><p>PrescriptionStatus.actualEndDate</p><p>Prescription.cancelTime</p><p>Prescription.holdReleaseDate</p><p>Prescription.holdStartDate</p><p>Prescription.modificationTime</p><p>Prescription.stopDate</p><p>Prescription.reactivateDate</p><p>ZPB3.14(when 
         * code is discontinued)</p> 
         * <p>PrescriptionStatus.initialEndDate</p><p>PrescriptionStatus.actualEndDate</p><p>Prescription.cancelTime</p><p>Prescription.holdReleaseDate</p><p>Prescription.holdStartDate</p><p>Prescription.modificationTime</p><p>Prescription.stopDate</p><p>Prescription.reactivateDate</p><p>ZPB3.14(when 
         * code is discontinued)</p> 
         * <p>PrescriptionStatus.initialEndDate</p><p>PrescriptionStatus.actualEndDate</p><p>Prescription.cancelTime</p><p>Prescription.holdReleaseDate</p><p>Prescription.holdStartDate</p><p>Prescription.modificationTime</p><p>Prescription.stopDate</p><p>Prescription.reactivateDate</p><p>ZPB3.14(when 
         * code is discontinued)</p> 
         * <p>PrescriptionStatus.initialEndDate</p><p>PrescriptionStatus.actualEndDate</p><p>Prescription.cancelTime</p><p>Prescription.holdReleaseDate</p><p>Prescription.holdStartDate</p><p>Prescription.modificationTime</p><p>Prescription.stopDate</p><p>Prescription.reactivateDate</p><p>ZPB3.14(when 
         * code is discontinued)</p> 
         * <p>PrescriptionStatus.initialEndDate</p><p>PrescriptionStatus.actualEndDate</p><p>Prescription.cancelTime</p><p>Prescription.holdReleaseDate</p><p>Prescription.holdStartDate</p><p>Prescription.modificationTime</p><p>Prescription.stopDate</p><p>Prescription.reactivateDate</p><p>ZPB3.14(when 
         * code is discontinued)</p> 
         * <p>PrescriptionStatus.initialEndDate</p><p>PrescriptionStatus.actualEndDate</p><p>Prescription.cancelTime</p><p>Prescription.holdReleaseDate</p><p>Prescription.holdStartDate</p><p>Prescription.modificationTime</p><p>Prescription.stopDate</p><p>Prescription.reactivateDate</p><p>ZPB3.14(when 
         * code is discontinued)</p> <p>Allows applications to sort and 
         * filter by time.</p><p>The effective date can be defaulted to 
         * change date, and thus is mandatory.</p> <p>Allows 
         * applications to sort and filter by time.</p><p>The effective 
         * date can be defaulted to change date, and thus is 
         * mandatory.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"effectiveTime"})]
        public Interval<PlatformDate> EffectiveTime {
            get { return this.effectiveTime.Value; }
            set { this.effectiveTime.Value = value; }
        }

        /**
         * <summary>ChangeReason</summary>
         * 
         * <remarks>Change Reason <p>Denotes the reason the status of 
         * the prescription was changed.</p> 
         * <p>PrescriptionStatus.reason(mnemonic)</p><p>PrescriptionStatus.adhocReason(originalText)</p> 
         * <p>PrescriptionStatus.reason(mnemonic)</p><p>PrescriptionStatus.adhocReason(originalText)</p> 
         * <p>Ensures consistent terminology in capturing and 
         * interpreting reasons for change. Allows CWE because not all 
         * reasons will correspond to a pre-defined code.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"reasonCode"})]
        public ControlActReason ReasonCode {
            get { return (ControlActReason) this.reasonCode.Value; }
            set { this.reasonCode.Value = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"responsibleParty/assignedPerson"})]
        public Ca.Infoway.Messagebuilder.Model.Ab_mr2007_v02_r02.Sessionmgmt.Coct_mt090107ca.Provider ResponsiblePartyAssignedPerson {
            get { return this.responsiblePartyAssignedPerson; }
            set { this.responsiblePartyAssignedPerson = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"author"})]
        public Ca.Infoway.Messagebuilder.Model.Ab_mr2007_v02_r02.Merged.Author1 Author {
            get { return this.author; }
            set { this.author = value; }
        }

    }

}