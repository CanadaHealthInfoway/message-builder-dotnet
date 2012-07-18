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
 * Last modified: $LastChangedDate: 2012-02-16 11:12:01 -0500 (Thu, 16 Feb 2012) $
 * Revision:      $LastChangedRevision: 5532 $
 */
/* This class was auto-generated by the message builder generator tools. */
namespace Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r02.Common.Mfmi_mt700711ca {
    using Ca.Infoway.Messagebuilder.Annotation;
    using Ca.Infoway.Messagebuilder.Datatype;
    using Ca.Infoway.Messagebuilder.Datatype.Impl;
    using Ca.Infoway.Messagebuilder.Domainvalue;
    using Ca.Infoway.Messagebuilder.Model;


    /**
     * <summary>Null Author Role</summary>
     * 
     * <remarks><p>This is a messaging artifact used by HL7 to 
     * allow the time, signiture and method to be captured when the 
     * author is not sent. This will happen in circumstances where 
     * the author information is sent as part of the authentication 
     * token.</p></remarks>
     */
    [Hl7PartTypeMappingAttribute(new string[] {"MFMI_MT700711CA.AuthorRole"})]
    public class NullAuthorRole : MessagePartBean, Ca.Infoway.Messagebuilder.Model.Pcs_mr2007_v02_r02.Common.Merged.IAuthorPerson {

        private CS classCode;

        public NullAuthorRole() {
            this.classCode = new CSImpl();
        }
        [Hl7XmlMappingAttribute(new string[] {"classCode"})]
        public RoleClass ClassCode {
            get { return (RoleClass) this.classCode.Value; }
            set { this.classCode.Value = value; }
        }

    }

}