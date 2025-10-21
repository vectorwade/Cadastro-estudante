using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BalataTest.Data.Migrations
{
    /// <inheritdoc />
    public partial class FixPremiumStudentId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Premium_Student_StudentId",
                table: "Premium");

            migrationBuilder.RenameColumn(
                name: "StudentId",
                table: "Premium",
                newName: "StudentID");

            migrationBuilder.RenameIndex(
                name: "IX_Premium_StudentId",
                table: "Premium",
                newName: "IX_Premium_StudentID");

            migrationBuilder.AddColumn<decimal>(
                name: "Value",
                table: "Premium",
                type: "TEXT",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddForeignKey(
                name: "FK_Premium_Student_StudentID",
                table: "Premium",
                column: "StudentID",
                principalTable: "Student",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Premium_Student_StudentID",
                table: "Premium");

            migrationBuilder.DropColumn(
                name: "Value",
                table: "Premium");

            migrationBuilder.RenameColumn(
                name: "StudentID",
                table: "Premium",
                newName: "StudentId");

            migrationBuilder.RenameIndex(
                name: "IX_Premium_StudentID",
                table: "Premium",
                newName: "IX_Premium_StudentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Premium_Student_StudentId",
                table: "Premium",
                column: "StudentId",
                principalTable: "Student",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
