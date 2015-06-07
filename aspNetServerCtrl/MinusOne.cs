using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.Design.WebControls;

namespace nilnul.mathMl._ctr
{
	[ToolboxData(@"<{0}:MinusOne runat=""server""/>")]
	[Designer(typeof(CompositeControlDesigner))]
	[ParseChildren(false)]	//don't parse, so they are left as is, i.e., controls.

	public class MinusOne : CompositeControl
	{
		public override void RenderBeginTag(HtmlTextWriter text)
		{

		}

		public override void RenderEndTag(HtmlTextWriter theWriter)
		{

		}
		protected override void CreateChildControls()
		{
			;
			this.Controls.Add(new MoMinus());

		
			this.Controls.Add(new Mn1());

			base.CreateChildControls();
		}


	}
}
