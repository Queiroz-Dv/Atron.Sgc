namespace Atron.Sgc.Domain.Models
{
    public class Cliente
    {      
        public Cliente(long id, string nomeCompleto, string email, string cpf)
        {
            Id = id;
            NomeCompleto = nomeCompleto;
            Email = email;
            CPF = cpf;
            DataCadastro = DateTime.Now;
            Ativo = true;
        }

        public long Id { get;  set; }
        public string NomeCompleto { get;  set; }
        public string Email { get;  set; }
        public string CPF { get;  set; }
        public string? Telefone { get; set; }
        public DateTime DataCadastro { get; set; }
        public bool Ativo { get; set; } 
    }
}

/*
 Regras de Negócio:

RN01: O Email deve ser único na base de dados. O sistema não pode permitir o cadastro de dois clientes com o mesmo e-mail.

RN02: O CPF deve ser único. Validações de formato (11 dígitos numéricos) devem ser aplicadas.

RN03: Um cliente pode ser inativado (Ativo = false). Clientes inativos não podem 
realizar novos pedidos, mas seus pedidos antigos devem permanecer no histórico.

RN04: A exclusão de um cliente (exclusão física) só deve ser permitida
se ele não possuir nenhum pedido associado. Caso contrário, apenas a inativação é permitida (exclusão lógica).
 */