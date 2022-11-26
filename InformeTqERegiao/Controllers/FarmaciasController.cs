using InformeTqERegiao.Entidades;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InformeTqERegiao.Controllers
{
    public class FarmaciasController : Controller
    {
        private readonly Contexto db;
        public FarmaciasController(Contexto contexto)
        {
            db = contexto;
        }
        // GET: FarmaciasController

        public IActionResult DrogaRaia()
        {
            return View();
        }

        public IActionResult Farmalar()
        {
            return View();
        }
        public IActionResult DrogaCentro()
        {
            return View();
        }


        public IActionResult FarmaCenter()
        {
            return View();
        }
        public ActionResult Index()
        {
            return View(db.FARMACIAS.ToList());
        }

        // GET: FarmaciasController/Details/5
        public ActionResult Details(int id)
        {
            return View(db.FARMACIAS.Where(a => a.Id == id).FirstOrDefault());
        }

        // GET: FarmaciasController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FarmaciasController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Farmacias collection)
        {
            try
            {
                db.FARMACIAS.Add(collection);
                db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: FarmaciasController/Edit/5
        public ActionResult Edit(int id)
        {
            return View(db.FARMACIAS.Where(a => a.Id == id).FirstOrDefault());
        }

        // POST: FarmaciasController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Farmacias collection)
        {
            try
            {
                db.FARMACIAS.Update(collection);
                db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: FarmaciasController/Delete/5
        public ActionResult Delete(int id)
        {

            db.FARMACIAS.Remove(db.FARMACIAS.Where(a => a.Id == id).FirstOrDefault());
            db.SaveChanges();
            return View();
        }

        // POST: FarmaciasController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Farmacias collection)
        {
            try
            {

                db.FARMACIAS.Remove(db.FARMACIAS.Where(a => a.Id == id).FirstOrDefault());
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
