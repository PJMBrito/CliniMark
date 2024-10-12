using CliniMark.Aplication.Views;

namespace CliniMark.Aplication.Interfaces
{
    public interface IService
    {
        public Task<List<InformacaoViewModel> > ObterColaboradoresAsync();
    }
}
