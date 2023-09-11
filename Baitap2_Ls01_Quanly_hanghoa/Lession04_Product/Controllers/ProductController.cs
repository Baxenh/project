using Lession04_Product.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Reflection;

namespace Lession04_Product.Controllers
{
    public class ProductController : Controller
    {
        // GET: ProductController
        public ActionResult Index()
        {
            var _products = DataLocal.GetProducts();
            return View(_products);
        }

        // GET: ProductController/Details/5
        public ActionResult Details(int id)
        {
            var product = DataLocal.GetProductById(id);
            return View(product);
        }

        // GET: ProductController/Create
        public ActionResult Create()
        {
            var _products = DataLocal.GetProducts();
            return View(_products);
        }

        // POST: ProductController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Product model)
        {
            try
            {

                ////upload file vào thư mục wwwroot/images
                //var files = HttpContext.Request.Form.Files;
                ////using System.linq
                //if (files.Count() > 0 && files[0].Length > 0)
                //{
                //    var file = files[0];
                //    var FileName = file.FileName;
                //    //nhớ tạo thu mục trong mục wwwroot/images
                //    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\images\\Avatar", FileName);
                //    using (var stream = new FileStream(path, FileMode.Create))
                //    {
                //        file.CopyTo(stream);
                //        model.Images = "images" + FileName;//gán tên ảnh thuộc tính Avatar

                //    }
                //}
                ////cập nhật model vào danh sách DataLocal
                //DataLocal._products.Add(model);
                return RedirectToAction(nameof(Index));
            }
            catch 
            {
                //ViewBag.error = ex.Message;
                return View(model);
            }
        }

        // GET: ProductController/Edit/5
        public ActionResult Edit(int id)
        {
            var _products = DataLocal.GetProductById(id);
            return View(_products);
          
        }

        // POST: ProductController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Product model)
        {
            try
            {
                //upload file vào thư mục wwwroot/images
                var files = HttpContext.Request.Form.Files;
                //using System.linq
                if (files.Count() > 0 && files[0].Length > 0)
                {
                    var file = files[0];
                    var FileName = file.FileName;
                    //nhớ tạo thu mục trong mục wwwroot/images
                    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\images\\Avatar", FileName);
                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        file.CopyTo(stream);
                        model.Images = "images" + FileName;//gán tên ảnh thuộc tính Avatar

                    }
                }
                //cập nhật model vào danh sách DataLocal
                for (int i = 0; i < DataLocal._products.Count; i++)
                {
                    if (DataLocal._products[i].Id == id)
                    {
                        DataLocal._products[i] = model;
                    }
                }

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(model);
            }
        }
        

        // GET: ProductController/Delete/5
        public ActionResult Delete(int id)
        {
            var product = DataLocal.GetProductById(id);
            return View(product);
        }

        // POST: ProductController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Product model)
        {
            try
            {

                for (int i = 0; i < DataLocal._products.Count; i++)
                {
                    if (DataLocal._products[i].Id == id)
                    {
                        DataLocal._products.RemoveAt(i);
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
