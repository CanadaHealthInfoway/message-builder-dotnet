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
 * Author:        $LastChangedBy: tmcgrady $
 * Last modified: $LastChangedDate: 2011-05-04 16:47:15 -0300 (Wed, 04 May 2011) $
 * Revision:      $LastChangedRevision: 2623 $
 */
using System;
using System.Xml;
using Ca.Infoway.Messagebuilder;
using Ca.Infoway.Messagebuilder.Datatype;
using Ca.Infoway.Messagebuilder.Datatype.Impl;
using Ca.Infoway.Messagebuilder.Datatype.Lang;
using Ca.Infoway.Messagebuilder.Marshalling.HL7;
using Ca.Infoway.Messagebuilder.Marshalling.HL7.Parser;
using Ca.Infoway.Messagebuilder.Util.Xml;

namespace Ca.Infoway.Messagebuilder.Marshalling.HL7.Parser
{
	/// <summary>
	/// II - Installer Identifier
	/// Parses an II element into a II object.
	/// </summary>
	/// <remarks>
	/// II - Installer Identifier
	/// Parses an II element into a II object. The element looks like this:
	/// 
	/// CeRx standards claim that both attributes are required, although extension
	/// is sometimes unused.
	/// The HL7 standard defines the assigningAuthorityName attribute, but that
	/// has been left out of the CeRx implementation.
	/// According to CeRx: Root has a limit of 100 characters, extension of 20
	/// characters. These limits are not currently enforced by this class.
	/// http://www.hl7.org/v3ballot/html/infrastructure/itsxml/datatypes-its-xml.htm#dtimpl-II
	/// </remarks>
	[DataTypeHandler("II")]
	internal class IiElementParser : AbstractSingleElementParser<Identifier>
	{
		private static readonly IiValidationUtils iiValidationUtils = new IiValidationUtils();

		protected override BareANY DoCreateDataTypeInstance(string typeName)
		{
			return new IIImpl();
		}

		protected override Identifier ParseNonNullNode(ParseContext context, XmlNode node, BareANY result, Type returnType, XmlToModelResult
			 xmlToModelResult)
		{
			XmlElement element = (XmlElement)node;
			VersionNumber version = (context == null ? null : context.GetVersion());
			string root = GetMandatoryAttributeValue(element, "root", xmlToModelResult);
			string extension = GetAttributeValue(element, "extension");
			string versionAttribute = null;
			string type = HandleSpecializationType(context, element, xmlToModelResult);
			// type might have resolved to something different if this II.x is abstract (II, II_BUS_AND_VER), so set it again before performing validations
			SetDataType(type, result);
			if (IiValidationUtils.II.Equals(type))
			{
				// should only occur for CeRx and AB, but could happen if a relationship of type II is not specified via specializationType 
				ValidateII(xmlToModelResult, element, version, root, extension, type);
			}
			else
			{
				if (IiValidationUtils.II_TOKEN.Equals(type))
				{
					ValidateII_TOKEN(xmlToModelResult, element, root, type, version);
				}
				else
				{
					if (IiValidationUtils.II_BUS.Equals(type))
					{
						ValidateII_BUS(xmlToModelResult, element, root, extension, type, version);
					}
					else
					{
						if (IiValidationUtils.II_OID.Equals(type))
						{
							ValidateII_OID(context, xmlToModelResult, element, root, type, version);
						}
						else
						{
							if (IiValidationUtils.II_PUBLIC.Equals(type))
							{
								ValidateII_PUBLIC(context, xmlToModelResult, element, root, extension, type, version, false);
							}
							else
							{
								if (IiValidationUtils.II_VER.Equals(type))
								{
									ValidateII_VER(xmlToModelResult, element, root, type, version);
								}
								else
								{
									if (IiValidationUtils.II_BUSVER.Equals(type))
									{
										versionAttribute = ValidateII_BUSVER(xmlToModelResult, element, root, extension, type, version);
									}
									else
									{
										if (IiValidationUtils.II_PUBLICVER.Equals(type))
										{
											versionAttribute = ValidateII_PUBLICVER(context, xmlToModelResult, element, root, extension, type, version);
										}
									}
								}
							}
						}
					}
				}
			}
			ValidateUnallowedAttributes(type, element, xmlToModelResult, "assigningAuthorityName");
			return new Identifier(root, extension, versionAttribute);
		}

		private void ValidateII(XmlToModelResult xmlToModelResult, XmlElement element, VersionNumber version, string root, string
			 extension, string type)
		{
			ValidateRootAndExtensionAsOidOrUuid(xmlToModelResult, element, root, extension, type, version);
			ValidateUnallowedAttributes(type, element, xmlToModelResult, "displayable");
			ValidateUnallowedAttributes(type, element, xmlToModelResult, "use");
		}

