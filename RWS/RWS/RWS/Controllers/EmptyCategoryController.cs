using RWS.DAL;
using RWS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RWS.Controllers
{
    public class EmptyCategoryController : Controller
    {
        //
        // GET: /EmptyCategory/
        public ActionResult Index()
        {
            return View(Common.GetDataList<EmptyCategory>(0));
        }

        //
        // GET: /EmptyCategory/Details/5
        public ActionResult Details(int id)
        {
            return View(Common.GetDataList<EmptyCategory>(id).FirstOrDefault());
        }

        //
        // GET: /EmptyCategory/Create
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /EmptyCategory/Create
        [HttpPost]
        public ActionResult Create(EmptyCategory emptyCategory)
        {
            try
            {
                EmptyCategory.UpdateEmptyCategory(emptyCategory);

                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(String.Empty, ex.Message);
                return View();
            }
        }

        //
        // GET: /EmptyCategory/Edit/5
        public ActionResult Edit(int id)
        {
            return View(Common.GetDataList<EmptyCategory>(id).FirstOrDefault());
        }

        //
        // POST: /EmptyCategory/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, EmptyCategory emptyCategory)
        {
            try
            {
                EmptyCategory.UpdateEmptyCategory(emptyCategory);

                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(String.Empty, ex.Message);
                return View();
            }
        }

        //
        // GET: /EmptyCategory/Delete/5
        public ActionResult Delete(int id)
        {
            return View(Common.GetDataList<EmptyCategory>(id).FirstOrDefault());
        }

        //
        // POST: /EmptyCategory/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                Common.DeleteData("EmptyCategory", "CategoryId", id);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
