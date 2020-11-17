using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace الوظيفة_المحاضرة_الرابعة_الطلب_الثاني
{
    public partial class query_string : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button_sub_Click(object sender, EventArgs e)
        {
            Response.Redirect("query_string2.aspx?firestname=" + TextBox1.Text+"lastname="+TextBox2.Text);
            
        }
    }
}