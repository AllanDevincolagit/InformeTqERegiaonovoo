using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InformeTqERegiao.Controllers
{
    public class HospitaisController : Controller
    {
        // GET: HospitaisController
        public ActionResult Index()
        {
            return View();
        }

        // GET: HospitaisController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: HospitaisController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HospitaisController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
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

        // GET: HospitaisController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: HospitaisController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
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

        // GET: HospitaisController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: HospitaisController/Delete/5
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
