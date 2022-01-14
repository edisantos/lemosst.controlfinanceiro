using lemosst.controlefinanceiro.Domain.Entidades.Contas;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace lemosst.controlefinanceiro.Data
{
    public class UsuarioConfiguration : IEntityTypeConfiguration<Usuarios>
    {
        public void Configure(EntityTypeBuilder<Usuarios> builder)
        {
            builder.ToTable("Users");

            builder.HasKey(k=>k.Id);
            builder.Property(k => k.Id).ValueGeneratedOnAdd();

            builder.Property(ur => ur.FullName)
                .HasColumnType("varchar(50)")
                .IsRequired();

            builder.Property(ur => ur.Endereco)
               .HasColumnType("varchar(50)")
               .IsRequired();

            builder.HasOne(b => b.Bairros)
                .WithMany(ur => ur.Usuarios)
                .HasForeignKey(b => b.BairroId);

            builder.HasOne(b => b.Cidades)
                .WithMany(ur => ur.Usuarios)
                .HasForeignKey(b => b.CidadeId);

            builder.HasOne(b => b.Estados)
                .WithMany(ur => ur.Usuarios)
                .HasForeignKey(b => b.EstadoId);

        }
    }
}
