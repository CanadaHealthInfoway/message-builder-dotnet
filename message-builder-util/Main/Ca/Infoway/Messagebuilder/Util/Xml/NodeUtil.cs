using System.Collections.Generic;
using System.Xml;
using Ca.Infoway.Messagebuilder;

namespace Ca.Infoway.Messagebuilder.Util.Xml
{
	/// <summary>A variety of utility methods for manipulating nodes.</summary>
	/// <remarks>A variety of utility methods for manipulating nodes.</remarks>
	/// <author>Intelliware Development</author>
	public class NodeUtil
	{
		/// <summary>
		/// Scan all immediate children of a node, and append all
		/// text nodes into a string.
		/// </summary>
		/// <remarks>
		/// Scan all immediate children of a node, and append all
		/// text nodes into a string.  Consider the following example:
		/// 
		/// &lt;customer&gt;Joe Schmoe&lt;/customer&gt;
		/// 
		/// In this case, calling this method on the
		/// customer element returns "Joe Schmoe".
		/// </remarks>
		/// <param name="node">- the node to scan</param>
		/// <returns>- the text string</returns>
		public static string GetTextValue(XmlNode node)
		{
			return GetTextValue(node, false);
		}

		/// <summary>
		/// Scan all immediate children of a node, and append all
		/// text nodes into a string.
		/// </summary>
		/// <remarks>
		/// Scan all immediate children of a node, and append all
		/// text nodes into a string.  Consider the following example:
		/// 
		/// &lt;customer&gt;Joe Schmoe&lt;/customer&gt;
		/// 
		/// In this case, calling this method on the
		/// customer element returns "Joe Schmoe".
		/// </remarks>
		/// <param name="node">- the node to scan</param>
		/// <param name="recurse">
		/// - a flag to indicate whether or not to recurse into
		/// sub-elements
		/// </param>
		/// <returns>- the text string</returns>
		public static string GetTextValue(XmlNode node, bool recurse)
		{
			string text = null;
			if (node != null)
			{
				text = string.Empty;
				XmlNodeList textList = node.ChildNodes;
				for (int i = 0; i < textList.Count; i++)
				{
					XmlNode child = textList.Item(i);
					if (child.NodeType == System.Xml.XmlNodeType.Text || child.NodeType == System.Xml.XmlNodeType.CDATA)
					{
						text += ((XmlText)child).Data;
					}
					else
					{
						if (recurse && child.NodeType == System.Xml.XmlNodeType.Element)
						{
							text += GetTextValue(child, recurse);
						}
					}
				}
			}
			return text;
		}

		/// <summary>Treat the NodeList as a standard list.</summary>
		/// <remarks>Treat the NodeList as a standard list.</remarks>
		/// <param name="children">- the node list</param>
		/// <returns>- the list of nodes</returns>
		public static IList<XmlNode> AsList(XmlNodeList children)
		{
			IList<XmlNode> nodes = new List<XmlNode>();
			int length = children == null ? 0 : children.Count;
			for (int i = 0; i < length; i++)
			{
				nodes.Add(children.Item(i));
			}
			return nodes;
		}

		/// <summary>Get all children of a particular tag name as a list.</summary>
		/// <remarks>Get all children of a particular tag name as a list.</remarks>
		/// <param name="node">- the parent node</param>
		/// <param name="tagName">- the tag name to select</param>
		/// <returns>- the list of nodes</returns>
		public static IList<XmlNode> GetChildNodes(XmlNode node, string tagName)
		{
			if (node.NodeType != System.Xml.XmlNodeType.Element)
			{
				return CollUtils.EmptyList<XmlNode>();
			}
			else
			{
				return AsList(((XmlElement)node).GetElementsByTagName(tagName));
			}
		}

		/// <summary>Get all child elements of the given node as a list of elements.</summary>
		/// <remarks>Get all child elements of the given node as a list of elements.</remarks>
		/// <param name="node">- the node</param>
		/// <returns>- the list of child elements</returns>
		public static IList<XmlElement> ToElementList(XmlNode node)
		{
			IList<XmlElement> elements = new List<XmlElement>();
			XmlNodeList childNodes = node.ChildNodes;
			int length = childNodes == null ? 0 : childNodes.Count;
			for (int i = 0; i < length; i++)
			{
				XmlNode childNode = childNodes.Item(i);
				if (childNode is XmlElement)
				{
					elements.Add((XmlElement)childNode);
				}
			}
			return elements;
		}

		/// <summary>
		/// Get the local or tag name (depending on whether or not the DOM tree was
		/// parsed with namespace awareness.
		/// </summary>
		/// <remarks>
		/// Get the local or tag name (depending on whether or not the DOM tree was
		/// parsed with namespace awareness.
		/// </remarks>
		/// <param name="node">- the node/element</param>
		/// <returns>- the local name, if it is not blank; the tag name otherwise.</returns>
		public static string GetLocalOrTagName(XmlNode node)
		{
			return StringUtils.IsBlank(node.LocalName) ? node.Name : node.LocalName;
		}
	}
}
