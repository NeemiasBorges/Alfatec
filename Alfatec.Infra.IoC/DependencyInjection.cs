using Alfatec.Application.Mappings;
using Alfatec.Application.Services;
using Alfatec.Application.Services.Interfaces;
using Alfatec.Infra.Data.Context;
using Alfatec.Infra.Data.Repositories;
using Alfatec.Infra.Data.Repositories.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.ComponentModel.Design;

namespace Alfatec.Infra.IoC
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services,IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
              options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"),
                b => b.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName)));

            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            services.AddScoped<ISeloRepository,           SeloRepository>();
            services.AddScoped<ICategoriaRepository,      CategoriaRepository>();
            services.AddScoped<IProdutoRepository,        ProdutoRepository>();
            services.AddScoped<INoticiaRepository,        NoticiaRepository>();
            services.AddScoped<IServicoRepository,        ServicosRepository>();
            services.AddScoped<IUsuarioRepository,        UsuarioRepository>();
            services.AddScoped<IModeloMensagemRepository, ModeloMensagemRepository>();
            services.AddScoped<IMensagemRepository,       MensagensRepository>();
            services.AddScoped<IEnderecoRepository,       EnderecoRepository>();

            services.AddScoped<ISeloService,      SeloService>();
            services.AddScoped<ICategoriaService, CategoriaService>();
            services.AddScoped<IProdutoService,   ProdutoService>();
            //services.AddScoped<INoticiaService, NoticiaService>();
            services.AddScoped<IServicoService,   ServicoService>();
            services.AddScoped<IUsuarioService,   UsuarioService>();
            services.AddScoped<IModeloMensagens,  ModeloMensagemService>();
            services.AddScoped<IMensagensService, MensagensService>();
            services.AddScoped<IEnderecoService,  EnderecoService>();

            services.AddAutoMapper(typeof(DomainToDTOMappingProfile));

            return services;
        }
    }
}
