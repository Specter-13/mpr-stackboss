using Microsoft.EntityFrameworkCore.Migrations;

namespace StackBoss.Web.Data.Migrations
{
    public partial class AddedUsersRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ed3c3a1e-15f7-42e6-ae4c-1f70275bbd56");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "4c660c4c-5d17-4b82-8375-b2344aa3ce81", "7ead5b5b-d4c0-4a11-85da-92902deb1c72", "Admin", "ADMIN" },
                    { "95a5f2b1-1d90-48c9-89af-6be56955c52e", "c615155e-4929-4a84-bc91-a7ff3f2c2eed", "ProjectManager", "PROJECTMANAGER" },
                    { "47b0c2bf-b624-46f4-86f4-bf15e5f97f6f", "8a74de6c-e5fb-43f6-96b2-c5561fb459c2", "ProjectDirector", "PROJECTDIRECTOR" }
                });

            migrationBuilder.UpdateData(
                table: "RiskTable",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Consequences", "RiskEvaluation" },
                values: new object[] { 5, 15 });

            migrationBuilder.UpdateData(
                table: "RiskTable",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Consequences", "Probability", "RiskEvaluation" },
                values: new object[] { 8, 6, 48 });

            migrationBuilder.UpdateData(
                table: "RiskTable",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Consequences", "Probability", "RiskEvaluation" },
                values: new object[] { 10, 4, 40 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "47b0c2bf-b624-46f4-86f4-bf15e5f97f6f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4c660c4c-5d17-4b82-8375-b2344aa3ce81");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "95a5f2b1-1d90-48c9-89af-6be56955c52e");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ed3c3a1e-15f7-42e6-ae4c-1f70275bbd56", "dd0dedc2-67cd-4777-97b5-88b1c9d1f190", "Admin", "ADMIN" });

            migrationBuilder.UpdateData(
                table: "RiskTable",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Consequences", "RiskEvaluation" },
                values: new object[] { 4, 12 });

            migrationBuilder.UpdateData(
                table: "RiskTable",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Consequences", "Probability", "RiskEvaluation" },
                values: new object[] { 4, 3, 12 });

            migrationBuilder.UpdateData(
                table: "RiskTable",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Consequences", "Probability", "RiskEvaluation" },
                values: new object[] { 4, 3, 12 });
        }
    }
}
