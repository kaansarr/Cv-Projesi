﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CvProjem.Models.Entity;

namespace CvProjem.Controllers
{
    public class DefaultController : Controller
    {
        
        DbCvEntities db=new DbCvEntities();
        public ActionResult Index()
        {
            var degerler=db.TblHakkimda.ToList();
            return View(degerler);
        }

        public PartialViewResult Deneyim()
        {
            var deneyimler =db.TblDeneyimlerim.ToList();
            return PartialView(deneyimler);
        }

		public PartialViewResult Egitimlerim()
		{
			var egitimler = db.TblEgitim.ToList();
			return PartialView(egitimler);
		}

		public PartialViewResult Yeteneklerim()
		{
			var yetenekler = db.TblYeteneklerim.ToList();
			return PartialView(yetenekler);
		}

		public PartialViewResult Hobilerim()
		{
			var hobilerim = db.TblHobilerim.ToList();
			return PartialView(hobilerim);
		}
	}
}