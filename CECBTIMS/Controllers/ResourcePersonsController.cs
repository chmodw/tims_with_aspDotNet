﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CECBTIMS.DAL;
using CECBTIMS.Models;

namespace CECBTIMS.Controllers
{
    public class ResourcePersonsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: ResourcePersons
        public async Task<ActionResult> Index()
        {
            var resourcePersons = db.ResourcePersons.Include(r => r.Program);
            return View(await resourcePersons.ToListAsync());
        }

        // GET: ResourcePersons/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new System.Web.Mvc.HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ResourcePerson resourcePerson = await db.ResourcePersons.FindAsync(id);
            if (resourcePerson == null)
            {
                return HttpNotFound();
            }
            return View(resourcePerson);
        }

        // GET: ResourcePersons/Create
        public ActionResult Create(int programId, string programTitle)
        {
            ViewBag.ProgramId = programId;
            ViewBag.ProgramTitle = programTitle;
            return View();
        }

        // POST: ResourcePersons/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Id,Name,Designation,Cost,ProgramId")] ResourcePerson resourcePerson)
        {
            if (ModelState.IsValid)
            {
                db.ResourcePersons.Add(resourcePerson);
                await db.SaveChangesAsync();
            }

            return RedirectToAction($"Details", $"Programs", new { id = resourcePerson.ProgramId });
        }

        // GET: ResourcePersons/Edit/5
        public async Task<ActionResult> Edit(int? id, int? programId, string programTitle)
        {
            if (id == null || programId == null)
            {
                return new System.Web.Mvc.HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ResourcePerson resourcePerson = await db.ResourcePersons.FindAsync(programId);
            Program program = await db.Programs.FindAsync(id);
            if (resourcePerson == null || program == null)
            {
                return HttpNotFound();
            }
            ViewBag.ProgramId = programId;
            ViewBag.ProgramTitle = programTitle;
            return View(resourcePerson);
        }

        // POST: ResourcePersons/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Id,Name,Designation,Cost,ProgramId,RowVersion")] ResourcePerson resourcePerson)
        {
            if (ModelState.IsValid)
            {
                db.Entry(resourcePerson).State = EntityState.Modified;
                await db.SaveChangesAsync();

            }

            return RedirectToAction($"Details", $"Programs", new { id = resourcePerson.ProgramId });
        }

        // POST: ResourcePersons/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(int id, int programId)
        {
            ResourcePerson resourcePerson = await db.ResourcePersons.FindAsync(id);
            db.ResourcePersons.Remove(resourcePerson);
            await db.SaveChangesAsync();

            return RedirectToAction($"Details", $"Programs", new { id = programId });
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
