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
                      "~/Assets/Js/jquery-1.8.1.min.js",
                      "~/Assets/Js/underscore.js",
                      "~/Assets/Js/bui.js",
                      "~/Assets/Js/config.js"));

            bundles.Add(new StyleBundle("~/betWin/css").Include(
                      "~/Assets/Css/dpl-min.css",
                      "~/Assets/Css/bui-min.css",
                      "~/Assets/Css/main-min.css"));
        }
    }
}
