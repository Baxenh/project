using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Lession08_Lab08.Models;
using Lession08_Lab08_Product_Demo.Models;
using X.PagedList;

namespace Lession08_Lab08_Product_Demo.Areas.Admins.Controllers
{
    [Area("Admins")]
    public class CategoriesController : Controller
    {
        private readonly AppDbContext _context;

        public CategoriesController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Admins/Categories
        public async Task<IActionResult> Index(string? name, int page=1)
        {
            //Phân trang - số trang trên 1 trang
            int limit = 2;


            //Tìm kiếm start
            var category =await _context.Categories.OrderBy(x=>x.Id).ToPagedListAsync(page,limit);
            if (!string.IsNullOrEmpty(name))
            {
                category = await _context.Categories.Where(x => x.Name.Contains(name)).OrderBy(x => x.Id).ToPagedListAsync( page, limit); 
            }
            ViewBag.keyword = name;
            return View(category);
            //tìm kiếm end
        }

        // GET: Admins/Categories/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Categories == null)
            {
                return NotFound();
            }

            var category = await _context.Categories
                .FirstOrDefaultAsync(m => m.Id == id);
            if (category == null)
            {
                return NotFound();
            }

            return View(category);
        }

        // GET: Admins/Categories/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admins/Categories/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Status,CreatedDate,Image,Description")] Category category)
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
                    // upload ảnh vào thư mục wwwroot\\images\\Category
                    var path = Path.Combine(Directory.GetCurrentDirectory(),
                    "wwwroot\\images\\categories", FileName);
                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        file.CopyTo(stream);

                        category.Image = "/images/categories/" + FileName; // gán tên ảnh cho thuộc tinh Image
                    }
                }
                category.CreatedDate = DateTime.Now;


                //Thêm mới 
                _context.Add(category);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(category);
        }

        // GET: Admins/Categories/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Categories == null)
            {
                return NotFound();
            }

            var category = await _context.Categories.FindAsync(id);
            if (category == null)
            {
                return NotFound();
            }
            return View(category);
        }

        // POST: Admins/Categories/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Status,CreatedDate,Image,Description")] Category category)
        {
            if (id != category.Id)
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
                        "wwwroot\\iamges\\Categories", FileName);
                        using (var stream = new FileStream(path, FileMode.Create))
                        {
                            file.CopyTo(stream);
                            category.Image = "/images/categories/" + FileName; // gán  tên ảnh cho thuộc tinh Image
                        }
                    }
                    _context.Update(category);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CategoryExists(category.Id))
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
            return View(category);
        }

        // GET: Admins/Categories/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Categories == null)
            {
                return NotFound();
            }

            var category = await _context.Categories
                .FirstOrDefaultAsync(m => m.Id == id);
            if (category == null)
            {
                return NotFound();
            }

            return View(category);
        }

        // POST: Admins/Categories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Categories == null)
            {
                return Problem("Entity set 'AppDbContext.Categories'  is null.");
            }
            var category = await _context.Categories.FindAsync(id);
            if (category != null)
            {
                _context.Categories.Remove(category);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CategoryExists(int id)
        {
          return (_context.Categories?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
