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
	[DefaultProperty("Text")]
	[ToolboxData("<{0}:Mint runat=server></{0}:Mint>")]
	public class Mint: WebControl
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

		const string upperPropertyName = "upper";
		const string lowerPropertyName = "lower";


		[Bindable(true)]
		[Category("Appearance")]
		[DefaultValue("")]
		[Localizable(true)]
		public string upper
		{
			get
			{
				String s = (String)ViewState[upperPropertyName];
				return ((s == null) ? String.Empty : s);
			}

			set
			{
				ViewState[upperPropertyName]= value;
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
				return ((s == null) ? String.Empty : s);
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

			RenderContents(output);
		}






		private string xmlWrapper2()
		{

			



			var xe = new XElement("msubsup"
				,

						new XElement("mrow", ( "&int;"))
						,
						new XElement("mrow",lower)
						,
						new XElement("mrow",upper)

						);
			


			return xe.ToString().Replace("&amp;","&");
		}
	}
}
