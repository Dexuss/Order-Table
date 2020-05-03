using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TableOrder.Models;
using TableOrder.Repository;

namespace TableOrder.Controllers
{
    public class OrderController : Controller
    {
        OrderRepository rep = new OrderRepository();

        public ActionResult Index()
        {
            IEnumerable<OrderModel> obj = rep.SelectAllOrders();
            return View(obj);
        }

        public ActionResult Details(string table)
        {
            IEnumerable<OrderModel> obj = rep.SelectOrderByTableName(table);
            return View(obj);
        }

        public ActionResult Create() => 
            View();

        [HttpPost]
        public ActionResult Create(OrderModel ord)
        {
            try
            {
                rep.InsertOrder(ord);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Edit(Guid id)
        {
            OrderModel obj = rep.SelectOrderById(id);
            return View(obj);
        }

        [HttpPost]
        public ActionResult Edit(OrderModel ord)
        {
            try
            {
                rep.UpdateOrder(ord);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Delete(Guid id)
        {
            OrderModel obj = rep.SelectOrderById(id);
            return View(obj);
        }

        [HttpPost]
        public ActionResult Delete(Guid id, FormCollection collection)
        {
            try
            {
                rep.DeleteOrder(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}