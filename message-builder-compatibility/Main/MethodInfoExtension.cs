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
 * Last modified: $LastChangedDate: 2011-05-17 11:48:36 -0400 (Tue, 17 May 2011) $
 * Revision:      $LastChangedRevision: 2666 $
 */

using System;
using System.Reflection;

namespace Ca.Infoway.Messagebuilder
{


	public static class MethodInfoExtension
	{

        public static bool IsBridge(this MethodInfo methodInfo)
        {
            return false;
        }
		
        public static bool IsAnnotationPresent(this MethodInfo methodInfo, Type attributeType)
        {
			object[] attributes = methodInfo.GetCustomAttributes(attributeType, false);
            return attributes.Length > 0;
        }

        public static T GetAnnotation<T>(this MethodInfo methodInfo)
        {
			Type attributeType = typeof(T);
			object[] attributes = methodInfo.GetCustomAttributes(attributeType, false);
			if (attributes.Length>0) 
			{
				return (T) attributes[0];
			} else {
				return default(T);
			}
        }
		
		
	}
}
