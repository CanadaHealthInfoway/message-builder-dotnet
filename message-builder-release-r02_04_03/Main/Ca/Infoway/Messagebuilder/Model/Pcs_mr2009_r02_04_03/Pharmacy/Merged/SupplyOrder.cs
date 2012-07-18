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
namespace Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Pharmacy.Merged {
    using Ca.Infoway.Messagebuilder.Annotation;
    using Ca.Infoway.Messagebuilder.Datatype;
    using Ca.Infoway.Messagebuilder.Datatype.Impl;
    using Ca.Infoway.Messagebuilder.Datatype.Lang;
    using Ca.Infoway.Messagebuilder.Domainvalue;
    using Ca.Infoway.Messagebuilder.Model;
    using Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Common.Merged;
    using Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Merged;
    using System.Collections.Generic;


    /**
     * <summary>PORX_MT060020CA.SupplyRequest: Prescription 
     * Reference</summary>
     * 
     * <remarks><p>A reference to the prescription order being 
     * dispensed</p> <p>Links a dispense with its parent 
     * prescription.</p> PORX_MT020050CA.SupplyRequest: Supply 
     * Order <p>Identification of the supply information. This 
     * prescription will have a supply order portion but no 
     * administration part.</p> <p>Ensures that dispenses to 
     * offices (non-patient identifiable dispenses) follow the 
     * normal dispensing rules.</p></remarks>
     */
    [Hl7PartTypeMappingAttribute(new string[] {"PORX_MT020050CA.SupplyRequest","PORX_MT060020CA.SupplyRequest"})]
    public class SupplyOrder : MessagePartBean {

        private SET<II, Identifier> id;
        private CS statusCode;
        private Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Common.Merged.HealthcareWorker responsiblePartyAssignedEntity;
        private Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Merged.PrescribedBy author;

        public SupplyOrder() {
            this.id = new SETImpl<II, Identifier>(typeof(IIImpl));
            this.statusCode = new CSImpl();
        }
        /**
         * <summary>PrescriptionIdentifier</summary>
         * 
         * <remarks>A:Prescription Identifier <p>This is an identifier 
         * assigned to a specific device order. The number remains 
         * constant across the lifetime of the order, regardless of the 
         * number of providers or pharmacies involved in fulfilling the 
         * order.</p> <p>Allows prescriptions to be uniquely referenced 
         * and associated with the dispense.</p><p>The ID is mandatory 
         * because the DIS would always assign a Prescription 
         * Number.</p> <p>Allows prescriptions to be uniquely 
         * referenced and associated with the dispense.</p><p>The ID is 
         * mandatory because the DIS would always assign a Prescription 
         * Number.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"id"})]
        public ICollection<Identifier> Id {
            get { return this.id.RawSet(); }
        }

        /**
         * <summary>PrescriptionStatus</summary>
         * 
         * <remarks>Prescription Status <p>Provides the status of the 
         * prescription without requiring additional queries</p> 
         * <p>Needed in some jurisdictions</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"statusCode"})]
        public ActStatus StatusCode {
            get { return (ActStatus) this.statusCode.Value; }
            set { this.statusCode.Value = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"responsibleParty/assignedEntity"})]
        public Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Common.Merged.HealthcareWorker ResponsiblePartyAssignedEntity {
            get { return this.responsiblePartyAssignedEntity; }
            set { this.responsiblePartyAssignedEntity = value; }
        }

        [Hl7XmlMappingAttribute(new string[] {"author"})]
        public Ca.Infoway.Messagebuilder.Model.Pcs_mr2009_r02_04_03.Merged.PrescribedBy Author {
            get { return this.author; }
            set { this.author = value; }
        }

    }

}