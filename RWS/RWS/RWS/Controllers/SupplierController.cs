using RWS.DAL;
using RWS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RWS.Controllers
{
    public class SupplierController : Controller
    {
        //
        // GET: /Supplier/
        public ActionResult Index()
        {
            return View(Common.GetDataList<Supplier>(0));
        }

        //
        // GET: /Supplier/Details/5
        public ActionResult Details(int id)
        {
            return View(Common.GetDataList<Supplier>(id).FirstOrDefault());
        }

        //
        // GET: /Supplier/Create
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Supplier/Create
        [HttpPost]
        public ActionResult Create(Supplier supplier)
        {
            try
            {
                Supplier.UpdateSupplier(supplier);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Supplier/Edit/5
        public ActionResult Edit(int id)
        {
            return View(Common.GetDataList<Supplier>(id).FirstOrDefault());
        }

        //
        // POST: /Supplier/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Supplier supplier)
        {
            try
            {
                Supplier.UpdateSupplier(supplier);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Supplier/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Supplier/Delete/5
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
