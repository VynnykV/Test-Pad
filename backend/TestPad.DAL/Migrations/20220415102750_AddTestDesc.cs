using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TestPad.DAL.Migrations
{
    public partial class AddTestDesc : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsRequired",
                table: "Answers");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Tests",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "17e78e34-4f09-4eac-ad14-f5c569b03341");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "a88a9f35-c40b-4ada-a896-f923d46cbdc4");

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 1,
                column: "Description",
                value: "Learn how to use the present simple in English. This is an English grammar lesson for beginners or elementary students");

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AuthorId", "Description" },
                values: new object[] { 1, "Past simple exercises - regular verbs elementary level esl. Beginners exercises." });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 3,
                column: "Description",
                value: "Online quiz to test your understanding of the Future Simple tense in English.");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Tests");

            migrationBuilder.AddColumn<bool>(
                name: "IsRequired",
                table: "Answers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "345c23fc-e73e-439d-8571-4f9f2cec1eea");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "0d53b96d-ce11-446f-be65-57522d9a86f1");

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 2,
                column: "AuthorId",
                value: 2);
        }
    }
}
