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
	[ToolboxData(@"<{0}:Mi_x runat=""server""/>")]
	[ParseChildren(false)]	//don't parse, so they are left as is, i.e., controls.

	public class Mi_x : WebControl
	{


		protected override void Render(HtmlTextWriter output)
		{
			output.RenderBeginTag("mi");
			output.Write("x");
			output.RenderEndTag();
		}


	}
}
