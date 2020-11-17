using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace الوظيفة_المحاضرة_الرابعة_الطلب_الثاني.الوظيفة_المحاضرة_الثالثة
{
    public partial class المحاضرة_الثالثة_وظيفة_الطلب_الثاني : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_move_Click(object sender, EventArgs e)
        {
            TextBox2.Text = TextBox1.Text;
            TextBox1.Text = null;

        }
    }
}