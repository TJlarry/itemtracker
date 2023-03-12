using Microsoft.EntityFrameworkCore.Migrations;

namespace itemtracker.Migrations
{
    public partial class addmenu : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Amount",
                table: "Expenses");

            migrationBuilder.RenameColumn(
                name: "ExpenseName",
                table: "Expenses",
                newName: "Menu");

            migrationBuilder.AddColumn<string>(
                name: "Allergy",
                table: "Expenses",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BussinessUnit",
                table: "Expenses",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FullName",
                table: "Expenses",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Allergy",
                table: "Expenses");

            migrationBuilder.DropColumn(
                name: "BussinessUnit",
                table: "Expenses");

            migrationBuilder.DropColumn(
                name: "FullName",
                table: "Expenses");

            migrationBuilder.RenameColumn(
                name: "Menu",
                table: "Expenses",
                newName: "ExpenseName");

            migrationBuilder.AddColumn<int>(
                name: "Amount",
                table: "Expenses",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
