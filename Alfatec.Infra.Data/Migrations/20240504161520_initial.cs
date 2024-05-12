using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Alfatec.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Arquivo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeArquivo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TipoArquivo = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false, defaultValue: "JPG"),
                    Diretorio = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TipoObjeto = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Arquivo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Autorizacao",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Bloqueado = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    EditarProduto = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    InserirProduto = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    DesativarProduto = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    EditarInformacoesEmpresa = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    EditarInformacoesUsuario = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    AcessoModuloContato = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    TipoObjeto = table.Column<int>(type: "int", nullable: false, defaultValue: 2)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Autorizacao", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categoria",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeCategoria = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TipoObjeto = table.Column<int>(type: "int", nullable: false, defaultValue: 7)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categoria", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Comentario",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UsuarioQueComentou = table.Column<int>(type: "int", nullable: false),
                    DataComentario = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ComentarioTexto = table.Column<string>(type: "nvarchar(max)", maxLength: 25600, nullable: false),
                    TipoObjeto = table.Column<int>(type: "int", nullable: false, defaultValue: 6)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comentario", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Condicoes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TipoObjeto = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Condicoes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CondicoesEstrada",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Localizacao = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    DataRegistro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Observacoes = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    TipoObjeto = table.Column<int>(type: "int", nullable: false, defaultValue: 16)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CondicoesEstrada", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ConfiguracoesUsuario",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    nomeConfiguracao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TipoObjeto = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Endereco",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Rua = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cidade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Numero = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Bairro = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CEP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Complemento = table.Column<string>(type: "nvarchar(max)", nullable: true, defaultValue: "-"),
                    UF = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Observacoes = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true, defaultValue: "-"),
                    TipoObjeto = table.Column<int>(type: "int", nullable: false, defaultValue: 8),
                    latitude = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    longitude = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Endereco", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Log",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeCampoAlterado = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Usuario = table.Column<int>(type: "int", nullable: false),
                    AntigoValor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TipoObjetoAlterado = table.Column<int>(type: "int", nullable: false),
                    NovoValor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TipoObjeto = table.Column<int>(type: "int", nullable: false, defaultValue: 13)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Log", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MidiaUsuario",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeArquivo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TipoArquivo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Diretorio = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TipoObjeto = table.Column<int>(type: "int", nullable: false, defaultValue: 10)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MidiaUsuario", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ModeloMensagem",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nomeModelo = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    TextoModelo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TipoObjeto = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModeloMensagem", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ModoEnvio",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeTransportadora = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CNPJTransportadora = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IETransportadora = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CalculoPrevisaoEntrega = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TipoEnvio = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TipoObjeto = table.Column<int>(type: "int", nullable: false, defaultValue: 12)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModoEnvio", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Negociacao",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataNegociacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdEmpresaVendedora = table.Column<int>(type: "int", nullable: false),
                    IdEmpresaCompradora = table.Column<int>(type: "int", nullable: false),
                    MetodoEnvio = table.Column<int>(type: "int", nullable: false),
                    MetodoPagamento = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PrevisaoEntrega = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StatusPagamento = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TipoObjeto = table.Column<int>(type: "int", nullable: false, defaultValue: 11)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Negociacao", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Noticia",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titulo = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Subtitulo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    UsuarioId = table.Column<int>(type: "int", nullable: false),
                    DataHoraCriacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CaminhoImagem = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Noticia", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Produto",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeProduto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DescricaoProduto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    Categoria = table.Column<int>(type: "int", nullable: false),
                    UnidadeVenda = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    IdFotos = table.Column<int>(type: "int", nullable: false),
                    Variacao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Validade = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Selos = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Classificacao = table.Column<int>(type: "int", nullable: false),
                    Comentarios = table.Column<int>(type: "int", nullable: false),
                    ComentariosAdicionais = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TipoObjeto = table.Column<int>(type: "int", nullable: false, defaultValue: 4),
                    IdMidiaProduto = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produto", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Selo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeSelo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TipoObjeto = table.Column<int>(type: "int", nullable: false, defaultValue: 8)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Selo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Servicos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeServico = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TipoObjeto = table.Column<int>(type: "int", nullable: false, defaultValue: 23)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Servicos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Veiculo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    TipoObjeto = table.Column<int>(type: "int", nullable: false, defaultValue: 21)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Veiculo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Empresa",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeEmpresa = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    Tipo = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Telefone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Grupo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    AreaAtuacao = table.Column<string>(type: "nvarchar(125)", maxLength: 125, nullable: false),
                    VendasConcluidas = table.Column<int>(type: "int", nullable: false),
                    Classificacao = table.Column<int>(type: "int", nullable: false),
                    CNPJ = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IE = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TipoObjeto = table.Column<int>(type: "int", nullable: false, defaultValue: 3),
                    IdUsuario = table.Column<int>(type: "int", nullable: false),
                    IdEndereco = table.Column<int>(type: "int", nullable: false),
                    enderecoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empresa", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Empresa_Endereco_enderecoId",
                        column: x => x.enderecoId,
                        principalTable: "Endereco",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    Tipo = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    NomeEmpresa = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Senha = table.Column<string>(type: "nvarchar(16)", maxLength: 16, nullable: false),
                    IdEndereco = table.Column<int>(type: "int", nullable: false),
                    IdAutorizacao = table.Column<int>(type: "int", nullable: false),
                    IdMidiaUsuario = table.Column<int>(type: "int", nullable: false),
                    DDD = table.Column<int>(type: "int", nullable: false),
                    Telefone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TipoObjeto = table.Column<int>(type: "int", nullable: false, defaultValue: 1),
                    CNPJ = table.Column<string>(type: "nvarchar(14)", maxLength: 14, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Usuario_Endereco_IdEndereco",
                        column: x => x.IdEndereco,
                        principalTable: "Endereco",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Mensagem",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Destinatario = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Remetente = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MensagemTexto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StatusEnvio = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataEnvio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdModelo = table.Column<int>(type: "int", nullable: false),
                    TipoObjeto = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mensagem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Mensagem_ModeloMensagem_IdModelo",
                        column: x => x.IdModelo,
                        principalTable: "ModeloMensagem",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MidiaProduto",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IDproduto = table.Column<int>(type: "int", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TipoArquivo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Diretorio = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TipoObjeto = table.Column<int>(type: "int", nullable: false, defaultValue: 9)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MidiaProduto", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MidiaProduto_Produto_IDproduto",
                        column: x => x.IDproduto,
                        principalTable: "Produto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ServicosUsuario",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdUsuario = table.Column<int>(type: "int", nullable: false),
                    UsuarioId = table.Column<int>(type: "int", nullable: false),
                    IdServico = table.Column<int>(type: "int", nullable: false),
                    ServicoId = table.Column<int>(type: "int", nullable: false),
                    NomeServico = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TipoObjeto = table.Column<int>(type: "int", nullable: false, defaultValue: 24)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServicosUsuario", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ServicosUsuario_Servicos_ServicoId",
                        column: x => x.ServicoId,
                        principalTable: "Servicos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ServicosUsuario_Usuario_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VeiculoUsuario",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Marca = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Modelo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Ano = table.Column<int>(type: "int", nullable: false),
                    Placa = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Cor = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    TipoCombustivel = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CapacidadeTanque = table.Column<double>(type: "float", nullable: false),
                    DataUltimaManutencao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Observacoes = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    UsuarioId = table.Column<int>(type: "int", nullable: false),
                    VeiculoId = table.Column<int>(type: "int", nullable: false),
                    TipoObjeto = table.Column<int>(type: "int", nullable: false, defaultValue: 22)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VeiculoUsuario", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VeiculoUsuario_Usuario_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_VeiculoUsuario_Veiculo_VeiculoId",
                        column: x => x.VeiculoId,
                        principalTable: "Veiculo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Categoria",
                columns: new[] { "Id", "DataCriacao", "NomeCategoria", "TipoObjeto" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 5, 4, 13, 15, 20, 310, DateTimeKind.Local).AddTicks(1736), "Grãos e cereais", 7 },
                    { 2, new DateTime(2024, 5, 4, 13, 15, 20, 310, DateTimeKind.Local).AddTicks(1754), "Frutas", 7 },
                    { 3, new DateTime(2024, 5, 4, 13, 15, 20, 310, DateTimeKind.Local).AddTicks(1757), "Horaliças", 7 },
                    { 4, new DateTime(2024, 5, 4, 13, 15, 20, 310, DateTimeKind.Local).AddTicks(1759), "Produtos lácteos", 7 },
                    { 5, new DateTime(2024, 5, 4, 13, 15, 20, 310, DateTimeKind.Local).AddTicks(1761), "Carne e aves", 7 }
                });

            migrationBuilder.InsertData(
                table: "Condicoes",
                columns: new[] { "Id", "Nome", "TipoObjeto" },
                values: new object[,]
                {
                    { 1, "Estradas não pavimentadas", 15 },
                    { 2, "Buracos e irregularidades", 15 },
                    { 3, "Lama e alagamentos", 15 },
                    { 4, "Estradas estreitas", 15 },
                    { 5, "Declives e aclives pronunciados", 15 },
                    { 6, "Curvas fechadas e sinuosas", 15 },
                    { 7, "Presença de animais", 15 },
                    { 8, "Ausência de sinalização e iluminação", 15 },
                    { 9, "Condições climáticas extremas", 15 },
                    { 10, "Falta de serviços de emergência", 15 },
                    { 11, "Falta de acostamento", 15 },
                    { 12, "Presença de pedras soltas", 15 },
                    { 13, "Ponte de uma única faixa", 15 },
                    { 14, "Vegetação sobre crescida", 15 },
                    { 15, "Excesso Poeira", 15 },
                    { 16, "Inclinações laterais", 15 },
                    { 17, "Cruzamentos não sinalizados", 15 },
                    { 18, "Presença de tratores e veículos agrícolas", 15 },
                    { 19, "Estradas com manutenção irregular", 15 },
                    { 20, "Riscos sazonais", 15 }
                });

            migrationBuilder.InsertData(
                table: "ModeloMensagem",
                columns: new[] { "Id", "TextoModelo", "TipoObjeto", "nomeModelo" },
                values: new object[,]
                {
                    { 1, "Olá {{NomeUsuario}},\r\n\r\nSeja bem-vindo à nossa plataforma! Estamos muito felizes em tê-lo(a) conosco.\r\n\r\nSeu cadastro foi realizado com sucesso usando o email: {{Email}}.\r\nTipo de usuário cadastrado: [Tipo de usuário]\r\nPara acessar sua conta pela primeira vez, utilize a seguinte senha temporária: {{SenhaTemp}}. Recomendamos que você altere sua senha assim que fizer login.\r\nPara acessar nossa plataforma, clique no link abaixo:\r\n\r\n{{Link de acesso}}", 20, "Primeiro Acesso" },
                    { 2, "Olá {{NomeUsuario}},\r\n\r\nUm novo serviço baseado em seu perfil acabou de aparecer. Se estiver interessado, por favor, responda com o número 1. Segue o resumo:\r\nTransporte de carga {{TipoCarga}}, aproximadamente {{PesoCarga}}} Kilos para o endereço:\r\n{{Endereco}}.\r\n\r\nAs condições da via são: {{CondicoesVia}}.\r\n\r\nO tempo total da viagem de ida é de aproximadamente {{TempoAproximado}} horas com o valor de {{ValorHora}} reais por hora, totalizando {{Total}} reais.\r\nFicamos no aguardo de sua resposta.", 20, "Notifica Servico" },
                    { 3, "Olá {{NomeUsuario}},\r\n\r\nVocê solicitou uma nova senha. Sua nova senha é: {{NovaSenha}}.", 20, "Resetar Senha" }
                });

            migrationBuilder.InsertData(
                table: "Selo",
                columns: new[] { "Id", "DataCriacao", "NomeSelo", "TipoObjeto" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 5, 4, 13, 15, 20, 316, DateTimeKind.Local).AddTicks(5570), "Agricultura Familiar", 8 },
                    { 2, new DateTime(2024, 5, 4, 13, 15, 20, 316, DateTimeKind.Local).AddTicks(5584), "BRC Global Standards", 8 },
                    { 3, new DateTime(2024, 5, 4, 13, 15, 20, 316, DateTimeKind.Local).AddTicks(5585), "Demeter: Agricultura Biodinâmica", 8 },
                    { 4, new DateTime(2024, 5, 4, 13, 15, 20, 316, DateTimeKind.Local).AddTicks(5587), "Comércio Justo - Fair Trade", 8 },
                    { 5, new DateTime(2024, 5, 4, 13, 15, 20, 316, DateTimeKind.Local).AddTicks(5588), "ISO 22000: Segurança Alimentar", 8 },
                    { 6, new DateTime(2024, 5, 4, 13, 15, 20, 316, DateTimeKind.Local).AddTicks(5590), "Kosher: Alimentação Judaica", 8 },
                    { 7, new DateTime(2024, 5, 4, 13, 15, 20, 316, DateTimeKind.Local).AddTicks(5592), "Non-GMO Project Verified", 8 },
                    { 8, new DateTime(2024, 5, 4, 13, 15, 20, 316, DateTimeKind.Local).AddTicks(5593), "Orgânico Brasil", 8 },
                    { 9, new DateTime(2024, 5, 4, 13, 15, 20, 316, DateTimeKind.Local).AddTicks(5594), "SENAR: Agricultura Familiar", 8 },
                    { 10, new DateTime(2024, 5, 4, 13, 15, 20, 316, DateTimeKind.Local).AddTicks(5596), "SISORG: Avaliação Orgânica", 8 },
                    { 11, new DateTime(2024, 5, 4, 13, 15, 20, 316, DateTimeKind.Local).AddTicks(5597), "SQF: Segurança Alimentar", 8 },
                    { 12, new DateTime(2024, 5, 4, 13, 15, 20, 316, DateTimeKind.Local).AddTicks(5599), "CCCF: Café, Cacau e Chá Sustentáveis", 8 },
                    { 13, new DateTime(2024, 5, 4, 13, 15, 20, 316, DateTimeKind.Local).AddTicks(5600), "NSF International: Saúde Alimentar", 8 },
                    { 14, new DateTime(2024, 5, 4, 13, 15, 20, 316, DateTimeKind.Local).AddTicks(5601), "ISO 9001: Qualidade", 8 },
                    { 15, new DateTime(2024, 5, 4, 13, 15, 20, 316, DateTimeKind.Local).AddTicks(5603), "Fairtrade International", 8 },
                    { 16, new DateTime(2024, 5, 4, 13, 15, 20, 316, DateTimeKind.Local).AddTicks(5604), "EU Organic", 8 },
                    { 17, new DateTime(2024, 5, 4, 13, 15, 20, 316, DateTimeKind.Local).AddTicks(5605), "GFCO: Livre de Glúten", 8 },
                    { 18, new DateTime(2024, 5, 4, 13, 15, 20, 316, DateTimeKind.Local).AddTicks(5607), "EcoCert: Ecológica", 8 },
                    { 19, new DateTime(2024, 5, 4, 13, 15, 20, 316, DateTimeKind.Local).AddTicks(5608), "Vegan Action", 8 },
                    { 20, new DateTime(2024, 5, 4, 13, 15, 20, 316, DateTimeKind.Local).AddTicks(5610), "Rainforest Alliance Agriculture", 8 }
                });

            migrationBuilder.InsertData(
                table: "Servicos",
                columns: new[] { "Id", "Descricao", "NomeServico", "TipoObjeto" },
                values: new object[,]
                {
                    { 1, "Orientação técnica para manejo de culturas.", "Consultoria Agronômica", 23 },
                    { 2, "Acompanhamento regular para otimização agrícola.", "Assistência Técnica", 23 },
                    { 3, "Distribuição eficiente de produtos agrícolas.", "Logística de Transporte", 23 },
                    { 4, "Controle e distribuição segura de colheitas.", "Armazenagem Pós-Colheita", 23 },
                    { 5, "Aluguel e manutenção de equipamentos agrícolas.", "Serviços de Máquinas Agrícolas", 23 },
                    { 6, "Avaliação e recomendação de fertilizantes.", "Análise de Solo e Nutrição de Plantas", 23 },
                    { 7, "Soluções tecnológicas para otimização agrícola.", "Tecnologia Agrícola e Digital", 23 },
                    { 8, "Projetos e manutenção de sistemas de irrigação.", "Serviços de Irrigação", 23 },
                    { 9, "Práticas sustentáveis para a agricultura.", "Gestão Ambiental e Sustentabilidade", 23 },
                    { 10, "Assessoria legal e administrativa para fazendas.", "Assistência Jurídica e Administrativa", 23 },
                    { 11, "Estratégias de promoção e vendas de produtos.", "Marketing Agrícola", 23 },
                    { 12, "Cursos e capacitação para agricultores.", "Educação e Treinamento Agrícola", 23 },
                    { 13, "Proteção contra perdas devido a eventos adversos.", "Seguro Agrícola", 23 },
                    { 14, "Desenvolvimento de variedades de plantas.", "Genética e Melhoramento Vegetal", 23 },
                    { 15, "Gestão financeira e tributária para fazendas.", "Contabilidade e Finanças Agrícolas", 23 },
                    { 16, "Garantia de padrões de qualidade e conformidade.", "Certificação e Qualidade", 23 },
                    { 17, "Produção e comercialização de materiais genéticos.", "Produção de Sementes e Mudas", 23 },
                    { 18, "Implementação de fontes de energia limpa em fazendas.", "Energias Renováveis", 23 },
                    { 19, "Prevenção e combate a problemas fitossanitários.", "Controle de Pragas e Doenças", 23 },
                    { 20, "Análise e insights sobre tendências e demanda do mercado agrícola.", "Consultoria de Mercado", 23 },
                    { 21, "Locação Equipamentos.", "Locação Equipamentos", 23 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Empresa_enderecoId",
                table: "Empresa",
                column: "enderecoId");

            migrationBuilder.CreateIndex(
                name: "IX_Mensagem_IdModelo",
                table: "Mensagem",
                column: "IdModelo");

            migrationBuilder.CreateIndex(
                name: "IX_MidiaProduto_IDproduto",
                table: "MidiaProduto",
                column: "IDproduto");

            migrationBuilder.CreateIndex(
                name: "IX_ServicosUsuario_ServicoId",
                table: "ServicosUsuario",
                column: "ServicoId");

            migrationBuilder.CreateIndex(
                name: "IX_ServicosUsuario_UsuarioId",
                table: "ServicosUsuario",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_IdEndereco",
                table: "Usuario",
                column: "IdEndereco");

            migrationBuilder.CreateIndex(
                name: "IX_VeiculoUsuario_UsuarioId",
                table: "VeiculoUsuario",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_VeiculoUsuario_VeiculoId",
                table: "VeiculoUsuario",
                column: "VeiculoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Arquivo");

            migrationBuilder.DropTable(
                name: "Autorizacao");

            migrationBuilder.DropTable(
                name: "Categoria");

            migrationBuilder.DropTable(
                name: "Comentario");

            migrationBuilder.DropTable(
                name: "Condicoes");

            migrationBuilder.DropTable(
                name: "CondicoesEstrada");

            migrationBuilder.DropTable(
                name: "ConfiguracoesUsuario");

            migrationBuilder.DropTable(
                name: "Empresa");

            migrationBuilder.DropTable(
                name: "Log");

            migrationBuilder.DropTable(
                name: "Mensagem");

            migrationBuilder.DropTable(
                name: "MidiaProduto");

            migrationBuilder.DropTable(
                name: "MidiaUsuario");

            migrationBuilder.DropTable(
                name: "ModoEnvio");

            migrationBuilder.DropTable(
                name: "Negociacao");

            migrationBuilder.DropTable(
                name: "Noticia");

            migrationBuilder.DropTable(
                name: "Selo");

            migrationBuilder.DropTable(
                name: "ServicosUsuario");

            migrationBuilder.DropTable(
                name: "VeiculoUsuario");

            migrationBuilder.DropTable(
                name: "ModeloMensagem");

            migrationBuilder.DropTable(
                name: "Produto");

            migrationBuilder.DropTable(
                name: "Servicos");

            migrationBuilder.DropTable(
                name: "Usuario");

            migrationBuilder.DropTable(
                name: "Veiculo");

            migrationBuilder.DropTable(
                name: "Endereco");
        }
    }
}
