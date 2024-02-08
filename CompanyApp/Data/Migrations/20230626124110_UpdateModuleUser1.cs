using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CompanyApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateModuleUser1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserId",
                table: "ModuleUser");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "ModuleUser",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
