using System.Web;
using System.Web.Optimization;

namespace BW.App
{
    public class BundleConfig
    {
        // 有关捆绑的详细信息，请访问 https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/betWin/bootstrap").Include(
                      "~/assets/js/jquery-1.8.1.min.js",
                      "~/assets/js/underscore.js",
                      "~/assets/js/bui.js",
                      "~/assets/js/config.js"));

            bundles.Add(new StyleBundle("~/betWin/css").Include(
                      "~/assets/css/dpl-min.css",
                      "~/assets/css/bui-min.css",
                      "~/assets/css/main-min.css"));
        }
    }
}
