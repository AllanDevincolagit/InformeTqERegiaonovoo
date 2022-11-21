using InformeTqERegiao.Entidades;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InformeTqERegiao.Controllers
{
    public class EstabelecimentoController : Controller
    {
        private readonly Contexto db;
        public EstabelecimentoController(Contexto contexto)
        {
            db = contexto;
        }
        // GET: EstabelecimentoController

        // Card Saude

        public ActionResult Index()
        {
            return View(db.ESTABELECIMENTO.ToList());
        }

        public ActionResult Farmacias()
        {
            return View();
        }

        public ActionResult Hospitais()
        {
            return View();
        }

        //FimSaude

        // Card Compras

        public ActionResult Supermercados()
        {
            return View();
        }

        public ActionResult Lojasderoupa()
        {
            return View();
        }

        public ActionResult Camamesaebanho()
        {
            return View();
        }

        public ActionResult Construcaoeutensiliosdomesticos()
        {
            return View();
        }

        public ActionResult Variedades()
        {
            return View();
        }

        //Fim card Compras

        //Card serviços

        public ActionResult Autopecaseoficinasmecanicas()
        {
            return View();
        }

        public ActionResult Concessionarias()
        {
            return View();
        }
        public ActionResult Lojasdevariedades()
        {
            return View();
        }

        //Fim Serviços

        // GET: EstabelecimentoController/Details/5
        public ActionResult Details(int id)
        {
            return View(db.ESTABELECIMENTO.Where(a => a.id == id).FirstOrDefault());
        }

        // GET: EstabelecimentoController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EstabelecimentoController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(estabelecimento collection)
        {
            try
            {
                db.ESTABELECIMENTO.Add(collection);
                db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EstabelecimentoController/Edit/5
        public ActionResult Edit(int id)
        {
            return View(db.ESTABELECIMENTO.Where(a => a.id == id).FirstOrDefault());
        }

        // POST: EstabelecimentoController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, estabelecimento collection)
        {
            try
            {
                db.ESTABELECIMENTO.Update(collection);
                db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EstabelecimentoController/Delete/5
        public ActionResult Delete(int id)
        {
            db.ESTABELECIMENTO.Remove(db.ESTABELECIMENTO.Where(a => a.id == id).FirstOrDefault());
            db.SaveChanges();
            return View("/Cards/Index");
        }

        // POST: EstabelecimentoController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, estabelecimento collection)
        {
            try
            {
                db.ESTABELECIMENTO.Remove(db.ESTABELECIMENTO.Where(a => a.id == id).FirstOrDefault());
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
