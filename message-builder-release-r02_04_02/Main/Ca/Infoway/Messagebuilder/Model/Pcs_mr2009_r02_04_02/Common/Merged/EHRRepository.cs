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
 * Last modified: $LastChangedDate: 2012-01-18 21:05:07 -0500 (Wed, 18 Jan 2012) $
 * Revision:      $LastChangedRevision: 3929 $
 */

/* This class was auto-generated by the message builder generator tools. */
namespace Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Common.Merged {
    using Ca.Infoway.Messagebuilder.Annotation;
    using Ca.Infoway.Messagebuilder.Datatype;
    using Ca.Infoway.Messagebuilder.Datatype.Impl;
    using Ca.Infoway.Messagebuilder.Datatype.Lang;
    using Ca.Infoway.Messagebuilder.Model;
    using System;


    /**
     * <summary>COCT_MT090310CA.AssignedDevice: EHR Repository</summary>
     * 
     * <remarks><p>Identification of the EHR infostructure 
     * responsible for the storage and management of the 
     * record.</p> <p>Provides context about the record and its 
     * management.</p> COCT_MT090302CA.AssignedDevice: Application 
     * <p>A reference to a system/application related to healthcare 
     * information.</p> <p>Allows an application to be uniquely 
     * identified.</p></remarks>
     */
    [Hl7PartTypeMappingAttribute(new string[] {"COCT_MT090302CA.AssignedDevice","COCT_MT090310CA.AssignedDevice"})]
    public class EHRRepository : MessagePartBean, Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_02.Pharmacy.Merged.IChangedBy {

        private II id;
        private ST repositoryName;
        private ST repositoryJurisdictionName;
        private ST applicationName;

        public EHRRepository() {
            this.id = new IIImpl();
            this.repositoryName = new STImpl();
            this.repositoryJurisdictionName = new STImpl();
            this.applicationName = new STImpl();
        }
        /**
         * <summary>Repository Identifier</summary>
         * 
         * <remarks><p>A unique identifier for the EHR repository.</p> 
         * <p>Allows repositories to be uniquely identified for linking 
         * or grouping purposes and is therefore mandatory.</p> 
         * C:Application Id <p>Unique identifier of an application or a 
         * system.</p> <p>PVD.020-01 (extension)</p><p>PVD.020-02 
         * (root)</p><p>Dispensing Pharmacy number</p><p>Pharmacy 
         * Identifier</p><p>Facility.facilityKey</p><p>DispensedItem.facilityKey</p> 
         * <p>PVD.020-01 (extension)</p><p>PVD.020-02 
         * (root)</p><p>Dispensing Pharmacy number</p><p>Pharmacy 
         * Identifier</p><p>Facility.facilityKey</p><p>DispensedItem.facilityKey</p> 
         * <p>PVD.020-01 (extension)</p><p>PVD.020-02 
         * (root)</p><p>Dispensing Pharmacy number</p><p>Pharmacy 
         * Identifier</p><p>Facility.facilityKey</p><p>DispensedItem.facilityKey</p> 
         * <p>PVD.020-01 (extension)</p><p>PVD.020-02 
         * (root)</p><p>Dispensing Pharmacy number</p><p>Pharmacy 
         * Identifier</p><p>Facility.facilityKey</p><p>DispensedItem.facilityKey</p> 
         * <p>PVD.020-01 (extension)</p><p>PVD.020-02 
         * (root)</p><p>Dispensing Pharmacy number</p><p>Pharmacy 
         * Identifier</p><p>Facility.facilityKey</p><p>DispensedItem.facilityKey</p> 
         * <p>PVD.020-01 (extension)</p><p>PVD.020-02 
         * (root)</p><p>Dispensing Pharmacy number</p><p>Pharmacy 
         * Identifier</p><p>Facility.facilityKey</p><p>DispensedItem.facilityKey</p> 
         * <p>To uniquely identify an 
         * application/system.</p><p>Attribute is mandatory to allow 
         * for distinguishing different applications/systems.</p> <p>To 
         * uniquely identify an application/system.</p><p>Attribute is 
         * mandatory to allow for distinguishing different 
         * applications/systems.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"id"})]
        public Identifier Id {
            get { return this.id.Value; }
            set { this.id.Value = value; }
        }

        /**
         * <summary>RepositoryName</summary>
         * 
         * <remarks>Repository Name <p>The name of the repository which 
         * is responsible for maintaining the record. E.g. 
         * &quot;Ontario Health Respository #3&quot;</p> <p>Provides a 
         * human-readable name for the repository and is therefore 
         * mandatory</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"assignedRepository/name"})]
        public String RepositoryName {
            get { return this.repositoryName.Value; }
            set { this.repositoryName.Value = value; }
        }

        /**
         * <summary>RepositoryJurisdictionName</summary>
         * 
         * <remarks>Repository Jurisdiction Name <p>The name of the 
         * jurisdiction that is responsible for the EHR infostructure 
         * that contains and manages the record.</p> <p>Establishes 
         * business context for determining custodianship, and is 
         * therefore mandatory.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"representedRepositoryJurisdiction/name"})]
        public String RepositoryJurisdictionName {
            get { return this.repositoryJurisdictionName.Value; }
            set { this.repositoryJurisdictionName.Value = value; }
        }

        /**
         * <summary>ApplicationName</summary>
         * 
         * <remarks>B: Application Name <p>The name assigned to the 
         * application/system.</p> <p>PVD.070</p><p>Dispensing Pharmacy 
         * Name</p><p>Facility.name</p> <p>PVD.070</p><p>Dispensing 
         * Pharmacy Name</p><p>Facility.name</p> 
         * <p>PVD.070</p><p>Dispensing Pharmacy 
         * Name</p><p>Facility.name</p> <p>Used for human 
         * communication. The name of the application must be known and 
         * is therefore marked as 'mandatory'.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"assignedDevice/manufacturerModelName"})]
        public String ApplicationName {
            get { return this.applicationName.Value; }
            set { this.applicationName.Value = value; }
        }

    }

}