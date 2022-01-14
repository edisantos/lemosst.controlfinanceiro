using lemosst.controlefinanceiro.Domain.Entidades;
using lemosst.controlefinanceiro.Domain.Entidades.Contas;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace lemosst.controlefinanceiro.Data.Contexto
{
    public class DataContexto : IdentityDbContext<Usuarios, Roles, int,
        IdentityUserClaim<int>, UserRoles, IdentityUserLogin<int>,
        IdentityRoleClaim<int>, IdentityUserToken<int>>
    {
        public DataContexto(DbContextOptions options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

        #region Entidades
        public DbSet<Bairros>? Bairros { get; set; }
        public DbSet<Cidades>? Cidades { get; set; }
        public DbSet<Estados>? Estados { get; set; }
        #endregion
    }
}
