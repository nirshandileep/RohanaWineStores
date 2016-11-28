using RWS.DAL;
using RWS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RWS.Controllers
{
    public class BankAccountController : Controller
    {
        //
        // GET: /BankAccount/
        public ActionResult Index()
        {
            return View(Common.GetDataList<BankAccount>(0));
        }

        //
        // GET: /BankAccount/Details/5
        public ActionResult Details(int id)
        {
            return View(Common.GetDataList<BankAccount>(id).FirstOrDefault());
        }

        //
        // GET: /BankAccount/Create
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /BankAccount/Create
        [HttpPost]
        public ActionResult Create(BankAccount bankAccount)
        {
            try
            {
                BankAccount.UpdateBankAccount(bankAccount);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /BankAccount/Edit/5
        public ActionResult Edit(int id)
        {
            return View(Common.GetDataList<BankAccount>(id).FirstOrDefault());
        }

        //
        // POST: /BankAccount/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, BankAccount bankAccount)
        {
            try
            {
                BankAccount.UpdateBankAccount(bankAccount);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /BankAccount/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /BankAccount/Delete/5
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
