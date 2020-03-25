using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccessLayer1.Repository
{
    interface IRepository<T>
    {
        void Insert(T entity);
        void Delete(T entity);
        void Update(T entity);
        IQueryable<T> GetAll(T entity);
    }
}
