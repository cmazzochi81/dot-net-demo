using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TheCorridorGroupMd.Models;

namespace TheCorridorGroupMd.Controllers
{
    public class PotentialClientsController : Controller
    {
        // GET: PotentialClient
        public ActionResult Index()
        {
            return View();
        }

        // GET: PotentialClients/Details/5
        public ActionResult Details()
        {
            var potentialClients = new PotentialClients
            {
                FirstName = "Chris",
                LastName = "Tester",
                //PhoneNumber = "804.300.9787",
                Email = "cmazzochi81@gmail.com"
            };
            return View(potentialClients);
        }
        //Decorating this action with the authorize attribute.
        [Authorize(Roles = "Admin")]
        public ActionResult DetailsForAdmin(int id)
        {
            var db = new ApplicationDbContext();
            var potentialClients = db.PotentialClients.Find(id);
            //You can use the Details view, instead of creating a brand new view called DetailsForAdmin
            return View("Details", potentialClients);
        }

        public ActionResult List()
        {
            var db = new ApplicationDbContext();
            return View(db.PotentialClients.ToList());
        }


        // GET: PotentialClient/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PotentialClient/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: PotentialClient/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PotentialClient/Edit/5
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

        // GET: PotentialClient/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PotentialClient/Delete/5
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
