using System.Web.Optimization;

namespace Hackaton
{
    public class BundleConfig
    {
        public enum Bundles
        {
            JQuery,
            BootstrapScript,
            BootstrapCSS,
            BootstrapTheme,
        }


        public static string GetBundlePath(Bundles bundle)
        {
            return string.Format("~/bundles/{0}", bundle.ToString());
        }


        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(GetJQueryBundle());
            bundles.Add(GetBootstrapScriptBundle());
            bundles.Add(GetBootstrapCSSBundle());
            bundles.Add(GetBootstrapThemeBundle());

            BundleTable.EnableOptimizations = true;
        }



        #region bundles

        private static Bundle GetJQueryBundle()
        {
            var bundle = new ScriptBundle(GetBundlePath(Bundles.JQuery));

            bundle.Include(
                "~/Content/Scripts/jquery-{version}.js",
                "~/Content/Scripts/jquery.validate.js",
                "~/Content/Scripts/jquery.validate.unobtrusive.js"
            );

            return bundle;
        }


        private static Bundle GetBootstrapScriptBundle()
        {
            var bundle = new ScriptBundle(GetBundlePath(Bundles.BootstrapScript));

            bundle.Include(
                "~/Content/Scripts/bootstrap.js"
            );

            return bundle;
        }


        private static Bundle GetBootstrapCSSBundle()
        {
            var bundle = new StyleBundle(GetBundlePath(Bundles.BootstrapCSS));

            bundle.Include(
                "~/Content/Bootstrap/bootstrap.css",
                "~/Content/Bootstrap/site.css"
            );

            return bundle;
        }


        private static Bundle GetBootstrapThemeBundle()
        {
            var bundle = new StyleBundle(GetBundlePath(Bundles.BootstrapTheme));

            bundle.Include("~/Content/Bootstrap/bootstrap-theme.css");

            return bundle;
        }

        #endregion



    }
}