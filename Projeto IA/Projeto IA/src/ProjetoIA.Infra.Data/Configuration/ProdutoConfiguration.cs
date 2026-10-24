
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoIA.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoIA.Infra.Data.Configuration
{
    public class ProdutoConfiguration : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Sku)    .HasMaxLength(20)   .IsRequired();
            builder.Property(p => p.DescricaoResumida)  .HasMaxLength(100)  .IsRequired();
            builder.Property(p => p.DescricaoCompleta)  .HasMaxLength(1000) .IsRequired();
            builder.Property(p => p.Preco)  .HasPrecision(18, scale: 2) .IsRequired();
            builder.Property(p => p.Marca)  .HasMaxLength(50)   .IsRequired();
            builder.ToTable("tbProduto");
        }
    }
}
