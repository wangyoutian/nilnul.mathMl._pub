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
	//[DefaultProperty("Text")]
	[ToolboxData("<{0}:Math runat=server overflow=linebreak><template></template></{0}:Math>")]
	[ParseChildren(true)]
	public class Math: WebControl,INamingContainer
	{

		private ITemplate _template = null;

		[
		PersistenceMode(PersistenceMode.InnerProperty),
		TemplateContainer(typeof(Item))
	]
		public ITemplate template
		{
			get
			{
				return _template;
			}
			set
			{
				_template = value;
			}
		}

		const string overflowPropertyName = "overflow";

		[Bindable(true)]
		[Category("Appearance")]
		[DefaultValue("linebreak")]
		[Localizable(true)]
		public string overflow
		{
			get
			{
				String s = (String)ViewState[overflowPropertyName];
				return ((s == null) ? "" : s);
			}

			set
			{
				ViewState[overflowPropertyName] = value;
			}
		}

		public override ControlCollection Controls
		{
			get
			{
				this.EnsureChildControls();
				return base.Controls;
			}
		}


		protected override void CreateChildControls()
		{

			// If a template has been specified, use it to create children.
			// Otherwise, create a single LiteralControl with the message value.

			if (template != null)
			{
				Controls.Clear();
				var i = new Item();
				template.InstantiateIn(i);
				Controls.Add(i);
				//Controls.Add(new LiteralControl("----------"));
			}

			//else
			//{
			//	this.Controls.Add(new LiteralControl(this.Message));
			//}
		}




		protected override void RenderContents(HtmlTextWriter output)
		{

			//output.Write(xmlWrapper2());

			RenderChildren(output);
		}

		public override void RenderBeginTag(HtmlTextWriter writer)
		{
			if (!String.IsNullOrWhiteSpace(overflow))
			{
				writer.Write("<math overflow=\"linebreak\">");
				return;
				
			}
			writer.Write("<math>");
		}

		public override void RenderEndTag(HtmlTextWriter writer)
		{

			writer.Write("</math>");
			//writer.RenderEndTag();
		}



		protected override void Render(HtmlTextWriter output)
		{
			if (DesignMode)
			{
				output.Write("MathML");
				return;
			}
			RenderBeginTag(output);

			RenderContents(output);
			RenderEndTag(output);

		


		}






		private string xmlWrapper2()
		{

			



			var xe = new XElement("math"
				,

					""

						);
			


			return xe.ToString();
		}

		[ToolboxItem(false)]
		public class Item : Control, INamingContainer
		{
	

			public Item()
			{
			}
					

		


		}

	
	}
}
