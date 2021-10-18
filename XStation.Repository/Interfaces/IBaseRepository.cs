using System;
using System.Collections.Generic;
using System.Text;

namespace XStation.Repository.Interfaces
{
    public interface IBaseRepository<T>
    {
        void Insert(T obj);
        void Update(T obj);
        void Excluir(int id);

        List<T> GetAll();
        T GetById(int id);
    }
}
