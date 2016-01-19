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
using Platform.Xml.Sax;
 
namespace Ca.Infoway.Messagebuilder.Datatype.Lang {

    using Ca.Infoway.Messagebuilder;
    using Ca.Infoway.Messagebuilder.Lang;
    using Ca.Infoway.Messagebuilder.Util.Xml;
    using Ca.Infoway.Messagebuilder.Domainvalue;
    using Ca.Infoway.Messagebuilder.Datatype.Lang.Util;
    using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.ComponentModel;
	using System.Runtime.CompilerServices;
    using System.Text;
    using System.Xml;
	
	/// <summary>
    /// R2-specific ED data type
    /// This class represents data that is primarily intended for human interpretation
	/// or for further machine processing outside the scope of HL7.  Examples include
	/// PDF documents, images, XML or other content types.
	/// This includes unformatted or formatted written language, multimedia data, or
	/// structured information in as defined by a different standard (e.g., XML-signatures.)
	/// </summary>
	///
	public class EncapsulatedData {

        private static readonly DocumentFactory DOCUMENT_FACTORY = new DocumentFactory();

        private String content;
	
		/// <summary>
		/// Constructs an empty ED.
		/// </summary>
		///
		public EncapsulatedData() {
		}

        public EncapsulatedData(String textContent) {
            Content = textContent;
        }

        public EncapsulatedData(XmlNode nodeOrDocumentContent) {
            AddContent(nodeOrDocumentContent);
        }

        public EncapsulatedData(IList<XmlNode> nodeOrDocumentContents) {
            foreach (XmlNode node in nodeOrDocumentContents) {
                AddContent(node);
            }
        }
	
		/// <summary>
		/// Constructs an ED using the supplied parameters.
		/// </summary>
		///
		/// <param name="mediaType_0">the mediatype</param>
		/// <param name="reference_1">a reference</param>
        /// <param name="language_2">language</param>
        /// <param name="content_3">content within a byte array</param>
        [Obsolete]
		public EncapsulatedData(
				x_DocumentMediaType mediaType_0,
				String reference_1, String lanuage_2, byte[] content_3) {
			MediaType = mediaType_0;
            Language = lanuage_2;
            this.content = content_3 == null || content_3.Length == 0 ? null : XmlStringEscape.Escape(ASCIIEncoding.ASCII.GetString(content_3));
            if (!StringUtils.IsBlank(reference_1)) {
			    String[] parts = reference_1.Split(new string[] {"://"}, StringSplitOptions.None);
			    if (parts.Length > 0) {
				    Ca.Infoway.Messagebuilder.Domainvalue.Basic.URLScheme urlsScheme = null; 
				    if (parts.Length > 1) {
                        urlsScheme = Ca.Infoway.Messagebuilder.Domainvalue.Basic.URLScheme.ValueOf<Ca.Infoway.Messagebuilder.Domainvalue.Basic.URLScheme>(
                            typeof(Ca.Infoway.Messagebuilder.Domainvalue.Basic.URLScheme), parts[0]);
				    }
				    String address = (parts.Length > 1 ? parts[1] : parts[0]); 
				    ReferenceObj = new TelecommunicationAddress(urlsScheme, address);
                }
            }
		}		
	
		/// <summary>
		/// Returns the media type.
		/// </summary>
		///
		/// <returns>the media type</returns>
        public virtual x_DocumentMediaType MediaType {
            /// <summary>
            /// Returns the media type.
            /// </summary>
            ///
            /// <returns>the media type</returns>
            get;
            set;
        }
		
	
		/// <summary>
		/// Returns the language.
		/// </summary>
		///
        /// <returns>the language</returns>
        public String Language {
            /// <summary>
            /// Returns the language.
            /// </summary>
            ///
            /// <returns>the language</returns>
            get;
            set;
        }

        /// <summary>
        /// Returns the reference.
        /// </summary>
        ///
        /// <returns>the reference</returns>
        public TelecommunicationAddress ReferenceObj {
            /// <summary>
            /// Returns the reference.
            /// </summary>
            ///
            /// <returns>the reference</returns>
            get;
            set;
        }

