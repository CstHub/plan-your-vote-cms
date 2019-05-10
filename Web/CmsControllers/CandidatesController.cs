﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Web.Models;
using Web.Data;

namespace Web
{
    [Authorize]
    public class CandidatesController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly int _currentElection;

        public CandidatesController(ApplicationDbContext context)
        {
            _context = context;
            _currentElection = _context.StateSingleton.Find(State.STATE_ID).CurrentElection;
        }

        // GET: Candidates
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Candidates
                .Where(c => c.ElectionId == _currentElection)
                .Include(c => c.Organization).Include(c => c.Contacts).Include(c => c.CandidateRaces);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Candidates/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var candidate = await _context.Candidates
                .Include(c => c.Organization).Include(c => c.CandidateRaces)
                .FirstOrDefaultAsync(m => m.CandidateId == id);
            if (candidate == null)
            {
                return NotFound();
            }

            return View(candidate);
        }

        // GET: Candidates/Create
        public IActionResult Create()
        {
            ViewData["OrganizationId"] = new SelectList(_context.Organizations, "OrganizationId", "OrganizationId");
            return View();
        }

        // POST: Candidates/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(string name, IFormFile image, int organizationId)
        {
            var fileName = "";
            var nameOfile = "";
            if (image != null)
            {
                if (image.ContentType != "image/jpeg"
                        && image.ContentType != "image/png"
                        && image.ContentType != "image/gif")
                {
                    ViewData["ImageMessage"] = "Invalid image type. Image must be a JPEG, GIF, or PNG.";
                    ViewData["OrganizationId"] = new SelectList(_context.Organizations, "OrganizationId", "OrganizationId");
                    return View();
                }

                if (image.Length < 4500)
                {
                    ViewData["ImageMessage"] = "Invalid image size. Image must be a minimum size of 5KB.";
                    ViewData["OrganizationId"] = new SelectList(_context.Organizations, "OrganizationId", "OrganizationId");
                    return View();
                }

                nameOfile = "images\\" + GenerateImageId() + Path.GetFileName(image.FileName);
                fileName = "wwwroot\\" + nameOfile;
                image.CopyTo(new FileStream(fileName, FileMode.Create));
            }
            var candidate = new Candidate();
            candidate.Name = name;
            candidate.Picture = nameOfile;
            candidate.OrganizationId = organizationId;
            candidate.ElectionId = _context.StateSingleton.Find(State.STATE_ID).CurrentElection;
            if (ModelState.IsValid)
            {
                _context.Add(candidate);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["OrganizationId"] = new SelectList(_context.Organizations, "Name", "Name", candidate.OrganizationId);
            return View(candidate);
        }

        public static string GenerateImageId()
        {
            Random R = new Random();
            string strDateTimeNumber = DateTime.Now.ToString("yyyyMMddHHmmssms");
            string strRandomResult = R.Next(1, 1000).ToString();
            return strDateTimeNumber + strRandomResult;
        }

        // GET: Candidates/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var candidate = await _context.Candidates.FindAsync(id);
            if (candidate == null)
            {
                return NotFound();
            }
            ViewData["OrganizationId"] = new SelectList(_context.Organizations, "OrganizationId", "OrganizationId", candidate.OrganizationId);
            return View(candidate);
        }

        // POST: Candidates/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CandidateId,Name,OrganizationId")] Candidate candidate, IFormFile image)
        {
            if (id != candidate.CandidateId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                if (image != null)
                {
                    if (image.ContentType != "image/jpeg" 
                        && image.ContentType != "image/png" 
                        && image.ContentType != "image/gif")
                    {
                        ViewData["ImageMessage"] = "Invalid image type. Image must be a JPEG, GIF, or PNG.";
                        ViewData["OrganizationId"] = new SelectList(_context.Organizations, "OrganizationId", "OrganizationId", candidate.OrganizationId);
                        return View(candidate);
                    }

                    if (image.Length < 4500)
                    {
                        ViewData["ImageMessage"] = "Invalid image size. Image must be a minimum size of 5KB.";
                        ViewData["OrganizationId"] = new SelectList(_context.Organizations, "OrganizationId", "OrganizationId", candidate.OrganizationId);
                        return View(candidate);
                    }

                    string nameOfile = "images\\" + GenerateImageId() + Path.GetFileName(image.FileName);
                    string fileName = "wwwroot\\" + nameOfile;
                    image.CopyTo(new FileStream(fileName, FileMode.Create));
                    candidate.Picture = nameOfile;
                }
                else
                {
                    var existing = _context.Candidates
                        .Where(c => c.CandidateId == id)
                        .Select(c => new { Pic = c.Picture });
                    foreach (var result in existing)
                    {
                        candidate.Picture = result.Pic;
                    }
                }

                try
                {
                    _context.Update(candidate);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CandidateExists(candidate.CandidateId))
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
            ViewData["OrganizationId"] = new SelectList(_context.Organizations, "OrganizationId", "OrganizationId", candidate.OrganizationId);
            return View(candidate);
        }

        // GET: Candidates/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var candidate = await _context.Candidates
                .Include(c => c.Organization)
                .FirstOrDefaultAsync(m => m.CandidateId == id);
            if (candidate == null)
            {
                return NotFound();
            }

            return View(candidate);
        }

        // POST: Candidates/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var candidate = await _context.Candidates.FindAsync(id);
            _context.Candidates.Remove(candidate);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CandidateExists(int id)
        {
            return _context.Candidates.Any(e => e.CandidateId == id);
        }
    }
}
