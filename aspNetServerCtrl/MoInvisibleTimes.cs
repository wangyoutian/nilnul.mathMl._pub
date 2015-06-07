using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace nilnul.mathMl._ctr
{
	[ToolboxData(@"<{0}:MoInvisibleTimes runat=""server""/>")]
	public class MoInvisibleTimes : WebControl
	{


		protected override void Render(HtmlTextWriter output)
		{
			output.Write("<mo>");

			output.Write("&#x2062;");
			output.Write("</mo>");
			// There is also a MathML entity name for the invisible times character: &InvisibleTimes;.I recommend AGAINST using this named version of the entity. The reason is that if your MathML code gets embedded into other kinds of markup (like HTML, Atom, RSS, other XML, etc) using the &InvisibleTimes; version of the entity may actually break things (due to invalid XML). (I'll skip the technical details, but if you're interested it relates to DTDs.) For this reason I strongly recommend FOR using the &#8290; entity whenver you want to create an invisible times. 

		}







	}
}
