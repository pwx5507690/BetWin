using BW.App.Models;
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
        public AccountsInfoRespository _AccountsInfoRespository { get; set; }
        public AccountsCollectionRespository _AccountsCollectionRespository { get; set; }
        public SystemBankTypeRespository _SystemBankTypeRespository { get; set; }
      
        public object GetDyncProperty(string respository) {
            if (string.IsNullOrEmpty(respository))
                throw new BWException("respository is not found");

            respository = $"_{respository}Respository";
            return this.GetType().GetProperty(respository).GetValue(this);
        }
        public object Exec(string respository,string method,params object[] param) {
            var dyncProperty = GetDyncProperty(respository);
            var result = dyncProperty.GetType().GetMethod(method).Invoke(dyncProperty, param);
            return result;
        }
        [HttpGet]
        [Route("Query/{respository}")]
        public ActionResult Query(int limit, int pageIndex, string expression, string respository)
        {
            var result = Exec(respository, "Query", new object[] { limit, pageIndex, expression });
            var table = new TableResult.Table();
            Array.ForEach(result.GetType().GetProperties(), t => {
                if (t.Name == "Result")
                    table.Rows = t.GetValue(result);
                else if (t.Name == "Count")
                    table.Results = Convert.ToInt32(t.GetValue(result));
            });
            return new TableResult(table);
        }
        [HttpPost]
        [Route("option")]
        public int Option(OptionModel model)
        {
            var result = Exec(model.Respository, model.Cmd, new object[] { model.Content });
            return Convert.ToInt32(result);
        }
        [HttpGet]
        [Route("View/{viewName}")]
        public ActionResult GetView(string viewName)
        {
            return View(viewName);
        }
    }
}