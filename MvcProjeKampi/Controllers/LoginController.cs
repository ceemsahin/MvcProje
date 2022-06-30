using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace MvcProjeKampi.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        // GET: Login
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Admın p)
        {

            Context c = new Context();
            var admınUserinfo = c.Admins.FirstOrDefault(x => x.AdminUserName ==p.AdminUserName && x.AdminPassword==p.AdminPassword);
            if (admınUserinfo!=null)
            {
                FormsAuthentication.SetAuthCookie(admınUserinfo.AdminUserName, false);
                Session["AdminUserName"] = admınUserinfo.AdminUserName;

                return RedirectToAction("Index","AdminCategory");


            }
            else
            {
                return RedirectToAction("Index");
            }
            


        }

        [HttpGet]
        public ActionResult WriterLogin()
        {
            return View();
        }
        [HttpPost]
        public ActionResult WriterLogin(Writer p)
        {

            Context c = new Context();
            var writerUserinfo = c.Writers.FirstOrDefault(x => x.WriterMail == p.WriterMail && x.WriterPassword == p.WriterPassword);
            if (writerUserinfo != null)
            {
                FormsAuthentication.SetAuthCookie(writerUserinfo.WriterMail, false);
                Session["WriterMail"] = writerUserinfo.WriterMail
                    ;

                return RedirectToAction("MyContent", "WriterPanelContent");


            }
            else
            {
                return RedirectToAction("WriterLogin");
            }

        
        }
    }
}