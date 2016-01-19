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


using System;

namespace Ca.Infoway.Messagebuilder.Marshalling
{
	internal class BridgeContext
	{
		private readonly bool collapsed;

		private readonly Int32? index;

		internal BridgeContext() : this(false)
		{
		}

		internal BridgeContext(bool collapsed)
		{
			this.collapsed = collapsed;
			this.index = null;
		}

		internal BridgeContext(bool collapsed, Int32? index)
		{
			this.collapsed = collapsed;
			this.index = index;
		}

		public virtual bool IsCollapsed()
		{
			return this.collapsed;
		}

		public virtual Int32? GetOriginalIndex()
		{
			return this.index;
		}

		public virtual int GetIndex()
		{
			if (this.index == null)
			{
				throw new InvalidOperationException("index is null");
			}
			else
			{
				return this.index.Value;
			}
		}

		public virtual bool IsIndexed()
		{
			return this.index != null;
		}
	}
}
