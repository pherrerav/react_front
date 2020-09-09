using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Linq;
using System.Web;

namespace plantillaMVC.DAL.Repositorio
{
    public class Repositorio<T> : IRepositorio<T> where T : class
    {
        private static plantillaDbContext Context;
        public DbSet<T> table;

        public Repositorio()
        {
            Context = new plantillaDbContext();
            table = Context.Set<T>();
        }
        public Repositorio(plantillaDbContext _context)
        {
            Context = _context;
            table = Context.Set<T>();
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

        public void Insert(T obj)
        {
            table.Add(obj);
        }

        public void Save()
        {
            try
            {
                Context.SaveChanges();
            }
            catch (DbEntityValidationException e)
            {
                foreach(var eve in e.EntityValidationErrors)
                {
                    Console.WriteLine("- Property \"{0}\" in state : \"{1}\"",
                        eve.Entry.Entity.GetType().Name, eve.Entry.State);
                    foreach (var ve in eve.ValidationErrors)
                    {
                        Console.WriteLine("- Property \"{0}\" in state : \"{1}\"",
                        ve.PropertyName, ve.ErrorMessage);
                    }
                }
                throw;
            }
        }

        public void Update(T obj)
        {
            table.Attach(obj);
            Context.Entry(obj).State = EntityState.Modified;
        }
    }
}