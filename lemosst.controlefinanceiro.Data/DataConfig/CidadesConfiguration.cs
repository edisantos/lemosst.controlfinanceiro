using lemosst.controlefinanceiro.Domain.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace lemosst.controlefinanceiro.Data.DataConfig
{
    public class CidadesConfiguration : IEntityTypeConfiguration<Cidades>
    {
        public void Configure(EntityTypeBuilder<Cidades> builder)
        {
            builder.ToTable("Cidades");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).ValueGeneratedOnAdd();

            builder.Property(x => x.NomeCidade)
                .HasColumnType("varchar(50)")
                .IsRequired();
        }
    }
}
