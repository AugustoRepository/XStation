using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XStation.Repository.Entities;

namespace XStation.Presentation.Model
{
    public class EnderecoModel
    {
        public int Id { get; set; }
        public string Cep { get; set; }
        public string Logradouro { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }

        #region Relacionamento

        public Funcionario Funcionario { get; set; }
        public Cliente Cliente { get; set; }

        #endregion
    }
}
