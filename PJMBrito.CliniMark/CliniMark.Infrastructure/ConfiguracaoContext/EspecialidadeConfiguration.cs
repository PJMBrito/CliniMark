using CliniMark.Domain.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CliniMark.Infrastructure.ConfiguracaoContext
{
    public class EspecialidadeConfiguration : IEntityTypeConfiguration<Especialidade>
    {
        public void Configure(EntityTypeBuilder<Especialidade> builder)
        {
            builder.ToTable("Especialidades");

            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id).HasDefaultValueSql("gen_random_uuid()");
            builder.Property(c => c.Descricao).HasMaxLength(200);

            builder
                .HasMany(e => e.Colaboradores)
                .WithMany(c => c.Especialidades);
        }
    }
}