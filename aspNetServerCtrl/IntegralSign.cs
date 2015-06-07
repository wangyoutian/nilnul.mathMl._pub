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
@"<{0}:IntegralSign runat=""server"" />")]
	[ParseChildren(false)]	//don't parse, so they are left as is, i.e., controls.
	public class IntegralSign: WebControl
	{

		public const string EntityString = "&#x222B;";


		protected override void Render(HtmlTextWriter output)
		{
			if (DesignMode)
			{
				output.Write("&lt;mint&gt;");
				return;
			}

			output.Write(EntityString);
			
		}






	}
}
