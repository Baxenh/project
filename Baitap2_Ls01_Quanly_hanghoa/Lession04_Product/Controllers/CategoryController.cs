using Lession04_Product.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Reflection;

namespace Lession04_Product.Controllers
{
    public class CategoryController : Controller
    {
        // GET: CategoryController
        public ActionResult Index()
        {
            var categories = DataLocalCate.GetCategory();
            return View(categories);
        }

        // GET: CategoryController/Details/5
        public ActionResult Details(int id)
        {
            var categories = DataLocalCate.GetCategory();
            return View(categories);
        }

        // GET: CategoryController/Create
        public ActionResult Create()
        {
            var categories = DataLocalCate.GetCategory();
            return View();
        }

        // POST: CategoryController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Category model)
        {
            try
            {               
                //cập nhật model vào danh sách DataLocal
                DataLocalCate._categories.Add(model);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ViewBag.error = ex.Message;
                return View(model);
            }
        
        }

        // GET: CategoryController/Edit/5
        public ActionResult Edit(int id)
        {
            var categories = DataLocalCate.GetCategoryById(id);
            return View(categories);
        }

        // POST: CategoryController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Category model)
        {
            try
            {   //upload file vào thư mục wwwroot/images
                var files = HttpContext.Request.Form.Files;
                //using System.linq
               
                //cập nhật model vào danh sách DataLocal
                for (int i = 0; i < DataLocal._products.Count; i++)
                {
                    if (DataLocalCate._categories[i].Id == id)
                    {
                        DataLocalCate._categories[i] = model;
                    }
                }

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(model);
            }
        }
        

        // GET: CategoryController/Delete/5
        public ActionResult Delete(int id)
        {

            var categories = DataLocalCate.GetCategoryById(id);
            return View(categories);
        }

        // POST: CategoryController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                for (int i = 0; i < DataLocalCate._categories.Count; i++)
                {
                    if (DataLocalCate._categories[i].Id == id)
                    {
                        DataLocalCate._categories.RemoveAt(i);
                        break;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
