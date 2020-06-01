using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ClassLibrary;

namespace Umbracofinal.Controllers
{
    public class SubmisssionsController : Controller
    {
        private readonly UmbracoContext _context;

        public SubmisssionsController(UmbracoContext context)
        {
            _context = context;
        }

        // GET: Submisssions
        public async Task<IActionResult> Index()
        {
            return View(await _context.Submissions.ToListAsync());
        }

        // GET: Submisssions/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var submisssion = await _context.Submissions
                .FirstOrDefaultAsync(m => m.Id == id);
            if (submisssion == null)
            {
                return NotFound();
            }

            return View(submisssion);
        }

        // GET: Submisssions/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Submisssions/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Age,FirstName,LastName,Email,SerialNumber")] Submisssion submisssion)
        {
            if (ModelState.IsValid)
            {
                _context.Add(submisssion);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(submisssion);
        }

        // GET: Submisssions/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var submisssion = await _context.Submissions.FindAsync(id);
            if (submisssion == null)
            {
                return NotFound();
            }
            return View(submisssion);
        }

        // POST: Submisssions/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Age,FirstName,LastName,Email,SerialNumber")] Submisssion submisssion)
        {
            if (id != submisssion.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(submisssion);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SubmisssionExists(submisssion.Id))
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
            return View(submisssion);
        }

        // GET: Submisssions/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var submisssion = await _context.Submissions
                .FirstOrDefaultAsync(m => m.Id == id);
            if (submisssion == null)
            {
                return NotFound();
            }

            return View(submisssion);
        }

        // POST: Submisssions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var submisssion = await _context.Submissions.FindAsync(id);
            _context.Submissions.Remove(submisssion);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SubmisssionExists(int id)
        {
            return _context.Submissions.Any(e => e.Id == id);
        }
    }
}
