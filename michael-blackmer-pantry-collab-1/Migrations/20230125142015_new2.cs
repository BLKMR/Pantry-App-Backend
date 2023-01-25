using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace michaelblackmerpantrycollab1.Migrations
{
    /// <inheritdoc />
    public partial class new2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_Families_FamilyId",
                table: "Items");

            migrationBuilder.DropIndex(
                name: "IX_Items_FamilyId",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "FamilyId",
                table: "Items");

            migrationBuilder.RenameColumn(
                name: "PantryName",
                table: "Items",
                newName: "FamilyName");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FamilyName",
                table: "Items",
                newName: "PantryName");

            migrationBuilder.AddColumn<int>(
                name: "FamilyId",
                table: "Items",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Items_FamilyId",
                table: "Items",
                column: "FamilyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Families_FamilyId",
                table: "Items",
                column: "FamilyId",
                principalTable: "Families",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
