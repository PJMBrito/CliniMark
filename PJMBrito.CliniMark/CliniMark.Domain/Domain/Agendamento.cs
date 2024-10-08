namespace CliniMark.Domain.Domain
{
    internal class Agendamento
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
        public Agendamento(Guid id, Guid clienteId, Guid especialidadeId, Guid colaboradorId, DateTime dataMarcacao, Cliente cliente, Especialidade especialidade, Colaborador colaborador)
        {
            Id = id;
            ClienteId = clienteId;
            EspecialidadeId = especialidadeId;
            ColaboradorId = colaboradorId;
            DataMarcacao = dataMarcacao;
            Cliente = cliente;
            Especialidade = especialidade;
            Colaborador = colaborador;
        }
    }
}
