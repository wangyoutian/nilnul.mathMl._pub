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
	[ToolboxData("<{0}:Frac_nullBoxTemplate runat=server><template><mfrac><mrow><mn>numerator</mn></mrow><mrow>denominator</mrow></mfrac></template></{0}:Frac_nullBoxTemplate>")]
	[ParseChildren(true)]
	public class Frac_nullBoxTemplate: WebControl,INamingContainer
	{

		private ITemplate _template = null;

		[
		PersistenceMode(PersistenceMode.InnerProperty),
		TemplateContainer(typeof(Item))
	]
		///the following is not tested.
		[TemplateInstance(TemplateInstance.Single)]

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
			RenderChildren(output);
			
		}

		
		protected override void RenderChildren(HtmlTextWriter writer)
		{

			base.RenderChildren(writer);
		}


		protected override void Render(HtmlTextWriter output)
		{

			//output.Write("<msubsup>");
			//output.Write("<mrow>&int;</mrow>");

			//Controls[0].RenderControl(output);
			//Controls[1].RenderControl(output);

			//output.Write("</msubsup>");
		


			//Controls[2].RenderControl(output);

			//output.Write("d");
			//Controls[3].RenderControl(output);

			RenderContents(output);

			//RenderChildren(output);

			
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
