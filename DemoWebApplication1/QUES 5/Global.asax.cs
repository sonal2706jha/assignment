using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace QUES_5
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            Application["Total Application"] = 0;
            Application["Total UserSession"] = 0;
            Application["Total Application"] =(int) Application["Total Application"] + 1;
        }
        void Application_End(object sender, EventArgs e)
        {

        }
         void Application_Error(object sender, EventArgs e)
        {

        }
        void Session_Start(object sender, EventArgs e)
        {
            Application["Total UserSession"] = (int)Application["Total UserSession"] + 1;
        }
        void Session_End(object sender, EventArgs e)
        {
            Application["Total UserSession"] = (int)Application["Total UserSession"] - 1;
        }
    }
}