using Microsoft.EntityFrameworkCore.Migrations;

namespace ThisorThat.Data.Migrations
{
    public partial class CreateTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Item_Item_ItemId1",
                table: "Item");

            migrationBuilder.DropForeignKey(
                name: "FK_Item_List_ListId",
                table: "Item");

            migrationBuilder.DropPrimaryKey(
                name: "PK_List",
                table: "List");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Item",
                table: "Item");

            migrationBuilder.RenameTable(
                name: "List",
                newName: "Lists");

            migrationBuilder.RenameTable(
                name: "Item",
                newName: "Items");

            migrationBuilder.RenameIndex(
                name: "IX_Item_ListId",
                table: "Items",
                newName: "IX_Items_ListId");

            migrationBuilder.RenameIndex(
                name: "IX_Item_ItemId1",
                table: "Items",
                newName: "IX_Items_ItemId1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Lists",
                table: "Lists",
                column: "ListId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Items",
                table: "Items",
                column: "ItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Items_ItemId1",
                table: "Items",
                column: "ItemId1",
                principalTable: "Items",
                principalColumn: "ItemId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Lists_ListId",
                table: "Items",
                column: "ListId",
                principalTable: "Lists",
                principalColumn: "ListId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_Items_ItemId1",
                table: "Items");

            migrationBuilder.DropForeignKey(
                name: "FK_Items_Lists_ListId",
                table: "Items");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Lists",
                table: "Lists");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Items",
                table: "Items");

            migrationBuilder.RenameTable(
                name: "Lists",
                newName: "List");

            migrationBuilder.RenameTable(
                name: "Items",
                newName: "Item");

            migrationBuilder.RenameIndex(
                name: "IX_Items_ListId",
                table: "Item",
                newName: "IX_Item_ListId");

            migrationBuilder.RenameIndex(
                name: "IX_Items_ItemId1",
                table: "Item",
                newName: "IX_Item_ItemId1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_List",
                table: "List",
                column: "ListId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Item",
                table: "Item",
                column: "ItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_Item_Item_ItemId1",
                table: "Item",
                column: "ItemId1",
                principalTable: "Item",
                principalColumn: "ItemId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Item_List_ListId",
                table: "Item",
                column: "ListId",
                principalTable: "List",
                principalColumn: "ListId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
