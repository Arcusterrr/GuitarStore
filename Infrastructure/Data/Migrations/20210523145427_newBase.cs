using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Infrastructure.Data.Migrations
{
    public partial class newBase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "GuitarTypeId",
                table: "Guitars",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "GuitarTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GuitarTypes", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Guitars_GuitarTypeId",
                table: "Guitars",
                column: "GuitarTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Guitars_GuitarTypes_GuitarTypeId",
                table: "Guitars",
                column: "GuitarTypeId",
                principalTable: "GuitarTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Guitars_GuitarTypes_GuitarTypeId",
                table: "Guitars");

            migrationBuilder.DropTable(
                name: "GuitarTypes");

            migrationBuilder.DropIndex(
                name: "IX_Guitars_GuitarTypeId",
                table: "Guitars");

            migrationBuilder.DropColumn(
                name: "GuitarTypeId",
                table: "Guitars");
        }
    }
}
