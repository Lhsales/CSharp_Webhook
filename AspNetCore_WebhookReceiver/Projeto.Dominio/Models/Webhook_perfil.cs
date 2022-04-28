using System;
using System.Collections.Generic;


namespace Dominio.Models
{
    public class Webhook_perfil : BaseEntity
    {
        public string Nome { get; set; }
        public string Chave { get; set; }
        public DateTime Criacao { get; set; }
        public DateTime Atualizacao { get; set; }

        public List<Webhook_mensagem> Mensagens { get; set; }

        private void Valida()
        {
            if (string.IsNullOrEmpty(Nome))
                throw new InvalidOperationException("Nome precisa estar preenchido.");
        }
    }
}
