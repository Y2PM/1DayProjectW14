using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class AddItemToBasketController : Controller
    {
        // GET: AddItemToBasket
        public ActionResult AddToBasket()
        {
            ViewBag.Message = "Your AddToBasket page.";

            return View();
        }
    }
}