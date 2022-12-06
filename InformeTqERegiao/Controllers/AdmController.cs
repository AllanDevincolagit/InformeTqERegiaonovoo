using InformeTqERegiao.Entidades;
using InformeTqERegiao.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace InformeTqERegiao.Controllers
{
    public class AdmController : Controller
    {
        private readonly Contexto db;
        public AdmController(Contexto contexto)
        {
            db = contexto;
        }
        // GET: AdmController

    
        public ActionResult Index()
        {
            return View(db.ADMINISTRADOR.ToList());
        }

        // GET: AdmController/Details/5
        public ActionResult Details(int id)
        {
            return View(db.ADMINISTRADOR.Where(a => a.Id == id).FirstOrDefault());
        }

        // GET: AdmController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AdmController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(adm collection)
        {
            try
            {
                db.ADMINISTRADOR.Add(collection);
                db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AdmController/Edit/5
        public ActionResult Edit(int id)
        {
            return View(db.ADMINISTRADOR.Where(a => a.Id == id).FirstOrDefault());
        }

        // POST: AdmController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, adm collection)
        {
            try
            {
                db.ADMINISTRADOR.Update(collection);
                db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AdmController/Delete/5
        public ActionResult Delete(int id)
        {
            db.ADMINISTRADOR.Remove(db.ADMINISTRADOR.Where(a => a.Id == id).FirstOrDefault());
            db.SaveChanges();
            return View();
        }

        // POST: AdmController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
