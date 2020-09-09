using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Horarios.DAL.Repositorio
{
    public interface IRepositorio<T> where T : class
    {
        IEnumerable<T> GetAll();
        T GetById(object id);
        void Add(T obj);
        void Update(T obj);
        void Delete(object id);
        void Save();
    }
}