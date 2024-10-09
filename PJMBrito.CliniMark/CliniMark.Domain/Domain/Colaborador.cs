namespace CliniMark.Domain.Domain
{
    public class Colaborador
    {
        public Guid Id { get; set; }

        public string Nome { get; set; }

        //Relacionamentos
        public IEnumerable<Agendamento> Agendamentos { get; set; }

        public IEnumerable<Especialidade> Especialidades { get; set; }

        //Construtor
        public Colaborador()
        {
        }

        public Colaborador(string nome)
        {
            Nome = nome;
        }
    }
}
