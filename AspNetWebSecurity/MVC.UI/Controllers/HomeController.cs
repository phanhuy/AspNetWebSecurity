using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.UI.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

		[HttpPost]
		public ActionResult Page(int nextPage)
		{
			int page = nextPage / nextPage +1;


			return View();
		}

		[HttpGet]
		public ActionResult PageGet(int nextPage)
		{
			int page = nextPage / nextPage + 1;


			return View();
		}
    }
}