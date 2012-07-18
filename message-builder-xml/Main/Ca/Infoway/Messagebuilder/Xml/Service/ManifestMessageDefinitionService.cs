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
 * Last modified: $LastChangedDate: 2012-01-18 21:44:48 -0500 (Wed, 18 Jan 2012) $
 * Revision:      $LastChangedRevision: 4355 $
 */

using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using Ca.Infoway.Messagebuilder.Annotation;

namespace Ca.Infoway.Messagebuilder.Xml.Service
{
    class ManifestMessageDefinitionService : BaseMessageDefinitionService
    {
        protected override IList<ResourcePair> Names
        {
            get { return getResourceNamesFromManifests(); }
        }

        private List<ResourcePair> getResourceNamesFromManifests()
        {
            var manifests = new List<ResourcePair>();

            foreach (var assembly in AppDomain.CurrentDomain.GetAssemblies())
            {
				string simpleAssemblyName = assembly.GetName().Name;
				
				if (simpleAssemblyName.StartsWith("message-builder-"))
				{
                    var attr = GetAssemblyAttribute(assembly);

                    if (attr != null)
                    {
                        string[] collection = attr.value.Split(' ');

                        foreach (var s in collection)
                        {
                            manifests.Add(new ResourcePair(s, assembly));
                        }
                        
                    }
				}
            }

            return manifests;
        }


        private static MbtMessageSetAttribute GetAssemblyAttribute(Assembly assembly)
        {
            var assemblyAttributes = assembly.GetCustomAttributes(typeof(MbtMessageSetAttribute), true);

            MbtMessageSetAttribute attr = null;

            if (assemblyAttributes.Length > 0)
            {
                attr = assemblyAttributes[0] as MbtMessageSetAttribute;
            }

            return attr;
        }
    }

    public class ResourcePair
    {
        public ResourcePair(string s, Assembly assembly)
        {
            Name = s;
            Assembly = assembly;
        }

        public string Name { get; set; }

        public Assembly Assembly { get; set; }
    }
}
