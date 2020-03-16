using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Configuration.Database.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Service");

            migrationBuilder.CreateTable(
                name: "Assemblies",
                schema: "Service",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(nullable: false),
                    Type = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Assemblies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Params",
                schema: "Service",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Active = table.Column<bool>(nullable: false),
                    AssemblyId = table.Column<int>(nullable: true),
                    Key = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Params", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Params_Assemblies_AssemblyId",
                        column: x => x.AssemblyId,
                        principalSchema: "Service",
                        principalTable: "Assemblies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Params_AssemblyId",
                schema: "Service",
                table: "Params",
                column: "AssemblyId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Params",
                schema: "Service");

            migrationBuilder.DropTable(
                name: "Assemblies",
                schema: "Service");
        }
    }
}
