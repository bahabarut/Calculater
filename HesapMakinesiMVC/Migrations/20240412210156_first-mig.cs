using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HesapMakinesiMVC.Migrations
{
    /// <inheritdoc />
    public partial class firstmig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Process",
                columns: table => new
                {
                    ProcessId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Number1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Number2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Result = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProcessType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Process", x => x.ProcessId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Process");
        }
    }
}
