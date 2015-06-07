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

	[ToolboxData(@"
<{0}:Mfrac2 runat=""server"">
	<%--element*2: numerator, denominator--%>

</{0}:Mfrac2>")]
	[ParseChildren(false)]	//don't parse, so they are left as is, i.e., controls.
	public class Mfrac2 : WebControl
	{

		public const string tag = "mfrac";



		protected override void Render(HtmlTextWriter output)
		{
			output.RenderBeginTag(tag);


			RenderChildren(output);

			output.RenderEndTag();

		}






	}
}
