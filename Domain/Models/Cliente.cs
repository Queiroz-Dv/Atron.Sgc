namespace Atron.Sgc.Domain.Models
{
    public class Cliente : IEntity
    {      
        public Cliente(int id, string nomeCompleto, string email, string cpf)
        {
            Id = id;
            NomeCompleto = nomeCompleto;
            Email = email;
            CPF = cpf;
            DataCadastro = DateTime.Now;
            Ativo = true;
        }

        public int Id { get;  set; }
        public string NomeCompleto { get;  set; }
        public string Email { get;  set; }
        public string CPF { get;  set; }
        public string? Telefone { get; set; }
        public DateTime DataCadastro { get; set; }
        public bool Ativo { get; set; } 
    }
}