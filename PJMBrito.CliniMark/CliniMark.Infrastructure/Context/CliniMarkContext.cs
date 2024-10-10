using CliniMark.Domain.Domain;
using CliniMark.Infrastructure.ConfiguracaoContext;
using Microsoft.EntityFrameworkCore;

namespace CliniMark.Infrastructure.Context
{
    public class CliniMarkContext : DbContext
    {

        public CliniMarkContext(DbContextOptions options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Aqui você especifica o assembly para buscar todas as configurações
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AgendamentoConfiguration).Assembly);


            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Agendamento> Agendamentos { get; set; }

        public DbSet<Cliente> Clientes { get; set; }

        public DbSet<Colaborador> Colaboradores { get; set; }

        public DbSet<Especialidade> Especialidades { get; set; }
    }
}