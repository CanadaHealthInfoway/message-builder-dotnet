/* This class was auto-generated by the message builder generator tools. */
namespace Ca.Infoway.Messagebuilder.Model.Ab_r02_04_03_shr.Interaction {
    using Ca.Infoway.Messagebuilder.Annotation;
    using Ca.Infoway.Messagebuilder.Model;
    using Ca.Infoway.Messagebuilder.Model.Ab_r02_04_03_shr.Common.Mcai_mt700211ab;
    using Ca.Infoway.Messagebuilder.Model.Ab_r02_04_03_shr.Common.Mcci_mt002100ca;
    using Ca.Infoway.Messagebuilder.Model.Ab_r02_04_03_shr.Common.Repc_mt500001ab;


    /**
     * <summary>Business Name: REPC_IN000070AB: Record care 
     * composition request</summary>
     * 
     * <p>Seeks to add a record of an encounter, episode or similar 
     * structure for a particular patient or group of patients.</p> 
     * Message: MCCI_MT002100CA.Message Control Act: 
     * MCAI_MT700211AB.ControlActEvent --> Payload: 
     * REPC_MT500001AB.PatientCareProvisionEvent
     */
    [Hl7PartTypeMappingAttribute(new string[] {"REPC_IN000070AB"})]
    public class RecordCareCompositionRequest : HL7Message<Ca.Infoway.Messagebuilder.Model.Ab_r02_04_03_shr.Common.Mcai_mt700211ab.TriggerEvent<Ca.Infoway.Messagebuilder.Model.Ab_r02_04_03_shr.Common.Repc_mt500001ab.CareComposition>>, IInteraction {


        public RecordCareCompositionRequest() {
        }
    }

}