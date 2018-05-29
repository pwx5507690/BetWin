using BW.App.Models;
using BW.App.Result;
using BW.Infrastructure;
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
    public partial class PageTempController : Controller
    {
        private readonly IDictionary<string, string> _expressionRule = new Dictionary<string, string>()
        {
            {"_not_","<>"},
            {"_notnull_","is not null"}
        };
        public string ResolveExpression(string key, string value)
        {
            var defaultRule = "=";
            foreach (var item in _expressionRule)
            {
                if (value.Contains(item.Key))
                {
                    defaultRule = item.Value;
                    value.Replace(item.Key, string.Empty);
                    break;
                }
            }
            return $"{key} {defaultRule} {value}";
        }
        public string ResolveExpression(string expression)
        {
            if (string.IsNullOrEmpty(expression))
                return null;
            expression = HttpUtility.UrlDecode(expression);
            return expression.DeserializeObject<IDictionary<string, string>>()
               .Select(t => ResolveExpression(t.Key, t.Value)).JoinString(" and ");
        }
        public object GetDyncProperty(string respository)
        {
            if (string.IsNullOrEmpty(respository))
                throw new BWException("respository is not found");

            respository = $"_{respository}Respository";
            return this.GetType().GetProperty(respository).GetValue(this);
        }
        public object Exec(string respository, string method, params object[] param)
        {
            var dyncProperty = GetDyncProperty(respository);
            var result = dyncProperty.GetType().GetMethod(method).Invoke(dyncProperty, param);
            return result;
        }
        [HttpGet]
        [Route("Query/{respository}")]
        public ActionResult Query(int limit, int pageIndex, string expression, string respository)
        {
            expression = ResolveExpression(expression) ?? string.Empty;
            var result = Exec(respository, "Query", new object[] { limit, pageIndex, expression });
            var table = new TableResult.Table();
            Array.ForEach(result.GetType().GetProperties(), t =>
            {
                if (t.Name == "Result")
                    table.Rows = t.GetValue(result);
                else if (t.Name == "Count")
                    table.Results = Convert.ToInt32(t.GetValue(result));
            });
            return new TableResult(table);
        }
        [HttpGet]
        [Route("QueryExist/{respository}")]
        public string QueryExist(string expression, string respository)
        {
            expression = ResolveExpression(expression) ?? string.Empty;
            var result = Exec(respository, "QueryExist", new object[] { expression });
            return result.ToString();
        }
        [HttpGet]
        [Route("QueryExpression/{respository}")]
        public ActionResult QueryExpression(string expression, string respository)
        {
            expression = ResolveExpression(expression) ?? string.Empty;
            var result = Exec(respository, "QueryExpression", new object[] { expression });
            return new JsonNetResult()
            {
                Data = result
            };
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
    public partial class PageTempController
    {
        public AccountsBankInfoRespository _AccountsBankInfoRespository { get; set; }
        public AccountsInfoRespository _AccountsInfoRespository { get; set; }
        public AccountsCollectionRespository _AccountsCollectionRespository { get; set; }
        public SystemBankTypeRespository _SystemBankTypeRespository { get; set; }
    }
}