using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class bagmati : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bagmati",
                columns: table => new
                {
                    Parameters = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    pH = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DO = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BOD = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    COD = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TDS = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EC = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NH3_N = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    N03_N = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    N02_N = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TOC = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TH = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mg = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fe = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TC = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    E_coli = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bagmati", x => x.Parameters);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bagmati");
        }
    }
}
