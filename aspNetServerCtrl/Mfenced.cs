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
@"<{0}:MFenced runat=""server"">
	<!--element*-->
</{0}:MFenced>")]
	[ParseChildren(false)]	//don't parse, so they are left as is, i.e., children controls.

	public class MFenced: WebControl
	{

		protected override void Render(HtmlTextWriter output)
		{
			output.RenderBeginTag("mfenced");
			RenderChildren(output);
			output.RenderEndTag();
		}

	}
}
