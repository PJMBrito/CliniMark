namespace CliniMark.Domain.Domain
{
    internal class Colaborador
    {
        public Guid Id { get; set; }

        public required string Nome { get; set; }

        //Relacionamentos
        public List<Agendamento> Agendamentos { get; set; }

        public List<Especialidade> Especialidades { get; set; }


        //Construtor
        public Colaborador(Guid id, string nome)
        {
            Id = id;
            Nome = nome;
        }
    }
}
