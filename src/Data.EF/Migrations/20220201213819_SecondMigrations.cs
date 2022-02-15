using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.EF.Migrations
{
    public partial class SecondMigrations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_User",
                table: "User");

            migrationBuilder.RenameTable(
                name: "User",
                newName: "Usuarios");

            migrationBuilder.RenameIndex(
                name: "IX_User_Email",
                table: "Usuarios",
                newName: "IX_Usuarios_Email");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Usuarios",
                table: "Usuarios",
                column: "Codigo");

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Codigo",
                keyValue: 1,
                columns: new[] { "DataAniversario", "DataCriacao" },
                values: new object[] { new DateTime(2022, 2, 1, 18, 38, 19, 725, DateTimeKind.Local).AddTicks(7660), new DateTime(2022, 2, 1, 18, 38, 19, 725, DateTimeKind.Local).AddTicks(323) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Usuarios",
                table: "Usuarios");

            migrationBuilder.RenameTable(
                name: "Usuarios",
                newName: "User");

            migrationBuilder.RenameIndex(
                name: "IX_Usuarios_Email",
                table: "User",
                newName: "IX_User_Email");

            migrationBuilder.AddPrimaryKey(
                name: "PK_User",
                table: "User",
                column: "Codigo");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Codigo",
                keyValue: 1,
                columns: new[] { "DataAniversario", "DataCriacao" },
                values: new object[] { new DateTime(2022, 2, 1, 18, 34, 11, 527, DateTimeKind.Local).AddTicks(1956), new DateTime(2022, 2, 1, 18, 34, 11, 526, DateTimeKind.Local).AddTicks(2767) });
        }
    }
}
