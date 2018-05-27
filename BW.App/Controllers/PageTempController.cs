using BW.App.Result;
using BW.Enitiy;
using BW.Respository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BW.App.Controllers
{
    [RoutePrefix("Page")]
    public class PageTempController : Controller
    {        
        public AccountsBankInfoRespository _AccountsBankInfoRespository { get; set; }

        public object GetDyncProperty(string respository) {
            if (string.IsNullOrEmpty(respository))
                throw new BWException("respository IsNullOrEmpty");

            respository = $"_{respository}Respository";
            return this.GetType().GetProperty(respository).GetValue(this);
        }
        [HttpGet]
        [Route("Query/{respository}")]
        public ActionResult Query(int limit, int pageIndex, string expression, string respository)
        {
            var dyncProperty = GetDyncProperty(respository);
            var result = dyncProperty.GetType().GetMethod("Query").Invoke(dyncProperty, new object[] { limit, pageIndex, expression });
            var table = new TableResult.Table();
            Array.ForEach(result.GetType().GetProperties(), t => {
                if (t.Name == "Result")
                    table.Rows = t.GetValue(result);
                else if (t.Name == "Count")
                    table.Results = Convert.ToInt32(t.GetValue(result));
            });
            return new TableResult(table);
        }
        [HttpGet]
        [Route("View/{viewName}")]
        public ActionResult GetView(string viewName)
        {
            return View(viewName);
        }
    }
}