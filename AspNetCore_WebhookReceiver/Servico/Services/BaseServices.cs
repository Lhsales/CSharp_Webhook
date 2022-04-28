using Dominio.Interfaces;
using Dominio.Models;
using System.Collections.Generic;

namespace Servico.Services
{
    public class BaseServices<TEntity> : IBaseService<TEntity> where TEntity : BaseEntity
    {
        private readonly IBaseRepository<TEntity> _baseRepository;

        public BaseServices(IBaseRepository<TEntity> baseRepository)
        {
            _baseRepository = baseRepository;
        }

        public TEntity Add(TEntity obj)
        {
            _baseRepository.Insert(obj);
            return obj;
        }

        public void Delete(int id) => _baseRepository.Delete(id);
        public IList<TEntity> GetAll() => _baseRepository.GetAll();
        public TEntity GetById(int id) => _baseRepository.GetById(id);
        public TEntity Update(TEntity obj)
        {
            _baseRepository.Update(obj);
            return obj;
        }

    }
}
