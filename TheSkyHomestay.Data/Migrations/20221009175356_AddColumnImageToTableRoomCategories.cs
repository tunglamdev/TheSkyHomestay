using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TheSkyHomestay.Data.Migrations
{
    public partial class AddColumnImageToTableRoomCategories : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "User",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 10, 0, 53, 56, 227, DateTimeKind.Local).AddTicks(1416),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 5, 0, 43, 0, 755, DateTimeKind.Local).AddTicks(5748));

            migrationBuilder.AlterColumn<DateTime>(
                name: "RegisteredTime",
                table: "User",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 10, 0, 53, 56, 227, DateTimeKind.Local).AddTicks(1270),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 5, 0, 43, 0, 755, DateTimeKind.Local).AddTicks(5581));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "Services",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 10, 0, 53, 56, 227, DateTimeKind.Local).AddTicks(729),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 5, 0, 43, 0, 755, DateTimeKind.Local).AddTicks(4754));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Services",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 10, 0, 53, 56, 227, DateTimeKind.Local).AddTicks(625),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 5, 0, 43, 0, 755, DateTimeKind.Local).AddTicks(4609));

            migrationBuilder.AlterColumn<DateTime>(
                name: "BookingTime",
                table: "ServiceBookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 10, 0, 53, 56, 227, DateTimeKind.Local).AddTicks(3610),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 5, 0, 43, 0, 755, DateTimeKind.Local).AddTicks(8797));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "Rooms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 10, 0, 53, 56, 226, DateTimeKind.Local).AddTicks(9561),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 5, 0, 43, 0, 755, DateTimeKind.Local).AddTicks(3369));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Rooms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 10, 0, 53, 56, 226, DateTimeKind.Local).AddTicks(9453),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 5, 0, 43, 0, 755, DateTimeKind.Local).AddTicks(3213));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "RoomImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 10, 0, 53, 56, 227, DateTimeKind.Local).AddTicks(5400),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 5, 0, 43, 0, 756, DateTimeKind.Local).AddTicks(1356));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "RoomImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 10, 0, 53, 56, 227, DateTimeKind.Local).AddTicks(5263),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 5, 0, 43, 0, 756, DateTimeKind.Local).AddTicks(1208));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "RoomCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 10, 0, 53, 56, 227, DateTimeKind.Local).AddTicks(193),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 5, 0, 43, 0, 755, DateTimeKind.Local).AddTicks(4025));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "RoomCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 10, 0, 53, 56, 227, DateTimeKind.Local).AddTicks(88),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 5, 0, 43, 0, 755, DateTimeKind.Local).AddTicks(3889));

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "RoomCategories",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "default.jpg");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckOutDate",
                table: "RoomBookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 10, 0, 53, 56, 227, DateTimeKind.Local).AddTicks(2043),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 5, 0, 43, 0, 755, DateTimeKind.Local).AddTicks(6722));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckInDate",
                table: "RoomBookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 10, 0, 53, 56, 227, DateTimeKind.Local).AddTicks(1955),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 5, 0, 43, 0, 755, DateTimeKind.Local).AddTicks(6591));

            migrationBuilder.AlterColumn<DateTime>(
                name: "BookingTime",
                table: "RoomBookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 10, 0, 53, 56, 227, DateTimeKind.Local).AddTicks(2130),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 5, 0, 43, 0, 755, DateTimeKind.Local).AddTicks(6852));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "Feedbacks",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 10, 0, 53, 56, 227, DateTimeKind.Local).AddTicks(4887),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 5, 0, 43, 0, 756, DateTimeKind.Local).AddTicks(680));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Feedbacks",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 10, 0, 53, 56, 227, DateTimeKind.Local).AddTicks(4781),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 5, 0, 43, 0, 756, DateTimeKind.Local).AddTicks(533));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Bills",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 10, 0, 53, 56, 227, DateTimeKind.Local).AddTicks(5667),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 5, 0, 43, 0, 756, DateTimeKind.Local).AddTicks(1778));

            migrationBuilder.UpdateData(
                table: "Bills",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2022, 10, 10, 0, 53, 56, 231, DateTimeKind.Local).AddTicks(8230));

            migrationBuilder.UpdateData(
                table: "Bills",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2022, 10, 10, 0, 53, 56, 231, DateTimeKind.Local).AddTicks(8232));

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2022, 10, 10, 0, 53, 56, 231, DateTimeKind.Local).AddTicks(8213), new DateTime(2022, 10, 10, 0, 53, 56, 231, DateTimeKind.Local).AddTicks(8215) });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2022, 10, 10, 0, 53, 56, 231, DateTimeKind.Local).AddTicks(8217), new DateTime(2022, 10, 10, 0, 53, 56, 231, DateTimeKind.Local).AddTicks(8217) });

            migrationBuilder.UpdateData(
                table: "RoomBookings",
                keyColumns: new[] { "BillId", "RoomId" },
                keyValues: new object[] { 1, 1 },
                column: "BookingTime",
                value: new DateTime(2022, 10, 10, 0, 53, 56, 231, DateTimeKind.Local).AddTicks(8249));

            migrationBuilder.UpdateData(
                table: "RoomBookings",
                keyColumns: new[] { "BillId", "RoomId" },
                keyValues: new object[] { 1, 3 },
                column: "BookingTime",
                value: new DateTime(2022, 10, 10, 0, 53, 56, 231, DateTimeKind.Local).AddTicks(8251));

            migrationBuilder.UpdateData(
                table: "RoomBookings",
                keyColumns: new[] { "BillId", "RoomId" },
                keyValues: new object[] { 2, 4 },
                column: "BookingTime",
                value: new DateTime(2022, 10, 10, 0, 53, 56, 231, DateTimeKind.Local).AddTicks(8252));

            migrationBuilder.UpdateData(
                table: "RoomCategories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "Image", "UpdatedTime" },
                values: new object[] { new DateTime(2022, 10, 10, 0, 53, 56, 227, DateTimeKind.Local).AddTicks(6898), "phong-1-giuong.jpg", new DateTime(2022, 10, 10, 0, 53, 56, 227, DateTimeKind.Local).AddTicks(6898) });

            migrationBuilder.UpdateData(
                table: "RoomCategories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "Image", "UpdatedTime" },
                values: new object[] { new DateTime(2022, 10, 10, 0, 53, 56, 227, DateTimeKind.Local).AddTicks(6899), "phong-2-giuong.jpg", new DateTime(2022, 10, 10, 0, 53, 56, 227, DateTimeKind.Local).AddTicks(6899) });

            migrationBuilder.UpdateData(
                table: "RoomImages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2022, 10, 10, 0, 53, 56, 231, DateTimeKind.Local).AddTicks(8280));

            migrationBuilder.UpdateData(
                table: "RoomImages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2022, 10, 10, 0, 53, 56, 231, DateTimeKind.Local).AddTicks(8281));

            migrationBuilder.UpdateData(
                table: "RoomImages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2022, 10, 10, 0, 53, 56, 231, DateTimeKind.Local).AddTicks(8282));

            migrationBuilder.UpdateData(
                table: "RoomImages",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedTime",
                value: new DateTime(2022, 10, 10, 0, 53, 56, 231, DateTimeKind.Local).AddTicks(8290));

            migrationBuilder.UpdateData(
                table: "RoomImages",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedTime",
                value: new DateTime(2022, 10, 10, 0, 53, 56, 231, DateTimeKind.Local).AddTicks(8291));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2022, 10, 10, 0, 53, 56, 227, DateTimeKind.Local).AddTicks(6813), new DateTime(2022, 10, 10, 0, 53, 56, 227, DateTimeKind.Local).AddTicks(6814) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2022, 10, 10, 0, 53, 56, 227, DateTimeKind.Local).AddTicks(6815), new DateTime(2022, 10, 10, 0, 53, 56, 227, DateTimeKind.Local).AddTicks(6815) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2022, 10, 10, 0, 53, 56, 227, DateTimeKind.Local).AddTicks(6816), new DateTime(2022, 10, 10, 0, 53, 56, 227, DateTimeKind.Local).AddTicks(6817) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2022, 10, 10, 0, 53, 56, 227, DateTimeKind.Local).AddTicks(6818), new DateTime(2022, 10, 10, 0, 53, 56, 227, DateTimeKind.Local).AddTicks(6818) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2022, 10, 10, 0, 53, 56, 227, DateTimeKind.Local).AddTicks(6819), new DateTime(2022, 10, 10, 0, 53, 56, 227, DateTimeKind.Local).AddTicks(6819) });

            migrationBuilder.UpdateData(
                table: "ServiceBookings",
                keyColumns: new[] { "BillId", "ServiceId" },
                keyValues: new object[] { 1, 1 },
                column: "BookingTime",
                value: new DateTime(2022, 10, 10, 0, 53, 56, 231, DateTimeKind.Local).AddTicks(8267));

            migrationBuilder.UpdateData(
                table: "ServiceBookings",
                keyColumns: new[] { "BillId", "ServiceId" },
                keyValues: new object[] { 1, 2 },
                column: "BookingTime",
                value: new DateTime(2022, 10, 10, 0, 53, 56, 231, DateTimeKind.Local).AddTicks(8268));

            migrationBuilder.UpdateData(
                table: "ServiceBookings",
                keyColumns: new[] { "BillId", "ServiceId" },
                keyValues: new object[] { 2, 1 },
                column: "BookingTime",
                value: new DateTime(2022, 10, 10, 0, 53, 56, 231, DateTimeKind.Local).AddTicks(8269));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2022, 10, 10, 0, 53, 56, 227, DateTimeKind.Local).AddTicks(6910), new DateTime(2022, 10, 10, 0, 53, 56, 227, DateTimeKind.Local).AddTicks(6911) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2022, 10, 10, 0, 53, 56, 227, DateTimeKind.Local).AddTicks(6912), new DateTime(2022, 10, 10, 0, 53, 56, 227, DateTimeKind.Local).AddTicks(6912) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2022, 10, 10, 0, 53, 56, 227, DateTimeKind.Local).AddTicks(6913), new DateTime(2022, 10, 10, 0, 53, 56, 227, DateTimeKind.Local).AddTicks(6913) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("372ea575-2536-4076-9bab-3e3138de495f"),
                columns: new[] { "ConcurrencyStamp", "Password" },
                values: new object[] { "b8da8d92-f879-4401-a122-4cd0050c2027", "AQAAAAEAACcQAAAAEIxHTJC7YzYwnWCrBDkCdgtflvjQW0thLARaY/MdB7NbIfp3R1ZvmwQgh8/BpXfFOw==" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("51b4b238-4ae0-4e46-a3f4-e0acf7666b15"),
                columns: new[] { "ConcurrencyStamp", "Password" },
                values: new object[] { "aa66c99b-968e-4e5f-95c3-f740912421b6", "AQAAAAEAACcQAAAAEAlAtIqZQ1lCcfnX1cCryOZwM8LlAPfBUl9HofeqsQuZT1ElBkyhYCnuHgXEJI5asg==" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("8a820adb-93d7-4c6f-9404-bdbfc14419f4"),
                columns: new[] { "ConcurrencyStamp", "Password" },
                values: new object[] { "aaa7a42a-2ff0-4990-8c02-a496ef187c12", "AQAAAAEAACcQAAAAEFfR+YLTBFlmHT1mPFYEztSn4jRzpb4BJmkrXZDRi9EHLEpMMZGzXbzuVetHXnCrBw==" });

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "Id",
                keyValue: new Guid("8f7579ee-4af9-4b71-9ada-7f792f76dc31"),
                column: "ConcurrencyStamp",
                value: "f8f5846a-5a9f-4ea4-af32-ebdb89e0043e");

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "Id",
                keyValue: new Guid("9e87b492-5343-4272-9a34-fa5de7cffb22"),
                column: "ConcurrencyStamp",
                value: "bff65df9-7568-4830-a088-a6e6d75515a7");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "RoomCategories");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "User",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 5, 0, 43, 0, 755, DateTimeKind.Local).AddTicks(5748),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 10, 0, 53, 56, 227, DateTimeKind.Local).AddTicks(1416));

            migrationBuilder.AlterColumn<DateTime>(
                name: "RegisteredTime",
                table: "User",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 5, 0, 43, 0, 755, DateTimeKind.Local).AddTicks(5581),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 10, 0, 53, 56, 227, DateTimeKind.Local).AddTicks(1270));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "Services",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 5, 0, 43, 0, 755, DateTimeKind.Local).AddTicks(4754),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 10, 0, 53, 56, 227, DateTimeKind.Local).AddTicks(729));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Services",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 5, 0, 43, 0, 755, DateTimeKind.Local).AddTicks(4609),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 10, 0, 53, 56, 227, DateTimeKind.Local).AddTicks(625));

            migrationBuilder.AlterColumn<DateTime>(
                name: "BookingTime",
                table: "ServiceBookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 5, 0, 43, 0, 755, DateTimeKind.Local).AddTicks(8797),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 10, 0, 53, 56, 227, DateTimeKind.Local).AddTicks(3610));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "Rooms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 5, 0, 43, 0, 755, DateTimeKind.Local).AddTicks(3369),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 10, 0, 53, 56, 226, DateTimeKind.Local).AddTicks(9561));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Rooms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 5, 0, 43, 0, 755, DateTimeKind.Local).AddTicks(3213),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 10, 0, 53, 56, 226, DateTimeKind.Local).AddTicks(9453));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "RoomImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 5, 0, 43, 0, 756, DateTimeKind.Local).AddTicks(1356),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 10, 0, 53, 56, 227, DateTimeKind.Local).AddTicks(5400));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "RoomImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 5, 0, 43, 0, 756, DateTimeKind.Local).AddTicks(1208),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 10, 0, 53, 56, 227, DateTimeKind.Local).AddTicks(5263));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "RoomCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 5, 0, 43, 0, 755, DateTimeKind.Local).AddTicks(4025),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 10, 0, 53, 56, 227, DateTimeKind.Local).AddTicks(193));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "RoomCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 5, 0, 43, 0, 755, DateTimeKind.Local).AddTicks(3889),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 10, 0, 53, 56, 227, DateTimeKind.Local).AddTicks(88));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckOutDate",
                table: "RoomBookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 5, 0, 43, 0, 755, DateTimeKind.Local).AddTicks(6722),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 10, 0, 53, 56, 227, DateTimeKind.Local).AddTicks(2043));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckInDate",
                table: "RoomBookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 5, 0, 43, 0, 755, DateTimeKind.Local).AddTicks(6591),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 10, 0, 53, 56, 227, DateTimeKind.Local).AddTicks(1955));

            migrationBuilder.AlterColumn<DateTime>(
                name: "BookingTime",
                table: "RoomBookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 5, 0, 43, 0, 755, DateTimeKind.Local).AddTicks(6852),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 10, 0, 53, 56, 227, DateTimeKind.Local).AddTicks(2130));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "Feedbacks",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 5, 0, 43, 0, 756, DateTimeKind.Local).AddTicks(680),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 10, 0, 53, 56, 227, DateTimeKind.Local).AddTicks(4887));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Feedbacks",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 5, 0, 43, 0, 756, DateTimeKind.Local).AddTicks(533),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 10, 0, 53, 56, 227, DateTimeKind.Local).AddTicks(4781));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Bills",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 5, 0, 43, 0, 756, DateTimeKind.Local).AddTicks(1778),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 10, 0, 53, 56, 227, DateTimeKind.Local).AddTicks(5667));

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
    }
}
