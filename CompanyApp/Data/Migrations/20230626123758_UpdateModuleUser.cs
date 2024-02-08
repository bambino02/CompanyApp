using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CompanyApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateModuleUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ModuleUser_AspNetUsers_UserId",
                table: "ModuleUser");

            migrationBuilder.DropForeignKey(
                name: "FK_ModuleUser_AspNetUsers_UsersId",
                table: "ModuleUser");

            migrationBuilder.DropIndex(
                name: "IX_ModuleUser_UserId",
                table: "ModuleUser");

            migrationBuilder.DropIndex(
                name: "IX_ModuleUser_UsersId",
                table: "ModuleUser");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "ModuleUser",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.CreateIndex(
                name: "IX_ModuleUser_UsersId",
                table: "ModuleUser",
                column: "UsersId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ModuleUser_AspNetUsers_UsersId",
                table: "ModuleUser",
                column: "UsersId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ModuleUser_AspNetUsers_UsersId",
                table: "ModuleUser");

            migrationBuilder.DropIndex(
                name: "IX_ModuleUser_UsersId",
                table: "ModuleUser");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "ModuleUser",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.CreateIndex(
                name: "IX_ModuleUser_UserId",
                table: "ModuleUser",
                column: "UserId",
                unique: true,
                filter: "[UserId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_ModuleUser_UsersId",
                table: "ModuleUser",
                column: "UsersId");

            migrationBuilder.AddForeignKey(
                name: "FK_ModuleUser_AspNetUsers_UserId",
                table: "ModuleUser",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ModuleUser_AspNetUsers_UsersId",
                table: "ModuleUser",
                column: "UsersId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
