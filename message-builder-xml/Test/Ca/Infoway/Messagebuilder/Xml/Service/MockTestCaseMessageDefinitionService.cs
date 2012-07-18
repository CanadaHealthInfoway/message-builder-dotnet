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
 * Last modified: $LastChangedDate: 2012-01-18 21:44:55 -0500 (Wed, 18 Jan 2012) $
 * Revision:      $LastChangedRevision: 4357 $
 */

using System.Collections.Generic;
using Ca.Infoway.Messagebuilder.Xml.Service;
using ILOG.J2CsMapping.Collections.Generics;

namespace Ca.Infoway.Messagebuilder.Xml.Service
{
	public class MockTestCaseMessageDefinitionService : BaseMessageDefinitionService
	{
		private static bool initialized = false;

		public static void Register()
		{
			if (!initialized)
			{
				MessageDefinitionService service = new MessageDefinitionServiceFactory().Create();
				if (service != null && service is CompositeMessageDefinitionService)
				{
					MockTestCaseMessageDefinitionService mockService = new MockTestCaseMessageDefinitionService();
					((CompositeMessageDefinitionService)service).services.Add(mockService);
					initialized = true;
				}
			}
		}

		protected override IList<ResourcePair> Names
		{
			get
			{
				IList<ResourcePair> result = new List<ResourcePair>();
				result.Add(new ResourcePair("/messageSet_mock_NEWFOUNDLAND.xml", GetType().Assembly));
				result.Add(new ResourcePair("/messageSet_mock_r02_04_02.xml", GetType().Assembly));
				return result;
			}
		}
	}
}
