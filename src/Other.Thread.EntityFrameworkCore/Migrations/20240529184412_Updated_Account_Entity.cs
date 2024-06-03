using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Other.Thread.Migrations
{
    /// <inheritdoc />
    public partial class Updated_Account_Entity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsCustomer",
                table: "AppAccounts",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsSuplier",
                table: "AppAccounts",
                type: "boolean",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsCustomer",
                table: "AppAccounts");

            migrationBuilder.DropColumn(
                name: "IsSuplier",
                table: "AppAccounts");
        }
    }
}
