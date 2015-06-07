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
	[DefaultProperty("Text")]
	[ToolboxData("<{0}:MoMinus runat=server></{0}:MoMinus>")]
	public class MoMinus : WebControl
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

			var xe = new XElement("mo",
						 

						"-"



						);
			


			return xe.ToString();
		}
	}
}
