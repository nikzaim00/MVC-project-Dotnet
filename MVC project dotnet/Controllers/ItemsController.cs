﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MVC_project_dotnet;

namespace MVC_project_dotnet.Controllers
{
    public class ItemsController : Controller
    {
        private Entities5 db = new Entities5();

        // GET: Items
        [Authorize]
        public ActionResult Index()
        {
           
            var items = db.Items.Include(i => i.TSNUser);
            return View(items.ToList());
        }

        // GET: Items/Details/5
        [Authorize]
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Item item = db.Items.Find(id);
            if (item == null)
            {
                return HttpNotFound();
            }
            return View(item);
        }

        [Authorize]
        // GET: Items/Create
        public ActionResult Create()
        {
            ViewBag.Id = new SelectList(db.TSNUsers, "Id", "Email");
            return View();
        }

        [Authorize]
        // POST: Items/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ItemID,ItemName,ItemDesc,ItemPicture,Id")] Item item,HttpPostedFileBase File1)
        {
            if (File1 != null && File1.ContentLength > 0)
            {
                item.ItemPicture = new byte[File1.ContentLength]; // file1 to store image in binary formate  
                File1.InputStream.Read(item.ItemPicture, 0, File1.ContentLength);
            }
                if (ModelState.IsValid)
                {
                db.Items.Add(item);
                db.SaveChanges();
                return RedirectToAction("Index");
                }

            ViewBag.Id = new SelectList(db.TSNUsers, "Id", "Email", item.Id);
            return View(item);
        }

        [Authorize]
        // GET: Items/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Item item = db.Items.Find(id);
            if (item == null)
            {
                return HttpNotFound();
            }
            ViewBag.Id = new SelectList(db.TSNUsers, "Id", "Email", item.Id);
            return View(item);
        }

        [Authorize]
        // POST: Items/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ItemID,ItemName,ItemDesc,ItemPicture,Id")] Item item)
        {
            if (ModelState.IsValid)
            {
                db.Entry(item).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Id = new SelectList(db.TSNUsers, "Id", "Email", item.Id);
            return View(item);
        }

        [Authorize]
        // GET: Items/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Item item = db.Items.Find(id);
            if (item == null)
            {
                return HttpNotFound();
            }
            return View(item);
        }

        [Authorize]
        // POST: Items/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Item item = db.Items.Find(id);
            db.Items.Remove(item);
            db.SaveChanges();
            return RedirectToAction("Index");
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
