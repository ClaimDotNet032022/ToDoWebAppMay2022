using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ToDoWebAppMay2022.Data.Migrations
{
    public partial class UpdateDbContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ToDoItem_ToDoList_ParentListId",
                table: "ToDoItem");

            migrationBuilder.DropForeignKey(
                name: "FK_ToDoList_AspNetUsers_OwnerId",
                table: "ToDoList");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ToDoList",
                table: "ToDoList");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ToDoItem",
                table: "ToDoItem");

            migrationBuilder.RenameTable(
                name: "ToDoList",
                newName: "ToDoLists");

            migrationBuilder.RenameTable(
                name: "ToDoItem",
                newName: "ToDoItems");

            migrationBuilder.RenameIndex(
                name: "IX_ToDoList_OwnerId",
                table: "ToDoLists",
                newName: "IX_ToDoLists_OwnerId");

            migrationBuilder.RenameIndex(
                name: "IX_ToDoItem_ParentListId",
                table: "ToDoItems",
                newName: "IX_ToDoItems_ParentListId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ToDoLists",
                table: "ToDoLists",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ToDoItems",
                table: "ToDoItems",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ToDoItems_ToDoLists_ParentListId",
                table: "ToDoItems",
                column: "ParentListId",
                principalTable: "ToDoLists",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ToDoLists_AspNetUsers_OwnerId",
                table: "ToDoLists",
                column: "OwnerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ToDoItems_ToDoLists_ParentListId",
                table: "ToDoItems");

            migrationBuilder.DropForeignKey(
                name: "FK_ToDoLists_AspNetUsers_OwnerId",
                table: "ToDoLists");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ToDoLists",
                table: "ToDoLists");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ToDoItems",
                table: "ToDoItems");

            migrationBuilder.RenameTable(
                name: "ToDoLists",
                newName: "ToDoList");

            migrationBuilder.RenameTable(
                name: "ToDoItems",
                newName: "ToDoItem");

            migrationBuilder.RenameIndex(
                name: "IX_ToDoLists_OwnerId",
                table: "ToDoList",
                newName: "IX_ToDoList_OwnerId");

            migrationBuilder.RenameIndex(
                name: "IX_ToDoItems_ParentListId",
                table: "ToDoItem",
                newName: "IX_ToDoItem_ParentListId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ToDoList",
                table: "ToDoList",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ToDoItem",
                table: "ToDoItem",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ToDoItem_ToDoList_ParentListId",
                table: "ToDoItem",
                column: "ParentListId",
                principalTable: "ToDoList",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ToDoList_AspNetUsers_OwnerId",
                table: "ToDoList",
                column: "OwnerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
