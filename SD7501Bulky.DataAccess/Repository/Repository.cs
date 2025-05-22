using BulkyWeb.Data;
using Microsoft.EntityFrameworkCore;
using SD7501Bulky.DataAccess.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SD7501Bulky.DataAccess.Repository
{
    public class Repository<T>:IRepository<T> where T : class
    {
        private readonly ApplicationDbContext _db;
        internal DbSet<T> dbSet;
        public Repository(ApplicationDbContext db)
        {
            _db = db;
            this.dbSet = _db.Set<T>();
        }
        void IRepository<T>.Add(T entity)
        {
            dbSet.Add(entity);
        }

        T IRepository<T>.Get(Expression<Func<T, bool>> filter)
        {
            IQueryable<T> query = dbSet;
            query = query.Where(filter);
            return query.FirstOrDefault();
        }
        IEnumerable<T> IRepository<T>.GetAll()
        {
            IQueryable<T> query = dbSet;
            return query.ToList();
        }
        void IRepository<T>.Remove(T entity)
        {
            dbSet.Remove(entity);
        }
        void IRepository<T>.RemoveRange(IEnumerable<T> entity)
        {
            dbSet.RemoveRange(entity);
        }
        public void Add(T entity)
        {
            throw new NotImplementedException();
        }
        public T Get(int id)
        {
            throw new NotImplementedException();
        }
        public IEnumerable<T> GetAll()
        {
            throw new NotImplementedException();
        }
        public T Get(Expression<Func<T, bool>> filter)
        {
            throw new NotImplementedException();
        }
        public void RemoveRange(IEnumerable<T> entity)
        {
            throw new NotImplementedException();
        }
        public void Remove(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
