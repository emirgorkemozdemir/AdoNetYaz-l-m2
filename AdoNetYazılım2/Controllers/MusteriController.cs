using AdoNetYazılım2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AdoNetYazılım2.Controllers
{
    public class MusteriController : Controller
    {
        OtoServisDBEntities dba = new OtoServisDBEntities();
        // GET: Musteri
        public ActionResult Index()
        {
            List<musteriler> musterileryukle = dba.musterilers.ToList();
            return View(musterileryukle);
        }
    }
}