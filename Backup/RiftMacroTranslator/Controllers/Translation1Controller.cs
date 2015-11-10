using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RiftMacroTranslator.Models;

namespace RiftMacroTranslator.Controllers
{
    public class Translation1Controller : Controller
    {
        private Translation1DBContext db = new Translation1DBContext();

        //
        // GET: /Translation1/

        public ActionResult Index()
        {
            return View(db.Translations.ToList());
        }

        //
        // GET: /Translation1/Details/5

        public ActionResult Details(int id = 0)
        {
            Translation1DB translation1db = db.Translations.Find(id);
            if (translation1db == null)
            {
                return HttpNotFound();
            }
            return View(translation1db);
        }

        //
        // GET: /Translation1/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Translation1/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Translation1DB translation1db)
        {
            if (ModelState.IsValid)
            {
                db.Translations.Add(translation1db);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(translation1db);
        }

        //
        // GET: /Translation1/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Translation1DB translation1db = db.Translations.Find(id);
            if (translation1db == null)
            {
                return HttpNotFound();
            }
            return View(translation1db);
        }

        //
        // POST: /Translation1/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Translation1DB translation1db)
        {
            if (ModelState.IsValid)
            {
                db.Entry(translation1db).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(translation1db);
        }

        //
        // GET: /Translation1/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Translation1DB translation1db = db.Translations.Find(id);
            if (translation1db == null)
            {
                return HttpNotFound();
            }
            return View(translation1db);
        }

        //
        // POST: /Translation1/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Translation1DB translation1db = db.Translations.Find(id);
            db.Translations.Remove(translation1db);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}