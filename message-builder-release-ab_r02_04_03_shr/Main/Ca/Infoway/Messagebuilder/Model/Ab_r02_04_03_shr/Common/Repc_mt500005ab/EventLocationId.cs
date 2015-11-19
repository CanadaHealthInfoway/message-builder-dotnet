/* This class was auto-generated by the message builder generator tools. */
namespace Ca.Infoway.Messagebuilder.Model.Ab_r02_04_03_shr.Common.Repc_mt500005ab {
    using Ca.Infoway.Messagebuilder.Annotation;
    using Ca.Infoway.Messagebuilder.Datatype;
    using Ca.Infoway.Messagebuilder.Datatype.Impl;
    using Ca.Infoway.Messagebuilder.Datatype.Lang;
    using Ca.Infoway.Messagebuilder.Model;
    using System.Collections.Generic;


    [Hl7PartTypeMappingAttribute(new string[] {"REPC_MT500005AB.EventLocationId"})]
    public class EventLocationId : MessagePartBean {

        private SET<II, Identifier> value;

        public EventLocationId() {
            this.value = new SETImpl<II, Identifier>(typeof(IIImpl));
        }
        /**
         * <summary>Business Name: Event Location Id</summary>
         * 
         * <remarks>Relationship: REPC_MT500005AB.EventLocationId.value 
         * Conformance/Cardinality: MANDATORY (*) <p>Allows retrieving 
         * those records associated with a particular facility.</p> 
         * <p>Filters the records retrieved to only include those 
         * records which are officially associated with and/or were 
         * performed by a particular facility. I.e. It will return 
         * records where either the &quot;Service Location&quot; or the 
         * &quot;Record Location&quot; has the specified location id. 
         * Records associated with &quot;sub-locations&quot; (e.g. 
         * departments, wards) will be returned when searching by the 
         * larger location (e.g. hospital).</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"value"})]
        public ICollection<Identifier> Value {
            get { return this.value.RawSet(); }
        }

    }

}