using Alfatec.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace Alfatec.Infra.Data.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) 
            : base(options)
        { }
            public DbSet<Autorizacoes> Autorizacoes { get; set; }
            public DbSet<Categoria> Categoria { get; set; }
            public DbSet<Comentario> Comentario{ get; set; }
            public DbSet<ConfiguracoesUsuario> ConfiguracoesUsuario{ get; set; }
            public DbSet<Empresa> Empresa { get; set; }
            public DbSet<Endereco> Endereco{ get; set; }
            public DbSet<EnvioEmail> EnvioEmail{ get; set; }
            public DbSet<EnvioWhatsapp> EnvioWhatsapp{ get; set; }
            public DbSet<Grupo> Grupo{ get; set; }
            public DbSet<Log> Log { get; set; }
            public DbSet<MidiaProduto> MidiaProduto { get; set; }
            public DbSet<MidiaUsuario> MidiaUsuario { get; set; }
            public DbSet<ModeloEmail> ModeloEmail { get; set; }
            public DbSet<ModeloMensagem> ModeloMensagem{ get; set; }
            public DbSet<ModoEnvio> ModoEnvio{ get; set; }
            public DbSet<Negociacao> Negociacao{ get; set; }
            public DbSet<Produto> Produto{ get; set; }
            public DbSet<Selo> Selo{ get; set; }
            public DbSet<Usuarios> Usuarios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
