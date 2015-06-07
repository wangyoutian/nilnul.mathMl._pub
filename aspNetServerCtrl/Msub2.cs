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

	[ToolboxData(@"<{0}:Msub2 runat=""server"">
  <msub>
	<mi>a</mi>
	<mn>1</mn>
  </msub>
 		</{0}:Msub2>")]
	[ParseChildren(false)]	//don't parse, so they are left as is, i.e., controls.
	public class Msub2: NoWrapperA
	{




	}
}
