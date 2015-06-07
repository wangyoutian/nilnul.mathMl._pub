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
@"<{0}:InverseRow runat=""server"">
	<%--element*--%>

</{0}:InverseRow>")]
	[ParseChildren(false)]	//don't parse, so they are left as is, i.e., controls.
	public class InverseRow : WebControl
	{

		const string tag = "mfrac";



		protected override void Render(HtmlTextWriter output)
		{
			output.RenderBeginTag(tag);
			
			new Mn1().RenderControl(output);
			output.RenderBeginTag("mrow");

			RenderChildren(output);
			output.RenderEndTag();


			output.RenderEndTag();
		}






	}
}
