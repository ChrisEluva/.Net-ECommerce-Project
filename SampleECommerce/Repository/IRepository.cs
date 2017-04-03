using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface IRepository<T>
    {
        List<T> GetAll();
        int Add(T entity);
        T Find(int ID);
        T Update(T entity);
        void Delete(T entity);
    }
}
