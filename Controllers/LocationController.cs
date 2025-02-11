using System;
using System.Collections.Generic;
using System.Data;

//using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Crud_Framework_Youtube1.Models;

namespace Crud_Framework_Youtube1.Controllers
{
    public class LocationController : Controller
    {
        // GET: Location
        public ActionResult Index()
        {
            using (DbModel context = new DbModel())
            {
                //return View(context.location.Where(x => x.estado == true).ToList());
                return View(context.location.ToList());
            }
            
        }

        // GET: Location/Details/5
        public ActionResult Details(int id)
        {
            using (DbModel context = new DbModel())
            {
                return View(context.location.Where(x => x.id == id).FirstOrDefault());
            }

        }

        // GET: Location/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Location/Create
        [HttpPost]
        public ActionResult Create(location location)
        {
            try
            {
                // TODO: Add insert logic here
                using (DbModel context = new DbModel())
                {
                    context.location.Add(location);
                    context.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Location/Edit/5
        public ActionResult Edit(int id)
        {
            using (DbModel context = new DbModel())
            {
                return View(context.location.Where(x => x.id == id).FirstOrDefault());
            }
        }

        // POST: Location/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, location location)
        {
            try
            {
                // TODO: Add update logic here
                using (DbModel context = new DbModel())
                {
                    context.Entry(location).State = EntityState.Modified;
                    context.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Location/Delete/5
        public ActionResult Delete(int id)
        {
            using (DbModel context = new DbModel())
            {
                return View(context.location.Where(x => x.id == id).FirstOrDefault());
            }
        }

        // POST: Location/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                using (DbModel context = new DbModel())
                {
                    location location = context.location.Where(x => x.id == id).FirstOrDefault();
                    context.location.Remove(location);
                    context.SaveChanges();
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
