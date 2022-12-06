using InformeTqERegiao.Entidades;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InformeTqERegiao.Controllers
{
    public class SupermercadosController : Controller
    {
        private readonly Contexto db;
        public SupermercadosController(Contexto contexto)
        {
            db = contexto;
        }

        // GET: SupermercadosController

        public IActionResult SucessoCreate()
        {
            return View();
        }

        public IActionResult CarvalhoUm()
        {
            return View();
        }

        public IActionResult CarvalhoDois()
        {
            return View();
        }

        public IActionResult IpirangaUm()
        {
            return View();
        }

        public IActionResult IpirangaDois()
        {
            return View();
        }

        public IActionResult IpirangaTres()
        {
            return View();
        }

        public IActionResult Vencedor()
        {
            return View();
        }

        public IActionResult Dia()
        {
            return View();
        }

        public IActionResult Iquegami()
        {
            return View();
        }

        public IActionResult CompreFacil()
        {
            return View();
        }
        public ActionResult Index()
        {
            return View(db.SUPERMERCADOS.ToList());
        }

        // GET: SupermercadosController/Details/5
        public ActionResult Details(int id)
        {
            return View(db.SUPERMERCADOS.Where(a => a.Id == id).FirstOrDefault());
        }

        // GET: SupermercadosController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SupermercadosController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Supermercados collection)
        {
            try
            {
                db.SUPERMERCADOS.Add(collection);
                db.SaveChanges();
                return RedirectToAction(nameof(SucessoCreate));
            }
            catch
            {
                return View();
            }
        }

        // GET: SupermercadosController/Edit/5
        public ActionResult Edit(int id)
        {
            return View(db.SUPERMERCADOS.Where(a => a.Id == id).FirstOrDefault());
        }

        // POST: SupermercadosController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Supermercados collection)
        {
            try
            {
                db.SUPERMERCADOS.Update(collection);
                db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: SupermercadosController/Delete/5
        public ActionResult Delete(int id)
        {
            db.SUPERMERCADOS.Remove(db.SUPERMERCADOS.Where(a => a.Id == id).FirstOrDefault());
            db.SaveChanges();
            return RedirectToAction("Index");
           
        }

        // POST: SupermercadosController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Supermercados collection)
        {
            try
            {

                db.SUPERMERCADOS.Remove(db.SUPERMERCADOS.Where(a => a.Id == id).FirstOrDefault());
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
