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

namespace nilnul.mathMl._aspNetServerCtrl
{
	
	[ToolboxData("<{0}:Msub runat=\"server\"><mi>a</mi><mn>1</mn></{0}:Msub>")]
	[ParseChildren(false)]	//don't parse, so they are left as is, i.e., controls.
	public class Msub : WebControl
	{
		

		const string middlePropertyName = "middel";
		const string lowerPropertyName = "lower";


		[Bindable(true)]
		[Category("Appearance")]
		[DefaultValue("")]
		[Localizable(true)]
		public string middle
		{
			get
			{
				String s = (String)ViewState[middlePropertyName];
				return ((s == null) ? "a" : s);
			}

			set
			{
				ViewState[middlePropertyName]= value;
			}
		}

		[Bindable(true)]
		[Category("Appearance")]
		[DefaultValue("")]
		[Localizable(true)]
		public string lower
		{
			get
			{
				String s = (String)ViewState[lowerPropertyName];
				return ((s == null) ? "1" : s);
			}

			set
			{
				ViewState[lowerPropertyName] = value;
			}
		}





		protected override void RenderContents(HtmlTextWriter output)
		{

			output.Write(xmlWrapper2());
		}

		protected override void Render(HtmlTextWriter output)
		{

			output.Write("<msub>");
			RenderChildren(output);

			//RenderContents(output);

			output.Write("</msub>");
		}






		private string xmlWrapper2()
		{

			



			var xe = new XElement("msub"	,

						new XElement("mi", ( middle))
						,
						new XElement("mi",lower)
						

						);
			return xe.ToString();


			//return xe.ToString().Replace("&amp;","&");
		}
	}
}