		private string ValidateII_PUBLICVER(ParseContext context, XmlToModelResult xmlToModelResult, XmlElement element, string root
			, string extension, string type, VersionNumber version)
		{
			ValidateII_PUBLIC(context, xmlToModelResult, element, root, extension, type, version, true);
			return GetMandatoryAttributeValue(element, "version", xmlToModelResult);
		}

		private string ValidateII_BUSVER(XmlToModelResult xmlToModelResult, XmlElement element, string root, string extension, string
			 type, VersionNumber version)
		{
			ValidateII_BUS(xmlToModelResult, element, root, extension, type, version);
			return GetMandatoryAttributeValue(element, "version", xmlToModelResult);
		}

		private void ValidateII_VER(XmlToModelResult xmlToModelResult, XmlElement element, string root, string type, VersionNumber
			 version)
		{
			ValidateRootAsUuid(element, root, xmlToModelResult, version);
			ValidateUnallowedAttributes(type, element, xmlToModelResult, "extension");
			ValidateUnallowedAttributes(type, element, xmlToModelResult, "displayable");
			ValidateAttributeEquals(type, element, xmlToModelResult, "use", "VER");
		}

		private void ValidateII_TOKEN(XmlToModelResult xmlToModelResult, XmlElement element, string root, string type, VersionNumber
			 version)
		{
			ValidateRootAsUuid(element, root, xmlToModelResult, version);
			ValidateUnallowedAttributes(type, element, xmlToModelResult, "extension");
			ValidateUnallowedAttributes(type, element, xmlToModelResult, "use");
			ValidateUnallowedAttributes(type, element, xmlToModelResult, "displayable");
		}

		private void ValidateII_OID(ParseContext context, XmlToModelResult xmlToModelResult, XmlElement element, string root, string
			 type, VersionNumber version)
		{
			ValidateRootAsOid(root, element, xmlToModelResult, version);
			ValidateUnallowedAttributes(type, element, xmlToModelResult, "extension");
			ValidateUnallowedAttributes(type, element, xmlToModelResult, "displayable");
			if (!iiValidationUtils.IsCerxOrMr2007(context.GetVersion()))
			{
				ValidateAttributeEquals(type, element, xmlToModelResult, "use", "BUS");
			}
			else
			{
				ValidateUnallowedAttributes(type, element, xmlToModelResult, "use");
			}
		}

		private void ValidateII_PUBLIC(ParseContext context, XmlToModelResult xmlToModelResult, XmlElement element, string root, 
			string extension, string type, VersionNumber version, bool isII_PUBLICVER)
		{
			ValidateRootAsOid(root, element, xmlToModelResult, version);
			ValidateExtensionForOid(xmlToModelResult, element, extension);
			ValidateAttributeEquals(type, element, xmlToModelResult, "displayable", "true");
			// Redmine 11293 - TM - must have use=BUS, but not for MR2007 (use is not permitted in this case)
			if (!isII_PUBLICVER && !iiValidationUtils.IsCerxOrMr2007(context.GetVersion()))
			{
				ValidateAttributeEquals(type, element, xmlToModelResult, "use", "BUS");
			}
			else
			{
				ValidateUnallowedAttributes(type, element, xmlToModelResult, "use");
			}
		}

		private void ValidateII_BUS(XmlToModelResult xmlToModelResult, XmlElement element, string root, string extension, string 
			type, VersionNumber version)
		{
			ValidateRootAndExtensionAsOidOrUuid(xmlToModelResult, element, root, extension, type, version);
			ValidateUnallowedAttributes(type, element, xmlToModelResult, "displayable");
			ValidateAttributeEquals(type, element, xmlToModelResult, "use", "BUS");
		}

		private void ValidateRootAndExtensionAsOidOrUuid(XmlToModelResult xmlToModelResult, XmlElement element, string root, string
			 extension, string type, VersionNumber version)
		{
			// if root has not been provided don't bother further validating root or extension
			if (StringUtils.IsNotBlank(root))
			{
				if (!iiValidationUtils.IsUuid(root))
				{
					ValidateRootAsOid(root, element, xmlToModelResult, version);
					ValidateExtensionForOid(xmlToModelResult, element, extension);
				}
				else
				{
					ValidateRootAsUuid(element, root, xmlToModelResult, version);
					ValidateUnallowedAttributes(type, element, xmlToModelResult, "extension");
				}
			}
		}

		private void ValidateExtensionForOid(XmlToModelResult xmlToModelResult, XmlElement element, string extension)
		{
			// extension is mandatory in this case
			GetMandatoryAttributeValue(element, "extension", xmlToModelResult);
			ValidateExtensionLength(element, extension, xmlToModelResult);
		}

