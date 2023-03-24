using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class AddConnectionBetweenEngineAndEngineType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EngineTypeId",
                table: "Engines",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Engines_EngineTypeId",
                table: "Engines",
                column: "EngineTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Engines_EngineType_EngineTypeId",
                table: "Engines",
                column: "EngineTypeId",
                principalTable: "EngineType",
                principalColumn: "EngineTypeId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Engines_EngineType_EngineTypeId",
                table: "Engines");

            migrationBuilder.DropIndex(
                name: "IX_Engines_EngineTypeId",
                table: "Engines");

            migrationBuilder.DropColumn(
                name: "EngineTypeId",
                table: "Engines");
        }
    }
}
