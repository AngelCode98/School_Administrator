using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace School_Administrator.Migrations
{
    public partial class AddIndexToInstitution : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_institutions_Name",
                table: "institutions",
                column: "Name",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_institutions_Name",
                table: "institutions");
        }
    }
}
