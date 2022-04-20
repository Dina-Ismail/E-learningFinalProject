using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using E_learningFinalProject.Data;
using E_learningFinalProject.Models;
using Microsoft.AspNetCore.Authorization;

namespace E_learningFinalProject.Controllers
{
    [Authorize(Policy = "AdminRolePolicy")]
    [Authorize(Policy = "OfficeRolePolicy")]

    public class StudentSchedulesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public StudentSchedulesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: StudentSchedules
        public async Task<IActionResult> Index()
        {
            return View(await _context.studentSchedules.ToListAsync());
        }

        // GET: StudentSchedules/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var studentSchedule = await _context.studentSchedules
                .FirstOrDefaultAsync(m => m.StudentScheduleID == id);
            if (studentSchedule == null)
            {
                return NotFound();
            }

            return View(studentSchedule);
        }

        // GET: StudentSchedules/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: StudentSchedules/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("StudentScheduleID,SemesterScheduleID,StudentID,FinalGrade,Comment")] StudentSchedule studentSchedule)
        {
            if (ModelState.IsValid)
            {
                _context.Add(studentSchedule);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(studentSchedule);
        }

        // GET: StudentSchedules/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var studentSchedule = await _context.studentSchedules.FindAsync(id);
            if (studentSchedule == null)
            {
                return NotFound();
            }
            return View(studentSchedule);
        }

        // POST: StudentSchedules/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("StudentScheduleID,SemesterScheduleID,StudentID,FinalGrade,Comment")] StudentSchedule studentSchedule)
        {
            if (id != studentSchedule.StudentScheduleID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(studentSchedule);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StudentScheduleExists(studentSchedule.StudentScheduleID))
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
            return View(studentSchedule);
        }

        // GET: StudentSchedules/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var studentSchedule = await _context.studentSchedules
                .FirstOrDefaultAsync(m => m.StudentScheduleID == id);
            if (studentSchedule == null)
            {
                return NotFound();
            }

            return View(studentSchedule);
        }

        // POST: StudentSchedules/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var studentSchedule = await _context.studentSchedules.FindAsync(id);
            _context.studentSchedules.Remove(studentSchedule);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool StudentScheduleExists(int id)
        {
            return _context.studentSchedules.Any(e => e.StudentScheduleID == id);
        }
    }
}
