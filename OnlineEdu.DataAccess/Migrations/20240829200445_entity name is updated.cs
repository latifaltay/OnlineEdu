using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineEdu.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class entitynameisupdated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Blogs_BlogCategorys_BlogCategoryId",
                table: "Blogs");

            migrationBuilder.DropForeignKey(
                name: "FK_Courses_CourseCategorys_CourseCategoryId",
                table: "Courses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CourseCategorys",
                table: "CourseCategorys");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BlogCategorys",
                table: "BlogCategorys");

            migrationBuilder.RenameTable(
                name: "CourseCategorys",
                newName: "CourseCategories");

            migrationBuilder.RenameTable(
                name: "BlogCategorys",
                newName: "BlogCategories");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CourseCategories",
                table: "CourseCategories",
                column: "CourseCategoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BlogCategories",
                table: "BlogCategories",
                column: "BlogCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Blogs_BlogCategories_BlogCategoryId",
                table: "Blogs",
                column: "BlogCategoryId",
                principalTable: "BlogCategories",
                principalColumn: "BlogCategoryId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_CourseCategories_CourseCategoryId",
                table: "Courses",
                column: "CourseCategoryId",
                principalTable: "CourseCategories",
                principalColumn: "CourseCategoryId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Blogs_BlogCategories_BlogCategoryId",
                table: "Blogs");

            migrationBuilder.DropForeignKey(
                name: "FK_Courses_CourseCategories_CourseCategoryId",
                table: "Courses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CourseCategories",
                table: "CourseCategories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BlogCategories",
                table: "BlogCategories");

            migrationBuilder.RenameTable(
                name: "CourseCategories",
                newName: "CourseCategorys");

            migrationBuilder.RenameTable(
                name: "BlogCategories",
                newName: "BlogCategorys");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CourseCategorys",
                table: "CourseCategorys",
                column: "CourseCategoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BlogCategorys",
                table: "BlogCategorys",
                column: "BlogCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Blogs_BlogCategorys_BlogCategoryId",
                table: "Blogs",
                column: "BlogCategoryId",
                principalTable: "BlogCategorys",
                principalColumn: "BlogCategoryId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_CourseCategorys_CourseCategoryId",
                table: "Courses",
                column: "CourseCategoryId",
                principalTable: "CourseCategorys",
                principalColumn: "CourseCategoryId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
