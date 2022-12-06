using InformeTqERegiao.Entidades;
using Microsoft.AspNetCore.Mvc;

namespace InformeTqERegiao.Controllers
{
    public class AdministradoresPermissoesController : Controller
    {
        private readonly Contexto db;
        public AdministradoresPermissoesController(Contexto contexto) {
            db = contexto;
        }

        [HttpGet("[controller]/[action]/{AdmId}/{PermissaoId}")]
        public IActionResult AdicionarPermissao(int AdmId, int PermissaoId )
        {
            Adm_Permissoes novo = new Adm_Permissoes();
            novo.AdmId= AdmId;
            novo.PermissaoId = PermissaoId;
            db.ADMPERMISSOES.Add( novo );
            db.SaveChanges();
            return Redirect("/adm");
        }
    }
}
