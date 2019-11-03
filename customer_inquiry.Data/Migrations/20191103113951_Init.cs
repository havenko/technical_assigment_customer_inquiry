using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace customer_inquiry.Data.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 30, nullable: true),
                    Email = table.Column<string>(maxLength: 25, nullable: true),
                    MobileNo = table.Column<string>(maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Transactions",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CustomerID = table.Column<int>(nullable: false),
                    Timestamp = table.Column<DateTime>(nullable: false),
                    Amount = table.Column<decimal>(nullable: false),
                    CurrencyCode = table.Column<int>(nullable: false),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transactions", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Transactions_Customers_CustomerID",
                        column: x => x.CustomerID,
                        principalTable: "Customers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "ID", "Email", "MobileNo", "Name" },
                values: new object[] { 123456, "user1@domain.com", "0123456789", "Firstname1 Lastname1" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "ID", "Email", "MobileNo", "Name" },
                values: new object[] { 123457, "user2@domain.com", "0123456788", "Firstname2 Lastname2" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "ID", "Email", "MobileNo", "Name" },
                values: new object[] { 123458, "user3@domain.com", "0123456787", "Firstname3 Lastname3" });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "ID", "Amount", "CurrencyCode", "CustomerID", "Status", "Timestamp" },
                values: new object[] { 1, 1234.56m, 0, 123457, 0, new DateTime(2018, 2, 28, 21, 34, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "ID", "Amount", "CurrencyCode", "CustomerID", "Status", "Timestamp" },
                values: new object[] { 2, 1234.56m, 0, 123458, 0, new DateTime(2018, 2, 28, 21, 34, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "ID", "Amount", "CurrencyCode", "CustomerID", "Status", "Timestamp" },
                values: new object[] { 3, 0.56m, 8, 123458, 1, new DateTime(2018, 1, 11, 8, 34, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_CustomerID",
                table: "Transactions",
                column: "CustomerID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Transactions");

            migrationBuilder.DropTable(
                name: "Customers");
        }
    }
}
