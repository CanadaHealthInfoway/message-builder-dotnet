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
    using System.Collections.Generic;


    /**
     * <summary>Business Name: Geographic Coordinates</summary>
     * 
     * <p>Some locations cannot be described by postal addresses. 
     * Also, geographic coordinates allow calculation of distances 
     * and proximity</p> <p>Allows the capturing of a physical 
     * location according to a particular coordinate system, such 
     * as GPS, legal designation (lot, block, plan), 
     * range-meridian, etc.</p>
     */
    [Hl7PartTypeMappingAttribute(new string[] {"COCT_MT960002CA.Position"})]
    public class GeographicCoordinates : MessagePartBean {

        private CV code;
        private IList<Ca.Infoway.Messagebuilder.Model.Ab_r02_04_03_shr.Common.Coct_mt960002ca.CoordinateAxis> componentPositionCoordinate;

        public GeographicCoordinates() {
            this.code = new CVImpl();
            this.componentPositionCoordinate = new List<Ca.Infoway.Messagebuilder.Model.Ab_r02_04_03_shr.Common.Coct_mt960002ca.CoordinateAxis>();
        }
        /**
         * <summary>Business Name: Coordinate System</summary>
         * 
         * <remarks>Relationship: COCT_MT960002CA.Position.code 
         * Conformance/Cardinality: MANDATORY (1) <p>Essential for 
         * interpretting the specified coordinates and therefore 
         * mandatory</p> <p>Identifies the coordinate system inclusive 
         * of any transformation projections.</p></remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"code"})]
        public ObservationCoordinateSystemType Code {
            get { return (ObservationCoordinateSystemType) this.code.Value; }
            set { this.code.Value = value; }
        }

        /**
         * <summary>Relationship: 
         * COCT_MT960002CA.Component1.positionCoordinate</summary>
         * 
         * <remarks>Conformance/Cardinality: MANDATORY (1)</remarks>
         */
        [Hl7XmlMappingAttribute(new string[] {"component/positionCoordinate"})]
        public IList<Ca.Infoway.Messagebuilder.Model.Ab_r02_04_03_shr.Common.Coct_mt960002ca.CoordinateAxis> ComponentPositionCoordinate {
            get { return this.componentPositionCoordinate; }
        }

    }

}