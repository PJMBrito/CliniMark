using CliniMark.Domain.Domain.Enums;
using System;
namespace CliniMark.Domain.Domain
{
    internal class Cliente
    {
        public Guid Id { get; set; }

        public required string Nome { get; set; }

        public string? Telefone { get; set; }

        public string? Email { get; set; }

        public Sexo Sexo { get; set; } = Sexo.Indefinido;

        //Relacionamentos
        public List<Agendamento> Agendamentos { get; set; }


        //Construtor
        public Cliente(Guid id, string nome, string? telefone, string? email, Sexo sexo)
        {
            Id = id;
            Nome = nome;
            Telefone = telefone;
            Email = email;
            Sexo = sexo;
        }
    }
}
