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

/// ---------------------------------------------------------------------------------------------------
///  This file was automatically generated by J2CS Translator (http://j2cstranslator.sourceforge.net/). 
///  Version 1.0.0                                                                                      
/// ---------------------------------------------------------------------------------------------------
 
namespace Ca.Infoway.Messagebuilder.Datatype {
	
	using Ca.Infoway.Messagebuilder;
	using ILOG.J2CsMapping.Util;
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.ComponentModel;
	using System.Runtime.CompilerServices;
	using System.Text;
	
	/// <summary>
	/// A parser used to separate the component parts of an HL7 type.  For
	/// example, the HL7 type <c>SET&lt;RTO&lt;PQ.DRUG,PQ.QUANTITY&gt;&gt;</c> 
	/// can be separated into these "parts":
	/// <ul>
	/// <li>PQ.DRUG</li>
	/// <li>PQ.QUANTITY</li>
	/// <li>RTO&lt;PQ.DRUG,PQ.QUANTITY&gt;</li>
	/// <li>SET&lt;RTO&lt;PQ.DRUG,PQ.QUANTITY&gt;&gt;</li>
	/// </ul>
	/// </summary>
	///
	internal class Hl7TypeParser {
	
		internal Hl7TypeName Parse(String hl7Type) {
			Hl7TypeName name = null;
			if (hl7Type != null) {
				IList<Hl7TypeName> nameParts = ProcessParts(hl7Type);
				if (nameParts.Count == 1) {
					name = nameParts[0];
				} else if (nameParts.Count > 1) {
					throw new ArgumentException(
							"Cannot parse the following type: " + hl7Type);
				}
			}
			return name;
		}
	
		private IList<Hl7TypeName> ProcessParts(String hl7Type) {
			IList<String> parts = Split(hl7Type);
			IList<Hl7TypeName> nameParts = new List<Hl7TypeName>();
			/* foreach */
			foreach (String part  in  parts) {
				ILOG.J2CsMapping.Collections.Generics.Collections.Add(nameParts,ConvertPart(part));
			}
			return nameParts;
		}
	
		private Hl7TypeName ConvertPart(String hl7Type) {
			Hl7TypeName result = null;
			if (hl7Type.Contains("<")) {
				String parameters = Ca.Infoway.Messagebuilder.StringUtils.SubstringBeforeLast(Ca.Infoway.Messagebuilder.StringUtils
						.SubstringAfter(hl7Type, "<"), ">");
				String baseName = Ca.Infoway.Messagebuilder.StringUtils.SubstringBefore(hl7Type, "<");
				result = new Hl7TypeName(Ca.Infoway.Messagebuilder.StringUtils.Trim(baseName),
						ProcessParts(parameters));
			} else {
				result = new Hl7TypeName(Ca.Infoway.Messagebuilder.StringUtils.Trim(hl7Type));
			}
			return result;
		}
	
		internal IList<String> Split(String name) {
			IList<String> parts = new List<String>();
			int depth = 0;
			StringBuilder builder = new StringBuilder();
			for (StringTokenizer tokenizer = new StringTokenizer(name, "<,>", true); tokenizer
					.HasMoreTokens();) {
				String token = tokenizer.NextToken();
				if ("<".Equals(token)) {
					depth++;
					builder.Append(token);
				} else if (",".Equals(token) && depth == 0) {
					ILOG.J2CsMapping.Collections.Generics.Collections.Add(parts,builder.ToString());
					builder.Length=0;
				} else if ("<".Equals(token)) {
					depth--;
					builder.Append(token);
				} else {
					builder.Append(token);
				}
			}
			if (builder.Length > 0) {
				ILOG.J2CsMapping.Collections.Generics.Collections.Add(parts,builder.ToString());
			}
			return parts;
		}
	}
}
