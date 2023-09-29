using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Lession07Lab07_BTTL_Product_DF.Models;

namespace Lession07Lab07_BTTL_Product_DF.Areas.Admins.Controllers
{
    [Area("Admins")]
    public class NguoiDungsController : Controller
    {
        private readonly ProductContext _context;

        public NguoiDungsController(ProductContext context)
        {
            _context = context;
        }

        // GET: Admins/NguoiDungs
        public async Task<IActionResult> Index()
        {
              return _context.NguoiDungs != null ? 
                          View(await _context.NguoiDungs.ToListAsync()) :
                          Problem("Entity set 'ProductContext.NguoiDungs'  is null.");
        }

        // GET: Admins/NguoiDungs/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.NguoiDungs == null)
            {
                return NotFound();
            }

            var nguoiDung = await _context.NguoiDungs
                .FirstOrDefaultAsync(m => m.Id == id);
            if (nguoiDung == null)
            {
                return NotFound();
            }

            return View(nguoiDung);
        }

        // GET: Admins/NguoiDungs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admins/NguoiDungs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,TenDangNhap,LoaiNguoiDung,MaNguoiDung,TenNguoiDung,GioiTinh")] NguoiDung nguoiDung)
        {
            if (ModelState.IsValid)
            {
                _context.Add(nguoiDung);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(nguoiDung);
        }

        // GET: Admins/NguoiDungs/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.NguoiDungs == null)
            {
                return NotFound();
            }

            var nguoiDung = await _context.NguoiDungs.FindAsync(id);
            if (nguoiDung == null)
            {
                return NotFound();
            }
            return View(nguoiDung);
        }

        // POST: Admins/NguoiDungs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Id,TenDangNhap,LoaiNguoiDung,MaNguoiDung,TenNguoiDung,GioiTinh")] NguoiDung nguoiDung)
        {
            if (id != nguoiDung.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(nguoiDung);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NguoiDungExists(nguoiDung.Id))
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
            return View(nguoiDung);
        }

        // GET: Admins/NguoiDungs/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.NguoiDungs == null)
            {
                return NotFound();
            }

            var nguoiDung = await _context.NguoiDungs
                .FirstOrDefaultAsync(m => m.Id == id);
            if (nguoiDung == null)
            {
                return NotFound();
            }

            return View(nguoiDung);
        }

        // POST: Admins/NguoiDungs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.NguoiDungs == null)
            {
                return Problem("Entity set 'ProductContext.NguoiDungs'  is null.");
            }
            var nguoiDung = await _context.NguoiDungs.FindAsync(id);
            if (nguoiDung != null)
            {
                _context.NguoiDungs.Remove(nguoiDung);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool NguoiDungExists(string id)
        {
          return (_context.NguoiDungs?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
