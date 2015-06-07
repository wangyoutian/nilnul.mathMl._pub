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
@"<{0}:IntegralPrefix runat=""server"">
	<!--element 2: lower, upper-->
	
</{0}:IntegralPrefix>"
)]
	[ParseChildren(false)]	//don't parse, so they are left as is, i.e., controls.
	public class IntegralPrefix: WebControl
	{

		


		protected override void Render(HtmlTextWriter output)
		{
			output.RenderBeginTag("msubsup");

			new IntegralSign_Mo().RenderControl(output);

			RenderChildren(output);
			output.RenderEndTag();



			
		}






	}
}
