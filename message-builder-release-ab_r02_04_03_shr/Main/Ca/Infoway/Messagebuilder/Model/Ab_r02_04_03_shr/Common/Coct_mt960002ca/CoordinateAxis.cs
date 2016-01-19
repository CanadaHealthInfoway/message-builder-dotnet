/**
 * Copyright 2013 Canada Health Infoway, Inc.
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
 * Author:        $LastChangedBy: gng $
 * Last modified: $LastChangedDate: 2015-11-19 18:20:12 -0500 (Fri, 30 Jan 2015) $
 * Revision:      $LastChangedRevision: 9755 $
 */

/* This class was auto-generated by the message builder generator tools. */
namespace Ca.Infoway.Messagebuilder.Model.Ab_r02_04_03_shr.Common.Coct_mt960002ca {
    using Ca.Infoway.Messagebuilder.Annotation;
    using Ca.Infoway.Messagebuilder.Datatype;
    using Ca.Infoway.Messagebuilder.Datatype.Impl;
    using Ca.Infoway.Messagebuilder.Model;
    using Ca.Infoway.Messagebuilder.Model.Ab_r02_04_03_shr.Domainvalue;
    using System;


    /**
     * <summary>Business Name: Coordinate Axis</summary>
     * 
     * <p>Defines the position of the location</p> <p>Describes the 
     * postion of the location along a specific axis.</p>
     */
    [Hl7PartTypeMappingAttribute(new string[] {"COCT_MT960002CA.PositionCoordinate"})]
    public class CoordinateAxis : MessagePartBean {

        private CV code;
        private REAL value;

        public CoordinateAxis() {
            this.code = new CVImpl();
            this.value = new REALImpl();
        }
        /**
         * <summary>Business Name: Coordinate Axis Type</summary>
         * 
         * <remarks>Relationship: 
         * COCT_MT960002CA.PositionCoordinate.code 
         * Conformance/Cardinality: MANDATORY (1) <p>Acts as the 
         * &quot;name&quot; in the name-value pair that expresses a 
         * coordinate and is therefore mandatory</p> <p>Identifies the 
         * individual coordinate in the coordinate system inclusive of 
         * any transformations or projections.</p><p>Examples of 
         * corordinate types are: meridian, range, township, longitude, 
         * latitude, lot, block, etc.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"code"})]
        public ObservationCoordinateAxisType Code {
            get { return (ObservationCoordinateAxisType) this.code.Value; }
            set { this.code.Value = value; }
        }

        /**
         * <summary>Business Name: Coordinate Axis Value</summary>
         * 
         * <remarks>Relationship: 
         * COCT_MT960002CA.PositionCoordinate.value 
         * Conformance/Cardinality: MANDATORY (1) <p>Actually expresses 
         * the location along the axis. Because unknown axis positions 
         * can simply be omitted, this attribute is mandatory.</p> 
         * <p>Denotes the individual coordinate value as a a physical 
         * quantity. For example, lot number, range number, latitude, 
         * etc.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"value"})]
        public BigDecimal Value {
            get { return this.value.Value; }
            set { this.value.Value = value; }
        }

    }

}