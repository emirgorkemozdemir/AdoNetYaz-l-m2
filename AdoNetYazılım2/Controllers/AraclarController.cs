using AdoNetYazılım2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AdoNetYazılım2.Controllers
{
    public class AraclarController : Controller
    {
        // veritabanı referansı her yerden bu arkadaşı kullanabilirsiniz.
        OtoServisDBEntities db = new OtoServisDBEntities();

        [HttpGet]
        public ActionResult AraclarıYukle()
        {
            List<araclar> arac_listesi = db.araclars.ToList();
            return View(arac_listesi);
        }

       
    }
}