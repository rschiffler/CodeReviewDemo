using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CodeReviewDemo.Models;

namespace CodeReviewDemo.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View(new Home { Message = new Content().Get() });
        }
    }

    public class Content
    {
        public string Get()
        {
            return "Test change";
        }
    }
}