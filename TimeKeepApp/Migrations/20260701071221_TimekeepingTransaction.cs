using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TimeKeepApp.Migrations
{
    /// <inheritdoc />
    public partial class TimekeepingTransaction : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TimekeepingTransaction",
                columns: table => new
                {
                    TimeKeepingTransactionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    TransactionTypeId = table.Column<int>(type: "int", nullable: false),
                    TransactionDateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TimekeepingTransaction", x => x.TimeKeepingTransactionId);
                    table.ForeignKey(
                        name: "FK_TimekeepingTransaction_Employee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employee",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TimekeepingTransaction_TransactionType_TransactionTypeId",
                        column: x => x.TransactionTypeId,
                        principalTable: "TransactionType",
                        principalColumn: "TransactionTypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TimekeepingTransaction_EmployeeId",
                table: "TimekeepingTransaction",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_TimekeepingTransaction_TransactionTypeId",
                table: "TimekeepingTransaction",
                column: "TransactionTypeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TimekeepingTransaction");
        }
    }
}
