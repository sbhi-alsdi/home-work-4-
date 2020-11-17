using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace الوظيفة_المحاضرة_الرابعة_الطلب_الثاني
{
    public partial class query_string2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string name = Request.QueryString.Get("firestname");
            string lastname = Request.QueryString.Get("lastname");
            Label1.Text = "hello" + name +""+ lastname; 
            
        }
    }
}