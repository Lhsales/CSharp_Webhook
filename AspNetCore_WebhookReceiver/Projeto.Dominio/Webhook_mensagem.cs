using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Webhook_mensagem
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public DateTime Criacao { get; set; }
        public DateTime Atualizacao { get; set; }
        public int Perfil_Id { get; set; }
        public Webhook_perfil Perfil { get; set; }
    }
}
