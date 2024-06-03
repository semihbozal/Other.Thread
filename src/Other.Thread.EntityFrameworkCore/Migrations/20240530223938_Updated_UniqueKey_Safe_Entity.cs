using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Other.Thread.Migrations
{
    /// <inheritdoc />
    public partial class Updated_UniqueKey_Safe_Entity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_AppSafes_Code"
            );

            migrationBuilder.CreateIndex(
                name: "IX_AppSafes_Code_DeletionTime",
                table: "AppSafes",
                columns: new[] { "Code", "DeletionTime" },
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_AppSafes_Code_DeletionTime"
            );

            migrationBuilder.CreateIndex(
                name: "IX_AppSafes_Code",
                table: "AppSafes",
                column: "Code",
                unique: true);
        }
    }
}
