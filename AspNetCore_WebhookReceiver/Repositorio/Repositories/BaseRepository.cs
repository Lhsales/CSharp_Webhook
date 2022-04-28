using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Dominio.Interfaces;
using Dominio.Models;
using Infra.Contexts;

namespace Infra.Repositories
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : BaseEntity
    {
        protected readonly PersisteContext _persisteContext;

        public BaseRepository(PersisteContext context) => _persisteContext = context;

        public void Insert(TEntity obj)
        {
            obj = atualizacaoTimeStamp(obj);
            obj = criacaoTimeStamp(obj);

            _persisteContext.Set<TEntity>().Add(obj);
            _persisteContext.SaveChanges();
        }

        public void Update(TEntity obj)
        {
            obj = atualizacaoTimeStamp(obj);

            _persisteContext.Entry(obj).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _persisteContext.SaveChanges();
        }

        public void Delete(int id)
        {
            _persisteContext.Set<TEntity>().Remove(GetById(id));
            _persisteContext.SaveChanges();
        }

        public IList<TEntity> GetAll() => _persisteContext.Set<TEntity>().ToList();
        public TEntity GetById(int id) => _persisteContext.Set<TEntity>().Find(id);

        private TEntity atualizacaoTimeStamp(TEntity obj) 
        {
            obj.Atualizacao = DateTime.Now;
            return obj;
        }
        private TEntity criacaoTimeStamp(TEntity obj) 
        {
            obj.Criacao = DateTime.Now;
            return obj;
        }
    }
}
