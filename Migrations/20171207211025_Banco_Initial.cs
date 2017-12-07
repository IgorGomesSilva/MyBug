using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace myBug.Migrations
{
    public partial class Banco_Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bugs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DataRegistro = table.Column<DateTime>(nullable: false),
                    Descricao = table.Column<string>(maxLength: 50, nullable: false),
                    Email = table.Column<string>(maxLength: 40, nullable: false),
                    Produto = table.Column<string>(maxLength: 60, nullable: false),
                    Severidade = table.Column<string>(maxLength: 20, nullable: false),
                    Titulo = table.Column<string>(maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bugs", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bugs");
        }
    }
}
