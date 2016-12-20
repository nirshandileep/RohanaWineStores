using RWS.DAL;
using RWS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RWS.Controllers
{
    public class PurchaseOrderController : Controller
    {
        //
        // GET: /PurchaseOrder/
        public ActionResult Index()
        {
            return View(Common.GetDataList<Order>(0));
        }

        //
        // GET: /PurchaseOrder/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /PurchaseOrder/Create
        public ActionResult Create()
        {
            Order ord = new Order();
            ord.OrderDate = DateTime.Now.Date;
            ord.Supplier = new SelectList(Common.GetDataList<Supplier>(0), "SupplierId", "DisplayName");
            ord.OrderDetail = Common.GetDataList<OrderDetail>(0);
            return View(ord);
        }

        //
        // POST: /PurchaseOrder/Create
        [HttpPost]
        public ActionResult Create(Order order)
        {
            try
            {
                Order.UpdateOrderHeader(order);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /PurchaseOrder/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /PurchaseOrder/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /PurchaseOrder/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /PurchaseOrder/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
