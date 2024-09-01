using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductOrderManagement.Domain.IRepositories
{
    public interface IBaseRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        T? GetById(Guid id);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
