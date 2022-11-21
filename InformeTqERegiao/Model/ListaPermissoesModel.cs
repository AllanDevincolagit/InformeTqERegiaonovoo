using InformeTqERegiao.Entidades;
using System.Collections.Generic;

namespace InformeTqERegiao.Model
{
    public class ListaPermissoesModel
    {

        public int UsuarioId { get; set; }
        public List<Permissoes> TodasAsPermissoes { get; set; }
        public List<Usuarios_Permissoes> PermissoesUsuario { get; set; }
    }
}
