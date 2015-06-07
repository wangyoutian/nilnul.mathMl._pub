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
@"<{0}:Differential runat=""server"" />")]
	[ParseChildren(false)]	//don't parse, so they are left as is, i.e., controls.
	public class Differential: WebControl
	{


		public const string EntityStr = "&#x2146;";

		protected override void Render(HtmlTextWriter output)
		{
			if (DesignMode)
			{
				output.Write("d");
				return;
			}


			output.Write(EntityStr);
		//	RenderChildren(output);

			//RenderContents(output);

			//output.Write("</subsup>");
		}






	}
}
