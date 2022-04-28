using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Dominio.Interfaces;
using Dominio.Models;
using Infra.Contexts;
using Microsoft.EntityFrameworkCore;

namespace Infra.Repositories
{
    public class PerfilRepository : BaseRepository<Webhook_perfil>
    {
        public PerfilRepository(PersisteContext context) : base(context) { } 

        public override IList<Webhook_perfil> GetAll() => _persisteContext.Webhook_perfis.Include(x => x.Mensagens).ToList();
        

    }
}
