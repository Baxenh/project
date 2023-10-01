using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Lession08Lab08_Product_Demo.Models;
using Lesson08_Lab08_Demo_Product.Models;
using X.PagedList;

namespace Lesson08_Lab08_Demo_Product.Areas.Admins.Controllers
{
    [Area("Admins")]
    public class ProductsController : Controller
    {
        private readonly AppDbContext _context;

        public ProductsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Admins/Products
        public async Task<IActionResult> Index(string? name, int page = 1)
        {
            //phân trang - số trang trên 1 trang
            int limit = 5;


            var products = await _context.Products.OrderBy(p => p.Id).ToPagedListAsync(page, limit);
            if (!string.IsNullOrEmpty(name))
            {
                products = await _context.Products.Where(p => p.Name.Contains(name)).OrderBy(p => p.Id).ToPagedListAsync(page, limit);
            }
            ViewBag.keyword = name;
            return View(products);
            //end tìm kiếm
        }

        // GET: Admins/Products/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Products == null)
            {
                return NotFound();
            }

            var product = await _context.Products
                .Include(p => p.Category)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // GET: Admins/Products/Create
        public IActionResult Create()
        {
            ViewData["CategoryId"] = new SelectList(_context.Categories, "Id", "Name");
            return View();
        }

        // POST: Admins/Products/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Image,Price,SalePrice,Status,Description,CategoryId,CreatedDate")] Product product)
        {
            if (ModelState.IsValid)
            {
                //// upload ảnh
                var files = HttpContext.Request.Form.Files;
                //tìm kiếm ảnh
                // Kiểm tra xem tệp ảnh có tồn tại không
                //if (System.IO.File.Exists("wwwroot/" + resultObj.Image))
                //{
                //    // Xóa tệp ảnh
                //    System.IO.File.Delete("wwwroot/" + resultObj.Image);
                //}
                //else
                if (files.Count() > 0 && files[0].Length > 0)
                {
                    var file = files[0];

                    var FileName = file.FileName;
                    // upload ảnh vào thư mục wwwroot\\images\\Product
                    var path = Path.Combine(Directory.GetCurrentDirectory(),
                    "wwwroot\\images\\products", FileName);
                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        file.CopyTo(stream);

                        product.Image = "/images/products/" + FileName; // gán tên ảnh cho thuộc tinh Image
                    }
                }
                product.CreatedDate = DateTime.Now;


                //Thêm mới

                _context.Add(product);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CategoryId"] = new SelectList(_context.Categories, "Id", "Name", product.CategoryId);
            return View(product);
        }

        // GET: Admins/Products/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Products == null)
            {
                return NotFound();
            }

            var product = await _context.Products.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }
            ViewData["CategoryId"] = new SelectList(_context.Categories, "Id", "Name", product.CategoryId);
            return View(product);
        }

        // POST: Admins/Products/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Image,Price,SalePrice,Status,Description,CategoryId,CreatedDate")] Product product)
        {
            if (id != product.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var files = HttpContext.Request.Form.Files;
                    if (files.Count() > 0 && files[0].Length > 0)

                    {
                        var file = files[0];

                        var FileName = file.FileName;
                        // upload ảnh vào thư mục wwwroot\\iamges\\Categories
                        var path = Path.Combine(Directory.GetCurrentDirectory(),
                        "wwwroot\\iamges\\products", FileName);
                        using (var stream = new FileStream(path, FileMode.Create))
                        {
                            file.CopyTo(stream);
                            product.Image = "/images/products/" + FileName; // gán tên ảnh cho thuộc tinh Image
                        }
                    }

                    _context.Update(product);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductExists(product.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["CategoryId"] = new SelectList(_context.Categories, "Id", "Name", product.CategoryId);
            return View(product);
        }

        // GET: Admins/Products/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Products == null)
            {
                return NotFound();
            }

            var product = await _context.Products
                .Include(p => p.Category)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // POST: Admins/Products/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Products == null)
            {
                return Problem("Entity set 'AppDbContext.Products'  is null.");
            }
            var product = await _context.Products.FindAsync(id);
            if (product != null)
            {
                _context.Products.Remove(product);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProductExists(int id)
        {
          return (_context.Products?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
