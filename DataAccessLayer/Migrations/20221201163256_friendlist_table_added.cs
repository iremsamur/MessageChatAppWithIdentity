using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class friendlist_table_added : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Friendlists",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccountOwnerPersonID = table.Column<int>(type: "int", nullable: false),
                    FriendPersonID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Friendlists", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Friendlists_AspNetUsers_AccountOwnerPersonID",
                        column: x => x.AccountOwnerPersonID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Friendlists_AspNetUsers_FriendPersonID",
                        column: x => x.FriendPersonID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Friendlists_AccountOwnerPersonID",
                table: "Friendlists",
                column: "AccountOwnerPersonID");

            migrationBuilder.CreateIndex(
                name: "IX_Friendlists_FriendPersonID",
                table: "Friendlists",
                column: "FriendPersonID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Friendlists");
        }
    }
}
