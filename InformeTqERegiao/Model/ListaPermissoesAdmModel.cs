using InformeTqERegiao.Entidades;
using System.Collections.Generic;

namespace InformeTqERegiao.Model
{
    public class ListaPermissoesAdmModel
    {
        public List<adm> TodasPermissoes { get; set; }
        public List<Permissaoadm> PermissoesdoAdm { get; set; }
    }
}
