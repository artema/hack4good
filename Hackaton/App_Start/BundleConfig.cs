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
            AngularJS,
            Styles,
            Scripts
        }


        public static string GetBundlePath(Bundles bundle)
        {
            return string.Format("~/bundles/{0}", bundle.ToString());
        }


        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(GetJQueryBundle());
            bundles.Add(GetAngularBundle());
            bundles.Add(GetBootstrapScriptBundle());
            bundles.Add(GetBootstrapCSSBundle());
            bundles.Add(GetBootstrapThemeBundle());
            bundles.Add(GetStylesBundle());
            bundles.Add(GetScriptsBundle());

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
                "~/Content/Bootstrap/site.css",
                "~/Content/normalize.css"
            );

            return bundle;
        }

        private static Bundle GetStylesBundle()
        {
            var bundle = new Bundle(GetBundlePath(Bundles.Styles));

            bundle.Include(
                "~/Content/Styles/main.css"
            );

            return bundle;
        }

        private static Bundle GetScriptsBundle()
        {
            var bundle = new Bundle(GetBundlePath(Bundles.Scripts));

            bundle.Include(
                "~/Content/Scripts/App/main.js"
            );

            return bundle;
        }

        private static Bundle GetBootstrapThemeBundle()
        {
            var bundle = new StyleBundle(GetBundlePath(Bundles.BootstrapTheme));

            bundle.Include("~/Content/Bootstrap/bootstrap-theme.css");

            return bundle;
        }

        private static Bundle GetAngularBundle()
        {
            var bundle = new ScriptBundle(GetBundlePath(Bundles.AngularJS));

            bundle.Include(
                "~/Scripts/angular.min.js",
                "~/Scripts/angular-resource.min.js",
                "~/Scripts/angular-route.min.js",
                "~/Scripts/angular-animate.min.js",
                "~/Scripts/angular-loader.min.js",
                "~/Scripts/angular-touch.min.js"
            );

            return bundle;
        }

        #endregion



    }
}