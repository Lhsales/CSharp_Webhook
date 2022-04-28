using System;

namespace Dominio.Models
{
    public abstract class BaseEntity
    {
        public virtual int Id { get; set; }
        public virtual DateTime Criacao { get; set; }
        public virtual DateTime Atualizacao { get; set; }
    }
}
