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
 * Last modified: $LastChangedDate: 2012-02-16 11:06:56 -0500 (Thu, 16 Feb 2012) $
 * Revision:      $LastChangedRevision: 5470 $
 */
/* This class was auto-generated by the message builder generator tools. */
namespace Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r01.Pharmacy.Merged {
    using Ca.Infoway.Messagebuilder.Annotation;
    using Ca.Infoway.Messagebuilder.Datatype;
    using Ca.Infoway.Messagebuilder.Datatype.Impl;
    using Ca.Infoway.Messagebuilder.Datatype.Lang;
    using Ca.Infoway.Messagebuilder.Domainvalue;
    using Ca.Infoway.Messagebuilder.Model;


    /**
     * <summary>CoverageExtensions</summary>
     * 
     * <remarks>PORX_MT010120CA.Coverage: Coverage Extensions <p>An 
     * authorization issued by a payor to cover a drug not 
     * previously covered by a patient's drug plan.</p> <p>Allows 
     * conveying special coverage information between 
     * providers.</p> PORX_MT060040CA.Coverage: Coverage Extensions 
     * <p>An authorization issued by a payor to cover a device not 
     * previously covered by a patient's drug plan.</p> <p>Allows 
     * conveying special coverage information between 
     * providers.</p> PORX_MT010110CA.Coverage: Coverage Extensions 
     * <p>An authorization issued by a payor to cover a device not 
     * previously covered by a patient's drug plan.</p> <p>Allows 
     * conveying special coverage information between 
     * providers.</p></remarks>
     */
    [Hl7PartTypeMappingAttribute(new string[] {"PORX_MT010110CA.Coverage","PORX_MT010120CA.Coverage","PORX_MT060040CA.Coverage"})]
    public class CoverageExtensions_1 : MessagePartBean {

        private CS moodCode;
        private II id;
        private Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r01.Pharmacy.Merged.Underwriter authorUnderwriter;

        public CoverageExtensions_1() {
            this.moodCode = new CSImpl();
            this.id = new IIImpl();
        }
        /**
         * <summary>ExtensionGrantedIndicator</summary>
         * 
         * <remarks>Extension Granted Indicator <p>If set to 'EVN', 
         * then coverage has been granted. Otherwise it has merely been 
         * requested.</p> <p>Indicates to the pharmacy whether they 
         * need to check the status of coverage prior to dispensing</p> 
         * Extension Granted Indicator <p>If set to 'EVN', then 
         * coverage has been granted. Otherwise it has merely been 
         * requested.</p> <p>Indicates to the pharmacy whether they 
         * need to check the status of coverage prior to dispensing. 
         * Mandatory due to HL7 rules.</p> Extension Granted Indicator 
         * <p>If set to 'EVN', then coverage has been granted. 
         * Otherwise it has merely been requested.</p> <p>Indicates to 
         * the pharmacy whether they need to check the status of 
         * coverage prior to dispensing. The attribute is mandatory due 
         * to HL7 rules.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"moodCode"})]
        public x_ActMoodOrderEvent MoodCode {
            get { return (x_ActMoodOrderEvent) this.moodCode.Value; }
            set { this.moodCode.Value = value; }
        }

        /**
         * <summary>CoverageExtensionId</summary>
         * 
         * <remarks>A:Coverage Extension Id <p>Unique identification 
         * for a specific coverage extension.</p> <p>Allows for 
         * referencing of a specific coverage extension.</p><p>This 
         * identifier may be needed on claims against the 
         * coverage.</p><p>At times when the ID will not be available 
         * (such as when the request has just been submitted), the 
         * attribute is 'populated'.</p> <p>Allows for referencing of a 
         * specific coverage extension.</p><p>This identifier may be 
         * needed on claims against the coverage.</p><p>At times when 
         * the ID will not be available (such as when the request has 
         * just been submitted), the attribute is 'populated'.</p> 
         * <p>Allows for referencing of a specific coverage 
         * extension.</p><p>This identifier may be needed on claims 
         * against the coverage.</p><p>At times when the ID will not be 
         * available (such as when the request has just been 
         * submitted), the attribute is 'populated'.</p> A:Coverage 
         * Extension Id <p>Unique identification for a specific 
         * coverage extension.</p> <p>Allows for referencing of a 
         * specific coverage extension.</p><p>This identifier may be 
         * needed on claims against the coverage.</p><p>At times the ID 
         * will not be available (such as when the request has just 
         * been submitted), the attribute is 'populated'.</p> <p>Allows 
         * for referencing of a specific coverage extension.</p><p>This 
         * identifier may be needed on claims against the 
         * coverage.</p><p>At times the ID will not be available (such 
         * as when the request has just been submitted), the attribute 
         * is 'populated'.</p> <p>Allows for referencing of a specific 
         * coverage extension.</p><p>This identifier may be needed on 
         * claims against the coverage.</p><p>At times the ID will not 
         * be available (such as when the request has just been 
         * submitted), the attribute is 'populated'.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"id"})]
        public Identifier Id {
            get { return this.id.Value; }
            set { this.id.Value = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"author/underwriter"})]
        public Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r01.Pharmacy.Merged.Underwriter AuthorUnderwriter {
            get { return this.authorUnderwriter; }
            set { this.authorUnderwriter = value; }
        }

    }

}