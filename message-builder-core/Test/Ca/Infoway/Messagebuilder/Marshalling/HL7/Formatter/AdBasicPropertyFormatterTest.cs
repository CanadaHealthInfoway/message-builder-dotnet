using System;
using System.Xml;
using Ca.Infoway.Messagebuilder;
using Ca.Infoway.Messagebuilder.Datatype.Impl;
using Ca.Infoway.Messagebuilder.Datatype.Lang;
using Ca.Infoway.Messagebuilder.Domainvalue.Basic;
using Ca.Infoway.Messagebuilder.Marshalling;
using Ca.Infoway.Messagebuilder.Marshalling.HL7.Formatter;
using Ca.Infoway.Messagebuilder.Util.Xml;
using NUnit.Framework;

namespace Ca.Infoway.Messagebuilder.Marshalling.HL7.Formatter
{
	[TestFixture]
	public class AdBasicPropertyFormatterTest : FormatterTestCase
	{
		private PostalAddress address;

		private AdBasicPropertyFormatter formatter;

		/// <exception cref="System.Exception"></exception>
		[NUnit.Framework.SetUp]
		public virtual void SetUp()
		{
			this.address = new PostalAddress();
			this.formatter = new AdBasicPropertyFormatter();
		}

		/// <exception cref="System.Exception"></exception>
		[Test]
		public virtual void TestFormatValueNull()
		{
			string result = this.formatter.Format(GetContext("name"), new ADImpl());
			string expectedResult = "<name nullFlavor=\"NI\"/>" + SystemUtils.LINE_SEPARATOR;
			Assert.AreEqual(expectedResult, result, "null name");
		}

		/// <exception cref="System.Exception"></exception>
		[Test]
		public virtual void TestFormatEmptyAddress()
		{
			AdBasicPropertyFormatter formatter = new AdBasicPropertyFormatter();
			string result = formatter.Format(GetContext("address"), new ADImpl(this.address));
			string expectedResult = "<address>" + SystemUtils.LINE_SEPARATOR + "</address>" + SystemUtils.LINE_SEPARATOR;
			AssertXmlEquals("empty address", expectedResult, result);
			// a funny case: make sure adding a null address use is like not adding one at all
			// (i.e., just like above)
			this.address.AddUse(null);
			AssertXmlEquals("empty address - even with \"null\" address use", expectedResult, result);
			this.address.AddUse(Ca.Infoway.Messagebuilder.Datatype.Lang.PostalAddressUse.WORK_PLACE);
			result = formatter.Format(GetContext("address"), new ADImpl(this.address));
			expectedResult = "<address use=\"WP\">" + SystemUtils.LINE_SEPARATOR + "</address>" + SystemUtils.LINE_SEPARATOR;
			AssertXmlEquals("empty workplace address", expectedResult, result);
			this.address.AddUse(Ca.Infoway.Messagebuilder.Datatype.Lang.PostalAddressUse.HOME);
			result = formatter.Format(GetContext("address"), new ADImpl(this.address));
			XmlDocument document = new DocumentFactory().CreateFromString(result);
			string attribute = (document.DocumentElement).GetAttribute("use");
			FormatterAssert.AssertContainsSame("uses", FormatterAssert.ToSet("H WP"), FormatterAssert.ToSet(attribute));
		}

		/// <exception cref="System.Exception"></exception>
		[Test]
		public virtual void TestFormatFreeformLines()
		{
			AdBasicPropertyFormatter formatter = new AdBasicPropertyFormatter();
			this.address.AddPostalAddressPart(new PostalAddressPart("address line one"));
			string result = formatter.Format(GetContext("address"), new ADImpl(this.address));
			string expectedResult = "<address>" + "address line one" + "</address>";
			AssertXmlEquals("one freeform line", expectedResult, result);
			this.address.AddPostalAddressPart(new PostalAddressPart("address line two"));
			result = formatter.Format(GetContext("address"), new ADImpl(this.address));
			expectedResult = "<address>" + "address line one " + "address line two" + "</address>";
			AssertXmlEquals("two freeform lines", expectedResult, result);
		}

		/// <exception cref="System.Exception"></exception>
		[Test]
		public virtual void TestFormatCity()
		{
			this.address.AddPostalAddressPart(new PostalAddressPart(PostalAddressPartType.CITY, "Cityville"));
			string result = this.formatter.Format(GetContext("address"), new ADImpl(this.address));
			string expectedResult = "<address>" + SystemUtils.LINE_SEPARATOR + "  <city>Cityville</city>" + SystemUtils.LINE_SEPARATOR
				 + "</address>" + SystemUtils.LINE_SEPARATOR;
			AssertXmlEquals("city", expectedResult, result);
		}

		private void AssertXmlEquals(string @string, string expected, string actual)
		{
			Assert.AreEqual(WhitespaceUtil.NormalizeWhitespace(expected), WhitespaceUtil.NormalizeWhitespace(actual), @string);
		}

