using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InternetShop.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Products()
        {
            ViewBag.Message = "Список продуктов";

            using (var context = new Context())
            {
                ViewBag.Products = context.Products.ToList();
            }

            return View();
        }

    }
}