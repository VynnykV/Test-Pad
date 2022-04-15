using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TestPad.DAL.Migrations
{
    public partial class ChangeSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Content", "IsCorrect" },
                values: new object[] { "long ago", false });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Content", "IsCorrect" },
                values: new object[] { "last night", true });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Content", "IsCorrect" },
                values: new object[] { "didn't never lie", false });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 23,
                column: "Content",
                value: "never lie");

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Content", "IsCorrect" },
                values: new object[] { "didn't lie", true });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Content", "IsCorrect" },
                values: new object[] { "didn't stay", false });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Content", "IsCorrect" },
                values: new object[] { "stayed", true });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Content", "IsCorrect" },
                values: new object[] { "How many, it will", false });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 35,
                column: "Content",
                value: "How much, will it");

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Content", "IsCorrect" },
                values: new object[] { "How much, it will", true });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 37,
                column: "IsCorrect",
                value: false);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 38,
                column: "IsCorrect",
                value: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "87b5c123-7574-49ec-a000-ce8b59476343");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "b3c055bb-9ebf-4526-90bf-1db1d9bf4ede");

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 1,
                column: "AuthorId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 3,
                column: "AuthorId",
                value: 1);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Content", "IsCorrect" },
                values: new object[] { "last night", true });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Content", "IsCorrect" },
                values: new object[] { "long ago", false });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Content", "IsCorrect" },
                values: new object[] { "didn't lie", true });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 23,
                column: "Content",
                value: "didn't never lie");

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Content", "IsCorrect" },
                values: new object[] { "never lie", false });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Content", "IsCorrect" },
                values: new object[] { "stayed", true });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Content", "IsCorrect" },
                values: new object[] { "didn't stay", false });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Content", "IsCorrect" },
                values: new object[] { "How much, it will", true });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 35,
                column: "Content",
                value: "How many, it will");

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Content", "IsCorrect" },
                values: new object[] { "How much, will it", false });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 37,
                column: "IsCorrect",
                value: true);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 38,
                column: "IsCorrect",
                value: false);

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
                column: "AuthorId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 3,
                column: "AuthorId",
                value: 2);
        }
    }
}
