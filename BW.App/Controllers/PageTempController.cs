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
    public class PageTempController : Controller
    {
        public AccountsBankInfoRespository _AccountsBankInfoRespository { get; set; }
        //public PageTempController(AccountsBankInfoRespository accountsBankInfoRespository)
        //{
        //    _accountsBankInfoRespository = accountsBankInfoRespository;
        //}
        public ActionResult AccountsBankInfo()
        {
            return View();
        }
        public ActionResult AccountsBankList(int limit, int pageIndex, string expression)
        {
            var obj = this.GetType().GetProperty("_AccountsBankInfoRespository").GetValue(this);
            var result = obj.GetType().GetMethod("Query").Invoke(obj, new object[] { limit, pageIndex, expression });
            var table = new TableResult.Table();
            Array.ForEach(result.GetType().GetProperties(), t => {
                if (t.Name == "Result")
                    table.Rows = t.GetValue(result);
                else if (t.Name == "Count")
                    table.Results = Convert.ToInt32(t.GetValue(result));
            });
            return new TableResult(table);
        }

        public ActionResult Index()
        {
            return View();
        }
    }
}