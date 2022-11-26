using InformeTqERegiao.Entidades;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InformeTqERegiao.Controllers
{
    public class RoupasController : Controller
    {
        private readonly Contexto db;
        public RoupasController(Contexto contexto)
        {
            db = contexto;
        }
        // GET: RoupasController
        public ActionResult Index()
        {
            return View(db.ROUPAS.ToList());
        }

        // GET: RoupasController/Details/5
        public ActionResult Details(int id)
        {
            return View(db.ROUPAS.Where(a => a.Id==id).FirstOrDefault());
        }

        // GET: RoupasController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RoupasController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Roupas collection)
        {
            try
            {
                db.ROUPAS.Add(collection);
                db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: RoupasController/Edit/5
        public ActionResult Edit(int id)
        {
            return View(db.ROUPAS.Where(a => a.Id == id).FirstOrDefault());
        }

        // POST: RoupasController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Roupas collection)
        {
            try
            {
                db.ROUPAS.Update(collection);
                db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: RoupasController/Delete/5
        public ActionResult Delete(int id)
        {
            db.ROUPAS.Remove(db.ROUPAS.Where(a => a.Id == id).FirstOrDefault());
            return View();
        }

        // POST: RoupasController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Roupas collection)
        {
            try
            {

                db.ROUPAS.Remove(db.ROUPAS.Where(a => a.Id == id).FirstOrDefault());
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
