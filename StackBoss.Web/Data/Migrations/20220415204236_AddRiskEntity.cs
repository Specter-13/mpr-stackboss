using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StackBoss.Web.Data.Migrations
{
    public partial class AddRiskEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RiskTable",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Category = table.Column<int>(type: "int", nullable: false),
                    Threat = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Starters = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Reaction = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Owner = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Probability = table.Column<int>(type: "int", nullable: false),
                    Consequences = table.Column<int>(type: "int", nullable: false),
                    RiskEvaluation = table.Column<int>(type: "int", nullable: false),
                    State = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedStateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ReactionDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RiskTable", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "RiskTable",
                columns: new[] { "Id", "Category", "Consequences", "CreatedDate", "Description", "ModifiedStateDate", "Name", "Owner", "Probability", "Reaction", "ReactionDate", "RiskEvaluation", "Starters", "State", "Threat" },
                values: new object[] { 1, 2, 4, new DateTime(2021, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test bussiness risk", new DateTime(2021, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Risk of bankruptcy", "Ing. Jozko Mrkvicka", 3, "Change staff, project reset", new DateTime(2022, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 12, "Project wasn't finished successfuly", 1, "Loosing all of money" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RiskTable");
        }
    }
}
