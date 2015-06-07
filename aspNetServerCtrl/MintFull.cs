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
	[ToolboxData("<{0}:MintFull runat=server lower=0 upper=1><template></template></{0}:MintFull>")]
	[ParseChildren(true)]
	public class MintFull: WebControl,INamingContainer
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

	

		const string upperPropertyName = "upper";
		const string lowerPropertyName = "lower";
		const string dvarPropertyName = "dvar";


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

		[Bindable(true)]
		[Category("Appearance")]
		[DefaultValue("")]
		[Localizable(true)]
		public string dvar
		{
			get
			{
				String s = (String)ViewState[dvarPropertyName];
				return ((s == null) ? "x" : s);
			}

			set
			{
				ViewState[dvarPropertyName] = value;
			}
		}






		protected override void RenderContents(HtmlTextWriter output)
		{

			output.Write(xmlWrapper2());
		}

		protected override void Render(HtmlTextWriter output)
		{


			RenderContents(output);

			RenderChildren(output);

			output.Write("d"+dvar);
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

		[ToolboxItem(false)]
		public class Item : Control, INamingContainer
		{
			private String _message = null;


			public Item()
			{
			}
					

			public Item(String message)
			{
				_message = message;
			}

			public String Message
			{

				get
				{
					return _message;
				}
				set
				{
					_message = value;
				}
			}
		


		}

	
	}
}
