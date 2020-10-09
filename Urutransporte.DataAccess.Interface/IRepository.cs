using System;
using Urutransporte.Domain;
using System.Collections.Generic;

namespace Urutransporte.DataAccess.Interface
{
    public interface IRepository<T> where T : class
    {
        void Add (T entity);
        void Update (int id, T entity);
        T Get (int id);
        void Delete (int id);
        bool Exist(Func<T, bool> predicate);
        IEnumerable<T> GetAll ();
        void Save();
    }
}
