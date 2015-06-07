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
	[ToolboxData("<{0}:MoGt runat=server></{0}:MoGt>")]
	public class MoGt : WebControl
	{





		protected override void Render(HtmlTextWriter output)
		{

			output.Write("<mo>");

			output.Write("&gt;");
			output.Write("</mo>");

		}






	}
}
