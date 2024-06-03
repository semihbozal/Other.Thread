using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Other.Thread.Migrations
{
    /// <inheritdoc />
    public partial class Updated_Required_Field_Account_Entity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "Address",
                table: "AppAccounts",
                type: "character varying(500)",
                nullable: true,
                maxLength: 500);

            migrationBuilder.AlterColumn<bool>(
                name: "Phone",
                table: "AppAccounts",
                type: "character varying(50)",
                nullable: true,
                maxLength: 500);

            migrationBuilder.AlterColumn<bool>(
                name: "Email",
                table: "AppAccounts",
                type: "character varying(100)",
                nullable: true,
                maxLength: 500);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("UPDATE dbo.AppAccounts SET Address = COALESCE(Address, 'Migration Down')");
            migrationBuilder.Sql("UPDATE dbo.AppAccounts SET Phone = COALESCE(Phone, 'Migration Down')");
            migrationBuilder.Sql("UPDATE dbo.AppAccounts SET Email = COALESCE(Email, 'Migration Down')");

            migrationBuilder.AlterColumn<bool>(
                name: "Address",
                table: "AppAccounts",
                type: "character varying(500)",
                nullable: false,
                maxLength: 500);

            migrationBuilder.AlterColumn<bool>(
                name: "Phone",
                table: "AppAccounts",
                type: "character varying(50)",
                nullable: false,
                maxLength: 500);

            migrationBuilder.AlterColumn<bool>(
                name: "Email",
                table: "AppAccounts",
                type: "character varying(100)",
                nullable: false,
                maxLength: 500);
        }
    }
}
