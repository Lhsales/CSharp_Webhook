using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infra.Migrations
{
    public partial class PrimeiraMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tbWebhook_perfil",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nome = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    chave = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    criacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    atualizacao = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("idPerfil", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "tbWebhook_mensagem",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    descricao = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    PerfilId = table.Column<int>(type: "int", nullable: true),
                    criacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    atualizacao = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("idMensagem", x => x.id);
                    table.ForeignKey(
                        name: "FK_tbWebhook_mensagem_tbWebhook_perfil_PerfilId",
                        column: x => x.PerfilId,
                        principalTable: "tbWebhook_perfil",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tbWebhook_mensagem_PerfilId",
                table: "tbWebhook_mensagem",
                column: "PerfilId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tbWebhook_mensagem");

            migrationBuilder.DropTable(
                name: "tbWebhook_perfil");
        }
    }
}
