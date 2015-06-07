using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace nilnul.mathMl._aspNetServerCtrl
{
	[DefaultProperty("Text")]
	[ToolboxData("<{0}:FracHalf runat=server></{0}:FracHalf>")]
	public class FracHalf : WebControl
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

			var xe = new XElement("mfrac",
						 

						new XElement("mn",1)
						,
						new XElement("mn",2)



						);
			


			return xe.ToString();
		}
	}
}
