 using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CvProjem.Models.Entity;
using CvProjem.Repositories;

namespace CvProjem.Controllers
{
    public class SosyalMedyaController : Controller
    {
        GenericRepository<TblSosyalMedya> repo = new GenericRepository<TblSosyalMedya>();
       

        public ActionResult Index()
        {

            var veriler = repo.List();
            return View(veriler);
        }

        [HttpGet]
        public ActionResult Ekle()
        {
            return View();
        }

		[HttpPost]
		public ActionResult Ekle(TblSosyalMedya p)
		{
            repo.TAdd(p);
            return RedirectToAction("Index");
		}
	}
}