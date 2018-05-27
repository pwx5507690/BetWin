using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BW.Respository;

namespace BW.App.Controllers
{
    public class HomeController : Controller
    {
        public readonly AccountsBankInfoRespository _accountsBankInfoRespository;
        public HomeController(AccountsBankInfoRespository accountsBankInfoRespository) {
            _accountsBankInfoRespository = accountsBankInfoRespository;
        }
        public ActionResult Index()
        {
            _accountsBankInfoRespository.Query();
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}