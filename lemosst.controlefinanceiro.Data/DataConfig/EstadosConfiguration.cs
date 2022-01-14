using lemosst.controlefinanceiro.Domain.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace lemosst.controlefinanceiro.Data.DataConfig
{
    internal class EstadosConfiguration:IEntityTypeConfiguration<Estados>
    {

        public void Configure(EntityTypeBuilder<Estados> builder)
        {
            builder.ToTable("Bairros");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).ValueGeneratedOnAdd();

            builder.Property(x => x.NomeEstado)
                    .HasColumnType("varchar(2)")
                    .IsRequired();
        }
    }
}
