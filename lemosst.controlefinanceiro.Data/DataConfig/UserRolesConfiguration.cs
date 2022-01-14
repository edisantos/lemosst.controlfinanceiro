using lemosst.controlefinanceiro.Domain.Entidades.Contas;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace lemosst.controlefinanceiro.Data.DataConfig
{
    public class UserRolesConfiguration : IEntityTypeConfiguration<UserRoles>
    {
        public void Configure(EntityTypeBuilder<UserRoles> builder)
        {
            builder.HasKey(ur => new { ur.UserId, ur.RoleId });

            builder.HasOne(ur => ur.Roles)
                .WithMany(r => r.UserRoles)
                .HasForeignKey(ur => ur.RoleId)
                .IsRequired();

            builder.HasOne(ur => ur.Usuarios)
               .WithMany(r => r.UserRoles)
               .HasForeignKey(ur => ur.UserId)
               .IsRequired();
        }
    }
}
