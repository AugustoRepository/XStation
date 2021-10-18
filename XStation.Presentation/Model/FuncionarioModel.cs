using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XStation.Repository.Entities;
using XStation.Repository.Enuns;

namespace XStation.Presentation.Model
{
    public class FuncionarioModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Telefone1 { get; set; }
        public string Telefone2 { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime DataNascimento { get; set; }

       

        public Autenticacao Autenticacao { get; set; }

        public Endereco Enderecos { get; set; }

        public TipoUsuarioEnum TipoUsuarioEnum { get; set; }
    }
}
