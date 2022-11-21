using InformeTqERegiao.Entidades;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace InformeTqERegiao.Controllers
{
    
    public class UsuariosPermissoesController : Controller
    {
        private readonly Contexto db;
        public UsuariosPermissoesController(Contexto contexto)
        {
            db = contexto;
        }

        [HttpGet("[controller]/[action]/{UsuarioId}/{PermissaoId}")]
        public IActionResult Adicionar(int UsuarioId,int PermissaoId)
        {
            Usuarios_Permissoes novo = new Usuarios_Permissoes();
            novo.UsuarioId = UsuarioId;
            novo.PermissaoId = PermissaoId;
            db.USUARIOS_PERMISSOES.Add(novo);
            db.SaveChanges();
            return Redirect("/Usuarios");
            
        }
    }
}
