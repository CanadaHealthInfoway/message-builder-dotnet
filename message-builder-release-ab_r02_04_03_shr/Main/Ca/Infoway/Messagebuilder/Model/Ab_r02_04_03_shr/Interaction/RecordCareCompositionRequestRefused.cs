/* This class was auto-generated by the message builder generator tools. */
namespace Ca.Infoway.Messagebuilder.Model.Ab_r02_04_03_shr.Interaction {
    using Ca.Infoway.Messagebuilder.Annotation;
    using Ca.Infoway.Messagebuilder.Model;
    using Ca.Infoway.Messagebuilder.Model.Ab_r02_04_03_shr.Common.Mcai_mt700237ab;
    using Ca.Infoway.Messagebuilder.Model.Ab_r02_04_03_shr.Common.Mcci_mt002300ca;


    /**
     * <summary>Business Name: REPC_IN000072AB: Record care 
     * composition request refused</summary>
     * 
     * <p>Indicates request to record basic information about an 
     * encounter, episode or similar structure for a particular 
     * patient or group of patients has been refused.</p> Message: 
     * MCCI_MT002300CA.Message Control Act: 
     * MCAI_MT700237AB.ControlActEvent
     */
    [Hl7PartTypeMappingAttribute(new string[] {"REPC_IN000072AB"})]
    public class RecordCareCompositionRequestRefused : HL7Message<Ca.Infoway.Messagebuilder.Model.Ab_r02_04_03_shr.Common.Mcai_mt700237ab.TriggerEvent>, IInteraction {


        public RecordCareCompositionRequestRefused() {
        }
    }

}