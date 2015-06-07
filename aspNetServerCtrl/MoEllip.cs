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
	[DefaultProperty("Text")]
	[ToolboxData("<{0}:MoEllip runat=server></{0}:MoEllip>")]
	public class MoEllip : WebControl
	{




		protected override void Render(HtmlTextWriter output)
		{

			output.Write("<mo>");

			output.Write("&hellip;");
			output.Write("</mo>");


		}






	
	}
}
