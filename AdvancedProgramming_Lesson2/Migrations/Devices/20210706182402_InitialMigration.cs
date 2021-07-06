using Microsoft.EntityFrameworkCore.Migrations;

namespace AdvancedProgramming_Lesson2.Migrations.Devices
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Device",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(nullable: true),
                    Producer = table.Column<string>(nullable: true),
                    Model = table.Column<string>(nullable: true),
                    ReliableUser = table.Column<string>(nullable: true),
                    Price = table.Column<double>(nullable: false),
                    Ticket = table.Column<int>(nullable: false),
                    Comments = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Device", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Device");
        }
    }
}
