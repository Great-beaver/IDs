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
        private int PageSize = 1;
        //
        // GET: /Home/

        public ActionResult Index(int PageNum = 0)
        {
            ViewData["PageNum"] = PageNum;
            ViewData["ItemsCount"] = db.IDtables.Count(); 
            ViewData["PageSize"] = PageSize;
            var ids = (from IDtable in db.IDtables orderby IDtable.IDnumber select IDtable ).
                Skip(PageSize * PageNum).Take(PageSize).ToList();
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
