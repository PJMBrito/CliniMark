using System.Reflection.PortableExecutable;

namespace CliniMark.Domain.Domain
{
    internal class Especialidade
    {
        public Guid Id { get; set; }

        public string Descricao { get; set; }

        //Relacionamentos
        public List<Agendamento> Agendamentos { get; set; }

        public List<Colaborador> Colaboradores { get; set; }

        //Construtor
        public Especialidade(Guid id, string descricao)
        {
            Id = id;
            Descricao = descricao;
        }
    }
}
