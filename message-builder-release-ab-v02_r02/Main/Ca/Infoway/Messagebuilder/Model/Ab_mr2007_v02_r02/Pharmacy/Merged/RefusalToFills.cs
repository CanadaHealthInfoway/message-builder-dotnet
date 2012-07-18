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
namespace Ca.Infoway.Messagebuilder.Model.Ab_mr2007_v02_r02.Pharmacy.Merged {
    using Ca.Infoway.Messagebuilder.Annotation;
    using Ca.Infoway.Messagebuilder.Datatype;
    using Ca.Infoway.Messagebuilder.Datatype.Impl;
    using Ca.Infoway.Messagebuilder.Domainvalue;
    using Ca.Infoway.Messagebuilder.Model;
    using Ca.Infoway.Messagebuilder.Model.Ab_mr2007_v02_r02.Merged;
    using System;
    using System.Collections.Generic;


    /**
     * <summary>PORX_MT060060CA.RefusalToFill: Refusal To Fills</summary>
     * 
     * <remarks><p>One of 'Refusal To Fill Reason' or Issue must be 
     * specified but not both</p> <p>Indicates that the identified 
     * issue resulted in a dispenser refusing to fill the subject 
     * prescription.</p> <p>Exposes in the model that this issue is 
     * associated with a refusal to dispense.</p><p>An indication 
     * of 'refusal to fill' must be indicated, thus attribute is 
     * mandatory.</p> <p>Exposes in the model that this issue is 
     * associated with a refusal to dispense.</p><p>An indication 
     * of 'refusal to fill' must be indicated, thus attribute is 
     * mandatory.</p> PORX_MT030040CA.RefusalToFill: Refusal to 
     * Fills <p>One of 'Refusal To Fill Reason' or 'Issue' must be 
     * specified, but not both.</p> <p>Indicates that the 
     * identified issue resulted in a dispenser refusing to fill 
     * the subject prescription.</p> <p>Exposes in the model that 
     * this issue is associated with a refusal to 
     * dispense.</p><p>An indication of 'refusal to fill' must be 
     * indicated, thus attribute is mandatory.</p> <p>Exposes in 
     * the model that this issue is associated with a refusal to 
     * dispense.</p><p>An indication of 'refusal to fill' must be 
     * indicated, thus attribute is mandatory.</p> 
     * PORX_MT060190CA.RefusalToFill: Refusal To Fills <p>One of 
     * 'Refusal To Fill Reason' or Issue must be specified but not 
     * both</p> <p>Indicates that the identified issue resulted in 
     * a dispenser refusing to fill the subject prescription.</p> 
     * <p>Exposes in the model that this issue is associated with a 
     * refusal to dispense.</p><p>An indication of 'refusal to 
     * fill' must be indicated, thus attribute is mandatory.</p> 
     * <p>Exposes in the model that this issue is associated with a 
     * refusal to dispense.</p><p>An indication of 'refusal to 
     * fill' must be indicated, thus attribute is mandatory.</p> 
     * PORX_MT060040CA.RefusalToFill: Refusals To Fills <p>One of 
     * 'Refusal To Fill Reason' or Issue must be specified but not 
     * both</p> <p>Indicates that the identified issue resulted in 
     * a dispenser refusing to fill the subject prescription. .</p> 
     * <p>Exposes in the model that this issue is associated with a 
     * refusal to dispense.</p><p>An indication of 'refusal to 
     * fill' must be indicated, thus attribute is mandatory.</p> 
     * <p>Exposes in the model that this issue is associated with a 
     * refusal to dispense.</p><p>An indication of 'refusal to 
     * fill' must be indicated, thus attribute is mandatory.</p></remarks>
     */
    [Hl7PartTypeMappingAttribute(new string[] {"PORX_MT030040CA.RefusalToFill","PORX_MT060040CA.RefusalToFill","PORX_MT060060CA.RefusalToFill","PORX_MT060190CA.RefusalToFill"})]
    public class RefusalToFills : MessagePartBean {

