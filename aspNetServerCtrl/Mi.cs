﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;
using System.Xml;

namespace nilnul.mathMl._ctr
{

	[ToolboxData(@"<{0}:Mi runat=""server"">
	<%--content--%>
	
</{0}:Mi>")]
	[ParseChildren(false)]	//don't parse, so they are left as is, i.e., controls.
	public class Mi : WebControl
	{

		public const string tag = "mi";



		protected override void Render(HtmlTextWriter output)
		{
			output.RenderBeginTag(tag);


			RenderChildren(output);

			output.RenderEndTag();

		}






	}
}
