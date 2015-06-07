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

	[ToolboxData(@"<{0}:InvisibleTimes runat=""server"" />")]

	[ParseChildren(false)]	//don't parse, so they are left as is, i.e., controls.
	public class InvisibleTimes: WebControl
	{

		protected override void Render(HtmlTextWriter output)
		{

			this.output(output);
		}

		public void output(HtmlTextWriter output) {

			output.Write("<mo>");

			output.Write("&#x2062;");
			output.Write("</mo>");
		
		}






	}
}
