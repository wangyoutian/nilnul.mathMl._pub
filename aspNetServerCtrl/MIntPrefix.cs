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
@"<{0}:MIntegralPrefix runat=""server"">
	<msubsup>
		<mo> &#x222B;</mo>
		<mn> 0 </mn>
		<mn> 1 </mn>
	</msubsup>
</{0}:MIntegralPrefix>")]
	[ParseChildren(false)]	//don't parse, so they are left as is, i.e., controls.
	public class MIntegralPrefix : WebControl
	{




		protected override void Render(HtmlTextWriter output)
		{
			if (DesignMode)
			{
				output.Write("&lt;mint&gt;");
				return;
			}


			//output.Write("<msubsup>");
			RenderChildren(output);

			//RenderContents(output);

			//output.Write("</subsup>");
		}






	}
}
