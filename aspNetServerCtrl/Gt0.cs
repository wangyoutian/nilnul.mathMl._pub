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
	[ToolboxData("<{0}:Gt0 runat=server />")]
	[Designer(typeof(CompositeControlDesigner))]

	public class Gt0 : CompositeControl
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
			this.Controls.Add(new MoGt());

		
			this.Controls.Add(new Mn0());

			base.CreateChildControls();
		}


	}
}
