
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Horarios.DAL.Repositorio
{
    public class Repositorio<T> : IRepositorio<T> where T : class
    {
        protected readonly CnnDbContext Context;
        public DbSet<T> table;

        public Repositorio()
        {
            Context = new CnnDbContext();
            table = Context.Set<T>();
        }
        public Repositorio(CnnDbContext _context)
        {
            Context = _context;
            table = _context.Set<T>();
        }
        public void Add(T obj)
        {
            table.Add(obj);
        }

        public void Delete(object id)
        {
            T existing = table.Find(id);
            table.Remove(existing);
        }

        public IEnumerable<T> GetAll()
        {
            return table.ToList();
        }

        public T GetById(object id)
        {
            return table.Find(id);
        }

        public void Update(T obj)
        {
            table.Attach(obj);
            Context.Entry(obj).State = EntityState.Modified;
        }

        public void Save()
        {
            Context.SaveChanges();
        }
    }
}