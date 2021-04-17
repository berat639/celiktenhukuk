using celiktenhukuk.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace celiktenhukuk.Controllers
{
    public class SayfalarController : Controller
    {
        // GET: Sayfalar
        public ActionResult AnaSayfa()
        {
            return View();
        }
        public ActionResult Baglantilar()
        {
            return View();
        }
        public ActionResult Vekaletnameveodemebilgileri()
        {
            return View();
        }
        public ActionResult Calismaalanlari()
        {
            return View();
        }
        public ActionResult Hakkimizda()
        {
            return View();
        }
        public ActionResult Yasaluyari()
        {
            return View();
        }
        public ActionResult Iletisim()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Iletisim(contact model)
        {
            if (ModelState.IsValid)
            {
                var body = new StringBuilder();
                body.AppendLine("İsim:" + model.İsim);
                body.AppendLine("Eposta:" + model.Email);
                body.AppendLine("Soy İsim:" + model.Soyisim);
                body.AppendLine("Tel:" + model.Tel);
                body.AppendLine("Mesaj:" + model.Mesaj);

                Mail.SendMail(body.ToString());
                ViewBag.Success = true;
            }
            return View();
        }


        public ActionResult Isvesosyalguvenlikhukuku()
        {
            return View();
        }
        public ActionResult Tuketicihukuku()
        {
            return View();
        }
        public ActionResult Tazminathukuku()
        {
            return View();
        }
        public ActionResult Sirketlerhukuku()
        {
            return View();
        }
        public ActionResult Fikrivesinaihaklarhukuku()
        {
            return View();
        }
        public ActionResult Cezahukuku()
        {
            return View();
        }
        public ActionResult Yabancilarvevatandaslikhukuku()
        {
            return View();
        }
        public ActionResult Icraiflashukuku()
        {
            return View();
        }
        public ActionResult Vergihukuku()
        {
            return View();
        }
        public ActionResult Idarehukuku()
        {
            return View();
        }
        public ActionResult TurizmHukuku()
        {
            return View();
        }
        public ActionResult Imarhukuku()
        {
            return View();
        }
        public ActionResult Gayrimenkulveinsaathukuku()
        {
            return View();
        }
        public ActionResult odemebilgileri()
        {
            return View();
        }

    }
}