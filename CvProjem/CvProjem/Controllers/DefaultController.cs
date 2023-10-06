using System;
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
    }
}