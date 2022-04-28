using System;

namespace Dominio.Models
{
    public class Webhook_mensagem : BaseEntity
    {
        public string Descricao { get; set; }
        public int Perfil_Id { get; set; }
        public Webhook_perfil Perfil { get; set; }

        private void Valida()
        {
            if (string.IsNullOrEmpty(Descricao))
                throw new InvalidOperationException("Descrição precisa estar preenchida.");
        }
    }
}
