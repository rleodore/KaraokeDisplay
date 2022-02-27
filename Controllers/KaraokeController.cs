using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using KaraokeDisplay.Data;
using KaraokeDisplay.Models;
using System.Web;

namespace KaraokeDisplay.Controllers
{
    public class KaraokeController : Controller
    {
        private readonly KaraokeDisplayContext _context;

        public KaraokeController(KaraokeDisplayContext context)
        {
            _context = context;
        }

        // GET: Karaoke
        public async Task<IActionResult> Index(string searchString)
        {
            ViewData["CurrentFilter"] = searchString;

            var artists = from s in _context.KaraokeModel
                           select s;
            if (!String.IsNullOrEmpty(searchString))
            {
                artists = artists.Where(s => s.Artist.Contains(searchString));
            }

            List<KaraokeModel> karaokeModels = new List<KaraokeModel>();
            var link = karaokeModels;
            link = SeedKaraoke.getIndex("A");


            return View(await _context.KaraokeModel.ToListAsync());
        }

        // GET: Karaoke/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var karaokeModel = await _context.KaraokeModel
                .FirstOrDefaultAsync(m => m.Id == id);
            if (karaokeModel == null)
            {
                return NotFound();
            }

            return View(karaokeModel);
        }

        // GET: Karaoke/Create
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        
        public async Task<IActionResult> GetLink(string a)
        {
            if(a == null)
            {
                return View(await _context.KaraokeModel.ToListAsync()) ;
            }
            switch (a)
            {
                case "a":
                    return View(SeedKaraoke.getIndex("a"));
                case "b":
                    return View(SeedKaraoke.getIndex("b"));
                case "c":
                    return View(SeedKaraoke.getIndex("c"));
                case "d":
                    return View(SeedKaraoke.getIndex("d"));
                case "e":
                    return View(SeedKaraoke.getIndex("e"));
                case "f":
                    return View(SeedKaraoke.getIndex("f"));
                case "g":
                    return View(SeedKaraoke.getIndex("g"));
                case "h":
                    return View(SeedKaraoke.getIndex("h"));
                case "i":
                    return View(SeedKaraoke.getIndex("i"));
                case "j":
                    return View(SeedKaraoke.getIndex("j"));
                case "k":
                    return View(SeedKaraoke.getIndex("k"));
                case "l":
                    return View(SeedKaraoke.getIndex("l"));
                case "m":
                    return View(SeedKaraoke.getIndex("m"));
                case "n":
                    return View(SeedKaraoke.getIndex("n"));
                case "o":
                    return View(SeedKaraoke.getIndex("o"));
                case "p":
                    return View(SeedKaraoke.getIndex("p"));
                case "q":
                    return View(SeedKaraoke.getIndex("q"));
                case "r":
                    return View(SeedKaraoke.getIndex("r"));
                case "s":
                    return View(SeedKaraoke.getIndex("s"));
                case "t":
                    return View(SeedKaraoke.getIndex("t"));
                case "u":
                    return View(SeedKaraoke.getIndex("u"));
                case "v":
                    return View(SeedKaraoke.getIndex("v"));
                case "w":
                    return View(SeedKaraoke.getIndex("w"));
                case "x":
                    return View(SeedKaraoke.getIndex("x"));
                case "y":
                    return View(SeedKaraoke.getIndex("y"));
                case "z":
                    return View(SeedKaraoke.getIndex("z"));
                default:
                    return View(SeedKaraoke.getIndex("0"));

            }
        }

        // POST: Karaoke/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Artist,Title")] KaraokeModel karaokeModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(karaokeModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(karaokeModel);
        }
        
        // GET: Karaoke/Edit/5

        // POST: Karaoke/Edit/5

        // GET: Karaoke/Delete/5

        private bool KaraokeModelExists(int id)
        {
            return _context.KaraokeModel.Any(e => e.Id == id);
        }
    }
}
