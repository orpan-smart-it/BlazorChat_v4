using Microsoft.EntityFrameworkCore.Migrations;

namespace BlazorChat_v3.Api.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    ContactId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.ContactId);
                });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "ContactId", "FirstName", "LastName" },
                values: new object[] { 3, "Jack", "Rassel" });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "ContactId", "FirstName", "LastName" },
                values: new object[] { 1, "Anatoliy", "Rassel" });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "ContactId", "FirstName", "LastName" },
                values: new object[] { 2, "Lara", "Rassel" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contacts");
        }
    }
}
