using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LMS.Web.Data;
using LMS.Web.Models;
using Microsoft.AspNetCore.Authorization;

namespace LMS.Web.Areas.Online.Controllers
{
    [Area("Online")]
   
    public class QuestionAnswersController : Controller
    {
        private readonly ApplicationDbContext _context;
       
        public QuestionAnswersController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Online/QuestionAnswers
        public async Task<IActionResult> Index()
        {
            return View(await _context.QuestionAnswer.ToListAsync());
        }

        public async Task<IActionResult> Index1()
        {
            return View(await _context.QuestionAnswer.ToListAsync());
        }

        // GET: Online/QuestionAnswers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var questionAnswer = await _context.QuestionAnswer
                .FirstOrDefaultAsync(m => m.QuestionAnswerId == id);
            if (questionAnswer == null)
            {
                return NotFound();
            }

            return View(questionAnswer);
        }

        // GET: Online/QuestionAnswers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Online/QuestionAnswers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("QuestionAnswerId,Question,Option1,Option2,Option3,Option4,Answer")] QuestionAnswer questionAnswer)
        {
            if (ModelState.IsValid)
            {
                _context.Add(questionAnswer);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(questionAnswer);
        }

        // GET: Online/QuestionAnswers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var questionAnswer = await _context.QuestionAnswer.FindAsync(id);
            if (questionAnswer == null)
            {
                return NotFound();
            }
            return View(questionAnswer);
        }

        // POST: Online/QuestionAnswers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("QuestionAnswerId,Question,Option1,Option2,Option3,Option4,Answer")] QuestionAnswer questionAnswer)
        {
            if (id != questionAnswer.QuestionAnswerId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(questionAnswer);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!QuestionAnswerExists(questionAnswer.QuestionAnswerId))
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
            return View(questionAnswer);
        }

        // GET: Online/QuestionAnswers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var questionAnswer = await _context.QuestionAnswer
                .FirstOrDefaultAsync(m => m.QuestionAnswerId == id);
            if (questionAnswer == null)
            {
                return NotFound();
            }

            return View(questionAnswer);
        }

        // POST: Online/QuestionAnswers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var questionAnswer = await _context.QuestionAnswer.FindAsync(id);
            _context.QuestionAnswer.Remove(questionAnswer);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool QuestionAnswerExists(int id)
        {
            return _context.QuestionAnswer.Any(e => e.QuestionAnswerId == id);
        }
    }
}
