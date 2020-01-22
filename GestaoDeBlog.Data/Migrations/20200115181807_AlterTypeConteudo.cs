using Microsoft.EntityFrameworkCore.Migrations;

namespace GestaoDeBlog.Data.Migrations
{
    public partial class AlterTypeConteudo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Conteudo",
                table: "Posts",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(800)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Conteudo",
                table: "Posts",
                type: "varchar(800)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");
        }
    }
}
