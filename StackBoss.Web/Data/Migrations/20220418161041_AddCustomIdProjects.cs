using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StackBoss.Web.Data.Migrations
{
    public partial class AddCustomIdProjects : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProjectTable",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Manager = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Staff = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectTable", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RiskTable",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    ReactionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ProjectId = table.Column<int>(type: "int", nullable: false),
                    CustomId = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RiskTable", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RiskTable_ProjectTable_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "ProjectTable",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ed3c3a1e-15f7-42e6-ae4c-1f70275bbd56", "dd0dedc2-67cd-4777-97b5-88b1c9d1f190", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "ProjectTable",
                columns: new[] { "Id", "CustomId", "Description", "Manager", "Name", "Staff" },
                values: new object[] { 1, "P_001", "Information system for Hospital in Brno", "Ing. Jan Honza", "Medical IS", "Lukas Kudlicka, Michal Kovac" });

            migrationBuilder.InsertData(
                table: "RiskTable",
                columns: new[] { "Id", "Category", "Consequences", "CreatedDate", "CustomId", "Description", "ModifiedStateDate", "Name", "Owner", "Probability", "ProjectId", "Reaction", "ReactionDate", "RiskEvaluation", "Starters", "State", "Threat" },
                values: new object[] { 1, 2, 4, new DateTime(2021, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "P001_R01", "Test bussiness risk", new DateTime(2021, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Risk of bankruptcy", "Ing. Jozko Mrkvicka", 3, 1, "Change staff, project reset", new DateTime(2022, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 12, "Project wasn't finished successfuly", 1, "Loosing all of money" });

            migrationBuilder.InsertData(
                table: "RiskTable",
                columns: new[] { "Id", "Category", "Consequences", "CreatedDate", "CustomId", "Description", "ModifiedStateDate", "Name", "Owner", "Probability", "ProjectId", "Reaction", "ReactionDate", "RiskEvaluation", "Starters", "State", "Threat" },
                values: new object[] { 2, 3, 4, new DateTime(2021, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "P001_R02", "Test extern risk", new DateTime(2021, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Risk of Fire", "Ing. Jozko Mrkvicka", 3, 1, "Change staff, project reset", new DateTime(2022, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 12, "Project wasn't finished successfuly", 1, "Loosing all of money" });

            migrationBuilder.InsertData(
                table: "RiskTable",
                columns: new[] { "Id", "Category", "Consequences", "CreatedDate", "CustomId", "Description", "ModifiedStateDate", "Name", "Owner", "Probability", "ProjectId", "Reaction", "ReactionDate", "RiskEvaluation", "Starters", "State", "Threat" },
                values: new object[] { 3, 2, 4, new DateTime(2021, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "P001_R03", "Test bussiness risk", new DateTime(2021, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Risk of Lost Data", "Ing. Jozko Mrkvicka", 3, 1, "Change staff, project reset", new DateTime(2022, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 12, "Project wasn't finished successfuly", 1, "Loosing all of money" });

            migrationBuilder.CreateIndex(
                name: "IX_RiskTable_ProjectId",
                table: "RiskTable",
                column: "ProjectId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RiskTable");

            migrationBuilder.DropTable(
                name: "ProjectTable");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ed3c3a1e-15f7-42e6-ae4c-1f70275bbd56");
        }
    }
}
