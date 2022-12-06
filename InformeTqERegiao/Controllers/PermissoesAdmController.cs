using InformeTqERegiao.Entidades;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace InformeTqERegiao.Controllers
{
    public class PermissoesAdmController : Controller
    {
        private readonly Contexto db;
        public PermissoesAdmController(Contexto contexto)
        {
            db = contexto;
        }
        // GET: PermissoesAdmController
        public ActionResult Index()
        {
            return View(db.PERMADM.ToList());
        }

        // GET: PermissoesAdmController/Details/5
        public ActionResult Details(int id)
        {
            return View(db.PERMADM.Where(a => a.Id == id).FirstOrDefault());
        }

        // GET: PermissoesAdmController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PermissoesAdmController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Permissaoadm collection)
        {
            try
            {
                db.PERMADM.Add(collection);
                db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PermissoesAdmController/Edit/5
        public ActionResult Edit(int id)
        {
            return View(db.PERMADM.Where(a => a.Id == id).FirstOrDefault());
        }

        // POST: PermissoesAdmController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Permissaoadm collection)
        {
            try
            {
                db.PERMADM.Update(collection);
                db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PermissoesAdmController/Delete/5
        public ActionResult Delete(int id)
        {
            return View(db.PERMADM.Remove(db.PERMADM.Where(a => a.Id == id).FirstOrDefault()));
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        // POST: PermissoesAdmController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Permissaoadm collection)
        {
            try
            {
                db.PERMADM.Remove(db.PERMADM.Where(a => a.Id == id).FirstOrDefault());
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
