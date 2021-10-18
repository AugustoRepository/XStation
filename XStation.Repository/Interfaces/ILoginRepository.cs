using System;
using System.Collections.Generic;
using System.Text;
using XStation.Repository.Entities;

namespace XStation.Repository.Interfaces
{
    public interface ILoginRepository : IBaseRepository<Autenticacao>
    {
        Autenticacao GetByIdAndSenha(string login, string senha);
    }
}
