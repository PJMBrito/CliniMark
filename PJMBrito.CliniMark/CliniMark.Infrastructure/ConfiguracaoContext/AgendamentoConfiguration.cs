using CliniMark.Domain.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CliniMark.Infrastructure.ConfiguracaoContext
{
    public class AgendamentoConfiguration : IEntityTypeConfiguration<Agendamento>
    {
        public void Configure(EntityTypeBuilder<Agendamento> builder)
        {
            builder.ToTable("Agendamentos");

            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id).HasDefaultValueSql("gen_random_uuid()");

            builder
                .HasOne(ag => ag.Especialidade)
                .WithMany(es => es.Agendamentos)
                .HasForeignKey(ag => ag.EspecialidadeId);

            builder
               .HasOne(ag => ag.Cliente)
               .WithMany(c => c.Agendamentos)
               .HasForeignKey(ag => ag.ClienteId);
        }
    }
}