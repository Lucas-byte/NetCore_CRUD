using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.EF.Migrations
{
    public partial class FirstMigrations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Codigo = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DataCriacao = table.Column<DateTime>(nullable: false),
                    Nome = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Senha = table.Column<string>(nullable: true),
                    DataAniversario = table.Column<DateTime>(nullable: false),
                    DataDelecao = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Codigo);
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Codigo", "DataAniversario", "DataCriacao", "DataDelecao", "Email", "Nome", "Senha" },
                values: new object[] { 1, new DateTime(2022, 2, 1, 18, 34, 11, 527, DateTimeKind.Local).AddTicks(1956), new DateTime(2022, 2, 1, 18, 34, 11, 526, DateTimeKind.Local).AddTicks(2767), null, "administrador@email.com.br", "Administrador", "admin@123" });

            migrationBuilder.CreateIndex(
                name: "IX_User_Email",
                table: "User",
                column: "Email",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
