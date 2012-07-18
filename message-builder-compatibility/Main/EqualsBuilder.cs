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
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ca.Infoway.Messagebuilder
{
    public class EqualsBuilder
    {
        private bool equal;

        public EqualsBuilder()
        {
            equal = true;
        }

        public EqualsBuilder Append<T>(T lhs, T rhs)
        {
            if (equal)
                equal = (null != lhs ? lhs.Equals(rhs) : null == rhs);

            return this;
        }

        public EqualsBuilder AppendSuper(bool superEquals)
        {
            if (equal)
                equal = superEquals;

            return this;
        }

        public bool IsEquals()
        {
            return equal;
        }
    }
}
