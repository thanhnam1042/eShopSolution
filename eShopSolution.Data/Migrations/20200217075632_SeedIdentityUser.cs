using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShopSolution.Data.Migrations
{
    public partial class SeedIdentityUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                nullable: false,
                defaultValue: new DateTime(2020, 2, 17, 14, 56, 31, 482, DateTimeKind.Local).AddTicks(1363),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 2, 17, 14, 47, 9, 337, DateTimeKind.Local).AddTicks(6806));

            migrationBuilder.InsertData(
                table: "AppRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[] { new Guid("8d730a44-9cd2-4500-9d56-cf680dd5dbc3"), "b43d96f7-96a4-4deb-a530-3e18870af251", "Administrator role", "admin", "admin" });

            migrationBuilder.InsertData(
                table: "AppUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { new Guid("7a7d9683-f436-4de9-bd78-09d6c6633db0"), new Guid("8d730a44-9cd2-4500-9d56-cf680dd5dbc3") });

            migrationBuilder.InsertData(
                table: "AppUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Dob", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("7a7d9683-f436-4de9-bd78-09d6c6633db0"), 0, "3a32866a-2641-497d-a5f2-78103354af2b", new DateTime(1995, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "thanhnam1042@gmail.com", true, "Nam", "Vo", false, null, "thanhnam1042@gmail.com", "admin", "AQAAAAEAACcQAAAAEKjzKhNTpOfxAuWmDkNUY7cyggvLAj9qtrtE5Ka88BAeONlddBntdy7RffT5OEJ+QA==", null, false, "", false, "admin" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2020, 2, 17, 14, 56, 31, 503, DateTimeKind.Local).AddTicks(8345));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d730a44-9cd2-4500-9d56-cf680dd5dbc3"));

            migrationBuilder.DeleteData(
                table: "AppUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("7a7d9683-f436-4de9-bd78-09d6c6633db0"), new Guid("8d730a44-9cd2-4500-9d56-cf680dd5dbc3") });

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("7a7d9683-f436-4de9-bd78-09d6c6633db0"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 2, 17, 14, 47, 9, 337, DateTimeKind.Local).AddTicks(6806),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 2, 17, 14, 56, 31, 482, DateTimeKind.Local).AddTicks(1363));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2020, 2, 17, 14, 47, 9, 361, DateTimeKind.Local).AddTicks(3174));
        }
    }
}
