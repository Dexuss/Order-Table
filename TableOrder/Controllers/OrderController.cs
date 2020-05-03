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
        //
        // GET: /Order/
        public ActionResult Index()
        {
            IEnumerable<OrderModel> obj = rep.SelectAllOrders();
            return View(obj);
        }

        //
        // GET: /Order/Details/5
        public ActionResult Details(string table)
        {
            IEnumerable<OrderModel> obj = rep.SelectOrderByTableName(table);
            return View(obj);
        }

        //
        // GET: /Order/Create
        public ActionResult Create()
        {
            return View();
        }

        /*public ActionResult CreateByTable(string table)
        {
            return View(table);
        }*/

        //
        // POST: /Order/Create
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

        //
        // GET: /Order/Edit/5
        public ActionResult Edit(Guid id)
        {
            OrderModel obj = rep.SelectOrderById(id);
            return View(obj);
        }

        //
        // POST: /Order/Edit/5
        [HttpPost]
        public ActionResult Edit(Guid id, OrderModel ord)
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

        //
        // GET: /Order/Delete/5
        public ActionResult Delete(Guid id)
        {
            OrderModel obj = rep.SelectOrderById(id);
            return View(obj);
        }

        //
        // POST: /Order/Delete/5
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