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
 * Last modified: $LastChangedDate: 2012-01-18 21:08:39 -0500 (Wed, 18 Jan 2012) $
 * Revision:      $LastChangedRevision: 3976 $
 */

/* This class was auto-generated by the message builder generator tools. */
namespace Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Lab.Merged {
    using Ca.Infoway.Messagebuilder;
    using Ca.Infoway.Messagebuilder.Annotation;
    using Ca.Infoway.Messagebuilder.Datatype;
    using Ca.Infoway.Messagebuilder.Datatype.Impl;
    using Ca.Infoway.Messagebuilder.Model;


    /**
     * <summary>ReferralRedirectIndicator</summary>
     * 
     * <remarks>POLB_MT001000CA.ReferralRedirectIndicator: Referral 
     * Redirect Indicator <p>This referral redirect flag object is 
     * present and the code is set to &quot;referral&quot; when the 
     * order is a referral order (an order from labA to labB, labA 
     * will report all results), set to &quot;redirect&quot; when 
     * the order is a redirect order (an order from labA to labB, 
     * labB will report the results to ordering provider), or this 
     * object is absent from orders requested by providers.</p> 
     * <p>OLIS needs a flag at the ObservationRequest level test 
     * request to identify a &quot;reference&quot; test request 
     * because this limits the visibility of the test request in 
     * OLIS to the laboratory sector (i.e., practitioners and 
     * hospitals can't retrieve reference test requests).</p> 
     * POLB_MT001001CA.ReferralRedirectIndicator: Referral Redirect 
     * Indicator <p>This referral redirect flag object is present 
     * and the code is set to &quot;referral&quot; when the order 
     * is a referral order (an order from labA to labB, labA will 
     * report all results), set to &quot;redirect&quot; when the 
     * order is a redirect order (an order from labA to labB, labB 
     * will report the results to ordering provider), or this 
     * object is absent from orders requested by providers.</p> 
     * <p>OLIS needs a flag at the ObservationRequest level test 
     * request to identify a &quot;reference&quot; test request 
     * because this limits the visibility of the test request in 
     * OLIS to the laboratory sector (i.e., practitioners and 
     * hospitals can't retrieve reference test requests).</p> 
     * POLB_MT001999CA.ReferralRedirectIndicator: Referral Redirect 
     * Indicator <p>This referral redirect flag object is present 
     * and the code is set to &quot;referral&quot; when the order 
     * is a referral order (an order from labA to labB, labA will 
     * report all results), set to &quot;redirect&quot; when the 
     * order is a redirect order (an order from labA to labB, labB 
     * will report the results to ordering provider), or this 
     * object is absent from orders requested by providers.</p> 
     * <p>OLIS needs a flag at the ObservationRequest level test 
     * request to identify a &quot;reference&quot; test request 
     * because this limits the visibility of the test request in 
     * OLIS to the laboratory sector (i.e., practitioners and 
     * hospitals can't retrieve reference test requests).</p> 
     * POLB_MT001010CA.ReferralRedirectIndicator: Referral Redirect 
     * Indicator <p>This referral redirect flag object is present 
     * and the code is set to &quot;referral&quot; when the order 
     * is a referral order (an order from labA to labB, labA will 
     * report all results), set to &quot;redirect&quot; when the 
     * order is a redirect order (an order from labA to labB, labB 
     * will report the results to ordering provider), or this 
     * object is absent from orders requested by providers.</p> 
     * <p>OLIS needs a flag at the ObservationRequest level test 
     * request to identify a &quot;reference&quot; test request 
     * because this limits the visibility of the test request in 
     * OLIS to the laboratory sector (i.e., practitioners and 
     * hospitals can't retrieve reference test requests).</p></remarks>
     */
    [Hl7PartTypeMappingAttribute(new string[] {"POLB_MT001000CA.ReferralRedirectIndicator","POLB_MT001001CA.ReferralRedirectIndicator","POLB_MT001010CA.ReferralRedirectIndicator","POLB_MT001999CA.ReferralRedirectIndicator"})]
    public class ReferralRedirectIndicator : MessagePartBean {

        private CD code;

        public ReferralRedirectIndicator() {
            this.code = new CDImpl();
        }
        /**
         * <summary>ReferralRedirectIndicator</summary>
         * 
         * <remarks>O:Referral Redirect Indicator <p>Describes this act 
         * event as a referral or redirect indicator act.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"code"})]
        public Code Code {
            get { return (Code) this.code.Value; }
            set { this.code.Value = value; }
        }

    }

}