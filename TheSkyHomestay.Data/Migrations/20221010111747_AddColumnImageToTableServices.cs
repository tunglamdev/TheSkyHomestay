using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TheSkyHomestay.Data.Migrations
{
    public partial class AddColumnImageToTableServices : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "User",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 10, 18, 17, 46, 456, DateTimeKind.Local).AddTicks(8584),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 10, 0, 53, 56, 227, DateTimeKind.Local).AddTicks(1416));

            migrationBuilder.AlterColumn<DateTime>(
                name: "RegisteredTime",
                table: "User",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 10, 18, 17, 46, 456, DateTimeKind.Local).AddTicks(8448),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 10, 0, 53, 56, 227, DateTimeKind.Local).AddTicks(1270));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "Services",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 10, 18, 17, 46, 456, DateTimeKind.Local).AddTicks(7812),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 10, 0, 53, 56, 227, DateTimeKind.Local).AddTicks(729));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Services",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 10, 18, 17, 46, 456, DateTimeKind.Local).AddTicks(7721),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 10, 0, 53, 56, 227, DateTimeKind.Local).AddTicks(625));

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Services",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "default.jpg");

            migrationBuilder.AlterColumn<DateTime>(
                name: "BookingTime",
                table: "ServiceBookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 10, 18, 17, 46, 457, DateTimeKind.Local).AddTicks(628),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 10, 0, 53, 56, 227, DateTimeKind.Local).AddTicks(3610));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "Rooms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 10, 18, 17, 46, 456, DateTimeKind.Local).AddTicks(6514),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 10, 0, 53, 56, 226, DateTimeKind.Local).AddTicks(9561));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Rooms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 10, 18, 17, 46, 456, DateTimeKind.Local).AddTicks(6380),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 10, 0, 53, 56, 226, DateTimeKind.Local).AddTicks(9453));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "RoomImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 10, 18, 17, 46, 457, DateTimeKind.Local).AddTicks(2490),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 10, 0, 53, 56, 227, DateTimeKind.Local).AddTicks(5400));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "RoomImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 10, 18, 17, 46, 457, DateTimeKind.Local).AddTicks(2382),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 10, 0, 53, 56, 227, DateTimeKind.Local).AddTicks(5263));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "RoomCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 10, 18, 17, 46, 456, DateTimeKind.Local).AddTicks(7154),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 10, 0, 53, 56, 227, DateTimeKind.Local).AddTicks(193));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "RoomCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 10, 18, 17, 46, 456, DateTimeKind.Local).AddTicks(7053),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 10, 0, 53, 56, 227, DateTimeKind.Local).AddTicks(88));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckOutDate",
                table: "RoomBookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 10, 18, 17, 46, 456, DateTimeKind.Local).AddTicks(9237),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 10, 0, 53, 56, 227, DateTimeKind.Local).AddTicks(2043));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckInDate",
                table: "RoomBookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 10, 18, 17, 46, 456, DateTimeKind.Local).AddTicks(9139),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 10, 0, 53, 56, 227, DateTimeKind.Local).AddTicks(1955));

            migrationBuilder.AlterColumn<DateTime>(
                name: "BookingTime",
                table: "RoomBookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 10, 18, 17, 46, 456, DateTimeKind.Local).AddTicks(9329),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 10, 0, 53, 56, 227, DateTimeKind.Local).AddTicks(2130));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "Feedbacks",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 10, 18, 17, 46, 457, DateTimeKind.Local).AddTicks(1964),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 10, 0, 53, 56, 227, DateTimeKind.Local).AddTicks(4887));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Feedbacks",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 10, 18, 17, 46, 457, DateTimeKind.Local).AddTicks(1852),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 10, 0, 53, 56, 227, DateTimeKind.Local).AddTicks(4781));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Bills",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 10, 18, 17, 46, 457, DateTimeKind.Local).AddTicks(2865),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 10, 0, 53, 56, 227, DateTimeKind.Local).AddTicks(5667));

            migrationBuilder.UpdateData(
                table: "Bills",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2022, 10, 10, 18, 17, 46, 462, DateTimeKind.Local).AddTicks(523));

            migrationBuilder.UpdateData(
                table: "Bills",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2022, 10, 10, 18, 17, 46, 462, DateTimeKind.Local).AddTicks(525));

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2022, 10, 10, 18, 17, 46, 462, DateTimeKind.Local).AddTicks(494), new DateTime(2022, 10, 10, 18, 17, 46, 462, DateTimeKind.Local).AddTicks(498) });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2022, 10, 10, 18, 17, 46, 462, DateTimeKind.Local).AddTicks(502), new DateTime(2022, 10, 10, 18, 17, 46, 462, DateTimeKind.Local).AddTicks(503) });

            migrationBuilder.UpdateData(
                table: "RoomBookings",
                keyColumns: new[] { "BillId", "RoomId" },
                keyValues: new object[] { 1, 1 },
                column: "BookingTime",
                value: new DateTime(2022, 10, 10, 18, 17, 46, 462, DateTimeKind.Local).AddTicks(548));

            migrationBuilder.UpdateData(
                table: "RoomBookings",
                keyColumns: new[] { "BillId", "RoomId" },
                keyValues: new object[] { 1, 3 },
                column: "BookingTime",
                value: new DateTime(2022, 10, 10, 18, 17, 46, 462, DateTimeKind.Local).AddTicks(550));

            migrationBuilder.UpdateData(
                table: "RoomBookings",
                keyColumns: new[] { "BillId", "RoomId" },
                keyValues: new object[] { 2, 4 },
                column: "BookingTime",
                value: new DateTime(2022, 10, 10, 18, 17, 46, 462, DateTimeKind.Local).AddTicks(552));

            migrationBuilder.UpdateData(
                table: "RoomCategories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2022, 10, 10, 18, 17, 46, 457, DateTimeKind.Local).AddTicks(4424), new DateTime(2022, 10, 10, 18, 17, 46, 457, DateTimeKind.Local).AddTicks(4424) });

            migrationBuilder.UpdateData(
                table: "RoomCategories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2022, 10, 10, 18, 17, 46, 457, DateTimeKind.Local).AddTicks(4425), new DateTime(2022, 10, 10, 18, 17, 46, 457, DateTimeKind.Local).AddTicks(4426) });

            migrationBuilder.UpdateData(
                table: "RoomImages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2022, 10, 10, 18, 17, 46, 462, DateTimeKind.Local).AddTicks(579));

            migrationBuilder.UpdateData(
                table: "RoomImages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2022, 10, 10, 18, 17, 46, 462, DateTimeKind.Local).AddTicks(580));

            migrationBuilder.UpdateData(
                table: "RoomImages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2022, 10, 10, 18, 17, 46, 462, DateTimeKind.Local).AddTicks(581));

            migrationBuilder.UpdateData(
                table: "RoomImages",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedTime",
                value: new DateTime(2022, 10, 10, 18, 17, 46, 462, DateTimeKind.Local).AddTicks(582));

            migrationBuilder.UpdateData(
                table: "RoomImages",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedTime",
                value: new DateTime(2022, 10, 10, 18, 17, 46, 462, DateTimeKind.Local).AddTicks(583));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2022, 10, 10, 18, 17, 46, 457, DateTimeKind.Local).AddTicks(4324), new DateTime(2022, 10, 10, 18, 17, 46, 457, DateTimeKind.Local).AddTicks(4326) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2022, 10, 10, 18, 17, 46, 457, DateTimeKind.Local).AddTicks(4328), new DateTime(2022, 10, 10, 18, 17, 46, 457, DateTimeKind.Local).AddTicks(4328) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2022, 10, 10, 18, 17, 46, 457, DateTimeKind.Local).AddTicks(4329), new DateTime(2022, 10, 10, 18, 17, 46, 457, DateTimeKind.Local).AddTicks(4330) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2022, 10, 10, 18, 17, 46, 457, DateTimeKind.Local).AddTicks(4331), new DateTime(2022, 10, 10, 18, 17, 46, 457, DateTimeKind.Local).AddTicks(4332) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2022, 10, 10, 18, 17, 46, 457, DateTimeKind.Local).AddTicks(4334), new DateTime(2022, 10, 10, 18, 17, 46, 457, DateTimeKind.Local).AddTicks(4335) });

            migrationBuilder.UpdateData(
                table: "ServiceBookings",
                keyColumns: new[] { "BillId", "ServiceId" },
                keyValues: new object[] { 1, 1 },
                column: "BookingTime",
                value: new DateTime(2022, 10, 10, 18, 17, 46, 462, DateTimeKind.Local).AddTicks(564));

            migrationBuilder.UpdateData(
                table: "ServiceBookings",
                keyColumns: new[] { "BillId", "ServiceId" },
                keyValues: new object[] { 1, 2 },
                column: "BookingTime",
                value: new DateTime(2022, 10, 10, 18, 17, 46, 462, DateTimeKind.Local).AddTicks(566));

            migrationBuilder.UpdateData(
                table: "ServiceBookings",
                keyColumns: new[] { "BillId", "ServiceId" },
                keyValues: new object[] { 2, 1 },
                column: "BookingTime",
                value: new DateTime(2022, 10, 10, 18, 17, 46, 462, DateTimeKind.Local).AddTicks(567));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2022, 10, 10, 18, 17, 46, 457, DateTimeKind.Local).AddTicks(4438), new DateTime(2022, 10, 10, 18, 17, 46, 457, DateTimeKind.Local).AddTicks(4439) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2022, 10, 10, 18, 17, 46, 457, DateTimeKind.Local).AddTicks(4440), new DateTime(2022, 10, 10, 18, 17, 46, 457, DateTimeKind.Local).AddTicks(4440) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2022, 10, 10, 18, 17, 46, 457, DateTimeKind.Local).AddTicks(4441), new DateTime(2022, 10, 10, 18, 17, 46, 457, DateTimeKind.Local).AddTicks(4441) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("372ea575-2536-4076-9bab-3e3138de495f"),
                columns: new[] { "ConcurrencyStamp", "Password" },
                values: new object[] { "a66b67e1-a674-444e-9807-fae6a7fc6caa", "AQAAAAEAACcQAAAAEDIHUr9WQUiDTPxIRmESVCpXqeMwfQLxEXZJsPvUKzZAz6sKc2cw5aI9PEbozWAzSQ==" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("51b4b238-4ae0-4e46-a3f4-e0acf7666b15"),
                columns: new[] { "ConcurrencyStamp", "Password" },
                values: new object[] { "f8619df2-ef2a-42a0-8a89-5a024137d9a2", "AQAAAAEAACcQAAAAEA77MOwgzcvT5vdqEJeB81MiHlMl7MD5O2wj+pys14Jjhj4co4GuergCMfNRIU2FRg==" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("8a820adb-93d7-4c6f-9404-bdbfc14419f4"),
                columns: new[] { "ConcurrencyStamp", "Password" },
                values: new object[] { "6377e711-df82-4d05-9e2a-7dec0e0c650a", "AQAAAAEAACcQAAAAEAVPxc2tgeM10YzxOrtZgFd1TpqgsdrQG/hzpwTr2nO6/5N+AAuqQ9bNEioDBDbTSg==" });

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "Id",
                keyValue: new Guid("8f7579ee-4af9-4b71-9ada-7f792f76dc31"),
                column: "ConcurrencyStamp",
                value: "f6e32b72-f878-4895-8917-a77722b2ac21");

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "Id",
                keyValue: new Guid("9e87b492-5343-4272-9a34-fa5de7cffb22"),
                column: "ConcurrencyStamp",
                value: "150f44a2-4ada-49dd-a69a-68858e565520");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "Services");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "User",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 10, 0, 53, 56, 227, DateTimeKind.Local).AddTicks(1416),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 10, 18, 17, 46, 456, DateTimeKind.Local).AddTicks(8584));

            migrationBuilder.AlterColumn<DateTime>(
                name: "RegisteredTime",
                table: "User",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 10, 0, 53, 56, 227, DateTimeKind.Local).AddTicks(1270),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 10, 18, 17, 46, 456, DateTimeKind.Local).AddTicks(8448));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "Services",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 10, 0, 53, 56, 227, DateTimeKind.Local).AddTicks(729),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 10, 18, 17, 46, 456, DateTimeKind.Local).AddTicks(7812));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Services",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 10, 0, 53, 56, 227, DateTimeKind.Local).AddTicks(625),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 10, 18, 17, 46, 456, DateTimeKind.Local).AddTicks(7721));

            migrationBuilder.AlterColumn<DateTime>(
                name: "BookingTime",
                table: "ServiceBookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 10, 0, 53, 56, 227, DateTimeKind.Local).AddTicks(3610),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 10, 18, 17, 46, 457, DateTimeKind.Local).AddTicks(628));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "Rooms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 10, 0, 53, 56, 226, DateTimeKind.Local).AddTicks(9561),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 10, 18, 17, 46, 456, DateTimeKind.Local).AddTicks(6514));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Rooms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 10, 0, 53, 56, 226, DateTimeKind.Local).AddTicks(9453),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 10, 18, 17, 46, 456, DateTimeKind.Local).AddTicks(6380));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "RoomImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 10, 0, 53, 56, 227, DateTimeKind.Local).AddTicks(5400),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 10, 18, 17, 46, 457, DateTimeKind.Local).AddTicks(2490));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "RoomImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 10, 0, 53, 56, 227, DateTimeKind.Local).AddTicks(5263),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 10, 18, 17, 46, 457, DateTimeKind.Local).AddTicks(2382));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "RoomCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 10, 0, 53, 56, 227, DateTimeKind.Local).AddTicks(193),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 10, 18, 17, 46, 456, DateTimeKind.Local).AddTicks(7154));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "RoomCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 10, 0, 53, 56, 227, DateTimeKind.Local).AddTicks(88),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 10, 18, 17, 46, 456, DateTimeKind.Local).AddTicks(7053));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckOutDate",
                table: "RoomBookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 10, 0, 53, 56, 227, DateTimeKind.Local).AddTicks(2043),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 10, 18, 17, 46, 456, DateTimeKind.Local).AddTicks(9237));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckInDate",
                table: "RoomBookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 10, 0, 53, 56, 227, DateTimeKind.Local).AddTicks(1955),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 10, 18, 17, 46, 456, DateTimeKind.Local).AddTicks(9139));

            migrationBuilder.AlterColumn<DateTime>(
                name: "BookingTime",
                table: "RoomBookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 10, 0, 53, 56, 227, DateTimeKind.Local).AddTicks(2130),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 10, 18, 17, 46, 456, DateTimeKind.Local).AddTicks(9329));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "Feedbacks",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 10, 0, 53, 56, 227, DateTimeKind.Local).AddTicks(4887),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 10, 18, 17, 46, 457, DateTimeKind.Local).AddTicks(1964));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Feedbacks",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 10, 0, 53, 56, 227, DateTimeKind.Local).AddTicks(4781),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 10, 18, 17, 46, 457, DateTimeKind.Local).AddTicks(1852));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Bills",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 10, 0, 53, 56, 227, DateTimeKind.Local).AddTicks(5667),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 10, 18, 17, 46, 457, DateTimeKind.Local).AddTicks(2865));

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
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2022, 10, 10, 0, 53, 56, 227, DateTimeKind.Local).AddTicks(6898), new DateTime(2022, 10, 10, 0, 53, 56, 227, DateTimeKind.Local).AddTicks(6898) });

            migrationBuilder.UpdateData(
                table: "RoomCategories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2022, 10, 10, 0, 53, 56, 227, DateTimeKind.Local).AddTicks(6899), new DateTime(2022, 10, 10, 0, 53, 56, 227, DateTimeKind.Local).AddTicks(6899) });

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
    }
}
