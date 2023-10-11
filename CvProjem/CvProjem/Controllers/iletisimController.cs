using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CvProjem.Models.Entity;
using CvProjem.Repositories;

namespace CvProjem.Controllers
{
    public class iletisimController : Controller
    {
          GenericRepository<Tbliletişim> repo = new GenericRepository<Tbliletişim>();
        public ActionResult Index()
        {
            var mesajlar=repo.List();
            return View(mesajlar);
        }
    }
}