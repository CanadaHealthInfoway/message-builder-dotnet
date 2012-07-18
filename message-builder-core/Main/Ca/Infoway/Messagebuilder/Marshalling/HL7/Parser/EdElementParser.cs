using System;
using System.Xml;
using Ca.Infoway.Messagebuilder;
using Ca.Infoway.Messagebuilder.Datatype;
using Ca.Infoway.Messagebuilder.Datatype.Impl;
using Ca.Infoway.Messagebuilder.Datatype.Lang;
using Ca.Infoway.Messagebuilder.Marshalling.HL7;
using Ca.Infoway.Messagebuilder.Marshalling.HL7.Formatter;
using Ca.Infoway.Messagebuilder.Marshalling.HL7.Parser;
using Ca.Infoway.Messagebuilder.Platform;
using Ca.Infoway.Messagebuilder.Util.Xml;

namespace Ca.Infoway.Messagebuilder.Marshalling.HL7.Parser
{
	/// <summary>
	/// ED - Encapsulated Data (Document or Reference)
	/// Parses a ED element into an Encapsulated Data:
	/// This is some text.
	/// http://www.hl7.org/v3ballot/html/infrastructure/itsxml/datatypes-its-xml.htm#dtimpl-ED
	/// This appears to be correct, although all of the examples name the outer element as "text".
	/// </summary>
	/// <remarks>
	/// ED - Encapsulated Data (Document or Reference)
	/// Parses a ED element into an Encapsulated Data:
	/// This is some text.
	/// http://www.hl7.org/v3ballot/html/infrastructure/itsxml/datatypes-its-xml.htm#dtimpl-ED
	/// This appears to be correct, although all of the examples name the outer element as "text".
	/// Note that there are many more variations on this datatype. HTML, XML and PDF data are
	/// all supported. However the current schemas that we work with all define the document
	/// as a String so plain text is all we support at the moment.
	/// </remarks>
	[DataTypeHandler("ED")]
	internal class EdElementParser : AbstractSingleElementParser<EncapsulatedData>
	{
		/// <exception cref="Ca.Infoway.Messagebuilder.Marshalling.HL7.XmlToModelTransformationException"></exception>
		protected override EncapsulatedData ParseNonNullNode(ParseContext context, XmlNode node, BareANY result, Type expectedReturnType
			, XmlToModelResult xmlToModelResult)
		{
			ValidateMaxChildCount(context, node, 1);
			try
			{
				return Parse(node);
			}
			catch (Exception e)
			{
				throw new XmlToModelTransformationException(e);
			}
		}

		private EncapsulatedData Parse(XmlNode node)
		{
			XmlElement element = (XmlElement)node;
			MediaType mediaType = ParseMediaType(element);
			Compression compression = ParseCompression(element);
			string language = ParseLanguage(element);
			string representation = ParseRepresentation(element);
			string reference = ParseReference(element);
			byte[] content = ParseContent(element, representation);
			if (compression != null || language != null)
			{
				return new CompressedData(mediaType, reference, content, compression, language);
			}
			else
			{
				if (mediaType != null || reference != null || content != null)
				{
					return new EncapsulatedData(mediaType, reference, content);
				}
				else
				{
					return null;
				}
			}
		}

		private byte[] ParseContent(XmlElement element, string representation)
		{
			byte[] content = null;
			string text = NodeUtil.GetTextValue(element, false);
			if (!StringUtils.IsBlank(text))
			{
				if (EdPropertyFormatter.REPRESENTATION_B64.EqualsIgnoreCase(representation))
				{
					content = Base64.DecodeBase64String(text);
				}
				else
				{
					content = System.Text.ASCIIEncoding.ASCII.GetBytes(text);
				}
			}
			return content;
		}

		private string ParseRepresentation(XmlElement element)
		{
			if (element.HasAttribute(EdPropertyFormatter.ATTRIBUTE_REPRESENTATION))
			{
				return element.GetAttribute(EdPropertyFormatter.ATTRIBUTE_REPRESENTATION);
			}
			return null;
		}

		private string ParseReference(XmlElement element)
		{
			if (element.HasAttribute(EdPropertyFormatter.ATTRIBUTE_REFERENCE))
			{
				return element.GetAttribute(EdPropertyFormatter.ATTRIBUTE_REFERENCE);
			}
			return null;
		}

		private string ParseLanguage(XmlElement element)
		{
			if (element.HasAttribute(EdPropertyFormatter.ATTRIBUTE_LANGUAGE))
			{
				return element.GetAttribute(EdPropertyFormatter.ATTRIBUTE_LANGUAGE);
			}
			return null;
		}

		private Compression ParseCompression(XmlElement element)
		{
			if (element.HasAttribute(EdPropertyFormatter.ATTRIBUTE_COMPRESSION))
			{
				return Compression.Get(element.GetAttribute(EdPropertyFormatter.ATTRIBUTE_COMPRESSION));
			}
			return null;
		}

		private MediaType ParseMediaType(XmlElement element)
		{
			if (element.HasAttribute(EdPropertyFormatter.ATTRIBUTE_MEDIA_TYPE))
			{
				return MediaType.Get(element.GetAttribute(EdPropertyFormatter.ATTRIBUTE_MEDIA_TYPE));
			}
			return null;
		}

		protected override BareANY DoCreateDataTypeInstance(string typeName)
		{
			return new EDImpl<EncapsulatedData>();
		}
	}
}
