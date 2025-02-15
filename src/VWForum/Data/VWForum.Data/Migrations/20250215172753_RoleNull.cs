using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VWForum.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class RoleNull : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Roles_ForumRoleId",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<string>(
                name: "ForumRoleId",
                table: "AspNetUsers",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Roles_ForumRoleId",
                table: "AspNetUsers",
                column: "ForumRoleId",
                principalTable: "Roles",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Roles_ForumRoleId",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<string>(
                name: "ForumRoleId",
                table: "AspNetUsers",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Roles_ForumRoleId",
                table: "AspNetUsers",
                column: "ForumRoleId",
                principalTable: "Roles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
