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
 * Last modified: $LastChangedDate: 2012-02-16 11:02:17 -0500 (Thu, 16 Feb 2012) $
 * Revision:      $LastChangedRevision: 5407 $
 */
/* This class was auto-generated by the message builder generator tools. */
namespace Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r01.Merged {
    using Ca.Infoway.Messagebuilder.Annotation;
    using Ca.Infoway.Messagebuilder.Datatype;
    using Ca.Infoway.Messagebuilder.Datatype.Impl;
    using Ca.Infoway.Messagebuilder.Datatype.Lang;
    using Ca.Infoway.Messagebuilder.Model;
    using System;


    /**
     * <summary>Manufacturer</summary>
     * 
     * <remarks>POME_MT010040CA.Manufacturer: Manufacturer 
     * <p>Identity of the organization that manufactured the drug 
     * product.</p> <p>Useful in distinguishing and grouping drug 
     * products</p> POME_MT010100CA.Manufacturer: Manufacturer 
     * <p>Identity of the organization that manufactured the drug 
     * product.</p> <p>Useful in distinguishing and grouping drug 
     * products</p> COCT_MT220210CA.Manufacturer: Manufacturer 
     * <p>Identity of the organization that manufactured the drug 
     * product.</p> <p>Useful in distinguishing and grouping drug 
     * products</p> COCT_MT220110CA.Manufacturer: Manufacturer 
     * <p>Identity of the organization that manufactured the drug 
     * product.</p> <p>Useful in distinguishing and grouping drug 
     * products</p></remarks>
     */
    [Hl7PartTypeMappingAttribute(new string[] {"COCT_MT220110CA.Manufacturer","COCT_MT220210CA.Manufacturer","POME_MT010040CA.Manufacturer","POME_MT010100CA.Manufacturer"})]
    public class Manufacturer : MessagePartBean {

        private II id;
        private ST name;

        public Manufacturer() {
            this.id = new IIImpl();
            this.name = new STImpl();
        }
        /**
         * <summary>Manufacturer Id</summary>
         * 
         * <remarks><p>An identifier denoting a specific drug 
         * manufacturer.</p> <p>Allows sending of identifiers in place 
         * of manufacturer name. May be used in drug search where 
         * specific manufacturer is a criterion.</p> Organization Id 
         * <p>An identifier denoting a specific drug manufacturer.</p> 
         * <p>Allows sending of identifiers in place of manufacturer 
         * name. May be used in drug search where specific manufacturer 
         * is a criterion.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"id"})]
        public Identifier Id {
            get { return this.id.Value; }
            set { this.id.Value = value; }
        }

        /**
         * <summary>ManufacturerName</summary>
         * 
         * <remarks>Manufacturer Name <p>The name of the drug 
         * manufacturer.</p> <p>Used for reporting.</p><p>The attribute 
         * is marked as &quot;mandatory&quot; because there will always 
         * be a name for an organization.</p> <p>Used for 
         * reporting.</p><p>The attribute is marked as 
         * &quot;mandatory&quot; because there will always be a name 
         * for an organization.</p> Manufacturer Name <p>The name of 
         * the drug manufacturer.</p> <p>Used in reporting.</p><p>The 
         * attribute is marked as &quot;mandatory&quot; because there 
         * will always be a name for an organization.</p> <p>Used in 
         * reporting.</p><p>The attribute is marked as 
         * &quot;mandatory&quot; because there will always be a name 
         * for an organization.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"name"})]
        public String Name {
            get { return this.name.Value; }
            set { this.name.Value = value; }
        }

    }

}