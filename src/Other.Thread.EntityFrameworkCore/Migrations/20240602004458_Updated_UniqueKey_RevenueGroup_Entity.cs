using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Other.Thread.Migrations
{
    /// <inheritdoc />
    public partial class Updated_UniqueKey_RevenueGroup_Entity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_AppRevenueGroups_Code"
            );

            migrationBuilder.CreateIndex(
                name: "IX_AppRevenueGroups_Code_DeletionTime",
                table: "AppRevenueGroups",
                columns: new[] { "Code", "DeletionTime" },
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_AppRevenueGroups_Code_DeletionTime"
            );

            migrationBuilder.CreateIndex(
                name: "IX_AppRevenueGroups_Code",
                table: "AppRevenueGroups",
                column: "Code",
                unique: true);
        }
    }
}
