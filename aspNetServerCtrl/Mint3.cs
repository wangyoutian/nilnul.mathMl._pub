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
@"<{0}:Mint3 runat=""server"">
	<msubsup>
		<mo> &#x222B;<!--INTEGRAL--> </mo>
		<mn> 0 </mn>
		<mn> 1 </mn>
	</msubsup>
	<mrow>
		<mrow>
			<!-- here goes f(x)-->
		</mrow>
		<mo> &#x2062;<!--INVISIBLE TIMES--> </mo>
		<mrow>
			<mo> &#x2146;<!--DOUBLE-STRUCK ITALIC SMALL D--> </mo>
			<mi> x </mi>
		</mrow>
	</mrow>
</{0}:Mint3>")]
	[ParseChildren(false)]	//don't parse, so they are left as is, i.e., controls.
	public class Mint3: WebControl
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
