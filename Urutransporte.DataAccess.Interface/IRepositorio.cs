using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominioObligatorio2.InterfacesRepositorios
{
    public interface IRepositorio<T> where T : class
    {
        bool Add(T unObjeto);
        bool Remove(object clave);
        bool Update(T unObjeto);
        T FindById(object clave);
        IEnumerable<T> FindAll();

    }
}
