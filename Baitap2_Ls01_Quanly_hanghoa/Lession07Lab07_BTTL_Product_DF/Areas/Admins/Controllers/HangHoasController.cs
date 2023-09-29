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
    public class HangHoasController : Controller
    {
        private readonly ProductContext _context;

        public HangHoasController(ProductContext context)
        {
            _context = context;
        }

        // GET: Admins/HangHoas
        public async Task<IActionResult> Index()
        {
              return _context.HangHoas != null ? 
                          View(await _context.HangHoas.ToListAsync()) :
                          Problem("Entity set 'ProductContext.HangHoas'  is null.");
        }

        // GET: Admins/HangHoas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.HangHoas == null)
            {
                return NotFound();
            }

            var hangHoa = await _context.HangHoas
                .FirstOrDefaultAsync(m => m.MaHangHoa == id);
            if (hangHoa == null)
            {
                return NotFound();
            }

            return View(hangHoa);
        }

        // GET: Admins/HangHoas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admins/HangHoas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MaHangHoa,TenHangHoa,Soluong,DonGiaNhap,DonGiaBan,Anh,GhiChu")] HangHoa hangHoa)
        {
            if (ModelState.IsValid)
            {
                _context.Add(hangHoa);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(hangHoa);
        }

        // GET: Admins/HangHoas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.HangHoas == null)
            {
                return NotFound();
            }

            var hangHoa = await _context.HangHoas.FindAsync(id);
            if (hangHoa == null)
            {
                return NotFound();
            }
            return View(hangHoa);
        }

        // POST: Admins/HangHoas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MaHangHoa,TenHangHoa,Soluong,DonGiaNhap,DonGiaBan,Anh,GhiChu")] HangHoa hangHoa)
        {
            if (id != hangHoa.MaHangHoa)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(hangHoa);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HangHoaExists(hangHoa.MaHangHoa))
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
            return View(hangHoa);
        }

        // GET: Admins/HangHoas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.HangHoas == null)
            {
                return NotFound();
            }

            var hangHoa = await _context.HangHoas
                .FirstOrDefaultAsync(m => m.MaHangHoa == id);
            if (hangHoa == null)
            {
                return NotFound();
            }

            return View(hangHoa);
        }

        // POST: Admins/HangHoas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.HangHoas == null)
            {
                return Problem("Entity set 'ProductContext.HangHoas'  is null.");
            }
            var hangHoa = await _context.HangHoas.FindAsync(id);
            if (hangHoa != null)
            {
                _context.HangHoas.Remove(hangHoa);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HangHoaExists(int id)
        {
          return (_context.HangHoas?.Any(e => e.MaHangHoa == id)).GetValueOrDefault();
        }
    }
}
