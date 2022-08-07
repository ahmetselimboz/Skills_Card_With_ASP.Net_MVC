using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using YetenekKart.Models.Siniflar;

namespace YetenekKart.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            Context C = new Context();
            var degerler = C.Yeteneklers.ToList();
            return View(degerler);
        }
    }
}