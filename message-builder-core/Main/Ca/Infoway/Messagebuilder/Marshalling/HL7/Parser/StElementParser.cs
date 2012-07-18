using System;
using System.Xml;
using Ca.Infoway.Messagebuilder;
using Ca.Infoway.Messagebuilder.Datatype;
using Ca.Infoway.Messagebuilder.Datatype.Impl;
using Ca.Infoway.Messagebuilder.Marshalling.HL7;
using Ca.Infoway.Messagebuilder.Marshalling.HL7.Parser;
using Ca.Infoway.Messagebuilder.Util.Xml;
using ILOG.J2CsMapping.Text;

namespace Ca.Infoway.Messagebuilder.Marshalling.HL7.Parser
{
	/// <summary>
	/// ST - String
	/// Parses an ST element into a String.
	/// </summary>
	/// <remarks>
	/// ST - String
	/// Parses an ST element into a String. The element looks like this:
	/// This is some text
	/// Returns the value of the text node, or null if there is no node.
	/// HL7 defines other attributes, but notes that they are optional since
	/// the values are self-evident (representation="TXT" mediaType="text/plain").
	/// The CeRx documentation makes no mention of these attributes.
	/// http://www.hl7.org/v3ballot/html/infrastructure/itsxml/datatypes-its-xml.htm#dtimpl-ST
	/// </remarks>
	[DataTypeHandler("ST")]
	internal class StElementParser : AbstractSingleElementParser<string>
	{
		/// <exception cref="Ca.Infoway.Messagebuilder.Marshalling.HL7.XmlToModelTransformationException"></exception>
		protected override string ParseNonNullNode(ParseContext context, XmlNode node, BareANY dataType, Type returnType, XmlToModelResult
			 xmlToModelResult)
		{
			XmlElement element = (XmlElement)node;
			if (StandardDataType.ST.Type.Equals(context.Type) && HasLanguageAttribute(element))
			{
				xmlToModelResult.AddHl7Error(new Hl7Error(Hl7ErrorCode.DATA_TYPE_ERROR, System.String.Format("The language attribute is not allow for ST element types ({0})"
					, XmlDescriber.DescribeSingleElement(element)), element));
			}
			else
			{
				if (StandardDataType.ST_LANG.Type.Equals(context.Type) && !HasLanguageAttribute(element))
				{
					xmlToModelResult.AddHl7Error(new Hl7Error(Hl7ErrorCode.DATA_TYPE_ERROR, System.String.Format("The language attribute is required for ST.LANG element types ({0})"
						, XmlDescriber.DescribeSingleElement(element)), element));
				}
				else
				{
					if (StandardDataType.ST_LANG.Type.Equals(context.Type) && HasLanguageAttribute(element) && !LanguageSupported(element))
					{
						xmlToModelResult.AddHl7Error(new Hl7Error(Hl7ErrorCode.DATA_TYPE_ERROR, System.String.Format("The language attribute is not one of the supported types ({0})"
							, XmlDescriber.DescribeSingleElement(element)), element));
					}
				}
			}
			string result = null;
			int childNodeCount = node.ChildNodes.Count;
			if (childNodeCount == 0)
			{
				if (context.GetConformance() == Ca.Infoway.Messagebuilder.Xml.ConformanceLevel.MANDATORY)
				{
					xmlToModelResult.AddHl7Error(new Hl7Error(Hl7ErrorCode.DATA_TYPE_ERROR, System.String.Format("The string value should not be empty ({0})"
						, XmlDescriber.DescribeSingleElement(element)), element));
				}
				// this is an empty node, return empty string (null should have a null flavor attribute)
				result = AbstractSingleElementParser<string>.EMPTY_STRING;
			}
			else
			{
				if (childNodeCount == 1)
				{
					XmlNode childNode = node.FirstChild;
					if (childNode.NodeType != System.Xml.XmlNodeType.Text)
					{
						throw new XmlToModelTransformationException("Expected ST node to have a text node");
					}
					result = childNode.Value;
				}
				else
				{
					throw new XmlToModelTransformationException("Expected ST node to have at most one child");
				}
			}
			if (context.GetLength() != null && result.Length > context.GetLength())
			{
				xmlToModelResult.AddHl7Error(new Hl7Error(Hl7ErrorCode.DATA_TYPE_ERROR, System.String.Format("The specified string (\"{0}\") exceeds the maximum length of {1}.  The string has been truncated."
					, Truncate(result, 50), context.GetLength()), element));
				result = StringUtils.Left(result, context.GetLength());
			}
			if (StandardDataType.ST_LANG.Type.Equals(context.Type))
			{
				string language = ((XmlElement)node).GetAttribute("language");
				((STImpl)dataType).Language = StringUtils.TrimToNull(language);
			}
			return result;
		}

		private string Truncate(string text, Int32? length)
		{
			if (StringUtils.IsBlank(text))
			{
				return string.Empty;
			}
			else
			{
				if (text.Length > length)
				{
					return StringUtils.Substring(text, 0, length - 3) + "...";
				}
				else
				{
					return text;
				}
			}
		}

		private bool HasLanguageAttribute(XmlElement element)
		{
			return element.HasAttribute("language");
		}

		private bool LanguageSupported(XmlElement element)
		{
			return STImpl.ALLOWED_LANGUAGES.Contains(element.GetAttribute("language"));
		}

		protected override BareANY DoCreateDataTypeInstance(string typeName)
		{
			return new STImpl();
		}
	}
}
