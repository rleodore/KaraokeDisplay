using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using KaraokeDisplay.Data;
using KaraokeDisplay.Models;

namespace KaraokeDisplay.Controllers
{
    public class RequestController : Controller
    {
        private readonly RequestContext _context;

        public RequestController(RequestContext context)
        {
            _context = context;
        }

        // GET: Request
        public async Task<IActionResult> Index()
        {
            return View(await _context.RequestModel.ToListAsync());
        }

        // GET: Request/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var requestModel = await _context.RequestModel
                .FirstOrDefaultAsync(m => m.Id == id);
            if (requestModel == null)
            {
                return NotFound();
            }

            return View(requestModel);
        }

        // GET: Request/Create
        public IActionResult Create(int songId, string artist, string song)
        {

            ViewBag.SongId = songId;
            ViewBag.Artist = artist;
            ViewBag.Song = song;

            return View();
        }

        // POST: Request/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,SongId,RequesterName,Artist,Song")] RequestModel requestModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(requestModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(requestModel);
        }

        // GET: Request/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var requestModel = await _context.RequestModel.FindAsync(id);
            if (requestModel == null)
            {
                return NotFound();
            }
            return View(requestModel);
        }

        // POST: Request/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,SongId,RequesterName,Artist,Song")] RequestModel requestModel)
        {
            if (id != requestModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(requestModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RequestModelExists(requestModel.Id))
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
            return View(requestModel);
        }

        // GET: Request/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var requestModel = await _context.RequestModel
                .FirstOrDefaultAsync(m => m.Id == id);
            if (requestModel == null)
            {
                return NotFound();
            }

            return View(requestModel);
        }

        // POST: Request/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var requestModel = await _context.RequestModel.FindAsync(id);
            _context.RequestModel.Remove(requestModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RequestModelExists(int id)
        {
            return _context.RequestModel.Any(e => e.Id == id);
        }
    }
}
