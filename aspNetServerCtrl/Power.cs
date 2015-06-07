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
	[ToolboxData("<{0}:Power runat=server base=2 power=1/2 ></{0}:Power>")]
	public class Power : WebControl
	{


		const string basePropertyName = "base";
		const string powerPropertyName = "power";
		



		[Bindable(true)]
		[Category("Appearance")]
		[DefaultValue("")]
		[Localizable(true)]
		public string base_
		{
			get
			{
				String s = (String)ViewState[basePropertyName];
				return ((s == null) ? "x" : s);
			}

			set
			{
				ViewState[basePropertyName] = value;
			}
		}

		[Bindable(true)]
		[Category("Appearance")]
		[DefaultValue("")]
		[Localizable(true)]
		public string power
		{
			get
			{
				String s = (String)ViewState[powerPropertyName];
				return ((s == null) ? "2" : s);
			}

			set
			{
				ViewState[powerPropertyName] = value;
			}
		}





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

			var xe = new XElement("msup",
						 

						new XElement("mi",base_)
						,
						new XElement("mn",power)



						);
			


			return xe.ToString();
		}
	}
}
