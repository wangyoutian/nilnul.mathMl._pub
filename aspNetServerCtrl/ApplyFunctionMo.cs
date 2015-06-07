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
@"<{0}:ApplyFunctionMo runat=""server"" />")]
	[ParseChildren(false)]	//don't parse, so they are left as is, i.e., controls.
	public class ApplyFunctionMo: WebControl
	{

		public string Tag = "mo";


		protected override void Render(HtmlTextWriter output)
		{
			if (DesignMode)
			{
			output.Write(ApplyFunction_entity.EntityStr);
				return;
			}

			output.Write("<{0}>",Tag);

			output.Write(ApplyFunction_entity.EntityStr);

			output.Write("</{0}>",Tag);

		//	RenderChildren(output);

			//RenderContents(output);

			//output.Write("</subsup>");
		}






	}
}