		/// <exception cref="System.Exception"></exception>
		[Test]
		public virtual void TestFormatProvince()
		{
			this.address.AddPostalAddressPart(new PostalAddressPart(PostalAddressPartType.STATE, "Ontario"));
			string result = this.formatter.Format(GetContext("address"), new ADImpl(this.address));
			string expectedResult = "<address>" + SystemUtils.LINE_SEPARATOR + "  <state>Ontario</state>" + SystemUtils.LINE_SEPARATOR
				 + "</address>" + SystemUtils.LINE_SEPARATOR;
			AssertXmlEquals("province", expectedResult, result);
		}

		/// <exception cref="System.Exception"></exception>
		[Test]
		public virtual void TestFormatPostalCode()
		{
			this.address.AddPostalAddressPart(new PostalAddressPart(PostalAddressPartType.POSTAL_CODE, "postalCodeValue"));
			string result = this.formatter.Format(GetContext("address"), new ADImpl(this.address));
			string expectedResult = "<address>" + SystemUtils.LINE_SEPARATOR + "  <postalCode>postalCodeValue</postalCode>" + SystemUtils
				.LINE_SEPARATOR + "</address>" + SystemUtils.LINE_SEPARATOR;
			AssertXmlEquals("postal code", expectedResult, result);
		}

		/// <exception cref="System.Exception"></exception>
		[Test]
		public virtual void TestNonTrivialDelimiter()
		{
			AddParts(new PostalAddressPartType[] { PostalAddressPartType.UNIT_ID, PostalAddressPartType.DELIMITER, PostalAddressPartType
				.HOUSE_NUMBER, null }, new string[] { "200", "-", "1709", "Bloor St. W." });
			string result = this.formatter.Format(GetContext("address"), new ADImpl(this.address));
			string expectedResult = "<address>" + "200 - 1709 Bloor St. W." + "</address>";
			AssertXmlEquals("postal code", expectedResult, result);
		}

		private void AddParts(PostalAddressPartType[] type, string[] strings)
		{
			for (int i = 0; i < Math.Max(type.Length, strings.Length); i++)
			{
				this.address.AddPostalAddressPart(new PostalAddressPart(i < type.Length ? type[i] : null, i < strings.Length ? strings[i]
					 : null));
			}
		}

		/// <exception cref="System.Exception"></exception>
		[Test]
		public virtual void TestFormatCountryCode()
		{
			this.address.AddPostalAddressPart(new PostalAddressPart(PostalAddressPartType.COUNTRY, Country.CANADA));
			string result = this.formatter.Format(GetContext("address"), new ADImpl(this.address));
			string expectedResult = "<address>" + SystemUtils.LINE_SEPARATOR + "  <country code=\"Canada\">Canada</country>" + SystemUtils
				.LINE_SEPARATOR + "</address>" + SystemUtils.LINE_SEPARATOR;
			AssertXmlEquals("country", expectedResult, result);
		}

		/// <exception cref="System.Exception"></exception>
		[Test]
		public virtual void TestFormatCountryIsoCode()
		{
			this.address.AddPostalAddressPart(new PostalAddressPart(PostalAddressPartType.COUNTRY, Ca.Infoway.Messagebuilder.Domainvalue.Basic.Iso3166Alpha2Country
				.CANADA));
			string result = this.formatter.Format(GetContext("address"), new ADImpl(this.address));
			string expectedResult = "<address>" + SystemUtils.LINE_SEPARATOR + "  <country code=\"CA\">CA</country>" + SystemUtils.LINE_SEPARATOR
				 + "</address>" + SystemUtils.LINE_SEPARATOR;
			AssertXmlEquals("country", expectedResult, result);
		}

		/// <exception cref="System.Exception"></exception>
		[Test]
		public virtual void TestFormatCountryAsCodedString()
		{
			CodedString<Code> country = new CodedString<Code>("Canada", Ca.Infoway.Messagebuilder.Domainvalue.Basic.Iso3166Alpha2Country
				.CANADA);
			this.address.AddPostalAddressPart(new PostalAddressPart(PostalAddressPartType.COUNTRY, country));
			string result = this.formatter.Format(GetContext("address"), new ADImpl(this.address));
			string expectedResult = "<address>" + SystemUtils.LINE_SEPARATOR + "  <country code=\"CA\">Canada</country>" + SystemUtils
				.LINE_SEPARATOR + "</address>" + SystemUtils.LINE_SEPARATOR;
			AssertXmlEquals("country", expectedResult, result);
		}

