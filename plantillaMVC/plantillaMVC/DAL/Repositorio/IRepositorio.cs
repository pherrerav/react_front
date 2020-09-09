using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace plantillaMVC.DAL.Repositorio
{
    public interface IRepositorio<T> where T : class
    {
        IEnumerable<T> GetAll();
        T GetById(object id);
        void Insert(T obj);
        void Update(T obj);
        void Delete(object id);
        void Save();



    }
}