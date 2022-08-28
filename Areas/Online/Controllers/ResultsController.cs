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
using System.Data;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;


namespace LMS.Web.Areas.Online.Controllers
{
    [Area("Online")]


    public class ResultsController : Controller
    {
        private readonly ApplicationDbContext _context;
        public int count;
        public IActionResult Countvalue(Countvalue countvalue)
        {

            
            return View();
        }

        public ResultsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Online/Results
        public async Task<IActionResult> Index()
        {
            return View(await _context.Results.ToListAsync());
        }
        public async Task<IActionResult> CorrectAnswer()
        {
            return View(await _context.Results.ToListAsync());
        }
        // GET: Online/Results
        public async Task<IActionResult> Index1()
        {
            return View(await _context.Results.ToListAsync());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult ShowAnswer()
        {

            var answer1 = "Hyper Text Markup Language";
            var answer2 = "The world wide web Consortium";
            var answer3 = "2";
            var answer4 = "closing tag has a/in front";
            var answer5 = "Break tag";
            var answer6 = "Opening";
            var answer7 = "The home page";
            var answer8 = "Empty element";
            var answer9 = "<img />";
            var answer10 = "Quotation marks";
            var results = this.Request.Form.ToArray();
            try
            {
                if (answer1 == results[0].Value.ToString())
                {
                    count = count + 1;
                }
                if (answer2 == results[1].Value.ToString())
                {
                    count = count + 1;
                }
                if (answer3 == results[2].Value.ToString())
                {
                    count = count + 1;
                }
                if (answer4 == results[3].Value.ToString())
                {
                    count = count + 1;
                }
                if (answer5 == results[4].Value.ToString())
                {
                    count = count + 1;
                }
                if (answer6 == results[5].Value.ToString())
                {
                    count = count + 1;
                }
                if (answer7 == results[6].Value.ToString())
                {
                    count = count + 1;
                }
                if (answer8 == results[7].Value.ToString())
                {
                    count = count + 1;
                }
                if (answer9 == results[8].Value.ToString())
                {
                    count = count + 1;
                }
                if (answer10 == results[9].Value.ToString())
                {
                    count = count + 1;
                }
                if (count == 8)
                {
                    return RedirectToAction("Countvalue");
                }
                else
                {
                    return View();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Some thing went wrong ");
            }
            return View();
        }
        // GET: Online/Results/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var result = await _context.Results
                .FirstOrDefaultAsync(m => m.ResultId == id);
            if (result == null)
            {
                return NotFound();
            }

            return View(result);
        }

        // GET: Online/Results/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Online/Results/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ResultId,ExamName,Marks")] Result result)
        {
            if (ModelState.IsValid)
            {
                _context.Add(result);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(result);
        }

        // GET: Online/Results/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var result = await _context.Results.FindAsync(id);
            if (result == null)
            {
                return NotFound();
            }
            return View(result);
        }

        // POST: Online/Results/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ResultId,ExamName,Marks")] Result result)
        {
            if (id != result.ResultId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(result);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ResultExists(result.ResultId))
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
            return View(result);
        }

        // GET: Online/Results/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var result = await _context.Results
                .FirstOrDefaultAsync(m => m.ResultId == id);
            if (result == null)
            {
                return NotFound();
            }

            return View(result);
        }

        // POST: Online/Results/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var result = await _context.Results.FindAsync(id);
            _context.Results.Remove(result);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ResultExists(int id)
        {
            return _context.Results.Any(e => e.ResultId == id);
        }
    }
}
