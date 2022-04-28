using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Dominio.Models;

namespace Dominio.Interfaces
{
    public interface IBaseService<TEntity> where TEntity : BaseEntity
    {
        TEntity Add(TEntity obj);
        void Delete(int id);
        IList<TEntity> GetAll();
        TEntity GetById(int id);
        TEntity Update(TEntity obj);

    }
}
