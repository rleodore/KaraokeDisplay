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
using KaraokeDisplay.Models.KaraokeViewModels;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

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
        public async Task<IActionResult> Index(string search, char x)
        {
           
            var artists = from s in _context.KaraokeModel
                           select s;
            if (!String.IsNullOrEmpty(search))
            {
                artists = artists.Where(s => s.Artist.Contains(search));
                return View(await artists.ToListAsync());
            }
            else if(!Char.IsWhiteSpace(x)) 
            {
                return (Link(x));
            }
            return View();
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
        //GET - Link
        public IActionResult Link(char x)
        {
            var artist = from s in _context.KaraokeModel
                         select s;
            switch (x)
            {
                case 'A':
                    {
                        artist = from s in _context.KaraokeModel
                                      where s.Artist.StartsWith("A")
                                      select s;
                        break;
                    }
                case 'B':
                    {
                        artist = from s in _context.KaraokeModel
                                      where s.Artist.StartsWith("B")
                                      select s;
                        break;
                    }
                case 'C':
                    {
                        artist = from s in _context.KaraokeModel
                                      where s.Artist.StartsWith("C")
                                      select s;
                        break;
                    }
                case 'D':
                    {
                        artist = from s in _context.KaraokeModel
                                      where s.Artist.StartsWith("D")
                                      select s;
                        break;
                    }
                case 'E':
                    {
                        artist = from s in _context.KaraokeModel
                                      where s.Artist.StartsWith("E")
                                      select s;
                        break;
                    }
                case 'F':
                    {
                        artist = from s in _context.KaraokeModel
                                      where s.Artist.StartsWith("F")
                                      select s;
                        break;
                    }
                case 'G':
                    {
                        artist = from s in _context.KaraokeModel
                                      where s.Artist.StartsWith("G")
                                      select s;
                        break;
                    }
                case 'H':
                    {
                        artist = from s in _context.KaraokeModel
                                      where s.Artist.StartsWith("H")
                                      select s;
                        break;
                    }
                case 'I':
                    {
                        artist = from s in _context.KaraokeModel
                                      where s.Artist.StartsWith("I")
                                      select s;
                        break;
                    }
                case 'J':
                    {
                        artist = from s in _context.KaraokeModel
                                      where s.Artist.StartsWith("J")
                                      select s;
                        break;
                    }
                case 'K':
                    {
                        artist = from s in _context.KaraokeModel
                                      where s.Artist.StartsWith("K")
                                      select s;
                        break;
                    }
                case 'L':
                    {
                        artist = from s in _context.KaraokeModel
                                      where s.Artist.StartsWith("L")
                                      select s;
                        break;
                    }
                case 'M':
                    {
                       artist = from s in _context.KaraokeModel
                                      where s.Artist.StartsWith("M")
                                      select s;
                        break;
                    }
                case 'N':
                    {
                        artist = from s in _context.KaraokeModel
                                      where s.Artist.StartsWith("N")
                                      select s;
                        break;
                    }
                case 'O':
                    {
                        artist = from s in _context.KaraokeModel
                                      where s.Artist.StartsWith("O")
                                      select s;
                        break;
                    }
                case 'P':
                    {
                        artist = from s in _context.KaraokeModel
                                      where s.Artist.StartsWith("P")
                                      select s;
                        break;
                    }
                case 'Q':
                    {
                        artist = from s in _context.KaraokeModel
                                      where s.Artist.StartsWith("Q")
                                      select s;
                        break;
                    }
                case 'R':
                    {
                        artist = from s in _context.KaraokeModel
                                      where s.Artist.StartsWith("R")
                                      select s;
                        break;
                    }
                case 'S':
                    {
                        artist = from s in _context.KaraokeModel
                                      where s.Artist.StartsWith("S")
                                      select s;
                        break;
                    }
                case 'T':
                    {
                        artist = from s in _context.KaraokeModel
                                      where s.Artist.StartsWith("T")
                                      select s;
                        break;
                    }
                case 'U':
                    {
                        artist = from s in _context.KaraokeModel
                                      where s.Artist.StartsWith("U")
                                      select s;
                        break;
                    }
                case 'V':
                    {
                        artist = from s in _context.KaraokeModel
                                      where s.Artist.StartsWith("V")
                                      select s;
                        break;
                    }
                case 'W':
                    {
                        artist = from s in _context.KaraokeModel
                                      where s.Artist.StartsWith("W")
                                      select s;
                        break;
                    }
                case 'X':
                    {
                        artist = from s in _context.KaraokeModel
                                        where s.Artist.StartsWith("X")
                                        select s;
                        break;
                    }
                case 'Y':
                    {
                        artist = from s in _context.KaraokeModel
                                      where s.Artist.StartsWith("Y")
                                      select s;
                        break;
                    }
                case 'Z':
                    {
                        artist = from s in _context.KaraokeModel
                                      where s.Artist.StartsWith("Z")
                                      select s;
                        break;
                    }
                default:
                    {
                        artist = from s in _context.KaraokeModel.Take(441)
                                 select s;
                        break;
                    }
            }
            ViewBag.FirstLetter = x;
            return (View(artist.AsEnumerable()));

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
