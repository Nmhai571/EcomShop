using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eShopSolution.Migrations
{
    public partial class AddColumnOldPriceProduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "OldPrice",
                table: "Products",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: new Guid("f2994bad-dd70-486f-9345-02cac10a5466"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f4cc5798-91cf-429e-87b1-814f64484b2c", "AQAAAAEAACcQAAAAEBaqCRD4d/GaPPgIMFdpBrm3bLHEoGGkKGGWcOaV2P4e8KOftBeSqhAmip7msI/jaA==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2023, 4, 20, 0, 2, 51, 760, DateTimeKind.Local).AddTicks(9203));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2023, 4, 20, 0, 2, 51, 760, DateTimeKind.Local).AddTicks(9219));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("9b6fc39c-753f-460e-99a6-99bbd80ee262"),
                column: "ConcurrencyStamp",
                value: "f63987ed-bc27-4d1b-9461-3a1521f21846");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OldPrice",
                table: "Products");

            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: new Guid("f2994bad-dd70-486f-9345-02cac10a5466"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "94fae2f8-40d7-4402-93a7-2667d9fbccde", "AQAAAAEAACcQAAAAENPukDMMKZ7Z356VTKGhB1yajbcza1qPVev/hPtyfAO8CL0WvTpx8A4oTU/KdLxFtg==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2023, 4, 19, 23, 39, 25, 378, DateTimeKind.Local).AddTicks(6362));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2023, 4, 19, 23, 39, 25, 378, DateTimeKind.Local).AddTicks(6374));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("9b6fc39c-753f-460e-99a6-99bbd80ee262"),
                column: "ConcurrencyStamp",
                value: "c0f8bf05-94df-4004-99ad-ab9f6f6964f9");
        }
    }
}
