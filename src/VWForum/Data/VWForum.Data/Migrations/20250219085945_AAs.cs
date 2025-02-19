using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VWForum.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class AAs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VWTags_Categories_CategoryId",
                table: "VWTags");

            migrationBuilder.DropForeignKey(
                name: "FK_VWTags_VWThread_VWThreadId",
                table: "VWTags");

            migrationBuilder.DropIndex(
                name: "IX_VWTags_CategoryId",
                table: "VWTags");

            migrationBuilder.DropIndex(
                name: "IX_VWTags_VWThreadId",
                table: "VWTags");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "VWTags");

            migrationBuilder.DropColumn(
                name: "VWThreadId",
                table: "VWTags");

            migrationBuilder.CreateTable(
                name: "CategoryVWTags",
                columns: table => new
                {
                    CategoryId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TagsId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryVWTags", x => new { x.CategoryId, x.TagsId });
                    table.ForeignKey(
                        name: "FK_CategoryVWTags_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CategoryVWTags_VWTags_TagsId",
                        column: x => x.TagsId,
                        principalTable: "VWTags",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VWTagsVWThread",
                columns: table => new
                {
                    TagsId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    VWThreadId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VWTagsVWThread", x => new { x.TagsId, x.VWThreadId });
                    table.ForeignKey(
                        name: "FK_VWTagsVWThread_VWTags_TagsId",
                        column: x => x.TagsId,
                        principalTable: "VWTags",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VWTagsVWThread_VWThread_VWThreadId",
                        column: x => x.VWThreadId,
                        principalTable: "VWThread",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CategoryVWTags_TagsId",
                table: "CategoryVWTags",
                column: "TagsId");

            migrationBuilder.CreateIndex(
                name: "IX_VWTagsVWThread_VWThreadId",
                table: "VWTagsVWThread",
                column: "VWThreadId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CategoryVWTags");

            migrationBuilder.DropTable(
                name: "VWTagsVWThread");

            migrationBuilder.AddColumn<string>(
                name: "CategoryId",
                table: "VWTags",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VWThreadId",
                table: "VWTags",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_VWTags_CategoryId",
                table: "VWTags",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_VWTags_VWThreadId",
                table: "VWTags",
                column: "VWThreadId");

            migrationBuilder.AddForeignKey(
                name: "FK_VWTags_Categories_CategoryId",
                table: "VWTags",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_VWTags_VWThread_VWThreadId",
                table: "VWTags",
                column: "VWThreadId",
                principalTable: "VWThread",
                principalColumn: "Id");
        }
    }
}
