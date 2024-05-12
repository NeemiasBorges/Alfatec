using Alfatec.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Alfatec.Infra.Data.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) 
            : base(options)
        { }
            public DbSet<Arquivo>              Arquivo              { get; set; }
            public DbSet<Servicos>             Servicos             { get; set; }
            public DbSet<ServicosUsuario>      ServicosUsuario      { get; set; }
            public DbSet<Autorizacao>          Autorizacao          { get; set; }
            public DbSet<Categoria>            Categoria            { get; set; }
            public DbSet<Comentario>           Comentario           { get; set; }
            public DbSet<ConfiguracoesUsuario> ConfiguracoesUsuario { get; set; }
            public DbSet<Empresa>              Empresa              { get; set; }
            public DbSet<Endereco>             Endereco             { get; set; }
            public DbSet<Mensagem>             Mensagem             { get; set; }
            public DbSet<Log>                  Log                  { get; set; }
            public DbSet<MidiaProduto>         MidiaProduto         { get; set; }
            public DbSet<MidiaUsuario>         MidiaUsuario         { get; set; }
            public DbSet<ModeloMensagem>       ModeloMensagem       { get; set; }
            public DbSet<ModoEnvio>            ModoEnvio            { get; set; }
            public DbSet<Negociacao>           Negociacao           { get; set; }
            public DbSet<Produto>              Produto              { get; set; }
            public DbSet<Selo>                 Selo                 { get; set; }
            public DbSet<Usuario>              Usuario              { get; set; }
            public DbSet<Veiculo>              Veiculo              { get; set; }
            public DbSet<VeiculoUsuario>       VeiculoUsuario       { get; set; }
            public DbSet<Condicoes>            Condicoes            { get; set; }
            public DbSet<CondicoesEstrada>     CondicoesEstrada     { get; set; }
            public DbSet<Noticia>              Noticia              { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
        }
    }
}
