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
@"<{0}:UnionUnder runat=""server"">
	<!--one element: under union symbol--> 
 </{0}:UnionUnder>")]
	[ParseChildren(false)]	//don't parse, so they are left as is, i.e., controls.
	public class UnionUnder : WebControl
	{


		public const  string TAG=		"munder";
			

		public const string Union_Entity_String = "&cup;";

		protected override void Render(HtmlTextWriter output)
		{
			//if (DesignMode)
			//{
			//	output.Write( string.Format("&lt;/{0}&gt;"),tag);
			//	return;
			//}


			output.RenderBeginTag(TAG);

			output.RenderBeginTag("mo");
			output.Write(Union_Entity_String);
			output.RenderEndTag();

			RenderChildren(output);

			//RenderContents(output);
			output.RenderEndTag();

		}



	}
}
