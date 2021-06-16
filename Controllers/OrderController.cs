using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OrderManager.Models;

namespace OrderManager.Controllers
{
    public class OrderController : Controller
    {
        private static List<OrderModel> orders = new List<OrderModel>() {
            new OrderModel(){ OrderId = 1, Content = "1x laptop dla mikj", Comments = "", Company = CompanyEnum.Ail, Purchaser = "Michał" , DateAdd=DateTime.Now}
        };

        public ActionResult Index()
        {
            return View(orders);
        }

        public ActionResult Details(int id)
        {
            return View(orders.Find(i=>i.OrderId == id));
        }

        public ActionResult Create()
        {
            return View(new OrderModel());
        }

        [HttpPost]
        public ActionResult Create(OrderModel orderModel)
        {
            orderModel.OrderId = orders.Count + 1;
            orderModel.DateAdd = DateTime.Now;
            orders.Add(orderModel);
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            //return JavaScript(alert("Hello this is an alert"));
            return View(orders.Find(i=>i.OrderId == id));
        }

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            return View(orders.Find(i => i.OrderId == id));
        }

        [HttpPost]
        public ActionResult Delete(int id, OrderModel orderModel)
        {
            OrderModel order = orders.Find(i => i.OrderId == id);
            orders.Remove(order);
            return RedirectToAction("Index");
        }
    }
}
