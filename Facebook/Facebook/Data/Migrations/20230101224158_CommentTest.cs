using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Facebook.Data.Migrations
{
    public partial class CommentTest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Posts_UserInfos_PostUserInfoId",
                table: "Posts");

            migrationBuilder.DropIndex(
                name: "IX_Posts_PostUserInfoId",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "PostUserInfoId",
                table: "Posts");

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Body = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserIdId = table.Column<int>(type: "int", nullable: false),
                    PostIdId = table.Column<int>(type: "int", nullable: false),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comments_Posts_PostIdId",
                        column: x => x.PostIdId,
                        principalTable: "Posts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Comments_UserInfos_UserIdId",
                        column: x => x.UserIdId,
                        principalTable: "UserInfos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Comments_PostIdId",
                table: "Comments",
                column: "PostIdId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_UserIdId",
                table: "Comments",
                column: "UserIdId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.AddColumn<int>(
                name: "PostUserInfoId",
                table: "Posts",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Posts_PostUserInfoId",
                table: "Posts",
                column: "PostUserInfoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_UserInfos_PostUserInfoId",
                table: "Posts",
                column: "PostUserInfoId",
                principalTable: "UserInfos",
                principalColumn: "Id");
        }
    }
}
