using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using BLL;
using Newtonsoft.Json;

namespace HappyLibraryMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
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

        public ActionResult Deletar(int authorId)
        {
            HttpClient client = MVCUtil.GetClient("");
            client.DeleteAsync($"api/Authors?authorId={authorId}");

            return RedirectToAction("Index", "Authors");
        }
    }
}