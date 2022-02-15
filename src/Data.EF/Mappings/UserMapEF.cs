using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.EF.Mappings
{
    public class UserMapEF : IEntityTypeConfiguration<UserEF>
    {
        public void Configure(EntityTypeBuilder<UserEF> builder)
        {
            builder.ToTable("Usuarios");

            builder.HasKey(p => p.Id);

            builder.HasIndex(p => p.Email)
                .IsUnique();

            builder.Property(p => p.Id).HasColumnName("Codigo");
            builder.Property(p => p.CreationDate).HasColumnName("DataCriacao");
            builder.Property(p => p.Name).HasColumnName("Nome");
            builder.Property(p => p.DeletionDate).HasColumnName("DataDelecao");
            builder.Property(p => p.BrithDate).HasColumnName("DataAniversario");
            builder.Property(p => p.Password).HasColumnName("Senha");
            builder.Property(p => p.Email).HasColumnName("Email");
        }
    }
}
