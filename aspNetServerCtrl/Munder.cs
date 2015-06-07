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

	[ToolboxData(@"<{0}:Munder runat=""server"">
  <munder>
	<mo>&Sigma;</mo>
	<mrow>
		<mi>x</mi>
		<mo>=</mo>
	</mrow>
  </munder>
 		</{0}:Munder>")]
	[ParseChildren(false)]	//don't parse, so they are left as is, i.e., controls.
	public class Munder: NoWrapperA
	{




	}
}
