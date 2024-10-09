using CliniMark.Domain.Domain.Enums;

namespace CliniMark.Domain.Domain
{
    public class Cliente
    {
        public Guid Id { get; set; }

        public string Nome { get; set; }

        public string? Telefone { get; set; }

        public string? Email { get; set; }

        public SexoEnum Sexo { get; set; } = SexoEnum.Indefinido;

        //Relacionamentos
        public IEnumerable<Agendamento> Agendamentos { get; set; }

        //Construtor
        public Cliente()
        {
        }

        public Cliente(string nome, string? telefone, string? email, SexoEnum sexo)
        {
            Nome = nome;
            Telefone = telefone;
            Email = email;
            Sexo = sexo;
        }
    }
}
