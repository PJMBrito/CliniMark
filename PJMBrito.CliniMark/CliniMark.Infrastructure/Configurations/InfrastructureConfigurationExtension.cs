using CliniMark.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;

namespace CliniMark.Infrastructure.Configurations
{
    public static class InfrastructureConfigurationExtension
    {
        public static IServiceCollection ConfigureModuleInfrastructure(this IServiceCollection services, IConfiguration configuration, string assemblyName)
        {
            var connectionString = configuration.GetConnectionString("MinhaConexao");


            services.AddDbContext<CliniMarkContext>(options =>
            options.UseNpgsql(connectionString, npgsqlOptionsAction: sqlOptions =>
            {
                sqlOptions.MigrationsAssembly(assemblyName); // Se você quiser usar um assembly específico para as migrations
            })
        );

            //// Ligação Redis
            //services.AddStackExchangeRedisCache(options =>
            //{
            //    options.Configuration = configuration.GetValue<string?>(SettingsConstants.RedisServerKey);
            //});

            // Configuração global para ignorar loops de referência
            JsonSerializerSettings settings = new JsonSerializerSettings
            {
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            };

            JsonConvert.DefaultSettings = () => settings;

            services.AddScoped<DbContext, CliniMarkContext>();
            

            return services;
        }

        public static IServiceCollection ConfigureModuleInfrastructureOnlyDBContext(this IServiceCollection services, string? connectionStringDB)
        {
            // Ligação BD PostgreSQL
            services.AddDbContext<CliniMarkContext>(option =>
            {
                option.UseNpgsql(connectionStringDB);
            });

            return services;
        }
    }
}
