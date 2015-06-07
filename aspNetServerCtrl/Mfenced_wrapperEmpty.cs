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
	[ToolboxData(
	@"<{0}:Mfenced_wrapperEmpty runat=""server"">
		<!--elements will be separated by comma-->
	</{0}:Mfenced_wrapperEmpty>")]
	[ParseChildren(false)]	//don't parse, so they are left as is, i.e., children controls.

	public class Mfenced_wrapperEmpty : WebControl
	{

		protected override void Render(HtmlTextWriter output)
		{
			output.AddAttribute("open", "");
			output.AddAttribute("close", "");
			output.RenderBeginTag("mfenced");
			RenderChildren(output);
			output.RenderEndTag();
		}

	}
}
