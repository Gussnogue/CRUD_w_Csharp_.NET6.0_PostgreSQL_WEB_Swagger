using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace usuario.Migrations
{
    public partial class AtualizacaoUsuario : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Usuarios",
                table: "Usuarios");

            migrationBuilder.RenameTable(
                name: "Usuarios",
                newName: "Tb_usuario");

            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "Tb_usuario",
                newName: "nome");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Tb_usuario",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "DataNascimento",
                table: "Tb_usuario",
                newName: "data_nascimento");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tb_usuario",
                table: "Tb_usuario",
                column: "id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Tb_usuario",
                table: "Tb_usuario");

            migrationBuilder.RenameTable(
                name: "Tb_usuario",
                newName: "Usuarios");

            migrationBuilder.RenameColumn(
                name: "nome",
                table: "Usuarios",
                newName: "Nome");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Usuarios",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "data_nascimento",
                table: "Usuarios",
                newName: "DataNascimento");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Usuarios",
                table: "Usuarios",
                column: "Id");
        }
    }
}
