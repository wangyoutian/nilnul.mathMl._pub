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

namespace nilnul.mathMl._aspNetServerCtrl
{

	[ToolboxData("<{0}:Ln runat=\"server\"><mi>ln</mi></{0}:Ln>")]
	[ParseChildren(false)]	//don't parse, so they are left as is, i.e., controls.
	public class Ln : WebControl
	{




		protected override void Render(HtmlTextWriter output)
		{
			if (DesignMode)
			{
				output.Write("&lt;ln&gt;");
				return;
			}


			output.Write("<mi>");
			output.Write("ln");
		//	RenderChildren(output);

			//RenderContents(output);

			output.Write("</mi>");
		}






	}
}
