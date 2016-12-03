using RWS.DAL;
using RWS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RWS.Controllers
{
    public class ProductController : Controller
    {
        //
        // GET: /Product/
        public ActionResult Index()
        {
            return View(Common.GetDataList<Product>(0));
        }

        //
        // GET: /Product/Details/5
        public ActionResult Details(int id)
        {
            return View(Common.GetDataList<Product>(id).FirstOrDefault());
        }

        //
        // GET: /Product/Create
        public ActionResult Create()
        {
            Product pro = new Product();
            pro.Supplier = new SelectList(Common.GetDataList<Supplier>(0), "SupplierId", "DisplayName");
            pro.EmptyCategory = new SelectList(Common.GetDataList<EmptyCategory>(0), "CategoryId", "CategoryCode");
            pro.Unit = new SelectList(Common.GetDataList<Unit>(0), "UomId", "UomDesc");
            return View(pro);
        }

        //
        // POST: /Product/Create
        [HttpPost]
        public ActionResult Create(Product product)
        {
            try
            {
                Product.UpdateProduct(product);

                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(String.Empty, ex.Message);
                Product pro = new Product();
                pro.Supplier = new SelectList(Common.GetDataList<Supplier>(0), "SupplierId", "DisplayName");
                pro.EmptyCategory = new SelectList(Common.GetDataList<EmptyCategory>(0), "CategoryId", "CategoryCode");
                pro.Unit = new SelectList(Common.GetDataList<Unit>(0), "UomId", "UomDesc");
                return View(pro);
            }
        }

        //
        // GET: /Product/Edit/5
        public ActionResult Edit(int id)
        {
            Product pro = new Product();
            pro = Common.GetDataList<Product>(id).FirstOrDefault();

            pro.Supplier = new SelectList(Common.GetDataList<Supplier>(0), "SupplierId", "DisplayName");
            pro.EmptyCategory = new SelectList(Common.GetDataList<EmptyCategory>(0), "CategoryId", "CategoryCode");
            pro.Unit = new SelectList(Common.GetDataList<Unit>(0), "UomId", "UomDesc");
            return View(pro);
        }

        //
        // POST: /Product/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Product product)
        {
            try
            {
                Product.UpdateProduct(product);

                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(String.Empty, ex.Message);
                Product pro = new Product();
                pro.Supplier = new SelectList(Common.GetDataList<Supplier>(0), "SupplierId", "DisplayName");
                pro.EmptyCategory = new SelectList(Common.GetDataList<EmptyCategory>(0), "CategoryId", "CategoryCode");
                pro.Unit = new SelectList(Common.GetDataList<Unit>(0), "UomId", "UomDesc");
                return View(pro);
            }
        }

        //
        // GET: /Product/Delete/5
        public ActionResult Delete(int id)
        {
            return View(Common.GetDataList<Product>(id).FirstOrDefault());
        }

        //
        // POST: /Product/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                Common.DeleteData("Product", "ProductId", id);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
