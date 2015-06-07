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
	[ToolboxData(@"<{0}:Power_template runat=server><template><mrow>base</mrow><mrow>exp</mrow></template></{0}:Power_template>")]
	[ParseChildren(true)]
	public class Power_template: WebControl,INamingContainer
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

			RenderChildren(output);
		}

		protected override void Render(HtmlTextWriter output)
		{


			if (DesignMode)
			{
				output.Write("msup in MathMl for Power");
				return;
			}
			RenderBeginTag(output);

			RenderContents(output);
			RenderEndTag(output);

		}

		const string enclosingTagName = "msup";


		public override void RenderBeginTag(HtmlTextWriter writer)
		{
			writer.Write("<msup>");
		}

		public override void RenderEndTag(HtmlTextWriter writer)
		{
			writer.Write("</msup>");
			//writer.RenderEndTag();
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
