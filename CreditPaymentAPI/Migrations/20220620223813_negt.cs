using Microsoft.EntityFrameworkCore.Migrations;

namespace CreditPaymentAPI.Migrations
{
    public partial class negt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "OwnerName",
                table: "PaymentDetailList",
                newName: "CardOwnerName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CardOwnerName",
                table: "PaymentDetailList",
                newName: "OwnerName");
        }
    }
}
