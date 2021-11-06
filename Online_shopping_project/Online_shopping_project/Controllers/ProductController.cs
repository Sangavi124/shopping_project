using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Online_shopping_project.Models;
namespace Online_shopping_project.Controllers
{
    public class ProductController : Controller
    {
        project1Entities db = new project1Entities();
        // GET: Product
        public ActionResult Index()
        {


            var query = db.clothes.ToList();

            return View(query);
        }
        public ActionResult AddProduct()
        {
            List<Category> list1 = db.Categories.ToList();
            ViewBag.CatList = new SelectList(list1, "CategoryID", "CategoryName");

            List<Material> list2 = db.Materials.ToList();
            ViewBag.MatList = new SelectList(list2, "MaterialID", "MaterialName");
            return View();
        }
        [HttpPost]
        public ActionResult AddProduct(cloth c, HttpPostedFileBase Image)
        {
            List<Category> list1 = db.Categories.ToList();
            ViewBag.CatList = new SelectList(list1, "CategoryID", "CategoryName");

            List<Material> list2 = db.Materials.ToList();
            ViewBag.MatList = new SelectList(list2, "MaterialID", "MaterialName");

            if (ModelState.IsValid)
            {

                cloth clo = new cloth();
                clo.clothName = c.clothName;
                clo.Price = c.Price;
                clo.CategoryID = c.CategoryID;
                clo.MaterialID = c.MaterialID;
                clo.Image = Image.FileName.ToString();

                var folder = Path.Combine(Server.MapPath("~/Images/"), Path.GetFileName(Image.FileName));
                //Image.SaveAs(Path.Combine(folder, Image.FileName.ToString()));
                Image.SaveAs(folder);
                db.clothes.Add(clo);
                db.SaveChanges();

                return RedirectToAction("Index", "Product");
            }
            else
            {
                ModelState.AddModelError("", "Product did not upload");
            }
            return View();
        }

        public ActionResult Categories()
        {
            List<Category> c = db.Categories.ToList();
            return View(c);
        }

        public ActionResult CatSelect(int? id)
        {
            var klist = db.clothes.Where(x => x.CategoryID == id).ToList();
            return View(klist);
        }
    }
}