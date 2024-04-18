using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace KenshuServiceDatabaseLibrary.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Billing_Data",
                columns: table => new
                {
                    billing_ym = table.Column<DateOnly>(type: "date", nullable: false),
                    member_id = table.Column<int>(type: "integer", nullable: false),
                    mail = table.Column<string>(type: "text", nullable: false),
                    name = table.Column<string>(type: "text", nullable: false),
                    address = table.Column<string>(type: "text", nullable: false),
                    member_start_date = table.Column<DateOnly>(type: "date", nullable: false),
                    member_end_date = table.Column<DateOnly>(type: "date", nullable: false),
                    payment_method = table.Column<int>(type: "integer", nullable: false),
                    amount = table.Column<int>(type: "integer", nullable: false),
                    tax_ratio = table.Column<int>(type: "integer", nullable: false),
                    total = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Billing_Data", x => new { x.billing_ym, x.member_id });
                });

            migrationBuilder.CreateTable(
                name: "Billing_Data_Detail",
                columns: table => new
                {
                    billing_ym = table.Column<DateOnly>(type: "date", nullable: false),
                    member_id = table.Column<int>(type: "integer", nullable: false),
                    charge_id = table.Column<int>(type: "integer", nullable: false),
                    name = table.Column<string>(type: "text", nullable: false),
                    start_date = table.Column<DateOnly>(type: "date", nullable: false),
                    end_date = table.Column<DateOnly>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Billing_Data_Detail", x => new { x.billing_ym, x.member_id, x.charge_id });
                });

            migrationBuilder.CreateTable(
                name: "Billing_Status",
                columns: table => new
                {
                    billing_ym = table.Column<DateOnly>(type: "date", nullable: false),
                    is_commited = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Billing_Status", x => x.billing_ym);
                });

            migrationBuilder.CreateTable(
                name: "Charges",
                columns: table => new
                {
                    charge_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    charge_name = table.Column<string>(type: "text", nullable: false),
                    amount = table.Column<int>(type: "integer", nullable: true),
                    startDate = table.Column<DateOnly>(type: "date", nullable: true),
                    endDate = table.Column<DateOnly>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Charges", x => x.charge_id);
                });

            migrationBuilder.CreateTable(
                name: "Members",
                columns: table => new
                {
                    member_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    mail = table.Column<string>(type: "text", nullable: false),
                    name = table.Column<string>(type: "text", nullable: false),
                    address = table.Column<string>(type: "text", nullable: true),
                    start_date = table.Column<DateOnly>(type: "date", nullable: true),
                    end_date = table.Column<DateOnly>(type: "date", nullable: true),
                    payment_method = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Members", x => x.member_id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Billing_Data");

            migrationBuilder.DropTable(
                name: "Billing_Data_Detail");

            migrationBuilder.DropTable(
                name: "Billing_Status");

            migrationBuilder.DropTable(
                name: "Charges");

            migrationBuilder.DropTable(
                name: "Members");
        }
    }
}
