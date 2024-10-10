using CliniMark.Domain.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CliniMark.Infrastructure.ConfiguracaoContext
{
    public class ColaboradorConfiguration : IEntityTypeConfiguration<Colaborador>
    {
        public void Configure(EntityTypeBuilder<Colaborador> builder)
        {
            builder.ToTable("Colaboradores");

            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id).HasDefaultValueSql("gen_random_uuid()");
            builder.Property(c => c.Nome).HasMaxLength(300);

            builder
                .HasMany(c => c.Agendamentos)
                .WithOne(a => a.Colaborador)
                .HasForeignKey(a => a.ColaboradorId);
        }
    }
}