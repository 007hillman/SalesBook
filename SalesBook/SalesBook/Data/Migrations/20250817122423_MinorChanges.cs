using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SalesBook.Migrations
{
    /// <inheritdoc />
    public partial class MinorChanges : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ItemTicket_Ticket_TicketId1",
                table: "ItemTicket");

            migrationBuilder.DropIndex(
                name: "IX_ItemTicket_TicketId1",
                table: "ItemTicket");

            migrationBuilder.DropColumn(
                name: "TicketId1",
                table: "ItemTicket");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TicketId1",
                table: "ItemTicket",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ItemTicket_TicketId1",
                table: "ItemTicket",
                column: "TicketId1");

            migrationBuilder.AddForeignKey(
                name: "FK_ItemTicket_Ticket_TicketId1",
                table: "ItemTicket",
                column: "TicketId1",
                principalTable: "Ticket",
                principalColumn: "Id");
        }
    }
}
