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

namespace nilnul.mathMl._aspCtr
{


	//[ParseChildren(false)]	//don't parse, so they are left as is, i.e., controls.
	//[ToolboxItem(false)]

	public  class WrapperA2 : WebControl
	{


		public virtual string tag
		{
			get;
			set;

		}
		



		protected override void Render(HtmlTextWriter output)
		{
			if (DesignMode)
			{
				output.Write( string.Format("&lt;/{0}&gt;"),tag);
				return;
			}


			output.Write( string.Format("<{0}>",tag));
			RenderChildren(output);

			//RenderContents(output);

			output.Write(string.Format("</{0}>", tag));
		}


		//static public void Render_Static(HtmlTextWriter output, string tag, WebControl ctr) {

		//	if (ctr.DesignMode)
		//	{
		//		output.Write(string.Format("&lt;/{0}&gt;"), tag);
		//		return;
		//	}


		//	output.Write(string.Format("<{0}>", tag));
		//	ctr.RenderChildren(output);

		//	//RenderContents(output);

		//	output.Write(string.Format("</{0}>", tag));

		
		
		//}





	}
}
