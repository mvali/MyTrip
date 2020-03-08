using System.Web;
using System.Web.Optimization;

namespace MyTrip
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            //bundles.Add(new ScriptBundle("~/bundles/jquery").Include("~/Assets/Scripts/jquery.{version}.js"));
            bundles.Add(new ScriptBundle("~/bundles/js").Include(
                "~/Assets/Scripts/jquery-1.11.1.min.js",//
                "~/Assets/Scripts/bootstrap.js",//
                "~/Assets/Scripts/main.js",
                "~/Assets/Scripts/SmoothScroll.min.js",
                "~/Assets/Scripts/jarallax.js"
                ));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                "~/Assets/Scripts/jquery.validate*",
                "~/Assets/Scripts/jquery.unobtrusive-ajax.min.js"
                ));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            //bundles.Add(new ScriptBundle("~/bundles/modernizr").Include("~/Scripts/modernizr-*"));


            //bundles.Add(new StyleBundle("~/bundles/css").IncludeDirectory("~/Assets/Css", "*.css"));
            bundles.Add(new StyleBundle("~/bundles/css").Include(
                "~/Assets/Css/bootstrap.css",
                "~/Assets/Css/style.css",
                "~/Assets/Css/ken-burns.css",
                "~/Assets/Css/font-awesome.css"));
        }
    }
}
