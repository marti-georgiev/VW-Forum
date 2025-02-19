using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VWForum.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class a : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comment_Threads_ThreadId",
                table: "Comment");

            migrationBuilder.DropForeignKey(
                name: "FK_Threads_AspNetUsers_CreatedById",
                table: "Threads");

            migrationBuilder.DropForeignKey(
                name: "FK_Threads_AspNetUsers_DeletedById",
                table: "Threads");

            migrationBuilder.DropForeignKey(
                name: "FK_Threads_AspNetUsers_UpdatedById",
                table: "Threads");

            migrationBuilder.DropForeignKey(
                name: "FK_Threads_Categories_CategoryId",
                table: "Threads");

            migrationBuilder.DropForeignKey(
                name: "FK_UserReactionMapping_Threads_ThreadId",
                table: "UserReactionMapping");

            migrationBuilder.DropForeignKey(
                name: "FK_UserThreadComment_Threads_ThreadId",
                table: "UserThreadComment");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Threads",
                table: "Threads");

            migrationBuilder.RenameTable(
                name: "Threads",
                newName: "VWThread");

            migrationBuilder.RenameIndex(
                name: "IX_Threads_UpdatedById",
                table: "VWThread",
                newName: "IX_VWThread_UpdatedById");

            migrationBuilder.RenameIndex(
                name: "IX_Threads_DeletedById",
                table: "VWThread",
                newName: "IX_VWThread_DeletedById");

            migrationBuilder.RenameIndex(
                name: "IX_Threads_CreatedById",
                table: "VWThread",
                newName: "IX_VWThread_CreatedById");

            migrationBuilder.RenameIndex(
                name: "IX_Threads_CategoryId",
                table: "VWThread",
                newName: "IX_VWThread_CategoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_VWThread",
                table: "VWThread",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "VWTags",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Lable = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    VWThreadId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CreatedById = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedById = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedById = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VWTags", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VWTags_AspNetUsers_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_VWTags_AspNetUsers_DeletedById",
                        column: x => x.DeletedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_VWTags_AspNetUsers_UpdatedById",
                        column: x => x.UpdatedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_VWTags_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_VWTags_VWThread_VWThreadId",
                        column: x => x.VWThreadId,
                        principalTable: "VWThread",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_VWTags_CategoryId",
                table: "VWTags",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_VWTags_CreatedById",
                table: "VWTags",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_VWTags_DeletedById",
                table: "VWTags",
                column: "DeletedById");

            migrationBuilder.CreateIndex(
                name: "IX_VWTags_UpdatedById",
                table: "VWTags",
                column: "UpdatedById");

            migrationBuilder.CreateIndex(
                name: "IX_VWTags_VWThreadId",
                table: "VWTags",
                column: "VWThreadId");

            migrationBuilder.AddForeignKey(
                name: "FK_Comment_VWThread_ThreadId",
                table: "Comment",
                column: "ThreadId",
                principalTable: "VWThread",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserReactionMapping_VWThread_ThreadId",
                table: "UserReactionMapping",
                column: "ThreadId",
                principalTable: "VWThread",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserThreadComment_VWThread_ThreadId",
                table: "UserThreadComment",
                column: "ThreadId",
                principalTable: "VWThread",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VWThread_AspNetUsers_CreatedById",
                table: "VWThread",
                column: "CreatedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_VWThread_AspNetUsers_DeletedById",
                table: "VWThread",
                column: "DeletedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_VWThread_AspNetUsers_UpdatedById",
                table: "VWThread",
                column: "UpdatedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_VWThread_Categories_CategoryId",
                table: "VWThread",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comment_VWThread_ThreadId",
                table: "Comment");

            migrationBuilder.DropForeignKey(
                name: "FK_UserReactionMapping_VWThread_ThreadId",
                table: "UserReactionMapping");

            migrationBuilder.DropForeignKey(
                name: "FK_UserThreadComment_VWThread_ThreadId",
                table: "UserThreadComment");

            migrationBuilder.DropForeignKey(
                name: "FK_VWThread_AspNetUsers_CreatedById",
                table: "VWThread");

            migrationBuilder.DropForeignKey(
                name: "FK_VWThread_AspNetUsers_DeletedById",
                table: "VWThread");

            migrationBuilder.DropForeignKey(
                name: "FK_VWThread_AspNetUsers_UpdatedById",
                table: "VWThread");

            migrationBuilder.DropForeignKey(
                name: "FK_VWThread_Categories_CategoryId",
                table: "VWThread");

            migrationBuilder.DropTable(
                name: "VWTags");

            migrationBuilder.DropPrimaryKey(
                name: "PK_VWThread",
                table: "VWThread");

            migrationBuilder.RenameTable(
                name: "VWThread",
                newName: "Threads");

            migrationBuilder.RenameIndex(
                name: "IX_VWThread_UpdatedById",
                table: "Threads",
                newName: "IX_Threads_UpdatedById");

            migrationBuilder.RenameIndex(
                name: "IX_VWThread_DeletedById",
                table: "Threads",
                newName: "IX_Threads_DeletedById");

            migrationBuilder.RenameIndex(
                name: "IX_VWThread_CreatedById",
                table: "Threads",
                newName: "IX_Threads_CreatedById");

            migrationBuilder.RenameIndex(
                name: "IX_VWThread_CategoryId",
                table: "Threads",
                newName: "IX_Threads_CategoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Threads",
                table: "Threads",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Comment_Threads_ThreadId",
                table: "Comment",
                column: "ThreadId",
                principalTable: "Threads",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Threads_AspNetUsers_CreatedById",
                table: "Threads",
                column: "CreatedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Threads_AspNetUsers_DeletedById",
                table: "Threads",
                column: "DeletedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Threads_AspNetUsers_UpdatedById",
                table: "Threads",
                column: "UpdatedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Threads_Categories_CategoryId",
                table: "Threads",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserReactionMapping_Threads_ThreadId",
                table: "UserReactionMapping",
                column: "ThreadId",
                principalTable: "Threads",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserThreadComment_Threads_ThreadId",
                table: "UserThreadComment",
                column: "ThreadId",
                principalTable: "Threads",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