        private TS effectiveTime;
        private CV reasonCode;
        private Ca.Infoway.Messagebuilder.Model.Ab_mr2007_v02_r02.Merged.RefusedBy author;
        private IList<Ca.Infoway.Messagebuilder.Model.Ab_mr2007_v02_r02.Merged.Issues> reasonDetectedIssueEvent;
        private Ca.Infoway.Messagebuilder.Model.Ab_mr2007_v02_r02.Merged.CreatedAt location;

        public RefusalToFills() {
            this.effectiveTime = new TSImpl();
            this.reasonCode = new CVImpl();
            this.reasonDetectedIssueEvent = new List<Ca.Infoway.Messagebuilder.Model.Ab_mr2007_v02_r02.Merged.Issues>();
        }
        /**
         * <summary>RefusalToFillDate</summary>
         * 
         * <remarks>Refusal To Fill Date <p>The date that the dispenser 
         * refused to fill the prescription</p> <p>May be important to 
         * down stream providers to know when the refusal 
         * occurred.</p><p>Is marked as populated as it may not always 
         * be known for historical data pre- loaded into the EHR</p> 
         * <p>May be important to down stream providers to know when 
         * the refusal occurred.</p><p>Is marked as populated as it may 
         * not always be known for historical data pre- loaded into the 
         * EHR</p> Refusal To Fill Date <p>The date that the dispenser 
         * refused to fill the prescitpion</p> <p>May be important to 
         * down stream providers to know when the refusal 
         * occured.</p><p>Is marked as populated as it may not always 
         * be known for historical data pre- loaded into the EHR</p> 
         * <p>May be important to down stream providers to know when 
         * the refusal occured.</p><p>Is marked as populated as it may 
         * not always be known for historical data pre- loaded into the 
         * EHR</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"effectiveTime"})]
        public PlatformDate EffectiveTime {
            get { return this.effectiveTime.Value; }
            set { this.effectiveTime.Value = value; }
        }

        /**
         * <summary>RefusalToFillReason</summary>
         * 
         * <remarks>Refusal To Fill Reason <p>Indicates a 
         * non-clinical-issue based reason for refusing to fill.</p> 
         * <p>Supports capture of reasons such as 'moral objection' 
         * which are not tied to specific issues. Set as CWE to allow 
         * non-coded reasons.</p> Refusal To Fill Reason <p>Indicates a 
         * non-clinical-issue based reason for refusing to fill.</p> 
         * <p>Supports capture of reasons such as 'moral objection' 
         * which are not tied to specific issues. Set to CWE to allow 
         * non-coded reasons.</p> Refusal to Fill Reason <p>Indicates a 
         * non-clinical-issue based reason for refusing to fill.</p> 
         * <p>Indicates a non-clinical-issue based reason for refusing 
         * to fill. Allows CWE for non-coded reasons.</p> Refusal To 
         * Fill Reason <p>Indicates a non-clinical-issue based reason 
         * for refusing to fill.</p> <p>Supports capture of reasons 
         * such as 'moral objection' which are not tied to specific 
         * issues. The element is CWE to allow for non-coded 
         * reasons.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"reasonCode"})]
        public ActSupplyFulfillmentRefusalReason ReasonCode {
            get { return (ActSupplyFulfillmentRefusalReason) this.reasonCode.Value; }
            set { this.reasonCode.Value = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"author"})]
        public Ca.Infoway.Messagebuilder.Model.Ab_mr2007_v02_r02.Merged.RefusedBy Author {
            get { return this.author; }
            set { this.author = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"reason/detectedIssueEvent"})]
        public IList<Ca.Infoway.Messagebuilder.Model.Ab_mr2007_v02_r02.Merged.Issues> ReasonDetectedIssueEvent {
            get { return this.reasonDetectedIssueEvent; }
        }

        [Hl7XmlMappingAttribute(new string[] {"location"})]
        public Ca.Infoway.Messagebuilder.Model.Ab_mr2007_v02_r02.Merged.CreatedAt Location {
            get { return this.location; }
            set { this.location = value; }
        }

    }

}