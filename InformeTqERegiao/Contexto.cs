using Microsoft.EntityFrameworkCore;
using InformeTqERegiao.Entidades;
using InformeTqERegiao.Model;

namespace InformeTqERegiao
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> opt) : base(opt) { }
        public DbSet<Usuarios> USUARIOS { get; set; }
        public DbSet<Permissoes> PERMISSOES { get; set; }
        public DbSet<Cidades> CIDADES { get; set; } 
        public DbSet<Usuarios_Permissoes> USUARIOS_PERMISSOES { get; set; }
        public DbSet<Problema> PROBLEMA { get; set; }
        public DbSet<estabelecimento> ESTABELECIMENTO { get; set; }


    }
}
