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
namespace Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Iehr.Merged {
    using Ca.Infoway.Messagebuilder.Annotation;
    using Ca.Infoway.Messagebuilder.Datatype;
    using Ca.Infoway.Messagebuilder.Datatype.Impl;
    using Ca.Infoway.Messagebuilder.Datatype.Lang;
    using Ca.Infoway.Messagebuilder.Domainvalue;
    using Ca.Infoway.Messagebuilder.Model;


    /**
     * <summary>Request</summary>
     * 
     * <remarks>REPC_MT610002CA.ActRequest: A:Request </p> </p> 
     * REPC_MT610001CA.ActRequest: A:Request </p> </p></remarks>
     */
    [Hl7PartTypeMappingAttribute(new string[] {"REPC_MT610001CA.ActRequest","REPC_MT610002CA.ActRequest"})]
    public class Request_3 : MessagePartBean {

        private CS classCode;
        private II id;
        private Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Iehr.Merged.RequestedBy author;

        public Request_3() {
            this.classCode = new CSImpl();
            this.id = new IIImpl();
        }
        /**
         * <summary>RequestType</summary>
         * 
         * <remarks>B:Request Type </p> </p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"classCode"})]
        public x_ActClassCareProvisionProcedure ClassCode {
            get { return (x_ActClassCareProvisionProcedure) this.classCode.Value; }
            set { this.classCode.Value = value; }
        }

        /**
         * <summary>RequestId</summary>
         * 
         * <remarks>A: Request Id </p> </p> </p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"id"})]
        public Identifier Id {
            get { return this.id.Value; }
            set { this.id.Value = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"author"})]
        public Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Iehr.Merged.RequestedBy Author {
            get { return this.author; }
            set { this.author = value; }
        }

    }

}