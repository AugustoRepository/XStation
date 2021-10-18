using System;
using System.Collections.Generic;
using System.Text;
using XStation.Repository.Enuns;

namespace XStation.Repository.Entities
{
    public class Funcionario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string  Telefone1{ get; set; }
        public string  Telefone2{ get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime DataNascimento { get; set; }

        #region Relacionamento

        public Autenticacao Autenticacao { get; set; }

        public Endereco Enderecos { get; set; }

        public TipoUsuarioEnum TipoUsuarioEnum { get; set; }
        #endregion
    }
}
