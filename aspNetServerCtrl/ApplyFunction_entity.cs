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
	[ToolboxData("<{0}:ApplyFunction_entity runat=server />")]
	public class ApplyFunction_entity : WebControl
	{
		public const string EntityStr = "&ApplyFunction;";

		protected override void Render(HtmlTextWriter output)
		{


			

			output.Write(EntityStr);

		}






		
	}
}
