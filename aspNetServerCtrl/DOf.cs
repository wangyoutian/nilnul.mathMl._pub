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

namespace nilnul.mathMl._ctr
{

	[ToolboxData(
@"<{0}:DOf runat=""server""> 
	<%--element--%>
	
</{0}:DOf>")]
	[ParseChildren(false)]	//don't parse, so they are left as is, i.e., controls.
	public class DOf : WebControl
	{




		protected override void Render(HtmlTextWriter output)
		{
			new DifferentialMo().RenderControl(output);
			new ApplyFunctionMo().RenderControl(output);
			RenderChildren(output);

		}






	}
}
