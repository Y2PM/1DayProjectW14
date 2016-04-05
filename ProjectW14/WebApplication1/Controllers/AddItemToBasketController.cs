﻿using ADOClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Web;
using System.Web.Mvc;
using WCFServiceCL;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class AddItemToBasketController : Controller
    {
        public static List<Product> productList = new List<Product>();

        static EndpointAddress endpoint = new EndpointAddress("http://trnlon11566:8081/Service");
        IServe proxy = ChannelFactory<IServe>.CreateChannel(new BasicHttpBinding(), endpoint);


        // GET: AddItemToBasket
        public ActionResult AddToBasket(string code)
        {
            if (Request.IsAjaxRequest())
            {
                return ShowDetails(code);
            }

            List<Item> itemList = proxy.GetItemsFromDB();

            foreach (Item item in itemList)
            {
                productList.Add(new Product {  id=item.Id, name=item.ItemName, price=item.ItemPrice });//Get items from DB ready to use in asp.

            }

            ViewBag.Message = "Your AddToBasket page.";

            return View();
        }

        public PartialViewResult ShowDetails(string code)
        {
            Product product = new Product();

            foreach (Product p in productList)
            {
                if (p.id == Int32.Parse(code))
                {
                    product = p;
                    break;
                }
            }
            return PartialView("PartialView1", product);
        }
    }
}