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
namespace Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Lab.Merged {
    using Ca.Infoway.Messagebuilder.Annotation;
    using Ca.Infoway.Messagebuilder.Datatype;
    using Ca.Infoway.Messagebuilder.Datatype.Impl;
    using Ca.Infoway.Messagebuilder.Domainvalue;
    using Ca.Infoway.Messagebuilder.Model;
    using Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Merged;


    /**
     * <summary>POLB_MT002000CA.Receiver: (no business name)</summary>
     * 
     * <remarks><p>Distribution List</p> POLB_MT004000CA.Receiver: 
     * Electronic Receiver <p>These are the persons or 
     * organizations identifed on the Distribution List.</p> 
     * <p>Distribution List</p> POLB_MT004100CA.Receiver: (no 
     * business name) <p>Receiver Clone</p> 
     * POLB_MT004200CA.Receiver: Electronic Result Receiver 
     * <p>Identifies the healthcare providers who are to receive 
     * electronic copies of the result via the JLIS.</p></remarks>
     */
    [Hl7PartTypeMappingAttribute(new string[] {"POLB_MT002000CA.Receiver","POLB_MT004000CA.Receiver","POLB_MT004100CA.Receiver","POLB_MT004200CA.Receiver"})]
    public class ElectronicResultReceiver : MessagePartBean {

        private CS contextControlCode;
        private Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Merged.IRoleChoice roleChoice;

        public ElectronicResultReceiver() {
            this.contextControlCode = new CSImpl();
        }
        [Hl7XmlMappingAttribute(new string[] {"contextControlCode"})]
        public ContextControl ContextControlCode {
            get { return (ContextControl) this.contextControlCode.Value; }
            set { this.contextControlCode.Value = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"roleChoice"})]
        public Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Merged.IRoleChoice RoleChoice {
            get { return this.roleChoice; }
            set { this.roleChoice = value; }
        }

    }

}