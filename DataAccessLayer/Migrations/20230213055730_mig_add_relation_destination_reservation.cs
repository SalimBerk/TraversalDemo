using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class migaddrelationdestinationreservation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DesninationId",
                table: "Reservations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_DesninationId",
                table: "Reservations",
                column: "DesninationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_Desninations_DesninationId",
                table: "Reservations",
                column: "DesninationId",
                principalTable: "Desninations",
                principalColumn: "DesninationId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_Desninations_DesninationId",
                table: "Reservations");

            migrationBuilder.DropIndex(
                name: "IX_Reservations_DesninationId",
                table: "Reservations");

            migrationBuilder.DropColumn(
                name: "DesninationId",
                table: "Reservations");
        }
    }
}
