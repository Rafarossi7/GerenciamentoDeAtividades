using Microsoft.EntityFrameworkCore;
using GerenciamentoAtividadesApi.Data.Map;
using GerenciamentoAtividadesApi.Models;

namespace GerenciamentoAtividadesApi.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UsuarioMap());
            base.OnModelCreating(modelBuilder);
        }
    }
}










//using Microsoft.EntityFrameworkCore;
//using GerenciamentoAtividadesApi.Models;

//namespace GerenciamentoAtividadesApi.Data
//{
//    public class AppDbContext : DbContext
//    {
//        public AppDbContext(DbContextOptions options) : base(options) { }


//        public DbSet<Usuario> Usuarios { get; set; }

//    }
//}
