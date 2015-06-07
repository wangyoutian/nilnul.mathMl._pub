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
	[ToolboxData("<{0}:Mfrac runat=server numerator=1 denominator=2></{0}:Mfrac>")]
	public class Mfrac : WebControl
	{
		[Bindable(true)]
		[Category("Appearance")]
		[DefaultValue("")]
		[Localizable(true)]
		public string Text
		{
			get
			{
				String s = (String)ViewState["Text"];
				return ((s == null) ? String.Empty : s);
			}

			//set
			//{
			//	ViewState["Text"] = value;
			//}
		}


		[Bindable(true)]
		[Category("Appearance")]
		[DefaultValue("")]
		[Localizable(true)]
		public string numerator
		{
			get
			{
				String s = (String)ViewState["numerator"];
				return ((s == null) ? String.Empty : s);
			}

			set
			{
				ViewState["numerator"] = value;
			}
		}

		[Bindable(true)]
		[Category("Appearance")]
		[DefaultValue("")]
		[Localizable(true)]
		public string denominator
		{
			get
			{
				String s = (String)ViewState["denominator"];
				return ((s == null) ? String.Empty : s);
			}

			set
			{
				ViewState["denominator"] = value;
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

			var xe = new XElement("mfrac",
						  new XAttribute("id", this.NamingContainer.ClientID)
						,

						new XElement("mrow",numerator)
						,
						new XElement("mrow",denominator)



						);
			


			return xe.ToString();
		}
	}
}
