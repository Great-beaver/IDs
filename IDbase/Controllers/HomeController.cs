using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IDbase.Models;

namespace IDbase.Controllers
{
    public class HomeController : Controller
    {

        private IDbaseEntities db = new IDbaseEntities();

        //
        // GET: /Home/

        public ActionResult Index()
        {
            var ids = (from IDtable in db.IDtables select IDtable ).ToList();
            return View(ids);
        }

        public ActionResult Details(int id)
        {
            var idDetails = (from IDtable in db.IDtables 
                             where IDtable.IDnumber==id
                             select IDtable).First();
            return View(idDetails);
        }

    }
}
