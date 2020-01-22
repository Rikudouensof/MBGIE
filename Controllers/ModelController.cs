using MBGIE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MBGIE.Controllers
{
    public class ModelController : Controller
    {

        private ApplicationDbContext _context;


        public ModelController()
        {
            _context = new ApplicationDbContext();
        }
        // GET: Model
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ModelList()
        {
            return View();
        }


        public ActionResult AddModels()
        {
           
            return View();
        }

        public ActionResult SaveModels()
        {

            return View();
        }

        public ActionResult EditModel(int idkk)
        {
            ModelProfile modelProfile = _context.ModelProfiles.Where(mm => mm.Id.Equals(idkk)).FirstOrDefault();

            return View(modelProfile);
        }



    }
}