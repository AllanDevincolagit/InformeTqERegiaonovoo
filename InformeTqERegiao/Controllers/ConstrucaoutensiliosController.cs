using InformeTqERegiao.Entidades;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InformeTqERegiao.Controllers
{
    public class ConstrucaoutensiliosController : Controller
    {
        private readonly Contexto db;
        public ConstrucaoutensiliosController(Contexto contexto)
        {
            db = contexto;
        }
        // GET: ConstrucaoutensiliosController
        public ActionResult Index()
        {
            return View(db.CONSTRUCAOUTENSILIOS.ToList());
        }

        // GET: ConstrucaoutensiliosController/Details/5
        public ActionResult Details(int id)
        {
            return View(db.CONSTRUCAOUTENSILIOS.Where(a=> a.Id == id).FirstOrDefault());
        }

        // GET: ConstrucaoutensiliosController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ConstrucaoutensiliosController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Construcaoutensilios collection)
        {
            try
            {
                db.CONSTRUCAOUTENSILIOS.Add(collection);
                db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ConstrucaoutensiliosController/Edit/5
        public ActionResult Edit(int id)
        {
            return View(db.CONSTRUCAOUTENSILIOS.Where(a => a.Id == id).FirstOrDefault());
        }

        // POST: ConstrucaoutensiliosController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Construcaoutensilios collection)
        {
            try
            {
                db.CONSTRUCAOUTENSILIOS.Update(collection);
                db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ConstrucaoutensiliosController/Delete/5
        public ActionResult Delete(int id)
        {
            db.CONSTRUCAOUTENSILIOS.Remove(db.CONSTRUCAOUTENSILIOS.Where(a => a.Id == id).FirstOrDefault());
            return View();
        }

        // POST: ConstrucaoutensiliosController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Construcaoutensilios collection)
        {
            try
            {
                db.CONSTRUCAOUTENSILIOS.Remove(db.CONSTRUCAOUTENSILIOS.Where(a => a.Id == id).FirstOrDefault());
                db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
