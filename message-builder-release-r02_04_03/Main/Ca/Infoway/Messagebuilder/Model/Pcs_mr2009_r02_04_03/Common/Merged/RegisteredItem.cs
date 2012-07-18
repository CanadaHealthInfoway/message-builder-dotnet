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
namespace Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Common.Merged {
    using Ca.Infoway.Messagebuilder.Annotation;
    using Ca.Infoway.Messagebuilder.Model;


    /**
     * <summary>RegisteredItem</summary>
     * 
     * <remarks>MFMI_MT700746CA.Subject4: Registered Item 
     * <p>Commonly called the Payload stub. Any interaction that 
     * uses this ControlAct Wrapper will replace this class with a 
     * Role-based domain Message Type</p> <p>Defines the content of 
     * the registration and is therefore mandatory.</p> 
     * MFMI_MT700717CA.Subject4: Registered Item <p>Commonly called 
     * the Payload stub. Any interaction that uses this ControlAct 
     * Wrapper will replace this class with a Role-based domain 
     * Message Type</p> <p>Defines the content of the registration 
     * and is therefore mandatory.</p> MFMI_MT700711CA.Subject4: 
     * Registered Item <p>Commonly called the Payload stub. Any 
     * interaction that uses this ControlAct Wrapper will replace 
     * this class with a Role-based domain Message Type</p> 
     * <p>Defines the content of the registration and is therefore 
     * mandatory.</p> MFMI_MT700726CA.Subject4: Registered Item 
     * <p>Commonly called the Payload stub. Any interaction that 
     * uses this ControlAct Wrapper will replace this class with a 
     * Role-based domain Message Type</p> <p>Defines the content of 
     * the registration and is therefore mandatory.</p> 
     * MFMI_MT700716CA.Subject4: Registered Item <p>Commonly called 
     * the Payload stub. Any interaction that uses this ControlAct 
     * Wrapper will replace this class with a Role-based domain 
     * Message Type</p> <p>Defines the content of the registration 
     * and is therefore mandatory.</p></remarks>
     */
    [Hl7PartTypeMappingAttribute(new string[] {"MFMI_MT700711CA.Subject4","MFMI_MT700716CA.Subject4","MFMI_MT700717CA.Subject4","MFMI_MT700726CA.Subject4","MFMI_MT700746CA.Subject4"})]
    public class RegisteredItem<RR> : MessagePartBean {

        private RR registeredRole;

        public RegisteredItem() {
        }
        [Hl7XmlMappingAttribute(new string[] {"registeredRole"})]
        public RR RegisteredRole {
            get { return this.registeredRole; }
            set { this.registeredRole = value; }
        }

    }

}