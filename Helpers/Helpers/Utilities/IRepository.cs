using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helpers.Utilities
{
    public interface IRepository<TEntity> where TEntity : class
    {
        List<TEntity> FetchAll();
        IQueryable<TEntity> Query { get; }
        void Add(TEntity entity);
        void Delete(TEntity entity);
        void Save();
    }

    
    public class Repository<T> : IEnumerator<T> where T : class
    {
        DataContext db;
        public Repository(DataContext db)
        {
            this.db = db;
        }

        #region IRepository<T> Members

        public IQueryable<T> Query
        {
            get { return db.GetTable<T>(); }
        }

        public List<T> FetchAll()
        {
            return Query.ToList();
        }

        public void Add(T entity)
        {
            db.GetTable<T>().InsertOnSubmit(entity);
        }

        public void Delete(T entity)
        {
            db.GetTable<T>().DeleteOnSubmit(entity);
        }

        public void Save()
        {
            db.SubmitChanges();
        }


        #endregion
    }
}
