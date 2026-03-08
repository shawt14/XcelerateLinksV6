using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APIPSI16.Migrations
{
    public partial class AddPriorityIdAndIsDiscardedToEmployerCandidateHistory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PriorityId",
                table: "EmployerCandidateHistory",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDiscarded",
                table: "EmployerCandidateHistory",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDiscarded",
                table: "EmployerCandidateHistory");

            migrationBuilder.DropColumn(
                name: "PriorityId",
                table: "EmployerCandidateHistory");
        }
    }
}
