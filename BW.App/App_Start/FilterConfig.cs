using BW.App.Result;
using System.Web;
using System.Web.Configuration;
using System.Web.Mvc;

namespace BW.App
{
    
    public class CustomErrorAttribute : HandleErrorAttribute
    {
        public override void OnException(ExceptionContext filterContext)
        {
            var writeLog = true;
            if (filterContext.Exception.GetType().ToString() == typeof(BWException).ToString())
                writeLog = ((BWException)filterContext.Exception).WriteLog;

            var customErrors = ((CustomErrorsSection)WebConfigurationManager.GetSection("system.web/customErrors"));

            var exResult = new ExceptionResult
            (
                filterContext.Exception.Message,
                isWriteLog: writeLog,
                controller: filterContext.Controller.ToString(),
                stackTrace: filterContext.Exception.StackTrace
            );
            if (customErrors.Mode == CustomErrorsMode.On)
            {
                exResult.ExecuteResult(filterContext);
                filterContext.RequestContext.HttpContext.Response.End();
            }
            else
            {
                base.OnException(filterContext);
            }
        }
    }
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new CustomErrorAttribute());
        }
    }
}
