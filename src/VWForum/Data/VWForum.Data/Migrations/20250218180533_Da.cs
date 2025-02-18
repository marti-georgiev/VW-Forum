using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VWForum.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class Da : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserReactionMapping_Threads_ThreadId",
                table: "UserReactionMapping");

            migrationBuilder.AddColumn<string>(
                name: "CreatedById",
                table: "Roles",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "Roles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "DeletedById",
                table: "Roles",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedOn",
                table: "Roles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "UpdatedById",
                table: "Roles",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedOn",
                table: "Roles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateIndex(
                name: "IX_Roles_CreatedById",
                table: "Roles",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Roles_DeletedById",
                table: "Roles",
                column: "DeletedById");

            migrationBuilder.CreateIndex(
                name: "IX_Roles_UpdatedById",
                table: "Roles",
                column: "UpdatedById");

            migrationBuilder.AddForeignKey(
                name: "FK_Roles_AspNetUsers_CreatedById",
                table: "Roles",
                column: "CreatedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Roles_AspNetUsers_DeletedById",
                table: "Roles",
                column: "DeletedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Roles_AspNetUsers_UpdatedById",
                table: "Roles",
                column: "UpdatedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UserReactionMapping_Threads_ThreadId",
                table: "UserReactionMapping",
                column: "ThreadId",
                principalTable: "Threads",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Roles_AspNetUsers_CreatedById",
                table: "Roles");

            migrationBuilder.DropForeignKey(
                name: "FK_Roles_AspNetUsers_DeletedById",
                table: "Roles");

            migrationBuilder.DropForeignKey(
                name: "FK_Roles_AspNetUsers_UpdatedById",
                table: "Roles");

            migrationBuilder.DropForeignKey(
                name: "FK_UserReactionMapping_Threads_ThreadId",
                table: "UserReactionMapping");

            migrationBuilder.DropIndex(
                name: "IX_Roles_CreatedById",
                table: "Roles");

            migrationBuilder.DropIndex(
                name: "IX_Roles_DeletedById",
                table: "Roles");

            migrationBuilder.DropIndex(
                name: "IX_Roles_UpdatedById",
                table: "Roles");

            migrationBuilder.DropColumn(
                name: "CreatedById",
                table: "Roles");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "Roles");

            migrationBuilder.DropColumn(
                name: "DeletedById",
                table: "Roles");

            migrationBuilder.DropColumn(
                name: "DeletedOn",
                table: "Roles");

            migrationBuilder.DropColumn(
                name: "UpdatedById",
                table: "Roles");

            migrationBuilder.DropColumn(
                name: "UpdatedOn",
                table: "Roles");

            migrationBuilder.AddForeignKey(
                name: "FK_UserReactionMapping_Threads_ThreadId",
                table: "UserReactionMapping",
                column: "ThreadId",
                principalTable: "Threads",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
