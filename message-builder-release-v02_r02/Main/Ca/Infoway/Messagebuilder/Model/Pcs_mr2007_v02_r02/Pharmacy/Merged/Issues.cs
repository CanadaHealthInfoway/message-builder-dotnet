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
namespace Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r02.Pharmacy.Merged {
    using Ca.Infoway.Messagebuilder.Annotation;
    using Ca.Infoway.Messagebuilder.Datatype;
    using Ca.Infoway.Messagebuilder.Datatype.Impl;
    using Ca.Infoway.Messagebuilder.Domainvalue;
    using Ca.Infoway.Messagebuilder.Model;
    using System;


    /**
     * <summary>Business Name: Issues</summary>
     * 
     * <remarks>PORX_MT030040CA.DetectedIssueEvent: Issues 
     * <p>Allows a dispenser to assert an issue against a 
     * prescription to be displayed to subsequent dispensers as 
     * well as others reviewing the patient's medication 
     * profile.</p> <p>Describes an issue associated with a 
     * prescription that resulted in a dispenser refusing to fill 
     * it.</p> PORX_MT060160CA.DetectedIssueEvent: Issues <p>Allows 
     * a dispenser to assert an issue against a prescription to be 
     * displayed to subsequent dispensers as well as others 
     * reviewing the patient's medication profile.</p> <p>Describes 
     * an issue associated with a prescription that resulted in a 
     * dispenser refusing to fill it.</p> 
     * PORX_MT060340CA.DetectedIssueEvent: Issues <p>Allows a 
     * dispenser to assert an issue against a prescription to be 
     * displayed to subsequent dispensers as well as others 
     * reviewing the patient's medication profile.</p> <p>Describes 
     * an issue associated with a prescription that resulted in a 
     * dispenser refusing to fill it.</p> 
     * PORX_MT060190CA.DetectedIssueEvent: Issues <p>Allows a 
     * dispenser to assert an issue against a prescription to be 
     * displayed to subsequent dispensers as well as others 
     * reviewing the patient's medication profile.</p> <p>Describes 
     * an issue associated with a prescription that resulted in a 
     * dispenser refusing to fill it.</p> 
     * PORX_MT060040CA.DetectedIssueEvent: Issues <p>Allows a 
     * dispenser to assert an issue against a prescription to be 
     * displayed to subsequent dispensers as well as others 
     * reviewing the patient's medication profile.</p> <p>Describes 
     * an issue associated with a prescription that resulted in a 
     * dispenser refusing to fill it.</p> 
     * PORX_MT060060CA.DetectedIssueEvent: Issues <p>Allows a 
     * dispenser to assert an issue against a prescription to be 
     * displayed to subsequent dispensers as well as others 
     * reviewing the patient's profile.</p> <p>Describes an issue 
     * associated with a prescription that resulted in a dispenser 
     * refusing to fill it.</p></remarks>
     */
    [Hl7PartTypeMappingAttribute(new string[] {"PORX_MT030040CA.DetectedIssueEvent","PORX_MT060040CA.DetectedIssueEvent","PORX_MT060060CA.DetectedIssueEvent","PORX_MT060160CA.DetectedIssueEvent","PORX_MT060190CA.DetectedIssueEvent","PORX_MT060340CA.DetectedIssueEvent"})]
    public class Issues : MessagePartBean {

        private CV code;
        private ST text;