		private string HandleSpecializationType(ParseContext context, XmlElement element, XmlToModelResult xmlToModelResult)
		{
			VersionNumber version = context.GetVersion();
			string typeFromContext = context.Type;
			string specializationType = GetSpecializationType(element);
			if (iiValidationUtils.IsSpecializationTypeRequired(version, typeFromContext))
			{
				bool validSpecializationType = IsSpecializationTypeProvided(specializationType);
				if (iiValidationUtils.IsII(typeFromContext))
				{
					validSpecializationType &= IiValidationUtils.concreteIiTypes.Contains(specializationType);
				}
				else
				{
					if (iiValidationUtils.IsIiBusAndVer(typeFromContext))
					{
						validSpecializationType &= iiValidationUtils.IsIiBusOrIiVer(specializationType);
					}
				}
				// only override type if new type is valid
				if (validSpecializationType)
				{
					typeFromContext = specializationType;
				}
				else
				{
					if (iiValidationUtils.IsIiBusAndVer(typeFromContext))
					{
						string use = GetAttributeValue(element, "use");
						typeFromContext = ("VER".Equals(use) ? IiValidationUtils.II_VER : IiValidationUtils.II_BUS);
						// II.BUS allows oids and uuids, so default to it as a last resort
						RecordError(iiValidationUtils.GetInvalidSpecializationTypeForBusAndVerErrorMessage(specializationType, typeFromContext), 
							element, xmlToModelResult);
					}
					else
					{
						RecordError(iiValidationUtils.GetInvalidOrMissingSpecializationTypeErrorMessage(specializationType), element, xmlToModelResult
							);
					}
				}
			}
			else
			{
				if (IsSpecializationTypeProvided(specializationType))
				{
					RecordError(iiValidationUtils.GetShouldNotProvideSpecializationTypeErrorMessage(typeFromContext), element, xmlToModelResult
						);
				}
			}
			return typeFromContext;
		}

		private bool IsSpecializationTypeProvided(string specializationType)
		{
			return specializationType != null;
		}

		private void ValidateAttributeEquals(string type, XmlElement element, XmlToModelResult xmlToModelResult, string attributeName
			, string attributeValue)
		{
			if (!element.HasAttribute(attributeName))
			{
				RecordError(iiValidationUtils.GetMissingAttributeErrorMessage(type, attributeName, attributeValue), element, xmlToModelResult
					);
			}
			else
			{
				if (!StringUtils.Equals(element.GetAttribute(attributeName), attributeValue))
				{
					RecordError(iiValidationUtils.GetIncorrectAttributeValueErrorMessage(type, attributeName, attributeValue), element, xmlToModelResult
						);
				}
			}
		}

		private void ValidateRootAsUuid(XmlElement element, string root, XmlToModelResult xmlToModelResult, VersionNumber version
			)
		{
			if (StringUtils.IsNotBlank(root))
			{
				if (!iiValidationUtils.IsUuid(root))
				{
					RecordError(iiValidationUtils.GetRootMustBeUuidErrorMessage(root), element, xmlToModelResult);
				}
				ValidateRootLength(element, root, xmlToModelResult, version);
			}
		}

		private void ValidateRootLength(XmlElement element, string root, XmlToModelResult xmlToModelResult, VersionNumber version
			)
		{
			if (iiValidationUtils.IsRootLengthInvalid(root, version))
			{
				RecordError(iiValidationUtils.GetInvalidRootLengthErrorMessage(root, version), element, xmlToModelResult);
			}
		}

		private void ValidateExtensionLength(XmlElement element, string extension, XmlToModelResult xmlToModelResult)
		{
			if (iiValidationUtils.IsExtensionLengthInvalid(extension))
			{
				RecordError(iiValidationUtils.GetInvalidExtensionLengthErrorMessage(extension), element, xmlToModelResult);
			}
		}

		private void ValidateRootAsOid(string root, XmlElement element, XmlToModelResult xmlToModelResult, VersionNumber version)
		{
			if (StringUtils.IsNotBlank(root))
			{
				if (!iiValidationUtils.IsOid(root))
				{
					RecordError(iiValidationUtils.GetRootMustBeAnOidErrorMessage(root), element, xmlToModelResult);
				}
				ValidateRootLength(element, root, xmlToModelResult, version);
			}
		}

		private void RecordError(string message, XmlElement element, XmlToModelResult xmlToModelResult)
		{
			xmlToModelResult.AddHl7Error(new Hl7Error(Hl7ErrorCode.DATA_TYPE_ERROR, message + " (" + XmlDescriber.DescribeSingleElement
				(element) + ")", element));
		}
	}
}
