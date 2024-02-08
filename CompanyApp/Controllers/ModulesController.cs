using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CompanyApp.Data;
using CompanyApp.Models;
using Microsoft.AspNetCore.Authorization;

namespace CompanyApp.Controllers
{
    public class ModulesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ModulesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Modules
        [Authorize(Roles = "Admin, Manager")]
        public async Task<IActionResult> Index()
        {
            ViewBag.Completed = new List<int>();
            return View(await _context.Modules.ToListAsync());
        }

        public async Task<IActionResult> UserModules()
        {
            var user = await _context.Users.Include(x => x.Modules).FirstOrDefaultAsync(x => x.UserName == User.Identity.Name);
            ViewBag.Completed = await _context.ModuleUser.Where(x => x.UsersId == user.Id && x.Completed).Select(x => x.ModulesId).ToListAsync();
            return View("Index", user.Modules.ToList());
        }

        // GET: Modules/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Modules == null)
            {
                return NotFound();
            }

            var @module = await _context.Modules
                .FirstOrDefaultAsync(m => m.Id == id);
            if (@module == null)
            {
                return NotFound();
            }

            return View(@module);
        }

        // GET: Modules/Create
        [Authorize(Roles = "Admin, Manager")]
        public IActionResult Create()
        {
            return View();
        }

        // POST: Modules/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin, Manager")]
        public async Task<IActionResult> Create([Bind("Id,Name,Desctription,Type")] Module @module)
        {
            if (ModelState.IsValid)
            {
                _context.Add(@module);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(@module);
        }

        // GET: Modules/Edit/5
        [Authorize(Roles = "Admin, Manager")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Modules == null)
            {
                return NotFound();
            }

            var @module = await _context.Modules.FindAsync(id);
            if (@module == null)
            {
                return NotFound();
            }
            return View(@module);
        }

        // POST: Modules/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin, Manager")]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Desctription,Type")] Module @module)
        {
            if (id != @module.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(@module);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ModuleExists(@module.Id))
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
            return View(@module);
        }

        // GET: Modules/Delete/5
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Modules == null)
            {
                return NotFound();
            }

            var @module = await _context.Modules
                .FirstOrDefaultAsync(m => m.Id == id);
            if (@module == null)
            {
                return NotFound();
            }

            return View(@module);
        }

        // POST: Modules/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Modules == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Modules'  is null.");
            }
            var @module = await _context.Modules.FindAsync(id);
            if (@module != null)
            {
                _context.Modules.Remove(@module);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public IActionResult ShowModuleQuestions(int moduleId)
        {
            var moduleQuestions = _context.Questions.Include(x => x.Module).Where(c => c.Module.Id == moduleId).ToList();
            ViewData["Module"] = _context.Modules.Where(c => c.Id == moduleId).First();
            return View(moduleQuestions);
        }

        [HttpPost]
        public void ShowModuleQuestions(string ModuleId, string Completed)
        {
            bool completed = System.Boolean.Parse(Completed);
            var user = _context.Users.Where(x => x.UserName == User.Identity.Name).FirstOrDefault();
            ModuleUser moduleUser = new ModuleUser()
            {
                UsersId = user.Id,
                ModulesId = int.Parse(ModuleId),
                Completed = completed
            };
            _context.Update(moduleUser);
            _context.SaveChanges();
        }


        private bool ModuleExists(int id)
        {
            return _context.Modules.Any(e => e.Id == id);
        }
    }
}
