using InformeTqERegiao.Entidades;
using InformeTqERegiao.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace InformeTqERegiao.Controllers
{
    public class UsuariosController : Controller
    {
        private readonly Contexto db;
        public UsuariosController(Contexto contexto)
        {
            db = contexto;
        }

        public IActionResult CadLog()
        {
            return View();
        }

        public IActionResult ListaPermissoes(int id)
        {
            ListaPermissoesModel model = new ListaPermissoesModel();
            model.TodasAsPermissoes = db.PERMISSOES.ToList();
            model.UsuarioId = id;
            model.PermissoesUsuario = db.USUARIOS_PERMISSOES.Where(a => a.UsuarioId == id).Include(a => a.permissoes).ToList();
            return View(model);
        }

        public ActionResult Index(string query, string TipoPesquisa)
        {
            if (string.IsNullOrEmpty(query))
            {
                return View(db.USUARIOS.ToList());
            }
            else if(TipoPesquisa == "Todos")
            {
                return View(db.USUARIOS.Where(a=>a.Email.Contains(query) || a.Nome.Contains(query) || a.Sobrenome.Contains(query) || a.CPF.Contains(query)));
            }else if(TipoPesquisa == "Email")
            {
                return View(db.USUARIOS.Where(a => a.Email.Contains(query)));
            }else if(TipoPesquisa == "Nome")
            {
                return View(db.USUARIOS.Where(a => a.Nome.Contains(query)));
            }else if(TipoPesquisa == "Sobrenome")
            {
                return View(db.USUARIOS.Where(a => a.Sobrenome.Contains(query)));
            }else if(TipoPesquisa == "CPF")
            {
                return View(db.USUARIOS.Where(a => a.CPF.Contains(query)));
            }
            else
            {
                return View(db.USUARIOS.ToList());
            }
            
        }

        // GET: UsuariosController/Details/5
        public ActionResult Details(int id)
        {
            return View(db.USUARIOS.Where(a => a.Id == id).FirstOrDefault());
        }

        // GET: UsuariosController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UsuariosController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Usuarios collection)
        {
            try
            {
                db.USUARIOS.Add(collection);
                db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: UsuariosController/Edit/5
        public ActionResult Edit(int id)
        {
            return View(db.USUARIOS.Where(a=>a.Id == id).FirstOrDefault());
        }

        // POST: UsuariosController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Usuarios collection)
        {
            try
            {
                db.USUARIOS.Update(collection);
                db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: UsuariosController/Delete/5
        public ActionResult Delete(int id)
        {
            db.USUARIOS.Remove(db.USUARIOS.Where(a => a.Id == id).FirstOrDefault());
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        // POST: UsuariosController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Usuarios collection)
        {
            try
            {
                db.USUARIOS.Remove(db.USUARIOS.Where(a => a.Id == id).FirstOrDefault());
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
