using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Online_shopping_project.Models;

namespace Online_shopping_project.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult category()
        {
            project1Entities db = new project1Entities();
            List<Category> en = db.Categories.ToList();
            return View();
        }

        

    }
}