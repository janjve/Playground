using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Optimization;

namespace TfsAdministrationTool_Web
{
    // TODO: This should be replaced by grunt bundle + minification for consistensy - Remember to remove web.optimization reference
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/bundles/app_style")
                .Include("~/Content/Site.css")
                );

            bundles.Add(new ScriptBundle("~/bundles/app_script")
                .Include("~/wwwroot/app/app.module.js") // Should load first.
                .IncludeDirectory("~/wwwroot/app", "*.js", true)
                );


            bundles.Add(new StyleBundle("~/bundles/bower_style")
                .Include("~/temp/_bower.css")
                );

            bundles.Add(new ScriptBundle("~/bundles/bower_script")
                .Include("~/temp/_bower.js")
                );
        }
    }
}
