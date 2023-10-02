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
    public class BannersController : Controller
    {
        private readonly AppDbContext _context;

        public BannersController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Admins/Banners
        public async Task<IActionResult> Index(string? name, int page = 1)
        {
            //Phân trang - số trang trên 1 trang
            int limit = 5;


            //Tìm kiếm start
            var banner = await _context.Banners.OrderBy(x => x.Id).ToPagedListAsync(page, limit);
            if (!string.IsNullOrEmpty(name))
            {
                banner = await _context.Banners.Where(x => x.Name.Contains(name)).OrderBy(x => x.Id).ToPagedListAsync(page, limit);
            }
            ViewBag.keyword = name;
            return View(banner);
            //tìm kiếm end
        }

        // GET: Admins/Banners/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Banners == null)
            {
                return NotFound();
            }

            var banner = await _context.Banners
                .FirstOrDefaultAsync(m => m.Id == id);
            if (banner == null)
            {
                return NotFound();
            }

            return View(banner);
        }

        // GET: Admins/Banners/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admins/Banners/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Status,Prioty,CreatedDate,Image,Description")] Banner banner)
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
                    // upload ảnh vào thư mục wwwroot\\images\\Banners
                    var path = Path.Combine(Directory.GetCurrentDirectory(),
                    "wwwroot\\images\\banners", FileName);
                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        file.CopyTo(stream);

                       banner.Image = "/images/banners/" + FileName; // gán tên ảnh cho thuộc tinh Image
                    }
                }
                banner.CreatedDate = DateTime.Now;


                //Thêm mới 

                _context.Add(banner);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(banner);
        }

        // GET: Admins/Banners/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Banners == null)
            {
                return NotFound();
            }

            var banner = await _context.Banners.FindAsync(id);
            if (banner == null)
            {
                return NotFound();
            }
            return View(banner);
        }

        // POST: Admins/Banners/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Status,Prioty,CreatedDate,Image,Description")] Banner banner)
        {
            if (id != banner.Id)
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
                        // upload ảnh vào thư mục wwwroot\\iamges\\banners
                        var path = Path.Combine(Directory.GetCurrentDirectory(),
                        "wwwroot\\iamges\\banners", FileName);
                        using (var stream = new FileStream(path, FileMode.Create))
                        {
                            file.CopyTo(stream);
                            banner.Image = "/images/banners/" + FileName; // gán tên ảnh cho thuộc tinh Image
                        }
                    }
                    _context.Update(banner);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BannerExists(banner.Id))
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
            return View(banner);
        }

        // GET: Admins/Banners/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Banners == null)
            {
                return NotFound();
            }

            var banner = await _context.Banners
                .FirstOrDefaultAsync(m => m.Id == id);
            if (banner == null)
            {
                return NotFound();
            }

            return View(banner);
        }

        // POST: Admins/Banners/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Banners == null)
            {
                return Problem("Entity set 'AppDbContext.Banners'  is null.");
            }
            var banner = await _context.Banners.FindAsync(id);
            if (banner != null)
            {
                _context.Banners.Remove(banner);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BannerExists(int id)
        {
          return (_context.Banners?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
