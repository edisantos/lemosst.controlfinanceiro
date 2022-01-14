using lemosst.controlefinanceiro.Domain.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemosst.controlefinanceiro.Domain.Data
{
    public class BairrosConfiguration : IEntityTypeConfiguration<Bairros>
    {
        public void Configure(EntityTypeBuilder<Bairros> builder)
        {
            builder.ToTable("Bairros");

            builder.HasKey(x => x.Id);

            builder.Property(x=>x.Id).ValueGeneratedOnAdd();

            builder.Property(x=>x.NomeBarro)
                .HasColumnType("varchar(50)")
                .IsRequired();
        }
    }
}
