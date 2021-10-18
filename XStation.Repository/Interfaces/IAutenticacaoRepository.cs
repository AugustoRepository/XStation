using System;
using System.Collections.Generic;
using System.Text;
using XStation.Repository.Entities;

namespace XStation.Repository.Interfaces
{
    public interface IAutenticacaoRepository : IBaseRepository<Autenticacao>
    {
        Autenticacao GetByEmail(string email);
        Autenticacao GetByEmailESenha(string email, string senha);
    }
}
