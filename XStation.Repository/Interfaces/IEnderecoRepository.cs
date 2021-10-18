using System;
using System.Collections.Generic;
using System.Text;
using XStation.Repository.Entities;

namespace XStation.Repository.Interfaces
{
    public interface IEnderecoRepository : IBaseRepository<Endereco>
    {
        Endereco GetByCep(string cep);
    }
}
