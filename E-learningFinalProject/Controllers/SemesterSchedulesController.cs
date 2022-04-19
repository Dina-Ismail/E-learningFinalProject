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
    [Authorize]

    public class SemesterSchedulesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SemesterSchedulesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: SemesterSchedules
        public async Task<IActionResult> Index()
        {
            return View(await _context.semesterSchedules.ToListAsync());
        }

        // GET: SemesterSchedules/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var semesterSchedule = await _context.semesterSchedules
                .FirstOrDefaultAsync(m => m.SemesterScheduleID == id);
            if (semesterSchedule == null)
            {
                return NotFound();
            }

            return View(semesterSchedule);
        }

        // GET: SemesterSchedules/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: SemesterSchedules/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("SemesterScheduleID,SemesterID,CourseID,ProfessorID,MethodOfDelivery")] SemesterSchedule semesterSchedule)
        {
            if (ModelState.IsValid)
            {
                _context.Add(semesterSchedule);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(semesterSchedule);
        }

        // GET: SemesterSchedules/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var semesterSchedule = await _context.semesterSchedules.FindAsync(id);
            if (semesterSchedule == null)
            {
                return NotFound();
            }
            return View(semesterSchedule);
        }

        // POST: SemesterSchedules/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("SemesterScheduleID,SemesterID,CourseID,ProfessorID,MethodOfDelivery")] SemesterSchedule semesterSchedule)
        {
            if (id != semesterSchedule.SemesterScheduleID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(semesterSchedule);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SemesterScheduleExists(semesterSchedule.SemesterScheduleID))
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
            return View(semesterSchedule);
        }

        // GET: SemesterSchedules/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var semesterSchedule = await _context.semesterSchedules
                .FirstOrDefaultAsync(m => m.SemesterScheduleID == id);
            if (semesterSchedule == null)
            {
                return NotFound();
            }

            return View(semesterSchedule);
        }

        // POST: SemesterSchedules/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var semesterSchedule = await _context.semesterSchedules.FindAsync(id);
            _context.semesterSchedules.Remove(semesterSchedule);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SemesterScheduleExists(int id)
        {
            return _context.semesterSchedules.Any(e => e.SemesterScheduleID == id);
        }
    }
}
