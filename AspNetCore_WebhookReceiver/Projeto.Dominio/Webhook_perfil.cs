using System;
using System.Collections.Generic;


namespace Dominio
{
    public class Webhook_perfil
    {
        public Nullable<long> Id { get; set; }
        public string Nome { get; set; }
        public string Chave { get; set; }
        public DateTime Criacao { get; set; }
        public DateTime Atualizacao { get; set; }

        public List<Webhook_mensagem> Mensagens { get; set; }

    }
}