		/// <exception cref="System.Exception"></exception>
		[Test]
		public virtual void TestFormatAll()
		{
			AdBasicPropertyFormatter formatter = new AdBasicPropertyFormatter();
			this.address.AddPostalAddressPart(new PostalAddressPart(PostalAddressPartType.STREET_ADDRESS_LINE, "1 Yonge St."));
			this.address.AddPostalAddressPart(new PostalAddressPart(PostalAddressPartType.STREET_ADDRESS_LINE, "1 Bloor St."));
			this.address.AddPostalAddressPart(new PostalAddressPart(PostalAddressPartType.STREET_ADDRESS_LINE, "1 Spadina Ave."));
			this.address.AddUse(Ca.Infoway.Messagebuilder.Datatype.Lang.PostalAddressUse.HOME);
			this.address.AddPostalAddressPart(new PostalAddressPart(PostalAddressPartType.CITY, "Toronto"));
			this.address.AddPostalAddressPart(new PostalAddressPart(PostalAddressPartType.STATE, State.ONTARIO));
			this.address.AddPostalAddressPart(new PostalAddressPart(PostalAddressPartType.POSTAL_CODE, "postalCodeValue"));
			this.address.AddPostalAddressPart(new PostalAddressPart(PostalAddressPartType.COUNTRY, Country.CANADA));
			this.address.AddPostalAddressPart(new PostalAddressPart("freeformLine1"));
			this.address.AddPostalAddressPart(new PostalAddressPart("freeformLine2"));
			string result = formatter.Format(GetContext("address"), new ADImpl(this.address));
			string expectedResult = "<address use=\"H\">" + "1 Yonge St.<delimiter></delimiter>" + "1 Bloor St.<delimiter></delimiter>"
				 + "1 Spadina Ave." + "<city>Toronto</city>" + "<state code=\"ON\">ON</state>" + "<postalCode>postalCodeValue</postalCode>"
				 + "<country code=\"Canada\">Canada</country>" + "freeformLine1 freeformLine2" + "</address>";
			AssertXmlEquals("full address", expectedResult, result);
		}

		/// <exception cref="System.Exception"></exception>
		[Test]
		public virtual void TestFormatAllInvalidAddressUses()
		{
			AssertInvalidAddressUse(Ca.Infoway.Messagebuilder.Datatype.Lang.PostalAddressUse.ALPHABETIC);
			AssertInvalidAddressUse(Ca.Infoway.Messagebuilder.Datatype.Lang.PostalAddressUse.BAD);
			AssertInvalidAddressUse(Ca.Infoway.Messagebuilder.Datatype.Lang.PostalAddressUse.DIRECT);
			AssertInvalidAddressUse(Ca.Infoway.Messagebuilder.Datatype.Lang.PostalAddressUse.IDEOGRAPHIC);
			AssertInvalidAddressUse(Ca.Infoway.Messagebuilder.Datatype.Lang.PostalAddressUse.PRIMARY_HOME);
			AssertInvalidAddressUse(Ca.Infoway.Messagebuilder.Datatype.Lang.PostalAddressUse.PUBLIC);
			AssertInvalidAddressUse(Ca.Infoway.Messagebuilder.Datatype.Lang.PostalAddressUse.SYLLABIC);
			AssertInvalidAddressUse(Ca.Infoway.Messagebuilder.Datatype.Lang.PostalAddressUse.VACATION_HOME);
		}

		/// <exception cref="System.Exception"></exception>
		private void AssertInvalidAddressUse(Ca.Infoway.Messagebuilder.Datatype.Lang.PostalAddressUse postalAddressUse)
		{
			string xml = new AdBasicPropertyFormatter().Format(GetContext("address"), new ADImpl(this.address));
			Assert.IsFalse(xml.Contains("use"), "use: " + postalAddressUse);
		}

		/// <exception cref="System.Exception"></exception>
		[Test]
		public virtual void TestFormatAllValidAddressUses()
		{
			AssertValidAddressUse(Ca.Infoway.Messagebuilder.Datatype.Lang.PostalAddressUse.HOME);
			AssertValidAddressUse(Ca.Infoway.Messagebuilder.Datatype.Lang.PostalAddressUse.PHYSICAL);
			AssertValidAddressUse(Ca.Infoway.Messagebuilder.Datatype.Lang.PostalAddressUse.POSTAL);
			AssertValidAddressUse(Ca.Infoway.Messagebuilder.Datatype.Lang.PostalAddressUse.TEMPORARY);
			AssertValidAddressUse(Ca.Infoway.Messagebuilder.Datatype.Lang.PostalAddressUse.WORK_PLACE);
		}

		/// <exception cref="System.Exception"></exception>
		private void AssertValidAddressUse(Ca.Infoway.Messagebuilder.Datatype.Lang.PostalAddressUse use)
		{
			PostalAddress postalAddress = new PostalAddress();
			postalAddress.AddUse(use);
			string result = new AdBasicPropertyFormatter().Format(GetContext("address"), new ADImpl(postalAddress));
			string expected = "<address use=\"" + use.CodeValue + "\">" + SystemUtils.LINE_SEPARATOR + "</address>" + SystemUtils.LINE_SEPARATOR;
			AssertXmlEquals("use formatted properly", expected, result);
		}
	}
}
