using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ToDoWebAppMay2022.Data.Migrations
{
    public partial class CompleteFlag : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsComplete",
                table: "ToDoItems",
                type: "boolean",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsComplete",
                table: "ToDoItems");
        }
    }
}
