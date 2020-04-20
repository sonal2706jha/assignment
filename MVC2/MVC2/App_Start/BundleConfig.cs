using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace MVC2.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/bundles/bootstrap").Include(
                                                              "~/Content/bootstrap.css"
                                                          ));
            BundleTable.EnableOptimizations = true;
        }
    }
}