using System;
using Microsoft.EntityFrameworkCore;
using Dominio.Models;

namespace Infra.Contexts
{
    public class PersisteContext : DbContext
    {
        public PersisteContext() { }

        public PersisteContext(DbContextOptions<PersisteContext> opcoes) : base(opcoes) { }

        public DbSet<Webhook_perfil> Webhook_perfis { get; set; }
        public DbSet<Webhook_mensagem> Webhook_mensagens { get; set; }

        protected override void OnModelCreating(ModelBuilder construtorDeModelos)
        {
            //Define que o EF deve utilizar método Identity nas chaves primárias
            construtorDeModelos.UseIdentityColumns();

            construtorDeModelos.Entity<Webhook_perfil>(etd =>
            {
                etd.ToTable("tbWebhook_perfil");
                etd.HasKey(x => x.Id).HasName("idPerfil");
                etd.Property(x => x.Id).HasColumnName("id").ValueGeneratedOnAdd();
                etd.Property(x => x.Nome).HasColumnName("nome").HasMaxLength(200);
                etd.Property(x => x.Chave).HasColumnName("chave").HasMaxLength(200);
                etd.Property<DateTime>(x => x.Criacao).HasColumnName("criacao");
                etd.Property<DateTime>(x => x.Atualizacao).HasColumnName("atualizacao");
            });

            construtorDeModelos.Entity<Webhook_mensagem>(etd =>
            {
                etd.ToTable("tbWebhook_mensagem");
                etd.HasKey(x => x.Id).HasName("idMensagem");
                etd.Property(x => x.Id).HasColumnName("id").ValueGeneratedOnAdd();
                etd.Property(x => x.Descricao).HasColumnName("descricao").HasMaxLength(300);
                etd.Property<DateTime>(x => x.Criacao).HasColumnName("criacao");
                etd.Property<DateTime>(x => x.Atualizacao).HasColumnName("atualizacao");
                etd.HasOne(x => x.Perfil).WithMany(x => x.Mensagens);
            });

        }

    }
}
