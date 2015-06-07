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

namespace nilnul.mathMl._aspCtr
{

	[ToolboxData(@"<{0}:Msup runat=""server"">
  <msup>
	<mrow>
		<mi> &#x2147;<!--DOUBLE-STRUCK ITALIC SMALL E--> </mi>
	</mrow>
	<mrow>
		<mn>2</mn>
	</mrow>
  </msup></{0}:Msup>")]
	[ParseChildren(false)]	//don't parse, so they are left as is, i.e., controls.
	public class Msup: WebControl
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
