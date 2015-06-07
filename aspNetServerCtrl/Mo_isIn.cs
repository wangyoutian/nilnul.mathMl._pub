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
	[ToolboxData(@"<{0}:Mo_isIn runat=""server""/>")]
	public class Mo_isIn : WebControl
	{

		protected override void Render(HtmlTextWriter output)
		{
			output.RenderBeginTag("mo");
			output.Write("&isin;");
			output.RenderEndTag();
		}




	}
}
