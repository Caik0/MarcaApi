using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MarcaApi.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Marcas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", nullable: false),
                    AnoFundacao = table.Column<int>(type: "INTEGER", nullable: false),
                    PaisOrigem = table.Column<string>(type: "TEXT", nullable: false),
                    Setor = table.Column<string>(type: "TEXT", nullable: false),
                    Slogan = table.Column<string>(type: "TEXT", nullable: false),
                    Website = table.Column<string>(type: "TEXT", nullable: false),
                    Descricao = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Marcas", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Marcas",
                columns: new[] { "Id", "AnoFundacao", "Descricao", "Nome", "PaisOrigem", "Setor", "Slogan", "Website" },
                values: new object[,]
                {
                    { 1, 1969, "Empresa líder no setor de tecnologia, especializada em dispositivos eletrônicos e soluções digitais.", "Samsung", "Coreia do Sul", "Tecnologia", "Faça o que você não pode", "https://www.samsung.com/br/" },
                    { 2, 1976, "Empresa líder no desenvolvimento de hardware e software inovadores.", "Apple", "EUA", "Tecnologia", "Think Different", "https://www.apple.com/" },
                    { 3, 1946, "Especializada em eletrônicos de consumo, games, entretenimento e finanças.", "Sony", "Japão", "Tecnologia", "Make.Believe", "https://www.sony.com/" },
                    { 4, 1958, "Fornecedor global de produtos de eletrônicos de consumo, desde TVs até eletrodomésticos.", "LG", "Coreia do Sul", "Tecnologia", "Life's Good", "https://www.lg.com/" },
                    { 5, 1975, "Uma das maiores empresas de software do mundo, com soluções em computação e nuvem.", "Microsoft", "EUA", "Tecnologia", "Be what's next", "https://www.microsoft.com/" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Marcas");
        }
    }
}
