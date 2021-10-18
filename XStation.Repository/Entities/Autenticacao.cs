using System;
using System.Collections.Generic;
using System.Text;

namespace XStation.Repository.Entities
{
    public class Autenticacao
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }

        #region Relacionamento

        public Funcionario Funcionario { get; set; }
        public Cliente Cliente { get; set; }

        #endregion
    }
}
