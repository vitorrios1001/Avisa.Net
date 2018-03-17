using Avisa.Net.Data.Interface.Commons;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
 
namespace Avisa.Net.Data.Repository
{
    public class RepositoryBase<T> : IRepository<T> where T : class
    {

        protected readonly AvisaNetDbContext db;

        public RepositoryBase() => db = new AvisaNetDbContext();
        public void Delete(T obj)
        {
            db.Set<T>().Remove(obj);
            db.SaveChanges();
        }

        public void Edit(T obj)
        {
            db.Entry(obj).State = EntityState.Modified;
            db.SaveChanges();
        }

        public IEnumerable<T> GetAll() => db.Set<T>().ToList();


        public T GetById(int id) => db.Set<T>().Find(id);

        public void Insert(T obj)
        {
            db.Add(obj);
            db.SaveChanges();
        }

        public void Dispose()
        {
            db.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}