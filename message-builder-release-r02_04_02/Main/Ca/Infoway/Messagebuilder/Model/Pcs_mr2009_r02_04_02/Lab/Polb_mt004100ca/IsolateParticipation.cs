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
    using Ca.Infoway.Messagebuilder.Model;


    /**
     * <summary>Isolate Participation</summary>
     * 
     * <remarks><p>Associates the isolate specimen and specimen 
     * material (identification of the microorganism) with the 
     * grouper specimen cluster (object).</p></remarks>
     */
    [Hl7PartTypeMappingAttribute(new string[] {"POLB_MT004100CA.Specimen2"})]
    public class IsolateParticipation : MessagePartBean {

        private Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Lab.Polb_mt004100ca.Isolate isolate;

        public IsolateParticipation() {
        }
        [Hl7XmlMappingAttribute(new string[] {"isolate"})]
        public Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Lab.Polb_mt004100ca.Isolate Isolate {
            get { return this.isolate; }
            set { this.isolate = value; }
        }

    }

}