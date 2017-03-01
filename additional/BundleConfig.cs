using System.Web;
using System.Web.Optimization;

namespace BT.TS360.CMS.Project
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                     "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));            

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css"));
            bundles.Add(new StyleBundle("~/Content/css").Include(
                   "~/Content/bootstrap.css",
                     "~/Content/site.css"));
            /// For file upload starts
            bundles.Add(new ScriptBundle("~/bundles/dropzonescripts").Include(
                   "~/Scripts/dropzone/dropzone.min.js"));

            bundles.Add(new StyleBundle("~/Content/dropzonescss").Include(
                     "~/Scripts/dropzone/css/basic.css",
                     "~/Scripts/dropzone/css/dropzone.css"));
            /// for file upload ends

            bundles.Add(new ScriptBundle("~/Scripts/perfect-scrollbar").Include(
                      "~/Scripts/perfect-scrollbar/perfect-scrollbar.min.js"));
            bundles.Add(new StyleBundle("~/Content/perfect-scrollbar").Include(
                      "~/Scripts/perfect-scrollbar/perfect-scrollbar.min.css"));

            bundles.Add(new ScriptBundle("~/Scripts/additional").Include(
                      "~/Scripts/additional.js"));

            bundles.Add(new StyleBundle("~/Content/fontawesome").Include(
                      "~/Content/fontawesome/font-awesome.min.css"));
        }
    }
}




