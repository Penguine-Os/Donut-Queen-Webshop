using DonutQueen_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DonutQueen_DAL.IRepositories
{
    public interface IGenericRepo<T> where T : EntityId
    {
        public IEnumerable<T> GetAll();
        public IEnumerable<T> GetBySearchQuery(Expression<Func<T, bool>> Filter);
        public T GetById(int id);
        public void AddObjToDb(T obj);
        void UpdateObj(T obj);
        void DeleteObj(T obj);


        //public IEnumerable<T> GetAll();
        //public IEnumerable<T> GetAll();

    }
}
