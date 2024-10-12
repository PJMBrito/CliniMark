using CliniMark.Aplication.Interfaces;
using CliniMark.Aplication.Views;
using CliniMark.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace CliniMark.Aplication.Services
{
    public class Service : IService
    {
        private CliniMarkContext _context;

        public Service(CliniMarkContext context)
        {
            _context = context;
        }

        public async Task<List<InformacaoViewModel>> ObterColaboradoresAsync()
        {
            return await _context.Colaboradores
                   .Include(c => c.Especialidades)
                   .Select(x => new InformacaoViewModel
                   {
                       NomeColaborador = x.Nome,
                       EspecialidadesNomes = x.Especialidades.Select(e => e.Descricao).ToList()
                   }).ToListAsync();
        }
    }
}
