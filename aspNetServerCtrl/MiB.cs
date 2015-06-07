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
	[ToolboxData(@"<{0}:MiB runat=""server""/>")]
	public class MiB : WebControl
	{


		protected override void Render(HtmlTextWriter output)
		{
			output.RenderBeginTag("mi");
			output.Write("B");
			output.RenderEndTag();
		}


	}
}
