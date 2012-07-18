using System.IO;
using System.Text;

namespace Ca.Infoway.Messagebuilder.Util.Text
{
	/// <summary>
	/// This class provides basic functionality related to writing out the
	/// type of indentation you see in source code.
	/// </summary>
	/// <remarks>
	/// This class provides basic functionality related to writing out the
	/// type of indentation you see in source code.
	/// </remarks>
	/// <author>Intelliware Development</author>
	public class Indenter
	{
		private static readonly string INDENT = "  ";

		/// <summary>Write an indent to a StringBuffer.</summary>
		/// <remarks>Write an indent to a StringBuffer.</remarks>
		/// <param name="buffer">- the StringBuffer to which the tabs are written.</param>
		/// <param name="indentLevel">- the number of "tabs" to indent</param>
		public static void IndentBuffer(StringBuilder buffer, int indentLevel)
		{
			for (; indentLevel > 0; indentLevel--)
			{
				buffer.Append(INDENT);
			}
		}

		/// <summary>Write an indent to a StringBuilder.</summary>
		/// <remarks>Write an indent to a StringBuilder.</remarks>
		/// <param name="builder">- the StringBuilder to which the tabs are written.</param>
		/// <param name="indentLevel">- the number of "tabs" to indent</param>
		public static void IndentBuilder(StringBuilder builder, int indentLevel)
		{
			for (; indentLevel > 0; indentLevel--)
			{
				builder.Append(INDENT);
			}
		}

		/// <summary>Write an indent to a string.</summary>
		/// <remarks>Write an indent to a string.</remarks>
		/// <param name="string">- the string to which the tabs are written.</param>
		/// <param name="indentLevel">- the number of "tabs" to indent</param>
		/// <returns>the indented string</returns>
		public static string Indent(string @string, int indentLevel)
		{
			StringBuilder builder = new StringBuilder();
			IndentBuilder(builder, indentLevel);
			builder.Append(@string);
			return builder.ToString();
		}

		/// <summary>Write an indent to a Writer.</summary>
		/// <remarks>Write an indent to a Writer.</remarks>
		/// <param name="indentLevel">- the number of "tabs" to indent</param>
		/// <param name="writer">- the Writer to which the tabs are written.</param>
		/// <exception cref="System.IO.IOException"></exception>
		protected virtual void Indent(int indentLevel, TextWriter writer)
		{
			for (; indentLevel > 0; indentLevel--)
			{
				writer.Write(INDENT);
			}
		}
	}
}
