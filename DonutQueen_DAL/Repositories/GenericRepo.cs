using DonutQueen_DAL.Data;
using DonutQueen_DAL.IRepositories;
using DonutQueen_Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DonutQueen_DAL.Repositories
{
    public class GenericRepo<T> : IGenericRepo<T> where T :  EntityId
    {
        private readonly ApplicationDbContext _db;
        internal DbSet<T> _dbSet;
        public GenericRepo(ApplicationDbContext db)
        {
           _dbSet = db.Set<T>();
            _db = db;
        }

        public int AddObjToDb(T obj)
        {
            using (_db)
            {
                _db.Set<T>().Add(obj);
                _db.SaveChanges();
                _db.Entry(obj).GetDatabaseValues();

                return obj.Id;
            }
            
        }

        public IEnumerable<T> GetAll()
        {
            return _dbSet;
        }

        public T GetById(int id)
        {
            return _dbSet.Where(x => x.Id == id).FirstOrDefault(); 
            //throw new NotImplementedException();
        }

        public IEnumerable<T> GetBySearchQuery(Expression<Func<T, bool>> Filter)
        {
            return _dbSet.Where(Filter);
        }
       
    }
}
