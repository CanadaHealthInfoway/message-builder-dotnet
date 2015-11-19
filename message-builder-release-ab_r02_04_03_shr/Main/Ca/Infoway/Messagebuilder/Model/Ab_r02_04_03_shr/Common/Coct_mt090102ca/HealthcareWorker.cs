/* This class was auto-generated by the message builder generator tools. */
namespace Ca.Infoway.Messagebuilder.Model.Ab_r02_04_03_shr.Common.Coct_mt090102ca {
    using Ca.Infoway.Messagebuilder.Annotation;
    using Ca.Infoway.Messagebuilder.Datatype;
    using Ca.Infoway.Messagebuilder.Datatype.Impl;
    using Ca.Infoway.Messagebuilder.Datatype.Lang;
    using Ca.Infoway.Messagebuilder.Model;
    using System;


    /**
     * <summary>Business Name: Healthcare Worker</summary>
     * 
     * <p>Critical to tracking responsibility and performing 
     * follow-up. The CMET supports both licensed providers as well 
     * as non-licensed providers such as technicians, 
     * receptionists, etc.</p> <p>The person assigned to carry out 
     * the associated action (linked by a participation) and/or the 
     * organization/group under whose authority they are 
     * acting.</p>
     */
    [Hl7PartTypeMappingAttribute(new string[] {"COCT_MT090102CA.AssignedEntity"})]
    public class HealthcareWorker : MessagePartBean, Ca.Infoway.Messagebuilder.Model.Ab_r02_04_03_shr.Common.Coct_mt911102ca.IActingPerson, Ca.Infoway.Messagebuilder.Model.Ab_r02_04_03_shr.Common.Coct_mt470002ab.IRecipient {

        private II id;
        private PN assignedPersonName;
        private II assignedPersonAsHealthCareProviderId;
        private II representedOrganizationId;
        private ST representedOrganizationName;

        public HealthcareWorker() {
            this.id = new IIImpl();
            this.assignedPersonName = new PNImpl();
            this.assignedPersonAsHealthCareProviderId = new IIImpl();
            this.representedOrganizationId = new IIImpl();
            this.representedOrganizationName = new STImpl();
        }
        /**
         * <summary>Business Name: A: Healthcare Worker Identifier</summary>
         * 
         * <remarks>Relationship: COCT_MT090102CA.AssignedEntity.id 
         * Conformance/Cardinality: MANDATORY (1) <p>Allows unique 
         * identification of the person which can be critical for 
         * authentication, permissions, drill-down and traceability and 
         * is therefore mandatory.</p> <p>Unique identifier the person 
         * involved in the action.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"id"})]
        public Identifier Id {
            get { return this.id.Value; }
            set { this.id.Value = value; }
        }

        /**
         * <summary>Business Name: B: Healthcare Worker Name</summary>
         * 
         * <remarks>Relationship: COCT_MT090102CA.Person.name 
         * Conformance/Cardinality: MANDATORY (1) <p>This is a 
         * human-readable name and is essential for validation of the 
         * person. As a result, the attribute is mandatory</p> <p>The 
         * name of the involved person.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"assignedPerson/name"})]
        public PersonName AssignedPersonName {
            get { return this.assignedPersonName.Value; }
            set { this.assignedPersonName.Value = value; }
        }

        /**
         * <summary>Business Name: C: License Number</summary>
         * 
         * <remarks>Relationship: COCT_MT090102CA.HealthCareProvider.id 
         * Conformance/Cardinality: MANDATORY (1) <p>Allows lookup on 
         * college website, confirmation of identity, etc. Regulations 
         * occasionally require license numbers to be specified as part 
         * of clinical records.</p> <p>If the identifier used in the 
         * root of the CMET is the same as the license number, the 
         * license number should be sent in both places.</p> <p>The 
         * license number issued to the provider and relevant to the 
         * current action.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"assignedPerson/asHealthCareProvider/id"})]
        public Identifier AssignedPersonAsHealthCareProviderId {
            get { return this.assignedPersonAsHealthCareProviderId.Value; }
            set { this.assignedPersonAsHealthCareProviderId.Value = value; }
        }

        /**
         * <summary>Business Name: D: Organization identifier</summary>
         * 
         * <remarks>Relationship: COCT_MT090102CA.Organization.id 
         * Conformance/Cardinality: MANDATORY (1) <p>Allows the 
         * organization to be referenced when determining privileges 
         * and for drill-downs to retrieve additional information. 
         * Because of its importance, the attribute is mandatory.</p> 
         * <p>A unique identifier for the organization</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"representedOrganization/id"})]
        public Identifier RepresentedOrganizationId {
            get { return this.representedOrganizationId.Value; }
            set { this.representedOrganizationId.Value = value; }
        }

        /**
         * <summary>Business Name: E: Organization Name</summary>
         * 
         * <remarks>Relationship: COCT_MT090102CA.Organization.name 
         * Conformance/Cardinality: MANDATORY (1) <p>Allows for human 
         * recognition of the organization as well as confirmation of 
         * the identifier. As a result, the attribute is mandatory.</p> 
         * <p>Identifies the name of the organization</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"representedOrganization/name"})]
        public String RepresentedOrganizationName {
            get { return this.representedOrganizationName.Value; }
            set { this.representedOrganizationName.Value = value; }
        }

    }

}