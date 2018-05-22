using System.Web;
using System.Web.Optimization;

namespace TenisElo.Web
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/datatables.min.js",
                      "~/Scripts/jquery.toast.min.js",
                      "~/Scripts/jquery.easy-autocomplete.min.js",
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/datatables.min.css",
                      "~/Content/jquery.toast.min.css",
                      "~/Content/easy-autocomplete.min.css",
                      "~/Content/bootstrap.css",
                      "~/Content/dashboard.css",
                      "~/Content/site.css",
                      "~/Content/player-details.css"));
        }
    }
}
