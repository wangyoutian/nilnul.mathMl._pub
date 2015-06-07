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
	[ToolboxData("<{0}:Mn1 runat=server></{0}:Mn1>")]
	public class Mn1 : WebControl
	{




	

		protected override void Render(HtmlTextWriter output)
		{

				output.Write(xmlWrapper2());
		}






		private string xmlWrapper2()
		{

			var xe = new XElement("mn",
						 

						"1"



						);
			


			return xe.ToString();
		}
	}
}
