using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Lession08Lab08_Product_Demo.Models;
using Lession08_Lab08_Product_Demo.Models;
using X.PagedList;

namespace Lession08Lab08_Product_Demo.Areas.Admins.Controllers
{
    [Area("Admins")]
    public class BlogsController : Controller
    {
        private readonly AppDbContext _context;

        public BlogsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Admins/Blogs
        public async Task<IActionResult> Index(string? name, int page = 1)
        {  //Phân trang - số trang trên 1 trang
            int limit = 5;


            //Tìm kiếm start
            var blogs = await _context.Blogs.OrderBy(x => x.Id).ToPagedListAsync(page, limit);
            if (!string.IsNullOrEmpty(name))
            {
                blogs = await _context.Blogs.Where(x => x.Name.Contains(name)).OrderBy(x => x.Id).ToPagedListAsync(page, limit);
            }
            ViewBag.keyword = name;
            return View(blogs);
            //tìm kiếm end
        }

        // GET: Admins/Blogs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Blogs == null)
            {
                return NotFound();
            }

            var blog = await _context.Blogs
                .FirstOrDefaultAsync(m => m.Id == id);
            if (blog == null)
            {
                return NotFound();
            }

            return View(blog);
        }

        // GET: Admins/Blogs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admins/Blogs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Status,ViewCount,CreatedDate,Image,Description")] Blog blog)
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
                    // upload ảnh vào thư mục wwwroot\\images\\Blog
                    var path = Path.Combine(Directory.GetCurrentDirectory(),
                    "wwwroot\\images\\blogs", FileName);
                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        file.CopyTo(stream);

                        blog.Image = "/images/categories/" + FileName; // gán tên ảnh cho thuộc tinh Image
                    }
                }
                blog.CreatedDate = DateTime.Now;


                //Thêm mới 






                _context.Add(blog);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(blog);
        }

        // GET: Admins/Blogs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Blogs == null)
            {
                return NotFound();
            }

            var blog = await _context.Blogs.FindAsync(id);
            if (blog == null)
            {
                return NotFound();
            }
            return View(blog);
        }

        // POST: Admins/Blogs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Status,ViewCount,CreatedDate,Image,Description")] Blog blog)
        {
            if (id != blog.Id)
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
                        // upload ảnh vào thư mục wwwroot\\iamges\\Blogs
                        var path = Path.Combine(Directory.GetCurrentDirectory(),
                        "wwwroot\\iamges\\blogs", FileName);
                        using (var stream = new FileStream(path, FileMode.Create))
                        {
                            file.CopyTo(stream);
                            blog.Image = "/images/blogs/" + FileName; // gán tên ảnh cho thuộc tinh Image
                        }
                    }

                    _context.Update(blog);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BlogExists(blog.Id))
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
            return View(blog);
        }

        // GET: Admins/Blogs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Blogs == null)
            {
                return NotFound();
            }

            var blog = await _context.Blogs
                .FirstOrDefaultAsync(m => m.Id == id);
            if (blog == null)
            {
                return NotFound();
            }

            return View(blog);
        }

        // POST: Admins/Blogs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Blogs == null)
            {
                return Problem("Entity set 'AppDbContext.Blogs'  is null.");
            }
            var blog = await _context.Blogs.FindAsync(id);
            if (blog != null)
            {
                _context.Blogs.Remove(blog);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BlogExists(int id)
        {
          return _context.Blogs.Any(e => e.Id == id);
        }
    }
}
