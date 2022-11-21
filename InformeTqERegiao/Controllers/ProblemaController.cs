using InformeTqERegiao.Entidades;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;


namespace InformeTqERegiao.Controllers
{
    public class ProblemaController : Controller
    {
        private readonly Contexto db;
        public ProblemaController(Contexto contexto)
        {
            db = contexto;
        }

        // GET: ProblemaController
        public ActionResult Index()
        {
            return View(db.PROBLEMA.ToList());
        }

        // GET: ProblemaController/Details/5
        public ActionResult Details(int id)
        {
            return View(db.PROBLEMA.Where(a => a.id == id).FirstOrDefault());
        }

        // GET: ProblemaController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProblemaController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Problema collection)
        {
            try
            {
                db.PROBLEMA.Add(collection);
                db.SaveChanges();
                return RedirectToAction(nameof(Index));
               
            }
            catch
            {
                return View();
            }
        }

        // GET: ProblemaController/Edit/5
        public ActionResult Edit(int id)
        {
            return View(db.PROBLEMA.Where(a => a.id == id).FirstOrDefault());
        }

        // POST: ProblemaController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Permissoes collection)
        {
            try
            {

                db.PERMISSOES.Update(collection);
                db.SaveChanges();
                return RedirectToAction(nameof(Index));
                
            }
            catch
            {
                return View();
            }
        }

        // GET: ProblemaController/Delete/5
        public ActionResult Delete(int id)
        {
            db.PROBLEMA.Remove(db.PROBLEMA.Where(a => a.id == id).FirstOrDefault());
            db.SaveChanges();
            return RedirectToAction("Index");
            
        }

        // POST: ProblemaController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Problema collection)
        {
            try
            {
                db.PROBLEMA.Remove(db.PROBLEMA.Where(a => a.id == id).FirstOrDefault());
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
