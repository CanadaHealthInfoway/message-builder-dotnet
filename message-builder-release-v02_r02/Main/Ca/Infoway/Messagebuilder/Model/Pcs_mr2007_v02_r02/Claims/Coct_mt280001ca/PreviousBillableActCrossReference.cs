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
namespace Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r02.Claims.Coct_mt280001ca {
    using Ca.Infoway.Messagebuilder.Annotation;
    using Ca.Infoway.Messagebuilder.Datatype;
    using Ca.Infoway.Messagebuilder.Datatype.Impl;
    using Ca.Infoway.Messagebuilder.Datatype.Lang;
    using Ca.Infoway.Messagebuilder.Model;
    using System.Collections.Generic;


    /**
     * <summary>Previous Billable Act Cross Reference</summary>
     * 
     * <remarks><p>Used to reference a previous act (e.g. billable 
     * act) by including its Act.id. May only be used to reference 
     * a billable act in the SAME message, not for past messages 
     * (this would require adjudicators to keep a lot of 
     * history).</p> <p>Used to reference a previous act (e.g. 
     * billable act) by including its Act.id. May only be used to 
     * reference a billable act in the SAME message, not for past 
     * messages (this would require adjudicators to keep a lot of 
     * history).</p></remarks>
     */
    [Hl7PartTypeMappingAttribute(new string[] {"COCT_MT280001CA.CrossReference"})]
    public class PreviousBillableActCrossReference : MessagePartBean, Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r02.Claims.Coct_mt280001ca.IA_BillableActChoice {

        private SET<II, Identifier> id;

        public PreviousBillableActCrossReference() {
            this.id = new SETImpl<II, Identifier>(typeof(IIImpl));
        }
        /**
         * <summary>) (Act.id.</summary>
         * 
         * <remarks><p>Act.id. referencing a previous act (e.g. 
         * billable act) in the SAME message,</p> <p>Used to reference 
         * a previous act (e.g. billable act) by including its Act.id. 
         * May only be used to reference a billable act in the SAME 
         * message, not for past messages (this would require 
         * adjudicators to keep a lot of history).</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"id"})]
        public ICollection<Identifier> Id {
            get { return this.id.RawSet(); }
        }

    }

}