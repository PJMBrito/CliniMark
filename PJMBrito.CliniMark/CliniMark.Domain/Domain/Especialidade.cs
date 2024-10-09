namespace CliniMark.Domain.Domain
{
    public class Especialidade
    {
        public Guid Id { get; set; }

        public string Descricao { get; set; }

        //Relacionamentos
        public IEnumerable<Agendamento> Agendamentos { get; set; }

        public IEnumerable<Colaborador> Colaboradores { get; set; }

        //Construtor
        public Especialidade()
        {
        }

        public Especialidade(string descricao)
        {
            Descricao = descricao;
        }
    }
}
