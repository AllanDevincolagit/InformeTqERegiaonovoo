namespace InformeTqERegiao.Entidades
{
    public class Adm_Permissoes
    {
        public int Id { get; set; }
        public int AdmId { get; set; }
        public int PermissaoId { get; set; }
        public adm administrador { get; set; }
        public Permissaoadm Permissaoadm { get; set; }
    }
}
