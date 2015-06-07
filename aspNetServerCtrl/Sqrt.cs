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

namespace nilnul.mathMl.ctrl
{

	[ToolboxData("<{0}:Sqrt runat=\"server\"><mrow>2</mrow></{0}:Sqrt>")]
	[ParseChildren(false)]	//don't parse into properties, so they are left as is, i.e., controls.
	public class Sqrt : WebControl
	{
		const string tag = "msqrt";
		protected override void Render(HtmlTextWriter output)
		{
			if (DesignMode)
			{
				output.Write(string.Format( "&lt;{0}&gt;",tag));
				return;
			}


			output.Write( string.Format("<{0}>",tag));
			RenderChildren(output);

			//RenderContents(output);

			output.Write(string.Format("</{0}>", tag));
		}
	}
}
