using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SumUpDashBoard.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SumUpTransactions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Date = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    Code = table.Column<string>(type: "text", nullable: false),
                    Type = table.Column<int>(type: "integer", nullable: false),
                    Reference = table.Column<string>(type: "text", nullable: false),
                    ReferencePaiement = table.Column<string>(type: "text", nullable: false),
                    Status = table.Column<int>(type: "integer", nullable: false),
                    MontantFactureDebit = table.Column<decimal>(type: "numeric", nullable: false),
                    MontantFactureCredit = table.Column<decimal>(type: "numeric", nullable: false),
                    Devise = table.Column<string>(type: "text", nullable: false),
                    MontantTransactionDebit = table.Column<decimal>(type: "numeric", nullable: false),
                    MontantTransactionCredit = table.Column<decimal>(type: "numeric", nullable: false),
                    DeviseTransaction = table.Column<string>(type: "text", nullable: false),
                    TauxChange = table.Column<decimal>(type: "numeric", nullable: false),
                    TauxFrais = table.Column<decimal>(type: "numeric", nullable: false),
                    Solde = table.Column<decimal>(type: "numeric", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SumUpTransactions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UrsaffTrimesters",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Year = table.Column<int>(type: "integer", nullable: false),
                    Trimester = table.Column<int>(type: "integer", nullable: false),
                    ReportableAmount = table.Column<decimal>(type: "numeric", nullable: false),
                    AmountTaxe = table.Column<decimal>(type: "numeric", nullable: false),
                    IsPaid = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UrsaffTrimesters", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Transactions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    SumUpTransactionId = table.Column<Guid>(type: "uuid", nullable: false),
                    TrimesterId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transactions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Transactions_SumUpTransactions_SumUpTransactionId",
                        column: x => x.SumUpTransactionId,
                        principalTable: "SumUpTransactions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Transactions_UrsaffTrimesters_TrimesterId",
                        column: x => x.TrimesterId,
                        principalTable: "UrsaffTrimesters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_SumUpTransactionId",
                table: "Transactions",
                column: "SumUpTransactionId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_TrimesterId",
                table: "Transactions",
                column: "TrimesterId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Transactions");

            migrationBuilder.DropTable(
                name: "SumUpTransactions");

            migrationBuilder.DropTable(
                name: "UrsaffTrimesters");
        }
    }
}
