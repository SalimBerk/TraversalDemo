using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class migdestinationguiderelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "GuideId",
                table: "Desninations",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Desninations_GuideId",
                table: "Desninations",
                column: "GuideId");

            migrationBuilder.AddForeignKey(
                name: "FK_Desninations_Guides_GuideId",
                table: "Desninations",
                column: "GuideId",
                principalTable: "Guides",
                principalColumn: "GuidId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Desninations_Guides_GuideId",
                table: "Desninations");

            migrationBuilder.DropIndex(
                name: "IX_Desninations_GuideId",
                table: "Desninations");

            migrationBuilder.DropColumn(
                name: "GuideId",
                table: "Desninations");
        }
    }
}
