namespace CliniMark.Domain.Domain
{
    public class Agendamento
    {
        public Guid Id { get; set; }

        public Guid ClienteId { get; set; }

        public Guid EspecialidadeId { get; set; }

        public Guid ColaboradorId { get; set; }

        public DateTime DataMarcacao { get; set; }

        //Relacionamentos
        public Cliente Cliente { get; set; }

        public Especialidade Especialidade { get; set; }

        public Colaborador Colaborador { get; set; }

        //Construtor
        public Agendamento()
        {
        }

        public Agendamento(DateTime dataMarcacao, Cliente cliente, Especialidade especialidade, Colaborador colaborador)
        {
            DataMarcacao = dataMarcacao;
            Cliente = cliente;
            Especialidade = especialidade;
            Colaborador = colaborador;
        }
    }
}
