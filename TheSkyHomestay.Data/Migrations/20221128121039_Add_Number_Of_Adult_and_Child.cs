using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TheSkyHomestay.Data.Migrations
{
    public partial class Add_Number_Of_Adult_and_Child : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "User",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 28, 19, 10, 38, 941, DateTimeKind.Local).AddTicks(4040),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 15, 15, 6, 22, 668, DateTimeKind.Local).AddTicks(8600));

            migrationBuilder.AlterColumn<DateTime>(
                name: "RegisteredTime",
                table: "User",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 28, 19, 10, 38, 941, DateTimeKind.Local).AddTicks(3913),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 15, 15, 6, 22, 668, DateTimeKind.Local).AddTicks(8481));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "Services",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 28, 19, 10, 38, 941, DateTimeKind.Local).AddTicks(3179),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 15, 15, 6, 22, 668, DateTimeKind.Local).AddTicks(7896));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Services",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 28, 19, 10, 38, 941, DateTimeKind.Local).AddTicks(3067),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 15, 15, 6, 22, 668, DateTimeKind.Local).AddTicks(7812));

            migrationBuilder.AlterColumn<DateTime>(
                name: "BookingTime",
                table: "ServiceBookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 28, 19, 10, 38, 941, DateTimeKind.Local).AddTicks(6267),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 15, 15, 6, 22, 669, DateTimeKind.Local).AddTicks(548));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "Rooms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 28, 19, 10, 38, 941, DateTimeKind.Local).AddTicks(1818),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 15, 15, 6, 22, 668, DateTimeKind.Local).AddTicks(6714));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Rooms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 28, 19, 10, 38, 941, DateTimeKind.Local).AddTicks(1708),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 15, 15, 6, 22, 668, DateTimeKind.Local).AddTicks(6536));

            migrationBuilder.AddColumn<int>(
                name: "AdultCapacity",
                table: "Rooms",
                type: "int",
                nullable: false,
                defaultValue: 2);

            migrationBuilder.AddColumn<int>(
                name: "ChildCapacity",
                table: "Rooms",
                type: "int",
                nullable: false,
                defaultValue: 1);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "RoomImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 28, 19, 10, 38, 941, DateTimeKind.Local).AddTicks(8264),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 15, 15, 6, 22, 669, DateTimeKind.Local).AddTicks(2563));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "RoomImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 28, 19, 10, 38, 941, DateTimeKind.Local).AddTicks(8160),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 15, 15, 6, 22, 669, DateTimeKind.Local).AddTicks(2415));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "RoomCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 28, 19, 10, 38, 941, DateTimeKind.Local).AddTicks(2534),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 15, 15, 6, 22, 668, DateTimeKind.Local).AddTicks(7352));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "RoomCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 28, 19, 10, 38, 941, DateTimeKind.Local).AddTicks(2447),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 15, 15, 6, 22, 668, DateTimeKind.Local).AddTicks(7255));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckOutDate",
                table: "RoomBookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 28, 19, 10, 38, 941, DateTimeKind.Local).AddTicks(4762),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 15, 15, 6, 22, 668, DateTimeKind.Local).AddTicks(9088));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckInDate",
                table: "RoomBookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 28, 19, 10, 38, 941, DateTimeKind.Local).AddTicks(4671),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 15, 15, 6, 22, 668, DateTimeKind.Local).AddTicks(8985));

            migrationBuilder.AlterColumn<DateTime>(
                name: "BookingTime",
                table: "RoomBookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 28, 19, 10, 38, 941, DateTimeKind.Local).AddTicks(4863),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 15, 15, 6, 22, 668, DateTimeKind.Local).AddTicks(9178));

            migrationBuilder.AddColumn<int>(
                name: "NumberOfAdult",
                table: "RoomBookings",
                type: "int",
                nullable: false,
                defaultValue: 2);

            migrationBuilder.AddColumn<int>(
                name: "NumberOfChild",
                table: "RoomBookings",
                type: "int",
                nullable: false,
                defaultValue: 1);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "Feedbacks",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 28, 19, 10, 38, 941, DateTimeKind.Local).AddTicks(7814),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 15, 15, 6, 22, 669, DateTimeKind.Local).AddTicks(1993));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Feedbacks",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 28, 19, 10, 38, 941, DateTimeKind.Local).AddTicks(7699),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 15, 15, 6, 22, 669, DateTimeKind.Local).AddTicks(1886));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Bills",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 28, 19, 10, 38, 941, DateTimeKind.Local).AddTicks(8540),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 15, 15, 6, 22, 669, DateTimeKind.Local).AddTicks(3452));

            migrationBuilder.UpdateData(
                table: "Bills",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2022, 11, 28, 19, 10, 38, 946, DateTimeKind.Local).AddTicks(7236));

            migrationBuilder.UpdateData(
                table: "Bills",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2022, 11, 28, 19, 10, 38, 946, DateTimeKind.Local).AddTicks(7237));

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2022, 11, 28, 19, 10, 38, 946, DateTimeKind.Local).AddTicks(7204), new DateTime(2022, 11, 28, 19, 10, 38, 946, DateTimeKind.Local).AddTicks(7215) });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2022, 11, 28, 19, 10, 38, 946, DateTimeKind.Local).AddTicks(7217), new DateTime(2022, 11, 28, 19, 10, 38, 946, DateTimeKind.Local).AddTicks(7218) });

            migrationBuilder.UpdateData(
                table: "RoomBookings",
                keyColumns: new[] { "BillId", "RoomId" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "BookingTime", "NumberOfAdult", "NumberOfChild" },
                values: new object[] { new DateTime(2022, 11, 28, 19, 10, 38, 946, DateTimeKind.Local).AddTicks(7255), 2, 1 });

            migrationBuilder.UpdateData(
                table: "RoomBookings",
                keyColumns: new[] { "BillId", "RoomId" },
                keyValues: new object[] { 1, 3 },
                columns: new[] { "BookingTime", "NumberOfAdult", "NumberOfChild" },
                values: new object[] { new DateTime(2022, 11, 28, 19, 10, 38, 946, DateTimeKind.Local).AddTicks(7258), 2, 1 });

            migrationBuilder.UpdateData(
                table: "RoomBookings",
                keyColumns: new[] { "BillId", "RoomId" },
                keyValues: new object[] { 2, 4 },
                columns: new[] { "BookingTime", "NumberOfAdult", "NumberOfChild" },
                values: new object[] { new DateTime(2022, 11, 28, 19, 10, 38, 946, DateTimeKind.Local).AddTicks(7259), 4, 2 });

            migrationBuilder.UpdateData(
                table: "RoomCategories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2022, 11, 28, 19, 10, 38, 942, DateTimeKind.Local).AddTicks(71), new DateTime(2022, 11, 28, 19, 10, 38, 942, DateTimeKind.Local).AddTicks(72) });

            migrationBuilder.UpdateData(
                table: "RoomCategories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2022, 11, 28, 19, 10, 38, 942, DateTimeKind.Local).AddTicks(73), new DateTime(2022, 11, 28, 19, 10, 38, 942, DateTimeKind.Local).AddTicks(74) });

            migrationBuilder.UpdateData(
                table: "RoomImages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2022, 11, 28, 19, 10, 38, 946, DateTimeKind.Local).AddTicks(7293));

            migrationBuilder.UpdateData(
                table: "RoomImages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2022, 11, 28, 19, 10, 38, 946, DateTimeKind.Local).AddTicks(7294));

            migrationBuilder.UpdateData(
                table: "RoomImages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2022, 11, 28, 19, 10, 38, 946, DateTimeKind.Local).AddTicks(7295));

            migrationBuilder.UpdateData(
                table: "RoomImages",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedTime",
                value: new DateTime(2022, 11, 28, 19, 10, 38, 946, DateTimeKind.Local).AddTicks(7296));

            migrationBuilder.UpdateData(
                table: "RoomImages",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedTime",
                value: new DateTime(2022, 11, 28, 19, 10, 38, 946, DateTimeKind.Local).AddTicks(7297));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AdultCapacity", "ChildCapacity", "CreatedTime", "UpdatedTime" },
                values: new object[] { 2, 1, new DateTime(2022, 11, 28, 19, 10, 38, 941, DateTimeKind.Local).AddTicks(9925), new DateTime(2022, 11, 28, 19, 10, 38, 941, DateTimeKind.Local).AddTicks(9927) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AdultCapacity", "ChildCapacity", "CreatedTime", "UpdatedTime" },
                values: new object[] { 2, 1, new DateTime(2022, 11, 28, 19, 10, 38, 941, DateTimeKind.Local).AddTicks(9929), new DateTime(2022, 11, 28, 19, 10, 38, 941, DateTimeKind.Local).AddTicks(9930) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AdultCapacity", "ChildCapacity", "CreatedTime", "UpdatedTime" },
                values: new object[] { 2, 1, new DateTime(2022, 11, 28, 19, 10, 38, 941, DateTimeKind.Local).AddTicks(9931), new DateTime(2022, 11, 28, 19, 10, 38, 941, DateTimeKind.Local).AddTicks(9932) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AdultCapacity", "ChildCapacity", "CreatedTime", "Description", "UpdatedTime" },
                values: new object[] { 4, 2, new DateTime(2022, 11, 28, 19, 10, 38, 941, DateTimeKind.Local).AddTicks(9933), "Phòng 2 giường cho 4 người ở", new DateTime(2022, 11, 28, 19, 10, 38, 941, DateTimeKind.Local).AddTicks(9934) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AdultCapacity", "ChildCapacity", "CreatedTime", "Description", "UpdatedTime" },
                values: new object[] { 4, 2, new DateTime(2022, 11, 28, 19, 10, 38, 941, DateTimeKind.Local).AddTicks(9935), "Phòng 2 giường cho 4 người ở", new DateTime(2022, 11, 28, 19, 10, 38, 941, DateTimeKind.Local).AddTicks(9935) });

            migrationBuilder.UpdateData(
                table: "ServiceBookings",
                keyColumns: new[] { "BillId", "ServiceId" },
                keyValues: new object[] { 1, 1 },
                column: "BookingTime",
                value: new DateTime(2022, 11, 28, 19, 10, 38, 946, DateTimeKind.Local).AddTicks(7277));

            migrationBuilder.UpdateData(
                table: "ServiceBookings",
                keyColumns: new[] { "BillId", "ServiceId" },
                keyValues: new object[] { 1, 2 },
                column: "BookingTime",
                value: new DateTime(2022, 11, 28, 19, 10, 38, 946, DateTimeKind.Local).AddTicks(7279));

            migrationBuilder.UpdateData(
                table: "ServiceBookings",
                keyColumns: new[] { "BillId", "ServiceId" },
                keyValues: new object[] { 2, 1 },
                column: "BookingTime",
                value: new DateTime(2022, 11, 28, 19, 10, 38, 946, DateTimeKind.Local).AddTicks(7280));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2022, 11, 28, 19, 10, 38, 942, DateTimeKind.Local).AddTicks(97), new DateTime(2022, 11, 28, 19, 10, 38, 942, DateTimeKind.Local).AddTicks(98) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2022, 11, 28, 19, 10, 38, 942, DateTimeKind.Local).AddTicks(100), new DateTime(2022, 11, 28, 19, 10, 38, 942, DateTimeKind.Local).AddTicks(100) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2022, 11, 28, 19, 10, 38, 942, DateTimeKind.Local).AddTicks(102), new DateTime(2022, 11, 28, 19, 10, 38, 942, DateTimeKind.Local).AddTicks(102) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("372ea575-2536-4076-9bab-3e3138de495f"),
                columns: new[] { "ConcurrencyStamp", "Password" },
                values: new object[] { "52bfbfea-8890-4570-a291-985d572350cc", "AQAAAAEAACcQAAAAEH25uwW6Lwu0EmXw7AbPsbW1+2n+tj7j0B/cQ6wlEqGcgk/hqDyqNCH050C8eNr74w==" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("51b4b238-4ae0-4e46-a3f4-e0acf7666b15"),
                columns: new[] { "ConcurrencyStamp", "Password" },
                values: new object[] { "11ca572b-38c1-457f-93ac-b8616ee042ab", "AQAAAAEAACcQAAAAEFtwYETtZD06Ab5ToMKgl892CqMWJ6b/FNXVSqRjWTE8/QHxv9vPscX46HDgcYpB7w==" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("8a820adb-93d7-4c6f-9404-bdbfc14419f4"),
                columns: new[] { "ConcurrencyStamp", "Password" },
                values: new object[] { "c3df0aaf-d187-477b-a38b-787a3a7ba468", "AQAAAAEAACcQAAAAEF2nBsFTy2ZMwn/C2LSOdXAqey20PYBbiGyahQK0Qe2vD3hcQWO2u4ykIy8ryCKezA==" });

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "Id",
                keyValue: new Guid("8f7579ee-4af9-4b71-9ada-7f792f76dc31"),
                column: "ConcurrencyStamp",
                value: "91c691d4-bc3f-4260-932b-e177b54c85da");

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "Id",
                keyValue: new Guid("9e87b492-5343-4272-9a34-fa5de7cffb22"),
                column: "ConcurrencyStamp",
                value: "ad7fda82-9b8d-42dc-b065-4c03406602ab");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AdultCapacity",
                table: "Rooms");

            migrationBuilder.DropColumn(
                name: "ChildCapacity",
                table: "Rooms");

            migrationBuilder.DropColumn(
                name: "NumberOfAdult",
                table: "RoomBookings");

            migrationBuilder.DropColumn(
                name: "NumberOfChild",
                table: "RoomBookings");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "User",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 15, 15, 6, 22, 668, DateTimeKind.Local).AddTicks(8600),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 28, 19, 10, 38, 941, DateTimeKind.Local).AddTicks(4040));

            migrationBuilder.AlterColumn<DateTime>(
                name: "RegisteredTime",
                table: "User",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 15, 15, 6, 22, 668, DateTimeKind.Local).AddTicks(8481),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 28, 19, 10, 38, 941, DateTimeKind.Local).AddTicks(3913));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "Services",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 15, 15, 6, 22, 668, DateTimeKind.Local).AddTicks(7896),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 28, 19, 10, 38, 941, DateTimeKind.Local).AddTicks(3179));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Services",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 15, 15, 6, 22, 668, DateTimeKind.Local).AddTicks(7812),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 28, 19, 10, 38, 941, DateTimeKind.Local).AddTicks(3067));

            migrationBuilder.AlterColumn<DateTime>(
                name: "BookingTime",
                table: "ServiceBookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 15, 15, 6, 22, 669, DateTimeKind.Local).AddTicks(548),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 28, 19, 10, 38, 941, DateTimeKind.Local).AddTicks(6267));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "Rooms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 15, 15, 6, 22, 668, DateTimeKind.Local).AddTicks(6714),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 28, 19, 10, 38, 941, DateTimeKind.Local).AddTicks(1818));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Rooms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 15, 15, 6, 22, 668, DateTimeKind.Local).AddTicks(6536),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 28, 19, 10, 38, 941, DateTimeKind.Local).AddTicks(1708));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "RoomImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 15, 15, 6, 22, 669, DateTimeKind.Local).AddTicks(2563),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 28, 19, 10, 38, 941, DateTimeKind.Local).AddTicks(8264));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "RoomImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 15, 15, 6, 22, 669, DateTimeKind.Local).AddTicks(2415),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 28, 19, 10, 38, 941, DateTimeKind.Local).AddTicks(8160));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "RoomCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 15, 15, 6, 22, 668, DateTimeKind.Local).AddTicks(7352),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 28, 19, 10, 38, 941, DateTimeKind.Local).AddTicks(2534));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "RoomCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 15, 15, 6, 22, 668, DateTimeKind.Local).AddTicks(7255),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 28, 19, 10, 38, 941, DateTimeKind.Local).AddTicks(2447));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckOutDate",
                table: "RoomBookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 15, 15, 6, 22, 668, DateTimeKind.Local).AddTicks(9088),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 28, 19, 10, 38, 941, DateTimeKind.Local).AddTicks(4762));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckInDate",
                table: "RoomBookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 15, 15, 6, 22, 668, DateTimeKind.Local).AddTicks(8985),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 28, 19, 10, 38, 941, DateTimeKind.Local).AddTicks(4671));

            migrationBuilder.AlterColumn<DateTime>(
                name: "BookingTime",
                table: "RoomBookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 15, 15, 6, 22, 668, DateTimeKind.Local).AddTicks(9178),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 28, 19, 10, 38, 941, DateTimeKind.Local).AddTicks(4863));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "Feedbacks",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 15, 15, 6, 22, 669, DateTimeKind.Local).AddTicks(1993),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 28, 19, 10, 38, 941, DateTimeKind.Local).AddTicks(7814));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Feedbacks",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 15, 15, 6, 22, 669, DateTimeKind.Local).AddTicks(1886),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 28, 19, 10, 38, 941, DateTimeKind.Local).AddTicks(7699));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Bills",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 15, 15, 6, 22, 669, DateTimeKind.Local).AddTicks(3452),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 28, 19, 10, 38, 941, DateTimeKind.Local).AddTicks(8540));

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
                columns: new[] { "CreatedTime", "Description", "UpdatedTime" },
                values: new object[] { new DateTime(2022, 11, 15, 15, 6, 22, 669, DateTimeKind.Local).AddTicks(6131), "Phòng 2 giường cho 2 người ở", new DateTime(2022, 11, 15, 15, 6, 22, 669, DateTimeKind.Local).AddTicks(6132) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedTime", "Description", "UpdatedTime" },
                values: new object[] { new DateTime(2022, 11, 15, 15, 6, 22, 669, DateTimeKind.Local).AddTicks(6133), "Phòng 2 giường cho 2 người ở", new DateTime(2022, 11, 15, 15, 6, 22, 669, DateTimeKind.Local).AddTicks(6133) });

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
    }
}
