﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace الوظيفة_المحاضرة_الرابعة_الطلب_الثاني
{
    public partial class hidden_field : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HiddenField1.Value = DateTime.Now.ToString();
            Label1.Text = HiddenField1.Value;
        }
    }
}