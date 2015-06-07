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
	[ToolboxData(@"<{0}:MintFull_template runat=server><template><msubsup><mrow>&int;</mrow><mrow >lower</mrow><mrow >upper</mrow></msubsup><mrow runat=server>f(x)</mrow><mrow>d<mi>x</mi></mrow></template></{0}:MintFull_template>")]
	[ParseChildren(true)]
	public class MintFull_template: WebControl,INamingContainer
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



			RenderChildren(output);

			
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
