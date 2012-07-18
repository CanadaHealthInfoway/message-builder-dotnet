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
namespace Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Common.Coct_mt300000ca {
    using Ca.Infoway.Messagebuilder.Annotation;
    using Ca.Infoway.Messagebuilder.Datatype;
    using Ca.Infoway.Messagebuilder.Datatype.Impl;
    using Ca.Infoway.Messagebuilder.Datatype.Lang;
    using Ca.Infoway.Messagebuilder.Model;


    /**
     * <summary>Playing Prescribe Person</summary>
     * 
     * <remarks><p>ID cannot be mandatory as it may not be present 
     * on a pre-determination</p></remarks>
     */
    [Hl7PartTypeMappingAttribute(new string[] {"COCT_MT300000CA.PresriberRole"})]
    public class PlayingPrescribePerson : MessagePartBean {

        private II id;
        private Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Common.Coct_mt300000ca.PersonPrescribing playingPrescriberPerson;

        public PlayingPrescribePerson() {
            this.id = new IIImpl();
        }
        /**
         * <summary>Prescriber ID</summary>
         * 
         * <remarks><p>Prescriber ID</p> <p>This is mandatory for 
         * Invoices and required with nullFlavor for 
         * Pre-Determinations.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"id"})]
        public Identifier Id {
            get { return this.id.Value; }
            set { this.id.Value = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"playingPrescriberPerson"})]
        public Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Common.Coct_mt300000ca.PersonPrescribing PlayingPrescriberPerson {
            get { return this.playingPrescriberPerson; }
            set { this.playingPrescriberPerson = value; }
        }

    }

}