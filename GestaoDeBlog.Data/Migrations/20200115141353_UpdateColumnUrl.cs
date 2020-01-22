using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GestaoDeBlog.Data.Migrations
{
    public partial class UpdateColumnUrl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Url",
                table: "Posts",
                type: "varchar(80)",
                nullable: false);
        }
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