        public Issues() {
            this.code = new CVImpl();
            this.text = new STImpl();
        }
        /**
         * <summary>Business Name: IssueType</summary>
         * 
         * <remarks>Un-merged Business Name: IssueType Relationship: 
         * PORX_MT030040CA.DetectedIssueEvent.code 
         * Conformance/Cardinality: MANDATORY (1) <p>Identifies what 
         * kind of issue was detected or is being managed.</p><p>This 
         * is mandatory so as to ensure that one issue type can be 
         * distinguished from another.</p> <p>A coded value that is 
         * used to distinguish between different kinds of issues. Types 
         * of issue include: unrecognized identifiers, permission 
         * issues, drug-drug contraindications, drug-allergy alerts, 
         * duplicate therapies, suspect fraud etc.</p><p>.</p> 
         * Un-merged Business Name: IssueType Relationship: 
         * PORX_MT060160CA.DetectedIssueEvent.code 
         * Conformance/Cardinality: MANDATORY (1) <p>Identifies what 
         * kind of issue was detected or is being managed.</p><p>This 
         * is mandatory so as to ensure that one issue type can be 
         * distinguished from another.</p> <p>A coded value that is 
         * used to distinguish between different kinds of issues. Types 
         * of issue include: unrecognized identifiers, permission 
         * issues, drug-drug contraindications, drug-allergy alerts, 
         * duplicate therapies, suspect fraud etc.</p> Un-merged 
         * Business Name: IssueType Relationship: 
         * PORX_MT060340CA.DetectedIssueEvent.code 
         * Conformance/Cardinality: MANDATORY (1) <p>Identifies what 
         * kind of issue was detected or is being managed.</p><p>This 
         * is mandatory so as to ensure that one issue type can be 
         * distinguished from another.</p> <p>A coded value that is 
         * used to distinguish between different kinds of issues. Types 
         * of issue include: unrecognized identifiers, permission 
         * issues, drug-drug contraindications, drug-allergy alerts, 
         * duplicate therapies, suspect fraud etc.</p> Un-merged 
         * Business Name: IssueType Relationship: 
         * PORX_MT060190CA.DetectedIssueEvent.code 
         * Conformance/Cardinality: MANDATORY (1) <p>Identifies what 
         * kind of issue was detected or is being managed.</p><p>This 
         * is mandatory so as to ensure that one issue type can be 
         * distinguished from another.</p> <p>A coded value that is 
         * used to distinguish between different kinds of issues. Types 
         * of issue include: unrecognized identifiers, permission 
         * issues, drug-drug contraindications, drug-allergy alerts, 
         * duplicate therapies, suspect fraud etc.</p> Un-merged 
         * Business Name: IssueType Relationship: 
         * PORX_MT060040CA.DetectedIssueEvent.code 
         * Conformance/Cardinality: MANDATORY (1) <p>Identifies what 
         * kind of issue was detected or is being managed.</p><p>This 
         * is mandatory so as to ensure that one issue type can be 
         * distinguished from another.</p> <p>A coded value that is 
         * used to distinguish between different kinds of issues. Types 
         * of issue include: unrecognized identifiers, permission 
         * issues, drug-drug contraindications, drug-allergy alerts, 
         * duplicate therapies, suspect fraud etc.</p> Un-merged 
         * Business Name: IssueType Relationship: 
         * PORX_MT060060CA.DetectedIssueEvent.code 
         * Conformance/Cardinality: MANDATORY (1) <p>Identifies what 
         * kind of issue was detected or is being managed and is 
         * therefore mandatory.</p> <p>A coded value that is used to 
         * distinguish between different kinds of issues. Types of 
         * issue include: unrecognized identifiers, permission issues, 
         * drug-drug contraindications, drug-allergy alerts, duplicate 
         * therapies, suspect fraud etc.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"code"})]
        public ActDetectedIssueCode Code {
            get { return (ActDetectedIssueCode) this.code.Value; }
            set { this.code.Value = value; }
        }

        /**
         * <summary>Business Name: IssueComment</summary>
         * 
         * <remarks>Un-merged Business Name: IssueComment Relationship: 
         * PORX_MT030040CA.DetectedIssueEvent.text 
         * Conformance/Cardinality: REQUIRED (0-1) <p>Enables extra or 
         * more detailed description of the alert</p> <p>A free form 
         * textual description regarding the issue of fraudulence. This 
         * may be specified in place of, or in addition to the coded 
         * issue.</p> Un-merged Business Name: IssueComment 
         * Relationship: PORX_MT060160CA.DetectedIssueEvent.text 
         * Conformance/Cardinality: REQUIRED (0-1) <p>Enables extra or 
         * more detailed description of the alert</p> <p>A free form 
         * textual description regarding the issue of fraudulence. This 
         * may be specified in place of, or in addition to the coded 
         * issue.</p> Un-merged Business Name: IssueComment 
         * Relationship: PORX_MT060340CA.DetectedIssueEvent.text 
         * Conformance/Cardinality: REQUIRED (0-1) <p>Enables extra or 
         * more detailed description of the alert</p> <p>A free form 
         * textual description regarding the issue of fraudulence. This 
         * may be specified in place of, or in addition to the coded 
         * issue.</p> Un-merged Business Name: IssueComment 
         * Relationship: PORX_MT060190CA.DetectedIssueEvent.text 
         * Conformance/Cardinality: REQUIRED (0-1) <p>Enables extra or 
         * more detailed description of the alert</p> <p>A free form 
         * textual description regarding the issue of fraudulence. This 
         * may be specified in place of, or in addition to the coded 
         * issue.</p> Un-merged Business Name: IssueComment 
         * Relationship: PORX_MT060040CA.DetectedIssueEvent.text 
         * Conformance/Cardinality: REQUIRED (0-1) <p>Enables extra or 
         * more detailed description of the alert</p> <p>A free form 
         * textual description regarding the issue of fraudulence. This 
         * may be specified in place of, or in addition to the coded 
         * issue.</p> Un-merged Business Name: IssueComment 
         * Relationship: PORX_MT060060CA.DetectedIssueEvent.text 
         * Conformance/Cardinality: REQUIRED (0-1) <p>Enables extra or 
         * more detailed description of the alert</p> <p>A free form 
         * textual description regarding the issue. This may be 
         * specified in place of, or in addition to the coded 
         * issue.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"text"})]
        public String Text {
            get { return this.text.Value; }
            set { this.text.Value = value; }
        }

    }

}