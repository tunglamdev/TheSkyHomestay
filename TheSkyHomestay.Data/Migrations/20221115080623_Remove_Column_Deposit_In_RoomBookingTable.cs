using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TheSkyHomestay.Data.Migrations
{
    public partial class Remove_Column_Deposit_In_RoomBookingTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Deposit",
                table: "RoomBookings");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "User",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 15, 15, 6, 22, 668, DateTimeKind.Local).AddTicks(8600),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 4, 11, 11, 50, 717, DateTimeKind.Local).AddTicks(8416));

            migrationBuilder.AlterColumn<DateTime>(
                name: "RegisteredTime",
                table: "User",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 15, 15, 6, 22, 668, DateTimeKind.Local).AddTicks(8481),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 4, 11, 11, 50, 717, DateTimeKind.Local).AddTicks(8213));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "Services",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 15, 15, 6, 22, 668, DateTimeKind.Local).AddTicks(7896),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 4, 11, 11, 50, 717, DateTimeKind.Local).AddTicks(7303));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Services",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 15, 15, 6, 22, 668, DateTimeKind.Local).AddTicks(7812),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 4, 11, 11, 50, 717, DateTimeKind.Local).AddTicks(7186));

            migrationBuilder.AlterColumn<DateTime>(
                name: "BookingTime",
                table: "ServiceBookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 15, 15, 6, 22, 669, DateTimeKind.Local).AddTicks(548),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 4, 11, 11, 50, 718, DateTimeKind.Local).AddTicks(1721));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "Rooms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 15, 15, 6, 22, 668, DateTimeKind.Local).AddTicks(6714),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 4, 11, 11, 50, 717, DateTimeKind.Local).AddTicks(5575));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Rooms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 15, 15, 6, 22, 668, DateTimeKind.Local).AddTicks(6536),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 4, 11, 11, 50, 717, DateTimeKind.Local).AddTicks(5263));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "RoomImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 15, 15, 6, 22, 669, DateTimeKind.Local).AddTicks(2563),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 4, 11, 11, 50, 718, DateTimeKind.Local).AddTicks(4357));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "RoomImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 15, 15, 6, 22, 669, DateTimeKind.Local).AddTicks(2415),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 4, 11, 11, 50, 718, DateTimeKind.Local).AddTicks(4178));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "RoomCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 15, 15, 6, 22, 668, DateTimeKind.Local).AddTicks(7352),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 4, 11, 11, 50, 717, DateTimeKind.Local).AddTicks(6327));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "RoomCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 15, 15, 6, 22, 668, DateTimeKind.Local).AddTicks(7255),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 4, 11, 11, 50, 717, DateTimeKind.Local).AddTicks(6216));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckOutDate",
                table: "RoomBookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 15, 15, 6, 22, 668, DateTimeKind.Local).AddTicks(9088),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 4, 11, 11, 50, 717, DateTimeKind.Local).AddTicks(9492));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckInDate",
                table: "RoomBookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 15, 15, 6, 22, 668, DateTimeKind.Local).AddTicks(8985),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 4, 11, 11, 50, 717, DateTimeKind.Local).AddTicks(9308));

            migrationBuilder.AlterColumn<DateTime>(
                name: "BookingTime",
                table: "RoomBookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 15, 15, 6, 22, 668, DateTimeKind.Local).AddTicks(9178),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 4, 11, 11, 50, 717, DateTimeKind.Local).AddTicks(9620));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "Feedbacks",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 15, 15, 6, 22, 669, DateTimeKind.Local).AddTicks(1993),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 4, 11, 11, 50, 718, DateTimeKind.Local).AddTicks(3669));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Feedbacks",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 15, 15, 6, 22, 669, DateTimeKind.Local).AddTicks(1886),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 4, 11, 11, 50, 718, DateTimeKind.Local).AddTicks(3530));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Bills",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 15, 15, 6, 22, 669, DateTimeKind.Local).AddTicks(3452),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 4, 11, 11, 50, 718, DateTimeKind.Local).AddTicks(4782));

            migrationBuilder.UpdateData(
                table: "Bills",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2022, 11, 15, 15, 6, 22, 673, DateTimeKind.Local).AddTicks(6781));

            migrationBuilder.UpdateData(
                table: "Bills",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2022, 11, 15, 15, 6, 22, 673, DateTimeKind.Local).AddTicks(6782));

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2022, 11, 15, 15, 6, 22, 673, DateTimeKind.Local).AddTicks(6768), new DateTime(2022, 11, 15, 15, 6, 22, 673, DateTimeKind.Local).AddTicks(6769) });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2022, 11, 15, 15, 6, 22, 673, DateTimeKind.Local).AddTicks(6770), new DateTime(2022, 11, 15, 15, 6, 22, 673, DateTimeKind.Local).AddTicks(6771) });

            migrationBuilder.UpdateData(
                table: "RoomBookings",
                keyColumns: new[] { "BillId", "RoomId" },
                keyValues: new object[] { 1, 1 },
                column: "BookingTime",
                value: new DateTime(2022, 11, 15, 15, 6, 22, 673, DateTimeKind.Local).AddTicks(6796));

            migrationBuilder.UpdateData(
                table: "RoomBookings",
                keyColumns: new[] { "BillId", "RoomId" },
                keyValues: new object[] { 1, 3 },
                column: "BookingTime",
                value: new DateTime(2022, 11, 15, 15, 6, 22, 673, DateTimeKind.Local).AddTicks(6798));

            migrationBuilder.UpdateData(
                table: "RoomBookings",
                keyColumns: new[] { "BillId", "RoomId" },
                keyValues: new object[] { 2, 4 },
                column: "BookingTime",
                value: new DateTime(2022, 11, 15, 15, 6, 22, 673, DateTimeKind.Local).AddTicks(6799));

            migrationBuilder.UpdateData(
                table: "RoomCategories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2022, 11, 15, 15, 6, 22, 669, DateTimeKind.Local).AddTicks(6245), new DateTime(2022, 11, 15, 15, 6, 22, 669, DateTimeKind.Local).AddTicks(6246) });

            migrationBuilder.UpdateData(
                table: "RoomCategories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2022, 11, 15, 15, 6, 22, 669, DateTimeKind.Local).AddTicks(6248), new DateTime(2022, 11, 15, 15, 6, 22, 669, DateTimeKind.Local).AddTicks(6248) });

            migrationBuilder.UpdateData(
                table: "RoomImages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2022, 11, 15, 15, 6, 22, 673, DateTimeKind.Local).AddTicks(6826));

            migrationBuilder.UpdateData(
                table: "RoomImages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2022, 11, 15, 15, 6, 22, 673, DateTimeKind.Local).AddTicks(6827));

            migrationBuilder.UpdateData(
                table: "RoomImages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2022, 11, 15, 15, 6, 22, 673, DateTimeKind.Local).AddTicks(6828));

            migrationBuilder.UpdateData(
                table: "RoomImages",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedTime",
                value: new DateTime(2022, 11, 15, 15, 6, 22, 673, DateTimeKind.Local).AddTicks(6829));

            migrationBuilder.UpdateData(
                table: "RoomImages",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedTime",
                value: new DateTime(2022, 11, 15, 15, 6, 22, 673, DateTimeKind.Local).AddTicks(6829));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2022, 11, 15, 15, 6, 22, 669, DateTimeKind.Local).AddTicks(6122), new DateTime(2022, 11, 15, 15, 6, 22, 669, DateTimeKind.Local).AddTicks(6126) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2022, 11, 15, 15, 6, 22, 669, DateTimeKind.Local).AddTicks(6128), new DateTime(2022, 11, 15, 15, 6, 22, 669, DateTimeKind.Local).AddTicks(6128) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2022, 11, 15, 15, 6, 22, 669, DateTimeKind.Local).AddTicks(6130), new DateTime(2022, 11, 15, 15, 6, 22, 669, DateTimeKind.Local).AddTicks(6130) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2022, 11, 15, 15, 6, 22, 669, DateTimeKind.Local).AddTicks(6131), new DateTime(2022, 11, 15, 15, 6, 22, 669, DateTimeKind.Local).AddTicks(6132) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2022, 11, 15, 15, 6, 22, 669, DateTimeKind.Local).AddTicks(6133), new DateTime(2022, 11, 15, 15, 6, 22, 669, DateTimeKind.Local).AddTicks(6133) });

            migrationBuilder.UpdateData(
                table: "ServiceBookings",
                keyColumns: new[] { "BillId", "ServiceId" },
                keyValues: new object[] { 1, 1 },
                column: "BookingTime",
                value: new DateTime(2022, 11, 15, 15, 6, 22, 673, DateTimeKind.Local).AddTicks(6811));

            migrationBuilder.UpdateData(
                table: "ServiceBookings",
                keyColumns: new[] { "BillId", "ServiceId" },
                keyValues: new object[] { 1, 2 },
                column: "BookingTime",
                value: new DateTime(2022, 11, 15, 15, 6, 22, 673, DateTimeKind.Local).AddTicks(6812));

            migrationBuilder.UpdateData(
                table: "ServiceBookings",
                keyColumns: new[] { "BillId", "ServiceId" },
                keyValues: new object[] { 2, 1 },
                column: "BookingTime",
                value: new DateTime(2022, 11, 15, 15, 6, 22, 673, DateTimeKind.Local).AddTicks(6813));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2022, 11, 15, 15, 6, 22, 669, DateTimeKind.Local).AddTicks(6269), new DateTime(2022, 11, 15, 15, 6, 22, 669, DateTimeKind.Local).AddTicks(6270) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2022, 11, 15, 15, 6, 22, 669, DateTimeKind.Local).AddTicks(6272), new DateTime(2022, 11, 15, 15, 6, 22, 669, DateTimeKind.Local).AddTicks(6272) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2022, 11, 15, 15, 6, 22, 669, DateTimeKind.Local).AddTicks(6273), new DateTime(2022, 11, 15, 15, 6, 22, 669, DateTimeKind.Local).AddTicks(6274) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("372ea575-2536-4076-9bab-3e3138de495f"),
                columns: new[] { "ConcurrencyStamp", "Password" },
                values: new object[] { "adf1a107-85c4-428b-8655-37e950754188", "AQAAAAEAACcQAAAAEEMycdzy7yNfietFe+2odGCOJq7E0BhKy8G08ZDmCZTBGQXox6WNvlbtgoy5dGsqYQ==" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("51b4b238-4ae0-4e46-a3f4-e0acf7666b15"),
                columns: new[] { "ConcurrencyStamp", "Password" },
                values: new object[] { "68540d03-be7d-4580-8414-f0adea9c1a11", "AQAAAAEAACcQAAAAENlWiX70XL+Rk2bnUsVyBUGFhHQtmqDgDWWy+e+gMO6HmlnfCUkLAjZzzpjI4OTC9w==" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("8a820adb-93d7-4c6f-9404-bdbfc14419f4"),
                columns: new[] { "ConcurrencyStamp", "Password" },
                values: new object[] { "4812ffa3-6edd-4f59-9cbb-4c986e176b67", "AQAAAAEAACcQAAAAEDE64zcSq1bpsDlVH87q4PGspcjapludZO695xxlZ0AnL6fMcr7jstwJQZJ0BGkRKQ==" });

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "Id",
                keyValue: new Guid("8f7579ee-4af9-4b71-9ada-7f792f76dc31"),
                column: "ConcurrencyStamp",
                value: "f313714b-469e-4ef3-b1bc-e7bb18318c8b");

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "Id",
                keyValue: new Guid("9e87b492-5343-4272-9a34-fa5de7cffb22"),
                column: "ConcurrencyStamp",
                value: "09433f1b-580a-4abe-95ba-70a782539603");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "User",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 4, 11, 11, 50, 717, DateTimeKind.Local).AddTicks(8416),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 15, 15, 6, 22, 668, DateTimeKind.Local).AddTicks(8600));

            migrationBuilder.AlterColumn<DateTime>(
                name: "RegisteredTime",
                table: "User",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 4, 11, 11, 50, 717, DateTimeKind.Local).AddTicks(8213),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 15, 15, 6, 22, 668, DateTimeKind.Local).AddTicks(8481));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "Services",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 4, 11, 11, 50, 717, DateTimeKind.Local).AddTicks(7303),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 15, 15, 6, 22, 668, DateTimeKind.Local).AddTicks(7896));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Services",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 4, 11, 11, 50, 717, DateTimeKind.Local).AddTicks(7186),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 15, 15, 6, 22, 668, DateTimeKind.Local).AddTicks(7812));

            migrationBuilder.AlterColumn<DateTime>(
                name: "BookingTime",
                table: "ServiceBookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 4, 11, 11, 50, 718, DateTimeKind.Local).AddTicks(1721),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 15, 15, 6, 22, 669, DateTimeKind.Local).AddTicks(548));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "Rooms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 4, 11, 11, 50, 717, DateTimeKind.Local).AddTicks(5575),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 15, 15, 6, 22, 668, DateTimeKind.Local).AddTicks(6714));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Rooms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 4, 11, 11, 50, 717, DateTimeKind.Local).AddTicks(5263),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 15, 15, 6, 22, 668, DateTimeKind.Local).AddTicks(6536));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "RoomImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 4, 11, 11, 50, 718, DateTimeKind.Local).AddTicks(4357),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 15, 15, 6, 22, 669, DateTimeKind.Local).AddTicks(2563));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "RoomImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 4, 11, 11, 50, 718, DateTimeKind.Local).AddTicks(4178),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 15, 15, 6, 22, 669, DateTimeKind.Local).AddTicks(2415));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "RoomCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 4, 11, 11, 50, 717, DateTimeKind.Local).AddTicks(6327),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 15, 15, 6, 22, 668, DateTimeKind.Local).AddTicks(7352));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "RoomCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 4, 11, 11, 50, 717, DateTimeKind.Local).AddTicks(6216),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 15, 15, 6, 22, 668, DateTimeKind.Local).AddTicks(7255));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckOutDate",
                table: "RoomBookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 4, 11, 11, 50, 717, DateTimeKind.Local).AddTicks(9492),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 15, 15, 6, 22, 668, DateTimeKind.Local).AddTicks(9088));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckInDate",
                table: "RoomBookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 4, 11, 11, 50, 717, DateTimeKind.Local).AddTicks(9308),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 15, 15, 6, 22, 668, DateTimeKind.Local).AddTicks(8985));

            migrationBuilder.AlterColumn<DateTime>(
                name: "BookingTime",
                table: "RoomBookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 4, 11, 11, 50, 717, DateTimeKind.Local).AddTicks(9620),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 15, 15, 6, 22, 668, DateTimeKind.Local).AddTicks(9178));

            migrationBuilder.AddColumn<decimal>(
                name: "Deposit",
                table: "RoomBookings",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "Feedbacks",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 4, 11, 11, 50, 718, DateTimeKind.Local).AddTicks(3669),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 15, 15, 6, 22, 669, DateTimeKind.Local).AddTicks(1993));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Feedbacks",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 4, 11, 11, 50, 718, DateTimeKind.Local).AddTicks(3530),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 15, 15, 6, 22, 669, DateTimeKind.Local).AddTicks(1886));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Bills",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 4, 11, 11, 50, 718, DateTimeKind.Local).AddTicks(4782),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 15, 15, 6, 22, 669, DateTimeKind.Local).AddTicks(3452));

            migrationBuilder.UpdateData(
                table: "Bills",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2022, 11, 4, 11, 11, 50, 724, DateTimeKind.Local).AddTicks(4963));

            migrationBuilder.UpdateData(
                table: "Bills",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2022, 11, 4, 11, 11, 50, 724, DateTimeKind.Local).AddTicks(4965));

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2022, 11, 4, 11, 11, 50, 724, DateTimeKind.Local).AddTicks(4930), new DateTime(2022, 11, 4, 11, 11, 50, 724, DateTimeKind.Local).AddTicks(4936) });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2022, 11, 4, 11, 11, 50, 724, DateTimeKind.Local).AddTicks(4939), new DateTime(2022, 11, 4, 11, 11, 50, 724, DateTimeKind.Local).AddTicks(4940) });

            migrationBuilder.UpdateData(
                table: "RoomBookings",
                keyColumns: new[] { "BillId", "RoomId" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "BookingTime", "Deposit" },
                values: new object[] { new DateTime(2022, 11, 4, 11, 11, 50, 724, DateTimeKind.Local).AddTicks(4991), 200000m });

            migrationBuilder.UpdateData(
                table: "RoomBookings",
                keyColumns: new[] { "BillId", "RoomId" },
                keyValues: new object[] { 1, 3 },
                columns: new[] { "BookingTime", "Deposit" },
                values: new object[] { new DateTime(2022, 11, 4, 11, 11, 50, 724, DateTimeKind.Local).AddTicks(4994), 200000m });

            migrationBuilder.UpdateData(
                table: "RoomBookings",
                keyColumns: new[] { "BillId", "RoomId" },
                keyValues: new object[] { 2, 4 },
                columns: new[] { "BookingTime", "Deposit" },
                values: new object[] { new DateTime(2022, 11, 4, 11, 11, 50, 724, DateTimeKind.Local).AddTicks(4995), 500000m });

            migrationBuilder.UpdateData(
                table: "RoomCategories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2022, 11, 4, 11, 11, 50, 718, DateTimeKind.Local).AddTicks(7059), new DateTime(2022, 11, 4, 11, 11, 50, 718, DateTimeKind.Local).AddTicks(7059) });

            migrationBuilder.UpdateData(
                table: "RoomCategories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2022, 11, 4, 11, 11, 50, 718, DateTimeKind.Local).AddTicks(7061), new DateTime(2022, 11, 4, 11, 11, 50, 718, DateTimeKind.Local).AddTicks(7062) });

            migrationBuilder.UpdateData(
                table: "RoomImages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2022, 11, 4, 11, 11, 50, 724, DateTimeKind.Local).AddTicks(5039));

            migrationBuilder.UpdateData(
                table: "RoomImages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2022, 11, 4, 11, 11, 50, 724, DateTimeKind.Local).AddTicks(5041));

            migrationBuilder.UpdateData(
                table: "RoomImages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2022, 11, 4, 11, 11, 50, 724, DateTimeKind.Local).AddTicks(5042));

            migrationBuilder.UpdateData(
                table: "RoomImages",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedTime",
                value: new DateTime(2022, 11, 4, 11, 11, 50, 724, DateTimeKind.Local).AddTicks(5043));

            migrationBuilder.UpdateData(
                table: "RoomImages",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedTime",
                value: new DateTime(2022, 11, 4, 11, 11, 50, 724, DateTimeKind.Local).AddTicks(5044));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2022, 11, 4, 11, 11, 50, 718, DateTimeKind.Local).AddTicks(6888), new DateTime(2022, 11, 4, 11, 11, 50, 718, DateTimeKind.Local).AddTicks(6890) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2022, 11, 4, 11, 11, 50, 718, DateTimeKind.Local).AddTicks(6892), new DateTime(2022, 11, 4, 11, 11, 50, 718, DateTimeKind.Local).AddTicks(6893) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2022, 11, 4, 11, 11, 50, 718, DateTimeKind.Local).AddTicks(6894), new DateTime(2022, 11, 4, 11, 11, 50, 718, DateTimeKind.Local).AddTicks(6894) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2022, 11, 4, 11, 11, 50, 718, DateTimeKind.Local).AddTicks(6896), new DateTime(2022, 11, 4, 11, 11, 50, 718, DateTimeKind.Local).AddTicks(6896) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2022, 11, 4, 11, 11, 50, 718, DateTimeKind.Local).AddTicks(6897), new DateTime(2022, 11, 4, 11, 11, 50, 718, DateTimeKind.Local).AddTicks(6898) });

            migrationBuilder.UpdateData(
                table: "ServiceBookings",
                keyColumns: new[] { "BillId", "ServiceId" },
                keyValues: new object[] { 1, 1 },
                column: "BookingTime",
                value: new DateTime(2022, 11, 4, 11, 11, 50, 724, DateTimeKind.Local).AddTicks(5014));

            migrationBuilder.UpdateData(
                table: "ServiceBookings",
                keyColumns: new[] { "BillId", "ServiceId" },
                keyValues: new object[] { 1, 2 },
                column: "BookingTime",
                value: new DateTime(2022, 11, 4, 11, 11, 50, 724, DateTimeKind.Local).AddTicks(5017));

            migrationBuilder.UpdateData(
                table: "ServiceBookings",
                keyColumns: new[] { "BillId", "ServiceId" },
                keyValues: new object[] { 2, 1 },
                column: "BookingTime",
                value: new DateTime(2022, 11, 4, 11, 11, 50, 724, DateTimeKind.Local).AddTicks(5018));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2022, 11, 4, 11, 11, 50, 718, DateTimeKind.Local).AddTicks(7084), new DateTime(2022, 11, 4, 11, 11, 50, 718, DateTimeKind.Local).AddTicks(7085) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2022, 11, 4, 11, 11, 50, 718, DateTimeKind.Local).AddTicks(7087), new DateTime(2022, 11, 4, 11, 11, 50, 718, DateTimeKind.Local).AddTicks(7088) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2022, 11, 4, 11, 11, 50, 718, DateTimeKind.Local).AddTicks(7089), new DateTime(2022, 11, 4, 11, 11, 50, 718, DateTimeKind.Local).AddTicks(7090) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("372ea575-2536-4076-9bab-3e3138de495f"),
                columns: new[] { "ConcurrencyStamp", "Password" },
                values: new object[] { "5f0ee810-f85f-4959-9bf9-a27fca4ffff4", "AQAAAAEAACcQAAAAELMCm2tcKiEZnRUeMic2qI33ChCg3hWBOwlrWBUFxB911oiGhc8QZmdbCuSJScRfuA==" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("51b4b238-4ae0-4e46-a3f4-e0acf7666b15"),
                columns: new[] { "ConcurrencyStamp", "Password" },
                values: new object[] { "9011139a-e6b6-4c94-984d-3a1df954fa60", "AQAAAAEAACcQAAAAECoqDaE92Gk2EyvHNek48P8+T2bFkKriuhSzLyWsf6eLjV1Sswu/QpVPKDmppIpYpQ==" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("8a820adb-93d7-4c6f-9404-bdbfc14419f4"),
                columns: new[] { "ConcurrencyStamp", "Password" },
                values: new object[] { "16520604-6cc3-4060-a54d-628671ec9fa9", "AQAAAAEAACcQAAAAEEfo5kCYIJHYyN2tk0X+tnWCfJDeh5IHL7SMMTsXwaKV5loJkThhfsJi4El6ZknohQ==" });

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "Id",
                keyValue: new Guid("8f7579ee-4af9-4b71-9ada-7f792f76dc31"),
                column: "ConcurrencyStamp",
                value: "f65fb964-1a86-48f6-9676-4c907482dcc1");

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "Id",
                keyValue: new Guid("9e87b492-5343-4272-9a34-fa5de7cffb22"),
                column: "ConcurrencyStamp",
                value: "dfffe75f-4e0c-43a9-8642-a8a2dc9db6f4");
        }
    }
}
