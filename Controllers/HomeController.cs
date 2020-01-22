using MBGIE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MBGIE.Controllers
{

    [AllowAnonymous]

    public class HomeController : Controller
    {
        private ApplicationDbContext _context;

        public HomeController()
        {
            _context = new ApplicationDbContext();
        }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ContactusList()
        {
            return View();
        }
        public ActionResult Contestants()
        {
            return View();
        }

        public ActionResult Studios()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Gallary()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }


        public ActionResult Terms()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpPost]
        public ActionResult Contact(ContactUs contactUs)
        {
            int checkcontactid = _context.ContactUs.Count();
            if (checkcontactid.Equals(null))
            {
                contactUs.Id = 1;
            }
            else
            {
                contactUs.Id = checkcontactid + 1; 
            }
            contactUs.DateofContact = DateTime.Now;
            
            _context.ContactUs.Add(contactUs);
            _context.SaveChanges();
           

            return RedirectToAction("Index", "Home");
        }
    }
}