using CliniMark.Domain.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CliniMark.Infrastructure.ConfiguracaoContext
{
    public class ClienteConfiguration : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.ToTable("Clientes");

            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id).HasDefaultValueSql("gen_random_uuid()");
        }
    }
}