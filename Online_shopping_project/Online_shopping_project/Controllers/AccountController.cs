using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using Online_shopping_project.Models;

namespace Online_shopping_project.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult login()
        {
            return View();
        }
        [HttpPost]

        public ActionResult login(login model)
        {
            using (var context=new project1Entities() )
            {
                bool isvalid = context.Users.Any(x => x.UserName == model.Username && x.UserPassword == model.Password);
                if(isvalid)
                {
                    FormsAuthentication.SetAuthCookie(model.Username, false);
                    return RedirectToAction("category","Category");
                }
                ModelState.AddModelError("", "Invalid username or password");
                return View();
            }
        }


        public ActionResult Signup()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Signup(User en)
        {
            using (project1Entities db = new project1Entities())
            {
                db.Users.Add(en);
                db.SaveChanges();
               
            }

            return RedirectToAction("login");
        }


        public ActionResult Reset()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Reset(reset model)
        {
            using (var context = new project1Entities())
            {
                bool isvalid = context.Users.Any(x => x.UserName == model.Username );
                if (isvalid)
                {
                    var cols = context.Users.Where(x => x.UserName.Equals(model.Username));
                    foreach(User c in cols)
                    {
                        c.UserPassword = model.NewPassword;
                        
                    }
                    context.SaveChanges();
                   
                    return RedirectToAction("login");
                }
                ModelState.AddModelError("", "Username does not exist!! ");
                return View();
            }
        }
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("login");
        }


    }
}