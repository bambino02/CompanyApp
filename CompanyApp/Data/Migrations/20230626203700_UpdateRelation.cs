using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CompanyApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateRelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ModuleUser");

            migrationBuilder.CreateTable(
                name: "ApplicationUserModule",
                columns: table => new
                {
                    ModulesId = table.Column<int>(type: "int", nullable: false),
                    UsersId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationUserModule", x => new { x.ModulesId, x.UsersId });
                    table.ForeignKey(
                        name: "FK_ApplicationUserModule_AspNetUsers_UsersId",
                        column: x => x.UsersId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ApplicationUserModule_Modules_ModulesId",
                        column: x => x.ModulesId,
                        principalTable: "Modules",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationUserModule_UsersId",
                table: "ApplicationUserModule",
                column: "UsersId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ApplicationUserModule");

            migrationBuilder.CreateTable(
                name: "ModuleUser",
                columns: table => new
                {
                    ModuleId = table.Column<int>(type: "int", nullable: false),
                    UsersId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Finished = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModuleUser", x => new { x.ModuleId, x.UsersId });
                    table.ForeignKey(
                        name: "FK_ModuleUser_AspNetUsers_UsersId",
                        column: x => x.UsersId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ModuleUser_Modules_ModuleId",
                        column: x => x.ModuleId,
                        principalTable: "Modules",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_ModuleUser_ModuleId",
                table: "ModuleUser",
                column: "ModuleId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ModuleUser_UsersId",
                table: "ModuleUser",
                column: "UsersId",
                unique: true);
        }
    }
}
