using System.Collections.Generic;
using Dominio.Models;

namespace Dominio.Interfaces
{
    public interface IBaseRepository<TEntity> where TEntity : BaseEntity
    {
        void Insert(TEntity obj);
        void Update(TEntity obj);
        void Delete(int id);
        IList<TEntity> GetAll();
        TEntity GetById(int id);
    }
}