        /// <summary>
        /// Returns the reference. Deprecated. Use getReferenceObj() instead.
        /// </summary>
        [Obsolete]
        public String Reference {
            get {
                return ReferenceObj == null ? null : ReferenceObj.ToString();
            }
        }

        public virtual EdRepresentation Representation {
            get;
            set;
        }

        public virtual EncapsulatedData Thumbnail {
            get;
            set;
        }

        public virtual Compression Compression {
            get;
            set;
        }

        public virtual String IntegrityCheck {
            get;
            set;
        }

        public virtual IntegrityCheckAlgorithm IntegrityCheckAlgorithm {
            get;
            set;
        }

        public virtual String Content {
            get { return this.content; }
            set { AddContent(value);  }
        }

        public virtual bool HasContent() {
            return StringUtils.IsNotBlank(Content);
        }

        public virtual void AddContent(String newStringContent) {
            AddStringContent(newStringContent, true);
        }

        private void AddStringContent(String newStringContent, bool validate) {
		    if (validate) {
			    ValidateStringContent(newStringContent);
		    }
		    if (this.content == null) {
			    this.content = newStringContent;
		    } else {
			    this.content += newStringContent;
		    }
        }

        private void ValidateStringContent(String content) {
            // wrap content in an outer tag and try to convert to document (content such as plain text won't convert to a document but could still be valid)
            if (content != null) {
                try {
                    DOCUMENT_FACTORY.CreateFromString("<mbContent>" + content + "</mbContent>");
                } catch (XmlException e) {
                    throw new SAXException(e);
                }
            }
        }

        public virtual void TrimContent() {
            this.content = StringUtils.TrimToNull(this.content);
        }

        public virtual void AddContent(XmlNode nodeOrDocument) {
            // convert to String and add to content
            String newStringContent = ConvertNodeToString(nodeOrDocument);
            try {
                AddStringContent(newStringContent, false);
            } catch (SAXException e) {
                // validation not done for this case; should never get here
            }
        }

        private string ConvertNodeToString(XmlNode node) {
            XmlNode newNode = node;
            if (!IsTextNode(node)) {
                // convert the node into a document in order to avoid inheriting any namespaces
                // note, this should not remove inner namespaces in the content - may need to revisit
                // this may be very inefficient - better to just search and replace namespaces after converting to string?
                newNode = XmlRenderer.ObtainDocumentFromNode(node, true);
            }
            return XmlRenderer.RenderNodeEscaped(newNode);
        }

        private bool IsTextNode(XmlNode node) {
            // looking for any types that can not be converted to a document
            XmlNodeType nodeType = node.NodeType;
            return nodeType == XmlNodeType.CDATA || nodeType == XmlNodeType.Text || nodeType == XmlNodeType.Comment;
        }

        public override int GetHashCode()
        {
            return new HashCodeBuilder()
        		    .Append(ReferenceObj)
        		    .Append(Thumbnail)
        		    .Append(Representation)
 		            .Append(MediaType)
 		            .Append(Language)
		            .Append(Compression)
		            .Append(IntegrityCheck)
		            .Append(IntegrityCheckAlgorithm)
 		            .Append(this.content)
                    .ToHashCode();
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            } else if (obj.GetType() != GetType()) {
                return false;
            } else {
                return Equals((EncapsulatedData) obj);
            }
        }

        private bool Equals(EncapsulatedData that)
        {
            return new EqualsBuilder()
                    .Append(this.ReferenceObj, that.ReferenceObj)
		            .Append(this.Thumbnail, that.Thumbnail)
		            .Append(this.Representation, that.Representation)
		            .Append(this.MediaType, that.MediaType)
		            .Append(this.Language, that.Language)
		            .Append(this.Compression, that.Compression)
		            .Append(this.IntegrityCheck, that.IntegrityCheck)
		            .Append(this.IntegrityCheckAlgorithm, that.IntegrityCheckAlgorithm)
                    .Append(this.content, that.content)
                    .IsEquals();
        }

        public virtual bool IsEmpty() {
            return ReferenceObj == null &&
				Thumbnail == null &&
				Representation == null &&
				MediaType == null &&
				Language == null &&
				Compression == null &&
				IntegrityCheck == null &&
				IntegrityCheckAlgorithm == null &&
				this.content == null
				;
    	}

    }
}
