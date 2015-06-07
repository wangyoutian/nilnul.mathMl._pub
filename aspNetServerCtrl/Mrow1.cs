using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;
using System.Xml;

namespace nilnul.mathMl._ctr
{

	[ToolboxData(
@"<{0}:Mrow1 runat=""server"">
	<!--element*-->

</{0}:Mrow1>")]
	[ParseChildren(false)]	//don't parse, so they are left as is, i.e., controls.
	public class Mrow1: WebControl
	{

		protected override void Render(HtmlTextWriter output)
		{


			output.RenderBeginTag("mrow");

			RenderChildren(output);
			output.RenderEndTag();

		}







	}
}
