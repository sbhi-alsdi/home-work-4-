using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using الوظيفة_المحاضرة_الرابعة_الطلب_الثاني;

namespace الوظيفة_المحاضرة_الرابعة_الطلب_الثاني
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            AuthConfig.RegisterOpenAuth();
            Application["User"] = 0;
              Application.Lock();
            Application["user"] = (int)Application["user"] + 1;
            Application.UnLock();  
        }

        void Application_End(object sender, EventArgs e)
        {
         
            //  Code that runs on application shutdown

        }

        void Application_Error(object sender, EventArgs e)
        {
            // Code that runs when an unhandled error occurs

        }
    }
}
