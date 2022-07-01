using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class AuthorizationController : Controller
    {
        // GET: Authorization
        AdminManager am = new AdminManager(new EfAdminDal());
        public ActionResult Index()
        {
            var adminvalues = am.GetList();


            return View(adminvalues);
        }

        [HttpGet]
        public ActionResult AddAdmin()
        {
            return View();
        }




        [HttpPost]
        public ActionResult AddAdmin(Admın p)
        {


            am.AdminAdd(p);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult EditAdmin(int id)
        {

            List<SelectListItem> valuecategory = (from x in am.GetList()
                                                  select new SelectListItem
                                                  {
                                                      Text = x.AdminRole,
                                                      Value = x.AdminRole.ToString()

                                                  }).ToList();

            ViewBag.vlc = valuecategory;



            var adminvalue = am.GetByID(id);

            return View(adminvalue);
        }



        [HttpPost]
        public ActionResult EditAdmin(Admın p)
        {
            am.AdminUpdate(p);
            return RedirectToAction("Index");

        }


        public ActionResult DeleteAdmin(int id)
        {
            var admindelete = am.GetByID(id);
            am.AdminDelete(admindelete);
          return RedirectToAction("Index");
        }


    }

}