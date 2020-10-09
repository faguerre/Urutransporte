using System;
using System.Collections.Generic;
using Urutransporte.Utils;

namespace Urutransporte.BusinessLogic.Interface
{
    public interface IBusinessLogic<T> where T : class
    {
        Result<T> Add (T entity); 
        Result<T> Update (int id, T entity);
        Result<T> Get (int id);
        IEnumerable<T> GetAll();
        bool Exist (Func<T, bool> predicate);
        Result<T> Delete (int id);
    }
}
