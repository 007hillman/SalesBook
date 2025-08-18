using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SalesBook.Migrations
{
    /// <inheritdoc />
    public partial class AddedQuantityToJointTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Quantity",
                table: "ItemTicket",
                type: "TEXT",
                nullable: false,
                defaultValue: 0m);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "ItemTicket");
        }
    }
}
