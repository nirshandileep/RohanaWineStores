using RWS.DAL;
using RWS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RWS.Controllers
{
    public class ExpenseTypeController : Controller
    {
        //
        // GET: /ExpenseType/
        public ActionResult Index()
        {
            return View(Common.GetDataList<ExpenseType>(0));
        }

        //
        // GET: /ExpenseType/Details/5
        public ActionResult Details(int id)
        {
            return View(Common.GetDataList<ExpenseType>(id).FirstOrDefault());
        }

        //
        // GET: /ExpenseType/Create
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /ExpenseType/Create
        [HttpPost]
        public ActionResult Create(ExpenseType expenseType)
        {
            try
            {
                ExpenseType.UpdateExpenseType(expenseType);

                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(String.Empty, ex.Message);
                return View();
            }
        }

        //
        // GET: /ExpenseType/Edit/5
        public ActionResult Edit(int id)
        {
            return View(Common.GetDataList<ExpenseType>(id).FirstOrDefault());
        }

        //
        // POST: /ExpenseType/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, ExpenseType expenseType)
        {
            try
            {
                ExpenseType.UpdateExpenseType(expenseType);

                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(String.Empty, ex.Message);
                return View();
            }
        }

        //
        // GET: /ExpenseType/Delete/5
        public ActionResult Delete(int id)
        {
            return View(Common.GetDataList<ExpenseType>(id).FirstOrDefault());
        }

        //
        // POST: /ExpenseType/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                Common.DeleteData("ExpenseType", "ExpenseTypeId", id);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
