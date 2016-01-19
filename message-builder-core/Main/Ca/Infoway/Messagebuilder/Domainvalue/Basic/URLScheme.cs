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


/// ---------------------------------------------------------------------------------------------------
///  This file was automatically generated by J2CS Translator (http://j2cstranslator.sourceforge.net/). 
///  Version 1.0.0                                                                                      
/// ---------------------------------------------------------------------------------------------------

namespace Ca.Infoway.Messagebuilder.Domainvalue.Basic
{
	
	using Ca.Infoway.Messagebuilder;
	using Ca.Infoway.Messagebuilder.Lang;
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.ComponentModel;
	using System.Runtime.CompilerServices;
	
	/// <summary>
	/// An enum representing all the valid and applicable URL types used within MessageBuilder.
	/// </summary>
	///
	[Serializable]
	public class URLScheme : EnumPattern, 
			Ca.Infoway.Messagebuilder.Domainvalue.URLScheme, Describable {
	
		private const long serialVersionUID = -2569871003868077442L;
	
		public static readonly URLScheme FTP = new URLScheme("ftp");
		public static readonly URLScheme FAX = new URLScheme("fax");
		public static readonly URLScheme FILE = new URLScheme("file");
		public static readonly URLScheme HTTP = new URLScheme("http");
		public static readonly URLScheme HTTPS = new URLScheme("https");
		public static readonly URLScheme MLLP = new URLScheme("mllp");
		public static readonly URLScheme MAILTO = new URLScheme("mailto");
		public static readonly URLScheme MODEM = new URLScheme("modem");
		public static readonly URLScheme NFS = new URLScheme("nfs");
		public static readonly URLScheme TEL = new URLScheme("tel", "Phone");
		public static readonly URLScheme TELNET = new URLScheme("telnet");
	
		private readonly String description;
	
		private URLScheme(String codeValue) : base(codeValue) {
			this.description = Ca.Infoway.Messagebuilder.Domainvalue.Util.DescribableUtil.GetDefaultDescription(Name);
		}
	
		private URLScheme(String codeValue, String description_0) : base(codeValue) {
			this.description = description_0;
		}

        static URLScheme() { }
	
		/// <summary>
		/// Returns the c system for the URL.
		/// </summary>
		///
		/// <returns>the c system for the URL</returns>
		public virtual String CodeSystem {
		/// <summary>
		/// Returns the c system for the URL.
		/// </summary>
		///
		/// <returns>the c system for the URL</returns>
		  get {
				return Ca.Infoway.Messagebuilder.Codesystem.CodeSystem.VOCABULARY_URL_SCHEME.Root;
			}
		}
		
	
		/// <summary>
		/// Returns the value (protocol) for the URL.
		/// </summary>
		///
		/// <returns>the value (protocol) for the URL.</returns>
		public virtual String CodeValue {
		/// <summary>
		/// Returns the value (protocol) for the URL.
		/// </summary>
		///
		/// <returns>the value (protocol) for the URL.</returns>
		  get {
				return Name;
			}
		}

        public virtual String CodeSystemName {
            get { return null; }
        }
	
		/// <summary>
		/// A description of the URL.
		/// </summary>
		///
		/// <returns>the URL description</returns>
		public virtual String Description {
		/// <summary>
		/// A description of the URL.
		/// </summary>
		///
		/// <returns>the URL description</returns>
		  get {
				return this.description;
			}
		}
		
	
		/// <summary>
		/// Returns a list of enums applicable for "phone". 
		/// </summary>
		///
		/// <returns>URLs applicable for phone</returns>
		public static IList<URLScheme> PhoneSchemes {
		/// <summary>
		/// Returns a list of enums applicable for "phone". 
		/// </summary>
		///
		/// <returns>URLs applicable for phone</returns>
		  get {
				return ILOG.J2CsMapping.Collections.Generics.Arrays.AsList(FAX,TEL);
			}
		}
		
	}
}
