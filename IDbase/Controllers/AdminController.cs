using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IDbase.Models;

namespace IDbase.Controllers
{
    public class AdminController : Controller
    {

        private IDbaseEntities db = new IDbaseEntities();
        //
        // GET: /Admin/

        public ActionResult Index()
        {
            var ids = (from IDtable in db.IDtables select IDtable).ToList();
            return View(ids);
        }

        //
        // GET: /Admin/Details/5

        public ActionResult Details(int id)
        {
            var idDetails = (from IDtable in db.IDtables
                             where IDtable.IDnumber == id
                             select IDtable).First();
            return View(idDetails);
        }

        //
        // GET: /Admin/Create

        public ActionResult Create()
        {
            IDtable id = new IDtable();
            return View(id);
        } 

        //
        // POST: /Admin/Create

        [HttpPost]
        public ActionResult Create(IDtable id)
        {
            try
            {
                // TODO: Add insert logic here

                if (ModelState.IsValid)
                {
                    db.AddToIDtables(id);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            catch(Exception ex)
            {
                ModelState.AddModelError("Error",ex);
            }
            return View();
        }
        
        //
        // GET: /Admin/Edit/5
 
        public ActionResult Edit(int id)
        {
            var idEdit = (from IDtable in db.IDtables
                             where IDtable.IDnumber == id
                             select IDtable).First();
            return View(idEdit);
        }

        //
        // POST: /Admin/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            var idEdit = (from IDtable in db.IDtables
                          where IDtable.IDnumber == id
                          select IDtable).First();
            try
            {
                // TODO: Add update logic here
                UpdateModel(idEdit);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View(idEdit);
            }
        }

        //
        // GET: /Admin/Delete/5
 
        public ActionResult Delete(int id)
        {
            var idDelete = (from IDtable in db.IDtables
                          where IDtable.IDnumber == id
                          select IDtable).First();
            return View(idDelete);
        }

        //
        // POST: /Admin/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            var idDelete = (from IDtable in db.IDtables
                            where IDtable.IDnumber == id
                            select IDtable).First();

            try
            {
                db.DeleteObject(idDelete);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View(idDelete);
            }
        }
    }
}
