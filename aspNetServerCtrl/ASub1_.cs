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
	[ToolboxData("<{0}:ASub1_ runat=server></{0}:ASub1_>")]
	public class ASub1_ : WebControl
	{


		protected override void RenderContents(HtmlTextWriter output)
		{

			output.Write(xmlWrapper2());
		}

		protected override void Render(HtmlTextWriter output)
		{

			RenderContents(output);
		}






		private string xmlWrapper2()
		{

			var xe = new XElement("msub",
						 

						new XElement("mi","a")
						,
						new XElement("mn",1)



						);
			


			return xe.ToString();
		}
	}
}
