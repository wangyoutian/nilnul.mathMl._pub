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
@"<{0}:Math3 runat=""server""> 
	<%--elements--%>
	
</{0}:Math3>")]
	[ParseChildren(false)]	//don't parse, so they are left as is, i.e., controls.
	public class Math3 : WebControl
	{




		protected override void Render(HtmlTextWriter output)
		{
			//if (DesignMode)
			//{
			//	output.Write("&lt;math&gt;");
			//	return;
			//}

			output.RenderBeginTag("math");
			RenderChildren(output);

			output.RenderEndTag();

		}






	}
}
