using InformeTqERegiao.Entidades;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InformeTqERegiao.Controllers
{
    public class VariedadesController : Controller
    {
        private readonly Contexto db;
        public VariedadesController(Contexto contexto)
        {
            db = contexto;
        }
        // GET: VariedadesController
        public ActionResult Index()
        {
            return View(db.VARIEDADES.ToList());
        }

        // GET: VariedadesController/Details/5
        public ActionResult Details(int id)
        {
            return View(db.VARIEDADES.Where(a => a.Id == id).FirstOrDefault());
        }

        // GET: VariedadesController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: VariedadesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Variedades collection)
        {
            try
            {
                db.VARIEDADES.Add(collection);
                db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: VariedadesController/Edit/5
        public ActionResult Edit(int id)
        {
            return View(db.VARIEDADES.Where(a => a.Id == id).FirstOrDefault());
        }

        // POST: VariedadesController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Variedades collection)
        {
            try
            {

                db.VARIEDADES.Update(collection);
                db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: VariedadesController/Delete/5
        public ActionResult Delete(int id)
        {
            db.VARIEDADES.Remove(db.VARIEDADES.Where(a => a.Id == id).FirstOrDefault());
            return View();
        }

        // POST: VariedadesController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Variedades collection)
        {
            try
            {
                db.VARIEDADES.Remove(db.VARIEDADES.Where(a => a.Id == id).FirstOrDefault());
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
