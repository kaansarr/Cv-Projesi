using CvProjem.Models.Entity;
using CvProjem.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CvProjem.Controllers
{
    public class EgitimController : Controller
    {
		GenericRepository<TblEgitim> repo = new GenericRepository<TblEgitim>();
		public ActionResult Index()
        {
            var egitim = repo.List();
            return View(egitim);
        }
        [HttpGet]
        public ActionResult EgitimEkle()
        {
            return View();
        }
        [HttpPost]
		public ActionResult EgitimEkle(TblEgitim p)
		{

            if (!ModelState.IsValid)
            {
                return View("EgitimEkle");
            }
            repo.TAdd(p);
			return RedirectToAction("Index");
		}


	}
}