using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TheSkyHomestay.Data.Migrations
{
    public partial class AddBookingListToBill : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "User",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 5, 0, 43, 0, 755, DateTimeKind.Local).AddTicks(5748),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 29, 0, 10, 29, 171, DateTimeKind.Local).AddTicks(9339));

            migrationBuilder.AlterColumn<DateTime>(
                name: "RegisteredTime",
                table: "User",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 5, 0, 43, 0, 755, DateTimeKind.Local).AddTicks(5581),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 29, 0, 10, 29, 171, DateTimeKind.Local).AddTicks(9210));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "Services",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 5, 0, 43, 0, 755, DateTimeKind.Local).AddTicks(4754),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 29, 0, 10, 29, 171, DateTimeKind.Local).AddTicks(8661));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Services",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 5, 0, 43, 0, 755, DateTimeKind.Local).AddTicks(4609),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 29, 0, 10, 29, 171, DateTimeKind.Local).AddTicks(8551));

            migrationBuilder.AlterColumn<DateTime>(
                name: "BookingTime",
                table: "ServiceBookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 5, 0, 43, 0, 755, DateTimeKind.Local).AddTicks(8797),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 29, 0, 10, 29, 172, DateTimeKind.Local).AddTicks(1338));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "Rooms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 5, 0, 43, 0, 755, DateTimeKind.Local).AddTicks(3369),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 29, 0, 10, 29, 171, DateTimeKind.Local).AddTicks(7773));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Rooms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 5, 0, 43, 0, 755, DateTimeKind.Local).AddTicks(3213),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 29, 0, 10, 29, 171, DateTimeKind.Local).AddTicks(7650));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "RoomImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 5, 0, 43, 0, 756, DateTimeKind.Local).AddTicks(1356),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 29, 0, 10, 29, 172, DateTimeKind.Local).AddTicks(3012));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "RoomImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 5, 0, 43, 0, 756, DateTimeKind.Local).AddTicks(1208),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 29, 0, 10, 29, 172, DateTimeKind.Local).AddTicks(2916));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "RoomCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 5, 0, 43, 0, 755, DateTimeKind.Local).AddTicks(4025),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 29, 0, 10, 29, 171, DateTimeKind.Local).AddTicks(8178));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "RoomCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 5, 0, 43, 0, 755, DateTimeKind.Local).AddTicks(3889),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 29, 0, 10, 29, 171, DateTimeKind.Local).AddTicks(8090));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckOutDate",
                table: "RoomBookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 5, 0, 43, 0, 755, DateTimeKind.Local).AddTicks(6722),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 29, 0, 10, 29, 171, DateTimeKind.Local).AddTicks(9943));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckInDate",
                table: "RoomBookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 5, 0, 43, 0, 755, DateTimeKind.Local).AddTicks(6591),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 29, 0, 10, 29, 171, DateTimeKind.Local).AddTicks(9855));

            migrationBuilder.AlterColumn<DateTime>(
                name: "BookingTime",
                table: "RoomBookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 5, 0, 43, 0, 755, DateTimeKind.Local).AddTicks(6852),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 29, 0, 10, 29, 172, DateTimeKind.Local).AddTicks(66));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "Feedbacks",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 5, 0, 43, 0, 756, DateTimeKind.Local).AddTicks(680),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 29, 0, 10, 29, 172, DateTimeKind.Local).AddTicks(2552));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Feedbacks",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 5, 0, 43, 0, 756, DateTimeKind.Local).AddTicks(533),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 29, 0, 10, 29, 172, DateTimeKind.Local).AddTicks(2456));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Bills",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 5, 0, 43, 0, 756, DateTimeKind.Local).AddTicks(1778),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 29, 0, 10, 29, 172, DateTimeKind.Local).AddTicks(3268));

            migrationBuilder.UpdateData(
                table: "Bills",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2022, 10, 5, 0, 43, 0, 762, DateTimeKind.Local).AddTicks(1143));

            migrationBuilder.UpdateData(
                table: "Bills",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2022, 10, 5, 0, 43, 0, 762, DateTimeKind.Local).AddTicks(1145));

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2022, 10, 5, 0, 43, 0, 762, DateTimeKind.Local).AddTicks(1117), new DateTime(2022, 10, 5, 0, 43, 0, 762, DateTimeKind.Local).AddTicks(1119) });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2022, 10, 5, 0, 43, 0, 762, DateTimeKind.Local).AddTicks(1122), new DateTime(2022, 10, 5, 0, 43, 0, 762, DateTimeKind.Local).AddTicks(1122) });

            migrationBuilder.UpdateData(
                table: "RoomBookings",
                keyColumns: new[] { "BillId", "RoomId" },
                keyValues: new object[] { 1, 1 },
                column: "BookingTime",
                value: new DateTime(2022, 10, 5, 0, 43, 0, 762, DateTimeKind.Local).AddTicks(1170));

            migrationBuilder.UpdateData(
                table: "RoomBookings",
                keyColumns: new[] { "BillId", "RoomId" },
                keyValues: new object[] { 1, 3 },
                column: "BookingTime",
                value: new DateTime(2022, 10, 5, 0, 43, 0, 762, DateTimeKind.Local).AddTicks(1172));

            migrationBuilder.UpdateData(
                table: "RoomBookings",
                keyColumns: new[] { "BillId", "RoomId" },
                keyValues: new object[] { 2, 4 },
                column: "BookingTime",
                value: new DateTime(2022, 10, 5, 0, 43, 0, 762, DateTimeKind.Local).AddTicks(1174));

            migrationBuilder.UpdateData(
                table: "RoomCategories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2022, 10, 5, 0, 43, 0, 756, DateTimeKind.Local).AddTicks(3844), new DateTime(2022, 10, 5, 0, 43, 0, 756, DateTimeKind.Local).AddTicks(3844) });

            migrationBuilder.UpdateData(
                table: "RoomCategories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2022, 10, 5, 0, 43, 0, 756, DateTimeKind.Local).AddTicks(3846), new DateTime(2022, 10, 5, 0, 43, 0, 756, DateTimeKind.Local).AddTicks(3846) });

            migrationBuilder.UpdateData(
                table: "RoomImages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2022, 10, 5, 0, 43, 0, 762, DateTimeKind.Local).AddTicks(1214));

            migrationBuilder.UpdateData(
                table: "RoomImages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2022, 10, 5, 0, 43, 0, 762, DateTimeKind.Local).AddTicks(1215));

            migrationBuilder.UpdateData(
                table: "RoomImages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2022, 10, 5, 0, 43, 0, 762, DateTimeKind.Local).AddTicks(1216));

            migrationBuilder.UpdateData(
                table: "RoomImages",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedTime",
                value: new DateTime(2022, 10, 5, 0, 43, 0, 762, DateTimeKind.Local).AddTicks(1217));

            migrationBuilder.UpdateData(
                table: "RoomImages",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedTime",
                value: new DateTime(2022, 10, 5, 0, 43, 0, 762, DateTimeKind.Local).AddTicks(1218));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2022, 10, 5, 0, 43, 0, 756, DateTimeKind.Local).AddTicks(3705), new DateTime(2022, 10, 5, 0, 43, 0, 756, DateTimeKind.Local).AddTicks(3707) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2022, 10, 5, 0, 43, 0, 756, DateTimeKind.Local).AddTicks(3709), new DateTime(2022, 10, 5, 0, 43, 0, 756, DateTimeKind.Local).AddTicks(3709) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2022, 10, 5, 0, 43, 0, 756, DateTimeKind.Local).AddTicks(3711), new DateTime(2022, 10, 5, 0, 43, 0, 756, DateTimeKind.Local).AddTicks(3711) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2022, 10, 5, 0, 43, 0, 756, DateTimeKind.Local).AddTicks(3712), new DateTime(2022, 10, 5, 0, 43, 0, 756, DateTimeKind.Local).AddTicks(3713) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2022, 10, 5, 0, 43, 0, 756, DateTimeKind.Local).AddTicks(3714), new DateTime(2022, 10, 5, 0, 43, 0, 756, DateTimeKind.Local).AddTicks(3715) });

            migrationBuilder.UpdateData(
                table: "ServiceBookings",
                keyColumns: new[] { "BillId", "ServiceId" },
                keyValues: new object[] { 1, 1 },
                column: "BookingTime",
                value: new DateTime(2022, 10, 5, 0, 43, 0, 762, DateTimeKind.Local).AddTicks(1195));

            migrationBuilder.UpdateData(
                table: "ServiceBookings",
                keyColumns: new[] { "BillId", "ServiceId" },
                keyValues: new object[] { 1, 2 },
                column: "BookingTime",
                value: new DateTime(2022, 10, 5, 0, 43, 0, 762, DateTimeKind.Local).AddTicks(1197));

            migrationBuilder.UpdateData(
                table: "ServiceBookings",
                keyColumns: new[] { "BillId", "ServiceId" },
                keyValues: new object[] { 2, 1 },
                column: "BookingTime",
                value: new DateTime(2022, 10, 5, 0, 43, 0, 762, DateTimeKind.Local).AddTicks(1198));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2022, 10, 5, 0, 43, 0, 756, DateTimeKind.Local).AddTicks(3864), new DateTime(2022, 10, 5, 0, 43, 0, 756, DateTimeKind.Local).AddTicks(3865) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2022, 10, 5, 0, 43, 0, 756, DateTimeKind.Local).AddTicks(3867), new DateTime(2022, 10, 5, 0, 43, 0, 756, DateTimeKind.Local).AddTicks(3867) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2022, 10, 5, 0, 43, 0, 756, DateTimeKind.Local).AddTicks(3868), new DateTime(2022, 10, 5, 0, 43, 0, 756, DateTimeKind.Local).AddTicks(3869) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("372ea575-2536-4076-9bab-3e3138de495f"),
                columns: new[] { "ConcurrencyStamp", "Password" },
                values: new object[] { "08b18ac0-0002-48ab-a93b-baa87e6596bf", "AQAAAAEAACcQAAAAEPMHmd59I/yu1Ureg7FfFCCIxVs2BDeerwCvuEGH2+l6+afwPhZLDFqHtiZL/YZD6A==" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("51b4b238-4ae0-4e46-a3f4-e0acf7666b15"),
                columns: new[] { "ConcurrencyStamp", "Password" },
                values: new object[] { "92d82f2c-a2aa-4eac-a2f4-e2129c453898", "AQAAAAEAACcQAAAAEMXbXTQeFYYdoZgCFopJOVTEepRpLRHyiLS+N64faYL4k3t8BrRxmAB/Gu5HtURiyQ==" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("8a820adb-93d7-4c6f-9404-bdbfc14419f4"),
                columns: new[] { "ConcurrencyStamp", "Password" },
                values: new object[] { "181edfb5-eeda-421c-8a8b-035db90d8e47", "AQAAAAEAACcQAAAAEPugtNFn+XJvTMEsjei8VtS723DX2QCkc8Sxby9lqnBEItSZvSrXWGSyCQvUXZvCmA==" });

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "Id",
                keyValue: new Guid("8f7579ee-4af9-4b71-9ada-7f792f76dc31"),
                column: "ConcurrencyStamp",
                value: "c7ec92e6-49f3-4382-8e0d-6cff9bdf4564");

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "Id",
                keyValue: new Guid("9e87b492-5343-4272-9a34-fa5de7cffb22"),
                column: "ConcurrencyStamp",
                value: "a25d901e-7778-433e-beaa-6bd2a403beaa");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "User",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 29, 0, 10, 29, 171, DateTimeKind.Local).AddTicks(9339),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 5, 0, 43, 0, 755, DateTimeKind.Local).AddTicks(5748));

            migrationBuilder.AlterColumn<DateTime>(
                name: "RegisteredTime",
                table: "User",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 29, 0, 10, 29, 171, DateTimeKind.Local).AddTicks(9210),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 5, 0, 43, 0, 755, DateTimeKind.Local).AddTicks(5581));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "Services",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 29, 0, 10, 29, 171, DateTimeKind.Local).AddTicks(8661),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 5, 0, 43, 0, 755, DateTimeKind.Local).AddTicks(4754));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Services",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 29, 0, 10, 29, 171, DateTimeKind.Local).AddTicks(8551),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 5, 0, 43, 0, 755, DateTimeKind.Local).AddTicks(4609));

            migrationBuilder.AlterColumn<DateTime>(
                name: "BookingTime",
                table: "ServiceBookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 29, 0, 10, 29, 172, DateTimeKind.Local).AddTicks(1338),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 5, 0, 43, 0, 755, DateTimeKind.Local).AddTicks(8797));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "Rooms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 29, 0, 10, 29, 171, DateTimeKind.Local).AddTicks(7773),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 5, 0, 43, 0, 755, DateTimeKind.Local).AddTicks(3369));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Rooms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 29, 0, 10, 29, 171, DateTimeKind.Local).AddTicks(7650),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 5, 0, 43, 0, 755, DateTimeKind.Local).AddTicks(3213));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "RoomImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 29, 0, 10, 29, 172, DateTimeKind.Local).AddTicks(3012),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 5, 0, 43, 0, 756, DateTimeKind.Local).AddTicks(1356));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "RoomImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 29, 0, 10, 29, 172, DateTimeKind.Local).AddTicks(2916),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 5, 0, 43, 0, 756, DateTimeKind.Local).AddTicks(1208));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "RoomCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 29, 0, 10, 29, 171, DateTimeKind.Local).AddTicks(8178),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 5, 0, 43, 0, 755, DateTimeKind.Local).AddTicks(4025));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "RoomCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 29, 0, 10, 29, 171, DateTimeKind.Local).AddTicks(8090),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 5, 0, 43, 0, 755, DateTimeKind.Local).AddTicks(3889));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckOutDate",
                table: "RoomBookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 29, 0, 10, 29, 171, DateTimeKind.Local).AddTicks(9943),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 5, 0, 43, 0, 755, DateTimeKind.Local).AddTicks(6722));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckInDate",
                table: "RoomBookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 29, 0, 10, 29, 171, DateTimeKind.Local).AddTicks(9855),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 5, 0, 43, 0, 755, DateTimeKind.Local).AddTicks(6591));

            migrationBuilder.AlterColumn<DateTime>(
                name: "BookingTime",
                table: "RoomBookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 29, 0, 10, 29, 172, DateTimeKind.Local).AddTicks(66),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 5, 0, 43, 0, 755, DateTimeKind.Local).AddTicks(6852));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "Feedbacks",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 29, 0, 10, 29, 172, DateTimeKind.Local).AddTicks(2552),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 5, 0, 43, 0, 756, DateTimeKind.Local).AddTicks(680));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Feedbacks",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 29, 0, 10, 29, 172, DateTimeKind.Local).AddTicks(2456),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 5, 0, 43, 0, 756, DateTimeKind.Local).AddTicks(533));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Bills",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 29, 0, 10, 29, 172, DateTimeKind.Local).AddTicks(3268),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 5, 0, 43, 0, 756, DateTimeKind.Local).AddTicks(1778));

            migrationBuilder.UpdateData(
                table: "Bills",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2022, 9, 29, 0, 10, 29, 176, DateTimeKind.Local).AddTicks(3892));

            migrationBuilder.UpdateData(
                table: "Bills",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2022, 9, 29, 0, 10, 29, 176, DateTimeKind.Local).AddTicks(3894));

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2022, 9, 29, 0, 10, 29, 176, DateTimeKind.Local).AddTicks(3871), new DateTime(2022, 9, 29, 0, 10, 29, 176, DateTimeKind.Local).AddTicks(3872) });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2022, 9, 29, 0, 10, 29, 176, DateTimeKind.Local).AddTicks(3874), new DateTime(2022, 9, 29, 0, 10, 29, 176, DateTimeKind.Local).AddTicks(3875) });

            migrationBuilder.UpdateData(
                table: "RoomBookings",
                keyColumns: new[] { "BillId", "RoomId" },
                keyValues: new object[] { 1, 1 },
                column: "BookingTime",
                value: new DateTime(2022, 9, 29, 0, 10, 29, 176, DateTimeKind.Local).AddTicks(3915));

            migrationBuilder.UpdateData(
                table: "RoomBookings",
                keyColumns: new[] { "BillId", "RoomId" },
                keyValues: new object[] { 1, 3 },
                column: "BookingTime",
                value: new DateTime(2022, 9, 29, 0, 10, 29, 176, DateTimeKind.Local).AddTicks(3917));

            migrationBuilder.UpdateData(
                table: "RoomBookings",
                keyColumns: new[] { "BillId", "RoomId" },
                keyValues: new object[] { 2, 4 },
                column: "BookingTime",
                value: new DateTime(2022, 9, 29, 0, 10, 29, 176, DateTimeKind.Local).AddTicks(3919));

            migrationBuilder.UpdateData(
                table: "RoomCategories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2022, 9, 29, 0, 10, 29, 172, DateTimeKind.Local).AddTicks(4651), new DateTime(2022, 9, 29, 0, 10, 29, 172, DateTimeKind.Local).AddTicks(4652) });

            migrationBuilder.UpdateData(
                table: "RoomCategories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2022, 9, 29, 0, 10, 29, 172, DateTimeKind.Local).AddTicks(4653), new DateTime(2022, 9, 29, 0, 10, 29, 172, DateTimeKind.Local).AddTicks(4653) });

            migrationBuilder.UpdateData(
                table: "RoomImages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2022, 9, 29, 0, 10, 29, 176, DateTimeKind.Local).AddTicks(3958));

            migrationBuilder.UpdateData(
                table: "RoomImages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2022, 9, 29, 0, 10, 29, 176, DateTimeKind.Local).AddTicks(3959));

            migrationBuilder.UpdateData(
                table: "RoomImages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2022, 9, 29, 0, 10, 29, 176, DateTimeKind.Local).AddTicks(3960));

            migrationBuilder.UpdateData(
                table: "RoomImages",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedTime",
                value: new DateTime(2022, 9, 29, 0, 10, 29, 176, DateTimeKind.Local).AddTicks(3961));

            migrationBuilder.UpdateData(
                table: "RoomImages",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedTime",
                value: new DateTime(2022, 9, 29, 0, 10, 29, 176, DateTimeKind.Local).AddTicks(3962));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2022, 9, 29, 0, 10, 29, 172, DateTimeKind.Local).AddTicks(4533), new DateTime(2022, 9, 29, 0, 10, 29, 172, DateTimeKind.Local).AddTicks(4535) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2022, 9, 29, 0, 10, 29, 172, DateTimeKind.Local).AddTicks(4536), new DateTime(2022, 9, 29, 0, 10, 29, 172, DateTimeKind.Local).AddTicks(4537) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2022, 9, 29, 0, 10, 29, 172, DateTimeKind.Local).AddTicks(4538), new DateTime(2022, 9, 29, 0, 10, 29, 172, DateTimeKind.Local).AddTicks(4538) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2022, 9, 29, 0, 10, 29, 172, DateTimeKind.Local).AddTicks(4539), new DateTime(2022, 9, 29, 0, 10, 29, 172, DateTimeKind.Local).AddTicks(4539) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2022, 9, 29, 0, 10, 29, 172, DateTimeKind.Local).AddTicks(4540), new DateTime(2022, 9, 29, 0, 10, 29, 172, DateTimeKind.Local).AddTicks(4540) });

            migrationBuilder.UpdateData(
                table: "ServiceBookings",
                keyColumns: new[] { "BillId", "ServiceId" },
                keyValues: new object[] { 1, 1 },
                column: "BookingTime",
                value: new DateTime(2022, 9, 29, 0, 10, 29, 176, DateTimeKind.Local).AddTicks(3939));

            migrationBuilder.UpdateData(
                table: "ServiceBookings",
                keyColumns: new[] { "BillId", "ServiceId" },
                keyValues: new object[] { 1, 2 },
                column: "BookingTime",
                value: new DateTime(2022, 9, 29, 0, 10, 29, 176, DateTimeKind.Local).AddTicks(3941));

            migrationBuilder.UpdateData(
                table: "ServiceBookings",
                keyColumns: new[] { "BillId", "ServiceId" },
                keyValues: new object[] { 2, 1 },
                column: "BookingTime",
                value: new DateTime(2022, 9, 29, 0, 10, 29, 176, DateTimeKind.Local).AddTicks(3942));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2022, 9, 29, 0, 10, 29, 172, DateTimeKind.Local).AddTicks(4666), new DateTime(2022, 9, 29, 0, 10, 29, 172, DateTimeKind.Local).AddTicks(4667) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2022, 9, 29, 0, 10, 29, 172, DateTimeKind.Local).AddTicks(4668), new DateTime(2022, 9, 29, 0, 10, 29, 172, DateTimeKind.Local).AddTicks(4668) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2022, 9, 29, 0, 10, 29, 172, DateTimeKind.Local).AddTicks(4669), new DateTime(2022, 9, 29, 0, 10, 29, 172, DateTimeKind.Local).AddTicks(4669) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("372ea575-2536-4076-9bab-3e3138de495f"),
                columns: new[] { "ConcurrencyStamp", "Password" },
                values: new object[] { "e6935f51-835f-4f57-9d97-5d1c9e89589f", "AQAAAAEAACcQAAAAEJD7DTzxsIXn7Be2lA1oQ71kt6/I/6NjyFQKLgyp1v4udK5nrQ2sJu51fQADaTRd4Q==" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("51b4b238-4ae0-4e46-a3f4-e0acf7666b15"),
                columns: new[] { "ConcurrencyStamp", "Password" },
                values: new object[] { "f4fa4814-79e4-4687-a51e-cd8793fb4143", "AQAAAAEAACcQAAAAEFhwflc7VhluZxmYQtGzQ/R6Wpl+KmSbnzlH8SelxGeMpsTAiUuLMlSm44+EQC3E0Q==" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("8a820adb-93d7-4c6f-9404-bdbfc14419f4"),
                columns: new[] { "ConcurrencyStamp", "Password" },
                values: new object[] { "bb87e47d-be66-46ca-8cd4-e6c43578d68e", "AQAAAAEAACcQAAAAELTwqetns19JKaQTtfvxH1TtzhulQijlOWYB4JmxF5I0Vp3b49nSTyg7tqUyJ6sp1A==" });

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "Id",
                keyValue: new Guid("8f7579ee-4af9-4b71-9ada-7f792f76dc31"),
                column: "ConcurrencyStamp",
                value: "c58b3bbe-5794-4ff4-9f7f-fbd86bc305a5");

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "Id",
                keyValue: new Guid("9e87b492-5343-4272-9a34-fa5de7cffb22"),
                column: "ConcurrencyStamp",
                value: "ba37df17-85ca-4bc1-aa39-56f8b42edcb1");
        }
    }
}
