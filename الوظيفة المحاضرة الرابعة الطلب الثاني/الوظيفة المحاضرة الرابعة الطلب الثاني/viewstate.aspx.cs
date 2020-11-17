using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace الوظيفة_المحاضرة_الرابعة_الطلب_الثاني
{
    public partial class viewstate : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button_sub_Click(object sender, EventArgs e)
        {
            ViewState["name"] = TextBox1.Text;
            ViewState["password"] = TextBox2.Text;
            TextBox1.Text = TextBox2.Text = "";

        }

        protected void Button_restor_Click(object sender, EventArgs e)
        {
            TextBox1.Text = ViewState["name"].ToString();
            TextBox2.Text = ViewState["password"].ToString();
            

        }
    }
}