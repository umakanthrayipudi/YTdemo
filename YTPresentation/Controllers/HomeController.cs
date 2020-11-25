using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YTPresentation.Models;
using YTDAL;
namespace YTPresentation.Controllers
{
    public class HomeController : Controller
    {
        //public ActionResult Index()
        //{
        //    return View();
        //}

        //public ActionResult About()
        //{
        //    ViewBag.Message = "Your application description page.";

        //    return View();
        //}

        //public ActionResult Contact()
        //{
        //    ViewBag.Message = "Your contact page.";

        //    return View();
        //}
        Repository repo = new Repository();
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(ytmodel obj)
        {
            yt obj2 =  new yt();
            obj2.name = obj.name;
            obj2.roll = obj.roll;
            bool result = repo.Login(obj2);
            if (result)
            {
                Session["login"] = "successfull";
            }
            else
            {
                Session["login"] = "unsuccessfull";
            }
            return View();
        }
    }
}