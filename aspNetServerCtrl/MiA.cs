﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace nilnul.mathMl._ctr
{
	[ToolboxData(@"<{0}:MiA runat=""server"" />")]
	public class MiA : WebControl
	{

		protected override void Render(HtmlTextWriter output)
		{
			output.RenderBeginTag("mi");
			output.Write("A");
			output.RenderEndTag();
		}


	}
}
