using System.Collections.Generic;
using Ca.Infoway.Messagebuilder;
using Ca.Infoway.Messagebuilder.Xml;
using Platform.SimpleXml;

namespace Ca.Infoway.Messagebuilder.Xml
{
	/// <summary>The package location.</summary>
	/// <remarks>The package location.  Each package location corresponds with one MIF file.</remarks>
	/// <author>Intelliware Development</author>
	[RootAttribute]
	public class PackageLocation : Categorizable, HasDifferences, Named
	{
		[XmlAttributeAttribute]
		private string name;

		[XmlAttributeAttribute(Name = "desc", Required = false)]
		private string descriptiveName;

		[XmlAttributeAttribute(Required = false)]
		private string rootType;

		[ElementListAttribute(Inline = true, Required = false)]
		[NamespaceAttribute(Prefix = "regen", Reference = "regen_ns")]
		private IList<Difference> differences = new List<Difference>();

		[ElementMapAttribute(Name = "messagePart", Key = "name", Required = false, Inline = true, Attribute = true)]
		private IDictionary<string, MessagePart> messageParts = new SortedList<string, MessagePart>();

		[XmlAttributeAttribute(Required = false)]
		private string category;

		/// <summary>The default constructor.</summary>
		/// <remarks>The default constructor.</remarks>
		public PackageLocation()
		{
		}

		/// <summary>Standard constructor.</summary>
		/// <remarks>Standard constructor.</remarks>
		/// <param name="name">the name of the package location</param>
		public PackageLocation(string name)
		{
			this.name = name;
		}

		/// <summary>Get the name.</summary>
		/// <remarks>Get the name.  e.g. "PRPA_MT101103CA"</remarks>
		/// <returns>the name</returns>
		/// <summary>Set the name.</summary>
		/// <remarks>Set the name.</remarks>
		/// <value>- the new name</value>
		public virtual string Name
		{
			get
			{
				return this.name;
			}
			set
			{
				string name = value;
				this.name = name;
			}
		}

		/// <summary>The name of the top-level class defined by the MIF file.</summary>
		/// <remarks>The name of the top-level class defined by the MIF file.</remarks>
		/// <returns>the root type name.</returns>
		/// <summary>Set the name of the top-level class defined by the MIF file.</summary>
		/// <remarks>Set the name of the top-level class defined by the MIF file.</remarks>
		/// <value>- the root type name.</value>
		public virtual string RootType
		{
			get
			{
				return this.rootType;
			}
			set
			{
				string rootType = value;
				this.rootType = rootType;
			}
		}

		/// <summary>Get a map of all message parts, keyed by fully-qualified type name.</summary>
		/// <remarks>Get a map of all message parts, keyed by fully-qualified type name.</remarks>
		/// <returns>- the map</returns>
		/// <summary>Set the map of all message parts.</summary>
		/// <remarks>Set the map of all message parts.</remarks>
		/// <value>- the new value</value>
		public virtual IDictionary<string, MessagePart> MessageParts
		{
			get
			{
				return this.messageParts;
			}
			set
			{
				IDictionary<string, MessagePart> messageParts = value;
				this.messageParts = messageParts;
			}
		}

		/// <summary>Get the descriptive name.</summary>
		/// <remarks>Get the descriptive name.</remarks>
		/// <returns>the descriptive name.</returns>
		/// <summary>Set the descriptive name.</summary>
		/// <remarks>Set the descriptive name.</remarks>
		/// <value>- the new value</value>
		public virtual string DescriptiveName
		{
			get
			{
				return this.descriptiveName;
			}
			set
			{
				string descriptiveName = value;
				this.descriptiveName = descriptiveName;
			}
		}

		/// <summary>Set the category, such as "cr" (Client Registry).</summary>
		/// <remarks>Set the category, such as "cr" (Client Registry).</remarks>
		/// <value>- the new value</value>
		/// <summary>Get the category.</summary>
		/// <remarks>Get the category.</remarks>
		/// <returns>the category</returns>
		public virtual string Category
		{
			get
			{
				return this.category;
			}
			set
			{
				string category = value;
				this.category = category;
			}
		}

		/// <summary>Tracks package location differences for regen</summary>
		/// <returns>the differences</returns>
		public virtual IList<Difference> Differences
		{
			get
			{
				return this.differences;
			}
		}

		public virtual void SetDifferences(IList<Difference> differences)
		{
			this.differences = differences;
		}

		public virtual void AddDifference(Difference difference)
		{
			this.differences.Add(difference);
		}
	}
}
