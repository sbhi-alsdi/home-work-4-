using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace الوظيفة_المحاضرة_الرابعة_الطلب_الثاني
{
    public partial class session : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Btn_login_Click(object sender, EventArgs e)
        {
            Session["email"] = TextBox_email.Text;
            TextBox_email.Text = "";
            TextBox_password.Text = "";
            Label1.Text="this email is stored to the session";
            Label2.Text = Session["email"].ToString();

        }
    }
}