using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AspNetCore_CanberraRestaurants_WebApp.Data;
using AspNetCore_CanberraRestaurants_WebApp.Models;

namespace AspNetCore_CanberraRestaurants_WebApp.Controllers
{
    public class ReviewsForumsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ReviewsForumsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: ReviewsForums
        public async Task<IActionResult> Index()
        {
            return View(await _context.ReviewsForum.ToListAsync());
        }

        // GET: ReviewsForums/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reviewsForum = await _context.ReviewsForum
                .FirstOrDefaultAsync(m => m.Id == id);
            if (reviewsForum == null)
            {
                return NotFound();
            }

            return View(reviewsForum);
        }

        // GET: ReviewsForums/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ReviewsForums/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,PostDate,UserName,TopicTitle,MessageContent")] ReviewsForum reviewsForum)
        {
            if (ModelState.IsValid)
            {
                _context.Add(reviewsForum);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(reviewsForum);
        }

        // GET: ReviewsForums/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reviewsForum = await _context.ReviewsForum.FindAsync(id);
            if (reviewsForum == null)
            {
                return NotFound();
            }
            return View(reviewsForum);
        }

        // POST: ReviewsForums/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,PostDate,UserName,TopicTitle,MessageContent")] ReviewsForum reviewsForum)
        {
            if (id != reviewsForum.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(reviewsForum);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ReviewsForumExists(reviewsForum.Id))
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
            return View(reviewsForum);
        }

        // GET: ReviewsForums/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reviewsForum = await _context.ReviewsForum
                .FirstOrDefaultAsync(m => m.Id == id);
            if (reviewsForum == null)
            {
                return NotFound();
            }

            return View(reviewsForum);
        }

        // POST: ReviewsForums/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var reviewsForum = await _context.ReviewsForum.FindAsync(id);
            _context.ReviewsForum.Remove(reviewsForum);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ReviewsForumExists(int id)
        {
            return _context.ReviewsForum.Any(e => e.Id == id);
        }
    }
}
