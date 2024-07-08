using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LayerDataAccess.Migrations
{
    /// <inheritdoc />
    public partial class Blog3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OkunmaSayisi",
                table: "Yazi",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OkunmaSayisi",
                table: "Yazi");
        }
    }
}
