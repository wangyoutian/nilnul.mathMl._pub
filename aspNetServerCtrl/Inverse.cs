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
@"<{0}:Inverse runat=""server"">
	<%--element: denominator--%>

</{0}:Inverse>")]
	[ParseChildren(false)]	//don't parse, so they are left as is, i.e., controls.
	public class Inverse : WebControl
	{

		const string tag = "mfrac";



		protected override void Render(HtmlTextWriter output)
		{
			output.RenderBeginTag(tag);
			new Mn1().RenderControl(output);

			RenderChildren(output);


			output.RenderEndTag();
		}






	}
}
