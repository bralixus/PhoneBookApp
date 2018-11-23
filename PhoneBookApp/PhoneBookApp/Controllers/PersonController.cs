using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PhoneBookApp.Models;

namespace PhoneBookApp.Controllers
{
    public class PersonController : Controller
    {
        [HttpGet]
        public ActionResult Index(string search = "", int page = 1)
        {
            ViewBag.page = page;
            return View(SourceManager.Get(search, page));
        }

        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(PersonModel personModel)
        {
            if (ModelState.IsValid)
            {
                SourceManager.Add(personModel);
                return RedirectToAction("Index");
            }

            return View();
        }

        [HttpGet]
        public ActionResult Remove(int ID)
        {
            return View(SourceManager.GetById(ID));
        }

        [HttpPost]
        public ActionResult RemoveConfirm(int ID)
        {
            SourceManager.Remove(ID);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(int ID)
        {
            return View(SourceManager.GetById(ID));
        }

        [HttpPost]
        public ActionResult Edit(PersonModel personModel)
        {
            if (ModelState.IsValid)
            {
                SourceManager.Edit(personModel);
                return RedirectToAction("Index");
            }
            return View();
        }


    }
}