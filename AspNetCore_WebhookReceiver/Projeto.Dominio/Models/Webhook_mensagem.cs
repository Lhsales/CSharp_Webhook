using System;

namespace Dominio.Models
{
    public class Webhook_mensagem : BaseEntity
    {
        public string Descricao { get; set; }
        public DateTime Criacao { get; set; }
        public DateTime Atualizacao { get; set; }
        public int Perfil_Id { get; set; }
        public Webhook_perfil Perfil { get; set; }
    }
}
